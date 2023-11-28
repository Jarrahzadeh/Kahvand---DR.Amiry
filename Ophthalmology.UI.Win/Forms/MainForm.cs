using System;
using System.Windows.Forms;
using Ophthalmology.UI.Win.Classes;
using Ophthalmology.Utility.Helpers;

namespace Ophthalmology.UI.Win.Forms
{
    public partial class MainForm : CustomizableFormBase
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
        }

        #endregion

        #region ~( Event Handlers )~

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter)
            {
                //if (ActiveControl != ButtonLogin)
                //{
                //    SelectNextControl(ActiveControl, true, true, true, true);
                //}
            }
            else if (e.KeyChar == (int)Keys.Escape)
            {
                Close();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var dialogResult = MessageBox.Show("آیا برای خروج مطمئن هستید؟", "خروج از سیستم", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.No)
                e.Cancel = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
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