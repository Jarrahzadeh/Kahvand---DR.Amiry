﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Janus.Windows.GridEX;
using Ophthalmology.Controls;
using Ophthalmology.DataAccess.OleDb;
using Ophthalmology.Entity.Database;
using Ophthalmology.Entity.Entites;
using Ophthalmology.Entity.Enums;
using Ophthalmology.UI.Win.Classes;
using Ophthalmology.UI.Win.Enums;

namespace Ophthalmology.UI.Win.Forms
{
    public partial class CustomersForm : CustomizableForm
    {
        #region ~( Fields )~

        private FormActionMode _formActionMode;
        private int _recordLastPosition;
        private bool _onLoadRecords;

        #endregion

        #region ~( Constructors )~

        public CustomersForm()
        {
            InitializeComponent();
            Text += $" - {MyApplication.DrName}";
            ChangeFormEnabled(false);
            _recordLastPosition = -1;
            _formActionMode = FormActionMode.None;
        }

        #endregion

        #region ~( Method )~

        private void LoadCustomers()
        {
            _onLoadRecords = true;
            var whereClauses = new List<IWhereClause>
            {
                new WhereClause("DrId", MyApplication.DrId, "DrId")
            };

            var customers = DatabaseHelper.Select<Customer>("Customer", whereClauses: whereClauses, sortOrder: "Id DESC");
            bindingSourceCustomers.DataSource = new List<Customer>();
            bindingSourceCustomers.DataSource = customers;
            bindingSourceCustomers.ResetBindings(true);
            _onLoadRecords = false;
        }

        private void LoadTypePatient()
        {
            var typePatients = DatabaseHelper.Select<TypePatient>("TypePatient");
            var typePatient = new TypePatient { Id = 0, Name = string.Empty };
            typePatients.Insert(0, typePatient);
            bindingSourceTypePatient.DataSource = typePatients;
        }

        private void ResetDateTimeBoxes()
        {
            dateTimePickerRegisterDate.ClearDateTime();
            dateTimePickerEyeRight.ClearDateTime();
            dateTimePickerEyeRight.Text = string.Empty;
            dateTimePickerEyeLeft.ClearDateTime();
            dateTimePickerEyeLeft.Text = string.Empty;
        }

        private void Save()
        {
            var rowEffected = -1;
            if (_formActionMode == FormActionMode.Add)
            {
                rowEffected = SaveNewCustomer();
                if (rowEffected > 0)
                    LoadCustomers();

                bindingSourceCustomers.Position = 0;
            }
            else if (_formActionMode == FormActionMode.Edit)
            {
                rowEffected = EditCustomer();
                LoadCustomers();
            }

            if (rowEffected > 0)
            {
                MsgBox.ShowInformation("اطلاعات بیمار با موفقیت ثبت گردید.", "ثبت جدید");
            }
            else if (rowEffected > -2)
            {
                MsgBox.ShowError("مشکلی در ثبت اطلاعات بیمار پیش آمده و عملیات انجام نگردید.", "ثبت جدید");
            }
            else if (rowEffected == -2)
            {
                Cancel();
            }
            else if (rowEffected == -3)
            {
                MsgBox.ShowWarning("لطفا مشخصات بیمار را بصورت صحیح وارد نمائید", "ثبت جدید");
                ActiveControl = textBoxName;
            }

            ChangeFormEnabled(false);
        }

        private void Cancel()
        {
            bindingSourceCustomers.CancelEdit();
            bindingSourceCustomers.Position = _recordLastPosition;
            _recordLastPosition = -1;

            ChangeFormEnabled(false);

            gridCustomers.Focus();

            _formActionMode = FormActionMode.None;
        }

