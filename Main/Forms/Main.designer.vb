

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.Button1 = New System.Windows.Forms.Button
        Me.buttonVisitAppointment = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.btnUser = New System.Windows.Forms.Button
        Me.txtDrName = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button7 = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.NI = New System.Windows.Forms.NotifyIcon(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'buttonTextVisit
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(646, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(174, 71)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "اشخاص"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'buttonVisitAppointment
        '
        Me.buttonVisitAppointment.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.buttonVisitAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonVisitAppointment.Location = New System.Drawing.Point(646, 89)
        Me.buttonVisitAppointment.Name = "buttonVisitAppointment"
        Me.buttonVisitAppointment.Size = New System.Drawing.Size(174, 71)
        Me.buttonVisitAppointment.TabIndex = 1
        Me.buttonVisitAppointment.Tag = "\"
        Me.buttonVisitAppointment.Text = "رزرو ویزیت"
        Me.buttonVisitAppointment.UseVisualStyleBackColor = False
        '
        'buttonChat
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(646, 166)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(174, 71)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "گزارشات"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button4.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(646, 243)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(174, 71)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "خروج"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Ophthalmology.Main.My.Resources.Resources.dv645017
        Me.PictureBox1.Location = New System.Drawing.Point(192, 44)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(448, 270)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Location = New System.Drawing.Point(12, 89)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(174, 71)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "پشتیبان گیری"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Location = New System.Drawing.Point(12, 166)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(174, 71)
        Me.Button6.TabIndex = 6
        Me.Button6.Text = "باز گردانی پشتیبان"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'btnUser
        '
        Me.btnUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUser.Location = New System.Drawing.Point(12, 12)
        Me.btnUser.Name = "btnUser"
        Me.btnUser.Size = New System.Drawing.Size(174, 71)
        Me.btnUser.TabIndex = 4
        Me.btnUser.Text = "کاربران"
        Me.btnUser.UseVisualStyleBackColor = False
        '
        'txtDrName
        '
        Me.txtDrName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDrName.Location = New System.Drawing.Point(291, 12)
        Me.txtDrName.Name = "txtDrName"
        Me.txtDrName.ReadOnly = True
        Me.txtDrName.Size = New System.Drawing.Size(231, 21)
        Me.txtDrName.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(528, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "نام دکتر :"
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Location = New System.Drawing.Point(12, 243)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(174, 71)
        Me.Button7.TabIndex = 7
        Me.Button7.Text = "ارتباط منشی و پزشک"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'NI
        '
        Me.NI.Icon = CType(resources.GetObject("NI.Icon"), System.Drawing.Icon)
        Me.NI.Text = "NotifyIcon1"
        Me.NI.Visible = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.CancelButton = Me.Button4
        Me.ClientSize = New System.Drawing.Size(825, 332)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDrName)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.buttonVisitAppointment)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.btnUser)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.KeyPreview = True
        Me.Name = "Main"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "سیستم مدیریت نسخ"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents buttonVisitAppointment As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents btnUser As System.Windows.Forms.Button
    Friend WithEvents txtDrName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents NI As System.Windows.Forms.NotifyIcon
End Class
