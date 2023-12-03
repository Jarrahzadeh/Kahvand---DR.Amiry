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

        public CustomersForm()
        {
            InitializeComponent();

            _mode = Mode.None;
        }

        private void LoadCustomers()
        {
            var whereClauses = new List<IWhereClause>
            {
                new WhereClause("DrId", MyApplication.DrId)
            };

            var dataTableCustomers = DatabaseHelper.Select<Customer>("Customer", whereClauses: whereClauses);
            bindingSourceCustomers.DataSource = dataTableCustomers;
        }

        private void LoadTypePatient()
        {
            var typePatients = DatabaseHelper.Select<TypePatient>("TypePatient");
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

        //private void ResetDateTimeBoxes()
        //{
        //    dateTimePickerRegisterDate.ClearDateTime();
        //    dateTimePickerEyeRight.ClearDateTime();
        //    dateTimePickerEyeLeft.ClearDateTime();
        //}

        private void CustomersForm_Load(object sender, EventArgs e)
        {
            //ResetDateTimeBoxes();
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
            //if (_mode == Mode.Edit)
            //{
            //    //MsgBox.ShowQuestion($"اطلاعات '{CurrentCustomer}' در حال ویرایش می باشد، آیا میخواهید تغییرات را ذخیره کنید؟", "ثبت جدید");
            //    //bindingSourceCustomers.EndEdit();
            //    bindingSourceCustomers.CancelEdit();
            //    bindingSourceCustomers.ResetBindings(true);
            //}
            //else
            //{

            //}

            bindingSourceCustomers.AddNew();
            ActiveControl = textBoxName;
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            bindingSourceCustomers.ResetAllowNew();
            bindingSourceCustomers.CancelEdit();
            bindingSourceCustomers.ResetCurrentItem();
            _mode = Mode.None;
            Close();
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            var whereClauses = new List<IWhereClause>
            {
                new WhereClause("Name", CurrentCustomer.Name, LogicalOperatorType.And),
                new WhereClause("Family", CurrentCustomer.Family)
            };
            var hasRecord = DatabaseHelper.TableHasRecord("Customer", whereClauses);
            if (hasRecord)
            {
                var result = MsgBox.ShowQuestion("نام و نام خانوادگی تکراری می باشد. آیا ثبت می کنید؟", "ثبت بیمار");
                if (result == DialogResult.No)
                {
                    return;
                }
            }

            var fields = new List<IFieldValue>
            {
                new FieldValue("Name",  CurrentCustomer.Name),
                new FieldValue("Family",  CurrentCustomer.Family),
                new FieldValue("NameFather",  CurrentCustomer.NameFather),
                new FieldValue("Address",  CurrentCustomer.Address),
                new FieldValue("Age", CurrentCustomer.Age),
                new FieldValue("DateSave",  CurrentCustomer.DateSave),
                new FieldValue("Dis",  CurrentCustomer.Dis),
                new FieldValue("DrId", MyApplication.DrId),
                new FieldValue("IdTypePatient",  CurrentCustomer.IdTypePatient),
                new FieldValue("Tel",  CurrentCustomer.Tel)
            };

            if (checkBoxEyeLeft.Checked)
                fields.Add(new FieldValue("EyeLeft", CurrentCustomer.EyeLeft));

            if (checkBoxEyeRight.Checked)
                fields.Add(new FieldValue("EyeRight", CurrentCustomer.EyeRight));

            var rows = DatabaseHelper.Insert("Customer", fields);
            if (rows <= 0)
                return;

            MsgBox.ShowQuestion("اطلاعات با موفقیت ثبت شد", "ثبت بیمار");
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
                dateTimePickerEyeLeft.Focus();
            //else
            //    dateTimePickerEyeLeft.ClearDateTime();
        }

        private void CheckBoxEyeRight_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerEyeRight.Enabled = checkBoxEyeRight.Checked;
            if (dateTimePickerEyeRight.Enabled)
                dateTimePickerEyeRight.Focus();
            //else
            //    dateTimePickerEyeRight.ClearDateTime();
        }

        public Customer CurrentCustomer => (Customer)bindingSourceCustomers.Current;
    }
}