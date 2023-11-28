﻿namespace Ophthalmology.UI.Win.Forms
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonExit = new Janus.Windows.EditControls.UIButton();
            this.ButtonCustomers = new Janus.Windows.EditControls.UIButton();
            this.ButtonVisilList = new Janus.Windows.EditControls.UIButton();
            this.ButtonReports = new Janus.Windows.EditControls.UIButton();
            this.ButtonUsers = new Janus.Windows.EditControls.UIButton();
            this.ButtonBackup = new Janus.Windows.EditControls.UIButton();
            this.ButtonRestore = new Janus.Windows.EditControls.UIButton();
            this.ButtonChat = new Janus.Windows.EditControls.UIButton();
            this.uiGroupBox1 = new Janus.Windows.EditControls.UIGroupBox();
            this.TextBoxDoctor = new Janus.Windows.GridEX.EditControls.EditBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonSettings = new Janus.Windows.EditControls.UIButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.LabelCurrentUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.LabelCurrentUserValue = new System.Windows.Forms.ToolStripStatusLabel();
            this.LabelDoctor = new System.Windows.Forms.ToolStripStatusLabel();
            this.LabelDoctorName = new System.Windows.Forms.ToolStripStatusLabel();
            this.LabelDateTime = new System.Windows.Forms.ToolStripStatusLabel();
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
            this.tableLayoutPanel1.Controls.Add(this.ButtonExit, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.ButtonCustomers, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ButtonVisilList, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ButtonReports, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ButtonUsers, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.ButtonBackup, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.ButtonRestore, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.ButtonChat, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.uiGroupBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ButtonSettings, 2, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(664, 409);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ButtonExit
            // 
            this.ButtonExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonExit.Location = new System.Drawing.Point(541, 246);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(120, 75);
            this.ButtonExit.TabIndex = 7;
            this.ButtonExit.Text = "خروج (Esc)";
            this.ButtonExit.VisualStyleManager = this.visualStyleManager;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // ButtonCustomers
            // 
            this.ButtonCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonCustomers.Location = new System.Drawing.Point(541, 3);
            this.ButtonCustomers.Name = "ButtonCustomers";
            this.ButtonCustomers.Size = new System.Drawing.Size(120, 75);
            this.ButtonCustomers.TabIndex = 0;
            this.ButtonCustomers.Text = "اشخاص";
            this.ButtonCustomers.VisualStyleManager = this.visualStyleManager;
            this.ButtonCustomers.Click += new System.EventHandler(this.ButtonCustomers_Click);
            // 
            // ButtonVisilList
            // 
            this.ButtonVisilList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonVisilList.Location = new System.Drawing.Point(541, 84);
            this.ButtonVisilList.Name = "ButtonVisilList";
            this.ButtonVisilList.Size = new System.Drawing.Size(120, 75);
            this.ButtonVisilList.TabIndex = 1;
            this.ButtonVisilList.Text = "رزرو ویزیت";
            this.ButtonVisilList.VisualStyleManager = this.visualStyleManager;
            // 
            // ButtonReports
            // 
            this.ButtonReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonReports.Location = new System.Drawing.Point(541, 165);
            this.ButtonReports.Name = "ButtonReports";
            this.ButtonReports.Size = new System.Drawing.Size(120, 75);
            this.ButtonReports.TabIndex = 2;
            this.ButtonReports.Text = "گزارشات";
            this.ButtonReports.VisualStyleManager = this.visualStyleManager;
            // 
            // ButtonUsers
            // 
            this.ButtonUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonUsers.Location = new System.Drawing.Point(3, 3);
            this.ButtonUsers.Name = "ButtonUsers";
            this.ButtonUsers.Size = new System.Drawing.Size(121, 75);
            this.ButtonUsers.TabIndex = 3;
            this.ButtonUsers.Text = "کاربران";
            this.ButtonUsers.VisualStyleManager = this.visualStyleManager;
            // 
            // ButtonBackup
            // 
            this.ButtonBackup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonBackup.Location = new System.Drawing.Point(3, 84);
            this.ButtonBackup.Name = "ButtonBackup";
            this.ButtonBackup.Size = new System.Drawing.Size(121, 75);
            this.ButtonBackup.TabIndex = 4;
            this.ButtonBackup.Text = "پشتیبان گیری";
            this.ButtonBackup.VisualStyleManager = this.visualStyleManager;
            // 
            // ButtonRestore
            // 
            this.ButtonRestore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonRestore.Location = new System.Drawing.Point(3, 165);
            this.ButtonRestore.Name = "ButtonRestore";
            this.ButtonRestore.Size = new System.Drawing.Size(121, 75);
            this.ButtonRestore.TabIndex = 5;
            this.ButtonRestore.Text = "بازگردانی پشتیبان";
            this.ButtonRestore.VisualStyleManager = this.visualStyleManager;
            // 
            // ButtonChat
            // 
            this.ButtonChat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonChat.Location = new System.Drawing.Point(3, 246);
            this.ButtonChat.Name = "ButtonChat";
            this.ButtonChat.Size = new System.Drawing.Size(121, 75);
            this.ButtonChat.TabIndex = 6;
            this.ButtonChat.Text = "چت";
            this.ButtonChat.VisualStyleManager = this.visualStyleManager;
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.TextBoxDoctor);
            this.uiGroupBox1.Controls.Add(this.label1);
            this.uiGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiGroupBox1.Location = new System.Drawing.Point(137, 10);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(10);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.tableLayoutPanel1.SetRowSpan(this.uiGroupBox1, 5);
            this.uiGroupBox1.Size = new System.Drawing.Size(391, 389);
            this.uiGroupBox1.TabIndex = 8;
            this.uiGroupBox1.VisualStyleManager = this.visualStyleManager;
            // 
            // TextBoxDoctor
            // 
            this.TextBoxDoctor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TextBoxDoctor.Location = new System.Drawing.Point(53, 25);
            this.TextBoxDoctor.Name = "TextBoxDoctor";
            this.TextBoxDoctor.ReadOnly = true;
            this.TextBoxDoctor.Size = new System.Drawing.Size(233, 35);
            this.TextBoxDoctor.TabIndex = 1;
            this.TextBoxDoctor.VisualStyleManager = this.visualStyleManager;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "پزشک";
            // 
            // ButtonSettings
            // 
            this.ButtonSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonSettings.Location = new System.Drawing.Point(3, 327);
            this.ButtonSettings.Name = "ButtonSettings";
            this.ButtonSettings.Size = new System.Drawing.Size(121, 79);
            this.ButtonSettings.TabIndex = 6;
            this.ButtonSettings.Text = "تنظیمات";
            this.ButtonSettings.VisualStyleManager = this.visualStyleManager;
            this.ButtonSettings.Click += new System.EventHandler(this.ButtonSettings_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LabelCurrentUser,
            this.LabelCurrentUserValue,
            this.LabelDoctor,
            this.LabelDoctorName,
            this.LabelDateTime});
            this.statusStrip1.Location = new System.Drawing.Point(10, 419);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(664, 32);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // LabelCurrentUser
            // 
            this.LabelCurrentUser.Name = "LabelCurrentUser";
            this.LabelCurrentUser.Size = new System.Drawing.Size(43, 27);
            this.LabelCurrentUser.Text = "کاربر :";
            // 
            // LabelCurrentUserValue
            // 
            this.LabelCurrentUserValue.Name = "LabelCurrentUserValue";
            this.LabelCurrentUserValue.Size = new System.Drawing.Size(41, 27);
            this.LabelCurrentUserValue.Text = "کاربر";
            // 
            // LabelDoctor
            // 
            this.LabelDoctor.Name = "LabelDoctor";
            this.LabelDoctor.Size = new System.Drawing.Size(51, 27);
            this.LabelDoctor.Text = "پزشک :";
            // 
            // LabelDoctorName
            // 
            this.LabelDoctorName.Name = "LabelDoctorName";
            this.LabelDoctorName.Size = new System.Drawing.Size(470, 27);
            this.LabelDoctorName.Spring = true;
            this.LabelDoctorName.Text = "پزشک";
            this.LabelDoctorName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelDateTime
            // 
            this.LabelDateTime.Name = "LabelDateTime";
            this.LabelDateTime.Size = new System.Drawing.Size(44, 27);
            this.LabelDateTime.Text = "date";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "مدیریت مطب";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm_KeyPress);
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
        private System.Windows.Forms.Label label1;
        private Janus.Windows.GridEX.EditControls.EditBox TextBoxDoctor;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel LabelCurrentUser;
        private System.Windows.Forms.ToolStripStatusLabel LabelCurrentUserValue;
        private System.Windows.Forms.ToolStripStatusLabel LabelDoctor;
        private System.Windows.Forms.ToolStripStatusLabel LabelDoctorName;
        private System.Windows.Forms.ToolStripStatusLabel LabelDateTime;
        private System.Windows.Forms.Timer timer1;
        private Janus.Windows.EditControls.UIButton ButtonSettings;
    }
}