        private int SaveNewCustomer()
        {
            if (string.IsNullOrWhiteSpace(CurrentCustomer.Name) || string.IsNullOrWhiteSpace(CurrentCustomer.Family))
                return -3;

            var whereClauses = new List<IWhereClause>
            {
                new WhereClause(nameof(CurrentCustomer.Name), CurrentCustomer.Name, nameof(CurrentCustomer.Name), LogicalOperatorType.And),
                new WhereClause(nameof(CurrentCustomer.Family), CurrentCustomer.Family, nameof(CurrentCustomer.Family) ,LogicalOperatorType.And),
                new WhereClause(nameof(MyApplication.DrId), MyApplication.DrId, nameof(MyApplication.DrId))
            };

            var dataTable = DatabaseHelper.Select<Customer>("Customer", whereClauses: whereClauses);

            if (dataTable.Count > 0)
            {
                var msg = $"قبلا بیماری با مشخصات '{CurrentCustomer}' .ثبت گردیده است {Environment.NewLine} آیا عملیات ذخیره سازی را ادامه میدهید؟";
                var result = MsgBox.ShowQuestion(msg, "ثبت جدید");
                if (result != DialogResult.Yes)
                    return -2;
            }

            var filedNameAndValues = new List<IFieldValue>
            {
                new FieldValue("Name", CurrentCustomer.Name, "Name"),
                new FieldValue("Family", CurrentCustomer.Family, "Family"),
                new FieldValue("Tel", CurrentCustomer.Tel, "Tel"),
                new FieldValue("NameFather", CurrentCustomer.NameFather, "NameFather"),
                new FieldValue("Reason", CurrentCustomer.Reason, "Reason"),
                new FieldValue("Dis", CurrentCustomer.Dis, "Dis"),
                new FieldValue("Age", CurrentCustomer.Age, "Age"),
                new FieldValue("DateSave", CurrentCustomer.DateSave, "DateSave"),
                new FieldValue("DrId", MyApplication.DrId, "DrId"),
                new FieldValue("Address", CurrentCustomer.Address, "Address"),
                new FieldValue("IdTypePatient", CurrentCustomer.IdTypePatient, "IdTypePatient"),
                new FieldValue("EyeLeft", checkBoxEyeLeft.Checked ? CurrentCustomer.EyeLeft : "", "EyeLeft"),
                new FieldValue("EyeRight", checkBoxEyeRight.Checked ? CurrentCustomer.EyeRight : "", "EyeRight")
            };

            return DatabaseHelper.Insert("Customer", filedNameAndValues);
        }

        private int EditCustomer()
        {
            var filedNameAndValues = new List<IFieldValue>
            {
                new FieldValue("Name", CurrentCustomer.Name, "Name"),
                new FieldValue("Family", CurrentCustomer.Family, "Family"),
                new FieldValue("Tel", CurrentCustomer.Tel, "Tel"),
                new FieldValue("NameFather", CurrentCustomer.NameFather, "NameFather"),
                new FieldValue("Reason", CurrentCustomer.Reason, "Reason"),
                new FieldValue("Dis", CurrentCustomer.Dis, "Dis"),
                new FieldValue("Age", CurrentCustomer.Age, "Age"),
                new FieldValue("DateSave", CurrentCustomer.DateSave, "DateSave"),
                new FieldValue("DrId", MyApplication.DrId, "DrId"),
                new FieldValue("Address", CurrentCustomer.Address, "Address"),
                new FieldValue("IdTypePatient", CurrentCustomer.IdTypePatient, "IdTypePatient"),
                new FieldValue("EyeLeft", checkBoxEyeLeft.Checked ? CurrentCustomer.EyeLeft : "", "EyeLeft"),
                new FieldValue("EyeRight", checkBoxEyeRight.Checked ? CurrentCustomer.EyeRight : "", "EyeRight")
            };
            var whereClauses = new List<IWhereClause> { new WhereClause("Id", CurrentCustomer.Id, "Id") };
            return DatabaseHelper.Update("Customer", filedNameAndValues, whereClauses);
        }

        private void ChangeFormEnabled(bool enabled)
        {
            textBoxName.Enabled = enabled;
            textBoxFamily.Enabled = enabled;
            textBoxFatherName.Enabled = enabled;
            textBoxAddress.Enabled = enabled;
            textBoxAge.Enabled = enabled;
            textBoxCode.Enabled = enabled;
            textBoxDescription.Enabled = enabled;
            textBoxReason.Enabled = enabled;
            textBoxTel.Enabled = enabled;

            comboBoxType.Enabled = enabled;
            buttonBrowse.Enabled = enabled;

            buttonSave.Enabled = enabled;
            buttonCancel.Enabled = enabled;
            buttonAdd.Enabled = !enabled;
            buttonEdit.Enabled = !enabled;

            dateTimePickerRegisterDate.Enabled = enabled;

            checkBoxEyeLeft.Enabled = enabled;
            checkBoxEyeRight.Enabled = enabled;

            if (!enabled)
            {
                if (checkBoxEyeLeft.Checked)
                    checkBoxEyeLeft.Checked = false;

                if (checkBoxEyeRight.Checked)
                    checkBoxEyeRight.Checked = false;
            }
        }

