namespace Ophthalmology.UI.Win.Forms
{
    partial class CustomersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomersForm));
            Janus.Windows.GridEX.GridEXLayout customGridEx1_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonBrowse = new Janus.Windows.EditControls.UIButton();
            this.TextBoxAddress = new Janus.Windows.GridEX.EditControls.EditBox();
            this.LableCode = new System.Windows.Forms.Label();
            this.TextBoxDescription = new Janus.Windows.GridEX.EditControls.EditBox();
            this.TextBoxCode = new Janus.Windows.GridEX.EditControls.EditBox();
            this.CheckBoxEyeRight = new Janus.Windows.EditControls.UICheckBox();
            this.LableName = new System.Windows.Forms.Label();
            this.CheckBoxEyeLeft = new Janus.Windows.EditControls.UICheckBox();
            this.TextBoxName = new Janus.Windows.GridEX.EditControls.EditBox();
            this.LabelFamily = new System.Windows.Forms.Label();
            this.TextBoxFamily = new Janus.Windows.GridEX.EditControls.EditBox();
            this.TextBoxReason = new Janus.Windows.GridEX.EditControls.EditBox();
            this.LabelAddress = new System.Windows.Forms.Label();
            this.TextBoxTel = new Janus.Windows.GridEX.EditControls.EditBox();
            this.LableFatherName = new System.Windows.Forms.Label();
            this.TextBoxFatherName = new Janus.Windows.GridEX.EditControls.EditBox();
            this.LabelDescription = new System.Windows.Forms.Label();
            this.LablePhone = new System.Windows.Forms.Label();
            this.LIdentify_Num = new System.Windows.Forms.Label();
            this.LabelAge = new System.Windows.Forms.Label();
            this.LableRegDate = new System.Windows.Forms.Label();
            this.ComboBoxType = new Janus.Windows.EditControls.UIComboBox();
            this.bindingSourceTypePatient = new System.Windows.Forms.BindingSource(this.components);
            this.LabelType = new System.Windows.Forms.Label();
            this.TextBoxAge = new Janus.Windows.GridEX.EditControls.EditBox();
            this.ButtonOldVisit = new Janus.Windows.EditControls.UIButton();
            this.BtnVisit = new Janus.Windows.EditControls.UIButton();
            this.BtnVisitText = new Janus.Windows.EditControls.UIButton();
            this.ButtonCancel = new Janus.Windows.EditControls.UIButton();
            this.ButtonDelete = new Janus.Windows.EditControls.UIButton();
            this.ButtonEdit = new Janus.Windows.EditControls.UIButton();
            this.ButtonAdd = new Janus.Windows.EditControls.UIButton();
            this.datePicker1 = new Devy.Windows.DatePicker();
            this.uiGroupBox1 = new Janus.Windows.EditControls.UIGroupBox();
            this.customGridEx1 = new Ophthalmology.Controls.CustomControls.CustomGridEx();
            this.bindingSourceCustomers = new System.Windows.Forms.BindingSource(this.components);
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TSBVisit = new System.Windows.Forms.ToolStripButton();
            this.TSBCustomer2VisitList = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.LableDrName = new System.Windows.Forms.ToolStripLabel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTypePatient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).BeginInit();
            this.uiGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customGridEx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCustomers)).BeginInit();
            this.ToolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.ButtonBrowse, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.TextBoxAddress, 6, 5);
            this.tableLayoutPanel1.Controls.Add(this.LableCode, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TextBoxDescription, 6, 4);
            this.tableLayoutPanel1.Controls.Add(this.TextBoxCode, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.CheckBoxEyeRight, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.LableName, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.CheckBoxEyeLeft, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.TextBoxName, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.LabelFamily, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.TextBoxFamily, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.TextBoxReason, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.LabelAddress, 5, 5);
            this.tableLayoutPanel1.Controls.Add(this.TextBoxTel, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.LableFatherName, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.TextBoxFatherName, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.LabelDescription, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.LablePhone, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.LIdentify_Num, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.LabelAge, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.LableRegDate, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.ComboBoxType, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.LabelType, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.TextBoxAge, 6, 3);
            this.tableLayoutPanel1.Controls.Add(this.ButtonOldVisit, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.BtnVisit, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.BtnVisitText, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.ButtonCancel, 6, 7);
            this.tableLayoutPanel1.Controls.Add(this.ButtonDelete, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.ButtonEdit, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.ButtonAdd, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.datePicker1, 3, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 35);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(911, 334);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ButtonBrowse
            // 
            this.ButtonBrowse.Location = new System.Drawing.Point(346, 215);
            this.ButtonBrowse.Name = "ButtonBrowse";
            this.ButtonBrowse.Size = new System.Drawing.Size(35, 35);
            this.ButtonBrowse.TabIndex = 26;
            this.ButtonBrowse.Text = "...";
            this.ButtonBrowse.VisualStyleManager = this.visualStyleManager;
            this.ButtonBrowse.Click += new System.EventHandler(this.ButtonBrowse_Click);
            // 
            // TextBoxAddress
            // 
            this.TextBoxAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxAddress.Location = new System.Drawing.Point(67, 215);
            this.TextBoxAddress.Multiline = true;
            this.TextBoxAddress.Name = "TextBoxAddress";
            this.TextBoxAddress.Size = new System.Drawing.Size(190, 35);
            this.TextBoxAddress.TabIndex = 17;
            this.TextBoxAddress.VisualStyleManager = this.visualStyleManager;
            // 
            // LableCode
            // 
            this.LableCode.AutoSize = true;
            this.LableCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LableCode.Location = new System.Drawing.Point(881, 0);
            this.LableCode.Name = "LableCode";
            this.LableCode.Size = new System.Drawing.Size(27, 41);
            this.LableCode.TabIndex = 0;
            this.LableCode.Text = "کد";
            this.LableCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TextBoxDescription
            // 
            this.TextBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxDescription.Location = new System.Drawing.Point(67, 174);
            this.TextBoxDescription.Multiline = true;
            this.TextBoxDescription.Name = "TextBoxDescription";
            this.TextBoxDescription.Size = new System.Drawing.Size(190, 35);
            this.TextBoxDescription.TabIndex = 15;
            this.TextBoxDescription.VisualStyleManager = this.visualStyleManager;
            // 
            // TextBoxCode
            // 
            this.TextBoxCode.BackColor = System.Drawing.Color.AntiqueWhite;
            this.TextBoxCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxCode.Location = new System.Drawing.Point(732, 3);
            this.TextBoxCode.Name = "TextBoxCode";
            this.TextBoxCode.ReadOnly = true;
            this.TextBoxCode.Size = new System.Drawing.Size(143, 35);
            this.TextBoxCode.TabIndex = 1;
            this.TextBoxCode.TabStop = false;
            this.TextBoxCode.VisualStyleManager = this.visualStyleManager;
            // 
            // CheckBoxEyeRight
            // 
            this.CheckBoxEyeRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckBoxEyeRight.Location = new System.Drawing.Point(583, 174);
            this.CheckBoxEyeRight.Name = "CheckBoxEyeRight";
            this.CheckBoxEyeRight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CheckBoxEyeRight.Size = new System.Drawing.Size(143, 35);
            this.CheckBoxEyeRight.TabIndex = 22;
            this.CheckBoxEyeRight.Text = " تاریخ عمل چشم راست";
            this.CheckBoxEyeRight.VisualStyleManager = this.visualStyleManager;
            // 
            // LableName
            // 
            this.LableName.AutoSize = true;
            this.LableName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LableName.Location = new System.Drawing.Point(583, 0);
            this.LableName.Name = "LableName";
            this.LableName.Size = new System.Drawing.Size(143, 41);
            this.LableName.TabIndex = 2;
            this.LableName.Text = "نام";
            this.LableName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CheckBoxEyeLeft
            // 
            this.CheckBoxEyeLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckBoxEyeLeft.Location = new System.Drawing.Point(583, 133);
            this.CheckBoxEyeLeft.Name = "CheckBoxEyeLeft";
            this.CheckBoxEyeLeft.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CheckBoxEyeLeft.Size = new System.Drawing.Size(143, 35);
            this.CheckBoxEyeLeft.TabIndex = 20;
            this.CheckBoxEyeLeft.Text = " تاریخ عمل چشم چپ";
            this.CheckBoxEyeLeft.VisualStyleManager = this.visualStyleManager;
            // 
            // TextBoxName
            // 
            this.TextBoxName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxName.Location = new System.Drawing.Point(387, 3);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(190, 35);
            this.TextBoxName.TabIndex = 3;
            this.TextBoxName.VisualStyleManager = this.visualStyleManager;
            // 
            // LabelFamily
            // 
            this.LabelFamily.AutoSize = true;
            this.LabelFamily.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelFamily.Location = new System.Drawing.Point(583, 41);
            this.LabelFamily.Name = "LabelFamily";
            this.LabelFamily.Size = new System.Drawing.Size(143, 41);
            this.LabelFamily.TabIndex = 4;
            this.LabelFamily.Text = "نام خانوادگی";
            this.LabelFamily.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TextBoxFamily
            // 
            this.TextBoxFamily.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxFamily.Location = new System.Drawing.Point(387, 44);
            this.TextBoxFamily.Name = "TextBoxFamily";
            this.TextBoxFamily.Size = new System.Drawing.Size(190, 35);
            this.TextBoxFamily.TabIndex = 5;
            this.TextBoxFamily.VisualStyleManager = this.visualStyleManager;
            // 
            // TextBoxReason
            // 
            this.TextBoxReason.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxReason.Location = new System.Drawing.Point(67, 85);
            this.TextBoxReason.Name = "TextBoxReason";
            this.TextBoxReason.Size = new System.Drawing.Size(190, 35);
            this.TextBoxReason.TabIndex = 11;
            this.TextBoxReason.VisualStyleManager = this.visualStyleManager;
            // 
            // LabelAddress
            // 
            this.LabelAddress.AutoSize = true;
            this.LabelAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelAddress.Location = new System.Drawing.Point(263, 212);
            this.LabelAddress.Name = "LabelAddress";
            this.LabelAddress.Size = new System.Drawing.Size(77, 41);
            this.LabelAddress.TabIndex = 16;
            this.LabelAddress.Text = "آدرس";
            this.LabelAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TextBoxTel
            // 
            this.TextBoxTel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxTel.Location = new System.Drawing.Point(67, 44);
            this.TextBoxTel.Name = "TextBoxTel";
            this.TextBoxTel.Size = new System.Drawing.Size(190, 35);
            this.TextBoxTel.TabIndex = 9;
            this.TextBoxTel.VisualStyleManager = this.visualStyleManager;
            // 
            // LableFatherName
            // 
            this.LableFatherName.AutoSize = true;
            this.LableFatherName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LableFatherName.Location = new System.Drawing.Point(263, 0);
            this.LableFatherName.Name = "LableFatherName";
            this.LableFatherName.Size = new System.Drawing.Size(77, 41);
            this.LableFatherName.TabIndex = 6;
            this.LableFatherName.Text = "نام پدر";
            this.LableFatherName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TextBoxFatherName
            // 
            this.TextBoxFatherName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxFatherName.Location = new System.Drawing.Point(67, 3);
            this.TextBoxFatherName.Name = "TextBoxFatherName";
            this.TextBoxFatherName.Size = new System.Drawing.Size(190, 35);
            this.TextBoxFatherName.TabIndex = 7;
            this.TextBoxFatherName.VisualStyleManager = this.visualStyleManager;
            // 
            // LabelDescription
            // 
            this.LabelDescription.AutoSize = true;
            this.LabelDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelDescription.Location = new System.Drawing.Point(263, 171);
            this.LabelDescription.Name = "LabelDescription";
            this.LabelDescription.Size = new System.Drawing.Size(77, 41);
            this.LabelDescription.TabIndex = 14;
            this.LabelDescription.Text = "توضیحات";
            this.LabelDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LablePhone
            // 
            this.LablePhone.AutoSize = true;
            this.LablePhone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LablePhone.Location = new System.Drawing.Point(263, 41);
            this.LablePhone.Name = "LablePhone";
            this.LablePhone.Size = new System.Drawing.Size(77, 41);
            this.LablePhone.TabIndex = 8;
            this.LablePhone.Text = "شماره تلفن";
            this.LablePhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LIdentify_Num
            // 
            this.LIdentify_Num.AutoSize = true;
            this.LIdentify_Num.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LIdentify_Num.Location = new System.Drawing.Point(263, 82);
            this.LIdentify_Num.Name = "LIdentify_Num";
            this.LIdentify_Num.Size = new System.Drawing.Size(77, 48);
            this.LIdentify_Num.TabIndex = 10;
            this.LIdentify_Num.Text = "علت مراجعه";
            this.LIdentify_Num.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabelAge
            // 
            this.LabelAge.AutoSize = true;
            this.LabelAge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelAge.Location = new System.Drawing.Point(263, 130);
            this.LabelAge.Name = "LabelAge";
            this.LabelAge.Size = new System.Drawing.Size(77, 41);
            this.LabelAge.TabIndex = 12;
            this.LabelAge.Text = "سال تولد";
            this.LabelAge.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LableRegDate
            // 
            this.LableRegDate.AutoSize = true;
            this.LableRegDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LableRegDate.Location = new System.Drawing.Point(583, 82);
            this.LableRegDate.Name = "LableRegDate";
            this.LableRegDate.Size = new System.Drawing.Size(143, 48);
            this.LableRegDate.TabIndex = 18;
            this.LableRegDate.Text = "تاریخ ثبت";
            this.LableRegDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ComboBoxType
            // 
            this.ComboBoxType.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
            this.ComboBoxType.DataSource = this.bindingSourceTypePatient;
            this.ComboBoxType.DisplayMember = "Name";
            this.ComboBoxType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComboBoxType.Location = new System.Drawing.Point(387, 215);
            this.ComboBoxType.Name = "ComboBoxType";
            this.ComboBoxType.Size = new System.Drawing.Size(190, 35);
            this.ComboBoxType.TabIndex = 25;
            this.ComboBoxType.ValueMember = "Id";
            this.ComboBoxType.VisualStyleManager = this.visualStyleManager;
            // 
            // LabelType
            // 
            this.LabelType.AutoSize = true;
            this.LabelType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelType.Location = new System.Drawing.Point(583, 212);
            this.LabelType.Name = "LabelType";
            this.LabelType.Size = new System.Drawing.Size(143, 41);
            this.LabelType.TabIndex = 24;
            this.LabelType.Text = "نوع بیمار (بیمه)";
            this.LabelType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TextBoxAge
            // 
            this.TextBoxAge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxAge.Location = new System.Drawing.Point(67, 133);
            this.TextBoxAge.MaxLength = 30;
            this.TextBoxAge.Name = "TextBoxAge";
            this.TextBoxAge.Size = new System.Drawing.Size(190, 35);
            this.TextBoxAge.TabIndex = 13;
            this.TextBoxAge.VisualStyleManager = this.visualStyleManager;
            // 
            // ButtonOldVisit
            // 
            this.ButtonOldVisit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonOldVisit.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.AfterText;
            this.ButtonOldVisit.Location = new System.Drawing.Point(732, 85);
            this.ButtonOldVisit.Name = "ButtonOldVisit";
            this.ButtonOldVisit.Size = new System.Drawing.Size(143, 42);
            this.ButtonOldVisit.TabIndex = 30;
            this.ButtonOldVisit.Text = "نسخه های قبلی";
            this.ButtonOldVisit.VisualStyleManager = this.visualStyleManager;
            // 
            // BtnVisit
            // 
            this.BtnVisit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnVisit.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.AfterText;
            this.BtnVisit.Location = new System.Drawing.Point(732, 133);
            this.BtnVisit.Name = "BtnVisit";
            this.BtnVisit.Size = new System.Drawing.Size(143, 35);
            this.BtnVisit.TabIndex = 31;
            this.BtnVisit.Text = "نسخه قلم(F6)";
            this.BtnVisit.VisualStyleManager = this.visualStyleManager;
            // 
            // BtnVisitText
            // 
            this.BtnVisitText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnVisitText.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.AfterText;
            this.BtnVisitText.Location = new System.Drawing.Point(732, 174);
            this.BtnVisitText.Name = "BtnVisitText";
            this.BtnVisitText.Size = new System.Drawing.Size(143, 35);
            this.BtnVisitText.TabIndex = 32;
            this.BtnVisitText.Text = "نسخه متنی(F7)";
            this.BtnVisitText.VisualStyleManager = this.visualStyleManager;
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.AfterText;
            this.ButtonCancel.Location = new System.Drawing.Point(114, 256);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(143, 35);
            this.ButtonCancel.TabIndex = 33;
            this.ButtonCancel.Text = "انصراف";
            this.ButtonCancel.VisualStyleManager = this.visualStyleManager;
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonDelete.Enabled = false;
            this.ButtonDelete.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.AfterText;
            this.ButtonDelete.Location = new System.Drawing.Point(387, 256);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(143, 35);
            this.ButtonDelete.TabIndex = 29;
            this.ButtonDelete.Text = "حذف";
            this.ButtonDelete.VisualStyleManager = this.visualStyleManager;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonEdit.Enabled = false;
            this.ButtonEdit.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.AfterText;
            this.ButtonEdit.Location = new System.Drawing.Point(583, 256);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(143, 35);
            this.ButtonEdit.TabIndex = 28;
            this.ButtonEdit.Text = "ویرایش(F9)";
            this.ButtonEdit.VisualStyleManager = this.visualStyleManager;
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonAdd.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.AfterText;
            this.ButtonAdd.Location = new System.Drawing.Point(732, 256);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(143, 35);
            this.ButtonAdd.TabIndex = 27;
            this.ButtonAdd.Text = "ثبت(F2)";
            this.ButtonAdd.VisualStyleManager = this.visualStyleManager;
            // 
            // datePicker1
            // 
            this.datePicker1.BackColor = System.Drawing.SystemColors.Control;
            this.datePicker1.Date = "1402/09/07";
            this.datePicker1.Dock = System.Windows.Forms.DockStyle.Top;
            this.datePicker1.Location = new System.Drawing.Point(387, 86);
            this.datePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.datePicker1.MaximumSize = new System.Drawing.Size(300, 23);
            this.datePicker1.MinimumSize = new System.Drawing.Size(90, 23);
            this.datePicker1.Name = "datePicker1";
            this.datePicker1.Size = new System.Drawing.Size(190, 23);
            this.datePicker1.TabIndex = 34;
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.customGridEx1);
            this.uiGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiGroupBox1.Location = new System.Drawing.Point(10, 369);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Size = new System.Drawing.Size(911, 315);
            this.uiGroupBox1.TabIndex = 0;
            this.uiGroupBox1.Text = "نمایش";
            this.uiGroupBox1.VisualStyleManager = this.visualStyleManager;
            // 
            // customGridEx1
            // 
            this.customGridEx1.BuiltInTextsData = resources.GetString("customGridEx1.BuiltInTextsData");
            this.customGridEx1.DataSource = this.bindingSourceCustomers;
            customGridEx1_DesignTimeLayout.LayoutString = resources.GetString("customGridEx1_DesignTimeLayout.LayoutString");
            this.customGridEx1.DesignTimeLayout = customGridEx1_DesignTimeLayout;
            this.customGridEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customGridEx1.Location = new System.Drawing.Point(3, 31);
            this.customGridEx1.Name = "customGridEx1";
            this.customGridEx1.Size = new System.Drawing.Size(905, 281);
            this.customGridEx1.TabIndex = 0;
            this.customGridEx1.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.customGridEx1.VisualStyleManager = this.visualStyleManager;
            // 
            // bindingSourceCustomers
            // 
            this.bindingSourceCustomers.DataSource = typeof(Ophthalmology.Entity.Entites.Customer);
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSBVisit,
            this.TSBCustomer2VisitList,
            this.ToolStripSeparator1,
            this.ToolStripButton1,
            this.ToolStripButton2,
            this.ToolStripSeparator2,
            this.LableDrName});
            this.ToolStrip1.Location = new System.Drawing.Point(10, 10);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(911, 25);
            this.ToolStrip1.TabIndex = 2;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // TSBVisit
            // 
            this.TSBVisit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TSBVisit.Image = ((System.Drawing.Image)(resources.GetObject("TSBVisit.Image")));
            this.TSBVisit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBVisit.Name = "TSBVisit";
            this.TSBVisit.Size = new System.Drawing.Size(75, 22);
            this.TSBVisit.Text = "لیست ویزیت";
            // 
            // TSBCustomer2VisitList
            // 
            this.TSBCustomer2VisitList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TSBCustomer2VisitList.Image = ((System.Drawing.Image)(resources.GetObject("TSBCustomer2VisitList.Image")));
            this.TSBCustomer2VisitList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBCustomer2VisitList.Name = "TSBCustomer2VisitList";
            this.TSBCustomer2VisitList.Size = new System.Drawing.Size(86, 22);
            this.TSBCustomer2VisitList.Text = "نوبت دهی (F5)";
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolStripButton1
            // 
            this.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton1.Image")));
            this.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton1.Name = "ToolStripButton1";
            this.ToolStripButton1.Size = new System.Drawing.Size(75, 22);
            this.ToolStripButton1.Text = "افزایش فونت";
            // 
            // ToolStripButton2
            // 
            this.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton2.Image")));
            this.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton2.Name = "ToolStripButton2";
            this.ToolStripButton2.Size = new System.Drawing.Size(72, 22);
            this.ToolStripButton2.Text = "کاهش فونت";
            // 
            // ToolStripSeparator2
            // 
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // LableDrName
            // 
            this.LableDrName.ForeColor = System.Drawing.Color.Red;
            this.LableDrName.Name = "LableDrName";
            this.LableDrName.Size = new System.Drawing.Size(22, 22);
            this.LableDrName.Text = "---";
            // 
            // CustomersForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(931, 694);
            this.Controls.Add(this.uiGroupBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.ToolStrip1);
            this.Name = "CustomersForm";
            this.Text = "لیست بیماران";
            this.Load += new System.EventHandler(this.CustomersForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTypePatient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).EndInit();
            this.uiGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customGridEx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCustomers)).EndInit();
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox1;
        private Controls.CustomControls.CustomGridEx customGridEx1;
        private System.Windows.Forms.BindingSource bindingSourceCustomers;
        private System.Windows.Forms.ToolStrip ToolStrip1;
        private System.Windows.Forms.ToolStripButton TSBVisit;
        private System.Windows.Forms.ToolStripButton TSBCustomer2VisitList;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ToolStripButton1;
        private System.Windows.Forms.ToolStripButton ToolStripButton2;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel LableDrName;
        private Janus.Windows.EditControls.UIButton ButtonOldVisit;
        private System.Windows.Forms.Label LableCode;
        private Janus.Windows.GridEX.EditControls.EditBox TextBoxCode;
        private System.Windows.Forms.Label LableName;
        private Janus.Windows.GridEX.EditControls.EditBox TextBoxName;
        private System.Windows.Forms.Label LabelFamily;
        private Janus.Windows.GridEX.EditControls.EditBox TextBoxFamily;
        private System.Windows.Forms.Label LableFatherName;
        private Janus.Windows.GridEX.EditControls.EditBox TextBoxFatherName;
        private System.Windows.Forms.Label LabelDescription;
        private System.Windows.Forms.Label LablePhone;
        private System.Windows.Forms.Label LIdentify_Num;
        private System.Windows.Forms.Label LabelAge;
        private Janus.Windows.EditControls.UIButton ButtonBrowse;
        private Janus.Windows.EditControls.UIComboBox ComboBoxType;
        private Janus.Windows.EditControls.UICheckBox CheckBoxEyeRight;
        private Janus.Windows.EditControls.UICheckBox CheckBoxEyeLeft;
        private Janus.Windows.GridEX.EditControls.EditBox TextBoxAddress;
        private System.Windows.Forms.Label LabelType;
        private System.Windows.Forms.Label LabelAddress;
        private Janus.Windows.GridEX.EditControls.EditBox TextBoxDescription;
        private Janus.Windows.EditControls.UIButton ButtonCancel;
        private Janus.Windows.EditControls.UIButton ButtonDelete;
        private Janus.Windows.EditControls.UIButton BtnVisitText;
        private Janus.Windows.EditControls.UIButton BtnVisit;
        private Janus.Windows.EditControls.UIButton ButtonEdit;
        private Janus.Windows.EditControls.UIButton ButtonAdd;
        private System.Windows.Forms.Label LableRegDate;
        private Janus.Windows.GridEX.EditControls.EditBox TextBoxAge;
        private Janus.Windows.GridEX.EditControls.EditBox TextBoxReason;
        private Janus.Windows.GridEX.EditControls.EditBox TextBoxTel;
        private System.Windows.Forms.BindingSource bindingSourceTypePatient;
        private Devy.Windows.DatePicker datePicker1;
    }
}