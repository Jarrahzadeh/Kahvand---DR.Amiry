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
            Janus.Windows.GridEX.GridEXLayout customGridEx1_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomersForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonBrowse = new Janus.Windows.EditControls.UIButton();
            this.TextBoxAddress = new Janus.Windows.GridEX.EditControls.EditBox();
            this.bindingSourceCustomers = new System.Windows.Forms.BindingSource(this.components);
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnVisit = new Janus.Windows.EditControls.UIButton();
            this.BtnVisitText = new Janus.Windows.EditControls.UIButton();
            this.ButtonOldVisit = new Janus.Windows.EditControls.UIButton();
            this.ButtonVisitList = new Janus.Windows.EditControls.UIButton();
            this.ButtonAppointment = new Janus.Windows.EditControls.UIButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonAdd = new Janus.Windows.EditControls.UIButton();
            this.ButtonSave = new Janus.Windows.EditControls.UIButton();
            this.ButtonDelete = new Janus.Windows.EditControls.UIButton();
            this.ButtonCancel = new Janus.Windows.EditControls.UIButton();
            this.customGridEx1 = new Ophthalmology.Controls.CustomControls.CustomGridEx();
            this.dateTimePickerX1 = new BehComponents.DateTimePickerX();
            this.DateTimePickerEyeLeft = new BehComponents.DateTimePickerX();
            this.DateTimePickerEyeRight = new BehComponents.DateTimePickerX();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTypePatient)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customGridEx1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.ButtonBrowse, 4, 7);
            this.tableLayoutPanel1.Controls.Add(this.TextBoxAddress, 6, 7);
            this.tableLayoutPanel1.Controls.Add(this.LableCode, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.TextBoxDescription, 6, 6);
            this.tableLayoutPanel1.Controls.Add(this.TextBoxCode, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.CheckBoxEyeRight, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.LableName, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.CheckBoxEyeLeft, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.TextBoxName, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.LabelFamily, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.TextBoxFamily, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.TextBoxReason, 6, 4);
            this.tableLayoutPanel1.Controls.Add(this.LabelAddress, 5, 7);
            this.tableLayoutPanel1.Controls.Add(this.TextBoxTel, 6, 3);
            this.tableLayoutPanel1.Controls.Add(this.LableFatherName, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.TextBoxFatherName, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.LabelDescription, 5, 6);
            this.tableLayoutPanel1.Controls.Add(this.LablePhone, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.LIdentify_Num, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.LabelAge, 5, 5);
            this.tableLayoutPanel1.Controls.Add(this.LableRegDate, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.ComboBoxType, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.LabelType, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.TextBoxAge, 6, 5);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePickerX1, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.DateTimePickerEyeLeft, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.DateTimePickerEyeRight, 3, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(970, 372);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // ButtonBrowse
            // 
            this.ButtonBrowse.Location = new System.Drawing.Point(348, 266);
            this.ButtonBrowse.Name = "ButtonBrowse";
            this.ButtonBrowse.Size = new System.Drawing.Size(35, 35);
            this.ButtonBrowse.TabIndex = 26;
            this.ButtonBrowse.Text = "...";
            this.ButtonBrowse.VisualStyleManager = this.visualStyleManager;
            this.ButtonBrowse.Click += new System.EventHandler(this.ButtonBrowse_Click);
            // 
            // TextBoxAddress
            // 
            this.TextBoxAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCustomers, "Address", true));
            this.TextBoxAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxAddress.Location = new System.Drawing.Point(23, 266);
            this.TextBoxAddress.Name = "TextBoxAddress";
            this.TextBoxAddress.Size = new System.Drawing.Size(236, 35);
            this.TextBoxAddress.TabIndex = 17;
            this.TextBoxAddress.VisualStyleManager = this.visualStyleManager;
            // 
            // bindingSourceCustomers
            // 
            this.bindingSourceCustomers.DataSource = typeof(Ophthalmology.Entity.Entites.Customer);
            this.bindingSourceCustomers.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.bindingSourceCustomers_AddingNew);
            this.bindingSourceCustomers.BindingComplete += new System.Windows.Forms.BindingCompleteEventHandler(this.bindingSourceCustomers_BindingComplete);
            this.bindingSourceCustomers.DataError += new System.Windows.Forms.BindingManagerDataErrorEventHandler(this.bindingSourceCustomers_DataError);
            this.bindingSourceCustomers.DataSourceChanged += new System.EventHandler(this.bindingSourceCustomers_DataSourceChanged);
            this.bindingSourceCustomers.DataMemberChanged += new System.EventHandler(this.bindingSourceCustomers_DataMemberChanged);
            this.bindingSourceCustomers.CurrentChanged += new System.EventHandler(this.bindingSourceCustomers_CurrentChanged);
            this.bindingSourceCustomers.CurrentItemChanged += new System.EventHandler(this.bindingSourceCustomers_CurrentItemChanged);
            this.bindingSourceCustomers.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.bindingSourceCustomers_ListChanged);
            this.bindingSourceCustomers.PositionChanged += new System.EventHandler(this.bindingSourceCustomers_PositionChanged);
            // 
            // LableCode
            // 
            this.LableCode.AutoSize = true;
            this.LableCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LableCode.Location = new System.Drawing.Point(940, 58);
            this.LableCode.Name = "LableCode";
            this.LableCode.Size = new System.Drawing.Size(27, 41);
            this.LableCode.TabIndex = 0;
            this.LableCode.Text = "کد";
            this.LableCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TextBoxDescription
            // 
            this.TextBoxDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCustomers, "Dis", true));
            this.TextBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxDescription.Location = new System.Drawing.Point(23, 225);
            this.TextBoxDescription.Name = "TextBoxDescription";
            this.TextBoxDescription.Size = new System.Drawing.Size(236, 35);
            this.TextBoxDescription.TabIndex = 15;
            this.TextBoxDescription.VisualStyleManager = this.visualStyleManager;
            // 
            // TextBoxCode
            // 
            this.TextBoxCode.BackColor = System.Drawing.Color.AntiqueWhite;
            this.TextBoxCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxCode.Location = new System.Drawing.Point(734, 61);
            this.TextBoxCode.Name = "TextBoxCode";
            this.TextBoxCode.ReadOnly = true;
            this.TextBoxCode.Size = new System.Drawing.Size(200, 35);
            this.TextBoxCode.TabIndex = 1;
            this.TextBoxCode.TabStop = false;
            this.TextBoxCode.VisualStyleManager = this.visualStyleManager;
            // 
            // CheckBoxEyeRight
            // 
            this.CheckBoxEyeRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckBoxEyeRight.Location = new System.Drawing.Point(585, 225);
            this.CheckBoxEyeRight.Name = "CheckBoxEyeRight";
            this.CheckBoxEyeRight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CheckBoxEyeRight.Size = new System.Drawing.Size(143, 35);
            this.CheckBoxEyeRight.TabIndex = 22;
            this.CheckBoxEyeRight.Text = " تاریخ عمل چشم راست";
            this.CheckBoxEyeRight.VisualStyleManager = this.visualStyleManager;
            this.CheckBoxEyeRight.CheckedChanged += new System.EventHandler(this.CheckBoxEyeRight_CheckedChanged);
            // 
            // LableName
            // 
            this.LableName.AutoSize = true;
            this.LableName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LableName.Location = new System.Drawing.Point(585, 58);
            this.LableName.Name = "LableName";
            this.LableName.Size = new System.Drawing.Size(143, 41);
            this.LableName.TabIndex = 2;
            this.LableName.Text = "نام";
            this.LableName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CheckBoxEyeLeft
            // 
            this.CheckBoxEyeLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckBoxEyeLeft.Location = new System.Drawing.Point(585, 184);
            this.CheckBoxEyeLeft.Name = "CheckBoxEyeLeft";
            this.CheckBoxEyeLeft.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CheckBoxEyeLeft.Size = new System.Drawing.Size(143, 35);
            this.CheckBoxEyeLeft.TabIndex = 20;
            this.CheckBoxEyeLeft.Text = " تاریخ عمل چشم چپ";
            this.CheckBoxEyeLeft.VisualStyleManager = this.visualStyleManager;
            this.CheckBoxEyeLeft.CheckedChanged += new System.EventHandler(this.CheckBoxEyeLeft_CheckedChanged);
            // 
            // TextBoxName
            // 
            this.TextBoxName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCustomers, "Name", true));
            this.TextBoxName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxName.Location = new System.Drawing.Point(389, 61);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(190, 35);
            this.TextBoxName.TabIndex = 3;
            this.TextBoxName.VisualStyleManager = this.visualStyleManager;
            // 
            // LabelFamily
            // 
            this.LabelFamily.AutoSize = true;
            this.LabelFamily.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelFamily.Location = new System.Drawing.Point(585, 99);
            this.LabelFamily.Name = "LabelFamily";
            this.LabelFamily.Size = new System.Drawing.Size(143, 41);
            this.LabelFamily.TabIndex = 4;
            this.LabelFamily.Text = "نام خانوادگی";
            this.LabelFamily.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TextBoxFamily
            // 
            this.TextBoxFamily.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCustomers, "Family", true));
            this.TextBoxFamily.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxFamily.Location = new System.Drawing.Point(389, 102);
            this.TextBoxFamily.Name = "TextBoxFamily";
            this.TextBoxFamily.Size = new System.Drawing.Size(190, 35);
            this.TextBoxFamily.TabIndex = 5;
            this.TextBoxFamily.VisualStyleManager = this.visualStyleManager;
            // 
            // TextBoxReason
            // 
            this.TextBoxReason.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCustomers, "Reason", true));
            this.TextBoxReason.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxReason.Location = new System.Drawing.Point(23, 143);
            this.TextBoxReason.Name = "TextBoxReason";
            this.TextBoxReason.Size = new System.Drawing.Size(236, 35);
            this.TextBoxReason.TabIndex = 11;
            this.TextBoxReason.VisualStyleManager = this.visualStyleManager;
            // 
            // LabelAddress
            // 
            this.LabelAddress.AutoSize = true;
            this.LabelAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelAddress.Location = new System.Drawing.Point(265, 263);
            this.LabelAddress.Name = "LabelAddress";
            this.LabelAddress.Size = new System.Drawing.Size(77, 41);
            this.LabelAddress.TabIndex = 16;
            this.LabelAddress.Text = "آدرس";
            this.LabelAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TextBoxTel
            // 
            this.TextBoxTel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCustomers, "Tel", true));
            this.TextBoxTel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxTel.Location = new System.Drawing.Point(23, 102);
            this.TextBoxTel.Name = "TextBoxTel";
            this.TextBoxTel.Size = new System.Drawing.Size(236, 35);
            this.TextBoxTel.TabIndex = 9;
            this.TextBoxTel.VisualStyleManager = this.visualStyleManager;
            // 
            // LableFatherName
            // 
            this.LableFatherName.AutoSize = true;
            this.LableFatherName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LableFatherName.Location = new System.Drawing.Point(265, 58);
            this.LableFatherName.Name = "LableFatherName";
            this.LableFatherName.Size = new System.Drawing.Size(77, 41);
            this.LableFatherName.TabIndex = 6;
            this.LableFatherName.Text = "نام پدر";
            this.LableFatherName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TextBoxFatherName
            // 
            this.TextBoxFatherName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCustomers, "NameFather", true));
            this.TextBoxFatherName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxFatherName.Location = new System.Drawing.Point(23, 61);
            this.TextBoxFatherName.Name = "TextBoxFatherName";
            this.TextBoxFatherName.Size = new System.Drawing.Size(236, 35);
            this.TextBoxFatherName.TabIndex = 7;
            this.TextBoxFatherName.VisualStyleManager = this.visualStyleManager;
            // 
            // LabelDescription
            // 
            this.LabelDescription.AutoSize = true;
            this.LabelDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelDescription.Location = new System.Drawing.Point(265, 222);
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
            this.LablePhone.Location = new System.Drawing.Point(265, 99);
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
            this.LIdentify_Num.Location = new System.Drawing.Point(265, 140);
            this.LIdentify_Num.Name = "LIdentify_Num";
            this.LIdentify_Num.Size = new System.Drawing.Size(77, 41);
            this.LIdentify_Num.TabIndex = 10;
            this.LIdentify_Num.Text = "علت مراجعه";
            this.LIdentify_Num.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabelAge
            // 
            this.LabelAge.AutoSize = true;
            this.LabelAge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelAge.Location = new System.Drawing.Point(265, 181);
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
            this.LableRegDate.Location = new System.Drawing.Point(585, 140);
            this.LableRegDate.Name = "LableRegDate";
            this.LableRegDate.Size = new System.Drawing.Size(143, 41);
            this.LableRegDate.TabIndex = 18;
            this.LableRegDate.Text = "تاریخ ثبت";
            this.LableRegDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ComboBoxType
            // 
            this.ComboBoxType.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
            this.ComboBoxType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingSourceCustomers, "IdTypePatient", true));
            this.ComboBoxType.DataSource = this.bindingSourceTypePatient;
            this.ComboBoxType.DisplayMember = "Name";
            this.ComboBoxType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComboBoxType.Location = new System.Drawing.Point(389, 266);
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
            this.LabelType.Location = new System.Drawing.Point(585, 263);
            this.LabelType.Name = "LabelType";
            this.LabelType.Size = new System.Drawing.Size(143, 41);
            this.LabelType.TabIndex = 24;
            this.LabelType.Text = "نوع بیمار (بیمه)";
            this.LabelType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TextBoxAge
            // 
            this.TextBoxAge.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCustomers, "Age", true));
            this.TextBoxAge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxAge.Location = new System.Drawing.Point(23, 184);
            this.TextBoxAge.MaxLength = 30;
            this.TextBoxAge.Name = "TextBoxAge";
            this.TextBoxAge.Size = new System.Drawing.Size(236, 35);
            this.TextBoxAge.TabIndex = 13;
            this.TextBoxAge.VisualStyleManager = this.visualStyleManager;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 8);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.BtnVisit, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnVisitText, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.ButtonOldVisit, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.ButtonVisitList, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ButtonAppointment, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(964, 42);
            this.tableLayoutPanel2.TabIndex = 34;
            // 
            // BtnVisit
            // 
            this.BtnVisit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnVisit.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.AfterText;
            this.BtnVisit.Location = new System.Drawing.Point(199, 3);
            this.BtnVisit.Name = "BtnVisit";
            this.BtnVisit.Size = new System.Drawing.Size(186, 36);
            this.BtnVisit.TabIndex = 32;
            this.BtnVisit.Text = "نسخه قلم(F6)";
            this.BtnVisit.VisualStyleManager = this.visualStyleManager;
            // 
            // BtnVisitText
            // 
            this.BtnVisitText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnVisitText.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.AfterText;
            this.BtnVisitText.Location = new System.Drawing.Point(3, 3);
            this.BtnVisitText.Name = "BtnVisitText";
            this.BtnVisitText.Size = new System.Drawing.Size(190, 36);
            this.BtnVisitText.TabIndex = 33;
            this.BtnVisitText.Text = "نسخه متنی(F7)";
            this.BtnVisitText.VisualStyleManager = this.visualStyleManager;
            // 
            // ButtonOldVisit
            // 
            this.ButtonOldVisit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonOldVisit.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.AfterText;
            this.ButtonOldVisit.Location = new System.Drawing.Point(391, 3);
            this.ButtonOldVisit.Name = "ButtonOldVisit";
            this.ButtonOldVisit.Size = new System.Drawing.Size(186, 36);
            this.ButtonOldVisit.TabIndex = 31;
            this.ButtonOldVisit.Text = "نسخه های قبلی";
            this.ButtonOldVisit.VisualStyleManager = this.visualStyleManager;
            // 
            // ButtonVisitList
            // 
            this.ButtonVisitList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonVisitList.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.AfterText;
            this.ButtonVisitList.Location = new System.Drawing.Point(775, 3);
            this.ButtonVisitList.Name = "ButtonVisitList";
            this.ButtonVisitList.Size = new System.Drawing.Size(186, 36);
            this.ButtonVisitList.TabIndex = 31;
            this.ButtonVisitList.Text = "لیست ویزیت";
            this.ButtonVisitList.VisualStyleManager = this.visualStyleManager;
            // 
            // ButtonAppointment
            // 
            this.ButtonAppointment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonAppointment.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.AfterText;
            this.ButtonAppointment.Location = new System.Drawing.Point(583, 3);
            this.ButtonAppointment.Name = "ButtonAppointment";
            this.ButtonAppointment.Size = new System.Drawing.Size(186, 36);
            this.ButtonAppointment.TabIndex = 31;
            this.ButtonAppointment.Text = "نوبت دهی";
            this.ButtonAppointment.VisualStyleManager = this.visualStyleManager;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel3, 8);
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Controls.Add(this.ButtonAdd, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.ButtonSave, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.ButtonDelete, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.ButtonCancel, 4, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 317);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(964, 42);
            this.tableLayoutPanel3.TabIndex = 35;
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonAdd.Location = new System.Drawing.Point(775, 3);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(186, 36);
            this.ButtonAdd.TabIndex = 27;
            this.ButtonAdd.Text = "جدید";
            this.ButtonAdd.VisualStyleManager = this.visualStyleManager;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonSave.Location = new System.Drawing.Point(583, 3);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(186, 36);
            this.ButtonSave.TabIndex = 28;
            this.ButtonSave.Text = "ذخیره";
            this.ButtonSave.VisualStyleManager = this.visualStyleManager;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonDelete.Location = new System.Drawing.Point(391, 3);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(186, 36);
            this.ButtonDelete.TabIndex = 29;
            this.ButtonDelete.Text = "حذف";
            this.ButtonDelete.VisualStyleManager = this.visualStyleManager;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonCancel.Location = new System.Drawing.Point(3, 3);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(190, 36);
            this.ButtonCancel.TabIndex = 30;
            this.ButtonCancel.Text = "انصراف";
            this.ButtonCancel.VisualStyleManager = this.visualStyleManager;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // customGridEx1
            // 
            this.customGridEx1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.customGridEx1.AlternatingColors = true;
            this.customGridEx1.BuiltInTextsData = resources.GetString("customGridEx1.BuiltInTextsData");
            this.customGridEx1.ColumnAutoResize = true;
            this.customGridEx1.DataSource = this.bindingSourceCustomers;
            customGridEx1_DesignTimeLayout.LayoutString = resources.GetString("customGridEx1_DesignTimeLayout.LayoutString");
            this.customGridEx1.DesignTimeLayout = customGridEx1_DesignTimeLayout;
            this.customGridEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customGridEx1.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.customGridEx1.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.customGridEx1.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.customGridEx1.GroupByBoxVisible = false;
            this.customGridEx1.Location = new System.Drawing.Point(10, 382);
            this.customGridEx1.Name = "customGridEx1";
            this.customGridEx1.Size = new System.Drawing.Size(970, 341);
            this.customGridEx1.TabIndex = 0;
            this.customGridEx1.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.customGridEx1.VisualStyleManager = this.visualStyleManager;
            // 
            // dateTimePickerX1
            // 
            this.dateTimePickerX1.AnchorSize = new System.Drawing.Size(190, 35);
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
            this.dateTimePickerX1.CustomFormat = "yyyy/MM/dd";
            this.dateTimePickerX1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedDateInStringPersian", this.bindingSourceCustomers, "DateSave", true));
            this.dateTimePickerX1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePickerX1.DockSide = BehComponents.DropDownEmpty.Alignments.Left;
            this.dateTimePickerX1.DropDownClosedWhenClickOnDays = false;
            this.dateTimePickerX1.DropDownClosedWhenSelectedDateChanged = false;
            this.dateTimePickerX1.Format = BehComponents.DateTimePickerX.FormatDate.Custom;
            this.dateTimePickerX1.Format4Binding = "yyyy/MM/dd";
            this.dateTimePickerX1.Location = new System.Drawing.Point(389, 143);
            this.dateTimePickerX1.Name = "dateTimePickerX1";
            this.dateTimePickerX1.RightToLeftLayout = true;
            this.dateTimePickerX1.ShowClearButton = false;
            this.dateTimePickerX1.Size = new System.Drawing.Size(190, 35);
            this.dateTimePickerX1.TabIndex = 36;
            this.dateTimePickerX1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dateTimePickerX1.TextWhenClearButtonClicked = "";
            // 
            // DateTimePickerEyeLeft
            // 
            this.DateTimePickerEyeLeft.AnchorSize = new System.Drawing.Size(190, 35);
            this.DateTimePickerEyeLeft.BackColor = System.Drawing.Color.White;
            this.DateTimePickerEyeLeft.CalendarBoldedDayForeColor = System.Drawing.Color.Blue;
            this.DateTimePickerEyeLeft.CalendarBorderColor = System.Drawing.Color.CadetBlue;
            this.DateTimePickerEyeLeft.CalendarDayRectTickness = 2F;
            this.DateTimePickerEyeLeft.CalendarDaysBackColor = System.Drawing.Color.LightGray;
            this.DateTimePickerEyeLeft.CalendarDaysFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimePickerEyeLeft.CalendarDaysForeColor = System.Drawing.Color.DodgerBlue;
            this.DateTimePickerEyeLeft.CalendarEnglishAnnuallyBoldedDates = new System.DateTime[0];
            this.DateTimePickerEyeLeft.CalendarEnglishBoldedDates = new System.DateTime[0];
            this.DateTimePickerEyeLeft.CalendarEnglishHolidayDates = new System.DateTime[0];
            this.DateTimePickerEyeLeft.CalendarEnglishMonthlyBoldedDates = new System.DateTime[0];
            this.DateTimePickerEyeLeft.CalendarHolidayForeColor = System.Drawing.Color.Red;
            this.DateTimePickerEyeLeft.CalendarHolidayWeekly = BehComponents.MonthCalendarX.DayOfWeekForHoliday.Friday;
            this.DateTimePickerEyeLeft.CalendarLineWeekColor = System.Drawing.Color.Black;
            this.DateTimePickerEyeLeft.CalendarPersianAnnuallyBoldedDates = new BehComponents.PersianDateTime[0];
            this.DateTimePickerEyeLeft.CalendarPersianBoldedDates = new BehComponents.PersianDateTime[0];
            this.DateTimePickerEyeLeft.CalendarPersianHolidayDates = new BehComponents.PersianDateTime[0];
            this.DateTimePickerEyeLeft.CalendarPersianMonthlyBoldedDates = new BehComponents.PersianDateTime[0];
            this.DateTimePickerEyeLeft.CalendarShowToday = true;
            this.DateTimePickerEyeLeft.CalendarShowTodayRect = true;
            this.DateTimePickerEyeLeft.CalendarShowToolTips = false;
            this.DateTimePickerEyeLeft.CalendarShowTrailing = true;
            this.DateTimePickerEyeLeft.CalendarStyle_DaysButton = BehComponents.ButtonX.ButtonStyles.Simple;
            this.DateTimePickerEyeLeft.CalendarStyle_GotoTodayButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.DateTimePickerEyeLeft.CalendarStyle_MonthButton = BehComponents.ButtonX.ButtonStyles.Blue;
            this.DateTimePickerEyeLeft.CalendarStyle_NextMonthButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.DateTimePickerEyeLeft.CalendarStyle_PreviousMonthButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.DateTimePickerEyeLeft.CalendarStyle_YearButton = BehComponents.ButtonX.ButtonStyles.Blue;
            this.DateTimePickerEyeLeft.CalendarTitleBackColor = System.Drawing.Color.Wheat;
            this.DateTimePickerEyeLeft.CalendarTitleFont = new System.Drawing.Font("Tahoma", 8.25F);
            this.DateTimePickerEyeLeft.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.DateTimePickerEyeLeft.CalendarTodayBackColor = System.Drawing.Color.Wheat;
            this.DateTimePickerEyeLeft.CalendarTodayFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.DateTimePickerEyeLeft.CalendarTodayForeColor = System.Drawing.Color.Black;
            this.DateTimePickerEyeLeft.CalendarTodayRectColor = System.Drawing.Color.Coral;
            this.DateTimePickerEyeLeft.CalendarTodayRectTickness = 2F;
            this.DateTimePickerEyeLeft.CalendarTrailingForeColor = System.Drawing.Color.DarkGray;
            this.DateTimePickerEyeLeft.CalendarType = BehComponents.CalendarTypes.Persian;
            this.DateTimePickerEyeLeft.CalendarWeekDaysBackColor = System.Drawing.Color.Wheat;
            this.DateTimePickerEyeLeft.CalendarWeekDaysFont = new System.Drawing.Font("Tahoma", 8.25F);
            this.DateTimePickerEyeLeft.CalendarWeekDaysForeColor = System.Drawing.Color.OrangeRed;
            this.DateTimePickerEyeLeft.CalendarWeekStartsOn = BehComponents.MonthCalendarX.WeekDays.Saturday;
            this.DateTimePickerEyeLeft.ClearButtonAlignment = BehComponents.DropDownEmpty.Alignments.Left;
            this.DateTimePickerEyeLeft.ClearButtonBackColor = System.Drawing.Color.White;
            this.DateTimePickerEyeLeft.ClearButtonForeColor = System.Drawing.SystemColors.ControlText;
            this.DateTimePickerEyeLeft.ClearButtonImage = ((System.Drawing.Image)(resources.GetObject("DateTimePickerEyeLeft.ClearButtonImage")));
            this.DateTimePickerEyeLeft.ClearButtonImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DateTimePickerEyeLeft.ClearButtonImageFixedSize = new System.Drawing.Size(0, 0);
            this.DateTimePickerEyeLeft.ClearButtonImageSizeMode = BehComponents.DropDownEmpty.ImageSizeModes.Zoom;
            this.DateTimePickerEyeLeft.ClearButtonText = "";
            this.DateTimePickerEyeLeft.ClearButtonTextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DateTimePickerEyeLeft.ClearButtonToolTip = "";
            this.DateTimePickerEyeLeft.ClearButtonWidth = 17;
            this.DateTimePickerEyeLeft.ClearDateTimeWhenDownDeleteKey = true;
            this.DateTimePickerEyeLeft.CustomFormat = "yyyy/MM/dd";
            this.DateTimePickerEyeLeft.DataBindings.Add(new System.Windows.Forms.Binding("SelectedDateInStringPersian", this.bindingSourceCustomers, "EyeLeft", true));
            this.DateTimePickerEyeLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DateTimePickerEyeLeft.DockSide = BehComponents.DropDownEmpty.Alignments.Left;
            this.DateTimePickerEyeLeft.DropDownClosedWhenClickOnDays = false;
            this.DateTimePickerEyeLeft.DropDownClosedWhenSelectedDateChanged = false;
            this.DateTimePickerEyeLeft.Enabled = false;
            this.DateTimePickerEyeLeft.Format = BehComponents.DateTimePickerX.FormatDate.Custom;
            this.DateTimePickerEyeLeft.Format4Binding = "yyyy/MM/dd";
            this.DateTimePickerEyeLeft.Location = new System.Drawing.Point(389, 184);
            this.DateTimePickerEyeLeft.Name = "DateTimePickerEyeLeft";
            this.DateTimePickerEyeLeft.RightToLeftLayout = true;
            this.DateTimePickerEyeLeft.ShowClearButton = false;
            this.DateTimePickerEyeLeft.Size = new System.Drawing.Size(190, 35);
            this.DateTimePickerEyeLeft.TabIndex = 37;
            this.DateTimePickerEyeLeft.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DateTimePickerEyeLeft.TextWhenClearButtonClicked = "";
            // 
            // DateTimePickerEyeRight
            // 
            this.DateTimePickerEyeRight.AnchorSize = new System.Drawing.Size(190, 35);
            this.DateTimePickerEyeRight.BackColor = System.Drawing.Color.White;
            this.DateTimePickerEyeRight.CalendarBoldedDayForeColor = System.Drawing.Color.Blue;
            this.DateTimePickerEyeRight.CalendarBorderColor = System.Drawing.Color.CadetBlue;
            this.DateTimePickerEyeRight.CalendarDayRectTickness = 2F;
            this.DateTimePickerEyeRight.CalendarDaysBackColor = System.Drawing.Color.LightGray;
            this.DateTimePickerEyeRight.CalendarDaysFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimePickerEyeRight.CalendarDaysForeColor = System.Drawing.Color.DodgerBlue;
            this.DateTimePickerEyeRight.CalendarEnglishAnnuallyBoldedDates = new System.DateTime[0];
            this.DateTimePickerEyeRight.CalendarEnglishBoldedDates = new System.DateTime[0];
            this.DateTimePickerEyeRight.CalendarEnglishHolidayDates = new System.DateTime[0];
            this.DateTimePickerEyeRight.CalendarEnglishMonthlyBoldedDates = new System.DateTime[0];
            this.DateTimePickerEyeRight.CalendarHolidayForeColor = System.Drawing.Color.Red;
            this.DateTimePickerEyeRight.CalendarHolidayWeekly = BehComponents.MonthCalendarX.DayOfWeekForHoliday.Friday;
            this.DateTimePickerEyeRight.CalendarLineWeekColor = System.Drawing.Color.Black;
            this.DateTimePickerEyeRight.CalendarPersianAnnuallyBoldedDates = new BehComponents.PersianDateTime[0];
            this.DateTimePickerEyeRight.CalendarPersianBoldedDates = new BehComponents.PersianDateTime[0];
            this.DateTimePickerEyeRight.CalendarPersianHolidayDates = new BehComponents.PersianDateTime[0];
            this.DateTimePickerEyeRight.CalendarPersianMonthlyBoldedDates = new BehComponents.PersianDateTime[0];
            this.DateTimePickerEyeRight.CalendarShowToday = true;
            this.DateTimePickerEyeRight.CalendarShowTodayRect = true;
            this.DateTimePickerEyeRight.CalendarShowToolTips = false;
            this.DateTimePickerEyeRight.CalendarShowTrailing = true;
            this.DateTimePickerEyeRight.CalendarStyle_DaysButton = BehComponents.ButtonX.ButtonStyles.Simple;
            this.DateTimePickerEyeRight.CalendarStyle_GotoTodayButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.DateTimePickerEyeRight.CalendarStyle_MonthButton = BehComponents.ButtonX.ButtonStyles.Blue;
            this.DateTimePickerEyeRight.CalendarStyle_NextMonthButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.DateTimePickerEyeRight.CalendarStyle_PreviousMonthButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.DateTimePickerEyeRight.CalendarStyle_YearButton = BehComponents.ButtonX.ButtonStyles.Blue;
            this.DateTimePickerEyeRight.CalendarTitleBackColor = System.Drawing.Color.Wheat;
            this.DateTimePickerEyeRight.CalendarTitleFont = new System.Drawing.Font("Tahoma", 8.25F);
            this.DateTimePickerEyeRight.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.DateTimePickerEyeRight.CalendarTodayBackColor = System.Drawing.Color.Wheat;
            this.DateTimePickerEyeRight.CalendarTodayFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.DateTimePickerEyeRight.CalendarTodayForeColor = System.Drawing.Color.Black;
            this.DateTimePickerEyeRight.CalendarTodayRectColor = System.Drawing.Color.Coral;
            this.DateTimePickerEyeRight.CalendarTodayRectTickness = 2F;
            this.DateTimePickerEyeRight.CalendarTrailingForeColor = System.Drawing.Color.DarkGray;
            this.DateTimePickerEyeRight.CalendarType = BehComponents.CalendarTypes.Persian;
            this.DateTimePickerEyeRight.CalendarWeekDaysBackColor = System.Drawing.Color.Wheat;
            this.DateTimePickerEyeRight.CalendarWeekDaysFont = new System.Drawing.Font("Tahoma", 8.25F);
            this.DateTimePickerEyeRight.CalendarWeekDaysForeColor = System.Drawing.Color.OrangeRed;
            this.DateTimePickerEyeRight.CalendarWeekStartsOn = BehComponents.MonthCalendarX.WeekDays.Saturday;
            this.DateTimePickerEyeRight.ClearButtonAlignment = BehComponents.DropDownEmpty.Alignments.Left;
            this.DateTimePickerEyeRight.ClearButtonBackColor = System.Drawing.Color.White;
            this.DateTimePickerEyeRight.ClearButtonForeColor = System.Drawing.SystemColors.ControlText;
            this.DateTimePickerEyeRight.ClearButtonImage = ((System.Drawing.Image)(resources.GetObject("DateTimePickerEyeRight.ClearButtonImage")));
            this.DateTimePickerEyeRight.ClearButtonImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DateTimePickerEyeRight.ClearButtonImageFixedSize = new System.Drawing.Size(0, 0);
            this.DateTimePickerEyeRight.ClearButtonImageSizeMode = BehComponents.DropDownEmpty.ImageSizeModes.Zoom;
            this.DateTimePickerEyeRight.ClearButtonText = "";
            this.DateTimePickerEyeRight.ClearButtonTextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DateTimePickerEyeRight.ClearButtonToolTip = "";
            this.DateTimePickerEyeRight.ClearButtonWidth = 17;
            this.DateTimePickerEyeRight.ClearDateTimeWhenDownDeleteKey = true;
            this.DateTimePickerEyeRight.CustomFormat = "yyyy/MM/dd";
            this.DateTimePickerEyeRight.DataBindings.Add(new System.Windows.Forms.Binding("SelectedDateInStringPersian", this.bindingSourceCustomers, "EyeRight", true));
            this.DateTimePickerEyeRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DateTimePickerEyeRight.DockSide = BehComponents.DropDownEmpty.Alignments.Left;
            this.DateTimePickerEyeRight.DropDownClosedWhenClickOnDays = false;
            this.DateTimePickerEyeRight.DropDownClosedWhenSelectedDateChanged = false;
            this.DateTimePickerEyeRight.Enabled = false;
            this.DateTimePickerEyeRight.Format = BehComponents.DateTimePickerX.FormatDate.Custom;
            this.DateTimePickerEyeRight.Format4Binding = "yyyy/MM/dd";
            this.DateTimePickerEyeRight.Location = new System.Drawing.Point(389, 225);
            this.DateTimePickerEyeRight.Name = "DateTimePickerEyeRight";
            this.DateTimePickerEyeRight.RightToLeftLayout = true;
            this.DateTimePickerEyeRight.ShowClearButton = false;
            this.DateTimePickerEyeRight.Size = new System.Drawing.Size(190, 35);
            this.DateTimePickerEyeRight.TabIndex = 38;
            this.DateTimePickerEyeRight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DateTimePickerEyeRight.TextWhenClearButtonClicked = "";
            // 
            // CustomersForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(990, 733);
            this.Controls.Add(this.customGridEx1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CustomersForm";
            this.Text = "لیست بیماران";
            this.Load += new System.EventHandler(this.CustomersForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTypePatient)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customGridEx1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Controls.CustomControls.CustomGridEx customGridEx1;
        private System.Windows.Forms.BindingSource bindingSourceCustomers;
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
        private Janus.Windows.EditControls.UIButton ButtonSave;
        private Janus.Windows.EditControls.UIButton ButtonAdd;
        private System.Windows.Forms.Label LableRegDate;
        private Janus.Windows.GridEX.EditControls.EditBox TextBoxAge;
        private Janus.Windows.GridEX.EditControls.EditBox TextBoxReason;
        private Janus.Windows.GridEX.EditControls.EditBox TextBoxTel;
        private System.Windows.Forms.BindingSource bindingSourceTypePatient;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Janus.Windows.EditControls.UIButton ButtonVisitList;
        private Janus.Windows.EditControls.UIButton ButtonAppointment;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private BehComponents.DateTimePickerX dateTimePickerX1;
        private BehComponents.DateTimePickerX DateTimePickerEyeLeft;
        private BehComponents.DateTimePickerX DateTimePickerEyeRight;
    }
}