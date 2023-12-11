namespace Ophthalmology.UI.Win.Forms
{
    partial class AppointmentForm
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
            Janus.Windows.GridEX.GridEXLayout multiColumnCombo1_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppointmentForm));
            this.bindingSourceCustomers = new System.Windows.Forms.BindingSource(this.components);
            this.multiColumnCombo1 = new Janus.Windows.GridEX.EditControls.MultiColumnCombo();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.multiColumnCombo1)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSourceCustomers
            // 
            this.bindingSourceCustomers.DataSource = typeof(Ophthalmology.Entity.Entites.Customer);
            // 
            // multiColumnCombo1
            // 
            this.multiColumnCombo1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.multiColumnCombo1.AutoComplete = false;
            this.multiColumnCombo1.DataSource = this.bindingSourceCustomers;
            multiColumnCombo1_DesignTimeLayout.LayoutString = resources.GetString("multiColumnCombo1_DesignTimeLayout.LayoutString");
            this.multiColumnCombo1.DesignTimeLayout = multiColumnCombo1_DesignTimeLayout;
            this.multiColumnCombo1.DisplayMember = "FullName";
            this.multiColumnCombo1.Location = new System.Drawing.Point(512, 13);
            this.multiColumnCombo1.Name = "multiColumnCombo1";
            this.multiColumnCombo1.SelectedIndex = -1;
            this.multiColumnCombo1.SelectedItem = null;
            this.multiColumnCombo1.Size = new System.Drawing.Size(275, 35);
            this.multiColumnCombo1.TabIndex = 1;
            this.multiColumnCombo1.ValueMember = "Id";
            this.multiColumnCombo1.VisualStyleManager = this.visualStyleManager;
            this.multiColumnCombo1.ValueChanged += new System.EventHandler(this.multiColumnCombo1_ValueChanged);
            this.multiColumnCombo1.TextChanged += new System.EventHandler(this.multiColumnCombo1_TextChanged);
            // 
            // AppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.multiColumnCombo1);
            this.Name = "AppointmentForm";
            this.Text = "نوبت دهی";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.multiColumnCombo1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSourceCustomers;
        private Janus.Windows.GridEX.EditControls.MultiColumnCombo multiColumnCombo1;
    }
}