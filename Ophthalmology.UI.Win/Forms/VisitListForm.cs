using System;
using Ophthalmology.DataAccess.OleDb;
using Ophthalmology.Entity.Database;
using Ophthalmology.UI.Win.Classes;
using System.Collections.Generic;
using System.Windows.Forms;
using BehComponents;
using Ophthalmology.Entity.Entites;
using Ophthalmology.Entity.Enums;
using Ophthalmology.Utility.Helpers;

namespace Ophthalmology.UI.Win.Forms
{
    public partial class VisitListForm : CustomizableForm
    {
        #region ~( Constructors )~

        public VisitListForm()
        {
            InitializeComponent();

            Text += $" - {MyApplication.DrName}";
            customGridEx1.MergeMenu(contextMenuStrip1);
        }

        #endregion

        #region ~( Methods )~

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

        private void VisitListForm_Load(object sender, EventArgs e)
        {
            dateTimePickerX1.ClearDateTime();
            dateTimePickerX1.SetSelectedDate(DateTime.Now);
            dateTimePickerX1.SetTodayDate(DateTime.Now);
            dateTimePickerX1_SelectedDateChanged(DateTime.Now, new PersianDateTime(DateTime.Now));
        }

        #endregion

        #region ~( Properties )~



        #endregion

        private void dateTimePickerX1_SelectedDateChanged(DateTime selectedDateTime, BehComponents.PersianDateTime selectedPersianDateTime)
        {
            var date = selectedDateTime.ToString("yyyy/MM/dd", CultureHelper.PersianCulture);
            LoadVisitList(date);
        }

        private void buttonOldVisit_Click(object sender, EventArgs e)
        {
            MessageBox.Show(((Control)sender).Name);
        }

        private void buttonPenVisit_Click(object sender, EventArgs e)
        {
            MessageBox.Show(((Control)sender).Name);
        }

        private void buttonTextVisit_Click(object sender, EventArgs e)
        {
            MessageBox.Show(((Control)sender).Name);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show(((Control)sender).Name);
        }

        private void menuItemOldVisit_Click(object sender, EventArgs e)
        {
            MessageBox.Show(((System.Windows.Forms.ToolStripMenuItem)sender).Name);
        }

        private void menuItemPenVisit_Click(object sender, EventArgs e)
        {
            MessageBox.Show(((System.Windows.Forms.ToolStripMenuItem)sender).Name);
        }

        private void menuItemTextVisit_Click(object sender, EventArgs e)
        {
            MessageBox.Show(((System.Windows.Forms.ToolStripMenuItem)sender).Name);
        }

        private void menuItemDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show(((System.Windows.Forms.ToolStripMenuItem)sender).Name);
        }
    }
}