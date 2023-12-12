using System;
using Ophthalmology.DataAccess.OleDb;
using Ophthalmology.Entity.Database;
using Ophthalmology.UI.Win.Classes;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using BehComponents;
using Ophthalmology.Entity.Entites;
using Ophthalmology.Entity.Enums;
using Ophthalmology.Utility.Helpers;
using Ophthalmology.Controls;

namespace Ophthalmology.UI.Win.Forms
{
    public partial class VisitListForm : CustomizableForm
    {
        #region ~( Constructors )~

        public VisitListForm()
        {
            InitializeComponent();

            Text += $" - {MyApplication.DrName}";
            customGridEx1.MergeMenu(contextMenuRightClick);
            //timerLoad.Enabled = true;
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
            var visitLists = DatabaseHelper.Select<CustomerVisit>(tableName, selectFields, whereClauses, "C.Id DESC");

            var script = $@"
                SELECT Count(*) AS VisitedCount, V.Status AS Status
                  FROM VisitList V 
                 WHERE V.DateVisit = '{date}' 
                   AND V.DrId = {MyApplication.DrId}
                 GROUP BY V.Status;
            ";
            var dataTable = DatabaseHelper.SelectRawQuery(script);
            var visitedCount = 0;
            var notVisitedCount = 0;
            foreach (DataRow dataRow in dataTable.Rows)
            {
                var count = dataRow[0].ToString();
                var status = dataRow[1].ToString();

                if (status == "ویزیت شده" || status == "اپتومتری")
                {
                    visitedCount += int.Parse(count);
                }
                else if (status == "ویزیت نشده")
                {
                    notVisitedCount += int.Parse(count);
                }
            }

            labelTotalCount.Text = visitLists.Count.ToString();
            labelVisitedCount.Text = visitedCount.ToString();
            labelNotVisitedCount.Text = notVisitedCount.ToString();

            bindingSourceVisitList.DataSource = new List<CustomerVisit>();
            bindingSourceVisitList.DataSource = visitLists;
            bindingSourceVisitList.ResetBindings(true);
        }

        private void OldVisit()
        {
            var oldVisitForm = new OldVisitForm();
            oldVisitForm.ShowDialog(this);
        }

        private void LightPenVisit()
        {
            var lightPenVisitForm = new LightPenVisitForm();
            lightPenVisitForm.ShowDialog(this);
        }

        private void TextVisit()
        {
            var visitForm = new VisitForm();
            visitForm.ShowDialog(this);
        }

        private void DeleteCurrentRecord()
        {
            var personName = CurrentVisit.ToString();

            var result = MsgBox.ShowYesNo($"آیا از حذف ویزیت '{personName}' اطمینان دارید؟", "حذف ویزیت بیمار", MessageBoxIcon.Warning);
            if (result != DialogResult.Yes)
                return;

            var recordLastPosition = bindingSourceVisitList.Position;
            if (recordLastPosition <= 0)
                recordLastPosition = 0;

            if (recordLastPosition > 0)
                recordLastPosition--;

            var whereClauses = new List<IWhereClause> { new WhereClause("Id", CurrentVisit.Id, "Id") };
            var rows = DatabaseHelper.Delete("VisitList", whereClauses);
            var text = rows > 0 ? $"ویزیت '{personName}' با موفقیت حذف شد" : $"ویزیت '{personName}' حذف نشد";
            MsgBox.ShowInformation(text, "حذف ویزیت بیمار");
            dateTimePickerX1_SelectedDateChanged(dateTimePickerX1.GetSelectedDateInDateTime(), new PersianDateTime(DateTime.Now));

            bindingSourceVisitList.Position = recordLastPosition;
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

        private void dateTimePickerX1_SelectedDateChanged(DateTime selectedDateTime, PersianDateTime selectedPersianDateTime)
        {
            var date = selectedDateTime.ToString("yyyy/MM/dd", CultureHelper.PersianCulture);
            LoadVisitList(date);
        }

        private void buttonOldVisit_Click(object sender, EventArgs e)
        {
            OldVisit();
        }

        private void buttonPenVisit_Click(object sender, EventArgs e)
        {
            LightPenVisit();
        }

        private void buttonTextVisit_Click(object sender, EventArgs e)
        {
            TextVisit();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DeleteCurrentRecord();
        }

        private void menuItemOldVisit_Click(object sender, EventArgs e)
        {
            OldVisit();
        }

        private void menuItemPenVisit_Click(object sender, EventArgs e)
        {
            LightPenVisit();
        }

        private void menuItemTextVisit_Click(object sender, EventArgs e)
        {
            TextVisit();
        }

        private void menuItemDelete_Click(object sender, EventArgs e)
        {
            DeleteCurrentRecord();
        }

        private void timerLoad_Tick(object sender, EventArgs e)
        {
            dateTimePickerX1_SelectedDateChanged(DateTime.Now, new PersianDateTime(DateTime.Now));
        }

        #endregion

        #region ~( Properties )~

        private CustomerVisit CurrentVisit => (CustomerVisit)bindingSourceVisitList.Current;

        #endregion
    }
}