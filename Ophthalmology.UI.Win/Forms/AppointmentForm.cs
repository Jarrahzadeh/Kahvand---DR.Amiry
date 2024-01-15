using System;
using System.Collections.Generic;
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
        private bool _firstTimeShow;

        #endregion

        #region ~( Constructors )~

        private AppointmentForm()
        {
            InitializeComponent();
            Text += $" - {MyApplication.DrName}";
            
            multiColumnComboCustomer.DropDownList.SelectionChanged += DropDownList_SelectionChanged;
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
            uiGroupBox2.Text = string.Format("تاریخچه مراجعه {0}", multiColumnComboCustomer.Text);
            uiGroupBox1.Text = string.Format(uiGroupBox1.Tag.ToString(), dateTimePickerVisitDate.Text);
            var customer = (Customer)multiColumnComboCustomer.SelectedItem;
            if (customer != null)
            {
                var firstOrDefault = MyApplication.TypePatients.FirstOrDefault(x => x.Id == customer.IdTypePatient);
                textBoxPrice.Text = firstOrDefault?.Price;
                LoadPersonVisitHistory(customer.Id);
            }
            else
            {
                LoadPersonVisitHistory(-1);
            }

            LoadVisitList(maskedBoxTime.Text);
        }

        private void LoadPersonVisitHistory(int customerId)
        {
            bindingSourceVisitHistory.DataSource = new List<CustomerVisit>();

            if (customerId == -1)
            {
                return;
            }

            var customerVisit = new CustomerVisit();
            var whereClauses = new List<IWhereClause>
            {
                new WhereClause("V.DrId", MyApplication.DrId, "DrId" ,LogicalOperatorType.And),
                new WhereClause("V.Code_Customer", customerId, "CustomerId")
            };

            var tableName = $"{customerVisit.TableName} V";
            var selectFields = "DISTINCT V.DateVisit AS DateSave, V.TimeVisit, V.Price";
            var visitLists = DatabaseHelper.Select<CustomerVisit>(tableName, selectFields, whereClauses, "V.DateVisit DESC");

            bindingSourceVisitHistory.DataSource = visitLists;
            bindingSourceVisitHistory.ResetBindings(true);
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
            var selectFields = "DISTINCT V.Id, V.DrId, C.Id AS CustomerId, C.Name, C.Family, C.Tel, C.DateSave, V.TimeVisit, V.Status, V.Price, V.OrderId";
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
            _firstTimeShow = true;
            multiColumnComboCustomer.Value = _customerFullName;
        }

        private void MultiColumnCombo1TextChanged(object sender, EventArgs e)
        {
            var droppedDown = multiColumnComboCustomer.Text.Length > 0;
            multiColumnComboCustomer.DroppedDown = droppedDown;
        }

        private void DropDownList_SelectionChanged(object sender, EventArgs e)
        {
            if (multiColumnComboCustomer.DropDownList.CurrentRow == null)
                return;

            var customer = (Customer)multiColumnComboCustomer.DropDownList.CurrentRow.DataRow;
            if (customer != null)
            {
                LoadPersonVisitHistory(customer.Id);
                uiGroupBox2.Text = string.Format("تاریخچه مراجعه {0}", customer);
            }
            else
            {
                LoadPersonVisitHistory(-1);
                uiGroupBox2.Text = string.Format("تاریخچه مراجعه {0}", string.Empty);
            }
        }

        private void MultiColumnCombo1ValueChanged(object sender, EventArgs e)
        {
            var column = multiColumnComboCustomer.DropDownList.Columns[0];
            multiColumnComboCustomer.DropDownList.ApplyFilter(new GridEXFilterCondition(column, ConditionOperator.BeginsWith, multiColumnComboCustomer.Text));
            FillControls();

            if (_firstTimeShow)
            {
                _firstTimeShow = false;
                multiColumnComboCustomer.SelectedIndex = 0;
            }
        }

        private void DateTimePickerVisitListSelectedDateChanged(DateTime selectedDateTime, BehComponents.PersianDateTime selectedPersianDateTime)
        {
            var date = selectedDateTime.ToPersianDate();
            uiGroupBox1.Text = string.Format(uiGroupBox1.Tag.ToString(), dateTimePickerVisitDate.Text);
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
        private void bindingSourceCustomers_PositionChanged(object sender, EventArgs e)
        {
            var customer = (Customer)bindingSourceCustomers.Current;
            if (customer != null)
                LoadPersonVisitHistory(customer.Id);
        }

        #endregion
    }
}