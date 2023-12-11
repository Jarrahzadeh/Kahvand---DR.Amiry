using System.Collections.Generic;
using Ophthalmology.Entity.Entites;
using Ophthalmology.UI.Win.Classes;

namespace Ophthalmology.UI.Win.Forms
{
    public partial class TypePatientForm : CustomizableForm
    {
        public TypePatientForm()
        {
            InitializeComponent();
        }

        public void InitDataSource(List<TypePatient> patients)
        {
            bindingSourceBaseData.DataSource = patients;
        }

        private void TypePatientForm_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            MyApplication.ResetTypePatientCache();
        }
    }
}