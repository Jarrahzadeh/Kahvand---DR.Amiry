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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppointmentForm));
            Janus.Windows.GridEX.GridEXLayout customGridVisitList_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout customGridEx1_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout multiColumnComboCustomer_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.uiGroupBox1 = new Janus.Windows.EditControls.UIGroupBox();
            this.customGridVisitList = new Ophthalmology.Controls.CustomControls.CustomGridEx();
            this.bindingSourceVisitList = new System.Windows.Forms.BindingSource(this.components);
            this.uiGroupBox2 = new Janus.Windows.EditControls.UIGroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.customGridEx1 = new Ophthalmology.Controls.CustomControls.CustomGridEx();
            this.bindingSourceVisitHistory = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonAdd = new Janus.Windows.EditControls.UIButton();
            this.textBoxPrice = new Janus.Windows.GridEX.EditControls.EditBox();
            this.maskedBoxTime = new Janus.Windows.GridEX.EditControls.MaskedEditBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerVisitDate = new BehComponents.DateTimePickerX();
            this.label2 = new System.Windows.Forms.Label();
            this.multiColumnComboCustomer = new Janus.Windows.GridEX.EditControls.MultiColumnCombo();
            this.bindingSourceCustomers = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).BeginInit();
            this.uiGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customGridVisitList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceVisitList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox2)).BeginInit();
            this.uiGroupBox2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customGridEx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceVisitHistory)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.multiColumnComboCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.customGridVisitList);
            this.uiGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiGroupBox1.Location = new System.Drawing.Point(387, 102);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Size = new System.Drawing.Size(500, 488);
            this.uiGroupBox1.TabIndex = 1;
            this.uiGroupBox1.Tag = "لیست نوبت ها در تاریخ : {0}";
            this.uiGroupBox1.Text = "لیست نوبت ها در تاریخ : ";
            this.uiGroupBox1.VisualStyleManager = this.visualStyleManager;
            // 
            // customGridVisitList
            // 
            this.customGridVisitList.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.customGridVisitList.AlternatingColors = true;
            this.customGridVisitList.BuiltInTextsData = resources.GetString("customGridVisitList.BuiltInTextsData");
            this.customGridVisitList.ColumnAutoResize = true;
            this.customGridVisitList.DataSource = this.bindingSourceVisitList;
            customGridVisitList_DesignTimeLayout.LayoutString = resources.GetString("customGridVisitList_DesignTimeLayout.LayoutString");
            this.customGridVisitList.DesignTimeLayout = customGridVisitList_DesignTimeLayout;
            this.customGridVisitList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customGridVisitList.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.customGridVisitList.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.customGridVisitList.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.customGridVisitList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.customGridVisitList.GroupByBoxVisible = false;
            this.customGridVisitList.HideColumnsWhenGrouped = Janus.Windows.GridEX.InheritableBoolean.True;
            this.customGridVisitList.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            this.customGridVisitList.Location = new System.Drawing.Point(3, 22);
            this.customGridVisitList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customGridVisitList.Name = "customGridVisitList";
            this.customGridVisitList.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.customGridVisitList.Size = new System.Drawing.Size(494, 463);
            this.customGridVisitList.TabIndex = 2;
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
            // uiGroupBox2
            // 
            this.uiGroupBox2.Controls.Add(this.tableLayoutPanel3);
            this.uiGroupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiGroupBox2.Location = new System.Drawing.Point(9, 102);
            this.uiGroupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uiGroupBox2.Name = "uiGroupBox2";
            this.uiGroupBox2.Size = new System.Drawing.Size(378, 488);
            this.uiGroupBox2.TabIndex = 2;
            this.uiGroupBox2.Text = "تاریخچه مراجعه {0}";
            this.uiGroupBox2.VisualStyleManager = this.visualStyleManager;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.customGridEx1, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 22);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(372, 463);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // customGridEx1
            // 
            this.customGridEx1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.customGridEx1.AlternatingColors = true;
            this.customGridEx1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customGridEx1.BuiltInTextsData = resources.GetString("customGridEx1.BuiltInTextsData");
            this.customGridEx1.ColumnAutoResize = true;
            this.tableLayoutPanel3.SetColumnSpan(this.customGridEx1, 3);
            this.customGridEx1.DataSource = this.bindingSourceVisitHistory;
            customGridEx1_DesignTimeLayout.LayoutString = resources.GetString("customGridEx1_DesignTimeLayout.LayoutString");
            this.customGridEx1.DesignTimeLayout = customGridEx1_DesignTimeLayout;
            this.customGridEx1.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.customGridEx1.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.customGridEx1.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.customGridEx1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.customGridEx1.GroupByBoxVisible = false;
            this.customGridEx1.HideColumnsWhenGrouped = Janus.Windows.GridEX.InheritableBoolean.True;
            this.customGridEx1.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            this.customGridEx1.Location = new System.Drawing.Point(3, 2);
            this.customGridEx1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customGridEx1.Name = "customGridEx1";
            this.customGridEx1.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.customGridEx1.Size = new System.Drawing.Size(366, 459);
            this.customGridEx1.TabIndex = 0;
            this.customGridEx1.TabKeyBehavior = Janus.Windows.GridEX.TabKeyBehavior.ControlNavigation;
            this.customGridEx1.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.customGridEx1.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.customGridEx1.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.customGridEx1.VisualStyleManager = this.visualStyleManager;
            // 
            // bindingSourceVisitHistory
            // 
            this.bindingSourceVisitHistory.DataSource = typeof(Ophthalmology.Entity.Entites.CustomerVisit);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.buttonAdd, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxPrice, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.maskedBoxTime, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePickerVisitDate, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.multiColumnComboCustomer, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 7);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 7F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(878, 95);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(720, 60);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(135, 26);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "ثبت نوبت (F2)";
            this.buttonAdd.VisualStyleManager = this.visualStyleManager;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAddClick);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxPrice.Location = new System.Drawing.Point(151, 28);
            this.textBoxPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(64, 26);
            this.textBoxPrice.TabIndex = 7;
            this.textBoxPrice.VisualStyleManager = this.visualStyleManager;
            // 
            // maskedBoxTime
            // 
            this.maskedBoxTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maskedBoxTime.Location = new System.Drawing.Point(221, 28);
            this.maskedBoxTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maskedBoxTime.Mask = "00:00";
            this.maskedBoxTime.Name = "maskedBoxTime";
            this.maskedBoxTime.Size = new System.Drawing.Size(72, 26);
            this.maskedBoxTime.TabIndex = 5;
            this.maskedBoxTime.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
            this.maskedBoxTime.VisualStyleManager = this.visualStyleManager;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(151, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "حق ویزیت";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTimePickerVisitDate
            // 
            this.dateTimePickerVisitDate.AnchorSize = new System.Drawing.Size(200, 28);
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
            this.dateTimePickerVisitDate.Location = new System.Drawing.Point(299, 28);
            this.dateTimePickerVisitDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerVisitDate.Name = "dateTimePickerVisitDate";
            this.dateTimePickerVisitDate.RightToLeftLayout = true;
            this.dateTimePickerVisitDate.ShowClearButton = false;
            this.dateTimePickerVisitDate.Size = new System.Drawing.Size(200, 28);
            this.dateTimePickerVisitDate.TabIndex = 3;
            this.dateTimePickerVisitDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dateTimePickerVisitDate.TextWhenClearButtonClicked = "";
            this.dateTimePickerVisitDate.SelectedDateChanged += new BehComponents.DateTimePickerX.OnSelectedDateChanged(this.DateTimePickerVisitListSelectedDateChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(221, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "زمان ویزیت";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // multiColumnComboCustomer
            // 
            this.multiColumnComboCustomer.AutoComplete = false;
            this.multiColumnComboCustomer.DataSource = this.bindingSourceCustomers;
            multiColumnComboCustomer_DesignTimeLayout.LayoutString = resources.GetString("multiColumnComboCustomer_DesignTimeLayout.LayoutString");
            this.multiColumnComboCustomer.DesignTimeLayout = multiColumnComboCustomer_DesignTimeLayout;
            this.multiColumnComboCustomer.DisplayMember = "FullName";
            this.multiColumnComboCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.multiColumnComboCustomer.Location = new System.Drawing.Point(505, 28);
            this.multiColumnComboCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.multiColumnComboCustomer.Name = "multiColumnComboCustomer";
            this.multiColumnComboCustomer.SelectedIndex = -1;
            this.multiColumnComboCustomer.SelectedItem = null;
            this.multiColumnComboCustomer.Size = new System.Drawing.Size(350, 26);
            this.multiColumnComboCustomer.TabIndex = 1;
            this.multiColumnComboCustomer.ValueMember = "Id";
            this.multiColumnComboCustomer.VisualStyleManager = this.visualStyleManager;
            this.multiColumnComboCustomer.ValueChanged += new System.EventHandler(this.MultiColumnCombo1ValueChanged);
            this.multiColumnComboCustomer.DropDownHide += new Janus.Windows.GridEX.ComboDropDownHideEventHandler(this.multiColumnComboCustomer_DropDownHide);
            this.multiColumnComboCustomer.TextChanged += new System.EventHandler(this.MultiColumnCombo1TextChanged);
            // 
            // bindingSourceCustomers
            // 
            this.bindingSourceCustomers.DataSource = typeof(Ophthalmology.Entity.Entites.Customer);
            this.bindingSourceCustomers.PositionChanged += new System.EventHandler(this.bindingSourceCustomers_PositionChanged);
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(299, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 26);
            this.label4.TabIndex = 2;
            this.label4.Text = "تاریخ ویزیت";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(505, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "بیمار";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 597);
            this.Controls.Add(this.uiGroupBox1);
            this.Controls.Add(this.uiGroupBox2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "AppointmentForm";
            this.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.Text = "نوبت دهی";
            this.Shown += new System.EventHandler(this.AppointmentForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).EndInit();
            this.uiGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customGridVisitList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceVisitList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox2)).EndInit();
            this.uiGroupBox2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customGridEx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceVisitHistory)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.multiColumnComboCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCustomers)).EndInit();
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
        private System.Windows.Forms.BindingSource bindingSourceVisitList;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private Controls.CustomControls.CustomGridEx customGridEx1;
        private System.Windows.Forms.BindingSource bindingSourceVisitHistory;
        private Controls.CustomControls.CustomGridEx customGridVisitList;
    }
}