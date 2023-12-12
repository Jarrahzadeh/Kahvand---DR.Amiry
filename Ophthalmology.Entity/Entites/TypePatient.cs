using Ophthalmology.Entity.Database;
using System.Collections.Generic;
using System.Linq;

namespace Ophthalmology.Entity.Entites
{
    /// <summary>
    /// نوع بیمه
    /// </summary>
    public class TypePatient : EntityBase
    {
        #region ~( Fields )~

        private string _name;
        private string _price;

        #endregion

        #region ~( Constructors )~

        public TypePatient()
        {
            _name = string.Empty;
            _price = string.Empty;
        }

        #endregion

        #region ~( Operation )~

        public static explicit operator List<IFieldValue>(TypePatient typePatient)
        {
            var fieldValues = new List<IFieldValue>
            {
                new FieldValue(nameof(Id), typePatient.Id, nameof(Id)),
                new FieldValue(nameof(Name), typePatient.Name, nameof(Name)),
                new FieldValue(nameof(Price), typePatient.Price, nameof(Price))
            };
            return fieldValues;
        }

        public static explicit operator TypePatient(List<IFieldValue> fieldValues)
        {
            var typePatient = new TypePatient();

            var fieldValue = fieldValues.FirstOrDefault(x => x.Alias == nameof(Id));
            if (fieldValue != null)
            {
                var tryParse = int.TryParse(fieldValue.Value.ToString(), out var intValue);
                if (tryParse)
                {
                    typePatient._id = intValue;
                }
            }

            fieldValue = fieldValues.FirstOrDefault(x => x.Alias == nameof(Price));
            if (fieldValue != null)
            {
                typePatient._price = fieldValue.Value.ToString();
            }

            fieldValue = fieldValues.FirstOrDefault(x => x.Alias == nameof(Name));
            if (fieldValue != null)
            {
                typePatient._name = fieldValue.Value.ToString();
            }

            return typePatient;
        }

        #endregion

        #region ~( Properties )~

        public string Name
        {
            get => _name;
            set => SetField(ref _name, value);
        }

        public string Price
        {
            get => _price;
            set => SetField(ref _price, value);
        }

        public override string TableName => "TypePatient";

        #endregion
    }
}