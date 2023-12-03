using System;
using System.IO;
using System.Windows.Forms;
using Ophthalmology.Controls;
using Ophthalmology.DataAccess.OleDb;
using Ophthalmology.Entity.Entites;
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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ThreadException += Application_ThreadException;
            Application.ThreadExit += ApplicationOnThreadExit;
            Application.Idle += Application_Idle;

            CultureHelper.SetCultureToPersian();
            CultureHelper.SetInputLanguageToPersian();
            CheckImagesFolder();

            var isAvailable = DatabaseHelper.DatabaseIsAvailable();
            if (!isAvailable)
            {
                MsgBox.ShowError("در باز کردن بانک اطلاعاتی خطلای پیش آمده", "خطا");
                return;
            }

            var logIn = Login();
            if (logIn)
            {
                var mainForm = new MainForm();
                Application.Run(mainForm);
            }
        }
        
        private static void CheckImagesFolder()
        {
            if (!Directory.Exists("Images"))
                Directory.CreateDirectory("Images");
        }

        private static bool Login()
        {
            var loginForm = new LoginForm();
            var doctors = DatabaseHelper.Select<Doctor>();
            if (doctors == null || doctors.Count <= 0)
            {
                MsgBox.ShowError("پزشکی برای برنامه تعریف نشده است", "خطا");
                return false;
            }

            loginForm.PopulateUserTypeComboBox(doctors);
            var dialogResult = loginForm.ShowDialog();
            return dialogResult == DialogResult.OK;
        }

        private static void ApplicationOnThreadExit(object sender, EventArgs e)
        {
            MyApplication.SaveSettings();
        }

        private static void Application_Idle(object sender, EventArgs e)
        {
        }

        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            e.Exception.Log();
            MsgBox.ShowError(e.Exception.GetMessage(), "خطا مدیریت نشده در برنامه");
        }
    }
}