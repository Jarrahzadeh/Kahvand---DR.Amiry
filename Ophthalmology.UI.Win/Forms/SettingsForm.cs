﻿using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Janus.Windows.Common;
using Janus.Windows.EditControls;
using Ophthalmology.Controls.CustomForms;
using Ophthalmology.Entity;
using Ophthalmology.UI.Win.Classes;

namespace Ophthalmology.UI.Win.Forms
{
    public partial class SettingsForm : CustomizableFormBase
    {
        public SettingsForm()
        {
            InitializeComponent();
            MyApplication.LoadSettings();
            foreach (JanusColorScheme janusColorScheme in visualStyleManager.ColorSchemes)
            {
                uiComboBox1.Items.Add(janusColorScheme.Name);
            }

            uiComboBox1.SelectedIndex = 0;

            var fonts = FontFamily
                .Families
                .Select(fontFamily => new UIComboBoxItem(fontFamily.Name, fontFamily))
                .ToArray();
            uiComboBox2.Items.AddRange(fonts);
        }

        private void uiComboBox1_SelectedValueChanged(object sender, System.EventArgs e)
        {
            var selectedValue = uiComboBox1.SelectedValue;
            visualStyleManager.DefaultColorScheme = selectedValue.ToString();
        }

        private void uiButton1_Click(object sender, System.EventArgs e)
        {
            var result = fontDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                MyApplication.CurrentSettings.Font1 = fontDialog1.Font;
                MyApplication.CurrentSettings.Font = new ApplicationFont
                {
                    Name = fontDialog1.Font.Name,
                    Bold = fontDialog1.Font.Bold,
                    Italic = fontDialog1.Font.Italic,
                    Size = fontDialog1.Font.Size,
                    Underline = fontDialog1.Font.Underline,
                };
            }
        }

        private void SaveButton_Click(object sender, System.EventArgs e)
        {
            MyApplication.SaveSettings();
        }
    }
}