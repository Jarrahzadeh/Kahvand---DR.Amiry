using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Ophthalmology.Controls.CustomForms;
using Ophthalmology.Entity.Entites;
using Ophthalmology.Entity.Enums;
using Ophthalmology.UI.Win.Classes;
using Ophthalmology.Utility.Helpers;

namespace Ophthalmology.UI.Win.Forms
{
    public partial class LoginForm : FormBase
    {
        public LoginForm()
        {
            InitializeComponent();

            TextboxPassword.TextBox.UseSystemPasswordChar = true;
            ActiveControl = TextBoxUserName;
        }

        internal void PopulateUserTypeComboBox(List<Doctor> doctors)
        {
            bindingSource1.DataSource = doctors;
        }

        private static bool Authenticate(string userName, string password)
        {
            User user;
            var whereClause = new List<Tuple<string, Type, object, string>>
            {
                new Tuple<string, Type, object, string>(nameof(user.Name), "".GetType(), userName, "AND"),
                new Tuple<string, Type, object, string>(nameof(user.Pass), "".GetType(), password, "")
            };
            var users = DatabaseHelper.Select<User>(whereClause: whereClause);
            return users != null && users.Count > 0;
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            var authenticate = Authenticate(TextBoxUserName.Text, TextboxPassword.Text);
            if (!authenticate) 
                return;

            DialogResult = DialogResult.OK;
            if (RadioButtonDocter.Checked)
                MyApplication.CurrentSettings.UserType = UserType.Doctor;

            if (RadioButtonOptometrist.Checked)
                MyApplication.CurrentSettings.UserType = UserType.Optometrist;

            if (RadioButtonSecretary.Checked)
                MyApplication.CurrentSettings.UserType = UserType.Secretary;

            //MyApplication.SaveSettings();
        }

        private void LoginForm_Shown(object sender, EventArgs e)
        {
            try
            {
                ComboBoxDoctors.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                ex.Log();
            }

            switch (MyApplication.CurrentSettings.UserType)
            {
                case UserType.Doctor:
                    RadioButtonDocter.Checked = true;
                    break;
                case UserType.Optometrist:
                    RadioButtonOptometrist.Checked = true;
                    break;
                case UserType.Secretary:
                    RadioButtonSecretary.Checked = true;
                    break;
                default:
                    RadioButtonDocter.Checked = true;
                    break;
            }
        }
    }
}
