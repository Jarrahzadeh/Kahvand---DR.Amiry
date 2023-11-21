Imports Ophthalmology.Controls.CustomForms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Customer2VisitList
    Inherits CustomizableFormBase

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Customer2VisitList))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtType = New System.Windows.Forms.TextBox()
        Me.txtDrName = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MtTime = New System.Windows.Forms.MaskedTextBox()
        Me.LblCustomer = New System.Windows.Forms.Label()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.MtDate = New Devy.Windows.DatePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LFamily = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CbCustomer = New System.Windows.Forms.ComboBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.DG = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SendToDocterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnView = New System.Windows.Forms.Button()
        Me.DatePicker1 = New Devy.Windows.DatePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.DG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtType)
        Me.GroupBox1.Controls.Add(Me.txtDrName)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.txtPrice)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.MtTime)
        Me.GroupBox1.Controls.Add(Me.LblCustomer)
        Me.GroupBox1.Controls.Add(Me.BtnClose)
        Me.GroupBox1.Controls.Add(Me.BtnDelete)
        Me.GroupBox1.Controls.Add(Me.BtnSave)
        Me.GroupBox1.Controls.Add(Me.MtDate)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.LFamily)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.CbCustomer)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'txtType
        '
        resources.ApplyResources(Me.txtType, "txtType")
        Me.txtType.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtType.Name = "txtType"
        Me.txtType.ReadOnly = True
        Me.txtType.TabStop = False
        '
        'txtDrName
        '
        resources.ApplyResources(Me.txtDrName, "txtDrName")
        Me.txtDrName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDrName.Name = "txtDrName"
        Me.txtDrName.ReadOnly = True
        Me.txtDrName.TabStop = False
        '
        'Button1
        '
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtPrice
        '
        resources.ApplyResources(Me.txtPrice, "txtPrice")
        Me.txtPrice.Name = "txtPrice"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'MtTime
        '
        resources.ApplyResources(Me.MtTime, "MtTime")
        Me.MtTime.Name = "MtTime"
        Me.MtTime.ValidatingType = GetType(Date)
        '
        'LblCustomer
        '
        resources.ApplyResources(Me.LblCustomer, "LblCustomer")
        Me.LblCustomer.Name = "LblCustomer"
        '
        'BtnClose
        '
        resources.ApplyResources(Me.BtnClose, "BtnClose")
        Me.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnClose.Image = Global.Ophthalmology.Main.My.Resources.Resources.Delete
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        resources.ApplyResources(Me.BtnDelete, "BtnDelete")
        Me.BtnDelete.Image = Global.Ophthalmology.Main.My.Resources.Resources.cut
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        resources.ApplyResources(Me.BtnSave, "BtnSave")
        Me.BtnSave.Image = Global.Ophthalmology.Main.My.Resources.Resources.Add_h
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'MtDate
        '
        resources.ApplyResources(Me.MtDate, "MtDate")
        Me.MtDate.BackColor = System.Drawing.SystemColors.Control
        Me.MtDate.Date = "1402/08/20"
        Me.MtDate.Name = "MtDate"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'LFamily
        '
        resources.ApplyResources(Me.LFamily, "LFamily")
        Me.LFamily.Name = "LFamily"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'CbCustomer
        '
        resources.ApplyResources(Me.CbCustomer, "CbCustomer")
        Me.CbCustomer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CbCustomer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CbCustomer.FormattingEnabled = True
        Me.CbCustomer.Name = "CbCustomer"
        Me.ToolTip1.SetToolTip(Me.CbCustomer, resources.GetString("CbCustomer.ToolTip"))
        '
        'txtId
        '
        resources.ApplyResources(Me.txtId, "txtId")
        Me.txtId.Name = "txtId"
        Me.txtId.ReadOnly = True
        '
        'DG
        '
        Me.DG.AllowUserToAddRows = False
        Me.DG.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan
        Me.DG.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        resources.ApplyResources(Me.DG, "DG")
        Me.DG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG.ContextMenuStrip = Me.ContextMenuStrip1
        Me.DG.Name = "DG"
        Me.DG.ReadOnly = True
        Me.DG.RowHeadersVisible = False
        Me.DG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DG.TabStop = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SendToDocterToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        resources.ApplyResources(Me.ContextMenuStrip1, "ContextMenuStrip1")
        '
        'SendToDocterToolStripMenuItem
        '
        resources.ApplyResources(Me.SendToDocterToolStripMenuItem, "SendToDocterToolStripMenuItem")
        Me.SendToDocterToolStripMenuItem.Name = "SendToDocterToolStripMenuItem"
        '
        'BtnView
        '
        resources.ApplyResources(Me.BtnView, "BtnView")
        Me.BtnView.Name = "BtnView"
        Me.BtnView.TabStop = False
        Me.BtnView.UseVisualStyleBackColor = True
        '
        'DatePicker1
        '
        resources.ApplyResources(Me.DatePicker1, "DatePicker1")
        Me.DatePicker1.BackColor = System.Drawing.SystemColors.Control
        Me.DatePicker1.Date = "1402/08/20"
        Me.DatePicker1.Name = "DatePicker1"
        Me.DatePicker1.TabStop = False
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'Customer2VisitList
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnClose
        Me.Controls.Add(Me.BtnView)
        Me.Controls.Add(Me.DatePicker1)
        Me.Controls.Add(Me.DG)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.KeyPreview = True
        Me.Name = "Customer2VisitList"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents CbCustomer As System.Windows.Forms.ComboBox
    Private WithEvents MtDate As Devy.Windows.DatePicker
    Private WithEvents LFamily As System.Windows.Forms.Label
    Private WithEvents BtnSave As System.Windows.Forms.Button
    Private WithEvents BtnClose As System.Windows.Forms.Button
    Private WithEvents LblCustomer As System.Windows.Forms.Label
    Private WithEvents MtTime As System.Windows.Forms.MaskedTextBox
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents DG As System.Windows.Forms.DataGridView
    Private WithEvents txtPrice As System.Windows.Forms.TextBox
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents txtId As System.Windows.Forms.TextBox
    Private WithEvents Button1 As System.Windows.Forms.Button
    Private WithEvents BtnView As System.Windows.Forms.Button
    Private WithEvents DatePicker1 As Devy.Windows.DatePicker
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents BtnDelete As System.Windows.Forms.Button
    Private WithEvents Label5 As System.Windows.Forms.Label
    Private WithEvents txtDrName As System.Windows.Forms.TextBox
    Private WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Private WithEvents SendToDocterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents Label6 As System.Windows.Forms.Label
    Private WithEvents txtType As System.Windows.Forms.TextBox
    Private WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
