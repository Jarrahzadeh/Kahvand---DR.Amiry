using Janus.Windows.Common;
using System.Windows.Forms;

namespace Ophthalmology.Controls.CustomForms
{
    public partial class FormBase : Form
    {
        public FormBase()
        {
            InitializeComponent();
        }

        protected override void OnControlAdded(ControlEventArgs e)
        {
            if (e.Control is ScrollableControl)
            {
                foreach (Control controlControl in e.Control.Controls)
                {
                    OnControlAdded(new ControlEventArgs(controlControl));
                }
            }

            if (e.Control is ISupportVisualStyles control)
            {
                control.VisualStyleManager = visualStyleManager;
            }
            base.OnControlAdded(e);
        }
    }
}