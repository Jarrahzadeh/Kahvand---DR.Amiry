using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;
using Ophthalmology.Entity.Database;
using Ophthalmology.Entity.Entites;
using Ophthalmology.Entity.Enums;
using Ophthalmology.UI.Win.Classes;
using Ophthalmology.Utility.Helpers;

namespace Ophthalmology.UI.Win.Forms
{
    public partial class CustomersForm : CustomizableFormBase
    {
        private object _customers;
        private bool _editMode;

        public CustomersForm()
        {
            InitializeComponent();
            
            //dateTimePicker1.
            _customers = null;
            _editMode = false;
        }

        private void CustomersForm_Load(object sender, EventArgs e)
        {
            LoadCustomers();
            LoadTypePatient();
            _editMode = false;
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            var personName = $"{TextBoxFamily.Text} {TextBoxName.Text}";
            var result = MessageBox.Show($"آیا از حذف '{personName}' اطمینان دارید؟", $"حذف '{personName}'", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes)
                return;

            var whereClauses = new List<IWhereClause> { new WhereClause("Id", CurrentCustomer.Id) };
            var rows = DatabaseHelper.Delete("Customer", whereClauses);
            var text = rows > 0 ? $"اطلاعات '{personName}' با موفقیت حذف شد" : $"اطلاعات '{personName}' حذف نشد";
            MessageBox.Show(text, $"حذف '{personName}'", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ResetForm();
        }

        private void ButtonBrowse_Click(object sender, EventArgs e)
        {
            var typePatientForm = new TypePatientForm();
            typePatientForm.InitDataSource((List<TypePatient>)bindingSourceTypePatient.DataSource);
            typePatientForm.ShowDialog(this);
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

        private void ResetForm()
        {
            ResetTextBoxes();
            ResetCheckBoxes();
            ResetComboBoxes();
        }

        private void ResetTextBoxes()
        {
            TextBoxAddress.Clear();
            TextBoxAge.Clear();
            TextBoxCode.Clear();
            TextBoxDescription.Clear();
            TextBoxFamily.Clear();
            TextBoxFatherName.Clear();
            TextBoxName.Clear();
            TextBoxReason.Clear();
            TextBoxTel.Clear();
        }

        private void ResetCheckBoxes()
        {
            CheckBoxEyeLeft.Checked = false;
            CheckBoxEyeRight.Checked = false;
        }

        private void ResetComboBoxes()
        {
            ComboBoxType.Text = string.Empty;
        }

        public Customer CurrentCustomer
        {
            get
            {
                return (Customer)bindingSourceCustomers.Current;
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (_customers == null)
            {
                bindingSourceCustomers.EndEdit();
                _customers = bindingSourceCustomers.AddNew();
                ActiveControl = TextBoxName;
            }
            else
            {
                bindingSourceCustomers.CancelEdit();
                _customers = null;
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            bindingSourceCustomers.ResetAllowNew();
            bindingSourceCustomers.CancelEdit();
            bindingSourceCustomers.ResetCurrentItem();
            _customers = null;
            Close();
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            if (_customers == null)
            {

            }
            else
            {

            }

            var whereClauses = new List<IWhereClause>
            {
                new WhereClause("Name", CurrentCustomer.Name, LogicalOperatorType.And),
                new WhereClause("Family", CurrentCustomer.Family)
            };
            var hasRecord = DatabaseHelper.TableHasRecord("Customer", whereClauses);
            if (hasRecord)
            {
                var result = MessageBox.Show("نام و نام خانوادگی تکراری می باشد. آیا ثبت می کنید؟", "ثبت بیمار", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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

            if (CheckBoxEyeLeft.Checked)
                fields.Add(new FieldValue("EyeLeft", CurrentCustomer.EyeLeft));

            if (CheckBoxEyeRight.Checked)
                fields.Add(new FieldValue("EyeRight", CurrentCustomer.EyeRight));

            var rows = DatabaseHelper.Insert("Customer", fields);
            if (rows <= 0)
                return;

            MessageBox.Show("اطلاعات با موفقیت ثبت شد", "ثبت بیمار", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ResetForm();
        }

        private void bindingSourceCustomers_CurrentItemChanged(object sender, EventArgs e)
        {
            if (_editMode)
            {

            }
        }

        private void bindingSourceCustomers_ListChanged(object sender, System.ComponentModel.ListChangedEventArgs e)
        {
            switch (e.ListChangedType)
            {
                case ListChangedType.Reset:
                    break;
                case ListChangedType.ItemAdded:
                    break;
                case ListChangedType.ItemDeleted:
                    break;
                case ListChangedType.ItemMoved:
                    break;
                case ListChangedType.ItemChanged:
                    _editMode = true;
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

        private void bindingSourceCustomers_AddingNew(object sender, AddingNewEventArgs e)
        {

        }

        private void bindingSourceCustomers_BindingComplete(object sender, BindingCompleteEventArgs e)
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

        private void bindingSourceCustomers_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void bindingSourceCustomers_DataError(object sender, BindingManagerDataErrorEventArgs e)
        {

        }

        private void bindingSourceCustomers_DataMemberChanged(object sender, EventArgs e)
        {

        }

        private void bindingSourceCustomers_DataSourceChanged(object sender, EventArgs e)
        {

        }

        private void bindingSourceCustomers_PositionChanged(object sender, EventArgs e)
        {

        }

        private void CheckBoxEyeLeft_CheckedChanged(object sender, EventArgs e)
        {
            DateTimePickerEyeLeft.Enabled = CheckBoxEyeLeft.Checked;
        }

        private void CheckBoxEyeRight_CheckedChanged(object sender, EventArgs e)
        {
            DateTimePickerEyeRight.Enabled = CheckBoxEyeRight.Checked;
        }
    }
}