using System;
using System.Collections.Generic;
using Ophthalmology.Controls.CustomForms;
using Ophthalmology.Utility.Helpers;

namespace Ophthalmology.UI.Win.Forms
{
    public partial class CustomersForm : CustomizableFormBase
    {
        public CustomersForm()
        {
            InitializeComponent();
        }

        private void CustomersForm_Load(object sender, EventArgs e)
        {
            var where = new List<Tuple<string, Type, object, string>>
            {
                new Tuple<string, Type, object, string>("DrId", "".GetType(), "2", "")
            };

            var dataTableCustomers = DatabaseHelper.Select("Customer", whereClause: where);
            bindingSourceGridCustomer.DataSource = dataTableCustomers.DefaultView;
        }
    }
}