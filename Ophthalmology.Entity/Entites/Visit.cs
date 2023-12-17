using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Ophthalmology.Entity.Database;

namespace Ophthalmology.Entity.Entites
{
    public class Visit : EntityBase
    {
        #region ~( Fields )~

        private int _customerId;
        private string _dateVisit;
        private string _timeVisit;
        private string _status;
        private int _price;
        private int _drId;
        private int _orderId;

        #endregion

        #region ~( Constructors )~

        public Visit()
        {
            _dateVisit = DateTime.Now.ToString("yyyy/MM/dd", new CultureInfo("fa-IR"));
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
            if (!string.IsNullOrWhiteSpace(_status))
            {
                return _status;
            }
            return base.ToString();
        }

        #endregion

        #region ~( Operation )~

        public static explicit operator List<IFieldValue>(Visit customerVisit)
        {
            var fieldValues = new List<IFieldValue>
            {
                new FieldValue("Code_Customer", customerVisit.CustomerId, "Code_Customer"),
                new FieldValue(nameof(TimeVisit), customerVisit.TimeVisit, nameof(TimeVisit)),
                new FieldValue(nameof(DateVisit), customerVisit.DateVisit, nameof(DateVisit)),
                new FieldValue(nameof(Status), customerVisit.Status, nameof(Status)),
                new FieldValue(nameof(Price), customerVisit.Price, nameof(Price)),
                new FieldValue(nameof(DrId), customerVisit.DrId, nameof(DrId)),
                new FieldValue(nameof(OrderId), customerVisit.OrderId, nameof(OrderId)),
            };
            return fieldValues;
        }

        public static explicit operator Visit(List<IFieldValue> fieldValues)
        {
            var customVisit = new Visit();

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

            fieldValue = fieldValues.FirstOrDefault(x => x.Alias == nameof(DateVisit));
            if (fieldValue != null)
            {
                customVisit._dateVisit = fieldValue.Value.ToString();
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

        public static explicit operator List<IWhereClause>(Visit customerVisit)
        {
            var fieldValues = (List<IFieldValue>)customerVisit;
            return fieldValues.Cast<IWhereClause>().ToList();
        }

        public static explicit operator Visit(List<IWhereClause> fieldValues)
        {
            var customVisit = new Visit();

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

            fieldValue = fieldValues.FirstOrDefault(x => x.Alias == nameof(DateVisit));
            if (fieldValue != null)
            {
                customVisit._dateVisit = fieldValue.Value.ToString();
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

        public string DateVisit
        {
            get => _dateVisit;
            set => SetField(ref _dateVisit, value);
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