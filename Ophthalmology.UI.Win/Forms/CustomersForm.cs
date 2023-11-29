using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Ophthalmology.Entity.Entites;
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

            var where = new List<Tuple<string, object, string>>
            {
                new Tuple<string, object, string>("Id", CurrentCustomer.Id, "")
            };
            var rows = DatabaseHelper.Delete("Customer", where);
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
            var where = new List<Tuple<string, object, string>>
            {
                new Tuple<string, object, string>("DrId", MyApplication.DrId, "")
            };

            var dataTableCustomers = DatabaseHelper.Select<Customer>("Customer", whereClause: where);
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

            //bindingSourceCustomers.ResetAllowNew();
            //bindingSourceCustomers.CancelEdit();
            //bindingSourceCustomers.ResetCurrentItem();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            bindingSourceCustomers.ResetAllowNew();
            bindingSourceCustomers.CancelEdit();
            bindingSourceCustomers.ResetCurrentItem();
            _customers = null;
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            if (_customers == null)
            {

            }
            else
            {

            }

            var whereClause = new List<Tuple<string, object, string>>
            {
                new Tuple<string, object, string>("Name", CurrentCustomer.Name, "AND"),
                new Tuple<string, object, string>("Family",  CurrentCustomer.Family, ""),
            };
            var hasRecord = DatabaseHelper.TableHasRecord("Customer", whereClause);
            if (hasRecord)
            {
                var result = MessageBox.Show("نام و نام خانوادگی تکراری می باشد. آیا ثبت می کنید؟", "ثبت بیمار", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    return;
                }
            }

            var fields = new List<Tuple<string, object>>
            {
                new Tuple<string, object>("Name",  CurrentCustomer.Name),
                new Tuple<string, object>("Family",  CurrentCustomer.Family),
                new Tuple<string, object>("NameFather",  CurrentCustomer.NameFather),
                new Tuple<string, object>("Address",  CurrentCustomer.Address),
                new Tuple<string, object>("Age", CurrentCustomer.Age),
                new Tuple<string, object>("DateSave",  CurrentCustomer.DateSave),
                new Tuple<string, object>("Dis",  CurrentCustomer.Dis),
                new Tuple<string, object>("DrId", MyApplication.DrId),
                new Tuple<string, object>("IdTypePatient",  CurrentCustomer.IdTypePatient),
                new Tuple<string, object>("Tel",  CurrentCustomer.Tel)
            };

            if (CheckBoxEyeLeft.Checked)
                fields.Add(new Tuple<string, object>("EyeLeft", CurrentCustomer.EyeLeft));

            if (CheckBoxEyeRight.Checked)
                fields.Add(new Tuple<string, object>("EyeRight", CurrentCustomer.EyeRight));

            var rows = DatabaseHelper.Insert("Customer", fields);
            if (rows <= 0)
                return;

            MessageBox.Show("اطلاعات با موفقیت ثبت شد", "ثبت بیمار", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ResetForm();
        }

        private void bindingSourceCustomers_CurrentItemChanged(object sender, EventArgs e)
        {
            _editMode = true;
        }
    }
}