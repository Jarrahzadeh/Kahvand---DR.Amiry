namespace Ophthalmology.Controls.CustomControls
{
    partial class ChatControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.ListBoxMessages = new System.Windows.Forms.ListBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.ButtonCustomMessage = new System.Windows.Forms.Button();
            this.ComboBoxMessage = new System.Windows.Forms.ComboBox();
            this.ButtonSend = new System.Windows.Forms.Button();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.ListBoxMessages);
            this.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBox1.Location = new System.Drawing.Point(5, 5);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.GroupBox1.Size = new System.Drawing.Size(585, 499);
            this.GroupBox1.TabIndex = 1;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "نمایش پیام های ";
            // 
            // ListBoxMessages
            // 
            this.ListBoxMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListBoxMessages.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ListBoxMessages.FormattingEnabled = true;
            this.ListBoxMessages.ItemHeight = 19;
            this.ListBoxMessages.Location = new System.Drawing.Point(5, 19);
            this.ListBoxMessages.Name = "ListBoxMessages";
            this.ListBoxMessages.Size = new System.Drawing.Size(575, 475);
            this.ListBoxMessages.TabIndex = 0;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.Label2);
            this.GroupBox2.Controls.Add(this.ButtonCustomMessage);
            this.GroupBox2.Controls.Add(this.ComboBoxMessage);
            this.GroupBox2.Controls.Add(this.ButtonSend);
            this.GroupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GroupBox2.Location = new System.Drawing.Point(5, 504);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(585, 102);
            this.GroupBox2.TabIndex = 0;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "ارسال پیام";
            // 
            // Label2
            // 
            this.Label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(534, 19);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(45, 13);
            this.Label2.TabIndex = 0;
            this.Label2.Text = "متن پیام";
            // 
            // ButtonCustomMessage
            // 
            this.ButtonCustomMessage.Location = new System.Drawing.Point(6, 15);
            this.ButtonCustomMessage.Name = "ButtonCustomMessage";
            this.ButtonCustomMessage.Size = new System.Drawing.Size(123, 78);
            this.ButtonCustomMessage.TabIndex = 3;
            this.ButtonCustomMessage.Text = "پیام های آماده";
            this.ButtonCustomMessage.UseVisualStyleBackColor = true;
            this.ButtonCustomMessage.Click += new System.EventHandler(this.ButtonCustomMessage_Click);
            // 
            // ComboBoxMessage
            // 
            this.ComboBoxMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxMessage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ComboBoxMessage.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboBoxMessage.FormattingEnabled = true;
            this.ComboBoxMessage.Location = new System.Drawing.Point(135, 16);
            this.ComboBoxMessage.Name = "ComboBoxMessage";
            this.ComboBoxMessage.Size = new System.Drawing.Size(393, 21);
            this.ComboBoxMessage.TabIndex = 1;
            // 
            // ButtonSend
            // 
            this.ButtonSend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSend.Location = new System.Drawing.Point(135, 43);
            this.ButtonSend.Name = "ButtonSend";
            this.ButtonSend.Size = new System.Drawing.Size(393, 50);
            this.ButtonSend.TabIndex = 2;
            this.ButtonSend.Text = "ارسال";
            this.ButtonSend.UseVisualStyleBackColor = true;
            this.ButtonSend.Click += new System.EventHandler(this.ButtonSend_Click);
            // 
            // ChatControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.GroupBox2);
            this.Name = "ChatControl";
            this.Size = new System.Drawing.Size(595, 611);
            this.Load += new System.EventHandler(this.ChatControl_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox ComboBoxMessage;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.ListBox ListBoxMessages;
        private System.Windows.Forms.GroupBox GroupBox2;
        private System.Windows.Forms.Button ButtonCustomMessage;
        private System.Windows.Forms.Button ButtonSend;
    }
}
