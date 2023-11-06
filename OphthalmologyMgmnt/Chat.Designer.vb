<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Chat
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lstMSG = New System.Windows.Forms.ListBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnBrows = New System.Windows.Forms.Button
        Me.cbType = New System.Windows.Forms.ComboBox
        Me.BtnSend = New System.Windows.Forms.Button
        Me.TxtText = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lstMSG)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(578, 362)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "پیام"
        '
        'lstMSG
        '
        Me.lstMSG.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstMSG.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lstMSG.FormattingEnabled = True
        Me.lstMSG.ItemHeight = 19
        Me.lstMSG.Location = New System.Drawing.Point(3, 17)
        Me.lstMSG.Name = "lstMSG"
        Me.lstMSG.Size = New System.Drawing.Size(572, 327)
        Me.lstMSG.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnBrows)
        Me.GroupBox2.Controls.Add(Me.cbType)
        Me.GroupBox2.Controls.Add(Me.BtnSend)
        Me.GroupBox2.Controls.Add(Me.TxtText)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox2.Location = New System.Drawing.Point(0, 368)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(578, 103)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'btnBrows
        '
        Me.btnBrows.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBrows.Location = New System.Drawing.Point(96, 11)
        Me.btnBrows.Name = "btnBrows"
        Me.btnBrows.Size = New System.Drawing.Size(33, 25)
        Me.btnBrows.TabIndex = 1246
        Me.btnBrows.Text = "..."
        Me.btnBrows.UseVisualStyleBackColor = True
        '
        'cbType
        '
        Me.cbType.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbType.FormattingEnabled = True
        Me.cbType.Location = New System.Drawing.Point(135, 15)
        Me.cbType.Name = "cbType"
        Me.cbType.Size = New System.Drawing.Size(437, 21)
        Me.cbType.TabIndex = 1245
        '
        'BtnSend
        '
        Me.BtnSend.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnSend.Location = New System.Drawing.Point(6, 46)
        Me.BtnSend.Name = "BtnSend"
        Me.BtnSend.Size = New System.Drawing.Size(123, 50)
        Me.BtnSend.TabIndex = 1
        Me.BtnSend.Text = "ارسال"
        Me.BtnSend.UseVisualStyleBackColor = True
        '
        'TxtText
        '
        Me.TxtText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtText.Location = New System.Drawing.Point(135, 46)
        Me.TxtText.Multiline = True
        Me.TxtText.Name = "TxtText"
        Me.TxtText.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtText.Size = New System.Drawing.Size(437, 50)
        Me.TxtText.TabIndex = 0
        '
        'Chat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(578, 471)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.KeyPreview = True
        Me.Name = "Chat"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = "گفتگو"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lstMSG As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnSend As System.Windows.Forms.Button
    Friend WithEvents TxtText As System.Windows.Forms.TextBox
    Friend WithEvents btnBrows As System.Windows.Forms.Button
    Friend WithEvents cbType As System.Windows.Forms.ComboBox
End Class
