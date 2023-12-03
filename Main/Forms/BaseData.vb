Imports Ophthalmology.DataAccess.OleDb
Imports Ophthalmology.Entity.Database

Public Class BaseData
    Public Sub New()
        Me.New("", "")
    End Sub
    Public Sub New(tableName As String, title As String)
        InitializeComponent()
        _tableName = tableName
        Text = title
    End Sub

    Sub ShowGrid()

        Dim fields = "id as کد, Name as عنوان ,Price as مبلغ"
        Dim dt As DataTable = DatabaseHelper.Select(_tableName, fields)
        DG.DataSource = dt

        Try
            DG.Columns(0).Width = 50
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If btnSave.Text = "اضافه" Then
            ResetFormControls()
            ShowGrid()
            Exit Sub
        End If

        Try
            If TxtName.Text = "" Then
                MsgBox("عنوان را وارد کنيد .")
                Exit Sub
            End If

            If Val(TxtId.Text) = 0 Then

                Dim fields As New List(Of IFieldValue) From {
                    New FieldValue(Constants.NameFieldName, TxtName.Text),
                    New FieldValue(Constants.PriceFieldName, txtPrice.Text)
                }
                Dim rows = DatabaseHelper.Insert(_tableName, fields)

                If rows > 0 Then
                    MsgBox("اطلاعات با موفقیت ثبت شد", Title:="ثبت اطلاعات")
                Else
                    MsgBox("مشکلی بوجود آمده است", Title:="ثبت اطلاعات", Buttons:=MsgBoxStyle.Critical)
                End If

            End If

            ResetFormControls()
            ShowGrid()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        Dim fields As New List(Of IFieldValue) From {
                New FieldValue(Constants.NameFieldName, TxtName.Text),
                New FieldValue(Constants.PriceFieldName, txtPrice.Text)
                }
        Dim rows = DatabaseHelper.Update(_tableName, fields)

        If rows > 0 Then
            MsgBox("اطلاعات با موفقیت ویرایش شد.", Title:="ویرایش اطلاعات")
        Else
            MsgBox("مشکلی بوجود آمده است", Title:="ویرایش اطلاعات", Buttons:=MsgBoxStyle.Critical)
        End If

        ResetFormControls()
        ShowGrid()

    End Sub

    Private Sub BaseData_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F2 Then
            btnSave_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub BaseData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowGrid()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            If MsgBox("آيا از حذف '" + TxtName.Text + "'اطمينان داريد؟", MsgBoxStyle.YesNo + MsgBoxStyle.Critical, Title:="هشدار") = MsgBoxResult.No Then
                Exit Sub
            End If

            Dim where As New List(Of IWhereClause) From
            {
                New WhereClause(Constants.IdFieldName, TxtId.Text)
            }
            Dim rows = DatabaseHelper.Delete(_tableName, where)

            If rows > 0 Then
                MsgBox("اطلاعات با موفقیت حذف شد", Title:="حذف اطلاعات")
            Else
                MsgBox("اطلاعاتی حذف نشد", Title:="حذف اطلاعات")
            End If

            ResetFormControls()
            ShowGrid()
        Catch ex As Exception
            'HandelError(ex)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub DG_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG.CellDoubleClick
        TxtId.Text = DG.CurrentRow.Cells(0).Value.ToString
        TxtName.Text = DG.CurrentRow.Cells(1).Value.ToString
        txtPrice.Text = DG.CurrentRow.Cells(2).Value.ToString
        btnEdit.Enabled = True
        btnDelete.Enabled = True
        btnSave.Text = "اضافه"
    End Sub

    Private Sub ResetFormControls()
        Reset(GroupBox3)
        btnSave.Text = "ثبت(F2)"
        btnDelete.Enabled = False
        btnEdit.Enabled = False
    End Sub

    Private ReadOnly _tableName As String
End Class