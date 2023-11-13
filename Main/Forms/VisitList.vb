Public Class VisitList
    Sub ShowGrid(Optional ByVal St As String = "")
        Try


            Dim DtDg As New DataTable
            Dim AdoDaDg As New OleDb.OleDbDataAdapter("select V.id,C.id as کد ,C.Name as نام , C.Family as فامیلی, Tel as تلفن,  C.DateSave as تاریخ ,TimeVisit as زمان,V.Status as وضعیت  , v.price as مبلغ  From CustomerForm C inner join VisitList V on (C.id=V.Code_Customer) where V.DateVisit = '" + MtDate.Text + "' and C.DrId = " + DrId.ToString() + St + " order by C.id desc", AdoCon)
            AdoDaDg.Fill(DtDg)
            DG.DataSource = DtDg
            DG.Columns(0).Width = 50
            DG.Columns(0).Visible = False

            If DG.RowCount = 0 Then
                BtnDelete.Enabled = False
                BtnVisit.Enabled = False
                BtnOldVisit.Enabled = False
            End If

            tsslAllCount.Text = DG.RowCount.ToString()

            Dim K As Integer

            Dim I, J As Int16
            For I = 0 To DG.RowCount - 1
                If DG.Rows(I).Cells("وضعیت").Value = "ویزیت شده" Then
                    For J = 0 To DG.Columns.Count - 1
                        DG.Rows(I).Cells(J).Style.BackColor = Color.Red
                    Next
                    K += 1
                End If
                If DG.Rows(I).Cells("وضعیت").Value = "اپتومتری" Then
                    For J = 0 To DG.Columns.Count - 1
                        DG.Rows(I).Cells(J).Style.BackColor = Color.Yellow
                    Next
                    'K += 1
                End If
            Next

            tsslVisitCount.Text = K.ToString()
            tsslNotVisitCount.Text = (Val(tsslAllCount.Text) - K).ToString()

        Catch ex As Exception

        End Try


    End Sub

    Private Sub VisitList_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.VisitListSize = Me.Size
        My.Settings.Save()
    End Sub

    Private Sub VisitList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Code_Customer = 0
        ShowGrid()
        DG.Font = My.Settings.Fontsize
        Me.Size = My.Settings.VisitListSize

        '"Where id in (select Code_Customer from VisitList 
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()

    End Sub

    Private Sub B3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        If DG.RowCount = 0 Then Exit Sub
        If MsgBox("ایا از حذف اطلاعات جاری اطمینان دارید ؟", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "خذف") = MsgBoxResult.Yes Then
            Dim Cmd As New OleDb.OleDbCommand("Delete From VisitList Where id = " + DG.CurrentRow.Cells(0).Value.ToString, AdoCon)
            Cmd.ExecuteNonQuery()
            MsgBox("اطلاعات جاری حذف شد")
        End If

        ShowGrid()

    End Sub

    Private Sub DG_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG.CellContentClick

    End Sub

    Private Sub DG_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG.CellDoubleClick

        'Code_Customer = DG.CurrentRow.Cells(1).Value.ToString
        'Me.Close()
        Button1_Click(Nothing, Nothing)

    End Sub

    Private Sub DG_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DG.DoubleClick

    End Sub

 
    Private Sub TSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSearch.TextChanged
        ShowGrid(" and Family LIKE '" & TSearch.Text & "%' ")
    End Sub
    Private Sub BtnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnView.Click
        ShowGrid()

    End Sub

    Private Sub BtnVisit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVisit.Click
        Try

            Dim Frm As New Visit
            Frm.TFk_Customer.Text = DG.CurrentRow.Cells("کد").Value
            Frm.TName.Text = DG.CurrentRow.Cells("فامیلی").Value + " " + DG.CurrentRow.Cells("نام").Value
            Frm.ShowDialog()

            ShowGrid()

        Catch ex As Exception
            MsgBox("لطفا شخص را انتخاب کنید .")
        End Try
    End Sub

    Private Sub BtnOldVisit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOldVisit.Click
        Try

            Dim Frm As New OldVisit
            Frm.TFk_Customer.Text = DG.CurrentRow.Cells("کد").Value
            Frm.TName.Text = DG.CurrentRow.Cells("فامیلی").Value + " " + DG.CurrentRow.Cells("نام").Value
            Frm.ShowDialog()

        Catch ex As Exception
            MsgBox("لطفا شخص را انتخاب کنید .")

        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
           

            Dim Frm As New Editor
            Frm.TFk_Customer.Text = DG.CurrentRow.Cells("کد").Value
            Frm.TName.Text = DG.CurrentRow.Cells("فامیلی").Value + " " + DG.CurrentRow.Cells("نام").Value
            Frm.ShowDialog()

            ShowGrid()
        Catch ex As Exception
            MsgBox("لطفا شخص را انتخاب کنید .")

        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Not isShow Then
            ChatForm.Show()
            isShow = True
        End If
    End Sub

  

    Private Sub btnRef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRef.Click
        ShowGrid()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ShowGrid()
    End Sub
End Class