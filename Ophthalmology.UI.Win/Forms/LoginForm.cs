using System;
using System.Collections.Generic;
using System.Linq;
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
        #region ~( Constructors )~

        public LoginForm()
        {
            InitializeComponent();

            TextboxPassword.TextBox.UseSystemPasswordChar = true;
            ActiveControl = TextBoxUserName;
        }

        #endregion

        #region ~( Methods )~

        internal void PopulateUserTypeComboBox(List<Doctor> doctors)
        {
            bindingSource1.DataSource = doctors;
        }

        private bool Authenticate(string userName, string password)
        {
            User user;
            var whereClause = new List<Tuple<string, Type, object, string>>
            {
                new Tuple<string, Type, object, string>(nameof(user.Name), "".GetType(), userName, "AND"),
                new Tuple<string, Type, object, string>(nameof(user.Pass), "".GetType(), password, "")
            };
            var users = DatabaseHelper.Select<User>(whereClause: whereClause);
            var loggedIn = users != null && users.Count > 0;
            if (loggedIn)
            {
                user = users.First();
                MyApplication.UserId = user.Id;
                MyApplication.UserName = user.FullName;
                var doctor = (Doctor)bindingSource1.Current;
                MyApplication.DrId = doctor.Id;
                MyApplication.DrName = doctor.Name;
            }
            return loggedIn;
        }

        #endregion

        #region ~( Event Handlers )~

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            var authenticate = Authenticate(TextBoxUserName.Text, TextboxPassword.Text);
            if (!authenticate)
            {
                MessageBox.Show("امکان ورود به سیستم وجود ندارد", "ورود به سیستم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult = DialogResult.OK;
            if (RadioButtonDocter.Checked)
                MyApplication.CurrentSettings.UserType = UserType.Doctor;

            if (RadioButtonOptometrist.Checked)
                MyApplication.CurrentSettings.UserType = UserType.Optometrist;

            if (RadioButtonSecretary.Checked)
                MyApplication.CurrentSettings.UserType = UserType.Secretary;
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

        private void LoginForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter)
            {
                if (ActiveControl != ButtonLogin)
                {
                    SelectNextControl(ActiveControl, true, true, true, true);
                }
            }
            else if (e.KeyChar == (int)Keys.Escape)
            {
                Close();
            }
            else if (e.KeyChar == (int)Keys.F2) 
            {
                ButtonLogin_Click(sender, e);
            }
        }

        #endregion
    }
}