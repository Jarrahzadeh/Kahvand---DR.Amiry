

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Customer
    Inherits Form

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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Customer))
        Me.TNameFather = New System.Windows.Forms.TextBox()
        Me.LNational_Num = New System.Windows.Forms.Label()
        Me.TDis = New System.Windows.Forms.TextBox()
        Me.TTell = New System.Windows.Forms.TextBox()
        Me.Tfamily = New System.Windows.Forms.TextBox()
        Me.TName = New System.Windows.Forms.TextBox()
        Me.TCode = New System.Windows.Forms.TextBox()
        Me.LFather_Name = New System.Windows.Forms.Label()
        Me.LIdentify_Num = New System.Windows.Forms.Label()
        Me.LName = New System.Windows.Forms.Label()
        Me.LCode = New System.Windows.Forms.Label()
        Me.LFamily = New System.Windows.Forms.Label()
        Me.Gb = New System.Windows.Forms.GroupBox()
        Me.btnBrows = New System.Windows.Forms.Button()
        Me.cbType = New System.Windows.Forms.ComboBox()
        Me.MtDate = New Devy.Windows.DatePicker()
        Me.MtLeft = New Devy.Windows.DatePicker()
        Me.MtRight = New Devy.Windows.DatePicker()
        Me.BtnOldVisit = New System.Windows.Forms.Button()
        Me.ChRight = New System.Windows.Forms.CheckBox()
        Me.ChLeft = New System.Windows.Forms.CheckBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.B3 = New System.Windows.Forms.Button()
        Me.BtnVisitText = New System.Windows.Forms.Button()
        Me.BtnVisit = New System.Windows.Forms.Button()
        Me.B2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TAge = New System.Windows.Forms.TextBox()
        Me.TReason = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DG = New System.Windows.Forms.DataGridView()
        Me.LSearch = New System.Windows.Forms.Label()
        Me.RbTel = New System.Windows.Forms.RadioButton()
        Me.RbCode = New System.Windows.Forms.RadioButton()
        Me.RbDate = New System.Windows.Forms.RadioButton()
        Me.RbFamily = New System.Windows.Forms.RadioButton()
        Me.TSearch = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.TSBVisit = New System.Windows.Forms.ToolStripButton()
        Me.TSBCustomer2VisitList = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.lblDrName = New System.Windows.Forms.ToolStripLabel()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Gb.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TNameFather
        '
        Me.TNameFather.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TNameFather.Location = New System.Drawing.Point(49, 27)
        Me.TNameFather.Name = "TNameFather"
        Me.TNameFather.Size = New System.Drawing.Size(288, 26)
        Me.TNameFather.TabIndex = 7
        '
        'LNational_Num
        '
        Me.LNational_Num.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LNational_Num.AutoSize = True
        Me.LNational_Num.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNational_Num.Location = New System.Drawing.Point(343, 34)
        Me.LNational_Num.Name = "LNational_Num"
        Me.LNational_Num.Size = New System.Drawing.Size(43, 13)
        Me.LNational_Num.TabIndex = 6
        Me.LNational_Num.Text = "نام پدر :"
        '
        'TDis
        '
        Me.TDis.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TDis.Location = New System.Drawing.Point(49, 155)
        Me.TDis.Multiline = True
        Me.TDis.Name = "TDis"
        Me.TDis.Size = New System.Drawing.Size(288, 26)
        Me.TDis.TabIndex = 15
        '
        'TTell
        '
        Me.TTell.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TTell.Location = New System.Drawing.Point(49, 59)
        Me.TTell.Name = "TTell"
        Me.TTell.Size = New System.Drawing.Size(288, 26)
        Me.TTell.TabIndex = 9
        '
        'Tfamily
        '
        Me.Tfamily.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tfamily.Location = New System.Drawing.Point(425, 59)
        Me.Tfamily.Name = "Tfamily"
        Me.Tfamily.Size = New System.Drawing.Size(189, 26)
        Me.Tfamily.TabIndex = 5
        '
        'TName
        '
        Me.TName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TName.Location = New System.Drawing.Point(425, 27)
        Me.TName.Name = "TName"
        Me.TName.Size = New System.Drawing.Size(189, 26)
        Me.TName.TabIndex = 3
        '
        'TCode
        '
        Me.TCode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TCode.BackColor = System.Drawing.Color.AntiqueWhite
        Me.TCode.Location = New System.Drawing.Point(676, 27)
        Me.TCode.Name = "TCode"
        Me.TCode.ReadOnly = True
        Me.TCode.Size = New System.Drawing.Size(85, 26)
        Me.TCode.TabIndex = 1
        Me.TCode.TabStop = False
        '
        'LFather_Name
        '
        Me.LFather_Name.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LFather_Name.AutoSize = True
        Me.LFather_Name.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LFather_Name.Location = New System.Drawing.Point(343, 66)
        Me.LFather_Name.Name = "LFather_Name"
        Me.LFather_Name.Size = New System.Drawing.Size(68, 13)
        Me.LFather_Name.TabIndex = 8
        Me.LFather_Name.Text = "شماره تلفن :"
        '
        'LIdentify_Num
        '
        Me.LIdentify_Num.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LIdentify_Num.AutoSize = True
        Me.LIdentify_Num.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LIdentify_Num.Location = New System.Drawing.Point(343, 98)
        Me.LIdentify_Num.Name = "LIdentify_Num"
        Me.LIdentify_Num.Size = New System.Drawing.Size(71, 13)
        Me.LIdentify_Num.TabIndex = 10
        Me.LIdentify_Num.Text = "علت مراجعه :"
        '
        'LName
        '
        Me.LName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LName.AutoSize = True
        Me.LName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LName.Location = New System.Drawing.Point(620, 34)
        Me.LName.Name = "LName"
        Me.LName.Size = New System.Drawing.Size(33, 13)
        Me.LName.TabIndex = 2
        Me.LName.Text = "نام   :"
        '
        'LCode
        '
        Me.LCode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LCode.AutoSize = True
        Me.LCode.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCode.Location = New System.Drawing.Point(771, 34)
        Me.LCode.Name = "LCode"
        Me.LCode.Size = New System.Drawing.Size(25, 13)
        Me.LCode.TabIndex = 0
        Me.LCode.Text = "کد :"
        '
        'LFamily
        '
        Me.LFamily.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LFamily.AutoSize = True
        Me.LFamily.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LFamily.Location = New System.Drawing.Point(620, 98)
        Me.LFamily.Name = "LFamily"
        Me.LFamily.Size = New System.Drawing.Size(55, 13)
        Me.LFamily.TabIndex = 18
        Me.LFamily.Text = "تاریخ ثبت :"
        '
        'Gb
        '
        Me.Gb.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gb.Controls.Add(Me.btnBrows)
        Me.Gb.Controls.Add(Me.cbType)
        Me.Gb.Controls.Add(Me.MtDate)
        Me.Gb.Controls.Add(Me.MtLeft)
        Me.Gb.Controls.Add(Me.MtRight)
        Me.Gb.Controls.Add(Me.BtnOldVisit)
        Me.Gb.Controls.Add(Me.ChRight)
        Me.Gb.Controls.Add(Me.ChLeft)
        Me.Gb.Controls.Add(Me.txtAddress)
        Me.Gb.Controls.Add(Me.Label5)
        Me.Gb.Controls.Add(Me.Label4)
        Me.Gb.Controls.Add(Me.TDis)
        Me.Gb.Controls.Add(Me.Label1)
        Me.Gb.Controls.Add(Me.Button11)
        Me.Gb.Controls.Add(Me.TCode)
        Me.Gb.Controls.Add(Me.B3)
        Me.Gb.Controls.Add(Me.TNameFather)
        Me.Gb.Controls.Add(Me.BtnVisitText)
        Me.Gb.Controls.Add(Me.BtnVisit)
        Me.Gb.Controls.Add(Me.B2)
        Me.Gb.Controls.Add(Me.Button1)
        Me.Gb.Controls.Add(Me.LNational_Num)
        Me.Gb.Controls.Add(Me.Label3)
        Me.Gb.Controls.Add(Me.LFamily)
        Me.Gb.Controls.Add(Me.LCode)
        Me.Gb.Controls.Add(Me.TAge)
        Me.Gb.Controls.Add(Me.TReason)
        Me.Gb.Controls.Add(Me.LName)
        Me.Gb.Controls.Add(Me.TTell)
        Me.Gb.Controls.Add(Me.LFather_Name)
        Me.Gb.Controls.Add(Me.Label2)
        Me.Gb.Controls.Add(Me.TName)
        Me.Gb.Controls.Add(Me.LIdentify_Num)
        Me.Gb.Controls.Add(Me.Tfamily)
        Me.Gb.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Gb.Location = New System.Drawing.Point(10, 25)
        Me.Gb.Name = "Gb"
        Me.Gb.Size = New System.Drawing.Size(793, 296)
        Me.Gb.TabIndex = 1
        Me.Gb.TabStop = False
        '
        'btnBrows
        '
        Me.btnBrows.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBrows.Location = New System.Drawing.Point(424, 186)
        Me.btnBrows.Name = "btnBrows"
        Me.btnBrows.Size = New System.Drawing.Size(34, 28)
        Me.btnBrows.TabIndex = 26
        Me.btnBrows.Text = "..."
        Me.btnBrows.UseVisualStyleBackColor = True
        '
        'cbType
        '
        Me.cbType.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbType.FormattingEnabled = True
        Me.cbType.Location = New System.Drawing.Point(463, 187)
        Me.cbType.Name = "cbType"
        Me.cbType.Size = New System.Drawing.Size(151, 26)
        Me.cbType.TabIndex = 25
        '
        'MtDate
        '
        Me.MtDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MtDate.BackColor = System.Drawing.SystemColors.Control
        Me.MtDate.Date = "1402/09/07"
        Me.MtDate.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.MtDate.Location = New System.Drawing.Point(425, 92)
        Me.MtDate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MtDate.MaximumSize = New System.Drawing.Size(300, 23)
        Me.MtDate.MinimumSize = New System.Drawing.Size(90, 23)
        Me.MtDate.Name = "MtDate"
        Me.MtDate.Size = New System.Drawing.Size(188, 23)
        Me.MtDate.TabIndex = 19
        '
        'MtLeft
        '
        Me.MtLeft.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MtLeft.BackColor = System.Drawing.SystemColors.Control
        Me.MtLeft.Date = "1402/09/07"
        Me.MtLeft.Enabled = False
        Me.MtLeft.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.MtLeft.Location = New System.Drawing.Point(425, 123)
        Me.MtLeft.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MtLeft.MaximumSize = New System.Drawing.Size(300, 23)
        Me.MtLeft.MinimumSize = New System.Drawing.Size(90, 23)
        Me.MtLeft.Name = "MtLeft"
        Me.MtLeft.Size = New System.Drawing.Size(188, 23)
        Me.MtLeft.TabIndex = 21
        '
        'MtRight
        '
        Me.MtRight.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MtRight.BackColor = System.Drawing.SystemColors.Control
        Me.MtRight.Date = "1402/09/07"
        Me.MtRight.Enabled = False
        Me.MtRight.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.MtRight.Location = New System.Drawing.Point(425, 154)
        Me.MtRight.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MtRight.MaximumSize = New System.Drawing.Size(300, 23)
        Me.MtRight.MinimumSize = New System.Drawing.Size(90, 23)
        Me.MtRight.Name = "MtRight"
        Me.MtRight.Size = New System.Drawing.Size(188, 23)
        Me.MtRight.TabIndex = 23
        '
        'BtnOldVisit
        '
        Me.BtnOldVisit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnOldVisit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOldVisit.Image = Global.Ophthalmology.Main.My.Resources.Resources.im
        Me.BtnOldVisit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnOldVisit.Location = New System.Drawing.Point(618, 252)
        Me.BtnOldVisit.Name = "BtnOldVisit"
        Me.BtnOldVisit.Size = New System.Drawing.Size(143, 35)
        Me.BtnOldVisit.TabIndex = 30
        Me.BtnOldVisit.Text = "نسخه های قبلی"
        Me.BtnOldVisit.UseVisualStyleBackColor = True
        '
        'ChRight
        '
        Me.ChRight.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChRight.AutoSize = True
        Me.ChRight.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ChRight.Location = New System.Drawing.Point(620, 161)
        Me.ChRight.Name = "ChRight"
        Me.ChRight.Size = New System.Drawing.Size(140, 17)
        Me.ChRight.TabIndex = 22
        Me.ChRight.Text = "تاریخ عمل چشم راست :"
        Me.ChRight.UseVisualStyleBackColor = True
        '
        'ChLeft
        '
        Me.ChLeft.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChLeft.AutoSize = True
        Me.ChLeft.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ChLeft.Location = New System.Drawing.Point(620, 126)
        Me.ChLeft.Name = "ChLeft"
        Me.ChLeft.Size = New System.Drawing.Size(141, 17)
        Me.ChLeft.TabIndex = 20
        Me.ChLeft.Text = "    تاریخ عمل چشم چپ :"
        Me.ChLeft.UseVisualStyleBackColor = True
        '
        'txtAddress
        '
        Me.txtAddress.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAddress.Location = New System.Drawing.Point(49, 187)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(288, 26)
        Me.txtAddress.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(620, 194)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "نوع بیمار (بیمه) :"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(343, 194)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "آدرس :"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(343, 162)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "توضیحات :"
        '
        'Button11
        '
        Me.Button11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button11.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button11.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Button11.Image = Global.Ophthalmology.Main.My.Resources.Resources.Delete
        Me.Button11.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button11.Location = New System.Drawing.Point(49, 252)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(128, 35)
        Me.Button11.TabIndex = 33
        Me.Button11.Text = "انصراف"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'B3
        '
        Me.B3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.B3.Enabled = False
        Me.B3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B3.Image = Global.Ophthalmology.Main.My.Resources.Resources.cut
        Me.B3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.B3.Location = New System.Drawing.Point(425, 217)
        Me.B3.Name = "B3"
        Me.B3.Size = New System.Drawing.Size(108, 29)
        Me.B3.TabIndex = 29
        Me.B3.Text = "حذف"
        Me.B3.UseVisualStyleBackColor = True
        '
        'BtnVisitText
        '
        Me.BtnVisitText.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnVisitText.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVisitText.Image = Global.Ophthalmology.Main.My.Resources.Resources.im
        Me.BtnVisitText.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnVisitText.Location = New System.Drawing.Point(322, 252)
        Me.BtnVisitText.Name = "BtnVisitText"
        Me.BtnVisitText.Size = New System.Drawing.Size(142, 35)
        Me.BtnVisitText.TabIndex = 32
        Me.BtnVisitText.Text = "نسخه متنی(F7)"
        Me.BtnVisitText.UseVisualStyleBackColor = True
        '
        'BtnVisit
        '
        Me.BtnVisit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnVisit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVisit.Image = Global.Ophthalmology.Main.My.Resources.Resources.im
        Me.BtnVisit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnVisit.Location = New System.Drawing.Point(470, 252)
        Me.BtnVisit.Name = "BtnVisit"
        Me.BtnVisit.Size = New System.Drawing.Size(142, 35)
        Me.BtnVisit.TabIndex = 31
        Me.BtnVisit.Text = "نسخه قلم(F6)"
        Me.BtnVisit.UseVisualStyleBackColor = True
        '
        'B2
        '
        Me.B2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.B2.Enabled = False
        Me.B2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B2.Image = Global.Ophthalmology.Main.My.Resources.Resources._05
        Me.B2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.B2.Location = New System.Drawing.Point(539, 217)
        Me.B2.Name = "B2"
        Me.B2.Size = New System.Drawing.Size(108, 29)
        Me.B2.TabIndex = 28
        Me.B2.Text = "ویرایش(F9)"
        Me.B2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.Ophthalmology.Main.My.Resources.Resources.Add_h
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(653, 217)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 29)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "ثبت(F2)"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(620, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "نام خانوادگی :"
        '
        'TAge
        '
        Me.TAge.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TAge.Location = New System.Drawing.Point(49, 123)
        Me.TAge.MaxLength = 30
        Me.TAge.Name = "TAge"
        Me.TAge.Size = New System.Drawing.Size(288, 26)
        Me.TAge.TabIndex = 13
        '
        'TReason
        '
        Me.TReason.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TReason.Location = New System.Drawing.Point(49, 91)
        Me.TReason.Name = "TReason"
        Me.TReason.Size = New System.Drawing.Size(288, 26)
        Me.TReason.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(343, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "سال تولد :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.DG)
        Me.GroupBox2.Controls.Add(Me.LSearch)
        Me.GroupBox2.Controls.Add(Me.RbTel)
        Me.GroupBox2.Controls.Add(Me.RbCode)
        Me.GroupBox2.Controls.Add(Me.RbDate)
        Me.GroupBox2.Controls.Add(Me.RbFamily)
        Me.GroupBox2.Controls.Add(Me.TSearch)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 327)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(793, 308)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "نمایش"
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(49, 19)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(106, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "به روز رسانی"
        Me.Button2.UseVisualStyleBackColor = True
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
        Me.DG.Location = New System.Drawing.Point(6, 49)
        Me.DG.Name = "DG"
        Me.DG.ReadOnly = True
        Me.DG.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DG.RowHeadersVisible = False
        Me.DG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG.Size = New System.Drawing.Size(798, 251)
        Me.DG.TabIndex = 7
        Me.DG.TabStop = False
        '
        'LSearch
        '
        Me.LSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LSearch.AutoSize = True
        Me.LSearch.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LSearch.Location = New System.Drawing.Point(695, 24)
        Me.LSearch.Name = "LSearch"
        Me.LSearch.Size = New System.Drawing.Size(69, 13)
        Me.LSearch.TabIndex = 0
        Me.LSearch.Text = "(F3)جستجو :"
        '
        'RbTel
        '
        Me.RbTel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RbTel.AutoSize = True
        Me.RbTel.Location = New System.Drawing.Point(308, 22)
        Me.RbTel.Name = "RbTel"
        Me.RbTel.Size = New System.Drawing.Size(46, 17)
        Me.RbTel.TabIndex = 3
        Me.RbTel.TabStop = True
        Me.RbTel.Text = "تلفن"
        Me.RbTel.UseVisualStyleBackColor = True
        '
        'RbCode
        '
        Me.RbCode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RbCode.AutoSize = True
        Me.RbCode.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbCode.Location = New System.Drawing.Point(169, 22)
        Me.RbCode.Name = "RbCode"
        Me.RbCode.Size = New System.Drawing.Size(36, 17)
        Me.RbCode.TabIndex = 5
        Me.RbCode.Text = "کد"
        Me.RbCode.UseVisualStyleBackColor = True
        '
        'RbDate
        '
        Me.RbDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RbDate.AutoSize = True
        Me.RbDate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbDate.Location = New System.Drawing.Point(219, 22)
        Me.RbDate.Name = "RbDate"
        Me.RbDate.Size = New System.Drawing.Size(75, 17)
        Me.RbDate.TabIndex = 4
        Me.RbDate.Text = "تاریخ ویزیت"
        Me.RbDate.UseVisualStyleBackColor = True
        '
        'RbFamily
        '
        Me.RbFamily.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RbFamily.AutoSize = True
        Me.RbFamily.Checked = True
        Me.RbFamily.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbFamily.Location = New System.Drawing.Point(368, 22)
        Me.RbFamily.Name = "RbFamily"
        Me.RbFamily.Size = New System.Drawing.Size(86, 17)
        Me.RbFamily.TabIndex = 2
        Me.RbFamily.TabStop = True
        Me.RbFamily.Text = " نام خانوادگی"
        Me.RbFamily.UseVisualStyleBackColor = True
        '
        'TSearch
        '
        Me.TSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TSearch.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSearch.Location = New System.Drawing.Point(476, 16)
        Me.TSearch.Name = "TSearch"
        Me.TSearch.Size = New System.Drawing.Size(213, 27)
        Me.TSearch.TabIndex = 1
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSBVisit, Me.TSBCustomer2VisitList, Me.ToolStripSeparator1, Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripSeparator2, Me.lblDrName})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(813, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'TSBVisit
        '
        Me.TSBVisit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.TSBVisit.Image = CType(resources.GetObject("TSBVisit.Image"), System.Drawing.Image)
        Me.TSBVisit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSBVisit.Name = "TSBVisit"
        Me.TSBVisit.Size = New System.Drawing.Size(73, 22)
        Me.TSBVisit.Text = "لیست ویزیت"
        '
        'TSBCustomer2VisitList
        '
        Me.TSBCustomer2VisitList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.TSBCustomer2VisitList.Image = CType(resources.GetObject("TSBCustomer2VisitList.Image"), System.Drawing.Image)
        Me.TSBCustomer2VisitList.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSBCustomer2VisitList.Name = "TSBCustomer2VisitList"
        Me.TSBCustomer2VisitList.Size = New System.Drawing.Size(94, 22)
        Me.TSBCustomer2VisitList.Text = "نوبت دهی  (F5)"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(74, 22)
        Me.ToolStripButton1.Text = "افزایش فونت"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(73, 22)
        Me.ToolStripButton2.Text = "کاهش فونت"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'lblDrName
        '
        Me.lblDrName.ForeColor = System.Drawing.Color.Red
        Me.lblDrName.Name = "lblDrName"
        Me.lblDrName.Size = New System.Drawing.Size(19, 22)
        Me.lblDrName.Text = "---"
        '
        'Customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Button11
        Me.ClientSize = New System.Drawing.Size(813, 643)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Gb)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.KeyPreview = True
        Me.Name = "Customer"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "اشخاص"
        Me.Gb.ResumeLayout(False)
        Me.Gb.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TNameFather As System.Windows.Forms.TextBox
    Friend WithEvents LNational_Num As System.Windows.Forms.Label
    Friend WithEvents TDis As System.Windows.Forms.TextBox
    Friend WithEvents TTell As System.Windows.Forms.TextBox
    Friend WithEvents Tfamily As System.Windows.Forms.TextBox
    Friend WithEvents TName As System.Windows.Forms.TextBox
    Friend WithEvents TCode As System.Windows.Forms.TextBox
    Friend WithEvents LFather_Name As System.Windows.Forms.Label
    Friend WithEvents LIdentify_Num As System.Windows.Forms.Label
    Friend WithEvents LName As System.Windows.Forms.Label
    Friend WithEvents LCode As System.Windows.Forms.Label
    Friend WithEvents LFamily As System.Windows.Forms.Label
    Friend WithEvents Gb As System.Windows.Forms.GroupBox
    Friend WithEvents TReason As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents B3 As System.Windows.Forms.Button
    Friend WithEvents B2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RbTel As System.Windows.Forms.RadioButton
    Friend WithEvents RbDate As System.Windows.Forms.RadioButton
    Friend WithEvents RbFamily As System.Windows.Forms.RadioButton
    Friend WithEvents TSearch As System.Windows.Forms.TextBox
    Friend WithEvents DG As System.Windows.Forms.DataGridView
    Friend WithEvents LSearch As System.Windows.Forms.Label
    Friend WithEvents TAge As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnVisit As System.Windows.Forms.Button
    Friend WithEvents ChRight As System.Windows.Forms.CheckBox
    Friend WithEvents ChLeft As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnOldVisit As System.Windows.Forms.Button
    Friend WithEvents MtDate As Devy.Windows.DatePicker
    Friend WithEvents MtLeft As Devy.Windows.DatePicker
    Friend WithEvents MtRight As Devy.Windows.DatePicker
    Friend WithEvents BtnVisitText As System.Windows.Forms.Button
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents TSBVisit As System.Windows.Forms.ToolStripButton
    Friend WithEvents TSBCustomer2VisitList As System.Windows.Forms.ToolStripButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lblDrName As System.Windows.Forms.ToolStripLabel
    Friend WithEvents RbCode As System.Windows.Forms.RadioButton
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnBrows As System.Windows.Forms.Button
    Friend WithEvents cbType As System.Windows.Forms.ComboBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents BindingSource1 As BindingSource
End Class
