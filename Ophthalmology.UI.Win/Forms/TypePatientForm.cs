using System.Collections.Generic;
using Ophthalmology.Entity.Entites;

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
    }
}