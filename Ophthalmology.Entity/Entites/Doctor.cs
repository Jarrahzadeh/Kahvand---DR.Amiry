using Ophthalmology.Entity.Database;
using System.Collections.Generic;
using System.Linq;

namespace Ophthalmology.Entity.Entites
{
    public class Doctor : EntityBase
    {
        #region ~( Fields )~

        private string _name;

        #endregion

        #region ~( Constructors )~

        public Doctor()
        {
            _name = string.Empty;
        }

        #endregion

        #region ~( Operation )~

        public static explicit operator List<IFieldValue>(Doctor doctor)
        {
            var fieldValues = new List<IFieldValue>
            {
                new FieldValue(nameof(Id), doctor.Id, nameof(Id)),
                new FieldValue(nameof(Name), doctor.Name, nameof(Name))
            };
            return fieldValues;
        }

        public static explicit operator Doctor(List<IFieldValue> fieldValues)
        {
            var doctor = new Doctor();

            var fieldValue = fieldValues.FirstOrDefault(x => x.Alias == nameof(Id));
            if (fieldValue != null)
            {
                var tryParse = int.TryParse(fieldValue.Value.ToString(), out var intValue);
                if (tryParse)
                {
                    doctor._id = intValue;
                }
            }
            
            fieldValue = fieldValues.FirstOrDefault(x => x.Alias == nameof(Name));
            if (fieldValue != null)
            {
                doctor._name = fieldValue.Value.ToString();
            }

            return doctor;
        }

        #endregion
        
        #region ~( Properties )~

        public string Name
        {
            get => _name;
            set => SetField(ref _name, value);
        }

        public override string TableName => "Dr";

        #endregion
    }
}