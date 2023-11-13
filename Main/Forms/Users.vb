Public Class Users

 
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If btnSave.Text = "ثبت(F2)" Then


            If TxtPassword.Text <> TxtPassword2.Text Then
                MsgBox("پسورد با هم برابر نيست  .")
                Exit Sub
            End If
            If TxtName.Text = "" Or TxtUserName.Text = "" Then
                MsgBox("نام کاربري و نام خانوادگي بايد وارد شود  ")
                Exit Sub
            End If

           
            Dim Cmd As New OleDb.OleDbCommand
            Cmd.Connection = AdoCon
            Cmd.CommandText = $"INSERT INTO [{Constants.UserTableName}]( Name, Pass, FirstName, LastName) VALUES(@Name, @Pass, @FirstName, @LastName)"
            Cmd.Parameters.AddWithValue("Name", TxtUserName.Text)
            Cmd.Parameters.AddWithValue("Pass", TxtPassword.Text)
            Cmd.Parameters.AddWithValue("FirstName", TxtName.Text)
            Cmd.Parameters.AddWithValue("LastName", TxtFamily.Text)
            Cmd.ExecuteNonQuery()
            ShowGrid()
       

        End If

        Reset(GroupBox3)


    End Sub
 
    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click

        Dim Cmd As New OleDb.OleDbCommand
        Cmd.Connection = AdoCon
        Cmd.CommandText = $"Update [{Constants.UserTableName}] set Name=@Name, Pass=@Pass, FirstName=@FirstName, LastName=@LastName where(id = " + TxtId.Text + ")"
        Cmd.Parameters.AddWithValue("Name", TxtUserName.Text)
        Cmd.Parameters.AddWithValue("Pass", TxtPassword.Text)
        Cmd.Parameters.AddWithValue("FirstName", TxtName.Text)
        Cmd.Parameters.AddWithValue("LastName", TxtFamily.Text)
        Cmd.ExecuteNonQuery()

        Reset(GroupBox3)
        btnEdit.Enabled = False
        btnDelete.Enabled = False

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If MsgBox("ایا از حذف اطلاعات جاری اطمینان دارید ؟", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "خذف") = MsgBoxResult.Yes Then
            Dim Cmd As New OleDb.OleDbCommand($"Delete From {Constants.UserTableName} Where id = " + TxtId.Text, AdoCon)
            Cmd.ExecuteNonQuery()
            MsgBox("اطلاعات جاری حذف شد")
            Reset(GroupBox3)
            btnEdit.Enabled = False
            btnDelete.Enabled = False

        End If
    End Sub
    Sub ShowGrid()
        Dim Ado As New OleDb.OleDbDataAdapter($"SELECT id as کد,Name as [نام کاربري], FirstName as نام, LastName as فاميلي from {Constants.UserTableName}", AdoCon)
        Dim Dt As New DataTable
        Ado.Fill(Dt)
        Dg.DataSource = Dt

    End Sub
    Private Sub Users_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ShowGrid()
        btnEdit.Enabled = False
        btnDelete.Enabled = False

    End Sub


    Sub ShowData()
        Try



            Dim Cmd As New OleDb.OleDbCommand
            Cmd.Connection = AdoCon
            Cmd.CommandText = $"Select * from {Constants.UserTableName} where id = " + TxtId.Text
            Dim Dr As OleDb.OleDbDataReader = Cmd.ExecuteReader
            Dim dt As New DataTable
            dt.Load(Dr)
            TxtId.Text = dt.Rows(0)("Id").ToString
            TxtUserName.Text = dt.Rows(0)("Name").ToString
            TxtPassword.Text = dt.Rows(0)("Pass").ToString
            TxtName.Text = dt.Rows(0)("FirstName").ToString
            TxtPassword2.Text = dt.Rows(0)("Pass").ToString
            TxtFamily.Text = dt.Rows(0)("LastName").ToString

            btnEdit.Enabled = True
            btnDelete.Enabled = True
            btnSave.Text = "اضافه"
        Catch ex As Exception

        End Try

    End Sub

    Private Sub DG_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG.CellDoubleClick
        TxtId.Text = DG.CurrentRow.Cells(0).Value.ToString()
        ShowData()
    End Sub
End Class