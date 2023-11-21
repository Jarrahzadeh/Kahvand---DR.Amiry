using System.Windows.Forms;

namespace Ophthalmology.UI.Win.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            new SettingsForm().ShowDialog();
        }
    }
}
