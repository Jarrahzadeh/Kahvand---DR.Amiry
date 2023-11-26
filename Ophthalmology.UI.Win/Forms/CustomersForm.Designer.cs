using Ophthalmology.Entity.Entites;

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
            Janus.Windows.GridEX.GridEXLayout gridCustomer_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomersForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gridCustomer = new Ophthalmology.Controls.CustomControls.CustomGridEx();
            this.bindingSourceGridCustomer = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGridCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.Controls.Add(this.gridCustomer, 0, 10);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(780, 430);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gridCustomer
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.gridCustomer, 7);
            this.gridCustomer.DataSource = this.bindingSourceGridCustomer;
            gridCustomer_DesignTimeLayout.LayoutString = resources.GetString("gridCustomer_DesignTimeLayout.LayoutString");
            this.gridCustomer.DesignTimeLayout = gridCustomer_DesignTimeLayout;
            this.gridCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridCustomer.GroupByBoxVisible = false;
            this.gridCustomer.Location = new System.Drawing.Point(3, 253);
            this.gridCustomer.Name = "gridCustomer";
            this.gridCustomer.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Blue;
            this.gridCustomer.OwnerDrawnAreas = ((Janus.Windows.GridEX.GridEXOwnerDrawnArea)((((((((((Janus.Windows.GridEX.GridEXOwnerDrawnArea.GroupByBoxBackground | Janus.Windows.GridEX.GridEXOwnerDrawnArea.GroupByBoxInfoText) 
            | Janus.Windows.GridEX.GridEXOwnerDrawnArea.GroupByBoxTableInfo) 
            | Janus.Windows.GridEX.GridEXOwnerDrawnArea.RowHeaders) 
            | Janus.Windows.GridEX.GridEXOwnerDrawnArea.TableHeaders) 
            | Janus.Windows.GridEX.GridEXOwnerDrawnArea.NewAndTotalRowSeparators) 
            | Janus.Windows.GridEX.GridEXOwnerDrawnArea.PreviewRows) 
            | Janus.Windows.GridEX.GridEXOwnerDrawnArea.Background) 
            | Janus.Windows.GridEX.GridEXOwnerDrawnArea.GroupRow) 
            | Janus.Windows.GridEX.GridEXOwnerDrawnArea.CardCaption)));
            this.gridCustomer.RecordNavigator = true;
            this.gridCustomer.Size = new System.Drawing.Size(774, 174);
            this.gridCustomer.TabIndex = 0;
            // 
            // bindingSourceGridCustomer
            // 
            this.bindingSourceGridCustomer.DataSource = typeof(Customer);
            // 
            // CustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CustomersForm";
            this.Text = "لیست بیماران";
            this.Load += new System.EventHandler(this.CustomersForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGridCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSourceGridCustomer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Ophthalmology.Controls.CustomControls.CustomGridEx gridCustomer;
    }
}