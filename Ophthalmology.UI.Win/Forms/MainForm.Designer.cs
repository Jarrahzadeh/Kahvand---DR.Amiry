namespace Ophthalmology.UI.Win.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonCustomers = new Janus.Windows.EditControls.UIButton();
            this.ButtonVisilList = new Janus.Windows.EditControls.UIButton();
            this.ButtonReports = new Janus.Windows.EditControls.UIButton();
            this.ButtonUsers = new Janus.Windows.EditControls.UIButton();
            this.ButtonBackup = new Janus.Windows.EditControls.UIButton();
            this.ButtonRestore = new Janus.Windows.EditControls.UIButton();
            this.ButtonChat = new Janus.Windows.EditControls.UIButton();
            this.uiGroupBox1 = new Janus.Windows.EditControls.UIGroupBox();
            this.textBoxDoctor = new Janus.Windows.GridEX.EditControls.EditBox();
            this.ButtonSettings = new Janus.Windows.EditControls.UIButton();
            this.ButtonExit = new Janus.Windows.EditControls.UIButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelUserType = new System.Windows.Forms.ToolStripStatusLabel();
            this.LabelCurrentUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelCurrentUserValue = new System.Windows.Forms.ToolStripStatusLabel();
            this.LabelDoctor = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelDoctorName = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelDateTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).BeginInit();
            this.uiGroupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.00715F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.98569F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.00716F));
            this.tableLayoutPanel1.Controls.Add(this.ButtonCustomers, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ButtonVisilList, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ButtonReports, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ButtonUsers, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.ButtonBackup, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.ButtonRestore, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.ButtonChat, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.uiGroupBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ButtonSettings, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.ButtonExit, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(664, 417);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ButtonCustomers
            // 
            this.ButtonCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonCustomers.Location = new System.Drawing.Point(541, 3);
            this.ButtonCustomers.Name = "ButtonCustomers";
            this.ButtonCustomers.Size = new System.Drawing.Size(120, 77);
            this.ButtonCustomers.TabIndex = 0;
            this.ButtonCustomers.Text = "اشخاص";
            this.ButtonCustomers.VisualStyleManager = this.visualStyleManager;
            this.ButtonCustomers.Click += new System.EventHandler(this.ButtonCustomers_Click);
            // 
            // ButtonVisilList
            // 
            this.ButtonVisilList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonVisilList.Location = new System.Drawing.Point(541, 86);
            this.ButtonVisilList.Name = "ButtonVisilList";
            this.ButtonVisilList.Size = new System.Drawing.Size(120, 77);
            this.ButtonVisilList.TabIndex = 1;
            this.ButtonVisilList.Text = "رزرو ویزیت";
            this.ButtonVisilList.VisualStyleManager = this.visualStyleManager;
            // 
            // ButtonReports
            // 
            this.ButtonReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonReports.Location = new System.Drawing.Point(541, 169);
            this.ButtonReports.Name = "ButtonReports";
            this.ButtonReports.Size = new System.Drawing.Size(120, 77);
            this.ButtonReports.TabIndex = 2;
            this.ButtonReports.Text = "گزارشات";
            this.ButtonReports.VisualStyleManager = this.visualStyleManager;
            // 
            // ButtonUsers
            // 
            this.ButtonUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonUsers.Location = new System.Drawing.Point(3, 3);
            this.ButtonUsers.Name = "ButtonUsers";
            this.ButtonUsers.Size = new System.Drawing.Size(121, 77);
            this.ButtonUsers.TabIndex = 3;
            this.ButtonUsers.Text = "کاربران";
            this.ButtonUsers.VisualStyleManager = this.visualStyleManager;
            // 
            // ButtonBackup
            // 
            this.ButtonBackup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonBackup.Location = new System.Drawing.Point(3, 86);
            this.ButtonBackup.Name = "ButtonBackup";
            this.ButtonBackup.Size = new System.Drawing.Size(121, 77);
            this.ButtonBackup.TabIndex = 4;
            this.ButtonBackup.Text = "پشتیبان گیری";
            this.ButtonBackup.VisualStyleManager = this.visualStyleManager;
            // 
            // ButtonRestore
            // 
            this.ButtonRestore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonRestore.Location = new System.Drawing.Point(3, 169);
            this.ButtonRestore.Name = "ButtonRestore";
            this.ButtonRestore.Size = new System.Drawing.Size(121, 77);
            this.ButtonRestore.TabIndex = 5;
            this.ButtonRestore.Text = "بازگردانی پشتیبان";
            this.ButtonRestore.VisualStyleManager = this.visualStyleManager;
            // 
            // ButtonChat
            // 
            this.ButtonChat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonChat.Location = new System.Drawing.Point(3, 252);
            this.ButtonChat.Name = "ButtonChat";
            this.ButtonChat.Size = new System.Drawing.Size(121, 77);
            this.ButtonChat.TabIndex = 6;
            this.ButtonChat.Text = "چت";
            this.ButtonChat.VisualStyleManager = this.visualStyleManager;
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.uiGroupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiGroupBox1.BackgroundImage")));
            this.uiGroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.uiGroupBox1.Controls.Add(this.textBoxDoctor);
            this.uiGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiGroupBox1.Location = new System.Drawing.Point(137, 10);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(10);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.tableLayoutPanel1.SetRowSpan(this.uiGroupBox1, 5);
            this.uiGroupBox1.Size = new System.Drawing.Size(391, 397);
            this.uiGroupBox1.TabIndex = 8;
            this.uiGroupBox1.VisualStyleManager = this.visualStyleManager;
            // 
            // textBoxDoctor
            // 
            this.textBoxDoctor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDoctor.BorderStyle = Janus.Windows.GridEX.BorderStyle.None;
            this.textBoxDoctor.Location = new System.Drawing.Point(6, 13);
            this.textBoxDoctor.Name = "textBoxDoctor";
            this.textBoxDoctor.ReadOnly = true;
            this.textBoxDoctor.Size = new System.Drawing.Size(379, 33);
            this.textBoxDoctor.TabIndex = 1;
            this.textBoxDoctor.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.textBoxDoctor.VisualStyleManager = this.visualStyleManager;
            // 
            // ButtonSettings
            // 
            this.ButtonSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonSettings.Location = new System.Drawing.Point(3, 335);
            this.ButtonSettings.Name = "ButtonSettings";
            this.ButtonSettings.Size = new System.Drawing.Size(121, 79);
            this.ButtonSettings.TabIndex = 6;
            this.ButtonSettings.Text = "تنظیمات";
            this.ButtonSettings.VisualStyleManager = this.visualStyleManager;
            this.ButtonSettings.Click += new System.EventHandler(this.ButtonSettings_Click);
            // 
            // ButtonExit
            // 
            this.ButtonExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonExit.Location = new System.Drawing.Point(541, 335);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(120, 79);
            this.ButtonExit.TabIndex = 7;
            this.ButtonExit.Text = "خروج (Esc)";
            this.ButtonExit.VisualStyleManager = this.visualStyleManager;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.labelUserType,
            this.LabelCurrentUser,
            this.labelCurrentUserValue,
            this.LabelDoctor,
            this.labelDoctorName,
            this.labelDateTime});
            this.statusStrip1.Location = new System.Drawing.Point(10, 427);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(664, 24);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)(((System.Windows.Forms.ToolStripStatusLabelBorderSides.Top | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(68, 19);
            this.toolStripStatusLabel1.Text = "نوع کاربری :";
            // 
            // labelUserType
            // 
            this.labelUserType.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)(((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.labelUserType.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.labelUserType.Name = "labelUserType";
            this.labelUserType.Size = new System.Drawing.Size(62, 19);
            this.labelUserType.Text = "نوع کاربری";
            // 
            // LabelCurrentUser
            // 
            this.LabelCurrentUser.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)(((System.Windows.Forms.ToolStripStatusLabelBorderSides.Top | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.LabelCurrentUser.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.LabelCurrentUser.Name = "LabelCurrentUser";
            this.LabelCurrentUser.Size = new System.Drawing.Size(40, 19);
            this.LabelCurrentUser.Text = "کاربر :";
            // 
            // labelCurrentUserValue
            // 
            this.labelCurrentUserValue.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)(((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.labelCurrentUserValue.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.labelCurrentUserValue.Name = "labelCurrentUserValue";
            this.labelCurrentUserValue.Size = new System.Drawing.Size(34, 19);
            this.labelCurrentUserValue.Text = "کاربر";
            // 
            // LabelDoctor
            // 
            this.LabelDoctor.Name = "LabelDoctor";
            this.LabelDoctor.Size = new System.Drawing.Size(42, 19);
            this.LabelDoctor.Text = "پزشک :";
            // 
            // labelDoctorName
            // 
            this.labelDoctorName.Name = "labelDoctorName";
            this.labelDoctorName.Size = new System.Drawing.Size(36, 19);
            this.labelDoctorName.Text = "پزشک";
            this.labelDoctorName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDateTime
            // 
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(336, 19);
            this.labelDateTime.Spring = true;
            this.labelDateTime.Text = "date";
            this.labelDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "MainForm";
            this.ShowCloseQuestion = false;
            this.Text = "مدیریت مطب";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).EndInit();
            this.uiGroupBox1.ResumeLayout(false);
            this.uiGroupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Janus.Windows.EditControls.UIButton ButtonCustomers;
        private Janus.Windows.EditControls.UIButton ButtonExit;
        private Janus.Windows.EditControls.UIButton ButtonVisilList;
        private Janus.Windows.EditControls.UIButton ButtonReports;
        private Janus.Windows.EditControls.UIButton ButtonUsers;
        private Janus.Windows.EditControls.UIButton ButtonBackup;
        private Janus.Windows.EditControls.UIButton ButtonRestore;
        private Janus.Windows.EditControls.UIButton ButtonChat;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox1;
        private Janus.Windows.GridEX.EditControls.EditBox textBoxDoctor;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel LabelCurrentUser;
        private System.Windows.Forms.ToolStripStatusLabel labelCurrentUserValue;
        private System.Windows.Forms.ToolStripStatusLabel LabelDoctor;
        private System.Windows.Forms.ToolStripStatusLabel labelDoctorName;
        private System.Windows.Forms.ToolStripStatusLabel labelDateTime;
        private System.Windows.Forms.Timer timer1;
        private Janus.Windows.EditControls.UIButton ButtonSettings;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel labelUserType;
    }
}