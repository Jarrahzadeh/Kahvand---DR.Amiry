using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Ophthalmology.Entity.Entites
{
    public abstract class EntityBase : INotifyPropertyChanged
    {
        private int _id;

        #region ~( Fields )~

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region ~( Methods )~

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

        #endregion

        #region ~( Properties )~

        public abstract string TableName { get; }

        public int Id
        {
            get => _id;
            set => SetField(ref _id, value);
        }
        
        #endregion
    }
}