<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VisitList
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnRef = New System.Windows.Forms.Button
        Me.DG = New System.Windows.Forms.DataGridView
        Me.LSearch = New System.Windows.Forms.Label
        Me.TSearch = New System.Windows.Forms.TextBox
        Me.MtDate = New Devy.Windows.DatePicker
        Me.LFamily = New System.Windows.Forms.Label
        Me.BtnClose = New System.Windows.Forms.Button
        Me.BtnDelete = New System.Windows.Forms.Button
        Me.BtnView = New System.Windows.Forms.Button
        Me.BtnOldVisit = New System.Windows.Forms.Button
        Me.BtnVisit = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.tsslAllCount = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel
        Me.tsslVisitCount = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel
        Me.tsslNotVisitCount = New System.Windows.Forms.ToolStripStatusLabel
        Me.Button3 = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox2.SuspendLayout()
        CType(Me.DG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.btnRef)
        Me.GroupBox2.Controls.Add(Me.DG)
        Me.GroupBox2.Controls.Add(Me.LSearch)
        Me.GroupBox2.Controls.Add(Me.TSearch)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 99)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(893, 393)
        Me.GroupBox2.TabIndex = 1238
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "نمایش"
        '
        'btnRef
        '
        Me.btnRef.Location = New System.Drawing.Point(6, 12)
        Me.btnRef.Name = "btnRef"
        Me.btnRef.Size = New System.Drawing.Size(121, 31)
        Me.btnRef.TabIndex = 1251
        Me.btnRef.Text = "به روز رسانی"
        Me.btnRef.UseVisualStyleBackColor = True
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
        Me.DG.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DG.Size = New System.Drawing.Size(879, 336)
        Me.DG.TabIndex = 101
        Me.DG.TabStop = False
        '
        'LSearch
        '
        Me.LSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LSearch.AutoSize = True
        Me.LSearch.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LSearch.Location = New System.Drawing.Point(772, 19)
        Me.LSearch.Name = "LSearch"
        Me.LSearch.Size = New System.Drawing.Size(101, 19)
        Me.LSearch.TabIndex = 100
        Me.LSearch.Text = "(F3)جستجو :"
        '
        'TSearch
        '
        Me.TSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TSearch.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSearch.Location = New System.Drawing.Point(455, 16)
        Me.TSearch.Name = "TSearch"
        Me.TSearch.Size = New System.Drawing.Size(311, 27)
        Me.TSearch.TabIndex = 10
        '
        'MtDate
        '
        Me.MtDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MtDate.BackColor = System.Drawing.SystemColors.Control
        Me.MtDate.Date = "1398/05/13"
        Me.MtDate.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.MtDate.Location = New System.Drawing.Point(704, 21)
        Me.MtDate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MtDate.MaximumSize = New System.Drawing.Size(300, 23)
        Me.MtDate.MinimumSize = New System.Drawing.Size(90, 23)
        Me.MtDate.Name = "MtDate"
        Me.MtDate.Size = New System.Drawing.Size(104, 23)
        Me.MtDate.TabIndex = 1244
        '
        'LFamily
        '
        Me.LFamily.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LFamily.AutoSize = True
        Me.LFamily.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LFamily.Location = New System.Drawing.Point(814, 24)
        Me.LFamily.Name = "LFamily"
        Me.LFamily.Size = New System.Drawing.Size(55, 13)
        Me.LFamily.TabIndex = 1243
        Me.LFamily.Text = "تاریخ ثبت :"
        '
        'BtnClose
        '
        Me.BtnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnClose.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.BtnClose.Image = Global.OphthalmologyMgmnt.My.Resources.Resources.Delete
        Me.BtnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnClose.Location = New System.Drawing.Point(20, 58)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(121, 35)
        Me.BtnClose.TabIndex = 1248
        Me.BtnClose.Text = "انصراف"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnDelete.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.Image = Global.OphthalmologyMgmnt.My.Resources.Resources.cut
        Me.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnDelete.Location = New System.Drawing.Point(147, 58)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(142, 35)
        Me.BtnDelete.TabIndex = 1249
        Me.BtnDelete.Text = "حذف"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnView
        '
        Me.BtnView.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnView.Location = New System.Drawing.Point(576, 20)
        Me.BtnView.Name = "BtnView"
        Me.BtnView.Size = New System.Drawing.Size(122, 27)
        Me.BtnView.TabIndex = 1250
        Me.BtnView.Text = "نمایش"
        Me.BtnView.UseVisualStyleBackColor = True
        '
        'BtnOldVisit
        '
        Me.BtnOldVisit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnOldVisit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOldVisit.Image = Global.OphthalmologyMgmnt.My.Resources.Resources.im
        Me.BtnOldVisit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnOldVisit.Location = New System.Drawing.Point(765, 58)
        Me.BtnOldVisit.Name = "BtnOldVisit"
        Me.BtnOldVisit.Size = New System.Drawing.Size(142, 35)
        Me.BtnOldVisit.TabIndex = 1252
        Me.BtnOldVisit.Text = "نسخه های قبلی"
        Me.BtnOldVisit.UseVisualStyleBackColor = True
        '
        'BtnVisit
        '
        Me.BtnVisit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnVisit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVisit.Image = Global.OphthalmologyMgmnt.My.Resources.Resources.im
        Me.BtnVisit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnVisit.Location = New System.Drawing.Point(617, 58)
        Me.BtnVisit.Name = "BtnVisit"
        Me.BtnVisit.Size = New System.Drawing.Size(142, 35)
        Me.BtnVisit.TabIndex = 1251
        Me.BtnVisit.Text = "نسخه قلم(F6)"
        Me.BtnVisit.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.OphthalmologyMgmnt.My.Resources.Resources.im
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(469, 58)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(142, 35)
        Me.Button1.TabIndex = 1251
        Me.Button1.Text = "نسخه متنی(F7)"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.BtnView)
        Me.GroupBox1.Controls.Add(Me.MtDate)
        Me.GroupBox1.Controls.Add(Me.LFamily)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(890, 54)
        Me.GroupBox1.TabIndex = 1253
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 13)
        Me.Label1.TabIndex = 1251
        Me.Label1.Text = "اطلاعات صفحه هر 5 ثانیه به روز می شود"
        Me.Label1.Visible = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.tsslAllCount, Me.ToolStripStatusLabel3, Me.tsslVisitCount, Me.ToolStripStatusLabel5, Me.tsslNotVisitCount})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 498)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(917, 22)
        Me.StatusStrip1.TabIndex = 1254
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.Navy
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(56, 17)
        Me.ToolStripStatusLabel1.Text = "تعداد کل :"
        '
        'tsslAllCount
        '
        Me.tsslAllCount.ForeColor = System.Drawing.Color.Red
        Me.tsslAllCount.Name = "tsslAllCount"
        Me.tsslAllCount.Size = New System.Drawing.Size(27, 17)
        Me.tsslAllCount.Text = "----"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.ForeColor = System.Drawing.Color.Navy
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(113, 17)
        Me.ToolStripStatusLabel3.Text = "تعداد ویزیت شده ها :"
        '
        'tsslVisitCount
        '
        Me.tsslVisitCount.ForeColor = System.Drawing.Color.Red
        Me.tsslVisitCount.Name = "tsslVisitCount"
        Me.tsslVisitCount.Size = New System.Drawing.Size(22, 17)
        Me.tsslVisitCount.Text = "---"
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.ForeColor = System.Drawing.Color.Navy
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(117, 17)
        Me.ToolStripStatusLabel5.Text = "تعداد ویزیت نشده ها :"
        '
        'tsslNotVisitCount
        '
        Me.tsslNotVisitCount.ForeColor = System.Drawing.Color.Red
        Me.tsslNotVisitCount.Name = "tsslNotVisitCount"
        Me.tsslNotVisitCount.Size = New System.Drawing.Size(22, 17)
        Me.tsslNotVisitCount.Text = "---"
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.Location = New System.Drawing.Point(312, 60)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(151, 35)
        Me.Button3.TabIndex = 1255
        Me.Button3.Text = "گفتگو"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 5000
        '
        'VisitList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnClose
        Me.ClientSize = New System.Drawing.Size(917, 520)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnOldVisit)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnVisit)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "VisitList"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "لیست اشخاص ویزیت"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DG As System.Windows.Forms.DataGridView
    Friend WithEvents LSearch As System.Windows.Forms.Label
    Friend WithEvents TSearch As System.Windows.Forms.TextBox
    Friend WithEvents MtDate As Devy.Windows.DatePicker
    Friend WithEvents LFamily As System.Windows.Forms.Label
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnView As System.Windows.Forms.Button
    Friend WithEvents BtnOldVisit As System.Windows.Forms.Button
    Friend WithEvents BtnVisit As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tsslAllCount As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tsslVisitCount As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tsslNotVisitCount As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btnRef As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