        private void DeleteCurrentRecord()
        {
            var personName = CurrentCustomer.ToString();

            var result = MsgBox.ShowYesNo($"آیا از حذف '{personName}' اطمینان دارید؟", "حذف بیمار", MessageBoxIcon.Warning);
            if (result != DialogResult.Yes)
                return;

            _recordLastPosition = bindingSourceCustomers.Position;
            if (_recordLastPosition <= 0)
                _recordLastPosition = 0;

            if (_recordLastPosition > 0)
                _recordLastPosition--;

            var whereClauses = new List<IWhereClause> { new WhereClause("Id", CurrentCustomer.Id, "Id") };
            var rows = DatabaseHelper.Delete("Customer", whereClauses);
            var text = rows > 0 ? $"اطلاعات '{personName}' با موفقیت حذف شد" : $"اطلاعات '{personName}' حذف نشد";
            MsgBox.ShowInformation(text, "حذف بیمار");
            LoadCustomers();

            bindingSourceCustomers.Position = _recordLastPosition;
        }

        #endregion

        #region ~( Event Handlers )~

        private void CustomersForm_Load(object sender, EventArgs e)
        {
            ResetDateTimeBoxes();
            LoadCustomers();
            LoadTypePatient();
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            DeleteCurrentRecord();
        }

        private void ButtonBrowse_Click(object sender, EventArgs e)
        {
            var typePatientForm = new TypePatientForm();
            typePatientForm.InitDataSource((List<TypePatient>)bindingSourceTypePatient.DataSource);
            typePatientForm.ShowDialog(this);
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            _recordLastPosition = bindingSourceCustomers.Position;
            bindingSourceCustomers.Position = 0;
            var maxId = CurrentCustomer.Id + 1;
            bindingSourceCustomers.AddNew();
            CurrentCustomer.Id = maxId;
            var dateSave = DateTime.Now.ToString("yyyy/MM/dd", Utility.Helpers.CultureHelper.PersianCulture);
            CurrentCustomer.DateSave = dateSave;
            dateTimePickerRegisterDate.Text = dateSave;
            gridCustomers.VerticalScrollPosition = 0;
            ChangeFormEnabled(true);
            ActiveControl = textBoxName;
            _formActionMode = FormActionMode.Add;
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            _recordLastPosition = bindingSourceCustomers.Position;
            ChangeFormEnabled(true);
            ActiveControl = textBoxName;
            _formActionMode = FormActionMode.Edit;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void CheckBoxEyeLeft_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerEyeLeft.Enabled = checkBoxEyeLeft.Checked;
        }

        private void CheckBoxEyeRight_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerEyeRight.Enabled = checkBoxEyeRight.Checked;
        }

        private void textBoxFamily_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    if (_onLoadRecords)
            //        return;

            //    var column = gridCustomers.RootTable.Columns["Family"];
            //    var filterValue = textBoxFamily.Text;
            //    gridCustomers.ApplyFilter(column, filterValue);
            //}
            //catch (Exception exception)
            //{
            //    Console.WriteLine(exception);
            //}
        }

        private void buttonVisitList_Click(object sender, EventArgs e)
        {
            var visitListForm = new VisitListForm();
            visitListForm.ShowDialog();
        }

        private void buttonAppointment_Click(object sender, EventArgs e)
        {
            var appointmentForm = new AppointmentForm();
            appointmentForm.Customers = bindingSourceCustomers.List;
            appointmentForm.ShowDialog();
        }

        private void buttonOldVisit_Click(object sender, EventArgs e)
        {

        }

        private void buttonVisit_Click(object sender, EventArgs e)
        {

        }

        private void buttonVisitText_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region ~( Properties )~

        public Customer CurrentCustomer => (Customer)bindingSourceCustomers.Current;

        #endregion

    }
}