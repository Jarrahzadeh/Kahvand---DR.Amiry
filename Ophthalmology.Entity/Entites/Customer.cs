using Ophthalmology.Entity.Database;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Ophthalmology.Entity.Entites
{
    public class Customer : EntityBase
    {
        #region ~( Fields )~

        private string _name;
        private string _family;
        private string _nameFather;
        private string _address;
        private string _reason;
        private string _tel;
        private string _dis;
        private string _age;
        private string _eyeLeft;
        private string _eyeRight;
        private string _dateSave;
        private int _drId;
        private int _idTypePatient;

        #endregion

        #region ~( Constructors )~

        public Customer()
        {
            _name = string.Empty;
            _family = string.Empty;
            _nameFather = string.Empty;
            _address = string.Empty;
            _reason = string.Empty;
            _tel = string.Empty;
            _dis = string.Empty;
            _age = string.Empty;
            _eyeLeft = string.Empty;
            _eyeRight = string.Empty;
            _dateSave = DateTime.Now.ToString("yyyy/MM/dd", new CultureInfo("fa-IR"));
            //_drId = 0;
            //_idTypePatient = 0;
        }

        #endregion

        #region ~( Methods )~

        public override string ToString()
        {
            return FullName;
        }

        #endregion

        #region ~( Operation )~

        public static explicit operator List<IFieldValue>(Customer customer)
        {
            var fieldValues = new List<IFieldValue>
            {
                new FieldValue(nameof(Id), customer.Id, nameof(Id)),
                new FieldValue(nameof(Name), customer.Name, nameof(Name)),
                new FieldValue(nameof(Family), customer.Family, nameof(Family)),
                new FieldValue(nameof(NameFather), customer.NameFather, nameof(NameFather)),
                new FieldValue(nameof(Address), customer.Address, nameof(Address)),
                new FieldValue(nameof(Reason), customer.Reason, nameof(Reason)),
                new FieldValue(nameof(Tel), customer.Tel, nameof(Tel)),
                new FieldValue(nameof(Dis), customer.Dis, nameof(Dis)),
                new FieldValue(nameof(Age), customer.Age, nameof(Age)),
                new FieldValue(nameof(EyeLeft), customer.EyeLeft, nameof(EyeLeft)),
                new FieldValue(nameof(EyeRight), customer.EyeRight, nameof(EyeRight)),
                new FieldValue(nameof(DateSave), customer.DateSave, nameof(DateSave)),
                new FieldValue(nameof(DrId), customer.DrId, nameof(DrId)),
                new FieldValue(nameof(IdTypePatient), customer.IdTypePatient, nameof(IdTypePatient)),
            };
            return fieldValues;
        }

        public static explicit operator Customer(List<IFieldValue> fieldValues)
        {
            var customer = new Customer();

            var fieldValue = fieldValues.FirstOrDefault(x => x.Alias == nameof(Id));
            if (fieldValue != null)
            {
                var tryParse = int.TryParse(fieldValue.Value.ToString(), out var intValue);
                if (tryParse)
                {
                    customer._id = intValue;
                }
            }

            fieldValue = fieldValues.FirstOrDefault(x => x.Alias == nameof(IdTypePatient));
            if (fieldValue != null)
            {
                var tryParse = int.TryParse(fieldValue.Value.ToString(), out var intValue);
                if (tryParse)
                {
                    customer._idTypePatient = intValue;
                }
            }
            
            fieldValue = fieldValues.FirstOrDefault(x => x.Alias == nameof(DrId));
            if (fieldValue != null)
            {
                var tryParse = int.TryParse(fieldValue.Value.ToString(), out var intValue);
                if (tryParse)
                {
                    customer._drId = intValue;
                }
            }

            fieldValue = fieldValues.FirstOrDefault(x => x.Alias == nameof(Name));
            if (fieldValue != null)
            {
                customer._name = fieldValue.Value.ToString();
            }

            fieldValue = fieldValues.FirstOrDefault(x => x.Alias == nameof(Family));
            if (fieldValue != null)
            {
                customer._family = fieldValue.Value.ToString();
            }

            fieldValue = fieldValues.FirstOrDefault(x => x.Alias == nameof(NameFather));
            if (fieldValue != null)
            {
                customer._nameFather = fieldValue.Value.ToString();
            }

            fieldValue = fieldValues.FirstOrDefault(x => x.Alias == nameof(Address));
            if (fieldValue != null)
            {
                customer._address = fieldValue.Value.ToString();
            }

            fieldValue = fieldValues.FirstOrDefault(x => x.Alias == nameof(Reason));
            if (fieldValue != null)
            {
                customer._reason = fieldValue.Value.ToString();
            }

            fieldValue = fieldValues.FirstOrDefault(x => x.Alias == nameof(Tel));
            if (fieldValue != null)
            {
                customer._tel = fieldValue.Value.ToString();
            }

            fieldValue = fieldValues.FirstOrDefault(x => x.Alias == nameof(Dis));
            if (fieldValue != null)
            {
                customer._dis = fieldValue.Value.ToString();
            }

            fieldValue = fieldValues.FirstOrDefault(x => x.Alias == nameof(Age));
            if (fieldValue != null)
            {
                customer._age = fieldValue.Value.ToString();
            }

            fieldValue = fieldValues.FirstOrDefault(x => x.Alias == nameof(EyeLeft));
            if (fieldValue != null)
            {
                customer._eyeLeft = fieldValue.Value.ToString();
            }

            fieldValue = fieldValues.FirstOrDefault(x => x.Alias == nameof(EyeRight));
            if (fieldValue != null)
            {
                customer._eyeRight = fieldValue.Value.ToString();
            }

            fieldValue = fieldValues.FirstOrDefault(x => x.Alias == nameof(DateSave));
            if (fieldValue != null)
            {
                customer._dateSave = fieldValue.Value.ToString();
            }

            return customer;
        }

        #endregion
        
        #region ~( Properties )~

        public string Name
        {
            get => _name;
            set => SetField(ref _name, value);
        }

        public string Family
        {
            get => _family;
            set => SetField(ref _family, value);
        }

        public string NameFather
        {
            get => _nameFather;
            set => SetField(ref _nameFather, value);
        }

        public string Address
        {
            get => _address;
            set => SetField(ref _address, value);
        }

        public string Reason
        {
            get => _reason;
            set => SetField(ref _reason, value);
        }

        public string Tel
        {
            get => _tel;
            set => SetField(ref _tel, value);
        }

        public string Dis
        {
            get => _dis;
            set => SetField(ref _dis, value);
        }

        public string Age
        {
            get => _age;
            set => SetField(ref _age, value);
        }

        public string EyeLeft
        {
            get => _eyeLeft;
            set => SetField(ref _eyeLeft, value);
        }

        public string EyeRight
        {
            get => _eyeRight;
            set => SetField(ref _eyeRight, value);
        }

        public string DateSave
        {
            get => _dateSave;
            set => SetField(ref _dateSave, value);
        }

        public int DrId
        {
            get => _drId;
            set => SetField(ref _drId, value);
        }

        public int IdTypePatient
        {
            get => _idTypePatient;
            set => SetField(ref _idTypePatient, value);
        }

        public override string TableName => "Customer";

        public string FullName
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(_name) && !string.IsNullOrWhiteSpace(_family))
                {
                    return $"{_family} {_name}";
                }

                return _name;
            }
        }

        #endregion
    }
}