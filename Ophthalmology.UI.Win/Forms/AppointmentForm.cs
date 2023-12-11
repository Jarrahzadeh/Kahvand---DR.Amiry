using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Janus.Windows.GridEX;
using Ophthalmology.DataAccess.OleDb;
using Ophthalmology.Entity.Database;
using Ophthalmology.Entity.Entites;
using Ophthalmology.Entity.Enums;
using Ophthalmology.UI.Win.Classes;
using Ophthalmology.Utility.Helpers;

namespace Ophthalmology.UI.Win.Forms
{
    public partial class AppointmentForm : CustomizableForm
    {
        #region ~( Fields )~

        private readonly string _customerFullName;

        #endregion

        #region ~( Constructors )~

        private AppointmentForm()
        {
            InitializeComponent();
            Text += $" - {MyApplication.DrName}";
        }

        public AppointmentForm(string customerFullName, IList<Customer> customers) : this()
        {
            _customerFullName = customerFullName;
            bindingSourceCustomers.DataSource = customers;
        }

        #endregion

        #region ~( Methods )~

        private void FillControls()
        {
            maskedBoxTime.Text = DateTime.Now.ToString("t");
            dateTimePickerVisitDate.SetSelectedDate(DateTime.Now);
            var customer = (Customer)multiColumnComboCustomer.SelectedItem;
            if (customer != null)
            {
                var firstOrDefault = MyApplication.TypePatients.FirstOrDefault(x => x.Id == customer.IdTypePatient);
                textBoxPrice.Text = firstOrDefault?.Price;
            }

            LoadVisitList(dateTimePickerVisitList.SelectedDateInStringPersian);
        }

        private void LoadVisitList(string date)
        {
            var whereClauses = new List<IWhereClause>
            {
                new WhereClause("V.DrId", MyApplication.DrId, "DrId" ,LogicalOperatorType.And),
                new WhereClause("V.DateVisit", date, "DateVisit")
            };

            var tableName = "Customer C INNER JOIN VisitList V ON (C.Id = V.Code_Customer)";
            var selectFields = "V.Id, C.Id AS CustomerId, C.Name, C.Family, C.Tel, C.DateSave, V.TimeVisit, V.Status, V.Price, V.OrderId";
            var visitLists = DatabaseHelper.Select<VisitList>(tableName, selectFields, whereClauses, "C.Id DESC");
            
            bindingSourceVisitList.DataSource = new List<VisitList>();
            bindingSourceVisitList.DataSource = visitLists;
            bindingSourceVisitList.ResetBindings(true);
        }

        #endregion

        #region ~( Event Handlers )~

        private void AppointmentForm_Shown(object sender, EventArgs e)
        {
            multiColumnComboCustomer.Value = _customerFullName;
        }

        private void multiColumnCombo1_TextChanged(object sender, EventArgs e)
        {
            multiColumnComboCustomer.DroppedDown = multiColumnComboCustomer.Text.Length > 0;
        }

        private void multiColumnCombo1_ValueChanged(object sender, EventArgs e)
        {
            var column = multiColumnComboCustomer.DropDownList.Columns[0];
            multiColumnComboCustomer.DropDownList.ApplyFilter(new GridEXFilterCondition(column, ConditionOperator.BeginsWith, multiColumnComboCustomer.Text));
            FillControls();
        }

        private void dateTimePickerVisitList_SelectedDateChanged(DateTime selectedDateTime, BehComponents.PersianDateTime selectedPersianDateTime)
        {
            var date = selectedDateTime.ToString("yyyy/MM/dd", CultureHelper.PersianCulture);
            LoadVisitList(date);
        }

        #endregion
    }
}