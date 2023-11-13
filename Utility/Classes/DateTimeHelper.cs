using System;
using Utility.Classes;

namespace Ophthalmology.Utility.Classes
{
    public class DateTimeHelper
    {
        public static string GetPersianDate()
        {
            return DateTime.Now.ToString(CultureHelper.PersianCulture.DateTimeFormat.ShortDatePattern, CultureHelper.PersianCulture);
        }
    }
}
