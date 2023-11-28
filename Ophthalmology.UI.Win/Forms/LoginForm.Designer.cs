namespace Ophthalmology.UI.Win.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxUserName = new Janus.Windows.GridEX.EditControls.EditBox();
            this.TextboxPassword = new Janus.Windows.GridEX.EditControls.EditBox();
            this.ButtonLogin = new Janus.Windows.EditControls.UIButton();
            this.ButtonCancel = new Janus.Windows.EditControls.UIButton();
            this.uiGroupBox1 = new Janus.Windows.EditControls.UIGroupBox();
            this.RadioButtonSecretary = new Janus.Windows.EditControls.UIRadioButton();
            this.RadioButtonOptometrist = new Janus.Windows.EditControls.UIRadioButton();
            this.RadioButtonDocter = new Janus.Windows.EditControls.UIRadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.ComboBoxDoctors = new Janus.Windows.EditControls.UIComboBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).BeginInit();
            this.uiGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.TextBoxUserName, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.TextboxPassword, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.ButtonLogin, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.ButtonCancel, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.uiGroupBox1, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.ComboBoxDoctors, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(546, 307);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(329, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام کاربری";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(329, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 41);
            this.label2.TabIndex = 2;
            this.label2.Text = "رمز عبور";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TextBoxUserName
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.TextBoxUserName, 2);
            this.TextBoxUserName.Dock = System.Windows.Forms.DockStyle.Left;
            this.TextBoxUserName.Location = new System.Drawing.Point(73, 3);
            this.TextBoxUserName.Name = "TextBoxUserName";
            this.TextBoxUserName.Size = new System.Drawing.Size(250, 35);
            this.TextBoxUserName.TabIndex = 1;
            this.TextBoxUserName.VisualStyleManager = this.visualStyleManager;
            // 
            // TextboxPassword
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.TextboxPassword, 2);
            this.TextboxPassword.Dock = System.Windows.Forms.DockStyle.Left;
            this.TextboxPassword.Location = new System.Drawing.Point(73, 44);
            this.TextboxPassword.Name = "TextboxPassword";
            this.TextboxPassword.Size = new System.Drawing.Size(250, 35);
            this.TextboxPassword.TabIndex = 3;
            this.TextboxPassword.VisualStyleManager = this.visualStyleManager;
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.Dock = System.Windows.Forms.DockStyle.Right;
            this.ButtonLogin.Location = new System.Drawing.Point(198, 260);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(125, 44);
            this.ButtonLogin.TabIndex = 7;
            this.ButtonLogin.Text = "ورود";
            this.ButtonLogin.VisualStyleManager = this.visualStyleManager;
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonCancel.Location = new System.Drawing.Point(67, 260);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(125, 44);
            this.ButtonCancel.TabIndex = 8;
            this.ButtonCancel.Text = "انصراف";
            this.ButtonCancel.VisualStyleManager = this.visualStyleManager;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // uiGroupBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.uiGroupBox1, 2);
            this.uiGroupBox1.Controls.Add(this.RadioButtonSecretary);
            this.uiGroupBox1.Controls.Add(this.RadioButtonOptometrist);
            this.uiGroupBox1.Controls.Add(this.RadioButtonDocter);
            this.uiGroupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiGroupBox1.Location = new System.Drawing.Point(73, 126);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.tableLayoutPanel1.SetRowSpan(this.uiGroupBox1, 2);
            this.uiGroupBox1.Size = new System.Drawing.Size(250, 128);
            this.uiGroupBox1.TabIndex = 6;
            this.uiGroupBox1.Text = "نوع کاربری";
            this.uiGroupBox1.VisualStyleManager = this.visualStyleManager;
            // 
            // RadioButtonSecretary
            // 
            this.RadioButtonSecretary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RadioButtonSecretary.Location = new System.Drawing.Point(57, 80);
            this.RadioButtonSecretary.Name = "RadioButtonSecretary";
            this.RadioButtonSecretary.Size = new System.Drawing.Size(171, 32);
            this.RadioButtonSecretary.TabIndex = 2;
            this.RadioButtonSecretary.Text = "  منشی";
            this.RadioButtonSecretary.VisualStyleManager = this.visualStyleManager;
            // 
            // RadioButtonOptometrist
            // 
            this.RadioButtonOptometrist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RadioButtonOptometrist.Location = new System.Drawing.Point(57, 53);
            this.RadioButtonOptometrist.Name = "RadioButtonOptometrist";
            this.RadioButtonOptometrist.Size = new System.Drawing.Size(171, 32);
            this.RadioButtonOptometrist.TabIndex = 1;
            this.RadioButtonOptometrist.Text = "  اپتومتریست";
            this.RadioButtonOptometrist.VisualStyleManager = this.visualStyleManager;
            // 
            // RadioButtonDocter
            // 
            this.RadioButtonDocter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RadioButtonDocter.Location = new System.Drawing.Point(57, 24);
            this.RadioButtonDocter.Name = "RadioButtonDocter";
            this.RadioButtonDocter.Size = new System.Drawing.Size(171, 32);
            this.RadioButtonDocter.TabIndex = 0;
            this.RadioButtonDocter.Text = "  پزشک";
            this.RadioButtonDocter.VisualStyleManager = this.visualStyleManager;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(329, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 41);
            this.label3.TabIndex = 4;
            this.label3.Text = "پزشک";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ComboBoxDoctors
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.ComboBoxDoctors, 2);
            this.ComboBoxDoctors.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
            this.ComboBoxDoctors.DataSource = this.bindingSource1;
            this.ComboBoxDoctors.DisplayMember = "Name";
            this.ComboBoxDoctors.Location = new System.Drawing.Point(73, 85);
            this.ComboBoxDoctors.Name = "ComboBoxDoctors";
            this.ComboBoxDoctors.Size = new System.Drawing.Size(250, 35);
            this.ComboBoxDoctors.TabIndex = 5;
            this.ComboBoxDoctors.ValueMember = "Id";
            this.ComboBoxDoctors.VisualStyleManager = this.visualStyleManager;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(Ophthalmology.Entity.Entites.Doctor);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(566, 327);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ورود به سیستم";
            this.Shown += new System.EventHandler(this.LoginForm_Shown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LoginForm_KeyPress);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).EndInit();
            this.uiGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Janus.Windows.EditControls.UIButton ButtonLogin;
        private Janus.Windows.EditControls.UIButton ButtonCancel;
        private Janus.Windows.GridEX.EditControls.EditBox TextBoxUserName;
        private Janus.Windows.GridEX.EditControls.EditBox TextboxPassword;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox1;
        private Janus.Windows.EditControls.UIRadioButton RadioButtonSecretary;
        private Janus.Windows.EditControls.UIRadioButton RadioButtonOptometrist;
        private Janus.Windows.EditControls.UIRadioButton RadioButtonDocter;
        private System.Windows.Forms.Label label3;
        private Janus.Windows.EditControls.UIComboBox ComboBoxDoctors;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}