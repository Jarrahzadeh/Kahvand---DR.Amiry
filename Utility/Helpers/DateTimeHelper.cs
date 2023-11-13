using System;

namespace Ophthalmology.Utility.Helpers
{
    public class DateTimeHelper
    {
        public static string GetPersianDate()
        {
            return DateTime.Now.ToString(CultureHelper.PersianCulture.DateTimeFormat.ShortDatePattern, CultureHelper.PersianCulture);
        }
    }
}
