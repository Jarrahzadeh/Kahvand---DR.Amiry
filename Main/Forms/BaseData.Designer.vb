Imports Ophthalmology.Controls.CustomForm

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BaseData
    Inherits Ophthalmology.Controls.CustomForm.CustomizableFormBase

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DG = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtPrice = New Ophthalmology.Main.UTextBox(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DG)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(457, 244)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'DG
        '
        Me.DG.AllowUserToAddRows = False
        Me.DG.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan
        Me.DG.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DG.Location = New System.Drawing.Point(3, 17)
        Me.DG.Name = "DG"
        Me.DG.ReadOnly = True
        Me.DG.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DG.RowHeadersVisible = False
        Me.DG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG.Size = New System.Drawing.Size(451, 224)
        Me.DG.TabIndex = 103
        Me.DG.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtPrice)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.TxtName)
        Me.GroupBox3.Controls.Add(Me.TxtId)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox3.Location = New System.Drawing.Point(0, 244)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(457, 88)
        Me.GroupBox3.TabIndex = 20
        Me.GroupBox3.TabStop = False
        '
        'txtPrice
        '
        Me.txtPrice.IsLanguage = Ophthalmology.Main.UTextBox.Language.Defualt
        Me.txtPrice.IsNumber = False
        Me.txtPrice.IsSplit = True
        Me.txtPrice.Location = New System.Drawing.Point(22, 50)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(244, 21)
        Me.txtPrice.TabIndex = 2
        Me.txtPrice.Value = ""
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(420, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "کد :"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(272, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "مبلغ ویزیت :"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(272, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "عنوان :"
        '
        'TxtName
        '
        Me.TxtName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtName.Location = New System.Drawing.Point(22, 20)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(244, 21)
        Me.TxtName.TabIndex = 0
        '
        'TxtId
        '
        Me.TxtId.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtId.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtId.Location = New System.Drawing.Point(318, 20)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.ReadOnly = True
        Me.TxtId.Size = New System.Drawing.Size(100, 21)
        Me.TxtId.TabIndex = 0
        Me.TxtId.TabStop = False
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.btnCancel.Image = Global.Ophthalmology.Main.My.Resources.Resources.Delete
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancel.Location = New System.Drawing.Point(22, 352)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(98, 30)
        Me.btnCancel.TabIndex = 582
        Me.btnCancel.Text = "انصراف"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.Enabled = False
        Me.btnDelete.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Image = Global.Ophthalmology.Main.My.Resources.Resources.cut
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDelete.Location = New System.Drawing.Point(126, 353)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(92, 29)
        Me.btnDelete.TabIndex = 581
        Me.btnDelete.Text = "حذف"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEdit.Enabled = False
        Me.btnEdit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Image = Global.Ophthalmology.Main.My.Resources.Resources._05
        Me.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEdit.Location = New System.Drawing.Point(225, 353)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(92, 29)
        Me.btnEdit.TabIndex = 580
        Me.btnEdit.Text = "ویرایش(F9)"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = Global.Ophthalmology.Main.My.Resources.Resources.Add_h
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.Location = New System.Drawing.Point(322, 353)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(92, 29)
        Me.btnSave.TabIndex = 579
        Me.btnSave.Text = "ثبت(F2)"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'BaseData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(457, 394)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Name = "BaseData"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "نوع بیمار"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtName As System.Windows.Forms.TextBox
    Friend WithEvents TxtId As System.Windows.Forms.TextBox
    Friend WithEvents DG As System.Windows.Forms.DataGridView
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents txtPrice As Ophthalmology.Main.UTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
