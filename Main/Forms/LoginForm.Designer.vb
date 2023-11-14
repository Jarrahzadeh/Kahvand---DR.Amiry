Imports Ophthalmology.Controls.CustomForm

Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class LoginForm
        Inherits Ophthalmology.Controls.CustomForm.CustomizableFormBase

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()>
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
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.BtnClose = New System.Windows.Forms.Button()
            Me.BtnEnter = New System.Windows.Forms.Button()
            Me.TxtPass = New System.Windows.Forms.TextBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.TxtUserName = New System.Windows.Forms.TextBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.PictureBox1 = New System.Windows.Forms.PictureBox()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.CbDr = New System.Windows.Forms.ComboBox()
            Me.RbDr = New System.Windows.Forms.RadioButton()
            Me.RbMonshi = New System.Windows.Forms.RadioButton()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.txtServerIP = New System.Windows.Forms.TextBox()
            Me.txtIp = New System.Windows.Forms.TextBox()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.GroupBox3 = New System.Windows.Forms.GroupBox()
            Me.rbOther = New System.Windows.Forms.RadioButton()
            Me.Label4 = New System.Windows.Forms.Label()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox1.SuspendLayout()
            Me.GroupBox3.SuspendLayout()
            Me.SuspendLayout()
            '
            'BtnClose
            '
            Me.BtnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.BtnClose.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnClose.Image = Global.Ophthalmology.Main.My.Resources.Resources.Delete
            Me.BtnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.BtnClose.Location = New System.Drawing.Point(274, 242)
            Me.BtnClose.Name = "BtnClose"
            Me.BtnClose.Size = New System.Drawing.Size(100, 30)
            Me.BtnClose.TabIndex = 10
            Me.BtnClose.Text = "انصراف"
            Me.BtnClose.UseVisualStyleBackColor = True
            '
            'BtnEnter
            '
            Me.BtnEnter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.BtnEnter.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnEnter.Image = Global.Ophthalmology.Main.My.Resources.Resources.dialog_ok
            Me.BtnEnter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.BtnEnter.Location = New System.Drawing.Point(380, 242)
            Me.BtnEnter.Name = "BtnEnter"
            Me.BtnEnter.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Me.BtnEnter.Size = New System.Drawing.Size(100, 30)
            Me.BtnEnter.TabIndex = 9
            Me.BtnEnter.Text = " ورود  (F2)"
            Me.BtnEnter.UseVisualStyleBackColor = True
            '
            'TxtPass
            '
            Me.TxtPass.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.TxtPass.Location = New System.Drawing.Point(274, 69)
            Me.TxtPass.Name = "TxtPass"
            Me.TxtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
            Me.TxtPass.Size = New System.Drawing.Size(208, 21)
            Me.TxtPass.TabIndex = 3
            '
            'Label2
            '
            Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(488, 72)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(59, 13)
            Me.Label2.TabIndex = 2
            Me.Label2.Text = "کلمه عبور :"
            '
            'TxtUserName
            '
            Me.TxtUserName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.TxtUserName.Location = New System.Drawing.Point(274, 32)
            Me.TxtUserName.Name = "TxtUserName"
            Me.TxtUserName.Size = New System.Drawing.Size(208, 21)
            Me.TxtUserName.TabIndex = 1
            '
            'Label1
            '
            Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(488, 35)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(60, 13)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "نام کاربری :"
            '
            'PictureBox1
            '
            Me.PictureBox1.Image = Global.Ophthalmology.Main.My.Resources.Resources.Icon__2_
            Me.PictureBox1.Location = New System.Drawing.Point(6, 20)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(256, 256)
            Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
            Me.PictureBox1.TabIndex = 6
            Me.PictureBox1.TabStop = False
            '
            'GroupBox1
            '
            Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                                          Or System.Windows.Forms.AnchorStyles.Left) _
                                         Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.GroupBox1.Controls.Add(Me.Label4)
            Me.GroupBox1.Controls.Add(Me.Label3)
            Me.GroupBox1.Controls.Add(Me.rbOther)
            Me.GroupBox1.Controls.Add(Me.CbDr)
            Me.GroupBox1.Controls.Add(Me.RbMonshi)
            Me.GroupBox1.Controls.Add(Me.RbDr)
            Me.GroupBox1.Controls.Add(Me.BtnClose)
            Me.GroupBox1.Controls.Add(Me.BtnEnter)
            Me.GroupBox1.Controls.Add(Me.TxtPass)
            Me.GroupBox1.Controls.Add(Me.Label2)
            Me.GroupBox1.Controls.Add(Me.TxtUserName)
            Me.GroupBox1.Controls.Add(Me.Label1)
            Me.GroupBox1.Controls.Add(Me.PictureBox1)
            Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(561, 286)
            Me.GroupBox1.TabIndex = 0
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "ورود به سیستم"
            '
            'Label3
            '
            Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(488, 109)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(60, 13)
            Me.Label3.TabIndex = 4
            Me.Label3.Text = "نام پزشک :"
            '
            'CbDr
            '
            Me.CbDr.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.CbDr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.CbDr.FormattingEnabled = True
            Me.CbDr.Location = New System.Drawing.Point(274, 106)
            Me.CbDr.Name = "CbDr"
            Me.CbDr.Size = New System.Drawing.Size(208, 21)
            Me.CbDr.TabIndex = 5
            '
            'RbDr
            '
            Me.RbDr.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.RbDr.AutoSize = True
            Me.RbDr.Location = New System.Drawing.Point(438, 143)
            Me.RbDr.Name = "RbDr"
            Me.RbDr.Size = New System.Drawing.Size(44, 17)
            Me.RbDr.TabIndex = 6
            Me.RbDr.TabStop = True
            Me.RbDr.Text = "دکتر"
            Me.RbDr.UseVisualStyleBackColor = True
            '
            'RbMonshi
            '
            Me.RbMonshi.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.RbMonshi.AutoSize = True
            Me.RbMonshi.Location = New System.Drawing.Point(424, 176)
            Me.RbMonshi.Name = "RbMonshi"
            Me.RbMonshi.Size = New System.Drawing.Size(58, 17)
            Me.RbMonshi.TabIndex = 7
            Me.RbMonshi.TabStop = True
            Me.RbMonshi.Text = "منشی"
            Me.RbMonshi.UseVisualStyleBackColor = True
            '
            'Label5
            '
            Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label5.AutoSize = True
            Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.Location = New System.Drawing.Point(253, 25)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(55, 13)
            Me.Label5.TabIndex = 0
            Me.Label5.Text = "Ip  سرور :"
            '
            'txtServerIP
            '
            Me.txtServerIP.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtServerIP.Location = New System.Drawing.Point(83, 22)
            Me.txtServerIP.Name = "txtServerIP"
            Me.txtServerIP.Size = New System.Drawing.Size(164, 21)
            Me.txtServerIP.TabIndex = 1
            '
            'txtIp
            '
            Me.txtIp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtIp.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.txtIp.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtIp.Location = New System.Drawing.Point(318, 20)
            Me.txtIp.Multiline = True
            Me.txtIp.Name = "txtIp"
            Me.txtIp.Size = New System.Drawing.Size(164, 21)
            Me.txtIp.TabIndex = 5
            '
            'Label6
            '
            Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label6.AutoSize = True
            Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.Location = New System.Drawing.Point(488, 25)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(48, 13)
            Me.Label6.TabIndex = 4
            Me.Label6.Text = "IP شما :"
            '
            'GroupBox3
            '
            Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                                         Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.GroupBox3.Controls.Add(Me.txtServerIP)
            Me.GroupBox3.Controls.Add(Me.Label6)
            Me.GroupBox3.Controls.Add(Me.Label5)
            Me.GroupBox3.Controls.Add(Me.txtIp)
            Me.GroupBox3.Location = New System.Drawing.Point(12, 308)
            Me.GroupBox3.Name = "GroupBox3"
            Me.GroupBox3.Size = New System.Drawing.Size(561, 53)
            Me.GroupBox3.TabIndex = 3
            Me.GroupBox3.TabStop = False
            Me.GroupBox3.Visible = False
            '
            'rbOther
            '
            Me.rbOther.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.rbOther.AutoSize = True
            Me.rbOther.Location = New System.Drawing.Point(435, 209)
            Me.rbOther.Name = "rbOther"
            Me.rbOther.Size = New System.Drawing.Size(47, 17)
            Me.rbOther.TabIndex = 8
            Me.rbOther.TabStop = True
            Me.rbOther.Text = "سایر"
            Me.rbOther.UseVisualStyleBackColor = True
            '
            'Label4
            '
            Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(488, 178)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(62, 13)
            Me.Label4.TabIndex = 4
            Me.Label4.Text = "نوع کاربری :"
            '
            'LoginForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(585, 310)
            Me.Controls.Add(Me.GroupBox3)
            Me.Controls.Add(Me.GroupBox1)
            Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.KeyPreview = True
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "LoginForm"
            Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "نرم افزار پزشکان"
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.GroupBox3.ResumeLayout(False)
            Me.GroupBox3.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

        Private WithEvents BtnClose As Button
        Private WithEvents BtnEnter As Button
        Private WithEvents TxtPass As TextBox
        Private WithEvents Label2 As Label
        Private WithEvents TxtUserName As TextBox
        Private WithEvents Label1 As Label
        Private WithEvents PictureBox1 As PictureBox
        Private WithEvents GroupBox1 As GroupBox
        Private WithEvents Label3 As Label
        Private WithEvents CbDr As ComboBox
        Private WithEvents RbMonshi As RadioButton
        Private WithEvents RbDr As RadioButton
        Private WithEvents Label6 As Label
        Private WithEvents Label5 As Label
        Private WithEvents txtIp As TextBox
        Private WithEvents txtServerIP As TextBox
        Private WithEvents GroupBox3 As GroupBox
        Private WithEvents rbOther As RadioButton
        Private WithEvents Label4 As Label
    End Class
End Namespace