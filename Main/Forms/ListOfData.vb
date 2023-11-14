Public Class ListOfData

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Close()
    End Sub

    Private Sub ListOfData_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Code_Customer = 0
        ShowGrid("")

    End Sub

    Private Sub TSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSearch.TextChanged
        ShowGrid(" and Family LIKE '" & TSearch.Text & "%'")
    End Sub

    Private Sub ShowGrid(ByVal critria As String)
        Dim DtDg As New DataTable
        Dim AdoDaDg As New OleDb.OleDbDataAdapter("select id as کد , Name as نام , Family as فامیلی, Tel as تلفن From Customer where drId = " + DrId.ToString() + critria + " order by id desc", AdoCon)
        AdoDaDg.Fill(DtDg)
        DG.DataSource = DtDg
        DG.Columns(0).Width = 50
    End Sub

    Private Sub DG_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DG.DoubleClick

        If DG.SelectedRows.Count <> 0 Then
            Code_Customer = DG.CurrentRow.Cells(0).Value.ToString()
            Me.Close()
        End If

    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        DG_DoubleClick(Nothing, Nothing)
    End Sub
End Class