namespace Ophthalmology.UI.Win.Forms
{
    partial class SettingsForm
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
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.uiGroupBox1 = new Janus.Windows.EditControls.UIGroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.integerUpDown1 = new Janus.Windows.GridEX.EditControls.IntegerUpDown();
            this.uiComboBox2 = new Janus.Windows.EditControls.UIComboBox();
            this.uiButton1 = new Janus.Windows.EditControls.UIButton();
            this.uiGroupBox2 = new Janus.Windows.EditControls.UIGroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.uiComboBox1 = new Janus.Windows.EditControls.UIComboBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.SaveButton = new Janus.Windows.EditControls.UIButton();
            this.CancelButton = new Janus.Windows.EditControls.UIButton();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).BeginInit();
            this.uiGroupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox2)).BeginInit();
            this.uiGroupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.tableLayoutPanel1);
            this.uiGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiGroupBox1.Location = new System.Drawing.Point(10, 10);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Size = new System.Drawing.Size(391, 174);
            this.uiGroupBox1.TabIndex = 0;
            this.uiGroupBox1.Text = "تنظیمات فونت";
            this.uiGroupBox1.VisualStyleManager = this.visualStyleManager;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.integerUpDown1, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.uiComboBox2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.uiButton1, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 31);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(385, 140);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(278, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "فونت";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(278, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 41);
            this.label2.TabIndex = 2;
            this.label2.Text = "اندازه";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // integerUpDown1
            // 
            this.integerUpDown1.Location = new System.Drawing.Point(172, 79);
            this.integerUpDown1.Name = "integerUpDown1";
            this.integerUpDown1.Size = new System.Drawing.Size(100, 35);
            this.integerUpDown1.TabIndex = 3;
            this.integerUpDown1.VisualStyleManager = this.visualStyleManager;
            // 
            // uiComboBox2
            // 
            this.uiComboBox2.Location = new System.Drawing.Point(23, 38);
            this.uiComboBox2.Name = "uiComboBox2";
            this.uiComboBox2.Size = new System.Drawing.Size(249, 35);
            this.uiComboBox2.TabIndex = 10;
            this.uiComboBox2.Text = "uiComboBox2";
            this.uiComboBox2.VisualStyleManager = this.visualStyleManager;
            // 
            // uiButton1
            // 
            this.uiButton1.Location = new System.Drawing.Point(172, 3);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(100, 29);
            this.uiButton1.TabIndex = 11;
            this.uiButton1.Text = "انتخاب فونت";
            this.uiButton1.VisualStyleManager = this.visualStyleManager;
            this.uiButton1.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // uiGroupBox2
            // 
            this.uiGroupBox2.Controls.Add(this.tableLayoutPanel2);
            this.uiGroupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiGroupBox2.Location = new System.Drawing.Point(10, 184);
            this.uiGroupBox2.Name = "uiGroupBox2";
            this.uiGroupBox2.Size = new System.Drawing.Size(391, 97);
            this.uiGroupBox2.TabIndex = 4;
            this.uiGroupBox2.Text = "رنگ بندی";
            this.uiGroupBox2.VisualStyleManager = this.visualStyleManager;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.uiComboBox1, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 31);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(385, 63);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(278, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 41);
            this.label3.TabIndex = 0;
            this.label3.Text = "تم فعال";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiComboBox1
            // 
            this.uiComboBox1.Location = new System.Drawing.Point(23, 3);
            this.uiComboBox1.Name = "uiComboBox1";
            this.uiComboBox1.Size = new System.Drawing.Size(249, 35);
            this.uiComboBox1.TabIndex = 3;
            this.uiComboBox1.Text = "uiComboBox1";
            this.uiComboBox1.VisualStyleManager = this.visualStyleManager;
            this.uiComboBox1.SelectedValueChanged += new System.EventHandler(this.uiComboBox1_SelectedValueChanged);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.CancelButton, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.SaveButton, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(10, 281);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(391, 62);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // SaveButton
            // 
            this.SaveButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.SaveButton.Location = new System.Drawing.Point(199, 23);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(100, 32);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "ذخیره";
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.CancelButton.Location = new System.Drawing.Point(93, 23);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(100, 32);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "انصراف";
            // 
            // SettingsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(411, 351);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.uiGroupBox2);
            this.Controls.Add(this.uiGroupBox1);
            this.Margin = new System.Windows.Forms.Padding(11, 13, 11, 13);
            this.Name = "SettingsForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "تنظیمات برنامه";
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).EndInit();
            this.uiGroupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox2)).EndInit();
            this.uiGroupBox2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FontDialog fontDialog1;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Janus.Windows.GridEX.EditControls.IntegerUpDown integerUpDown1;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private Janus.Windows.EditControls.UIComboBox uiComboBox1;
        private Janus.Windows.EditControls.UIButton uiButton1;
        private Janus.Windows.EditControls.UIComboBox uiComboBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private Janus.Windows.EditControls.UIButton SaveButton;
        private Janus.Windows.EditControls.UIButton CancelButton;
    }
}