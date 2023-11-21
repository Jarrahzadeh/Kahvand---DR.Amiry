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
            BuiltInTexts[GridEXBuiltInText.FilterRowConditionEqual] = "";
            BuiltInTexts[GridEXBuiltInText.FilterRowConditionNotEqual] = "";
            BuiltInTexts[GridEXBuiltInText.FilterRowConditionGreaterThan] = "";
            BuiltInTexts[GridEXBuiltInText.FilterRowConditionGreaterThanOrEqual] = "";
            BuiltInTexts[GridEXBuiltInText.FilterRowConditionLessThan] = "";
            BuiltInTexts[GridEXBuiltInText.FilterRowConditionLessThanOrEqual] = "";
            BuiltInTexts[GridEXBuiltInText.FilterRowConditionContains] = "";
            BuiltInTexts[GridEXBuiltInText.FilterRowConditionNotContains] = "";
            BuiltInTexts[GridEXBuiltInText.FilterRowConditionEndsWith] = "";
            BuiltInTexts[GridEXBuiltInText.FilterRowConditionBeginsWith] = "";
            BuiltInTexts[GridEXBuiltInText.FilterRowConditionIsEmpty] = "";
            BuiltInTexts[GridEXBuiltInText.FilterRowConditionNotIsEmpty] = "";
            BuiltInTexts[GridEXBuiltInText.FilterRowConditionClear] = "";

            GroupByBoxVisible = false;
            Office2007ColorScheme = Office2007ColorScheme.Blue;
            VisualStyle = VisualStyle.Office2007;
        }
    }
}
