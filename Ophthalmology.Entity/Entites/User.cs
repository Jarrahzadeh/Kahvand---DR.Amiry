using Ophthalmology.Entity.Database;
using System.Collections.Generic;
using System.Linq;

namespace Ophthalmology.Entity.Entites
{
    public class User : EntityBase
    {
        #region ~( Fields )~

        private string _userName;
        private string _password;
        private string _firstName;
        private string _lastName;
        private int _userTypeId;

        #endregion

        #region ~( Constructors )~

        public User()
        {
            _userName = string.Empty;
            _password = string.Empty;
            _firstName = string.Empty;
            _lastName = string.Empty;
        }

        #endregion

        #region ~( Methods )~

        public override string ToString()
        {
            return string.IsNullOrEmpty(FullName) ?
                base.ToString() :
                FullName;
        }

        #endregion

        #region ~( Operation )~

        public static explicit operator List<IFieldValue>(User user)
        {
            var fieldValues = new List<IFieldValue>
            {
                new FieldValue(nameof(Id), user.Id, nameof(Id)),
                new FieldValue(nameof(Name), user.Name, nameof(Name)),
                new FieldValue(nameof(Pass), user.Pass, nameof(Pass)),
                new FieldValue(nameof(FirstName), user.FirstName, nameof(FirstName)),
                new FieldValue(nameof(LastName), user.LastName, nameof(LastName))
            };
            return fieldValues;
        }

        public static explicit operator User(List<IFieldValue> fieldValues)
        {
            var user = new User();

            var fieldValue = fieldValues.FirstOrDefault(x => x.Alias == nameof(Id));
            if (fieldValue != null)
            {
                var tryParse = int.TryParse(fieldValue.Value.ToString(), out var intValue);
                if (tryParse)
                {
                    user._id = intValue;
                }
            }

            fieldValue = fieldValues.FirstOrDefault(x => x.Alias == nameof(Name));
            if (fieldValue != null)
            {
                user._userName = fieldValue.Value.ToString();
            }

            fieldValue = fieldValues.FirstOrDefault(x => x.Alias == nameof(Pass));
            if (fieldValue != null)
            {
                user._password = fieldValue.Value.ToString();
            }

            fieldValue = fieldValues.FirstOrDefault(x => x.Alias == nameof(FirstName));
            if (fieldValue != null)
            {
                user._firstName = fieldValue.Value.ToString();
            }

            fieldValue = fieldValues.FirstOrDefault(x => x.Alias == nameof(LastName));
            if (fieldValue != null)
            {
                user._lastName = fieldValue.Value.ToString();
            }

            return user;
        }

        #endregion

        #region ~( Properties )~

        public string Name
        {
            get => _userName;
            set => SetField(ref _userName, value);
        }

        public string Pass
        {
            get => _password;
            set => SetField(ref _password, value);
        }

        public string FirstName
        {
            get => _firstName;
            set => SetField(ref _firstName, value);
        }

        public string LastName
        {
            get => _lastName;
            set => SetField(ref _lastName, value);
        }

        public int UserTypeId
        {
            get => _userTypeId;
            set => SetField(ref _userTypeId, value);
        }

        public string FullName => $"{LastName} {FirstName}".Trim();

        public override string TableName => "User1";

        #endregion
    }
}