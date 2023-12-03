using System.Globalization;

namespace Ophthalmology.Utility.Helpers
{
    public class PersianCultureInfo : CultureInfo
    {
        private readonly Calendar[] _optionals;
        private readonly PersianCalendar _persianCalendar;

        public PersianCultureInfo()
            : this("fa-IR", true) { }

        public PersianCultureInfo(string cultureName, bool useUserOverride)
            : base(cultureName, useUserOverride)
        {
            //var optionalCalendars = new List<Calendar>();
            //optionalCalendars.AddRange(base.OptionalCalendars);

            _persianCalendar = new PersianCalendar();
            //optionalCalendars.Insert(0, _persianCalendar);

            //var formatType = typeof(DateTimeFormatInfo);
            //var calendarType = typeof(Calendar);
            //var idProperty = calendarType.GetProperty("ID", BindingFlags.Instance | BindingFlags.NonPublic);
            //var optionalCalendarField = formatType.GetField("optionalCalendars", BindingFlags.Instance | BindingFlags.NonPublic);
            //var newOptionalCalendarIDs = new int[optionalCalendars.Count];

            //for (var i = 0; i < newOptionalCalendarIDs.Length; i++)
            //    newOptionalCalendarIDs[i] = (int)idProperty.GetValue(optionalCalendars[i], null);

            //optionalCalendarField.SetValue(DateTimeFormat, newOptionalCalendarIDs);

            //_optionals = optionalCalendars.ToArray();

            DateTimeFormat.Calendar = _persianCalendar;
            DateTimeFormat.LongDatePattern = "yyyy/MM/dd";
            DateTimeFormat.FullDateTimePattern = "yyyy/MM/dd HH:mm:ss";
            DateTimeFormat.ShortDatePattern = "yyyy/MM/dd";
            DateTimeFormat.ShortTimePattern = "HH:mm";
            DateTimeFormat.LongTimePattern = "HH:mm:ss";
        }

        public override Calendar Calendar => _persianCalendar;

        public override Calendar[] OptionalCalendars => _optionals;
    }
}