using System.Drawing;
using System.Linq;
using Janus.Windows.Common;
using Janus.Windows.EditControls;
using Ophthalmology.Controls.CustomForms;

namespace Ophthalmology.UI.Win.Forms
{
    public partial class SettingsForm : CustomizableFormBase
    {
        public SettingsForm()
        {
            InitializeComponent();
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
            fontDialog1.ShowDialog();
        }
    }
}