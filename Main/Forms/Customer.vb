Imports System.Globalization
Imports Ophthalmology.Utility.Helpers

Public Class Customer
    Sub ShowGrid(Optional filter As String = "")

        Dim fields = "id as کد, Name as نام, Family as فامیلی, Tel as تلفن, NameFather as [نام پدر], DateSave as تاریخ"
        Dim where As New List(Of Tuple(Of String, Type, Object, String))
        where.Add(New Tuple(Of String, Type, Object, String)(Constants.DrIdFieldName, String.Empty.GetType(), DrId, String.Empty))
        Dim dataTable As DataTable = DatabaseHelper.Select(Constants.CustomerTableName, fields, where)
        dataTable.DefaultView.Sort = "کد DESC"

        If Not String.IsNullOrWhiteSpace(filter) Then
            dataTable.DefaultView.RowFilter = filter
        Else
            dataTable.DefaultView.RowFilter = String.Empty
        End If

        DG.DataSource = dataTable.DefaultView
        DG.Columns(0).Width = 50

    End Sub

    Sub ShowData(st As String)
        Dim where As New List(Of Tuple(Of String, Type, Object, String)) From {
            New Tuple(Of String, Type, Object, String)(Constants.IdFieldName, String.Empty.GetType(), st, String.Empty)
        }

        Dim dataTable As DataTable = DatabaseHelper.Select(Constants.CustomerTableName, whereClause:=where)
        Dim dataRow As DataRow = dataTable.Rows(0)

        TCode.Text = dataRow("id").ToString
        TTell.Text = dataRow("tel").ToString
        Tfamily.Text = dataRow("Family").ToString
        TName.Text = dataRow("Name").ToString
        TNameFather.Text = dataRow("NameFather").ToString
        TReason.Text = dataRow("Reason").ToString
        TDis.Text = dataRow("Dis").ToString
        TAge.Text = dataRow("Age").ToString
        MtDate.Text = dataRow("DateSave").ToString
        cbType.SelectedValue = Val(dataRow("IdTypePatient").ToString())
        txtAddress.Text = dataRow("Address").ToString

        Dim tempSt As String = dataRow("EyeLeft").ToString

        If tempSt <> "" Then
            ChLeft.Checked = True
            MtLeft.Text = dataRow("EyeLeft").ToString
        Else
            ChLeft.Checked = False
            MtLeft.Enabled = False
        End If

        tempSt = dataRow("EyeRight").ToString
        If tempSt <> "" Then
            ChRight.Checked = True
            MtRight.Text = dataRow("EyeRight").ToString
        Else
            ChRight.Checked = False
            MtRight.Enabled = False
        End If

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
        TSearch.Clear()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If Button1.Text = "ثبت(F2)" Then

            Dim where As New List(Of Tuple(Of String, Type, Object, String)) From {
                New Tuple(Of String, Type, Object, String)(Constants.NameFieldName, "".GetType(), TName.Text, "AND"),
                New Tuple(Of String, Type, Object, String)(Constants.FamilyFieldName, "".GetType(), Tfamily.Text, "")
            }
            Dim dataTable As DataTable = DatabaseHelper.Select(Constants.CustomerTableName, whereClause:=where)

            If dataTable.Rows.Count > 0 Then
                If MsgBox("نام و نام خانوادگی تکراری می باشد . آیا ثبت می کنید ؟", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "تکراری") = MsgBoxResult.No Then Exit Sub
            End If

            Dim fields As New List(Of Tuple(Of String, Type, Object)) From {
                New Tuple(Of String, Type, Object)(Constants.NameFieldName, "".GetType(), TName.Text),
                New Tuple(Of String, Type, Object)(Constants.FamilyFieldName, "".GetType(), Tfamily.Text),
                New Tuple(Of String, Type, Object)(Constants.TelFieldName, "".GetType(), TTell.Text),
                New Tuple(Of String, Type, Object)(Constants.NameFatherFieldName, "".GetType(), TNameFather.Text),
                New Tuple(Of String, Type, Object)(Constants.ReasonFieldName, "".GetType(), TReason.Text),
                New Tuple(Of String, Type, Object)(Constants.DisFieldName, "".GetType(), TDis.Text),
                New Tuple(Of String, Type, Object)(Constants.AgeFieldName, "".GetType(), TAge.Text),
                New Tuple(Of String, Type, Object)(Constants.DateSaveFieldName, "".GetType(), MtDate.Text),
                New Tuple(Of String, Type, Object)(Constants.DrIdFieldName, "".GetType(), DrId),
                New Tuple(Of String, Type, Object)(Constants.IdTypePatientFieldName, 0.GetType(), Val(cbType.SelectedValue)),
                New Tuple(Of String, Type, Object)(Constants.AddressFieldName, "".GetType(), txtAddress.Text)
            }

            Dim value As String = String.Empty
            If ChLeft.Checked Then
                value = MtLeft.Text
            End If

            fields.Add(New Tuple(Of String, Type, Object)(Constants.EyeLeftFieldName, "".GetType(), value))

            value = String.Empty
            If ChRight.Checked Then
                value = MtRight.Text
            End If
            fields.Add(New Tuple(Of String, Type, Object)(Constants.EyeRightFieldName, "".GetType(), value))

            Dim rows = DatabaseHelper.Insert(Constants.CustomerTableName, fields)
            If rows > 0 Then
                MsgBox("اطلاعات با موفقیت ثبت شد", Title:="ثبت بیمار")
                ResetForm()
            End If

            Dim dt As DataTable = DatabaseHelper.Select(Constants.CustomerTableName, "MAX(id)")
            ShowData(dt.Rows(0)(0))
        Else
            ResetForm()
        End If

    End Sub

    Private Sub B3_Click(sender As Object, e As EventArgs) Handles B3.Click
        Dim personName = $"{Tfamily.Text} {TName.Text}"
        If MsgBox($"آیا از حذف اطلاعات '{personName}' اطمینان دارید؟", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "حذف") = MsgBoxResult.Yes Then

            Dim where As New List(Of Tuple(Of String, Type, Object, String)) From {
                    New Tuple(Of String, Type, Object, String)(Constants.IdFieldName, "".GetType(), TCode.Text, "")
                        }

            Dim rows = DatabaseHelper.Delete(Constants.CustomerTableName, where)

            If rows > 0 Then
                MsgBox($"اطلاعات '{personName}' حذف شد", Title:="حذف اطلاعات")
            Else
                MsgBox($"اطلاعات {personName} حذف نشد", Buttons:=MsgBoxStyle.Critical, Title:="حذف اطلاعات")
            End If

            ResetForm()
        End If
    End Sub

    Private Sub Customer_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.SizeCustomer = Size
        My.Settings.Save()
    End Sub

    Private Sub Person_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.Enter Then
            SelectNextControl(ActiveControl, True, False, True, True)
            e.SuppressKeyPress = True
        ElseIf e.KeyCode = Keys.F2 Then
            Button1_Click(sender, e)
        ElseIf e.KeyCode = Keys.F3 Then
            TSearch.Focus()
        ElseIf e.KeyCode = Keys.F9 And B2.Enabled = True Then
            B2_Click(sender, e)
        ElseIf e.KeyCode = Keys.F6 And BtnVisit.Enabled = True Then
            BVisit_Click(sender, e)
        ElseIf e.KeyCode = Keys.F7 And BtnVisitText.Enabled = True Then
            BtnVisitText_Click(sender, e)
        ElseIf e.KeyCode = Keys.F5 And BtnVisitText.Enabled = True Then
            TSBCustomer2VisitList_Click(sender, e)
        End If

    End Sub

    Private Sub Person_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDrName.Text = DrName
        ResetForm()

        Size = My.Settings.SizeCustomer

        Left = (My.Computer.Screen.WorkingArea.Width - Width) / 2
        Top = (My.Computer.Screen.WorkingArea.Height - Height) / 2

        ResetForm()

        DG.Font = My.Settings.Fontsize

        BindCombo()

    End Sub

    Private Sub BindCombo()
        Try
            Dim dt As DataTable = DatabaseHelper.Select(Constants.TypePatientTableName)

            cbType.DataSource = dt
            cbType.ValueMember = Constants.IdFieldName
            cbType.DisplayMember = Constants.NameFieldName

        Catch ex As Exception

        End Try
    End Sub

    Private Sub B2_Click(sender As Object, e As EventArgs) Handles B2.Click

        Dim params As New List(Of Tuple(Of String, Type, Object)) From {
        New Tuple(Of String, Type, Object)(Constants.NameFieldName, "".GetType(), TName.Text),
        New Tuple(Of String, Type, Object)(Constants.FamilyFieldName, "".GetType(), Tfamily.Text),
        New Tuple(Of String, Type, Object)(Constants.TelFieldName, "".GetType(), TTell.Text),
        New Tuple(Of String, Type, Object)(Constants.NameFatherFieldName, "".GetType(), TNameFather.Text),
        New Tuple(Of String, Type, Object)(Constants.ReasonFieldName, "".GetType(), TReason.Text),
        New Tuple(Of String, Type, Object)(Constants.AgeFieldName, "".GetType(), TAge.Text),
        New Tuple(Of String, Type, Object)(Constants.DisFieldName, "".GetType(), TDis.Text),
        New Tuple(Of String, Type, Object)(Constants.DateSaveFieldName, "".GetType(), MtDate.Text),
        New Tuple(Of String, Type, Object)(Constants.DrIdFieldName, "".GetType(), DrId),
        New Tuple(Of String, Type, Object)(Constants.IdTypePatientFieldName, "".GetType(), Val(cbType.SelectedValue)),
        New Tuple(Of String, Type, Object)(Constants.AddressFieldName, "".GetType(), txtAddress.Text)
        }
        Dim value As String = ""
        If ChLeft.Checked Then
            value = MtLeft.Text
        End If
        params.Add(New Tuple(Of String, Type, Object)(Constants.EyeLeftFieldName, "".GetType(), value))

        value = ""
        If ChRight.Checked Then
            value = MtRight.Text
        End If
        params.Add(New Tuple(Of String, Type, Object)(Constants.EyeRightFieldName, "".GetType(), value))

        DatabaseHelper.Update(Constants.CustomerTableName, params)

        ResetForm()

    End Sub

    Private Sub DG_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG.CellClick
        ShowData(DG.CurrentRow.Cells(0).Value.ToString)
    End Sub

    Private Sub BVisit_Click(sender As Object, e As EventArgs) Handles BtnVisit.Click

        Dim Frm As New Visit
        Frm.TFk_Customer.Text = TCode.Text
        Frm.TName.Text = Tfamily.Text + " " + TName.Text
        Frm.ShowDialog()

    End Sub

    Private Sub ChLeft_CheckedChanged(sender As Object, e As EventArgs) Handles ChLeft.CheckedChanged
        MtLeft.Enabled = ChLeft.Checked
    End Sub

    Private Sub ChRight_CheckedChanged(sender As Object, e As EventArgs) Handles ChRight.CheckedChanged
        MtRight.Enabled = ChRight.Checked
    End Sub

    Private Sub TSearch_TextChanged(sender As Object, e As EventArgs) Handles TSearch.TextChanged

        If RbFamily.Checked Then
            ShowGrid(" فامیلی Like '" & TSearch.Text & "%'")
        ElseIf RbTel.Checked Then
            ShowGrid(" تلفن LIKE '" & TSearch.Text & "%'")
        ElseIf RbDate.Checked Then
            ShowGrid(" تاریخ LIKE '" & TSearch.Text & "%'")
        ElseIf RbCode.Checked Then
            ShowGrid(" کد = " & TSearch.Text)
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnOldVisit.Click
        Dim Frm As New OldVisit
        Frm.TFk_Customer.Text = TCode.Text
        Frm.TName.Text = Tfamily.Text + " " + TName.Text
        Frm.ShowDialog()
    End Sub

    Private Sub Tfamily_KeyUp(sender As Object, e As KeyEventArgs) Handles Tfamily.KeyUp
        TSearch.Text = Tfamily.Text
    End Sub

    Private Sub BtnVisitText_Click(sender As Object, e As EventArgs) Handles BtnVisitText.Click
        Dim Frm As New Editor
        Frm.TFk_Customer.Text = TCode.Text
        Frm.TName.Text = Tfamily.Text + " " + TName.Text
        Frm.ShowDialog()
    End Sub

    Private Sub TSBVisit_Click(sender As Object, e As EventArgs) Handles TSBVisit.Click
        Dim frm As New VisitList
        frm.ShowDialog()
        If Val(Code_Customer) <> 0 Then
            ShowData(Val(Code_Customer))
        End If
    End Sub

    Private Sub TSBCustomer2VisitList_Click(sender As Object, e As EventArgs) Handles TSBCustomer2VisitList.Click

        Dim frm As New Customer2VisitList
        frm.CustomerTitle = TCode.Text
        frm.ShowDialog()

    End Sub

    Private Sub DG_KeyDown(sender As Object, e As KeyEventArgs) Handles DG.KeyDown
        Try
            DG_CellClick(Nothing, Nothing)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub DG_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG.CellDoubleClick
        BtnVisitText_Click(Nothing, Nothing)
    End Sub

    Private Sub Customer_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Dim c As New CultureInfo("fa-IR")
        InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(c)
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click

        Dim xx As Single = 0

        xx = DG.Font.Size + 0.5

        DG.Font = New Font(DG.Font.Name, xx, DG.Font.Style)
        My.Settings.Fontsize = DG.Font
        My.Settings.Save()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click

        Dim xx As Single = 0

        xx = DG.Font.Size - 0.5

        DG.Font = New Font(DG.Font.Name, xx, DG.Font.Style)
        My.Settings.Fontsize = DG.Font
        My.Settings.Save()
    End Sub

    Private Sub btnBrows_Click(sender As Object, e As EventArgs) Handles btnBrows.Click
        Dim frm As New BaseData("TypePatient")
        frm.Text = "نوع بیمه"
        frm.ShowDialog()
        BindCombo()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ShowGrid()
    End Sub

End Class