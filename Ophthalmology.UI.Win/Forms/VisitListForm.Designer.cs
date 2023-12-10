﻿namespace Ophthalmology.UI.Win.Forms
{
    partial class VisitListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisitListForm));
            Janus.Windows.GridEX.GridEXLayout customGridEx1_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslAllCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslVisitCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslNotVisitCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.bindingSourceVisitList = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePickerX1 = new BehComponents.DateTimePickerX();
            this.buttonOldVisit = new Janus.Windows.EditControls.UIButton();
            this.buttonPenVisit = new Janus.Windows.EditControls.UIButton();
            this.buttonTextVisit = new Janus.Windows.EditControls.UIButton();
            this.buttonDelete = new Janus.Windows.EditControls.UIButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemOldVisit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemPenVisit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemTextVisit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.customGridEx1 = new Ophthalmology.Controls.CustomControls.CustomGridEx();
            this.StatusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceVisitList)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customGridEx1)).BeginInit();
            this.SuspendLayout();
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabel1,
            this.tsslAllCount,
            this.ToolStripStatusLabel3,
            this.tsslVisitCount,
            this.ToolStripStatusLabel5,
            this.tsslNotVisitCount});
            this.StatusStrip1.Location = new System.Drawing.Point(10, 489);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Padding = new System.Windows.Forms.Padding(23, 0, 2, 0);
            this.StatusStrip1.Size = new System.Drawing.Size(905, 22);
            this.StatusStrip1.TabIndex = 1255;
            this.StatusStrip1.Text = "StatusStrip1";
            // 
            // ToolStripStatusLabel1
            // 
            this.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.Navy;
            this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
            this.ToolStripStatusLabel1.Size = new System.Drawing.Size(56, 17);
            this.ToolStripStatusLabel1.Text = "تعداد کل :";
            // 
            // tsslAllCount
            // 
            this.tsslAllCount.ForeColor = System.Drawing.Color.Red;
            this.tsslAllCount.Name = "tsslAllCount";
            this.tsslAllCount.Size = new System.Drawing.Size(27, 17);
            this.tsslAllCount.Text = "----";
            // 
            // ToolStripStatusLabel3
            // 
            this.ToolStripStatusLabel3.ForeColor = System.Drawing.Color.Navy;
            this.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3";
            this.ToolStripStatusLabel3.Size = new System.Drawing.Size(113, 17);
            this.ToolStripStatusLabel3.Text = "تعداد ویزیت شده ها :";
            // 
            // tsslVisitCount
            // 
            this.tsslVisitCount.ForeColor = System.Drawing.Color.Red;
            this.tsslVisitCount.Name = "tsslVisitCount";
            this.tsslVisitCount.Size = new System.Drawing.Size(22, 17);
            this.tsslVisitCount.Text = "---";
            // 
            // ToolStripStatusLabel5
            // 
            this.ToolStripStatusLabel5.ForeColor = System.Drawing.Color.Navy;
            this.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5";
            this.ToolStripStatusLabel5.Size = new System.Drawing.Size(117, 17);
            this.ToolStripStatusLabel5.Text = "تعداد ویزیت نشده ها :";
            // 
            // tsslNotVisitCount
            // 
            this.tsslNotVisitCount.ForeColor = System.Drawing.Color.Red;
            this.tsslNotVisitCount.Name = "tsslNotVisitCount";
            this.tsslNotVisitCount.Size = new System.Drawing.Size(22, 17);
            this.tsslNotVisitCount.Text = "---";
            // 
            // bindingSourceVisitList
            // 
            this.bindingSourceVisitList.DataSource = typeof(Ophthalmology.Entity.Entites.VisitList);
            // 
            // dateTimePickerX1
            // 
            this.dateTimePickerX1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerX1.AnchorSize = new System.Drawing.Size(173, 36);
            this.dateTimePickerX1.BackColor = System.Drawing.Color.White;
            this.dateTimePickerX1.CalendarBoldedDayForeColor = System.Drawing.Color.Blue;
            this.dateTimePickerX1.CalendarBorderColor = System.Drawing.Color.CadetBlue;
            this.dateTimePickerX1.CalendarDayRectTickness = 2F;
            this.dateTimePickerX1.CalendarDaysBackColor = System.Drawing.Color.LightGray;
            this.dateTimePickerX1.CalendarDaysFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerX1.CalendarDaysForeColor = System.Drawing.Color.DodgerBlue;
            this.dateTimePickerX1.CalendarEnglishAnnuallyBoldedDates = new System.DateTime[0];
            this.dateTimePickerX1.CalendarEnglishBoldedDates = new System.DateTime[0];
            this.dateTimePickerX1.CalendarEnglishHolidayDates = new System.DateTime[0];
            this.dateTimePickerX1.CalendarEnglishMonthlyBoldedDates = new System.DateTime[0];
            this.dateTimePickerX1.CalendarHolidayForeColor = System.Drawing.Color.Red;
            this.dateTimePickerX1.CalendarHolidayWeekly = BehComponents.MonthCalendarX.DayOfWeekForHoliday.Friday;
            this.dateTimePickerX1.CalendarLineWeekColor = System.Drawing.Color.Black;
            this.dateTimePickerX1.CalendarPersianAnnuallyBoldedDates = new BehComponents.PersianDateTime[0];
            this.dateTimePickerX1.CalendarPersianBoldedDates = new BehComponents.PersianDateTime[0];
            this.dateTimePickerX1.CalendarPersianHolidayDates = new BehComponents.PersianDateTime[0];
            this.dateTimePickerX1.CalendarPersianMonthlyBoldedDates = new BehComponents.PersianDateTime[0];
            this.dateTimePickerX1.CalendarShowToday = true;
            this.dateTimePickerX1.CalendarShowTodayRect = true;
            this.dateTimePickerX1.CalendarShowToolTips = false;
            this.dateTimePickerX1.CalendarShowTrailing = true;
            this.dateTimePickerX1.CalendarStyle_DaysButton = BehComponents.ButtonX.ButtonStyles.Simple;
            this.dateTimePickerX1.CalendarStyle_GotoTodayButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.dateTimePickerX1.CalendarStyle_MonthButton = BehComponents.ButtonX.ButtonStyles.Blue;
            this.dateTimePickerX1.CalendarStyle_NextMonthButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.dateTimePickerX1.CalendarStyle_PreviousMonthButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.dateTimePickerX1.CalendarStyle_YearButton = BehComponents.ButtonX.ButtonStyles.Blue;
            this.dateTimePickerX1.CalendarTitleBackColor = System.Drawing.Color.Wheat;
            this.dateTimePickerX1.CalendarTitleFont = new System.Drawing.Font("Tahoma", 8.25F);
            this.dateTimePickerX1.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dateTimePickerX1.CalendarTodayBackColor = System.Drawing.Color.Wheat;
            this.dateTimePickerX1.CalendarTodayFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.dateTimePickerX1.CalendarTodayForeColor = System.Drawing.Color.Black;
            this.dateTimePickerX1.CalendarTodayRectColor = System.Drawing.Color.Coral;
            this.dateTimePickerX1.CalendarTodayRectTickness = 2F;
            this.dateTimePickerX1.CalendarTrailingForeColor = System.Drawing.Color.DarkGray;
            this.dateTimePickerX1.CalendarType = BehComponents.CalendarTypes.Persian;
            this.dateTimePickerX1.CalendarWeekDaysBackColor = System.Drawing.Color.Wheat;
            this.dateTimePickerX1.CalendarWeekDaysFont = new System.Drawing.Font("Tahoma", 8.25F);
            this.dateTimePickerX1.CalendarWeekDaysForeColor = System.Drawing.Color.OrangeRed;
            this.dateTimePickerX1.CalendarWeekStartsOn = BehComponents.MonthCalendarX.WeekDays.Saturday;
            this.dateTimePickerX1.ClearButtonAlignment = BehComponents.DropDownEmpty.Alignments.Left;
            this.dateTimePickerX1.ClearButtonBackColor = System.Drawing.Color.White;
            this.dateTimePickerX1.ClearButtonForeColor = System.Drawing.SystemColors.ControlText;
            this.dateTimePickerX1.ClearButtonImage = ((System.Drawing.Image)(resources.GetObject("dateTimePickerX1.ClearButtonImage")));
            this.dateTimePickerX1.ClearButtonImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dateTimePickerX1.ClearButtonImageFixedSize = new System.Drawing.Size(0, 0);
            this.dateTimePickerX1.ClearButtonImageSizeMode = BehComponents.DropDownEmpty.ImageSizeModes.Zoom;
            this.dateTimePickerX1.ClearButtonText = "";
            this.dateTimePickerX1.ClearButtonTextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dateTimePickerX1.ClearButtonToolTip = "";
            this.dateTimePickerX1.ClearButtonWidth = 17;
            this.dateTimePickerX1.ClearDateTimeWhenDownDeleteKey = true;
            this.dateTimePickerX1.CustomFormat = "";
            this.dateTimePickerX1.DockSide = BehComponents.DropDownEmpty.Alignments.Left;
            this.dateTimePickerX1.DropDownClosedWhenClickOnDays = false;
            this.dateTimePickerX1.DropDownClosedWhenSelectedDateChanged = false;
            this.dateTimePickerX1.Format = BehComponents.DateTimePickerX.FormatDate.Long;
            this.dateTimePickerX1.Format4Binding = "yyyy/MM/dd";
            this.dateTimePickerX1.Location = new System.Drawing.Point(739, 13);
            this.dateTimePickerX1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dateTimePickerX1.Name = "dateTimePickerX1";
            this.dateTimePickerX1.RightToLeftLayout = true;
            this.dateTimePickerX1.ShowClearButton = false;
            this.dateTimePickerX1.Size = new System.Drawing.Size(173, 36);
            this.dateTimePickerX1.TabIndex = 1256;
            this.dateTimePickerX1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dateTimePickerX1.TextWhenClearButtonClicked = "";
            this.dateTimePickerX1.SelectedDateChanged += new BehComponents.DateTimePickerX.OnSelectedDateChanged(this.dateTimePickerX1_SelectedDateChanged);
            // 
            // buttonOldVisit
            // 
            this.buttonOldVisit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOldVisit.Location = new System.Drawing.Point(556, 13);
            this.buttonOldVisit.Name = "buttonOldVisit";
            this.buttonOldVisit.Size = new System.Drawing.Size(175, 36);
            this.buttonOldVisit.TabIndex = 1258;
            this.buttonOldVisit.Text = "نسخه های قبلی";
            this.buttonOldVisit.VisualStyleManager = this.visualStyleManager;
            this.buttonOldVisit.Click += new System.EventHandler(this.buttonOldVisit_Click);
            // 
            // buttonPenVisit
            // 
            this.buttonPenVisit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPenVisit.Location = new System.Drawing.Point(375, 13);
            this.buttonPenVisit.Name = "buttonPenVisit";
            this.buttonPenVisit.Size = new System.Drawing.Size(175, 36);
            this.buttonPenVisit.TabIndex = 1258;
            this.buttonPenVisit.Text = "نسخه قلم (F6)";
            this.buttonPenVisit.VisualStyleManager = this.visualStyleManager;
            this.buttonPenVisit.Click += new System.EventHandler(this.buttonPenVisit_Click);
            // 
            // buttonTextVisit
            // 
            this.buttonTextVisit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTextVisit.Location = new System.Drawing.Point(194, 13);
            this.buttonTextVisit.Name = "buttonTextVisit";
            this.buttonTextVisit.Size = new System.Drawing.Size(175, 36);
            this.buttonTextVisit.TabIndex = 1258;
            this.buttonTextVisit.Text = "نسخه متنی (F7)";
            this.buttonTextVisit.VisualStyleManager = this.visualStyleManager;
            this.buttonTextVisit.Click += new System.EventHandler(this.buttonTextVisit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.Location = new System.Drawing.Point(13, 13);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(175, 36);
            this.buttonDelete.TabIndex = 1258;
            this.buttonDelete.Text = "حذف";
            this.buttonDelete.VisualStyleManager = this.visualStyleManager;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemOldVisit,
            this.menuItemPenVisit,
            this.menuItemTextVisit,
            this.menuItemDelete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(152, 92);
            // 
            // menuItemOldVisit
            // 
            this.menuItemOldVisit.Name = "menuItemOldVisit";
            this.menuItemOldVisit.Size = new System.Drawing.Size(151, 22);
            this.menuItemOldVisit.Text = "نسخه های قبلی";
            this.menuItemOldVisit.Click += new System.EventHandler(this.menuItemOldVisit_Click);
            // 
            // menuItemPenVisit
            // 
            this.menuItemPenVisit.Name = "menuItemPenVisit";
            this.menuItemPenVisit.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.menuItemPenVisit.Size = new System.Drawing.Size(151, 22);
            this.menuItemPenVisit.Text = "نسخه قلم";
            this.menuItemPenVisit.Click += new System.EventHandler(this.menuItemPenVisit_Click);
            // 
            // menuItemTextVisit
            // 
            this.menuItemTextVisit.Name = "menuItemTextVisit";
            this.menuItemTextVisit.ShortcutKeys = System.Windows.Forms.Keys.F7;
            this.menuItemTextVisit.Size = new System.Drawing.Size(151, 22);
            this.menuItemTextVisit.Text = "نسخه متنی";
            this.menuItemTextVisit.Click += new System.EventHandler(this.menuItemTextVisit_Click);
            // 
            // menuItemDelete
            // 
            this.menuItemDelete.Name = "menuItemDelete";
            this.menuItemDelete.Size = new System.Drawing.Size(151, 22);
            this.menuItemDelete.Text = "حذف";
            this.menuItemDelete.Click += new System.EventHandler(this.menuItemDelete_Click);
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
            this.customGridEx1.DataSource = this.bindingSourceVisitList;
            customGridEx1_DesignTimeLayout.LayoutString = resources.GetString("customGridEx1_DesignTimeLayout.LayoutString");
            this.customGridEx1.DesignTimeLayout = customGridEx1_DesignTimeLayout;
            this.customGridEx1.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.customGridEx1.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.customGridEx1.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.customGridEx1.GroupByBoxVisible = false;
            this.customGridEx1.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            this.customGridEx1.Location = new System.Drawing.Point(13, 59);
            this.customGridEx1.Name = "customGridEx1";
            this.customGridEx1.Size = new System.Drawing.Size(899, 423);
            this.customGridEx1.TabIndex = 1257;
            this.customGridEx1.TabKeyBehavior = Janus.Windows.GridEX.TabKeyBehavior.ControlNavigation;
            this.customGridEx1.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.customGridEx1.VisualStyleManager = this.visualStyleManager;
            // 
            // VisitListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 521);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonTextVisit);
            this.Controls.Add(this.buttonPenVisit);
            this.Controls.Add(this.buttonOldVisit);
            this.Controls.Add(this.customGridEx1);
            this.Controls.Add(this.dateTimePickerX1);
            this.Controls.Add(this.StatusStrip1);
            this.Margin = new System.Windows.Forms.Padding(10, 13, 10, 13);
            this.Name = "VisitListForm";
            this.Text = "ویزیت بیماران";
            this.Load += new System.EventHandler(this.VisitListForm_Load);
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceVisitList)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customGridEx1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel1;
        internal System.Windows.Forms.ToolStripStatusLabel tsslAllCount;
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel3;
        internal System.Windows.Forms.ToolStripStatusLabel tsslVisitCount;
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel5;
        internal System.Windows.Forms.ToolStripStatusLabel tsslNotVisitCount;
        private System.Windows.Forms.BindingSource bindingSourceVisitList;
        private System.Windows.Forms.StatusStrip StatusStrip1;
        private BehComponents.DateTimePickerX dateTimePickerX1;
        private Controls.CustomControls.CustomGridEx customGridEx1;
        private Janus.Windows.EditControls.UIButton buttonOldVisit;
        private Janus.Windows.EditControls.UIButton buttonPenVisit;
        private Janus.Windows.EditControls.UIButton buttonTextVisit;
        private Janus.Windows.EditControls.UIButton buttonDelete;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuItemOldVisit;
        private System.Windows.Forms.ToolStripMenuItem menuItemPenVisit;
        private System.Windows.Forms.ToolStripMenuItem menuItemTextVisit;
        private System.Windows.Forms.ToolStripMenuItem menuItemDelete;
    }
}