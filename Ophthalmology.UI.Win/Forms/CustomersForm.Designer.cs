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
            Janus.Windows.GridEX.GridEXLayout gridCustomers_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonBrowse = new Janus.Windows.EditControls.UIButton();
            this.lableCode = new System.Windows.Forms.Label();
            this.textBoxCode = new Janus.Windows.GridEX.EditControls.EditBox();
            this.checkBoxEyeRight = new Janus.Windows.EditControls.UICheckBox();
            this.lableName = new System.Windows.Forms.Label();
            this.checkBoxEyeLeft = new Janus.Windows.EditControls.UICheckBox();
            this.textBoxName = new Janus.Windows.GridEX.EditControls.EditBox();
            this.bindingSourceCustomers = new System.Windows.Forms.BindingSource(this.components);
            this.labelFamily = new System.Windows.Forms.Label();
            this.textBoxFamily = new Janus.Windows.GridEX.EditControls.EditBox();
            this.textBoxTel = new Janus.Windows.GridEX.EditControls.EditBox();
            this.lableFatherName = new System.Windows.Forms.Label();
            this.textBoxFatherName = new Janus.Windows.GridEX.EditControls.EditBox();
            this.lablePhone = new System.Windows.Forms.Label();
            this.lableRegDate = new System.Windows.Forms.Label();
            this.comboBoxType = new Janus.Windows.EditControls.UIComboBox();
            this.bindingSourceTypePatient = new System.Windows.Forms.BindingSource(this.components);
            this.labelType = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonVisit = new Janus.Windows.EditControls.UIButton();
            this.buttonVisitText = new Janus.Windows.EditControls.UIButton();
            this.buttonOldVisit = new Janus.Windows.EditControls.UIButton();
            this.buttonVisitList = new Janus.Windows.EditControls.UIButton();
            this.buttonAppointment = new Janus.Windows.EditControls.UIButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonAdd = new Janus.Windows.EditControls.UIButton();
            this.buttonCancel = new Janus.Windows.EditControls.UIButton();
            this.buttonDelete = new Janus.Windows.EditControls.UIButton();
            this.buttonSave = new Janus.Windows.EditControls.UIButton();
            this.buttonEdit = new Janus.Windows.EditControls.UIButton();
            this.dateTimePickerRegisterDate = new BehComponents.DateTimePickerX();
            this.dateTimePickerEyeLeft = new BehComponents.DateTimePickerX();
            this.dateTimePickerEyeRight = new BehComponents.DateTimePickerX();
            this.labelAge = new System.Windows.Forms.Label();
            this.textBoxAge = new Janus.Windows.GridEX.EditControls.EditBox();
            this.lableIdentifyNum = new System.Windows.Forms.Label();
            this.textBoxReason = new Janus.Windows.GridEX.EditControls.EditBox();
            this.textBoxAddress = new Janus.Windows.GridEX.EditControls.EditBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxDescription = new Janus.Windows.GridEX.EditControls.EditBox();
            this.gridCustomers = new Ophthalmology.Controls.CustomControls.CustomGridEx();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTypePatient)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomers)).BeginInit();
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.buttonBrowse, 4, 7);
            this.tableLayoutPanel1.Controls.Add(this.lableCode, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxCode, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxEyeRight, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.lableName, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxEyeLeft, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBoxName, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelFamily, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBoxFamily, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBoxTel, 6, 3);
            this.tableLayoutPanel1.Controls.Add(this.lableFatherName, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxFatherName, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.lablePhone, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.lableRegDate, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxType, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.labelType, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePickerRegisterDate, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePickerEyeLeft, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePickerEyeRight, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.labelAge, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBoxAge, 6, 4);
            this.tableLayoutPanel1.Controls.Add(this.lableIdentifyNum, 5, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBoxReason, 6, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBoxAddress, 6, 6);
            this.tableLayoutPanel1.Controls.Add(this.labelAddress, 5, 6);
            this.tableLayoutPanel1.Controls.Add(this.labelDescription, 5, 7);
            this.tableLayoutPanel1.Controls.Add(this.textBoxDescription, 6, 7);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1017, 372);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonBrowse.Enabled = false;
            this.buttonBrowse.Location = new System.Drawing.Point(449, 266);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(35, 35);
            this.buttonBrowse.TabIndex = 24;
            this.buttonBrowse.Text = "...";
            this.buttonBrowse.VisualStyleManager = this.visualStyleManager;
            this.buttonBrowse.Click += new System.EventHandler(this.ButtonBrowse_Click);
            // 
            // lableCode
            // 
            this.lableCode.AutoSize = true;
            this.lableCode.Dock = System.Windows.Forms.DockStyle.Right;
            this.lableCode.Location = new System.Drawing.Point(987, 58);
            this.lableCode.Name = "lableCode";
            this.lableCode.Size = new System.Drawing.Size(27, 41);
            this.lableCode.TabIndex = 0;
            this.lableCode.Text = "کد";
            this.lableCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxCode
            // 
            this.textBoxCode.BackColor = System.Drawing.Color.AntiqueWhite;
            this.textBoxCode.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxCode.Location = new System.Drawing.Point(843, 61);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.ReadOnly = true;
            this.textBoxCode.Size = new System.Drawing.Size(138, 35);
            this.textBoxCode.TabIndex = 1;
            this.textBoxCode.TabStop = false;
            this.textBoxCode.VisualStyleManager = this.visualStyleManager;
            // 
            // checkBoxEyeRight
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.checkBoxEyeRight, 2);
            this.checkBoxEyeRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkBoxEyeRight.Enabled = false;
            this.checkBoxEyeRight.Location = new System.Drawing.Point(746, 225);
            this.checkBoxEyeRight.Name = "checkBoxEyeRight";
            this.checkBoxEyeRight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBoxEyeRight.Size = new System.Drawing.Size(136, 35);
            this.checkBoxEyeRight.TabIndex = 20;
            this.checkBoxEyeRight.Text = "تاریخ عمل چشم راست";
            this.checkBoxEyeRight.VisualStyleManager = this.visualStyleManager;
            this.checkBoxEyeRight.CheckedChanged += new System.EventHandler(this.CheckBoxEyeRight_CheckedChanged);
            // 
            // lableName
            // 
            this.lableName.AutoSize = true;
            this.lableName.Dock = System.Windows.Forms.DockStyle.Right;
            this.lableName.Location = new System.Drawing.Point(746, 58);
            this.lableName.Name = "lableName";
            this.lableName.Size = new System.Drawing.Size(26, 41);
            this.lableName.TabIndex = 2;
            this.lableName.Text = "نام";
            this.lableName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkBoxEyeLeft
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.checkBoxEyeLeft, 2);
            this.checkBoxEyeLeft.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkBoxEyeLeft.Enabled = false;
            this.checkBoxEyeLeft.Location = new System.Drawing.Point(746, 184);
            this.checkBoxEyeLeft.Name = "checkBoxEyeLeft";
            this.checkBoxEyeLeft.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBoxEyeLeft.Size = new System.Drawing.Size(126, 35);
            this.checkBoxEyeLeft.TabIndex = 18;
            this.checkBoxEyeLeft.Text = "تاریخ عمل چشم چپ";
            this.checkBoxEyeLeft.VisualStyleManager = this.visualStyleManager;
            this.checkBoxEyeLeft.CheckedChanged += new System.EventHandler(this.CheckBoxEyeLeft_CheckedChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCustomers, "Name", true));
            this.textBoxName.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxName.Enabled = false;
            this.textBoxName.Location = new System.Drawing.Point(490, 61);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(250, 35);
            this.textBoxName.TabIndex = 3;
            this.textBoxName.VisualStyleManager = this.visualStyleManager;
            // 
            // bindingSourceCustomers
            // 
            this.bindingSourceCustomers.DataSource = typeof(Ophthalmology.Entity.Entites.Customer);
            // 
            // labelFamily
            // 
            this.labelFamily.AutoSize = true;
            this.labelFamily.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelFamily.Location = new System.Drawing.Point(746, 99);
            this.labelFamily.Name = "labelFamily";
            this.labelFamily.Size = new System.Drawing.Size(78, 41);
            this.labelFamily.TabIndex = 4;
            this.labelFamily.Text = "نام خانوادگی";
            this.labelFamily.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxFamily
            // 
            this.textBoxFamily.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCustomers, "Family", true));
            this.textBoxFamily.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxFamily.Enabled = false;
            this.textBoxFamily.Location = new System.Drawing.Point(490, 102);
            this.textBoxFamily.Name = "textBoxFamily";
            this.textBoxFamily.Size = new System.Drawing.Size(250, 35);
            this.textBoxFamily.TabIndex = 5;
            this.textBoxFamily.VisualStyleManager = this.visualStyleManager;
            this.textBoxFamily.TextChanged += new System.EventHandler(this.textBoxFamily_TextChanged);
            // 
            // textBoxTel
            // 
            this.textBoxTel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCustomers, "Tel", true));
            this.textBoxTel.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxTel.Enabled = false;
            this.textBoxTel.Location = new System.Drawing.Point(110, 102);
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.Size = new System.Drawing.Size(250, 35);
            this.textBoxTel.TabIndex = 9;
            this.textBoxTel.VisualStyleManager = this.visualStyleManager;
            // 
            // lableFatherName
            // 
            this.lableFatherName.AutoSize = true;
            this.lableFatherName.Dock = System.Windows.Forms.DockStyle.Right;
            this.lableFatherName.Location = new System.Drawing.Point(366, 58);
            this.lableFatherName.Name = "lableFatherName";
            this.lableFatherName.Size = new System.Drawing.Size(47, 41);
            this.lableFatherName.TabIndex = 6;
            this.lableFatherName.Text = "نام پدر";
            this.lableFatherName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxFatherName
            // 
            this.textBoxFatherName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCustomers, "NameFather", true));
            this.textBoxFatherName.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxFatherName.Enabled = false;
            this.textBoxFatherName.Location = new System.Drawing.Point(110, 61);
            this.textBoxFatherName.Name = "textBoxFatherName";
            this.textBoxFatherName.Size = new System.Drawing.Size(250, 35);
            this.textBoxFatherName.TabIndex = 7;
            this.textBoxFatherName.VisualStyleManager = this.visualStyleManager;
            // 
            // lablePhone
            // 
            this.lablePhone.AutoSize = true;
            this.lablePhone.Dock = System.Windows.Forms.DockStyle.Right;
            this.lablePhone.Location = new System.Drawing.Point(366, 99);
            this.lablePhone.Name = "lablePhone";
            this.lablePhone.Size = new System.Drawing.Size(71, 41);
            this.lablePhone.TabIndex = 8;
            this.lablePhone.Text = "شماره تلفن";
            this.lablePhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lableRegDate
            // 
            this.lableRegDate.AutoSize = true;
            this.lableRegDate.Dock = System.Windows.Forms.DockStyle.Right;
            this.lableRegDate.Location = new System.Drawing.Point(746, 140);
            this.lableRegDate.Name = "lableRegDate";
            this.lableRegDate.Size = new System.Drawing.Size(64, 41);
            this.lableRegDate.TabIndex = 25;
            this.lableRegDate.Text = "تاریخ ثبت";
            this.lableRegDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxType
            // 
            this.comboBoxType.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
            this.comboBoxType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingSourceCustomers, "IdTypePatient", true));
            this.comboBoxType.DataSource = this.bindingSourceTypePatient;
            this.comboBoxType.DisplayMember = "Name";
            this.comboBoxType.Dock = System.Windows.Forms.DockStyle.Left;
            this.comboBoxType.Enabled = false;
            this.comboBoxType.Location = new System.Drawing.Point(490, 266);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(250, 35);
            this.comboBoxType.TabIndex = 23;
            this.comboBoxType.ValueMember = "Id";
            this.comboBoxType.VisualStyleManager = this.visualStyleManager;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelType.Location = new System.Drawing.Point(746, 263);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(91, 41);
            this.labelType.TabIndex = 22;
            this.labelType.Text = "نوع بیمار (بیمه)";
            this.labelType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.tableLayoutPanel2.Controls.Add(this.buttonVisit, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonVisitText, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonOldVisit, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonVisitList, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonAppointment, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1011, 42);
            this.tableLayoutPanel2.TabIndex = 35;
            // 
            // buttonVisit
            // 
            this.buttonVisit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonVisit.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.AfterText;
            this.buttonVisit.Location = new System.Drawing.Point(206, 3);
            this.buttonVisit.Name = "buttonVisit";
            this.buttonVisit.Size = new System.Drawing.Size(196, 36);
            this.buttonVisit.TabIndex = 3;
            this.buttonVisit.Text = "نسخه قلم(F6)";
            this.buttonVisit.VisualStyleManager = this.visualStyleManager;
            // 
            // buttonVisitText
            // 
            this.buttonVisitText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonVisitText.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.AfterText;
            this.buttonVisitText.Location = new System.Drawing.Point(3, 3);
            this.buttonVisitText.Name = "buttonVisitText";
            this.buttonVisitText.Size = new System.Drawing.Size(197, 36);
            this.buttonVisitText.TabIndex = 4;
            this.buttonVisitText.Text = "نسخه متنی(F7)";
            this.buttonVisitText.VisualStyleManager = this.visualStyleManager;
            // 
            // buttonOldVisit
            // 
            this.buttonOldVisit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonOldVisit.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.AfterText;
            this.buttonOldVisit.Location = new System.Drawing.Point(408, 3);
            this.buttonOldVisit.Name = "buttonOldVisit";
            this.buttonOldVisit.Size = new System.Drawing.Size(196, 36);
            this.buttonOldVisit.TabIndex = 2;
            this.buttonOldVisit.Text = "نسخه های قبلی";
            this.buttonOldVisit.VisualStyleManager = this.visualStyleManager;
            // 
            // buttonVisitList
            // 
            this.buttonVisitList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonVisitList.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.AfterText;
            this.buttonVisitList.Location = new System.Drawing.Point(812, 3);
            this.buttonVisitList.Name = "buttonVisitList";
            this.buttonVisitList.Size = new System.Drawing.Size(196, 36);
            this.buttonVisitList.TabIndex = 0;
            this.buttonVisitList.Text = "لیست ویزیت";
            this.buttonVisitList.VisualStyleManager = this.visualStyleManager;
            // 
            // buttonAppointment
            // 
            this.buttonAppointment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAppointment.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.AfterText;
            this.buttonAppointment.Location = new System.Drawing.Point(610, 3);
            this.buttonAppointment.Name = "buttonAppointment";
            this.buttonAppointment.Size = new System.Drawing.Size(196, 36);
            this.buttonAppointment.TabIndex = 1;
            this.buttonAppointment.Text = "نوبت دهی";
            this.buttonAppointment.VisualStyleManager = this.visualStyleManager;
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
            this.tableLayoutPanel3.Controls.Add(this.buttonAdd, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonCancel, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonDelete, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonSave, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonEdit, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 317);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1011, 42);
            this.tableLayoutPanel3.TabIndex = 34;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAdd.Location = new System.Drawing.Point(812, 3);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(196, 36);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "جدید";
            this.buttonAdd.VisualStyleManager = this.visualStyleManager;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCancel.Location = new System.Drawing.Point(3, 3);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(197, 36);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "انصراف";
            this.buttonCancel.VisualStyleManager = this.visualStyleManager;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDelete.Location = new System.Drawing.Point(206, 3);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(196, 36);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "حذف";
            this.buttonDelete.VisualStyleManager = this.visualStyleManager;
            this.buttonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(408, 3);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(196, 36);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "ذخیره";
            this.buttonSave.VisualStyleManager = this.visualStyleManager;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEdit.Location = new System.Drawing.Point(610, 3);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(196, 36);
            this.buttonEdit.TabIndex = 1;
            this.buttonEdit.Text = "ویرایش";
            this.buttonEdit.VisualStyleManager = this.visualStyleManager;
            this.buttonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // dateTimePickerRegisterDate
            // 
            this.dateTimePickerRegisterDate.AnchorSize = new System.Drawing.Size(250, 35);
            this.dateTimePickerRegisterDate.BackColor = System.Drawing.Color.White;
            this.dateTimePickerRegisterDate.CalendarBoldedDayForeColor = System.Drawing.Color.Blue;
            this.dateTimePickerRegisterDate.CalendarBorderColor = System.Drawing.Color.CadetBlue;
            this.dateTimePickerRegisterDate.CalendarDayRectTickness = 2F;
            this.dateTimePickerRegisterDate.CalendarDaysBackColor = System.Drawing.Color.LightGray;
            this.dateTimePickerRegisterDate.CalendarDaysFont = null;
            this.dateTimePickerRegisterDate.CalendarDaysForeColor = System.Drawing.Color.DodgerBlue;
            this.dateTimePickerRegisterDate.CalendarEnglishAnnuallyBoldedDates = new System.DateTime[0];
            this.dateTimePickerRegisterDate.CalendarEnglishBoldedDates = new System.DateTime[0];
            this.dateTimePickerRegisterDate.CalendarEnglishHolidayDates = new System.DateTime[0];
            this.dateTimePickerRegisterDate.CalendarEnglishMonthlyBoldedDates = new System.DateTime[0];
            this.dateTimePickerRegisterDate.CalendarHolidayForeColor = System.Drawing.Color.Red;
            this.dateTimePickerRegisterDate.CalendarHolidayWeekly = BehComponents.MonthCalendarX.DayOfWeekForHoliday.Friday;
            this.dateTimePickerRegisterDate.CalendarLineWeekColor = System.Drawing.Color.Black;
            this.dateTimePickerRegisterDate.CalendarPersianAnnuallyBoldedDates = new BehComponents.PersianDateTime[0];
            this.dateTimePickerRegisterDate.CalendarPersianBoldedDates = new BehComponents.PersianDateTime[0];
            this.dateTimePickerRegisterDate.CalendarPersianHolidayDates = new BehComponents.PersianDateTime[0];
            this.dateTimePickerRegisterDate.CalendarPersianMonthlyBoldedDates = new BehComponents.PersianDateTime[0];
            this.dateTimePickerRegisterDate.CalendarShowToday = true;
            this.dateTimePickerRegisterDate.CalendarShowTodayRect = true;
            this.dateTimePickerRegisterDate.CalendarShowToolTips = false;
            this.dateTimePickerRegisterDate.CalendarShowTrailing = true;
            this.dateTimePickerRegisterDate.CalendarStyle_DaysButton = BehComponents.ButtonX.ButtonStyles.Simple;
            this.dateTimePickerRegisterDate.CalendarStyle_GotoTodayButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.dateTimePickerRegisterDate.CalendarStyle_MonthButton = BehComponents.ButtonX.ButtonStyles.Blue;
            this.dateTimePickerRegisterDate.CalendarStyle_NextMonthButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.dateTimePickerRegisterDate.CalendarStyle_PreviousMonthButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.dateTimePickerRegisterDate.CalendarStyle_YearButton = BehComponents.ButtonX.ButtonStyles.Blue;
            this.dateTimePickerRegisterDate.CalendarTitleBackColor = System.Drawing.Color.Wheat;
            this.dateTimePickerRegisterDate.CalendarTitleFont = null;
            this.dateTimePickerRegisterDate.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dateTimePickerRegisterDate.CalendarTodayBackColor = System.Drawing.Color.Wheat;
            this.dateTimePickerRegisterDate.CalendarTodayFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.dateTimePickerRegisterDate.CalendarTodayForeColor = System.Drawing.Color.Black;
            this.dateTimePickerRegisterDate.CalendarTodayRectColor = System.Drawing.Color.Coral;
            this.dateTimePickerRegisterDate.CalendarTodayRectTickness = 2F;
            this.dateTimePickerRegisterDate.CalendarTrailingForeColor = System.Drawing.Color.DarkGray;
            this.dateTimePickerRegisterDate.CalendarType = BehComponents.CalendarTypes.Persian;
            this.dateTimePickerRegisterDate.CalendarWeekDaysBackColor = System.Drawing.Color.Wheat;
            this.dateTimePickerRegisterDate.CalendarWeekDaysFont = null;
            this.dateTimePickerRegisterDate.CalendarWeekDaysForeColor = System.Drawing.Color.OrangeRed;
            this.dateTimePickerRegisterDate.CalendarWeekStartsOn = BehComponents.MonthCalendarX.WeekDays.Saturday;
            this.dateTimePickerRegisterDate.ClearButtonAlignment = BehComponents.DropDownEmpty.Alignments.Left;
            this.dateTimePickerRegisterDate.ClearButtonBackColor = System.Drawing.Color.White;
            this.dateTimePickerRegisterDate.ClearButtonForeColor = System.Drawing.SystemColors.ControlText;
            this.dateTimePickerRegisterDate.ClearButtonImage = ((System.Drawing.Image)(resources.GetObject("dateTimePickerRegisterDate.ClearButtonImage")));
            this.dateTimePickerRegisterDate.ClearButtonImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dateTimePickerRegisterDate.ClearButtonImageFixedSize = new System.Drawing.Size(0, 0);
            this.dateTimePickerRegisterDate.ClearButtonImageSizeMode = BehComponents.DropDownEmpty.ImageSizeModes.Zoom;
            this.dateTimePickerRegisterDate.ClearButtonText = "";
            this.dateTimePickerRegisterDate.ClearButtonTextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dateTimePickerRegisterDate.ClearButtonToolTip = "";
            this.dateTimePickerRegisterDate.ClearButtonWidth = 17;
            this.dateTimePickerRegisterDate.ClearDateTimeWhenDownDeleteKey = true;
            this.dateTimePickerRegisterDate.CustomFormat = "yyyy/MM/dd";
            this.dateTimePickerRegisterDate.DataBindings.Add(new System.Windows.Forms.Binding("SelectedDateInStringPersian", this.bindingSourceCustomers, "DateSave", true));
            this.dateTimePickerRegisterDate.Dock = System.Windows.Forms.DockStyle.Left;
            this.dateTimePickerRegisterDate.DockSide = BehComponents.DropDownEmpty.Alignments.Left;
            this.dateTimePickerRegisterDate.DropDownClosedWhenClickOnDays = false;
            this.dateTimePickerRegisterDate.DropDownClosedWhenSelectedDateChanged = false;
            this.dateTimePickerRegisterDate.Enabled = false;
            this.dateTimePickerRegisterDate.Format = BehComponents.DateTimePickerX.FormatDate.Custom;
            this.dateTimePickerRegisterDate.Format4Binding = "yyyy/MM/dd";
            this.dateTimePickerRegisterDate.Location = new System.Drawing.Point(490, 143);
            this.dateTimePickerRegisterDate.Name = "dateTimePickerRegisterDate";
            this.dateTimePickerRegisterDate.RightToLeftLayout = true;
            this.dateTimePickerRegisterDate.ShowClearButton = false;
            this.dateTimePickerRegisterDate.Size = new System.Drawing.Size(250, 35);
            this.dateTimePickerRegisterDate.TabIndex = 26;
            this.dateTimePickerRegisterDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dateTimePickerRegisterDate.TextWhenClearButtonClicked = "";
            // 
            // dateTimePickerEyeLeft
            // 
            this.dateTimePickerEyeLeft.AnchorSize = new System.Drawing.Size(250, 35);
            this.dateTimePickerEyeLeft.BackColor = System.Drawing.Color.White;
            this.dateTimePickerEyeLeft.CalendarBoldedDayForeColor = System.Drawing.Color.Blue;
            this.dateTimePickerEyeLeft.CalendarBorderColor = System.Drawing.Color.CadetBlue;
            this.dateTimePickerEyeLeft.CalendarDayRectTickness = 2F;
            this.dateTimePickerEyeLeft.CalendarDaysBackColor = System.Drawing.Color.LightGray;
            this.dateTimePickerEyeLeft.CalendarDaysFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerEyeLeft.CalendarDaysForeColor = System.Drawing.Color.DodgerBlue;
            this.dateTimePickerEyeLeft.CalendarEnglishAnnuallyBoldedDates = new System.DateTime[0];
            this.dateTimePickerEyeLeft.CalendarEnglishBoldedDates = new System.DateTime[0];
            this.dateTimePickerEyeLeft.CalendarEnglishHolidayDates = new System.DateTime[0];
            this.dateTimePickerEyeLeft.CalendarEnglishMonthlyBoldedDates = new System.DateTime[0];
            this.dateTimePickerEyeLeft.CalendarHolidayForeColor = System.Drawing.Color.Red;
            this.dateTimePickerEyeLeft.CalendarHolidayWeekly = BehComponents.MonthCalendarX.DayOfWeekForHoliday.Friday;
            this.dateTimePickerEyeLeft.CalendarLineWeekColor = System.Drawing.Color.Black;
            this.dateTimePickerEyeLeft.CalendarPersianAnnuallyBoldedDates = new BehComponents.PersianDateTime[0];
            this.dateTimePickerEyeLeft.CalendarPersianBoldedDates = new BehComponents.PersianDateTime[0];
            this.dateTimePickerEyeLeft.CalendarPersianHolidayDates = new BehComponents.PersianDateTime[0];
            this.dateTimePickerEyeLeft.CalendarPersianMonthlyBoldedDates = new BehComponents.PersianDateTime[0];
            this.dateTimePickerEyeLeft.CalendarShowToday = true;
            this.dateTimePickerEyeLeft.CalendarShowTodayRect = true;
            this.dateTimePickerEyeLeft.CalendarShowToolTips = false;
            this.dateTimePickerEyeLeft.CalendarShowTrailing = true;
            this.dateTimePickerEyeLeft.CalendarStyle_DaysButton = BehComponents.ButtonX.ButtonStyles.Simple;
            this.dateTimePickerEyeLeft.CalendarStyle_GotoTodayButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.dateTimePickerEyeLeft.CalendarStyle_MonthButton = BehComponents.ButtonX.ButtonStyles.Blue;
            this.dateTimePickerEyeLeft.CalendarStyle_NextMonthButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.dateTimePickerEyeLeft.CalendarStyle_PreviousMonthButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.dateTimePickerEyeLeft.CalendarStyle_YearButton = BehComponents.ButtonX.ButtonStyles.Blue;
            this.dateTimePickerEyeLeft.CalendarTitleBackColor = System.Drawing.Color.Wheat;
            this.dateTimePickerEyeLeft.CalendarTitleFont = new System.Drawing.Font("Tahoma", 8.25F);
            this.dateTimePickerEyeLeft.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dateTimePickerEyeLeft.CalendarTodayBackColor = System.Drawing.Color.Wheat;
            this.dateTimePickerEyeLeft.CalendarTodayFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.dateTimePickerEyeLeft.CalendarTodayForeColor = System.Drawing.Color.Black;
            this.dateTimePickerEyeLeft.CalendarTodayRectColor = System.Drawing.Color.Coral;
            this.dateTimePickerEyeLeft.CalendarTodayRectTickness = 2F;
            this.dateTimePickerEyeLeft.CalendarTrailingForeColor = System.Drawing.Color.DarkGray;
            this.dateTimePickerEyeLeft.CalendarType = BehComponents.CalendarTypes.Persian;
            this.dateTimePickerEyeLeft.CalendarWeekDaysBackColor = System.Drawing.Color.Wheat;
            this.dateTimePickerEyeLeft.CalendarWeekDaysFont = new System.Drawing.Font("Tahoma", 8.25F);
            this.dateTimePickerEyeLeft.CalendarWeekDaysForeColor = System.Drawing.Color.OrangeRed;
            this.dateTimePickerEyeLeft.CalendarWeekStartsOn = BehComponents.MonthCalendarX.WeekDays.Saturday;
            this.dateTimePickerEyeLeft.ClearButtonAlignment = BehComponents.DropDownEmpty.Alignments.Left;
            this.dateTimePickerEyeLeft.ClearButtonBackColor = System.Drawing.Color.White;
            this.dateTimePickerEyeLeft.ClearButtonForeColor = System.Drawing.SystemColors.ControlText;
            this.dateTimePickerEyeLeft.ClearButtonImage = ((System.Drawing.Image)(resources.GetObject("dateTimePickerEyeLeft.ClearButtonImage")));
            this.dateTimePickerEyeLeft.ClearButtonImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dateTimePickerEyeLeft.ClearButtonImageFixedSize = new System.Drawing.Size(0, 0);
            this.dateTimePickerEyeLeft.ClearButtonImageSizeMode = BehComponents.DropDownEmpty.ImageSizeModes.Zoom;
            this.dateTimePickerEyeLeft.ClearButtonText = "";
            this.dateTimePickerEyeLeft.ClearButtonTextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dateTimePickerEyeLeft.ClearButtonToolTip = "";
            this.dateTimePickerEyeLeft.ClearButtonWidth = 17;
            this.dateTimePickerEyeLeft.ClearDateTimeWhenDownDeleteKey = true;
            this.dateTimePickerEyeLeft.CustomFormat = "yyyy/MM/dd";
            this.dateTimePickerEyeLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.dateTimePickerEyeLeft.DockSide = BehComponents.DropDownEmpty.Alignments.Left;
            this.dateTimePickerEyeLeft.DropDownClosedWhenClickOnDays = false;
            this.dateTimePickerEyeLeft.DropDownClosedWhenSelectedDateChanged = false;
            this.dateTimePickerEyeLeft.Enabled = false;
            this.dateTimePickerEyeLeft.Format = BehComponents.DateTimePickerX.FormatDate.Custom;
            this.dateTimePickerEyeLeft.Format4Binding = "yyyy/MM/dd";
            this.dateTimePickerEyeLeft.Location = new System.Drawing.Point(490, 184);
            this.dateTimePickerEyeLeft.Name = "dateTimePickerEyeLeft";
            this.dateTimePickerEyeLeft.RightToLeftLayout = true;
            this.dateTimePickerEyeLeft.ShowClearButton = false;
            this.dateTimePickerEyeLeft.Size = new System.Drawing.Size(250, 35);
            this.dateTimePickerEyeLeft.TabIndex = 19;
            this.dateTimePickerEyeLeft.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dateTimePickerEyeLeft.TextWhenClearButtonClicked = "";
            // 
            // dateTimePickerEyeRight
            // 
            this.dateTimePickerEyeRight.AnchorSize = new System.Drawing.Size(250, 35);
            this.dateTimePickerEyeRight.BackColor = System.Drawing.Color.White;
            this.dateTimePickerEyeRight.CalendarBoldedDayForeColor = System.Drawing.Color.Blue;
            this.dateTimePickerEyeRight.CalendarBorderColor = System.Drawing.Color.CadetBlue;
            this.dateTimePickerEyeRight.CalendarDayRectTickness = 2F;
            this.dateTimePickerEyeRight.CalendarDaysBackColor = System.Drawing.Color.LightGray;
            this.dateTimePickerEyeRight.CalendarDaysFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerEyeRight.CalendarDaysForeColor = System.Drawing.Color.DodgerBlue;
            this.dateTimePickerEyeRight.CalendarEnglishAnnuallyBoldedDates = new System.DateTime[0];
            this.dateTimePickerEyeRight.CalendarEnglishBoldedDates = new System.DateTime[0];
            this.dateTimePickerEyeRight.CalendarEnglishHolidayDates = new System.DateTime[0];
            this.dateTimePickerEyeRight.CalendarEnglishMonthlyBoldedDates = new System.DateTime[0];
            this.dateTimePickerEyeRight.CalendarHolidayForeColor = System.Drawing.Color.Red;
            this.dateTimePickerEyeRight.CalendarHolidayWeekly = BehComponents.MonthCalendarX.DayOfWeekForHoliday.Friday;
            this.dateTimePickerEyeRight.CalendarLineWeekColor = System.Drawing.Color.Black;
            this.dateTimePickerEyeRight.CalendarPersianAnnuallyBoldedDates = new BehComponents.PersianDateTime[0];
            this.dateTimePickerEyeRight.CalendarPersianBoldedDates = new BehComponents.PersianDateTime[0];
            this.dateTimePickerEyeRight.CalendarPersianHolidayDates = new BehComponents.PersianDateTime[0];
            this.dateTimePickerEyeRight.CalendarPersianMonthlyBoldedDates = new BehComponents.PersianDateTime[0];
            this.dateTimePickerEyeRight.CalendarShowToday = true;
            this.dateTimePickerEyeRight.CalendarShowTodayRect = true;
            this.dateTimePickerEyeRight.CalendarShowToolTips = false;
            this.dateTimePickerEyeRight.CalendarShowTrailing = true;
            this.dateTimePickerEyeRight.CalendarStyle_DaysButton = BehComponents.ButtonX.ButtonStyles.Simple;
            this.dateTimePickerEyeRight.CalendarStyle_GotoTodayButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.dateTimePickerEyeRight.CalendarStyle_MonthButton = BehComponents.ButtonX.ButtonStyles.Blue;
            this.dateTimePickerEyeRight.CalendarStyle_NextMonthButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.dateTimePickerEyeRight.CalendarStyle_PreviousMonthButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.dateTimePickerEyeRight.CalendarStyle_YearButton = BehComponents.ButtonX.ButtonStyles.Blue;
            this.dateTimePickerEyeRight.CalendarTitleBackColor = System.Drawing.Color.Wheat;
            this.dateTimePickerEyeRight.CalendarTitleFont = new System.Drawing.Font("Tahoma", 8.25F);
            this.dateTimePickerEyeRight.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dateTimePickerEyeRight.CalendarTodayBackColor = System.Drawing.Color.Wheat;
            this.dateTimePickerEyeRight.CalendarTodayFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.dateTimePickerEyeRight.CalendarTodayForeColor = System.Drawing.Color.Black;
            this.dateTimePickerEyeRight.CalendarTodayRectColor = System.Drawing.Color.Coral;
            this.dateTimePickerEyeRight.CalendarTodayRectTickness = 2F;
            this.dateTimePickerEyeRight.CalendarTrailingForeColor = System.Drawing.Color.DarkGray;
            this.dateTimePickerEyeRight.CalendarType = BehComponents.CalendarTypes.Persian;
            this.dateTimePickerEyeRight.CalendarWeekDaysBackColor = System.Drawing.Color.Wheat;
            this.dateTimePickerEyeRight.CalendarWeekDaysFont = new System.Drawing.Font("Tahoma", 8.25F);
            this.dateTimePickerEyeRight.CalendarWeekDaysForeColor = System.Drawing.Color.OrangeRed;
            this.dateTimePickerEyeRight.CalendarWeekStartsOn = BehComponents.MonthCalendarX.WeekDays.Saturday;
            this.dateTimePickerEyeRight.ClearButtonAlignment = BehComponents.DropDownEmpty.Alignments.Left;
            this.dateTimePickerEyeRight.ClearButtonBackColor = System.Drawing.Color.White;
            this.dateTimePickerEyeRight.ClearButtonForeColor = System.Drawing.SystemColors.ControlText;
            this.dateTimePickerEyeRight.ClearButtonImage = ((System.Drawing.Image)(resources.GetObject("dateTimePickerEyeRight.ClearButtonImage")));
            this.dateTimePickerEyeRight.ClearButtonImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dateTimePickerEyeRight.ClearButtonImageFixedSize = new System.Drawing.Size(0, 0);
            this.dateTimePickerEyeRight.ClearButtonImageSizeMode = BehComponents.DropDownEmpty.ImageSizeModes.Zoom;
            this.dateTimePickerEyeRight.ClearButtonText = "";
            this.dateTimePickerEyeRight.ClearButtonTextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dateTimePickerEyeRight.ClearButtonToolTip = "";
            this.dateTimePickerEyeRight.ClearButtonWidth = 17;
            this.dateTimePickerEyeRight.ClearDateTimeWhenDownDeleteKey = true;
            this.dateTimePickerEyeRight.CustomFormat = "yyyy/MM/dd";
            this.dateTimePickerEyeRight.Dock = System.Windows.Forms.DockStyle.Left;
            this.dateTimePickerEyeRight.DockSide = BehComponents.DropDownEmpty.Alignments.Left;
            this.dateTimePickerEyeRight.DropDownClosedWhenClickOnDays = false;
            this.dateTimePickerEyeRight.DropDownClosedWhenSelectedDateChanged = false;
            this.dateTimePickerEyeRight.Enabled = false;
            this.dateTimePickerEyeRight.Format = BehComponents.DateTimePickerX.FormatDate.Custom;
            this.dateTimePickerEyeRight.Format4Binding = "yyyy/MM/dd";
            this.dateTimePickerEyeRight.Location = new System.Drawing.Point(490, 225);
            this.dateTimePickerEyeRight.Name = "dateTimePickerEyeRight";
            this.dateTimePickerEyeRight.RightToLeftLayout = true;
            this.dateTimePickerEyeRight.ShowClearButton = false;
            this.dateTimePickerEyeRight.Size = new System.Drawing.Size(250, 35);
            this.dateTimePickerEyeRight.TabIndex = 21;
            this.dateTimePickerEyeRight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dateTimePickerEyeRight.TextWhenClearButtonClicked = "";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelAge.Location = new System.Drawing.Point(366, 140);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(59, 41);
            this.labelAge.TabIndex = 10;
            this.labelAge.Text = "سال تولد";
            this.labelAge.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxAge
            // 
            this.textBoxAge.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCustomers, "Age", true));
            this.textBoxAge.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxAge.Enabled = false;
            this.textBoxAge.Location = new System.Drawing.Point(110, 143);
            this.textBoxAge.MaxLength = 30;
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(250, 35);
            this.textBoxAge.TabIndex = 11;
            this.textBoxAge.VisualStyleManager = this.visualStyleManager;
            // 
            // lableIdentifyNum
            // 
            this.lableIdentifyNum.AutoSize = true;
            this.lableIdentifyNum.Dock = System.Windows.Forms.DockStyle.Right;
            this.lableIdentifyNum.Location = new System.Drawing.Point(366, 181);
            this.lableIdentifyNum.Name = "lableIdentifyNum";
            this.lableIdentifyNum.Size = new System.Drawing.Size(77, 41);
            this.lableIdentifyNum.TabIndex = 12;
            this.lableIdentifyNum.Text = "علت مراجعه";
            this.lableIdentifyNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxReason
            // 
            this.textBoxReason.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCustomers, "Reason", true));
            this.textBoxReason.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxReason.Enabled = false;
            this.textBoxReason.Location = new System.Drawing.Point(110, 184);
            this.textBoxReason.Name = "textBoxReason";
            this.textBoxReason.Size = new System.Drawing.Size(250, 35);
            this.textBoxReason.TabIndex = 13;
            this.textBoxReason.VisualStyleManager = this.visualStyleManager;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCustomers, "Address", true));
            this.textBoxAddress.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxAddress.Enabled = false;
            this.textBoxAddress.Location = new System.Drawing.Point(110, 225);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(250, 35);
            this.textBoxAddress.TabIndex = 15;
            this.textBoxAddress.VisualStyleManager = this.visualStyleManager;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelAddress.Location = new System.Drawing.Point(366, 222);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(47, 41);
            this.labelAddress.TabIndex = 14;
            this.labelAddress.Text = "آدرس";
            this.labelAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelDescription.Location = new System.Drawing.Point(366, 263);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(63, 41);
            this.labelDescription.TabIndex = 16;
            this.labelDescription.Text = "توضیحات";
            this.labelDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCustomers, "Dis", true));
            this.textBoxDescription.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxDescription.Enabled = false;
            this.textBoxDescription.Location = new System.Drawing.Point(110, 266);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(250, 35);
            this.textBoxDescription.TabIndex = 17;
            this.textBoxDescription.VisualStyleManager = this.visualStyleManager;
            // 
            // gridCustomers
            // 
            this.gridCustomers.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.gridCustomers.AlternatingColors = true;
            this.gridCustomers.BuiltInTextsData = resources.GetString("gridCustomers.BuiltInTextsData");
            this.gridCustomers.ColumnAutoResize = true;
            this.gridCustomers.DataSource = this.bindingSourceCustomers;
            gridCustomers_DesignTimeLayout.LayoutString = resources.GetString("gridCustomers_DesignTimeLayout.LayoutString");
            this.gridCustomers.DesignTimeLayout = gridCustomers_DesignTimeLayout;
            this.gridCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCustomers.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.gridCustomers.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.gridCustomers.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.gridCustomers.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            this.gridCustomers.Location = new System.Drawing.Point(10, 382);
            this.gridCustomers.Name = "gridCustomers";
            this.gridCustomers.Size = new System.Drawing.Size(1017, 341);
            this.gridCustomers.TabIndex = 1;
            this.gridCustomers.TabKeyBehavior = Janus.Windows.GridEX.TabKeyBehavior.ControlNavigation;
            this.gridCustomers.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate;
            this.gridCustomers.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.gridCustomers.VisualStyleManager = this.visualStyleManager;
            // 
            // CustomersForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1037, 733);
            this.Controls.Add(this.gridCustomers);
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
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Controls.CustomControls.CustomGridEx gridCustomers;
        private System.Windows.Forms.BindingSource bindingSourceCustomers;
        private Janus.Windows.EditControls.UIButton buttonOldVisit;
        private System.Windows.Forms.Label lableCode;
        private Janus.Windows.GridEX.EditControls.EditBox textBoxCode;
        private System.Windows.Forms.Label lableName;
        private Janus.Windows.GridEX.EditControls.EditBox textBoxName;
        private System.Windows.Forms.Label labelFamily;
        private Janus.Windows.GridEX.EditControls.EditBox textBoxFamily;
        private System.Windows.Forms.Label lableFatherName;
        private Janus.Windows.GridEX.EditControls.EditBox textBoxFatherName;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label lablePhone;
        private System.Windows.Forms.Label lableIdentifyNum;
        private System.Windows.Forms.Label labelAge;
        private Janus.Windows.EditControls.UIButton buttonBrowse;
        private Janus.Windows.EditControls.UIComboBox comboBoxType;
        private Janus.Windows.EditControls.UICheckBox checkBoxEyeRight;
        private Janus.Windows.EditControls.UICheckBox checkBoxEyeLeft;
        private Janus.Windows.GridEX.EditControls.EditBox textBoxAddress;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelAddress;
        private Janus.Windows.GridEX.EditControls.EditBox textBoxDescription;
        private Janus.Windows.EditControls.UIButton buttonCancel;
        private Janus.Windows.EditControls.UIButton buttonDelete;
        private Janus.Windows.EditControls.UIButton buttonVisitText;
        private Janus.Windows.EditControls.UIButton buttonVisit;
        private Janus.Windows.EditControls.UIButton buttonSave;
        private Janus.Windows.EditControls.UIButton buttonAdd;
        private System.Windows.Forms.Label lableRegDate;
        private Janus.Windows.GridEX.EditControls.EditBox textBoxAge;
        private Janus.Windows.GridEX.EditControls.EditBox textBoxReason;
        private Janus.Windows.GridEX.EditControls.EditBox textBoxTel;
        private System.Windows.Forms.BindingSource bindingSourceTypePatient;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Janus.Windows.EditControls.UIButton buttonVisitList;
        private Janus.Windows.EditControls.UIButton buttonAppointment;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private BehComponents.DateTimePickerX dateTimePickerRegisterDate;
        private BehComponents.DateTimePickerX dateTimePickerEyeLeft;
        private BehComponents.DateTimePickerX dateTimePickerEyeRight;
        private Janus.Windows.EditControls.UIButton buttonEdit;
    }
}