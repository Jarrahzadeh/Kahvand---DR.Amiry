using System.Drawing;

namespace Ophthalmology.Entity
{
    public class ApplicationSettings
    {
        #region ~( Constructors )~

        public ApplicationSettings()
        {
            // Set default values.
            Font = new Font("B Koodak", 12);
            Theme = "Office2007 (Blue)";
        }

        #endregion
        #region ~( Methods )~

        public void SetFormSettings(ApplicationSettings applicationSettings)
        {
            applicationSettings.Font = Font;
            applicationSettings.Theme = Theme;
        }

        #endregion

        #region ~( Properties )~
        
        public Font Font { get; set; }
        
        public string Theme { get; set; }

        #endregion
    }
}
