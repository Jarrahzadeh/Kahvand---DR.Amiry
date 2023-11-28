using Janus.Windows.GridEX;

namespace Ophthalmology.Controls.CustomControls
{
    public class CustomGridEx : GridEX
    {
        public CustomGridEx()
        {
            RootTable = new GridEXTable
            {
                AllowAddNew = InheritableBoolean.False,
                AllowChildTableGroups = InheritableBoolean.False,
                AllowDelete = InheritableBoolean.False,
                AllowGroup = true,
                AllowEdit = InheritableBoolean.False,
                AllowRemoveColumns = InheritableBoolean.False,
                CellToolTip = CellToolTip.UseCellToolTipText
            };


            BuiltInTexts[GridEXBuiltInText.GroupByBoxInfo] = "سطری را جهت گروه بندی به اینجا بکشید";
            
            BuiltInTexts[GridEXBuiltInText.CalendarNoneButton] = "هیچی";
            BuiltInTexts[GridEXBuiltInText.CalendarTodayButton] = "امروز";
            
            BuiltInTexts[GridEXBuiltInText.RecordNavigator] = "سطر|از";
            BuiltInTexts[GridEXBuiltInText.RecordNavigatorError] = "خطا";
            
            BuiltInTexts[GridEXBuiltInText.EmptyGridInfo] = "لیست خالی است و موردی ثبت نشده است";
            
            BuiltInTexts[GridEXBuiltInText.OutlookDateEmpty] = "";
            BuiltInTexts[GridEXBuiltInText.OutlookDateOlder] = "";
            BuiltInTexts[GridEXBuiltInText.OutlookDateLastMonth] = "";
            BuiltInTexts[GridEXBuiltInText.OutlookDateEarlierThisMonth] = "";
            BuiltInTexts[GridEXBuiltInText.OutlookDateThreeWeeksAgo] = "";
            BuiltInTexts[GridEXBuiltInText.OutlookDateTwoWeeksAgo] = "";
            BuiltInTexts[GridEXBuiltInText.OutlookDateLastWeek] = "";
            BuiltInTexts[GridEXBuiltInText.OutlookDateYesterday] = "";
            BuiltInTexts[GridEXBuiltInText.OutlookDateToday] = "";
            BuiltInTexts[GridEXBuiltInText.OutlookDateTomorrow] = "";
            BuiltInTexts[GridEXBuiltInText.OutlookDateNextWeek] = "";
            BuiltInTexts[GridEXBuiltInText.OutlookDateTwoWeeksAway] = "";
            BuiltInTexts[GridEXBuiltInText.OutlookDateThreeWeeksAway] = "";
            BuiltInTexts[GridEXBuiltInText.OutlookDateLaterThisMonth] = "";
            BuiltInTexts[GridEXBuiltInText.OutlookDateNextMonth] = "";
            BuiltInTexts[GridEXBuiltInText.OutlookDateBeyondNextMonth] = "";

            BuiltInTexts[GridEXBuiltInText.DropDownOkButton] = "تایید";
            BuiltInTexts[GridEXBuiltInText.DropDownCancelButton] = "انصراف";
            
            BuiltInTexts[GridEXBuiltInText.FilterRowInfoText] = "فیلتر";
            BuiltInTexts[GridEXBuiltInText.FilterRowConditionEqual] = "برابر";
            BuiltInTexts[GridEXBuiltInText.FilterRowConditionNotEqual] = "نابرابر";
            BuiltInTexts[GridEXBuiltInText.FilterRowConditionGreaterThan] = "بزرگتر از";
            BuiltInTexts[GridEXBuiltInText.FilterRowConditionGreaterThanOrEqual] = "بزرگتر یا برابر";
            BuiltInTexts[GridEXBuiltInText.FilterRowConditionLessThan] = "کوچکتر از";
            BuiltInTexts[GridEXBuiltInText.FilterRowConditionLessThanOrEqual] = "کوچکتر یا برابر";
            BuiltInTexts[GridEXBuiltInText.FilterRowConditionContains] = "شامل";
            BuiltInTexts[GridEXBuiltInText.FilterRowConditionNotContains] = "شامل نشود";
            BuiltInTexts[GridEXBuiltInText.FilterRowConditionEndsWith] = "پایان با";
            BuiltInTexts[GridEXBuiltInText.FilterRowConditionBeginsWith] = "شروع با";
            BuiltInTexts[GridEXBuiltInText.FilterRowConditionIsEmpty] = "خالی";
            BuiltInTexts[GridEXBuiltInText.FilterRowConditionNotIsEmpty] = "پر";
            BuiltInTexts[GridEXBuiltInText.FilterRowConditionClear] = "پاک کردن";
        }
    }
}
