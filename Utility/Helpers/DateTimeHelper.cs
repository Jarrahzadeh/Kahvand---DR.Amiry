using System;

namespace Ophthalmology.Utility.Helpers
{
    public static class DateTimeHelper
    {
        public static string GetPersianDate()
        {
            return DateTime.Now.ToPersianDate();
        }

        public static string ToPersianDateTime(this DateTime gregorianDateTime)
        {
            var shortDatePattern = CultureHelper.PersianCulture.DateTimeFormat.FullDateTimePattern;
            return gregorianDateTime.ToString(shortDatePattern, CultureHelper.PersianCulture);
        }
        
        public static string ToPersianDate(this DateTime gregorianDateTime)
        {
            var shortDatePattern = CultureHelper.PersianCulture.DateTimeFormat.ShortDatePattern;
            return gregorianDateTime.ToString(shortDatePattern, CultureHelper.PersianCulture);
        }
        
        public static string ToPersianTime(this DateTime gregorianDateTime)
        {
            var shortTimePattern = CultureHelper.PersianCulture.DateTimeFormat.ShortTimePattern;
            return gregorianDateTime.ToString(shortTimePattern, CultureHelper.PersianCulture);
        }
    }
}
