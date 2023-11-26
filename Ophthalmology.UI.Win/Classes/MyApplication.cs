using System.IO;
using Ophthalmology.Utility.Helpers;
using System.Text;
using Ophthalmology.Entity.Settings;

namespace Ophthalmology.UI.Win.Classes
{
    public class MyApplication
    {
        #region ~( Fields )~

        private static ApplicationSettings _applicationSettings;

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

        #endregion
    }
}