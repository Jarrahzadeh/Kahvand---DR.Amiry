Public Class SaveMSG


    Sub ShowGrid()
        Dim Ado As New OleDb.OleDbDataAdapter("Select id as کد, Name as عنوان    From " + Tag, AdoCon)
        Dim Dt As New DataTable
        Ado.Fill(Dt)
        DG.DataSource = Dt
        ' Dg.RetrieveStructure()
        Try
            DG.Columns(0).Width = 50

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If btnSave.Text = "اضافه" Then
            Reset(GroupBox3)
            ShowGrid()
            Exit Sub
        End If
        Try
            If TxtName.Text = "" Then
                MsgBox("عنوان را وارد کنيد .")
                Exit Sub
            End If
            If Val(TxtId.Text) = 0 Then
                Dim cmd As New OleDb.OleDbCommand
                cmd.Connection = AdoCon
                cmd.CommandText = "Insert into " + Tag + " (Name) Values ('" + TxtName.Text + "')"
                cmd.ExecuteNonQuery()

                MsgBox("اطلاعات شما ثبت شد . ")
            Else


            End If
            Reset(GroupBox3)
            ShowGrid()
        Catch ex As Exception
            'HandelError(ex)
        End Try
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click

        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = AdoCon
        cmd.CommandText = "Update " + Tag + " Set Name ='" + TxtName.Text + "' Where Id = " + TxtId.Text
        cmd.ExecuteNonQuery()

        MsgBox("اطلاعات شما ویرایش شد . ")

        Reset(GroupBox3)
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        ShowGrid()

    End Sub

    Private Sub BaseData_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F2 Then
            btnSave_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub BaseData_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ShowGrid()

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            If MsgBox("    ايا از حذف   '" + TxtName.Text + "'   اطمينان داريد ؟  ", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then Exit Sub

            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = AdoCon
            cmd.CommandText = "Delete From " + Tag + " Where Id = " + TxtId.Text
            cmd.ExecuteNonQuery()
            Reset(GroupBox3)
        Catch ex As Exception
            'HandelError(ex)
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub

    Private Sub DG_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG.CellDoubleClick
        TxtId.Text = DG.CurrentRow.Cells(0).Value.ToString
        TxtName.Text = DG.CurrentRow.Cells(1).Value.ToString
        btnEdit.Enabled = True
        btnDelete.Enabled = True
        btnSave.Text = "اضافه"
    End Sub

    Public Overloads Property Tag As String
End Class