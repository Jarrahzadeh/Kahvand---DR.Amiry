<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Editor
    Inherits System.Windows.Forms.Form

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
        Me.components = New System.ComponentModel.Container
        Me.rtbMain = New System.Windows.Forms.RichTextBox
        Me.CbFont = New System.Windows.Forms.ComboBox
        Me.LblPicName = New System.Windows.Forms.Label
        Me.LblStatus = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TFk_Customer = New System.Windows.Forms.TextBox
        Me.LCode = New System.Windows.Forms.Label
        Me.LName = New System.Windows.Forms.Label
        Me.TDateVisit = New System.Windows.Forms.TextBox
        Me.TName = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.BtnClose = New System.Windows.Forms.Button
        Me.BtnSave = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.Button8 = New System.Windows.Forms.Button
        Me.Button9 = New System.Windows.Forms.Button
        Me.Button10 = New System.Windows.Forms.Button
        Me.lblId = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtDrName = New System.Windows.Forms.TextBox
        Me.lblTime = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtAge = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtType = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtAddress = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.کپیToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.الحاقToolStripMenuItem = New System.Windows.Forms.ToolStripSeparator
        Me.الحاقToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'rtbMain
        '
        Me.rtbMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtbMain.ContextMenuStrip = Me.ContextMenuStrip1
        Me.rtbMain.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.rtbMain.Location = New System.Drawing.Point(12, 165)
        Me.rtbMain.Name = "rtbMain"
        Me.rtbMain.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rtbMain.Size = New System.Drawing.Size(806, 371)
        Me.rtbMain.TabIndex = 0
        Me.rtbMain.Text = ""
        '
        'CbFont
        '
        Me.CbFont.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CbFont.FormattingEnabled = True
        Me.CbFont.Location = New System.Drawing.Point(144, 7)
        Me.CbFont.Name = "CbFont"
        Me.CbFont.Size = New System.Drawing.Size(58, 21)
        Me.CbFont.TabIndex = 1
        '
        'LblPicName
        '
        Me.LblPicName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblPicName.AutoSize = True
        Me.LblPicName.Location = New System.Drawing.Point(398, 39)
        Me.LblPicName.Name = "LblPicName"
        Me.LblPicName.Size = New System.Drawing.Size(19, 13)
        Me.LblPicName.TabIndex = 1252
        Me.LblPicName.Text = "---"
        '
        'LblStatus
        '
        Me.LblStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblStatus.AutoSize = True
        Me.LblStatus.Location = New System.Drawing.Point(398, 63)
        Me.LblStatus.Name = "LblStatus"
        Me.LblStatus.Size = New System.Drawing.Size(19, 13)
        Me.LblStatus.TabIndex = 1251
        Me.LblStatus.Text = "---"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(579, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 1250
        Me.Label1.Text = "تاریخ :"
        '
        'TFk_Customer
        '
        Me.TFk_Customer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TFk_Customer.BackColor = System.Drawing.Color.AntiqueWhite
        Me.TFk_Customer.Location = New System.Drawing.Point(714, 12)
        Me.TFk_Customer.Name = "TFk_Customer"
        Me.TFk_Customer.ReadOnly = True
        Me.TFk_Customer.Size = New System.Drawing.Size(34, 21)
        Me.TFk_Customer.TabIndex = 1247
        Me.TFk_Customer.TabStop = False
        '
        'LCode
        '
        Me.LCode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LCode.AutoSize = True
        Me.LCode.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCode.Location = New System.Drawing.Point(755, 15)
        Me.LCode.Name = "LCode"
        Me.LCode.Size = New System.Drawing.Size(25, 13)
        Me.LCode.TabIndex = 1248
        Me.LCode.Text = "کد :"
        '
        'LName
        '
        Me.LName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LName.AutoSize = True
        Me.LName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LName.Location = New System.Drawing.Point(675, 13)
        Me.LName.Name = "LName"
        Me.LName.Size = New System.Drawing.Size(33, 13)
        Me.LName.TabIndex = 1249
        Me.LName.Text = "نام   :"
        '
        'TDateVisit
        '
        Me.TDateVisit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TDateVisit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TDateVisit.Location = New System.Drawing.Point(460, 66)
        Me.TDateVisit.Name = "TDateVisit"
        Me.TDateVisit.ReadOnly = True
        Me.TDateVisit.Size = New System.Drawing.Size(113, 21)
        Me.TDateVisit.TabIndex = 1245
        '
        'TName
        '
        Me.TName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TName.Location = New System.Drawing.Point(539, 12)
        Me.TName.Name = "TName"
        Me.TName.ReadOnly = True
        Me.TName.Size = New System.Drawing.Size(130, 21)
        Me.TName.TabIndex = 1246
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(209, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 1253
        Me.Label2.Text = "اندازه قلم"
        '
        'BtnClose
        '
        Me.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnClose.Image = Global.Kahvand.My.Resources.Resources.Delete
        Me.BtnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnClose.Location = New System.Drawing.Point(12, 39)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(103, 45)
        Me.BtnClose.TabIndex = 1256
        Me.BtnClose.Text = "انصراف"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Image = Global.Kahvand.My.Resources.Resources.im
        Me.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSave.Location = New System.Drawing.Point(122, 39)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(133, 45)
        Me.BtnSave.TabIndex = 1255
        Me.BtnSave.Text = "ذخیره وخروج"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(282, 39)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 45)
        Me.Button1.TabIndex = 1254
        Me.Button1.Text = "گفتگو"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 105)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(77, 43)
        Me.Button2.TabIndex = 1257
        Me.Button2.Text = "F1 REF"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(95, 105)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(77, 43)
        Me.Button3.TabIndex = 1257
        Me.Button3.Text = "F2 Cat"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(178, 105)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(77, 43)
        Me.Button4.TabIndex = 1257
        Me.Button4.Text = "F3 Cornea"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(266, 105)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(77, 43)
        Me.Button5.TabIndex = 1257
        Me.Button5.Text = "F4 Strabism"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(349, 105)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(77, 43)
        Me.Button6.TabIndex = 1257
        Me.Button6.Text = "F5 Fundus"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(432, 105)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(86, 43)
        Me.Button7.TabIndex = 1257
        Me.Button7.Text = "F6 Conjunciva"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(524, 105)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(77, 43)
        Me.Button8.TabIndex = 1257
        Me.Button8.Text = "F7 NLD"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(607, 105)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(77, 43)
        Me.Button9.TabIndex = 1257
        Me.Button9.Text = "F8 Lid"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(690, 105)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(77, 43)
        Me.Button10.TabIndex = 1257
        Me.Button10.Text = "F9 Surgery"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'lblId
        '
        Me.lblId.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(398, 89)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(19, 13)
        Me.lblId.TabIndex = 1258
        Me.lblId.Text = "---"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(754, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 1260
        Me.Label3.Text = "نام دکتر :"
        '
        'txtDrName
        '
        Me.txtDrName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDrName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDrName.Location = New System.Drawing.Point(635, 66)
        Me.txtDrName.Name = "txtDrName"
        Me.txtDrName.ReadOnly = True
        Me.txtDrName.Size = New System.Drawing.Size(113, 21)
        Me.txtDrName.TabIndex = 1259
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lblTime.Location = New System.Drawing.Point(12, 9)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(99, 19)
        Me.lblTime.TabIndex = 1261
        Me.lblTime.Text = "---------------"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'txtAge
        '
        Me.txtAge.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAge.Location = New System.Drawing.Point(434, 10)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.ReadOnly = True
        Me.txtAge.Size = New System.Drawing.Size(45, 21)
        Me.txtAge.TabIndex = 1246
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(485, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 1249
        Me.Label4.Text = "سال تولد"
        '
        'txtType
        '
        Me.txtType.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtType.Location = New System.Drawing.Point(270, 10)
        Me.txtType.Name = "txtType"
        Me.txtType.ReadOnly = True
        Me.txtType.Size = New System.Drawing.Size(113, 21)
        Me.txtType.TabIndex = 1246
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(388, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 1249
        Me.Label5.Text = "نوع :"
        '
        'txtAddress
        '
        Me.txtAddress.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAddress.Location = New System.Drawing.Point(434, 39)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ReadOnly = True
        Me.txtAddress.Size = New System.Drawing.Size(314, 21)
        Me.txtAddress.TabIndex = 1262
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(754, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 1263
        Me.Label6.Text = "ادرس :"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.کپیToolStripMenuItem, Me.الحاقToolStripMenuItem, Me.الحاقToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(101, 54)
        '
        'کپیToolStripMenuItem
        '
        Me.کپیToolStripMenuItem.Name = "کپیToolStripMenuItem"
        Me.کپیToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.کپیToolStripMenuItem.Text = "کپی"
        '
        'الحاقToolStripMenuItem
        '
        Me.الحاقToolStripMenuItem.Name = "الحاقToolStripMenuItem"
        Me.الحاقToolStripMenuItem.Size = New System.Drawing.Size(149, 6)
        '
        'الحاقToolStripMenuItem1
        '
        Me.الحاقToolStripMenuItem1.Name = "الحاقToolStripMenuItem1"
        Me.الحاقToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.الحاقToolStripMenuItem1.Text = "الحاق"
        '
        'Editor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnClose
        Me.ClientSize = New System.Drawing.Size(830, 548)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDrName)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LblPicName)
        Me.Controls.Add(Me.LblStatus)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TFk_Customer)
        Me.Controls.Add(Me.LCode)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LName)
        Me.Controls.Add(Me.TDateVisit)
        Me.Controls.Add(Me.txtType)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.TName)
        Me.Controls.Add(Me.CbFont)
        Me.Controls.Add(Me.rtbMain)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.KeyPreview = True
        Me.Name = "Editor"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "نسخه"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rtbMain As System.Windows.Forms.RichTextBox
    Friend WithEvents CbFont As System.Windows.Forms.ComboBox
    Friend WithEvents LblPicName As System.Windows.Forms.Label
    Friend WithEvents LblStatus As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TFk_Customer As System.Windows.Forms.TextBox
    Friend WithEvents LCode As System.Windows.Forms.Label
    Friend WithEvents LName As System.Windows.Forms.Label
    Friend WithEvents TDateVisit As System.Windows.Forms.TextBox
    Friend WithEvents TName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents lblId As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDrName As System.Windows.Forms.TextBox
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents txtAge As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtType As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents کپیToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents الحاقToolStripMenuItem As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents الحاقToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
End Class
