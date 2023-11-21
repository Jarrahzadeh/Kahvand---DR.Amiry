using System.IO;
using Ophthalmology.Entity;
using Ophthalmology.Utility.Helpers;
using System.Text;
using System.Xml.Linq;

namespace Ophthalmology.UI.Win.Classes
{
    public class MyApplication
    {
        private static ApplicationSettings _applicationSettings;

        public static ApplicationSettings CurrentSettings
        {
            get
            {
                if (_applicationSettings == null)
                {
                    _applicationSettings = new ApplicationSettings();
                }
                return _applicationSettings;
            }
        }

        public static void LoadSettings()
        {
            var jsonFormSetting = ReadSettingsFromFile();
            var applicationSettings = JsonHelper.DeSerialize<ApplicationSettings>(jsonFormSetting);
            applicationSettings.SetFormSettings(_applicationSettings);
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

        public static void SaveSettings()
        {
            var serialize = JsonHelper.Serialize(_applicationSettings);
            WriteSettingsToFile(serialize);
        }

        private static void WriteSettingsToFile(string serialize)
        {
            File.WriteAllText(GetSettingsFileName(), serialize, Encoding.UTF8);
        }
    }
}
