﻿using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Janus.Windows.Common;
using Janus.Windows.EditControls;
using Ophthalmology.Controls.CustomForms;
using Ophthalmology.UI.Win.Classes;

namespace Ophthalmology.UI.Win.Forms
{
    public partial class SettingsForm : CustomizableFormBase
    {
        public SettingsForm()
        {
            InitializeComponent();

            MyApplication.LoadSettings();

            InitThemeCombobox();

            InitFontCombobox();
        }

        private void InitFontCombobox()
        {
            var fonts = FontFamily
                .Families
                .Select(fontFamily => new UIComboBoxItem(fontFamily.Name, fontFamily))
                .ToArray();
            FontsComboBox.Items.AddRange(fonts);

            FontsComboBox.Text = MyApplication.CurrentSettings.Font.Name;
            integerUpDown1.Value = (int)MyApplication.CurrentSettings.Font.Size;
        }

        private void InitThemeCombobox()
        {
            foreach (JanusColorScheme janusColorScheme in visualStyleManager.ColorSchemes)
            {
                ThemeComboBox.Items.Add(janusColorScheme.Name);
            }

            ThemeComboBox.Text = MyApplication.CurrentSettings.Theme;
        }

        private void ChooseFontButton_Click(object sender, System.EventArgs e)
        {
            fontDialog1.Font = MyApplication.CurrentSettings.Font;
            var result = fontDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                FontsComboBox.Text = fontDialog1.Font.Name;
                integerUpDown1.Value = (int)fontDialog1.Font.Size;
            }
        }

        private void SaveButton_Click(object sender, System.EventArgs e)
        {
            MyApplication.SaveSettings();
            MessageBox.Show("تنظیمات با موفقیت ذخیره گردید");
        }

        private void ThemeComboBox_SelectedValueChanged(object sender, System.EventArgs e)
        {
            var selectedValue = ThemeComboBox.SelectedValue;
            visualStyleManager.DefaultColorScheme = selectedValue.ToString();
            MyApplication.CurrentSettings.Theme = selectedValue.ToString();
        }

        private void integerUpDown1_ValueChanged(object sender, System.EventArgs e)
        {
            MyApplication.CurrentSettings.Font = new Font(MyApplication.CurrentSettings.Font.Name, integerUpDown1.Value);
        }

        private void FontsComboBox_SelectedValueChanged(object sender, System.EventArgs e)
        {
            MyApplication.CurrentSettings.Font = new Font(FontsComboBox.Text, MyApplication.CurrentSettings.Font.Size);
        }
    }
}