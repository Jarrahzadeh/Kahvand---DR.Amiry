using System;
using System.Collections.Generic;
using Ophthalmology.Controls.CustomForms;
using Ophthalmology.Entity.Entites;
using Ophthalmology.UI.Win.Classes;
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
                new Tuple<string, Type, object, string>("DrId", "".GetType(), MyApplication.DrId, "")
            };

            var dataTableCustomers = DatabaseHelper.Select<Customer>("Customer", whereClause: where);
            bindingSourceCustomers.DataSource = dataTableCustomers;
        }

        public Customer CurrentCustomer
        {
            get
            {
                return (Customer)bindingSourceCustomers.Current;
            }
        }
    }
}