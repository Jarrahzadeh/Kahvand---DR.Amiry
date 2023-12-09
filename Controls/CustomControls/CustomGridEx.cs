using Janus.Windows.GridEX;

namespace Ophthalmology.Controls.CustomControls
{
    public class CustomGridEx : GridEX
    {
        private System.Windows.Forms.ContextMenuStrip contextMenuGridRightClick;
        private System.Windows.Forms.ToolStripMenuItem MenuItemGrouping;
        private System.Windows.Forms.ToolStripMenuItem MenuItemColumnSelector;
        private System.ComponentModel.IContainer components;

        public CustomGridEx()
        {
            InitializeComponent();

            InitGrid();
            MenuItemGrouping.Checked = GroupByBoxVisible;
        }

        private void InitGrid()
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

            //SaveSettings = true;

            AllowEdit = InheritableBoolean.False;
            AlternatingColors = true;
            ColumnAutoResize = true;
            FilterMode = FilterMode.Automatic;
            FilterRowButtonStyle = FilterRowButtonStyle.ConditionOperatorDropDown;
            FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges;
            TabKeyBehavior = TabKeyBehavior.ControlNavigation;
            HideSelection = HideSelection.HighlightInactive;


            InitBuiltInTexts();
        }

        private void InitBuiltInTexts()
        {
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

            BuiltInTexts[GridEXBuiltInText.FilterRowInfoText] = "جستجو در لیست بر اساس هر ستون";
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

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuGridRightClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuItemGrouping = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemColumnSelector = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuGridRightClick.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuGridRightClick
            // 
            this.contextMenuGridRightClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemGrouping,
            this.MenuItemColumnSelector});
            this.contextMenuGridRightClick.Name = "contextMenuGridRightClick";
            this.contextMenuGridRightClick.Size = new System.Drawing.Size(157, 48);
            // 
            // MenuItemGrouping
            // 
            this.MenuItemGrouping.CheckOnClick = true;
            this.MenuItemGrouping.Name = "MenuItemGrouping";
            this.MenuItemGrouping.Size = new System.Drawing.Size(156, 22);
            this.MenuItemGrouping.Text = "نمایش گروهبندی";
            this.MenuItemGrouping.Click += new System.EventHandler(this.MenuItemGrouping_Click);
            // 
            // MenuItemColumnSelector
            // 
            this.MenuItemColumnSelector.Name = "MenuItemColumnSelector";
            this.MenuItemColumnSelector.Size = new System.Drawing.Size(156, 22);
            this.MenuItemColumnSelector.Text = "لیست ستون ها";
            this.MenuItemColumnSelector.Click += new System.EventHandler(this.MenuItemColumnSelector_Click);
            // 
            // CustomGridEx
            // 
            this.ContextMenuStrip = this.contextMenuGridRightClick;
            this.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            this.SettingsKey = "CustomGrid";
            this.TabKeyBehavior = Janus.Windows.GridEX.TabKeyBehavior.ControlNavigation;
            this.contextMenuGridRightClick.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        private void MenuItemGrouping_Click(object sender, System.EventArgs e)
        {
            GroupByBoxVisible = MenuItemGrouping.Checked;
        }

        private void MenuItemColumnSelector_Click(object sender, System.EventArgs e)
        {
            ShowFieldChooser(ParentForm, "انتخاب ستون ها");
        }

        public void ApplyFilter(GridEXColumn column, string filterValue)
        {
            FilterRow.Cells[column].Text = filterValue;
            var condition = new GridEXFilterCondition(column, ConditionOperator.BeginsWith, filterValue);
            RootTable.ApplyFilter(condition);
        }
    }
}