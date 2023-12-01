using System.Windows.Forms;
using Janus.Windows.Common;
using Ophthalmology.UI.Win.Classes;

namespace Ophthalmology.UI.Win.Forms
{
    public partial class FormBase : Form
    {
        public FormBase()
        {
            InitializeComponent();

            ShowCloseQuestion = true;
            visualStyleManager.DefaultColorScheme = MyApplication.CurrentSettings.Theme;
            Font = MyApplication.CurrentSettings.Font;
        }

        protected override void OnControlAdded(ControlEventArgs e)
        {
            ApplyThemeAndSettings(e.Control);

            base.OnControlAdded(e);
        }

        private void ApplyThemeAndSettings(Control control)
        {
            var controls = control.Controls;
            if (control is ScrollableControl)
            {
                foreach (Control ctl in controls)
                {
                    ApplyThemeAndSettings(ctl);
                }
            }

            if (control is ISupportVisualStyles control1)
            {
                control1.VisualStyleManager = visualStyleManager;
            }
        }

        private void FormBase_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!ShowCloseQuestion)
                return;

            var text = $"آیا برای بستن پنجره '{Text}' مطمئن هستید؟";
            var result = MessageBox.Show(text, "بستن", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// نمایش هشدار و گرفتن تاییدیه از کاربر جهت بستن پنجره
        /// </summary>
        public bool ShowCloseQuestion { get; set; }
    }
}