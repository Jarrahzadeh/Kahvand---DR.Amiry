using Ophthalmology.Controls.CustomForms;

namespace Ophthalmology.UI.Win.Forms
{
    public partial class LoginForm : CustomizableFormBase
    {
        public LoginForm()
        {
            InitializeComponent();
            TextboxPassword.TextBox.UseSystemPasswordChar = true;
            ActiveControl = TextBoxUserName;
        }
    }
}
