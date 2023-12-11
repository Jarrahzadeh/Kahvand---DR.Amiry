namespace Ophthalmology.UI.Win.Forms
{
    partial class TypePatientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TypePatientForm));
            Janus.Windows.GridEX.GridEXLayout customGridEx1_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.btnCancel = new Janus.Windows.EditControls.UIButton();
            this.btnDelete = new Janus.Windows.EditControls.UIButton();
            this.btnEdit = new Janus.Windows.EditControls.UIButton();
            this.btnSave = new Janus.Windows.EditControls.UIButton();
            this.GroupBox3 = new Janus.Windows.EditControls.UIGroupBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.editBox1 = new Janus.Windows.GridEX.EditControls.EditBox();
            this.TxtName = new Janus.Windows.GridEX.EditControls.EditBox();
            this.TxtId = new Janus.Windows.GridEX.EditControls.EditBox();
            this.customGridEx1 = new Ophthalmology.Controls.CustomControls.CustomGridEx();
            this.bindingSourceBaseData = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.GroupBox3)).BeginInit();
            this.GroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customGridEx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseData)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(57, 397);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 34);
            this.btnCancel.TabIndex = 588;
            this.btnCancel.Text = "انصراف";
            this.btnCancel.VisualStyleManager = this.visualStyleManager;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(164, 397);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 34);
            this.btnDelete.TabIndex = 587;
            this.btnDelete.Text = "حذف";
            this.btnDelete.VisualStyleManager = this.visualStyleManager;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(271, 397);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 34);
            this.btnEdit.TabIndex = 586;
            this.btnEdit.Text = "ویرایش(F9)";
            this.btnEdit.VisualStyleManager = this.visualStyleManager;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSave.Location = new System.Drawing.Point(378, 397);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 34);
            this.btnSave.TabIndex = 585;
            this.btnSave.Text = "ثبت(F2)";
            this.btnSave.VisualStyleManager = this.visualStyleManager;
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.Label2);
            this.GroupBox3.Controls.Add(this.Label3);
            this.GroupBox3.Controls.Add(this.Label1);
            this.GroupBox3.Controls.Add(this.editBox1);
            this.GroupBox3.Controls.Add(this.TxtName);
            this.GroupBox3.Controls.Add(this.TxtId);
            this.GroupBox3.Location = new System.Drawing.Point(3, 255);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(503, 113);
            this.GroupBox3.TabIndex = 584;
            this.GroupBox3.VisualStyleManager = this.visualStyleManager;
            // 
            // Label2
            // 
            this.Label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(466, 23);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(27, 28);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "کد";
            // 
            // Label3
            // 
            this.Label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(240, 64);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(71, 28);
            this.Label3.TabIndex = 1;
            this.Label3.Text = "مبلغ ویزیت";
            // 
            // Label1
            // 
            this.Label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(240, 23);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(42, 28);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "عنوان";
            // 
            // editBox1
            // 
            this.editBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editBox1.Location = new System.Drawing.Point(21, 61);
            this.editBox1.Name = "editBox1";
            this.editBox1.Size = new System.Drawing.Size(213, 35);
            this.editBox1.TabIndex = 0;
            this.editBox1.VisualStyleManager = this.visualStyleManager;
            // 
            // TxtName
            // 
            this.TxtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtName.Location = new System.Drawing.Point(21, 20);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(213, 35);
            this.TxtName.TabIndex = 0;
            this.TxtName.VisualStyleManager = this.visualStyleManager;
            // 
            // TxtId
            // 
            this.TxtId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.TxtId.Location = new System.Drawing.Point(364, 20);
            this.TxtId.Name = "TxtId";
            this.TxtId.ReadOnly = true;
            this.TxtId.Size = new System.Drawing.Size(100, 35);
            this.TxtId.TabIndex = 0;
            this.TxtId.TabStop = false;
            this.TxtId.VisualStyleManager = this.visualStyleManager;
            // 
            // customGridEx1
            // 
            this.customGridEx1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.customGridEx1.AlternatingColors = true;
            this.customGridEx1.BuiltInTextsData = resources.GetString("customGridEx1.BuiltInTextsData");
            this.customGridEx1.ColumnAutoResize = true;
            this.customGridEx1.DataSource = this.bindingSourceBaseData;
            customGridEx1_DesignTimeLayout.LayoutString = resources.GetString("customGridEx1_DesignTimeLayout.LayoutString");
            this.customGridEx1.DesignTimeLayout = customGridEx1_DesignTimeLayout;
            this.customGridEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customGridEx1.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.customGridEx1.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.customGridEx1.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.customGridEx1.GroupByBoxVisible = false;
            this.customGridEx1.HideColumnsWhenGrouped = Janus.Windows.GridEX.InheritableBoolean.True;
            this.customGridEx1.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            this.customGridEx1.Location = new System.Drawing.Point(3, 3);
            this.customGridEx1.Name = "customGridEx1";
            this.customGridEx1.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.customGridEx1.Size = new System.Drawing.Size(503, 246);
            this.customGridEx1.TabIndex = 0;
            this.customGridEx1.TabKeyBehavior = Janus.Windows.GridEX.TabKeyBehavior.ControlNavigation;
            this.customGridEx1.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.customGridEx1.VisualStyleManager = this.visualStyleManager;
            // 
            // bindingSourceBaseData
            // 
            this.bindingSourceBaseData.DataSource = typeof(Ophthalmology.Entity.Entites.TypePatient);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.customGridEx1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.GroupBox3, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 13);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(509, 371);
            this.tableLayoutPanel1.TabIndex = 589;
            // 
            // TypePatientForm
            // 
            this.ClientSize = new System.Drawing.Size(535, 444);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Name = "TypePatientForm";
            this.Text = "مدیریت انواع بیمه";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TypePatientForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.GroupBox3)).EndInit();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customGridEx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBaseData)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.EditControls.UIButton btnCancel;
        private Janus.Windows.EditControls.UIButton btnDelete;
        private Janus.Windows.EditControls.UIButton btnEdit;
        private Janus.Windows.EditControls.UIButton btnSave;
        private Janus.Windows.EditControls.UIGroupBox GroupBox3;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label Label1;
        private Janus.Windows.GridEX.EditControls.EditBox TxtName;
        private Janus.Windows.GridEX.EditControls.EditBox TxtId;
        private Controls.CustomControls.CustomGridEx customGridEx1;
        private Janus.Windows.GridEX.EditControls.EditBox editBox1;
        private System.Windows.Forms.BindingSource bindingSourceBaseData;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}