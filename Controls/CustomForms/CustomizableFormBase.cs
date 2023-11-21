using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Ophthalmology.Utility.Helpers;

namespace Ophthalmology.Controls.CustomForms
{
    public partial class CustomizableFormBase : FormBase
    {
        public CustomizableFormBase()
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

            public static FormSettings GetFormSettings(CustomizableFormBase form)
            {
                var formSettings = new FormSettings
                {
                    FormLocation = form.Location,
                    FormWindowState = form.WindowState,
                    FormSize = form.Size
                };

                return formSettings;
            }

            public void SetFormSettings(CustomizableFormBase form)
            {
                form.Location = FormLocation;
                form.WindowState = FormWindowState;
                if (!FormSize.IsEmpty)
                    form.Size = FormSize;
            }

            public Point FormLocation { get; set; }

            public FormWindowState FormWindowState { get; set; }

            public Size FormSize { get; set; }
        }
    }
}