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
            var customerVisit = new CustomerVisit();
            var whereClauses = new List<IWhereClause>
            {
                new WhereClause("V.DrId", MyApplication.DrId, "DrId" ,LogicalOperatorType.And),
                new WhereClause("V.DateVisit", date, "DateVisit")
            };

            var tableName = $"Customer C INNER JOIN {customerVisit.TableName} V ON (C.Id = V.Code_Customer)";
            var selectFields = "V.Id, V.DrId, C.Id AS CustomerId, C.Name, C.Family, C.Tel, C.DateSave, V.TimeVisit, V.Status, V.Price, V.OrderId";
            var visitLists = DatabaseHelper.Select<CustomerVisit>(tableName, selectFields, whereClauses, "C.Id DESC");

            bindingSourceVisitList.DataSource = new List<CustomerVisit>();
            bindingSourceVisitList.DataSource = visitLists;
            bindingSourceVisitList.ResetBindings(true);
        }

        private void SendToOptometer(int visitItemId)
        {
            var whereClauses = new List<IWhereClause> { new WhereClause("VisitItemId", visitItemId, "VisitItemId") };
            var hasRecord = DatabaseHelper.TableHasRecord("SendTo", whereClauses);

            var filedNameAndValues = new List<IFieldValue>();

            if (hasRecord)
                DatabaseHelper.Update("SendTo", filedNameAndValues);
            else
                DatabaseHelper.Insert("SendTo", filedNameAndValues);
        }

        private void SendToDoctor(int visitItemId)
        {
            DatabaseHelper.Insert("SendTo", new List<IFieldValue>());
        }

        private void AddNewAppointment()
        {
            var customer = (Customer)multiColumnComboCustomer.SelectedItem;
            if (customer != null)
            {
                var customerVisit = new Visit
                {
                    CustomerId = customer.Id,
                    DateVisit = dateTimePickerVisitDate.SelectedDateInStringPersian,
                    DrId = MyApplication.DrId,
                    TimeVisit = maskedBoxTime.Text,
                    Price = int.Parse(textBoxPrice.Text), 
                    OrderId = 1,
                    Status = "ویزیت نشده"
                };

                var filedNameAndValues = (List<IFieldValue>)customerVisit;
                var rowEffected = DatabaseHelper.Insert(customerVisit.TableName, filedNameAndValues);
                if (rowEffected > 0)
                {
                    Ophthalmology.Controls.MsgBox.ShowInformation("نوبت با موفقیت ثبت گردید", "ثبت نوبت");
                    var date = dateTimePickerVisitDate.SelectedDateInStringPersian;
                    LoadVisitList(date);
                }
            }
        }

        #endregion

        #region ~( Event Handlers )~

        private void AppointmentForm_Shown(object sender, EventArgs e)
        {
            multiColumnComboCustomer.Value = _customerFullName;
        }

        private void MultiColumnCombo1TextChanged(object sender, EventArgs e)
        {
            multiColumnComboCustomer.DroppedDown = multiColumnComboCustomer.Text.Length > 0;
        }

        private void MultiColumnCombo1ValueChanged(object sender, EventArgs e)
        {
            var column = multiColumnComboCustomer.DropDownList.Columns[0];
            multiColumnComboCustomer.DropDownList.ApplyFilter(new GridEXFilterCondition(column, ConditionOperator.BeginsWith, multiColumnComboCustomer.Text));
            FillControls();
        }

        private void DateTimePickerVisitListSelectedDateChanged(DateTime selectedDateTime, BehComponents.PersianDateTime selectedPersianDateTime)
        {
            var date = selectedDateTime.ToString("yyyy/MM/dd", CultureHelper.PersianCulture);
            LoadVisitList(date);
        }

        private void GridColumnButtonClick(object sender, ColumnActionEventArgs e)
        {
            var gridExRow = customGridVisitList.GetRow();
            var visitItem = (CustomerVisit)gridExRow.DataRow;
            if (visitItem.SendTo == "ارسال به دکتر")
            {
                SendToDoctor(visitItem.Id);
            }
            else if (visitItem.SendTo == "ارسال به اپتومتر")
            {
                SendToOptometer(visitItem.Id);
            }
        }

        private void ButtonAddClick(object sender, EventArgs e)
        {
            AddNewAppointment();
        }

        #endregion
    }
}