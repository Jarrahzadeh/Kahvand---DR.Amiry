using System.Drawing;
using Ophthalmology.Entity.Enums;

namespace Ophthalmology.Entity.Settings
{
    public class ApplicationSettings
    {
        #region ~( Constructors )~

        public ApplicationSettings()
        {
            // Set default values.
            Font = new Font("B Koodak", 12);
            Theme = "Office2007 (Blue)";
            UserType = UserType.Doctor;
        }

        #endregion

        #region ~( Methods )~

        public void SetFormSettings(ApplicationSettings applicationSettings)
        {
            applicationSettings.Font = Font;
            applicationSettings.Theme = Theme;
            applicationSettings.UserType = UserType;
        }

        #endregion

        #region ~( Properties )~
        
        public Font Font { get; set; }
        
        public string Theme { get; set; }

        public UserType UserType { get; set; }

        #endregion
    }
}