using System;
using System.Windows.Forms;
using Ophthalmology.UI.Win.Forms;
using Ophthalmology.Utility.Helpers;

namespace Ophthalmology.UI.Win.Classes
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.ThreadException += Application_ThreadException;

            CultureHelper.SetCultureToPersian();
            CultureHelper.SetInputLanguageToPersian();
            var logedIn = Login();
            if (logedIn)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
            }
        }

        private static bool Login()
        {
            var loginForm = new LoginForm();
            var dialogResult = loginForm.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                return true;
            }
            return false;
        }

        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {

        }
    }
}