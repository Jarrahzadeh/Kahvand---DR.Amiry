using System;
using System.Globalization;

namespace Ophthalmology.Entity.Entites
{
    public class Customer : EntityBase
    {
        #region ~( Private Fields )~

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
            if (!string.IsNullOrWhiteSpace(_name) && !string.IsNullOrWhiteSpace(_family))
            {
                return $"{_name} {_family}";
            }

            //if (!string.IsNullOrWhiteSpace(_name))
            //{
                return _name;
            //}

            //return !string.IsNullOrWhiteSpace(_family) ? _family : base.ToString();
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

        public bool EyeLeftHasData => !string.IsNullOrEmpty(EyeLeft);

        public bool EyeRightHasData => !string.IsNullOrEmpty(EyeRight);

        #endregion
    }
}