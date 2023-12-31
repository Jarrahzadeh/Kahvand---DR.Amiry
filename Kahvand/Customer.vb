Public Class Customer


    Sub ShowGrid(Optional ByVal St As String = "")

        Dim DtDg As New DataTable
        Dim AdoDaDg As New OleDb.OleDbDataAdapter("select id as کد , Name as نام , Family as فامیلی, Tel as تلفن, NameFather as [نام پدر] , DateSave as تاریخ From Customer where DrId = " + DrId.ToString() + St + " order by id desc", AdoCon)
        AdoDaDg.Fill(DtDg)
        DG.DataSource = DtDg
        DG.Columns(0).Width = 50

    End Sub
    Sub ShowData(ByVal st As String)

        Dim Cmd As New OleDb.OleDbCommand("select * from Customer Where id = " + st, AdoCon)
        Dim Dr As OleDb.OleDbDataReader
        Dr = Cmd.ExecuteReader
        Dr.Read()

        TCode.Text = Dr("id").ToString
        TTell.Text = Dr("tel").ToString
        Tfamily.Text = Dr("Family").ToString
        TName.Text = Dr("Name").ToString
        TNameFather.Text = Dr("NameFather").ToString
        TReason.Text = Dr("Reason").ToString
        TDis.Text = Dr("Dis").ToString
        TAge.Text = Dr("Age").ToString
        MtDate.Text = Dr("DateSave").ToString
        cbType.SelectedValue = Val(Dr("IdTypePatient").ToString())
        txtAddress.Text = Dr("Address").ToString


        Dim TempSt As String = Dr("EyeLeft").ToString

        If TempSt <> "" Then
            ChLeft.Checked = True
            MtLeft.Text = Dr("EyeLeft").ToString
        Else
            ChLeft.Checked = False
            MtLeft.Enabled = False
        End If

        TempSt = Dr("EyeRight").ToString
        If TempSt <> "" Then
            ChRight.Checked = True
            MtRight.Text = Dr("EyeRight").ToString
        Else
            ChRight.Checked = False
            MtRight.Enabled = False
        End If

        Dr.Close()

        ActiveFrm()

    End Sub
    Private Sub ActiveFrm()

        'ShowGrid()
        B2.Enabled = True
        B3.Enabled = True
        BtnVisit.Enabled = True
        BtnOldVisit.Enabled = True
        BtnVisitText.Enabled = True
        Button1.Text = "(F2)اضافه"

    End Sub
    Sub ResetForm()


        Reset(Gb)
        ShowGrid()
        B2.Enabled = False
        B3.Enabled = False
        BtnVisit.Enabled = False
        BtnOldVisit.Enabled = False
        BtnVisitText.Enabled = False
        TName.Focus()
        MtDate.Text = DateToday
        Button1.Text = "ثبت(F2)"
        ChLeft.Checked = False
        ChRight.Checked = False

    End Sub
    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If Button1.Text = "ثبت(F2)" Then
            If TName.Text = "" Or Tfamily.Text = "" Then MsgBox(".فیلد نام و نام خانوادگی را باید حتما  پر کنید", MsgBoxStyle.OkOnly, "Nilgon") : Exit Sub

            Dim CmdEx As New OleDb.OleDbCommand("Select Name,Family From Customer where Name = '" + TName.Text + "' and Family = '" + Tfamily.Text + "'", AdoCon)
            Dim st As String
            Try
                st = CmdEx.ExecuteScalar().ToString
            Catch ex As Exception
                st = ""
            End Try

            If st <> "" Then
                If MsgBox("نام و نام خانوادگی تکراری می باشد . آیا ثبت می کنید ؟", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "تکراری") = MsgBoxResult.No Then Exit Sub
            End If
            Dim Cmd As New OleDb.OleDbCommand("insert into Customer(Name,Family,Tel,NameFather,Reason,Dis,Age,EyeLeft,EyeRight,DateSave,DrId,IdTypePatient,Address)" & _
            " Values(@Name,@Family,@Tel,@NameFather,@Reason,@Dis,@Age,@EyeLeft,@EyeRight,@DateSave,@DrId,@IdTypePatient,@Address)", AdoCon)

            Cmd.Parameters.Add("@Name", OleDb.OleDbType.VarChar).Value = TName.Text
            Cmd.Parameters.Add("@Family", OleDb.OleDbType.VarChar).Value = Tfamily.Text
            Cmd.Parameters.Add("@Tel", OleDb.OleDbType.VarChar).Value = TTell.Text
            Cmd.Parameters.Add("@NameFather", OleDb.OleDbType.VarChar).Value = TNameFather.Text
            Cmd.Parameters.Add("@Reason", OleDb.OleDbType.VarChar).Value = TReason.Text
            Cmd.Parameters.Add("@Dis", OleDb.OleDbType.VarChar).Value = TDis.Text
            Cmd.Parameters.Add("@Age", OleDb.OleDbType.VarChar).Value = TAge.Text
            If ChLeft.Checked Then
                Cmd.Parameters.Add("@EyeLeft", OleDb.OleDbType.VarChar, 12).Value = MtLeft.Text
            Else
                Cmd.Parameters.Add("@EyeLeft", OleDb.OleDbType.VarChar, 12).Value = ""
            End If

            If ChRight.Checked Then
                Cmd.Parameters.Add("@EyeRight", OleDb.OleDbType.VarChar, 12).Value = MtRight.Text
            Else
                Cmd.Parameters.Add("@EyeRight", OleDb.OleDbType.VarChar, 12).Value = ""
            End If

            Cmd.Parameters.Add("@DateSave", OleDb.OleDbType.VarChar, 12).Value = MtDate.Text
            Cmd.Parameters.Add("@DrId", OleDb.OleDbType.Integer).Value = DrId
            Cmd.Parameters.Add("@IdTypePatient", OleDb.OleDbType.Integer).Value = Val(cbType.SelectedValue)
            Cmd.Parameters.Add("@Address", OleDb.OleDbType.VarChar).Value = txtAddress.Text

            Cmd.ExecuteNonQuery()

            ResetForm()
            'ActiveFrm()

            Dim Cmdx As New OleDb.OleDbCommand("Select Max(id) From Customer", AdoCon)
            ShowData(Cmdx.ExecuteScalar().ToString)

        Else
            ResetForm()
        End If


    End Sub

    Private Sub B3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B3.Click
        If MsgBox("ایا از حذف اطلاعات جاری اطمینان دارید ؟", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "خذف") = MsgBoxResult.Yes Then
            Dim Cmd As New OleDb.OleDbCommand("Delete From Customer Where id = " + TCode.Text, AdoCon)
            Cmd.ExecuteNonQuery()
            MsgBox("اطلاعات جاری حذف شد")
            ResetForm()
        End If
    End Sub

    Private Sub Customer_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.SizeCustomer = Me.Size
        My.Settings.Save()

    End Sub

    Private Sub Person_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.SelectNextControl(Me.ActiveControl, True, False, True, True)
            e.SuppressKeyPress = True
        ElseIf e.KeyCode = Keys.F2 Then
            Button1_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F3 Then
            TSearch.Focus()
        ElseIf e.KeyCode = Keys.F9 And B2.Enabled = True Then
            B2_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F6 And BtnVisit.Enabled = True Then
            BVisit_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F7 And BtnVisitText.Enabled = True Then
            BtnVisitText_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F5 And BtnVisitText.Enabled = True Then
            TSBCustomer2VisitList_Click(Nothing, Nothing)
        End If


    End Sub

    Private Sub Person_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblDrName.Text = DrName
        ResetForm()

        Me.Size = My.Settings.SizeCustomer

        Me.Left = (My.Computer.Screen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (My.Computer.Screen.WorkingArea.Height - Me.Height) / 2

        'Dim Cmd As New OleDb.OleDbCommand("select count(*) from Customer", AdoCon)
        'If Val(Cmd.ExecuteScalar.ToString) = 5000 Then
        '    MsgBox("Error For Register")
        '    End
        'End If

        ResetForm()

        DG.Font = My.Settings.Fontsize

        bindCombo()


    End Sub

    Private Sub bindCombo()
        Try

            Dim Ado As New OleDb.OleDbDataAdapter("Select id, Name  From TypePatient", AdoCon)
            Dim Dt As New DataTable
            Ado.Fill(Dt)
            cbType.DataSource = Dt
            cbType.ValueMember = "Id"
            cbType.DisplayMember = "Name"

        Catch ex As Exception

        End Try
    End Sub

    Private Sub B2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B2.Click

        Dim Cmd As New OleDb.OleDbCommand("Update Customer SET [Name] = @Name ,Family = @Family, tel = @Tel, NameFather = @NameFather, Reason =@Reason , Age = @Age , Dis =@Dis ,EyeLeft=@EyeLeft ,EyeRight=@EyeRight , DateSave=@DateSave ,DrId=@DrId,IdTypePatient=@IdTypePatient,Address=@Address Where id = " + TCode.Text, AdoCon)

        Cmd.Parameters.Add("@Name", OleDb.OleDbType.VarChar).Value = TName.Text
        Cmd.Parameters.Add("@Family", OleDb.OleDbType.VarChar).Value = Tfamily.Text
        Cmd.Parameters.Add("@Tel", OleDb.OleDbType.VarChar).Value = TTell.Text
        Cmd.Parameters.Add("@NameFather", OleDb.OleDbType.VarChar).Value = TNameFather.Text
        Cmd.Parameters.Add("@Reason", OleDb.OleDbType.VarChar).Value = TReason.Text
        Cmd.Parameters.Add("@Age", OleDb.OleDbType.VarChar).Value = TAge.Text
        Cmd.Parameters.Add("@Dis", OleDb.OleDbType.VarChar).Value = TDis.Text
        ' Cmd.Parameters.Add("@DrId", OleDb.OleDbType.Integer).Value = DrId


        If ChLeft.Checked Then
            Cmd.Parameters.Add("@EyeLeft", OleDb.OleDbType.VarChar, 12).Value = MtLeft.Text
        Else
            Cmd.Parameters.Add("@EyeLeft", OleDb.OleDbType.VarChar, 12).Value = ""
        End If

        If ChRight.Checked Then
            Cmd.Parameters.Add("@EyeRight", OleDb.OleDbType.VarChar, 12).Value = MtRight.Text
        Else
            Cmd.Parameters.Add("@EyeRight", OleDb.OleDbType.VarChar, 12).Value = ""
        End If
        Cmd.Parameters.Add("@DateSave", OleDb.OleDbType.VarChar).Value = MtDate.Text
        Cmd.Parameters.Add("@DrId", OleDb.OleDbType.Integer).Value = DrId
        Cmd.Parameters.Add("@IdTypePatient", OleDb.OleDbType.Integer).Value = Val(cbType.SelectedValue)
        Cmd.Parameters.Add("@Address", OleDb.OleDbType.VarChar).Value = txtAddress.Text

        Cmd.ExecuteNonQuery()

        ResetForm()

        'ShowData()

    End Sub

    Private Sub DG_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG.CellClick
        ShowData(DG.CurrentRow.Cells(0).Value.ToString)
    End Sub

    Private Sub DG_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG.CellContentClick


    End Sub

    Private Sub LNational_Num_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LNational_Num.Click

    End Sub

    Private Sub TAdress_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TNameFather.TextChanged

    End Sub

    Private Sub BVisit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVisit.Click

        Dim Frm As New Visit
        Frm.TFk_Customer.Text = TCode.Text
        Frm.TName.Text = Tfamily.Text + " " + TName.Text
        Frm.ShowDialog()

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Gb.Enter

    End Sub

    Private Sub ChLeft_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChLeft.CheckedChanged
        MtLeft.Enabled = ChLeft.Checked

    End Sub

    Private Sub ChRight_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChRight.CheckedChanged
        MtRight.Enabled = ChRight.Checked
    End Sub

    Private Sub TSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TSearch.KeyDown

    End Sub

    Private Sub TSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSearch.TextChanged

        If RbFamily.Checked Then
            ShowGrid(" and Family LIKE '" & TSearch.Text & "%'")
        ElseIf RbTel.Checked Then
            ShowGrid(" and Tel LIKE '" & TSearch.Text & "%'")
        ElseIf RbDate.Checked Then
            ShowGrid(" and DateSave LIKE '" & TSearch.Text & "%'")
        ElseIf RbCode.Checked Then
            ShowGrid(" and Id = " & TSearch.Text)
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOldVisit.Click
        Dim Frm As New OldVisit
        Frm.TFk_Customer.Text = TCode.Text
        Frm.TName.Text = Tfamily.Text + " " + TName.Text
        Frm.ShowDialog()

    End Sub

    Private Sub Tfamily_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Tfamily.KeyDown

    End Sub

    Private Sub Tfamily_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Tfamily.KeyUp
        TSearch.Text = Tfamily.Text
    End Sub

    Private Sub Tfamily_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tfamily.TextChanged

    End Sub

    Private Sub BtnVisitText_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVisitText.Click
        Dim Frm As New Editor
        Frm.TFk_Customer.Text = TCode.Text
        Frm.TName.Text = Tfamily.Text + " " + TName.Text
        Frm.ShowDialog()

    End Sub

    

    Private Sub Customer_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged

    End Sub

    Private Sub TSBVisit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSBVisit.Click
        Dim frm As New VisitList
        'frm.LblCustomer.Text = TCode.Text
        frm.ShowDialog()
        If Val(Code_Customer) <> 0 Then
            ShowData(Val(Code_Customer))
        End If
    End Sub

    Private Sub TSBCustomer2VisitList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSBCustomer2VisitList.Click

        Dim frm As New Customer2VisitList
        frm.LblCustomer.Text = TCode.Text
        frm.ShowDialog()

    End Sub

    Private Sub DG_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DG.KeyDown
        Try
            DG_CellClick(Nothing, Nothing)

        Catch ex As Exception

        End Try

    End Sub

    Private Sub DG_RowStateChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowStateChangedEventArgs) Handles DG.RowStateChanged
        'If DG.Rows.Count = 0 Then Exit Sub
        'Try
        '    Me.Text = DG.CurrentRow.Index

        'Catch ex As Exceptionf

        'End Try
    End Sub

    Private Sub DG_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DG.SelectionChanged

        ' Me.Text = DG.CurrentRow.Index
    End Sub

    Private Sub DG_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG.CellDoubleClick
        BtnVisitText_Click(Nothing, Nothing)
    End Sub

    Private Sub Customer_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Dim c As New System.Globalization.CultureInfo("fa-IR")
        InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(c)
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click

        Dim xx As Single = 0

        xx = DG.Font.Size + 0.5

        DG.Font = New Font(DG.Font.Name, xx, DG.Font.Style)
        My.Settings.Fontsize = DG.Font
        My.Settings.Save()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click

        Dim xx As Single = 0

        xx = DG.Font.Size - 0.5

        DG.Font = New Font(DG.Font.Name, xx, DG.Font.Style)
        My.Settings.Fontsize = DG.Font
        My.Settings.Save()
    End Sub

    Private Sub Customer_StyleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.StyleChanged

    End Sub

 
    Private Sub btnBrows_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrows.Click
        Dim frm As New BaseData
        frm.Tag = "TypePatient"
        frm.ShowDialog()
        bindCombo()
    End Sub


    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ShowGrid()

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ShowGrid()

    End Sub
End Class