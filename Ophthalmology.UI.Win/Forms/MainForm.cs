using System;
using System.Windows.Forms;
using Ophthalmology.Controls;
using Ophthalmology.UI.Win.Classes;
using Ophthalmology.Utility.Helpers;

namespace Ophthalmology.UI.Win.Forms
{
    public partial class MainForm : CustomizableForm
    {
        #region ~( Constructors )~

        public MainForm()
        {
            InitializeComponent();
            InitDetails();
        }

        #endregion

        #region ~( Methods )~

        private void InitDetails()
        {
            TextBoxDoctor.Text = MyApplication.DrName;
            LabelDoctorName.Text = MyApplication.DrName;
            LabelCurrentUserValue.Text = MyApplication.UserName;
            Text += $" - {MyApplication.DrName}";
        }

        #endregion

        #region ~( Event Handlers )~

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var dialogResult = MsgBox.ShowQuestion("آیا برای خروج مطمئن هستید؟", "خروج از سیستم");
            if (dialogResult == DialogResult.No)
                e.Cancel = true;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            LabelDateTime.Text = DateTime.Now.ToString("ddd dd MMM yyyy - HH:mm:ss", CultureHelper.PersianCulture);
        }

        private void ButtonCustomers_Click(object sender, EventArgs e)
        {
            var customerForm = new CustomersForm();
            customerForm.Text += $" - {MyApplication.DrName}";
            customerForm.ShowDialog();
        }

        private void ButtonSettings_Click(object sender, EventArgs e)
        {
            var settingsForm = new SettingsForm();
            settingsForm.ShowDialog(this);
        }

        #endregion
    }
}