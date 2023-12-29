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
            CultureInfo.DefaultThreadCurrentCulture = PersianCulture;
            CultureInfo.DefaultThreadCurrentUICulture = PersianCulture;
        }

        public static void SetCultureToEnglish()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = EnglishCulture;
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

        private static CultureInfo CreateCultureInfoInstance(string name)
        {
            var cultureInfo = new CultureInfo(name)
            {
                DateTimeFormat =
                {
                    LongDatePattern = "yyyy/MM/dd",
                    FullDateTimePattern = "yyyy/MM/dd HH:mm:ss",
                    ShortDatePattern = "yyyy/MM/dd",
                    ShortTimePattern = "HH:mm",
                    LongTimePattern = "HH:mm:ss"
                }
            };
            return cultureInfo;
        }

        public static PersianCultureInfo PersianCulture
        {
            get
            {
                var persianCulture = new PersianCultureInfo();
                return persianCulture;
            }
        }

        public static CultureInfo EnglishCulture
        {
            get
            {
                var englishCulture = CreateCultureInfoInstance("en-US");
                return englishCulture;
            }
        }
    }
}