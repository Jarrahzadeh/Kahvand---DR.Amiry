using System.Collections;
using Janus.Windows.GridEX;

namespace Ophthalmology.UI.Win.Forms
{
    public partial class AppointmentForm : CustomizableForm
    {
        public AppointmentForm()
        {
            InitializeComponent();
        }
        
        public IList Customers
        {
            set
            {
                bindingSourceCustomers.DataSource = value;
            }
        }

        private void multiColumnCombo1_TextChanged(object sender, System.EventArgs e)
        {
            //bindingSourceCustomers.Filter = $"FullName LIKE '{multiColumnCombo1.Text}%'";
            
        }

        private void multiColumnCombo1_ValueChanged(object sender, System.EventArgs e)
        {
            var column = multiColumnCombo1.DropDownList.Columns[0];
            multiColumnCombo1.DropDownList.ApplyFilter(new GridEXFilterCondition(column, ConditionOperator.BeginsWith, multiColumnCombo1.Text));
        }
    }
}
