<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Visit
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
        Me.TFk_Customer = New System.Windows.Forms.TextBox
        Me.LCode = New System.Windows.Forms.Label
        Me.LName = New System.Windows.Forms.Label
        Me.TName = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.BtnSave = New System.Windows.Forms.Button
        Me.TDateVisit = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.BtnClose = New System.Windows.Forms.Button
        Me.TB = New System.Windows.Forms.TrackBar
        Me.Pb = New System.Windows.Forms.PictureBox
        Me.LblStatus = New System.Windows.Forms.Label
        Me.LblPicName = New System.Windows.Forms.Label
        Me.BtnClear = New System.Windows.Forms.Button
        Me.BtnPen = New System.Windows.Forms.Button
        Me.btnOpen = New System.Windows.Forms.Button
        CType(Me.TB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TFk_Customer
        '
        Me.TFk_Customer.BackColor = System.Drawing.Color.AntiqueWhite
        Me.TFk_Customer.Location = New System.Drawing.Point(804, 10)
        Me.TFk_Customer.Name = "TFk_Customer"
        Me.TFk_Customer.ReadOnly = True
        Me.TFk_Customer.Size = New System.Drawing.Size(50, 21)
        Me.TFk_Customer.TabIndex = 1234
        Me.TFk_Customer.TabStop = False
        '
        'LCode
        '
        Me.LCode.AutoSize = True
        Me.LCode.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCode.Location = New System.Drawing.Point(860, 13)
        Me.LCode.Name = "LCode"
        Me.LCode.Size = New System.Drawing.Size(25, 13)
        Me.LCode.TabIndex = 1235
        Me.LCode.Text = "کد :"
        '
        'LName
        '
        Me.LName.AutoSize = True
        Me.LName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LName.Location = New System.Drawing.Point(769, 13)
        Me.LName.Name = "LName"
        Me.LName.Size = New System.Drawing.Size(33, 13)
        Me.LName.TabIndex = 1236
        Me.LName.Text = "نام   :"
        '
        'TName
        '
        Me.TName.Location = New System.Drawing.Point(644, 10)
        Me.TName.Name = "TName"
        Me.TName.ReadOnly = True
        Me.TName.Size = New System.Drawing.Size(120, 21)
        Me.TName.TabIndex = 1233
        '
        'Button1
        '
        Me.Button1.Image = Global.Kahvand.My.Resources.Resources.Add_h
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(254, 47)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 45)
        Me.Button1.TabIndex = 1237
        Me.Button1.Text = "جدید"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Image = Global.Kahvand.My.Resources.Resources.im
        Me.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSave.Location = New System.Drawing.Point(363, 47)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(133, 45)
        Me.BtnSave.TabIndex = 1238
        Me.BtnSave.Text = "ذخیره وخروج"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'TDateVisit
        '
        Me.TDateVisit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TDateVisit.Location = New System.Drawing.Point(521, 10)
        Me.TDateVisit.Name = "TDateVisit"
        Me.TDateVisit.ReadOnly = True
        Me.TDateVisit.Size = New System.Drawing.Size(75, 21)
        Me.TDateVisit.TabIndex = 1233
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(602, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 1240
        Me.Label1.Text = "تاریخ :"
        '
        'BtnClose
        '
        Me.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnClose.Image = Global.Kahvand.My.Resources.Resources.Delete
        Me.BtnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnClose.Location = New System.Drawing.Point(12, 47)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(103, 45)
        Me.BtnClose.TabIndex = 1241
        Me.BtnClose.Text = "خروج"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'TB
        '
        Me.TB.LargeChange = 1
        Me.TB.Location = New System.Drawing.Point(644, 47)
        Me.TB.Name = "TB"
        Me.TB.Size = New System.Drawing.Size(238, 45)
        Me.TB.TabIndex = 1242
        Me.TB.Value = 3
        '
        'Pb
        '
        Me.Pb.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Pb.BackColor = System.Drawing.Color.White
        Me.Pb.Location = New System.Drawing.Point(12, 98)
        Me.Pb.Name = "Pb"
        Me.Pb.Size = New System.Drawing.Size(1002, 521)
        Me.Pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pb.TabIndex = 1239
        Me.Pb.TabStop = False
        '
        'LblStatus
        '
        Me.LblStatus.AutoSize = True
        Me.LblStatus.Location = New System.Drawing.Point(449, 13)
        Me.LblStatus.Name = "LblStatus"
        Me.LblStatus.Size = New System.Drawing.Size(19, 13)
        Me.LblStatus.TabIndex = 1243
        Me.LblStatus.Text = "---"
        '
        'LblPicName
        '
        Me.LblPicName.AutoSize = True
        Me.LblPicName.Location = New System.Drawing.Point(384, 13)
        Me.LblPicName.Name = "LblPicName"
        Me.LblPicName.Size = New System.Drawing.Size(19, 13)
        Me.LblPicName.TabIndex = 1244
        Me.LblPicName.Text = "---"
        '
        'BtnClear
        '
        Me.BtnClear.Location = New System.Drawing.Point(12, 10)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(68, 21)
        Me.BtnClear.TabIndex = 1245
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'BtnPen
        '
        Me.BtnPen.Location = New System.Drawing.Point(89, 9)
        Me.BtnPen.Name = "BtnPen"
        Me.BtnPen.Size = New System.Drawing.Size(68, 21)
        Me.BtnPen.TabIndex = 1245
        Me.BtnPen.Text = "Pen"
        Me.BtnPen.UseVisualStyleBackColor = True
        '
        'btnOpen
        '
        Me.btnOpen.Image = Global.Kahvand.My.Resources.Resources.im
        Me.btnOpen.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnOpen.Location = New System.Drawing.Point(145, 47)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(103, 45)
        Me.btnOpen.TabIndex = 1237
        Me.btnOpen.Text = "از فایل"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'Visit
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnClose
        Me.ClientSize = New System.Drawing.Size(1026, 631)
        Me.Controls.Add(Me.BtnPen)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.LblPicName)
        Me.Controls.Add(Me.LblStatus)
        Me.Controls.Add(Me.TB)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Pb)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.btnOpen)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TFk_Customer)
        Me.Controls.Add(Me.LCode)
        Me.Controls.Add(Me.LName)
        Me.Controls.Add(Me.TDateVisit)
        Me.Controls.Add(Me.TName)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "Visit"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "نسخه"
        Me.TopMost = True
        CType(Me.TB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TFk_Customer As System.Windows.Forms.TextBox
    Friend WithEvents LCode As System.Windows.Forms.Label
    Friend WithEvents LName As System.Windows.Forms.Label
    Friend WithEvents TName As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents Pb As System.Windows.Forms.PictureBox
    Friend WithEvents TDateVisit As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents TB As System.Windows.Forms.TrackBar
    Friend WithEvents LblStatus As System.Windows.Forms.Label
    Friend WithEvents LblPicName As System.Windows.Forms.Label
    Friend WithEvents BtnClear As System.Windows.Forms.Button
    Friend WithEvents BtnPen As System.Windows.Forms.Button
    Friend WithEvents btnOpen As System.Windows.Forms.Button
End Class
