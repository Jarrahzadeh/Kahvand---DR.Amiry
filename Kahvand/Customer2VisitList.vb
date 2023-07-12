Imports System.Net.Sockets
Imports System.IO

Public Class Customer2VisitList

    Sub ShowGrid()

        Dim DtDg As New DataTable
        Dim AdoDaDg As New OleDb.OleDbDataAdapter("select V.id,C.id as کد ,C.Name as نام , C.Family as فامیلی,   C.DateSave as تاریخ ,TimeVisit as زمان,V.Status as وضعیت  , v.price as مبلغ  From Customer C inner join VisitList V on (C.id=V.Code_Customer) where V.DateVisit = '" + DatePicker1.Text + "' and C.DrId = " + DrId.ToString() + " order by V.id desc", AdoCon)
        AdoDaDg.Fill(DtDg)
        DG.DataSource = DtDg
        DG.Columns(0).Width = 50
        DG.Columns(1).Width = 50
        DG.Columns(0).Visible = False



        Dim K As Integer

        Dim I, J As Int16
        For I = 0 To DG.RowCount - 1
            If DG.Rows(I).Cells("وضعیت").Value = "ویزیت شده" Then
                For J = 0 To DG.Columns.Count - 1
                    DG.Rows(I).Cells(J).Style.BackColor = Color.Red
                    K += 1
                Next
            End If
            If DG.Rows(I).Cells("وضعیت").Value = "اپتومتری" Then
                For J = 0 To DG.Columns.Count - 1
                    DG.Rows(I).Cells(J).Style.BackColor = Color.Yellow
                    K += 1
                Next
            End If
        Next

    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click

        Me.Close()

    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click

        If (Val(txtId.Text) = 0) Then

            Dim Cmd As New OleDb.OleDbCommand("insert into VisitList(Code_customer,DateVisit,TimeVisit,Status,Price,DrId)" & _
                " Values(@Code_customer,@DateVisit,@TimeVisit,'ویزیت نشده',@Price,@DrId)", AdoCon)

            Cmd.Parameters.Add("@Code_customer", OleDb.OleDbType.Numeric).Value = CbCustomer.SelectedValue.ToString
            Cmd.Parameters.Add("@DateVisit", OleDb.OleDbType.VarChar).Value = MtDate.Text
            Cmd.Parameters.Add("@TimeVisit", OleDb.OleDbType.VarChar).Value = MtTime.Text
            Cmd.Parameters.Add("@Price", OleDb.OleDbType.Integer).Value = Val(txtPrice.Text)
            Cmd.Parameters.Add("@DrId", OleDb.OleDbType.Integer).Value = DrId

            Cmd.ExecuteNonQuery()
        Else

            Dim Cmd As New OleDb.OleDbCommand("Update VisitList set Code_customer=@Code_customer,DateVisit=@DateVisit" & _
                " ,TimeVisit=@TimeVisit,Price=@Price,Drid=@Drid where id =" + txtId.Text, AdoCon)

            Cmd.Parameters.Add("@Code_customer", OleDb.OleDbType.Numeric).Value = CbCustomer.SelectedValue.ToString
            Cmd.Parameters.Add("@DateVisit", OleDb.OleDbType.VarChar).Value = MtDate.Text
            Cmd.Parameters.Add("@TimeVisit", OleDb.OleDbType.VarChar).Value = MtTime.Text
            Cmd.Parameters.Add("@Price", OleDb.OleDbType.Integer).Value = Val(txtPrice.Text)
            Cmd.Parameters.Add("@DrId", OleDb.OleDbType.Integer).Value = DrId
            Cmd.ExecuteNonQuery()
        End If


        'CbCustomer.SelectedValue = Dr("Code_customer")
        MtDate.Text = DateToday
        MtTime.Text = ""
        txtPrice.Text = ""
        txtId.Text = ""
        txtType.Text = ""
        ShowGrid()
        'Me.Close()

    End Sub

    Private Sub Customer2VisitList_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.CustomerVisitSize = Me.Size
        My.Settings.Save()
    End Sub

    Private Sub Customer2VisitList_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.Enter Then
            Me.SelectNextControl(Me.ActiveControl, True, False, True, True)
            e.SuppressKeyPress = True
        End If
        If e.KeyCode = Keys.F2 Then
            BtnSave_Click(Nothing, Nothing)
        End If
        If e.KeyCode = Keys.F1 Then
            Button1_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub Customer2VisitList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try


            txtDrName.Text = DrName
            Dim Ado As New OleDb.OleDbDataAdapter("select id,Family +' ' + name +' ' + Tel as X from Customer where DrId = " + DrId.ToString(), AdoCon)
            Dim Dt As New DataTable
            Ado.Fill(Dt)
            CbCustomer.ValueMember = "id"
            CbCustomer.DisplayMember = "X"
            CbCustomer.DataSource = Dt

            If Val(LblCustomer.Text) <> 0 Then
                CbCustomer.SelectedValue = Val(LblCustomer.Text)
                ChangeCustomer()
            End If

            ShowGrid()

            Me.Size = My.Settings.CustomerVisitSize

        Catch ex As Exception

        End Try
    End Sub

    Private Sub CbCustomer_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CbCustomer.LostFocus

        If CbCustomer.SelectedValue = Nothing Then
            CbCustomer.SelectedIndex = 0
        End If

    End Sub

 

    Private Sub DG_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG.CellClick
        CbCustomer.SelectedValue = DG.CurrentRow.Cells(0).Value.ToString

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim frm As New ListOfData
        frm.ShowDialog()
        If Val(Code_Customer) <> 0 Then
            Try
                CbCustomer.SelectedValue = Code_Customer

                ChangeCustomer()

            Catch ex As Exception

            End Try
        End If

    End Sub

    Private Sub DG_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DG.DoubleClick
        Dim cmd As New OleDb.OleDbCommand("Select * from VisitList where id = " + DG.CurrentRow.Cells(0).Value.ToString(), AdoCon)
        Dim Dr As OleDb.OleDbDataReader = cmd.ExecuteReader()
        Dr.Read()
        If Dr.HasRows Then

            CbCustomer.SelectedValue = Dr("Code_customer")
            MtDate.Text = Dr("DateVisit")
            MtTime.Text = Dr("TimeVisit")
            txtPrice.Text = Dr("Price").ToString()
            txtId.Text = Dr("Id")
        End If


    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        If Val(txtId.Text) <> 0 Then
            Dim cmd As New OleDb.OleDbCommand("Delete from VisitList where id = " + txtId.Text, AdoCon)
            cmd.ExecuteNonQuery()
            ShowGrid()

            MtDate.Text = DateToday
            MtTime.Text = ""
            txtPrice.Text = ""
            txtId.Text = ""
            txtType.Text = ""
        Else
            MsgBox("ویزیت مورد نظر را مشخص کنید ")
        End If

    End Sub

    Private Sub BtnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnView.Click
        ShowGrid()
    End Sub

    Private Sub ارسالبهدکترToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ارسالبهدکترToolStripMenuItem.Click

        Try

            If ClientIp = "" Then
                MsgBox("ای پی طرف مقابل وارد نشده")
            Else
                client = New TcpClient(ClientIp, 44444)
                Dim writer As New StreamWriter(client.GetStream())
                writer.Write("#CMR" + DG.CurrentRow.Cells(1).Value.ToString())
                writer.Flush()
            End If

        Catch ex As Exception

        End Try


    End Sub
    Sub ChangeCustomer()

        Dim Ado As New OleDb.OleDbDataAdapter("SELECT Customer.Age, TypePatient.Name, TypePatient.Price FROM Customer INNER JOIN TypePatient ON Customer.IdTypePatient = TypePatient.ID where Customer.id = " + CbCustomer.SelectedValue.ToString(), AdoCon)
        Dim Dt As New DataTable
        Ado.Fill(Dt)
        If Dt.Rows.Count <> 0 Then
            txtType.Text = Dt.Rows(0)(1).ToString()
            txtPrice.Text = Dt.Rows(0)(2).ToString()
        End If


    End Sub
    Private Sub CbCustomer_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CbCustomer.SelectedIndexChanged

    End Sub

    
End Class