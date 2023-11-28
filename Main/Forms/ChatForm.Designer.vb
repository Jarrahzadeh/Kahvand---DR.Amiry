Imports Ophthalmology.Controls.CustomControls
Imports Ophthalmology.Controls.CustomForm
Imports Ophthalmology.Controls.CustomForms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ChatForm
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPageGroupChat = New System.Windows.Forms.TabPage()
        Me.ChatControlGroup = New Ophthalmology.Controls.CustomControls.ChatControl()
        Me.TabPagePrivate1 = New System.Windows.Forms.TabPage()
        Me.ChatControlPrivate1 = New Ophthalmology.Controls.CustomControls.ChatControl()
        Me.TabPagePrivate2 = New System.Windows.Forms.TabPage()
        Me.ChatControlPrivate2 = New Ophthalmology.Controls.CustomControls.ChatControl()
        Me.TabControl1.SuspendLayout()
        Me.TabPageGroupChat.SuspendLayout()
        Me.TabPagePrivate1.SuspendLayout()
        Me.TabPagePrivate2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPageGroupChat)
        Me.TabControl1.Controls.Add(Me.TabPagePrivate1)
        Me.TabControl1.Controls.Add(Me.TabPagePrivate2)
        Me.TabControl1.Location = New System.Drawing.Point(13, 6)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.RightToLeftLayout = True
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(441, 458)
        Me.TabControl1.TabIndex = 2
        '
        'TabPageGroupChat
        '
        Me.TabPageGroupChat.Controls.Add(Me.ChatControlGroup)
        Me.TabPageGroupChat.Location = New System.Drawing.Point(4, 22)
        Me.TabPageGroupChat.Name = "TabPageGroupChat"
        Me.TabPageGroupChat.Padding = New System.Windows.Forms.Padding(5)
        Me.TabPageGroupChat.Size = New System.Drawing.Size(433, 432)
        Me.TabPageGroupChat.TabIndex = 0
        Me.TabPageGroupChat.Text = "گروهی"
        Me.TabPageGroupChat.UseVisualStyleBackColor = True
        '
        'ChatControlGroup
        '
        Me.ChatControlGroup.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChatControlGroup.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ChatControlGroup.Location = New System.Drawing.Point(8, 8)
        Me.ChatControlGroup.Name = "ChatControlGroup"
        Me.ChatControlGroup.Padding = New System.Windows.Forms.Padding(5)
        Me.ChatControlGroup.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChatControlGroup.Size = New System.Drawing.Size(417, 416)
        Me.ChatControlGroup.TabIndex = 0
        '
        'TabPagePrivate1
        '
        Me.TabPagePrivate1.Controls.Add(Me.ChatControlPrivate1)
        Me.TabPagePrivate1.Location = New System.Drawing.Point(4, 22)
        Me.TabPagePrivate1.Name = "TabPagePrivate1"
        Me.TabPagePrivate1.Padding = New System.Windows.Forms.Padding(5)
        Me.TabPagePrivate1.Size = New System.Drawing.Size(433, 432)
        Me.TabPagePrivate1.TabIndex = 1
        Me.TabPagePrivate1.Text = "TabPage2"
        Me.TabPagePrivate1.UseVisualStyleBackColor = True
        '
        'ChatControlPrivate1
        '
        Me.ChatControlPrivate1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChatControlPrivate1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ChatControlPrivate1.Location = New System.Drawing.Point(8, 8)
        Me.ChatControlPrivate1.Name = "ChatControlPrivate1"
        Me.ChatControlPrivate1.Padding = New System.Windows.Forms.Padding(5)
        Me.ChatControlPrivate1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChatControlPrivate1.Size = New System.Drawing.Size(417, 416)
        Me.ChatControlPrivate1.TabIndex = 0
        '
        'TabPagePrivate2
        '
        Me.TabPagePrivate2.Controls.Add(Me.ChatControlPrivate2)
        Me.TabPagePrivate2.Location = New System.Drawing.Point(4, 22)
        Me.TabPagePrivate2.Name = "TabPagePrivate2"
        Me.TabPagePrivate2.Padding = New System.Windows.Forms.Padding(5)
        Me.TabPagePrivate2.Size = New System.Drawing.Size(433, 432)
        Me.TabPagePrivate2.TabIndex = 2
        Me.TabPagePrivate2.Text = "TabPage1"
        Me.TabPagePrivate2.UseVisualStyleBackColor = True
        '
        'ChatControlPrivate2
        '
        Me.ChatControlPrivate2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChatControlPrivate2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ChatControlPrivate2.Location = New System.Drawing.Point(8, 8)
        Me.ChatControlPrivate2.Name = "ChatControlPrivate2"
        Me.ChatControlPrivate2.Padding = New System.Windows.Forms.Padding(5)
        Me.ChatControlPrivate2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChatControlPrivate2.Size = New System.Drawing.Size(417, 416)
        Me.ChatControlPrivate2.TabIndex = 0
        '
        'ChatForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(467, 477)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.KeyPreview = True
        Me.Name = "ChatForm"
        Me.Padding = New System.Windows.Forms.Padding(10, 3, 10, 10)
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "گفتگو"
        Me.TopMost = True
        Me.TabControl1.ResumeLayout(False)
        Me.TabPageGroupChat.ResumeLayout(False)
        Me.TabPagePrivate1.ResumeLayout(False)
        Me.TabPagePrivate2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabPageGroupChat As TabPage
    Friend WithEvents TabPagePrivate1 As TabPage
    Friend WithEvents TabPagePrivate2 As TabPage
    Friend WithEvents ChatControlPrivate1 As ChatControl
    Friend WithEvents ChatControlPrivate2 As ChatControl
    Friend WithEvents ChatControlGroup As ChatControl
    Private WithEvents TabControl1 As TabControl
End Class
