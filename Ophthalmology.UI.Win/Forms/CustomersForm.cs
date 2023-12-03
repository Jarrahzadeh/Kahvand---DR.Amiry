using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Ophthalmology.Controls;
using Ophthalmology.DataAccess.OleDb;
using Ophthalmology.Entity.Database;
using Ophthalmology.Entity.Entites;
using Ophthalmology.Entity.Enums;
using Ophthalmology.UI.Win.Classes;
using Ophthalmology.Utility.Helpers;

namespace Ophthalmology.UI.Win.Forms
{
    public partial class CustomersForm : CustomizableForm
    {
        private enum Mode
        {
            None,
            Add,
            Edit,
            Delete
        }

        private Mode _mode;
        private int _recordLastPosition;


        public CustomersForm()
        {
            InitializeComponent();

            ChangeFormEnabled(false);
            _recordLastPosition = -1;
            _mode = Mode.None;
        }

        private void LoadCustomers()
        {
            var whereClauses = new List<IWhereClause>
            {
                new WhereClause("DrId", MyApplication.DrId)
            };

            var customers = DatabaseHelper.Select<Customer>("Customer", whereClauses: whereClauses);
            bindingSourceCustomers.DataSource = customers;
        }

        private void LoadTypePatient()
        {
            var typePatients = DatabaseHelper.Select<TypePatient>("TypePatient");
            var typePatient = new TypePatient { Id = 0, Name = string.Empty };
            typePatients.Insert(0, typePatient);
            bindingSourceTypePatient.DataSource = typePatients;
        }

        //private void ResetForm()
        //{
        //    ResetTextBoxes();
        //    ResetCheckBoxes();
        //    ResetComboBoxes();
        //}

        //private void ResetTextBoxes()
        //{
        //    textBoxAddress.Clear();
        //    textBoxAge.Clear();
        //    textBoxCode.Clear();
        //    textBoxDescription.Clear();
        //    textBoxFamily.Clear();
        //    textBoxFatherName.Clear();
        //    textBoxName.Clear();
        //    textBoxReason.Clear();
        //    textBoxTel.Clear();
        //}

        //private void ResetCheckBoxes()
        //{
        //    checkBoxEyeLeft.Checked = false;
        //    checkBoxEyeRight.Checked = false;
        //}

        //private void ResetComboBoxes()
        //{
        //    comboBoxType.Text = string.Empty;
        //}

        private void ResetDateTimeBoxes()
        {
            dateTimePickerRegisterDate.ClearDateTime();
            dateTimePickerEyeRight.ClearDateTime();
            dateTimePickerEyeRight.Text = string.Empty;
            dateTimePickerEyeLeft.ClearDateTime();
            dateTimePickerEyeLeft.Text = string.Empty;
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

            dateTimePickerEyeLeft.Enabled = enabled;
            dateTimePickerEyeRight.Enabled = enabled;
            dateTimePickerRegisterDate.Enabled = enabled;

            checkBoxEyeLeft.Enabled = enabled;
            checkBoxEyeRight.Enabled = enabled;
        }

        private void CustomersForm_Load(object sender, EventArgs e)
        {
            ResetDateTimeBoxes();
            LoadCustomers();
            LoadTypePatient();
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            var personName = CurrentCustomer.ToString();

            var result = MsgBox.ShowYesNo($"آیا از حذف '{personName}' اطمینان دارید؟", $"حذف '{personName}'", MessageBoxIcon.Warning);
            if (result != DialogResult.Yes)
                return;

            var whereClauses = new List<IWhereClause> { new WhereClause("Id", CurrentCustomer.Id) };
            var rows = DatabaseHelper.Delete("Customer", whereClauses);
            var text = rows > 0 ? $"اطلاعات '{personName}' با موفقیت حذف شد" : $"اطلاعات '{personName}' حذف نشد";
            MsgBox.ShowInformation(text, $"حذف '{personName}'");
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
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            _recordLastPosition = bindingSourceCustomers.Position;
            ChangeFormEnabled(true);
            ActiveControl = textBoxName;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            ChangeFormEnabled(false);
            MsgBox.ShowInformation("اطلاعات با موفقیت ذخیره گردید", "دخیره اطلاعات");
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            bindingSourceCustomers.CancelEdit();
            bindingSourceCustomers.Position = _recordLastPosition;
            _recordLastPosition = -1;

            ChangeFormEnabled(false);

            customGridEx1.Focus();

            //_mode = Mode.None;
        }

        private void BindingSourceCustomers_CurrentItemChanged(object sender, EventArgs e)
        {
            if (_mode == Mode.Add)
            {

            }
        }

        private void BindingSourceCustomers_ListChanged(object sender, ListChangedEventArgs e)
        {
            switch (e.ListChangedType)
            {
                case ListChangedType.Reset:
                    _mode = Mode.None;
                    break;
                case ListChangedType.ItemAdded:
                    _mode = Mode.Add;
                    break;
                case ListChangedType.ItemDeleted:
                    _mode = Mode.Delete;
                    break;
                case ListChangedType.ItemMoved:
                    break;
                case ListChangedType.ItemChanged:
                    _mode = Mode.Edit;
                    break;
                case ListChangedType.PropertyDescriptorAdded:
                    break;
                case ListChangedType.PropertyDescriptorDeleted:
                    break;
                case ListChangedType.PropertyDescriptorChanged:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void BindingSourceCustomers_AddingNew(object sender, AddingNewEventArgs e)
        {
            // ResetDateTimeBoxes();
        }

        private void BindingSourceCustomers_BindingComplete(object sender, BindingCompleteEventArgs e)
        {
            switch (e.BindingCompleteState)
            {
                case BindingCompleteState.Success:
                    break;
                case BindingCompleteState.DataError:
                    break;
                case BindingCompleteState.Exception:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            switch (e.BindingCompleteContext)
            {
                case BindingCompleteContext.ControlUpdate:
                    break;
                case BindingCompleteContext.DataSourceUpdate:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void CheckBoxEyeLeft_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerEyeLeft.Enabled = checkBoxEyeLeft.Checked;
            if (dateTimePickerEyeLeft.Enabled)
            {
                //dateTimePickerEyeLeft.SelectedDateInStringPersian = CurrentCustomer.EyeLeft;
            }
        }

        private void CheckBoxEyeRight_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerEyeRight.Enabled = checkBoxEyeRight.Checked;
            if (dateTimePickerEyeRight.Enabled)
            {
                //dateTimePickerEyeRight.SelectedDateInStringPersian = CurrentCustomer.EyeRight;
            }
        }

        public Customer CurrentCustomer => (Customer)bindingSourceCustomers.Current;

    }
}