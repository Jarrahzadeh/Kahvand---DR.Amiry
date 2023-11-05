<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RptVisit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RptVisit))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Dg = New Janus.Windows.GridEX.GridEX
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ChDate = New System.Windows.Forms.CheckBox
        Me.txtDateTo = New Devy.Windows.DatePicker
        Me.txtDateFrom = New Devy.Windows.DatePicker
        Me.BtnView = New System.Windows.Forms.Button
        Me.BtnClose = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.RBAmar = New System.Windows.Forms.RadioButton
        Me.RbAllVisit = New System.Windows.Forms.RadioButton
        Me.RbVisit = New System.Windows.Forms.RadioButton
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.TSSLTitel = New System.Windows.Forms.ToolStripStatusLabel
        Me.TSSLSummery = New System.Windows.Forms.ToolStripStatusLabel
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.نمایشمشخصاتToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BtnDetial = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.Dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Dg)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 105)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(893, 401)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Dg
        '
        Me.Dg.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.Dg.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Dg.BuiltInTextsData = resources.GetString("Dg.BuiltInTextsData")
        Me.Dg.ColumnAutoResize = True
        Me.Dg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dg.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.Dg.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.Dg.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Dg.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Dg.Location = New System.Drawing.Point(3, 17)
        Me.Dg.Name = "Dg"
        Me.Dg.RecordNavigator = True
        Me.Dg.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.Dg.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.Dg.Size = New System.Drawing.Size(887, 381)
        Me.Dg.TabIndex = 24
        Me.Dg.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.Dg.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.ChDate)
        Me.GroupBox3.Controls.Add(Me.txtDateTo)
        Me.GroupBox3.Controls.Add(Me.txtDateFrom)
        Me.GroupBox3.Location = New System.Drawing.Point(680, 17)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(202, 74)
        Me.GroupBox3.TabIndex = 628
        Me.GroupBox3.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(126, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "تا تاریخ :"
        '
        'ChDate
        '
        Me.ChDate.AutoSize = True
        Me.ChDate.Location = New System.Drawing.Point(126, 19)
        Me.ChDate.Name = "ChDate"
        Me.ChDate.Size = New System.Drawing.Size(64, 17)
        Me.ChDate.TabIndex = 8
        Me.ChDate.Text = "از تاریخ :"
        Me.ChDate.UseVisualStyleBackColor = True
        '
        'txtDateTo
        '
        Me.txtDateTo.BackColor = System.Drawing.SystemColors.Control
        Me.txtDateTo.Date = "1391/03/27"
        Me.txtDateTo.Enabled = False
        Me.txtDateTo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtDateTo.Location = New System.Drawing.Point(19, 45)
        Me.txtDateTo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDateTo.MaximumSize = New System.Drawing.Size(300, 23)
        Me.txtDateTo.MinimumSize = New System.Drawing.Size(90, 23)
        Me.txtDateTo.Name = "txtDateTo"
        Me.txtDateTo.Size = New System.Drawing.Size(101, 23)
        Me.txtDateTo.TabIndex = 7
        '
        'txtDateFrom
        '
        Me.txtDateFrom.BackColor = System.Drawing.SystemColors.Control
        Me.txtDateFrom.Date = "1391/03/27"
        Me.txtDateFrom.Enabled = False
        Me.txtDateFrom.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtDateFrom.Location = New System.Drawing.Point(19, 14)
        Me.txtDateFrom.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDateFrom.MaximumSize = New System.Drawing.Size(300, 23)
        Me.txtDateFrom.MinimumSize = New System.Drawing.Size(90, 23)
        Me.txtDateFrom.Name = "txtDateFrom"
        Me.txtDateFrom.Size = New System.Drawing.Size(101, 23)
        Me.txtDateFrom.TabIndex = 6
        '
        'BtnView
        '
        Me.BtnView.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnView.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnView.Image = Global.OphthalmologyMgmnt.My.Resources.Resources.s
        Me.BtnView.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnView.Location = New System.Drawing.Point(222, 62)
        Me.BtnView.Name = "BtnView"
        Me.BtnView.Size = New System.Drawing.Size(99, 35)
        Me.BtnView.TabIndex = 1252
        Me.BtnView.Text = "نمایش"
        Me.BtnView.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnClose.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.BtnClose.Image = Global.OphthalmologyMgmnt.My.Resources.Resources.Delete
        Me.BtnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnClose.Location = New System.Drawing.Point(12, 62)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(99, 35)
        Me.BtnClose.TabIndex = 1253
        Me.BtnClose.Text = "انصراف"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RBAmar)
        Me.GroupBox2.Controls.Add(Me.RbAllVisit)
        Me.GroupBox2.Controls.Add(Me.RbVisit)
        Me.GroupBox2.Controls.Add(Me.BtnClose)
        Me.GroupBox2.Controls.Add(Me.BtnDetial)
        Me.GroupBox2.Controls.Add(Me.BtnView)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(893, 105)
        Me.GroupBox2.TabIndex = 1254
        Me.GroupBox2.TabStop = False
        '
        'RBAmar
        '
        Me.RBAmar.AutoSize = True
        Me.RBAmar.Location = New System.Drawing.Point(488, 64)
        Me.RBAmar.Name = "RBAmar"
        Me.RBAmar.Size = New System.Drawing.Size(91, 17)
        Me.RBAmar.TabIndex = 1254
        Me.RBAmar.Text = "اطلاعات آماری"
        Me.RBAmar.UseVisualStyleBackColor = True
        '
        'RbAllVisit
        '
        Me.RbAllVisit.AutoSize = True
        Me.RbAllVisit.Checked = True
        Me.RbAllVisit.Location = New System.Drawing.Point(413, 41)
        Me.RbAllVisit.Name = "RbAllVisit"
        Me.RbAllVisit.Size = New System.Drawing.Size(166, 17)
        Me.RbAllVisit.TabIndex = 1254
        Me.RbAllVisit.TabStop = True
        Me.RbAllVisit.Text = "لیست همه بیماران ویزیت شده"
        Me.RbAllVisit.UseVisualStyleBackColor = True
        '
        'RbVisit
        '
        Me.RbVisit.AutoSize = True
        Me.RbVisit.Checked = True
        Me.RbVisit.Location = New System.Drawing.Point(437, 17)
        Me.RbVisit.Name = "RbVisit"
        Me.RbVisit.Size = New System.Drawing.Size(142, 17)
        Me.RbVisit.TabIndex = 1254
        Me.RbVisit.TabStop = True
        Me.RbVisit.Text = "لیست بیماران ویزیت شده"
        Me.RbVisit.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSSLTitel, Me.TSSLSummery})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 506)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(893, 22)
        Me.StatusStrip1.TabIndex = 1255
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'TSSLTitel
        '
        Me.TSSLTitel.ForeColor = System.Drawing.Color.Red
        Me.TSSLTitel.Name = "TSSLTitel"
        Me.TSSLTitel.Size = New System.Drawing.Size(22, 17)
        Me.TSSLTitel.Text = "---"
        '
        'TSSLSummery
        '
        Me.TSSLSummery.ForeColor = System.Drawing.Color.Blue
        Me.TSSLSummery.Name = "TSSLSummery"
        Me.TSSLSummery.Size = New System.Drawing.Size(27, 17)
        Me.TSSLSummery.Text = "----"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.نمایشمشخصاتToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(147, 26)
        '
        'نمایشمشخصاتToolStripMenuItem
        '
        Me.نمایشمشخصاتToolStripMenuItem.Name = "نمایشمشخصاتToolStripMenuItem"
        Me.نمایشمشخصاتToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.نمایشمشخصاتToolStripMenuItem.Text = "نمایش مشخصات"
        '
        'BtnDetial
        '
        Me.BtnDetial.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnDetial.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDetial.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnDetial.Location = New System.Drawing.Point(117, 64)
        Me.BtnDetial.Name = "BtnDetial"
        Me.BtnDetial.Size = New System.Drawing.Size(99, 35)
        Me.BtnDetial.TabIndex = 1252
        Me.BtnDetial.Text = "جزییات"
        Me.BtnDetial.UseVisualStyleBackColor = True
        '
        'RptVisit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnClose
        Me.ClientSize = New System.Drawing.Size(893, 528)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Name = "RptVisit"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RptVisit"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.Dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Public WithEvents Dg As Janus.Windows.GridEX.GridEX
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ChDate As System.Windows.Forms.CheckBox
    Friend WithEvents txtDateTo As Devy.Windows.DatePicker
    Friend WithEvents txtDateFrom As Devy.Windows.DatePicker
    Friend WithEvents BtnView As System.Windows.Forms.Button
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RBAmar As System.Windows.Forms.RadioButton
    Friend WithEvents RbVisit As System.Windows.Forms.RadioButton
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents TSSLTitel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TSSLSummery As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents RbAllVisit As System.Windows.Forms.RadioButton
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents نمایشمشخصاتToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BtnDetial As System.Windows.Forms.Button
End Class
