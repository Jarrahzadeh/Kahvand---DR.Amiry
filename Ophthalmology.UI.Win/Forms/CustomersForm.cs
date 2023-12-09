using System;
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
                new WhereClause("DrId", MyApplication.DrId)
            };

            var customers = DatabaseHelper.Select<Customer>("Customer", whereClauses: whereClauses);
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

        private int SaveNewCustomer()
        {
            if (string.IsNullOrWhiteSpace(CurrentCustomer.Name) || string.IsNullOrWhiteSpace(CurrentCustomer.Family))
                return -3;

            var whereClauses = new List<IWhereClause>
            {
                new WhereClause(nameof(CurrentCustomer.Name), CurrentCustomer.Name, LogicalOperatorType.And),
                new WhereClause(nameof(CurrentCustomer.Family), CurrentCustomer.Family, LogicalOperatorType.And),
                new WhereClause(nameof(MyApplication.DrId), MyApplication.DrId)
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
                new FieldValue("Name", CurrentCustomer.Name),
                new FieldValue("Family", CurrentCustomer.Family),
                new FieldValue("Tel", CurrentCustomer.Tel),
                new FieldValue("NameFather", CurrentCustomer.NameFather),
                new FieldValue("Reason", CurrentCustomer.Reason),
                new FieldValue("Dis", CurrentCustomer.Dis),
                new FieldValue("Age", CurrentCustomer.Age),
                new FieldValue("DateSave", CurrentCustomer.DateSave),
                new FieldValue("DrId", MyApplication.DrId),
                new FieldValue("Address", CurrentCustomer.Address),
                new FieldValue("IdTypePatient", CurrentCustomer.IdTypePatient),
                new FieldValue("EyeLeft", checkBoxEyeLeft.Checked ? CurrentCustomer.EyeLeft : ""),
                new FieldValue("EyeRight", checkBoxEyeRight.Checked ? CurrentCustomer.EyeRight : "")
            };

            return DatabaseHelper.Insert("Customer", filedNameAndValues);
        }

        private int EditCustomer()
        {
            var filedNameAndValues = new List<IFieldValue>
            {
                new FieldValue("Name", CurrentCustomer.Name),
                new FieldValue("Family", CurrentCustomer.Family),
                new FieldValue("Tel", CurrentCustomer.Tel),
                new FieldValue("NameFather", CurrentCustomer.NameFather),
                new FieldValue("Reason", CurrentCustomer.Reason),
                new FieldValue("Dis", CurrentCustomer.Dis),
                new FieldValue("Age", CurrentCustomer.Age),
                new FieldValue("DateSave", CurrentCustomer.DateSave),
                new FieldValue("DrId", MyApplication.DrId),
                new FieldValue("Address", CurrentCustomer.Address),
                new FieldValue("IdTypePatient", CurrentCustomer.IdTypePatient),
                new FieldValue("EyeLeft", checkBoxEyeLeft.Checked ? CurrentCustomer.EyeLeft : ""),
                new FieldValue("EyeRight", checkBoxEyeRight.Checked ? CurrentCustomer.EyeRight : "")
            };
            var whereClauses = new List<IWhereClause> { new WhereClause("Id", CurrentCustomer.Id) };
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

        #endregion

        #region ~( Event Handlers )~

        private void CustomersForm_Load(object sender, EventArgs e)
        {
            ResetDateTimeBoxes();
            LoadCustomers();
            LoadTypePatient();
            tableLayoutPanel1.Refresh();
            tableLayoutPanel1.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
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

            var whereClauses = new List<IWhereClause> { new WhereClause("Id", CurrentCustomer.Id) };
            var rows = DatabaseHelper.Delete("Customer", whereClauses);
            var text = rows > 0 ? $"اطلاعات '{personName}' با موفقیت حذف شد" : $"اطلاعات '{personName}' حذف نشد";
            MsgBox.ShowInformation(text, "حذف بیمار");
            LoadCustomers();

            bindingSourceCustomers.Position = _recordLastPosition;
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
            bindingSourceCustomers.AddNew();
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
            var rowEffected = -1;
            if (_formActionMode == FormActionMode.Add)
            {
                rowEffected = SaveNewCustomer();
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
                ButtonCancel_Click(sender, e);
            }
            else if (rowEffected == -3)
            {
                MsgBox.ShowWarning("لطفا مشخصات بیمار را بصورت صحیح وارد نمائید", "ثبت جدید");
                ActiveControl = textBoxName;
            }

            ChangeFormEnabled(false);
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            bindingSourceCustomers.CancelEdit();
            bindingSourceCustomers.Position = _recordLastPosition;
            _recordLastPosition = -1;

            ChangeFormEnabled(false);

            gridCustomers.Focus();

            _formActionMode = FormActionMode.None;
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

        #endregion

        #region ~( Properties )~

        public Customer CurrentCustomer => (Customer)bindingSourceCustomers.Current;

        #endregion
    }
}