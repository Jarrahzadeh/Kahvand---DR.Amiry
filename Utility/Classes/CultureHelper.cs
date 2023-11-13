using System.Globalization;
using System.Windows.Forms;

namespace Utility.Classes
{
    public class CultureHelper
    {
        public static void SetCultureToPersian()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = PersianCulture;
            System.Threading.Thread.CurrentThread.CurrentUICulture = PersianCulture;
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(PersianCulture);
        }

        public static CultureInfo PersianCulture
        {
            get
            {
                var persianCulture = new CultureInfo("fa-IR");
                persianCulture.DateTimeFormat.LongDatePattern = "yyyy/MM/dd";
                persianCulture.DateTimeFormat.FullDateTimePattern = "yyyy/MM/dd HH:mm:ss";
                persianCulture.DateTimeFormat.ShortDatePattern = "yyyy/MM/dd";
                persianCulture.DateTimeFormat.ShortTimePattern = "HH:mm";
                persianCulture.DateTimeFormat.LongTimePattern = "HH:mm:ss";
                return persianCulture;
            }
        }
    }
}