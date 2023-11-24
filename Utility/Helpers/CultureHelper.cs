using System.Globalization;
using System.Windows.Forms;

namespace Ophthalmology.Utility.Helpers
{
    public class CultureHelper
    {
        public static void SetCultureToPersian()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = PersianCulture;
            System.Threading.Thread.CurrentThread.CurrentUICulture = PersianCulture;
        }

        public static void SetCultureToEnglish()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture =   EnglishCulture;
            System.Threading.Thread.CurrentThread.CurrentUICulture = EnglishCulture;
        }

        public static void SetInputLanguageToPersian()
        {
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(PersianCulture);
        }

        public static void SetInputLanguageToEnglish()
        {
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(EnglishCulture);
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

        public static CultureInfo EnglishCulture
        {
            get
            {
                var persianCulture = new CultureInfo("en-US");
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