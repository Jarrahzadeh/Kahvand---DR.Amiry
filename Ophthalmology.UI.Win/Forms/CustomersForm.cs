using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Ophthalmology.Controls.CustomForms;
using Ophthalmology.Entity.Entites;
using Ophthalmology.UI.Win.Classes;
using Ophthalmology.Utility.Helpers;

namespace Ophthalmology.UI.Win.Forms
{
    public partial class CustomersForm : CustomizableFormBase
    {
        public CustomersForm()
        {
            InitializeComponent();
        }

        private void CustomersForm_Load(object sender, EventArgs e)
        {
            LoadCustomers();
            LoadTypePatient();
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            var personName = $"{TextBoxFamily.Text} {TextBoxName.Text}";
            var result = MessageBox.Show($"آیا از حذف '{personName}' اطمینان دارید؟", $"حذف '{personName}'", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes)
                return;

            var where = new List<Tuple<string, Type, object, string>>();
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
            var where = new List<Tuple<string, Type, object, string>>
            {
                new Tuple<string, Type, object, string>("DrId", "".GetType(), MyApplication.DrId, "")
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
    }
}