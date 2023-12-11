using System.Collections.Generic;
using System.IO;
using Ophthalmology.Utility.Helpers;
using System.Text;
using Ophthalmology.Entity.Entites;
using Ophthalmology.Entity.Settings;
using Ophthalmology.DataAccess.OleDb;

namespace Ophthalmology.UI.Win.Classes
{
    public class MyApplication
    {
        #region ~( Fields )~

        private static ApplicationSettings _applicationSettings;
        private static IList<TypePatient> _typePatients;

        #endregion

        #region ~( Methods )~

        private static void LoadSettings()
        {
            var jsonFormSetting = ReadSettingsFromFile();
            var applicationSettings = JsonHelper.DeSerialize<ApplicationSettings>(jsonFormSetting);
            applicationSettings.SetFormSettings(_applicationSettings);
        }

        public static void SaveSettings()
        {
            var serialize = JsonHelper.Serialize(_applicationSettings);
            WriteSettingsToFile(serialize);
        }

        /// <summary>
        /// ریست کردن کش انواع بیمه
        /// </summary>
        public static void ResetTypePatientCache()
        {
            _typePatients = null;
        }

        private static string ReadSettingsFromFile()
        {
            var settingsFileName = GetSettingsFileName();
            return File.Exists(settingsFileName) ?
                File.ReadAllText(settingsFileName, Encoding.UTF8) :
                "{}";
        }

        private static string GetSettingsFileName()
        {
            if (!Directory.Exists("CustomSetting"))
                Directory.CreateDirectory("CustomSetting");

            return "CustomSetting\\ApplicationSettings.json";
        }

        private static void WriteSettingsToFile(string serialize)
        {
            File.WriteAllText(GetSettingsFileName(), serialize, Encoding.UTF8);
        }

        #endregion

        #region ~( Properties )~

        public static ApplicationSettings CurrentSettings
        {
            get
            {
                if (_applicationSettings == null)
                {
                    _applicationSettings = new ApplicationSettings();
                    LoadSettings();
                }

                return _applicationSettings;

            }
        }

        public static int UserId { get; set; }
        
        public static string UserName { get; set; }

        public static int DrId { get; set; }
        
        public static string DrName { get; set; }

        /// <summary>
        /// لیست انواع بیمه ها
        /// </summary>
        /// <remarks>
        /// به علت اینکه این لیست زیاد دستخوش تغییر نمیشود آن را کش میکنیم و در زمانی که رکورد جدیدی ثبت شود از بانک مجددا بازیابی میشود
        /// </remarks>
        public static IList<TypePatient> TypePatients
        {
            get
            {
                if (_typePatients == null)
                {
                    _typePatients = DatabaseHelper.Select<TypePatient>("TypePatient");
                    var typePatient = new TypePatient { Id = 0, Name = string.Empty };
                    _typePatients.Insert(0, typePatient);
                }

                return _typePatients;
            }
        }

        #endregion
    }
}