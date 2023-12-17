namespace Ophthalmology.UI.Win.Forms
{
    partial class AppointmentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Janus.Windows.GridEX.GridEXLayout multiColumnComboCustomer_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppointmentForm));
            Janus.Windows.GridEX.GridEXLayout customGridVisitList_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.bindingSourceCustomers = new System.Windows.Forms.BindingSource(this.components);
            this.multiColumnComboCustomer = new Janus.Windows.GridEX.EditControls.MultiColumnCombo();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerVisitDate = new BehComponents.DateTimePickerX();
            this.maskedBoxTime = new Janus.Windows.GridEX.EditControls.MaskedEditBox();
            this.textBoxPrice = new Janus.Windows.GridEX.EditControls.EditBox();
            this.buttonAdd = new Janus.Windows.EditControls.UIButton();
            this.uiGroupBox1 = new Janus.Windows.EditControls.UIGroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.customGridVisitList = new Ophthalmology.Controls.CustomControls.CustomGridEx();
            this.bindingSourceVisitList = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerVisitList = new BehComponents.DateTimePickerX();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.multiColumnComboCustomer)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).BeginInit();
            this.uiGroupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customGridVisitList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceVisitList)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSourceCustomers
            // 
            this.bindingSourceCustomers.DataSource = typeof(Ophthalmology.Entity.Entites.Customer);
            // 
            // multiColumnComboCustomer
            // 
            this.multiColumnComboCustomer.AutoComplete = false;
            this.multiColumnComboCustomer.DataSource = this.bindingSourceCustomers;
            multiColumnComboCustomer_DesignTimeLayout.LayoutString = resources.GetString("multiColumnComboCustomer_DesignTimeLayout.LayoutString");
            this.multiColumnComboCustomer.DesignTimeLayout = multiColumnComboCustomer_DesignTimeLayout;
            this.multiColumnComboCustomer.DisplayMember = "FullName";
            this.multiColumnComboCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.multiColumnComboCustomer.Location = new System.Drawing.Point(271, 44);
            this.multiColumnComboCustomer.Name = "multiColumnComboCustomer";
            this.multiColumnComboCustomer.SelectedIndex = -1;
            this.multiColumnComboCustomer.SelectedItem = null;
            this.multiColumnComboCustomer.Size = new System.Drawing.Size(228, 35);
            this.multiColumnComboCustomer.TabIndex = 1;
            this.multiColumnComboCustomer.ValueMember = "Id";
            this.multiColumnComboCustomer.VisualStyleManager = this.visualStyleManager;
            this.multiColumnComboCustomer.ValueChanged += new System.EventHandler(this.MultiColumnCombo1ValueChanged);
            this.multiColumnComboCustomer.TextChanged += new System.EventHandler(this.MultiColumnCombo1TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.multiColumnComboCustomer, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePickerVisitDate, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.maskedBoxTime, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxPrice, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonAdd, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(588, 134);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(505, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 36);
            this.label4.TabIndex = 5;
            this.label4.Text = "تاریخ ویزیت";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(505, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "بیمار";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(185, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 36);
            this.label2.TabIndex = 6;
            this.label2.Text = "زمان ویزیت";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(185, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 36);
            this.label3.TabIndex = 7;
            this.label3.Text = "حق ویزیت";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateTimePickerVisitDate
            // 
            this.dateTimePickerVisitDate.AnchorSize = new System.Drawing.Size(228, 37);
            this.dateTimePickerVisitDate.BackColor = System.Drawing.Color.White;
            this.dateTimePickerVisitDate.CalendarBoldedDayForeColor = System.Drawing.Color.Blue;
            this.dateTimePickerVisitDate.CalendarBorderColor = System.Drawing.Color.CadetBlue;
            this.dateTimePickerVisitDate.CalendarDayRectTickness = 2F;
            this.dateTimePickerVisitDate.CalendarDaysBackColor = System.Drawing.Color.LightGray;
            this.dateTimePickerVisitDate.CalendarDaysFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerVisitDate.CalendarDaysForeColor = System.Drawing.Color.DodgerBlue;
            this.dateTimePickerVisitDate.CalendarEnglishAnnuallyBoldedDates = new System.DateTime[0];
            this.dateTimePickerVisitDate.CalendarEnglishBoldedDates = new System.DateTime[0];
            this.dateTimePickerVisitDate.CalendarEnglishHolidayDates = new System.DateTime[0];
            this.dateTimePickerVisitDate.CalendarEnglishMonthlyBoldedDates = new System.DateTime[0];
            this.dateTimePickerVisitDate.CalendarHolidayForeColor = System.Drawing.Color.Red;
            this.dateTimePickerVisitDate.CalendarHolidayWeekly = BehComponents.MonthCalendarX.DayOfWeekForHoliday.Friday;
            this.dateTimePickerVisitDate.CalendarLineWeekColor = System.Drawing.Color.Black;
            this.dateTimePickerVisitDate.CalendarPersianAnnuallyBoldedDates = new BehComponents.PersianDateTime[0];
            this.dateTimePickerVisitDate.CalendarPersianBoldedDates = new BehComponents.PersianDateTime[0];
            this.dateTimePickerVisitDate.CalendarPersianHolidayDates = new BehComponents.PersianDateTime[0];
            this.dateTimePickerVisitDate.CalendarPersianMonthlyBoldedDates = new BehComponents.PersianDateTime[0];
            this.dateTimePickerVisitDate.CalendarShowToday = true;
            this.dateTimePickerVisitDate.CalendarShowTodayRect = true;
            this.dateTimePickerVisitDate.CalendarShowToolTips = false;
            this.dateTimePickerVisitDate.CalendarShowTrailing = true;
            this.dateTimePickerVisitDate.CalendarStyle_DaysButton = BehComponents.ButtonX.ButtonStyles.Simple;
            this.dateTimePickerVisitDate.CalendarStyle_GotoTodayButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.dateTimePickerVisitDate.CalendarStyle_MonthButton = BehComponents.ButtonX.ButtonStyles.Blue;
            this.dateTimePickerVisitDate.CalendarStyle_NextMonthButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.dateTimePickerVisitDate.CalendarStyle_PreviousMonthButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.dateTimePickerVisitDate.CalendarStyle_YearButton = BehComponents.ButtonX.ButtonStyles.Blue;
            this.dateTimePickerVisitDate.CalendarTitleBackColor = System.Drawing.Color.Wheat;
            this.dateTimePickerVisitDate.CalendarTitleFont = new System.Drawing.Font("Tahoma", 8.25F);
            this.dateTimePickerVisitDate.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dateTimePickerVisitDate.CalendarTodayBackColor = System.Drawing.Color.Wheat;
            this.dateTimePickerVisitDate.CalendarTodayFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.dateTimePickerVisitDate.CalendarTodayForeColor = System.Drawing.Color.Black;
            this.dateTimePickerVisitDate.CalendarTodayRectColor = System.Drawing.Color.Coral;
            this.dateTimePickerVisitDate.CalendarTodayRectTickness = 2F;
            this.dateTimePickerVisitDate.CalendarTrailingForeColor = System.Drawing.Color.DarkGray;
            this.dateTimePickerVisitDate.CalendarType = BehComponents.CalendarTypes.Persian;
            this.dateTimePickerVisitDate.CalendarWeekDaysBackColor = System.Drawing.Color.Wheat;
            this.dateTimePickerVisitDate.CalendarWeekDaysFont = new System.Drawing.Font("Tahoma", 8.25F);
            this.dateTimePickerVisitDate.CalendarWeekDaysForeColor = System.Drawing.Color.OrangeRed;
            this.dateTimePickerVisitDate.CalendarWeekStartsOn = BehComponents.MonthCalendarX.WeekDays.Saturday;
            this.dateTimePickerVisitDate.ClearButtonAlignment = BehComponents.DropDownEmpty.Alignments.Left;
            this.dateTimePickerVisitDate.ClearButtonBackColor = System.Drawing.Color.White;
            this.dateTimePickerVisitDate.ClearButtonForeColor = System.Drawing.SystemColors.ControlText;
            this.dateTimePickerVisitDate.ClearButtonImage = ((System.Drawing.Image)(resources.GetObject("dateTimePickerVisitDate.ClearButtonImage")));
            this.dateTimePickerVisitDate.ClearButtonImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dateTimePickerVisitDate.ClearButtonImageFixedSize = new System.Drawing.Size(0, 0);
            this.dateTimePickerVisitDate.ClearButtonImageSizeMode = BehComponents.DropDownEmpty.ImageSizeModes.Zoom;
            this.dateTimePickerVisitDate.ClearButtonText = "";
            this.dateTimePickerVisitDate.ClearButtonTextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dateTimePickerVisitDate.ClearButtonToolTip = "";
            this.dateTimePickerVisitDate.ClearButtonWidth = 17;
            this.dateTimePickerVisitDate.ClearDateTimeWhenDownDeleteKey = true;
            this.dateTimePickerVisitDate.CustomFormat = "";
            this.dateTimePickerVisitDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePickerVisitDate.DockSide = BehComponents.DropDownEmpty.Alignments.Left;
            this.dateTimePickerVisitDate.DropDownClosedWhenClickOnDays = false;
            this.dateTimePickerVisitDate.DropDownClosedWhenSelectedDateChanged = false;
            this.dateTimePickerVisitDate.Format = BehComponents.DateTimePickerX.FormatDate.Long;
            this.dateTimePickerVisitDate.Format4Binding = "yyyy/MM/dd";
            this.dateTimePickerVisitDate.Location = new System.Drawing.Point(271, 2);
            this.dateTimePickerVisitDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerVisitDate.Name = "dateTimePickerVisitDate";
            this.dateTimePickerVisitDate.RightToLeftLayout = true;
            this.dateTimePickerVisitDate.ShowClearButton = false;
            this.dateTimePickerVisitDate.Size = new System.Drawing.Size(228, 37);
            this.dateTimePickerVisitDate.TabIndex = 8;
            this.dateTimePickerVisitDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dateTimePickerVisitDate.TextWhenClearButtonClicked = "";
            // 
            // maskedBoxTime
            // 
            this.maskedBoxTime.Location = new System.Drawing.Point(122, 3);
            this.maskedBoxTime.Mask = "00:00";
            this.maskedBoxTime.Name = "maskedBoxTime";
            this.maskedBoxTime.Size = new System.Drawing.Size(57, 35);
            this.maskedBoxTime.TabIndex = 9;
            this.maskedBoxTime.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
            this.maskedBoxTime.VisualStyleManager = this.visualStyleManager;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(9, 44);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(170, 35);
            this.textBoxPrice.TabIndex = 10;
            this.textBoxPrice.VisualStyleManager = this.visualStyleManager;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(349, 85);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(150, 36);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "ثبت نوبت (F2)";
            this.buttonAdd.VisualStyleManager = this.visualStyleManager;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAddClick);
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.tableLayoutPanel2);
            this.uiGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiGroupBox1.Location = new System.Drawing.Point(10, 144);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Size = new System.Drawing.Size(588, 296);
            this.uiGroupBox1.TabIndex = 3;
            this.uiGroupBox1.Text = "لیست نوبت ها بر اساس تاریخ انتخابی";
            this.uiGroupBox1.VisualStyleManager = this.visualStyleManager;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.customGridVisitList, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dateTimePickerVisitList, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 31);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(582, 262);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // customGridVisitList
            // 
            this.customGridVisitList.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.customGridVisitList.AlternatingColors = true;
            this.customGridVisitList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customGridVisitList.BuiltInTextsData = resources.GetString("customGridVisitList.BuiltInTextsData");
            this.customGridVisitList.ColumnAutoResize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.customGridVisitList, 3);
            this.customGridVisitList.DataSource = this.bindingSourceVisitList;
            customGridVisitList_DesignTimeLayout.LayoutString = resources.GetString("customGridVisitList_DesignTimeLayout.LayoutString");
            this.customGridVisitList.DesignTimeLayout = customGridVisitList_DesignTimeLayout;
            this.customGridVisitList.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.customGridVisitList.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.customGridVisitList.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.customGridVisitList.Font = new System.Drawing.Font("B Koodak", 12F);
            this.customGridVisitList.GroupByBoxVisible = false;
            this.customGridVisitList.HideColumnsWhenGrouped = Janus.Windows.GridEX.InheritableBoolean.True;
            this.customGridVisitList.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            this.customGridVisitList.Location = new System.Drawing.Point(3, 45);
            this.customGridVisitList.Name = "customGridVisitList";
            this.customGridVisitList.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.customGridVisitList.Size = new System.Drawing.Size(576, 214);
            this.customGridVisitList.TabIndex = 1258;
            this.customGridVisitList.TabKeyBehavior = Janus.Windows.GridEX.TabKeyBehavior.ControlNavigation;
            this.customGridVisitList.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.customGridVisitList.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.customGridVisitList.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.customGridVisitList.VisualStyleManager = this.visualStyleManager;
            this.customGridVisitList.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.GridColumnButtonClick);
            // 
            // bindingSourceVisitList
            // 
            this.bindingSourceVisitList.DataSource = typeof(Ophthalmology.Entity.Entites.CustomerVisit);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(499, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 36);
            this.label5.TabIndex = 3;
            this.label5.Text = "تاریخ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateTimePickerVisitList
            // 
            this.dateTimePickerVisitList.AnchorSize = new System.Drawing.Size(225, 36);
            this.dateTimePickerVisitList.BackColor = System.Drawing.Color.White;
            this.dateTimePickerVisitList.CalendarBoldedDayForeColor = System.Drawing.Color.Blue;
            this.dateTimePickerVisitList.CalendarBorderColor = System.Drawing.Color.CadetBlue;
            this.dateTimePickerVisitList.CalendarDayRectTickness = 2F;
            this.dateTimePickerVisitList.CalendarDaysBackColor = System.Drawing.Color.LightGray;
            this.dateTimePickerVisitList.CalendarDaysFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerVisitList.CalendarDaysForeColor = System.Drawing.Color.DodgerBlue;
            this.dateTimePickerVisitList.CalendarEnglishAnnuallyBoldedDates = new System.DateTime[0];
            this.dateTimePickerVisitList.CalendarEnglishBoldedDates = new System.DateTime[0];
            this.dateTimePickerVisitList.CalendarEnglishHolidayDates = new System.DateTime[0];
            this.dateTimePickerVisitList.CalendarEnglishMonthlyBoldedDates = new System.DateTime[0];
            this.dateTimePickerVisitList.CalendarHolidayForeColor = System.Drawing.Color.Red;
            this.dateTimePickerVisitList.CalendarHolidayWeekly = BehComponents.MonthCalendarX.DayOfWeekForHoliday.Friday;
            this.dateTimePickerVisitList.CalendarLineWeekColor = System.Drawing.Color.Black;
            this.dateTimePickerVisitList.CalendarPersianAnnuallyBoldedDates = new BehComponents.PersianDateTime[0];
            this.dateTimePickerVisitList.CalendarPersianBoldedDates = new BehComponents.PersianDateTime[0];
            this.dateTimePickerVisitList.CalendarPersianHolidayDates = new BehComponents.PersianDateTime[0];
            this.dateTimePickerVisitList.CalendarPersianMonthlyBoldedDates = new BehComponents.PersianDateTime[0];
            this.dateTimePickerVisitList.CalendarShowToday = true;
            this.dateTimePickerVisitList.CalendarShowTodayRect = true;
            this.dateTimePickerVisitList.CalendarShowToolTips = false;
            this.dateTimePickerVisitList.CalendarShowTrailing = true;
            this.dateTimePickerVisitList.CalendarStyle_DaysButton = BehComponents.ButtonX.ButtonStyles.Simple;
            this.dateTimePickerVisitList.CalendarStyle_GotoTodayButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.dateTimePickerVisitList.CalendarStyle_MonthButton = BehComponents.ButtonX.ButtonStyles.Blue;
            this.dateTimePickerVisitList.CalendarStyle_NextMonthButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.dateTimePickerVisitList.CalendarStyle_PreviousMonthButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.dateTimePickerVisitList.CalendarStyle_YearButton = BehComponents.ButtonX.ButtonStyles.Blue;
            this.dateTimePickerVisitList.CalendarTitleBackColor = System.Drawing.Color.Wheat;
            this.dateTimePickerVisitList.CalendarTitleFont = new System.Drawing.Font("Tahoma", 8.25F);
            this.dateTimePickerVisitList.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dateTimePickerVisitList.CalendarTodayBackColor = System.Drawing.Color.Wheat;
            this.dateTimePickerVisitList.CalendarTodayFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.dateTimePickerVisitList.CalendarTodayForeColor = System.Drawing.Color.Black;
            this.dateTimePickerVisitList.CalendarTodayRectColor = System.Drawing.Color.Coral;
            this.dateTimePickerVisitList.CalendarTodayRectTickness = 2F;
            this.dateTimePickerVisitList.CalendarTrailingForeColor = System.Drawing.Color.DarkGray;
            this.dateTimePickerVisitList.CalendarType = BehComponents.CalendarTypes.Persian;
            this.dateTimePickerVisitList.CalendarWeekDaysBackColor = System.Drawing.Color.Wheat;
            this.dateTimePickerVisitList.CalendarWeekDaysFont = new System.Drawing.Font("Tahoma", 8.25F);
            this.dateTimePickerVisitList.CalendarWeekDaysForeColor = System.Drawing.Color.OrangeRed;
            this.dateTimePickerVisitList.CalendarWeekStartsOn = BehComponents.MonthCalendarX.WeekDays.Saturday;
            this.dateTimePickerVisitList.ClearButtonAlignment = BehComponents.DropDownEmpty.Alignments.Left;
            this.dateTimePickerVisitList.ClearButtonBackColor = System.Drawing.Color.White;
            this.dateTimePickerVisitList.ClearButtonForeColor = System.Drawing.SystemColors.ControlText;
            this.dateTimePickerVisitList.ClearButtonImage = ((System.Drawing.Image)(resources.GetObject("dateTimePickerVisitList.ClearButtonImage")));
            this.dateTimePickerVisitList.ClearButtonImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dateTimePickerVisitList.ClearButtonImageFixedSize = new System.Drawing.Size(0, 0);
            this.dateTimePickerVisitList.ClearButtonImageSizeMode = BehComponents.DropDownEmpty.ImageSizeModes.Zoom;
            this.dateTimePickerVisitList.ClearButtonText = "";
            this.dateTimePickerVisitList.ClearButtonTextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dateTimePickerVisitList.ClearButtonToolTip = "";
            this.dateTimePickerVisitList.ClearButtonWidth = 17;
            this.dateTimePickerVisitList.ClearDateTimeWhenDownDeleteKey = true;
            this.dateTimePickerVisitList.CustomFormat = "";
            this.dateTimePickerVisitList.DockSide = BehComponents.DropDownEmpty.Alignments.Left;
            this.dateTimePickerVisitList.DropDownClosedWhenClickOnDays = false;
            this.dateTimePickerVisitList.DropDownClosedWhenSelectedDateChanged = false;
            this.dateTimePickerVisitList.Format = BehComponents.DateTimePickerX.FormatDate.Long;
            this.dateTimePickerVisitList.Format4Binding = "yyyy/MM/dd";
            this.dateTimePickerVisitList.Location = new System.Drawing.Point(268, 3);
            this.dateTimePickerVisitList.Name = "dateTimePickerVisitList";
            this.dateTimePickerVisitList.RightToLeftLayout = true;
            this.dateTimePickerVisitList.ShowClearButton = false;
            this.dateTimePickerVisitList.Size = new System.Drawing.Size(225, 36);
            this.dateTimePickerVisitList.TabIndex = 9;
            this.dateTimePickerVisitList.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dateTimePickerVisitList.TextWhenClearButtonClicked = "";
            this.dateTimePickerVisitList.SelectedDateChanged += new BehComponents.DateTimePickerX.OnSelectedDateChanged(this.DateTimePickerVisitListSelectedDateChanged);
            // 
            // AppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 450);
            this.Controls.Add(this.uiGroupBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AppointmentForm";
            this.Text = "نوبت دهی";
            this.Shown += new System.EventHandler(this.AppointmentForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.multiColumnComboCustomer)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).EndInit();
            this.uiGroupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customGridVisitList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceVisitList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSourceCustomers;
        private Janus.Windows.GridEX.EditControls.MultiColumnCombo multiColumnComboCustomer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private BehComponents.DateTimePickerX dateTimePickerVisitDate;
        private Janus.Windows.GridEX.EditControls.MaskedEditBox maskedBoxTime;
        private Janus.Windows.GridEX.EditControls.EditBox textBoxPrice;
        private Janus.Windows.EditControls.UIButton buttonAdd;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label5;
        private BehComponents.DateTimePickerX dateTimePickerVisitList;
        private Controls.CustomControls.CustomGridEx customGridVisitList;
        private System.Windows.Forms.BindingSource bindingSourceVisitList;
    }
}