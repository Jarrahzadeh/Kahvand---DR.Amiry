using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Ophthalmology.Entity.Entites
{
    public class Customer : EntityBase, INotifyPropertyChanged
    {
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

        public string Name
        {
            get => _name;
            set
            {
                if (_name != value)
                {
                    SetField(ref _name, value);
                }
            }
        }

        public string Family
        {
            get => _family;
            set
            {
                if (_family != value)
                {
                    SetField(ref _family, value);
                }
            }
        }

        public string NameFather
        {
            get => _nameFather;
            set
            {
                if (_nameFather != value)
                {
                    SetField(ref _nameFather, value);
                }
            }
        }

        public string Address
        {
            get => _address;
            set
            {
                if (_address != value)
                {
                    SetField(ref _address, value);
                }
            }
        }

        public string Reason
        {
            get => _reason;
            set
            {
                if (_reason != value)
                {
                    SetField(ref _reason, value);
                }
            }
        }

        public string Tel
        {
            get => _tel;
            set
            {
                if (_tel != value)
                {
                    SetField(ref _tel, value);
                }
            }
        }

        public string Dis
        {
            get => _dis;
            set
            {
                if (_dis != value)
                {
                    SetField(ref _dis, value);
                }
            }
        }

        public string Age
        {
            get => _age;
            set
            {
                if (_age != value)
                {
                    SetField(ref _age, value);
                }
            }
        }

        public string EyeLeft
        {
            get => _eyeLeft;
            set
            {
                if (_eyeLeft != value)
                {
                    SetField(ref _eyeLeft, value);
                }
            }
        }

        public string EyeRight
        {
            get => _eyeRight;
            set
            {
                if (_eyeRight != value)
                {
                    SetField(ref _eyeRight, value);
                }
            }
        }

        public string DateSave
        {
            get => _dateSave;
            set
            {
                if (_dateSave != value)
                {
                    SetField(ref _dateSave, value);
                }
            }
        }

        public int DrId
        {
            get => _drId;
            set
            {
                if (_drId != value)
                {
                    SetField(ref _drId, value);
                }
            }
        }

        public int IdTypePatient
        {
            get => _idTypePatient;
            set
            {
                if (_idTypePatient != value)
                {
                    SetField(ref _idTypePatient, value);
                }
            }
        }

        public override string TableName => "Customer";

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;

            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}