<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListOfData
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.LSearch = New System.Windows.Forms.Label
        Me.TSearch = New System.Windows.Forms.TextBox
        Me.DG = New System.Windows.Forms.DataGridView
        Me.BtnClose = New System.Windows.Forms.Button
        Me.BtnSave = New System.Windows.Forms.Button
        CType(Me.DG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LSearch
        '
        Me.LSearch.AutoSize = True
        Me.LSearch.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.LSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LSearch.Location = New System.Drawing.Point(502, 15)
        Me.LSearch.Name = "LSearch"
        Me.LSearch.Size = New System.Drawing.Size(101, 19)
        Me.LSearch.TabIndex = 107
        Me.LSearch.Text = "(F3)جستجو :"
        '
        'TSearch
        '
        Me.TSearch.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.TSearch.Location = New System.Drawing.Point(277, 12)
        Me.TSearch.Name = "TSearch"
        Me.TSearch.Size = New System.Drawing.Size(219, 27)
        Me.TSearch.TabIndex = 106
        '
        'DG
        '
        Me.DG.AllowUserToAddRows = False
        Me.DG.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan
        Me.DG.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DG.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG.Location = New System.Drawing.Point(12, 45)
        Me.DG.Name = "DG"
        Me.DG.ReadOnly = True
        Me.DG.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DG.RowHeadersVisible = False
        Me.DG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG.Size = New System.Drawing.Size(586, 458)
        Me.DG.TabIndex = 105
        Me.DG.TabStop = False
        '
        'BtnClose
        '
        Me.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnClose.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.BtnClose.Image = Global.Ophthalmology.Main.My.Resources.Resources.Delete
        Me.BtnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnClose.Location = New System.Drawing.Point(12, 509)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(122, 34)
        Me.BtnClose.TabIndex = 109
        Me.BtnClose.Text = "انصراف"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.BtnSave.Image = Global.Ophthalmology.Main.My.Resources.Resources.dialog_ok
        Me.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnSave.Location = New System.Drawing.Point(140, 509)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(122, 34)
        Me.BtnSave.TabIndex = 108
        Me.BtnSave.Text = "تایید"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'ListOfData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnClose
        Me.ClientSize = New System.Drawing.Size(612, 550)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.LSearch)
        Me.Controls.Add(Me.TSearch)
        Me.Controls.Add(Me.DG)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Name = "ListOfData"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ListOfData"
        CType(Me.DG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LSearch As System.Windows.Forms.Label
    Friend WithEvents TSearch As System.Windows.Forms.TextBox
    Friend WithEvents DG As System.Windows.Forms.DataGridView
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
End Class
