using System.Drawing;

namespace Ophthalmology.Entity
{
    public class ApplicationSettings
    {
        public ApplicationFont Font { get; set; }
        
        public Font Font1 { get; set; }

        public void SetFormSettings(ApplicationSettings applicationSettings)
        {
            applicationSettings.Font = Font;
            applicationSettings.Font1 = Font1;
        }
    }
}
