using System;
using System.Collections.Generic;
using System.Net.Security;
using System.Windows.Forms;
using Ophthalmology.Controls.CustomForms;
using Ophthalmology.Entity.Entites;
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
            ComboBoxDoctors.DataSource = doctors;
            ComboBoxDoctors.DisplayMember = "Name";
            ComboBoxDoctors.SelectedIndex = 0;
        }

        private void ButtonCancel_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void ButtonLogin_Click(object sender, System.EventArgs e)
        {
            var authenticate = Authenticate(TextBoxUserName.Text, TextboxPassword.Text);
            if (authenticate)
            {
                DialogResult = DialogResult.OK;
            }
        }

        private bool Authenticate(string userName, string password)
        {
            var user = new User();
            var whereClause = new List<Tuple<string, Type, object, string>>
            {
                new Tuple<string, Type, object, string>(nameof(user.Name), "".GetType(), userName, "AND"),
                new Tuple<string, Type, object, string>(nameof(user.Pass), "".GetType(), password, "")
            };
            var users = DatabaseHelper.Select<User>(whereClause: whereClause);
            return users != null && users.Count > 0;
        }
    }
}
