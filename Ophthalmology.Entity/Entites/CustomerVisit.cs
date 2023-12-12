using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Ophthalmology.Entity.Database;

namespace Ophthalmology.Entity.Entites
{
    public class CustomerVisit : EntityBase
    {
        #region ~( Fields )~

        private int _customerId;
        private string _name;
        private string _family;
        private string _tel;
        private string _dateSave;
        private string _timeVisit;
        private string _status;
        private int _price;
        private int _drId;
        private int _orderId;

        #endregion

        #region ~( Constructors )~

        public CustomerVisit()
        {
            _name = string.Empty;
            _family = string.Empty;
            _tel = string.Empty;
            _dateSave = DateTime.Now.ToString("yyyy/MM/dd", new CultureInfo("fa-IR"));
            _timeVisit = string.Empty;
            _status = string.Empty;
            _price = -1;
            _drId = -1;
            _orderId = -1;
        }

        #endregion

        #region ~( Methods )~

        public override string ToString()
        {
            if (!string.IsNullOrWhiteSpace(_name) && !string.IsNullOrWhiteSpace(_family))
            {
                return $"{_name} {_family}";
            }
            return _name;
        }

        #endregion

        #region ~( Operation )~

        public static explicit operator List<IFieldValue>(CustomerVisit customerVisit)
        {
            var fieldValues = new List<IFieldValue>
            {
                new FieldValue(nameof(Id), customerVisit.Id, nameof(Id)),
                new FieldValue(nameof(CustomerId), customerVisit.CustomerId, nameof(CustomerId)),
                new FieldValue(nameof(Name), customerVisit.Name, nameof(Name)),
                new FieldValue(nameof(Family), customerVisit.Family, nameof(Family)),
                new FieldValue(nameof(Tel), customerVisit.Tel, nameof(Tel)),
                new FieldValue(nameof(DateSave), customerVisit.DateSave, nameof(DateSave)),
                new FieldValue(nameof(TimeVisit), customerVisit.TimeVisit, nameof(TimeVisit)),
                new FieldValue(nameof(Status), customerVisit.Status, nameof(Status)),
                new FieldValue(nameof(Price), customerVisit.Price, nameof(Price)),
                new FieldValue(nameof(DrId), customerVisit.DrId, nameof(DrId)),
                new FieldValue(nameof(OrderId), customerVisit.OrderId, nameof(OrderId)),
            };
            return fieldValues;
        }

        public static explicit operator CustomerVisit(List<IFieldValue> fieldValues)
        {
            var customVisit = new CustomerVisit();

            var fieldValue = fieldValues.FirstOrDefault(x => x.Alias == nameof(Id));
            if (fieldValue != null)
            {
                var tryParse = int.TryParse(fieldValue.Value.ToString(), out var intValue);
                if (tryParse)
                {
                    customVisit._id = intValue;
                }
            }

            fieldValue = fieldValues.FirstOrDefault(x => x.Alias == nameof(CustomerId));
            if (fieldValue != null)
            {
                var tryParse = int.TryParse(fieldValue.Value.ToString(), out var intValue);
                if (tryParse)
                {
                    customVisit._customerId = intValue;
                }
            }

            fieldValue = fieldValues.FirstOrDefault(x => x.Alias == nameof(Price));
            if (fieldValue != null)
            {
                var tryParse = int.TryParse(fieldValue.Value.ToString(), out var intValue);
                if (tryParse)
                {
                    customVisit._price = intValue;
                }
            }

            fieldValue = fieldValues.FirstOrDefault(x => x.Alias == nameof(DrId));
            if (fieldValue != null)
            {
                var tryParse = int.TryParse(fieldValue.Value.ToString(), out var intValue);
                if (tryParse)
                {
                    customVisit._drId = intValue;
                }
            }

            fieldValue = fieldValues.FirstOrDefault(x => x.Alias == nameof(OrderId));
            if (fieldValue != null)
            {
                var tryParse = int.TryParse(fieldValue.Value.ToString(), out var intValue);
                if (tryParse)
                {
                    customVisit._orderId = intValue;
                }
            }

            fieldValue = fieldValues.FirstOrDefault(x => x.Alias == nameof(Name));
            if (fieldValue != null)
            {
                customVisit._name = fieldValue.Value.ToString();
            }

            fieldValue = fieldValues.FirstOrDefault(x => x.Alias == nameof(Family));
            if (fieldValue != null)
            {
                customVisit._family = fieldValue.Value.ToString();
            }

            fieldValue = fieldValues.FirstOrDefault(x => x.Alias == nameof(Tel));
            if (fieldValue != null)
            {
                customVisit._tel = fieldValue.Value.ToString();
            }

            fieldValue = fieldValues.FirstOrDefault(x => x.Alias == nameof(DateSave));
            if (fieldValue != null)
            {
                customVisit._dateSave = fieldValue.Value.ToString();
            }

            fieldValue = fieldValues.FirstOrDefault(x => x.Alias == nameof(TimeVisit));
            if (fieldValue != null)
            {
                customVisit._timeVisit = fieldValue.Value.ToString();
            }

            fieldValue = fieldValues.FirstOrDefault(x => x.Alias == nameof(Status));
            if (fieldValue != null)
            {
                customVisit._status = fieldValue.Value.ToString();
            }

            return customVisit;
        }

