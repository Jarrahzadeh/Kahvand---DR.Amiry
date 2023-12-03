using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Ophthalmology.Utility.Helpers;

namespace Ophthalmology.UI.Win.Forms
{
    public partial class CustomizableForm : BaseForm
    {
        public CustomizableForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoadSettings();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            SaveSettings();
            base.OnFormClosing(e);
        }

        protected void LoadSettings()
        {
            var jsonFormSetting = ReadSettingsFromFile();
            var formSetting = JsonHelper.DeSerialize<FormSettings>(jsonFormSetting);
            formSetting.SetFormSettings(this);
        }

        protected void SaveSettings()
        {
            var formSetting = FormSettings.GetFormSettings(this);
            var serialize = JsonHelper.Serialize(formSetting);
            WriteSettingsToFile(serialize);
        }

        private string GetSettingsFileName()
        {
            if (!Directory.Exists("CustomSetting"))
                Directory.CreateDirectory("CustomSetting");

            return $"CustomSetting\\{Name}.json";
        }

        private void WriteSettingsToFile(string serialize)
        {
            File.WriteAllText(GetSettingsFileName(), serialize, Encoding.UTF8);
        }

        private string ReadSettingsFromFile()
        {
            var settingsFileName = GetSettingsFileName();
            return File.Exists(settingsFileName) ?
                File.ReadAllText(settingsFileName, Encoding.UTF8) :
                "{}";
        }

        private class FormSettings
        {
            private FormSettings() { }

            public static FormSettings GetFormSettings(CustomizableForm baseForm)
            {
                var formSettings = new FormSettings
                {
                    FormLocation = baseForm.Location,
                    FormWindowState = baseForm.WindowState,
                    FormSize = baseForm.Size
                };

                return formSettings;
            }

            public void SetFormSettings(CustomizableForm baseForm)
            {
                baseForm.Location = FormLocation;
                baseForm.WindowState = FormWindowState;
                if (!FormSize.IsEmpty)
                    baseForm.Size = FormSize;
            }

            public Point FormLocation { get; set; }

            public FormWindowState FormWindowState { get; set; }

            public Size FormSize { get; set; }
        }
    }
}