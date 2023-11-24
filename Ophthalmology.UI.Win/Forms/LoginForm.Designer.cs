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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxUserName = new Janus.Windows.GridEX.EditControls.EditBox();
            this.TextboxPassword = new Janus.Windows.GridEX.EditControls.EditBox();
            this.uiButton1 = new Janus.Windows.EditControls.UIButton();
            this.uiButton2 = new Janus.Windows.EditControls.UIButton();
            this.uiGroupBox1 = new Janus.Windows.EditControls.UIGroupBox();
            this.uiRadioButton3 = new Janus.Windows.EditControls.UIRadioButton();
            this.uiRadioButton2 = new Janus.Windows.EditControls.UIRadioButton();
            this.uiRadioButton1 = new Janus.Windows.EditControls.UIRadioButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).BeginInit();
            this.uiGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.TextBoxUserName, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.TextboxPassword, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.uiButton1, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.uiButton2, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.uiGroupBox1, 2, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(452, 269);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(255, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام کاربری";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(255, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 41);
            this.label2.TabIndex = 2;
            this.label2.Text = "رمز عبور";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TextBoxUserName
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.TextBoxUserName, 2);
            this.TextBoxUserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxUserName.Location = new System.Drawing.Point(23, 23);
            this.TextBoxUserName.Name = "TextBoxUserName";
            this.TextBoxUserName.Size = new System.Drawing.Size(226, 35);
            this.TextBoxUserName.TabIndex = 1;
            this.TextBoxUserName.VisualStyleManager = this.visualStyleManager;
            // 
            // TextboxPassword
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.TextboxPassword, 2);
            this.TextboxPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextboxPassword.Location = new System.Drawing.Point(23, 64);
            this.TextboxPassword.Name = "TextboxPassword";
            this.TextboxPassword.Size = new System.Drawing.Size(226, 35);
            this.TextboxPassword.TabIndex = 3;
            this.TextboxPassword.VisualStyleManager = this.visualStyleManager;
            // 
            // uiButton1
            // 
            this.uiButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.uiButton1.Location = new System.Drawing.Point(149, 225);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(100, 41);
            this.uiButton1.TabIndex = 5;
            this.uiButton1.Text = "ورود";
            this.uiButton1.VisualStyleManager = this.visualStyleManager;
            // 
            // uiButton2
            // 
            this.uiButton2.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiButton2.Location = new System.Drawing.Point(43, 225);
            this.uiButton2.Name = "uiButton2";
            this.uiButton2.Size = new System.Drawing.Size(100, 41);
            this.uiButton2.TabIndex = 6;
            this.uiButton2.Text = "انصراف";
            this.uiButton2.VisualStyleManager = this.visualStyleManager;
            // 
            // uiGroupBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.uiGroupBox1, 2);
            this.uiGroupBox1.Controls.Add(this.uiRadioButton3);
            this.uiGroupBox1.Controls.Add(this.uiRadioButton2);
            this.uiGroupBox1.Controls.Add(this.uiRadioButton1);
            this.uiGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiGroupBox1.Location = new System.Drawing.Point(23, 105);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.tableLayoutPanel1.SetRowSpan(this.uiGroupBox1, 2);
            this.uiGroupBox1.Size = new System.Drawing.Size(226, 114);
            this.uiGroupBox1.TabIndex = 4;
            this.uiGroupBox1.Text = "نوع کاربری";
            this.uiGroupBox1.VisualStyleManager = this.visualStyleManager;
            // 
            // uiRadioButton3
            // 
            this.uiRadioButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uiRadioButton3.Location = new System.Drawing.Point(33, 80);
            this.uiRadioButton3.Name = "uiRadioButton3";
            this.uiRadioButton3.Size = new System.Drawing.Size(171, 32);
            this.uiRadioButton3.TabIndex = 2;
            this.uiRadioButton3.Text = "  منشی";
            this.uiRadioButton3.VisualStyleManager = this.visualStyleManager;
            // 
            // uiRadioButton2
            // 
            this.uiRadioButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uiRadioButton2.Location = new System.Drawing.Point(33, 53);
            this.uiRadioButton2.Name = "uiRadioButton2";
            this.uiRadioButton2.Size = new System.Drawing.Size(171, 32);
            this.uiRadioButton2.TabIndex = 1;
            this.uiRadioButton2.Text = "  اپتومتریست";
            this.uiRadioButton2.VisualStyleManager = this.visualStyleManager;
            // 
            // uiRadioButton1
            // 
            this.uiRadioButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uiRadioButton1.Location = new System.Drawing.Point(33, 24);
            this.uiRadioButton1.Name = "uiRadioButton1";
            this.uiRadioButton1.Size = new System.Drawing.Size(171, 32);
            this.uiRadioButton1.TabIndex = 0;
            this.uiRadioButton1.Text = "  پزشک";
            this.uiRadioButton1.VisualStyleManager = this.visualStyleManager;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(472, 289);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "ورود به سیستم";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).EndInit();
            this.uiGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Janus.Windows.EditControls.UIButton uiButton1;
        private Janus.Windows.EditControls.UIButton uiButton2;
        private Janus.Windows.GridEX.EditControls.EditBox TextBoxUserName;
        private Janus.Windows.GridEX.EditControls.EditBox TextboxPassword;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox1;
        private Janus.Windows.EditControls.UIRadioButton uiRadioButton3;
        private Janus.Windows.EditControls.UIRadioButton uiRadioButton2;
        private Janus.Windows.EditControls.UIRadioButton uiRadioButton1;
    }
}