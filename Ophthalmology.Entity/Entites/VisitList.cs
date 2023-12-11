namespace Ophthalmology.Entity.Entites
{
    public class VisitList : EntityBase
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

        public VisitList()
        {
            _name = string.Empty;
            _family = string.Empty;
            _tel = string.Empty;
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

        public override string TableName => "VisitList";

        #endregion
    }
}