        public static explicit operator List<IWhereClause>(CustomerVisit customerVisit)
        {
            var fieldValues = (List<IFieldValue>)customerVisit;
            return fieldValues.Cast<IWhereClause>().ToList();
        }

        public static explicit operator CustomerVisit(List<IWhereClause> fieldValues)
        {
            var customVisit = new CustomerVisit();

            var fieldValue = fieldValues.FirstOrDefault(x => x.Alias == nameof(Id));
            if (fieldValue != null)
            {
                var tryParse = int.TryParse(fieldValue.Value.ToString(), out var intValue);
                if (tryParse)
                {
                    customVisit._id = intValue;
                }
            }

            fieldValue = fieldValues.FirstOrDefault(x => x.Alias == nameof(CustomerId));
            if (fieldValue != null)
            {
                var tryParse = int.TryParse(fieldValue.Value.ToString(), out var intValue);
                if (tryParse)
                {
                    customVisit._customerId = intValue;
                }
            }

            fieldValue = fieldValues.FirstOrDefault(x => x.Alias == nameof(Price));
            if (fieldValue != null)
            {
                var tryParse = int.TryParse(fieldValue.Value.ToString(), out var intValue);
                if (tryParse)
                {
                    customVisit._price = intValue;
                }
            }

            fieldValue = fieldValues.FirstOrDefault(x => x.Alias == nameof(DrId));
            if (fieldValue != null)
            {
                var tryParse = int.TryParse(fieldValue.Value.ToString(), out var intValue);
                if (tryParse)
                {
                    customVisit._drId = intValue;
                }
            }

            fieldValue = fieldValues.FirstOrDefault(x => x.Alias == nameof(OrderId));
            if (fieldValue != null)
            {
                var tryParse = int.TryParse(fieldValue.Value.ToString(), out var intValue);
                if (tryParse)
                {
                    customVisit._orderId = intValue;
                }
            }

            fieldValue = fieldValues.FirstOrDefault(x => x.Alias == nameof(Name));
            if (fieldValue != null)
            {
                customVisit._name = fieldValue.Value.ToString();
            }

            fieldValue = fieldValues.FirstOrDefault(x => x.Alias == nameof(Family));
            if (fieldValue != null)
            {
                customVisit._family = fieldValue.Value.ToString();
            }

            fieldValue = fieldValues.FirstOrDefault(x => x.Alias == nameof(Tel));
            if (fieldValue != null)
            {
                customVisit._tel = fieldValue.Value.ToString();
            }

            fieldValue = fieldValues.FirstOrDefault(x => x.Alias == nameof(DateSave));
            if (fieldValue != null)
            {
                customVisit._dateSave = fieldValue.Value.ToString();
            }

            fieldValue = fieldValues.FirstOrDefault(x => x.Alias == nameof(TimeVisit));
            if (fieldValue != null)
            {
                customVisit._timeVisit = fieldValue.Value.ToString();
            }

            fieldValue = fieldValues.FirstOrDefault(x => x.Alias == nameof(Status));
            if (fieldValue != null)
            {
                customVisit._status = fieldValue.Value.ToString();
            }

            return customVisit;
        }

        #endregion

        #region ~( Properties )~

        public int CustomerId
        {
            get => _customerId;
            set => SetField(ref _customerId, value);
        }

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

        public string Tel
        {
            get => _tel;
            set => SetField(ref _tel, value);
        }

        public string DateSave
        {
            get => _dateSave;
            set => SetField(ref _dateSave, value);
        }

        public string TimeVisit
        {
            get => _timeVisit;
            set => SetField(ref _timeVisit, value);
        }

        public string Status
        {
            get => _status;
            set => SetField(ref _status, value);
        }

        public int Price
        {
            get => _price;
            set => SetField(ref _price, value);
        }

        public int DrId
        {
            get => _drId;
            set => SetField(ref _drId, value);
        }

        public int OrderId
        {
            get => _orderId;
            set => SetField(ref _orderId, value);
        }

        public string SendTo
        {
            get
            {
                var value = "";
                if (Status == "ویزیت نشده")
                    value = "ارسال به دکتر";
                else if (Status == "ویزیت شده")
                    value = "ارسال به اپتومتر";

                return value;
            }
        }

        public override string TableName => "VisitList";

        #endregion
    }
}