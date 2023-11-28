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
            var eControlControls = control.Controls;
            if (control is ScrollableControl)
            {
                foreach (Control controlControl in eControlControls)
                {
                    OnControlAdded(new ControlEventArgs(controlControl));
                }
            }

            if (control is ISupportVisualStyles control1)
            {
                control1.VisualStyleManager = visualStyleManager;
            }
        }
    }
}