Imports System.Net.Sockets
Imports System.IO
Imports Ophthalmology.DataAccess.OleDb
Imports Ophthalmology.Entity.Database
Imports Ophthalmology.Entity.Enums

Public Class Customer2VisitList
    Sub ShowGrid()

        Dim tableName = "Customer C INNER JOIN VisitList V on (C.id=V.Code_Customer)"
        Dim fields = "V.id as id, C.id as کد ,C.Name as نام , C.Family as فامیلی,   C.DateSave as تاریخ ,TimeVisit as زمان,V.Status as وضعیت  , v.price as مبلغ"
        Dim where As New List(Of IWhereClause) From
        {
            New WhereClause("V.DateVisit", $"{DatePicker1.Text}", "DateVisit", LogicalOperatorType.And),
            New WhereClause("C.DrId", $"{DrId}", "DrId")
        }
        Dim dt As DataTable = DatabaseHelper.Select(tableName, fields, where)
        dt.DefaultView.Sort = "id DESC"
        DG.DataSource = dt.DefaultView

        DG.Columns(0).Width = 50
        DG.Columns(1).Width = 50
        DG.Columns(0).Visible = False

        Dim K As Integer

        Dim I, J As Int16
        For I = 0 To DG.RowCount - 1
            Dim statusValue = DG.Rows(I).Cells("وضعیت").Value

            If statusValue IsNot DBNull.Value Then

                If statusValue = "ویزیت شده" Then
                    For J = 0 To DG.Columns.Count - 1
                        DG.Rows(I).Cells(J).Style.BackColor = Color.Red
                        K += 1
                    Next
                End If

                If statusValue = "اپتومتری" Then
                    For J = 0 To DG.Columns.Count - 1
                        DG.Rows(I).Cells(J).Style.BackColor = Color.Yellow
                        K += 1
                    Next
                End If

            End If
        Next

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click

        Me.Close()

    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

        Dim params As New List(Of IFieldValue) From {
                New FieldValue("Code_customer", CbCustomer.SelectedValue.ToString, "Code_customer"),
                New FieldValue("DateVisit", MtDate.Text, "DateVisit"),
                New FieldValue("TimeVisit", MtTime.Text, "TimeVisit"),
                New FieldValue("Price", Val(txtPrice.Text), "Price"),
                New FieldValue(Constants.DrIdFieldName, DrId, Constants.DrIdFieldName)
                }

        If Val(txtId.Text) = 0 Then
            params.Add(New FieldValue(Constants.StatusFieldName, "ویزیت نشده", Constants.StatusFieldName))
            DatabaseHelper.Insert("VisitList", params)
        Else

            params.Add(New FieldValue(Constants.StatusFieldName, "ویزیت نشده", Constants.StatusFieldName))
            params.Add(New FieldValue(Constants.IdFieldName, txtId.Text, Constants.IdFieldName))
            DatabaseHelper.Update("VisitList", params)
        End If

        ResetFormControls()
        ShowGrid()
        'Me.Close()

    End Sub

    Private Sub Customer2VisitList_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.CustomerVisitSize = Me.Size
        My.Settings.Save()
    End Sub

    Private Sub Customer2VisitList_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

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

    Private Sub Customer2VisitList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try


            txtDrName.Text = DrName

            'Dim Ado As New OleDbDataAdapter("select id,Family +' ' + name +' ' + Tel as X from Customer where DrId = " + DrId.ToString(), AdoCon)
            'Dim Dt As New DataTable
            'Ado.Fill(Dt)

            Dim where As New List(Of IWhereClause) From {
                    New WhereClause(Constants.DrIdFieldName, DrId, Constants.DrIdFieldName)}

            Dim dt As DataTable = DatabaseHelper.Select(Constants.CustomerTableName, "id,Family +' ' + name +' ' + Tel as X", where)

            CbCustomer.ValueMember = "id"
            CbCustomer.DisplayMember = "X"
            CbCustomer.DataSource = dt

            If Val(LblCustomer.Text) <> 0 Then
                CbCustomer.SelectedValue = Val(LblCustomer.Text)
                ChangeCustomer()
            End If

            ShowGrid()

            Size = My.Settings.CustomerVisitSize
            MtTime.Text = DateTime.Now.ToString("HH:mm")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CbCustomer_LostFocus(sender As Object, e As EventArgs) Handles CbCustomer.LostFocus

        If CbCustomer.SelectedValue = Nothing Then
            CbCustomer.SelectedIndex = 0
        End If

    End Sub

    Private Sub DG_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG.CellClick
        CbCustomer.SelectedValue = DG.CurrentRow.Cells(0).Value.ToString
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

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

    Private Sub DG_DoubleClick(sender As Object, e As EventArgs) Handles DG.DoubleClick
        'Dim cmd As New OleDbCommand("Select * from VisitList where id = " + DG.CurrentRow.Cells(0).Value.ToString(), AdoCon)
        'Dim Dr As OleDbDataReader = cmd.ExecuteReader()
        'Dr.Read()
        'If Dr.HasRows Then

        '  CbCustomer.SelectedValue = Dr("Code_customer")  
        '  MtDate.Text = Dr("DateVisit")  
        '  MtTime.Text = Dr("TimeVisit")  
        '  txtPrice.Text = Dr("Price").ToString()  
        '  txtId.Text = Dr("Id")  
        'End If

        CbCustomer.SelectedValue = DG.CurrentRow.Cells(1).Value
        MtDate.Text = DG.CurrentRow.Cells(2).Value
        MtTime.Text = DG.CurrentRow.Cells(3).Value
        txtPrice.Text = DG.CurrentRow.Cells(4).Value
        txtId.Text = DG.CurrentRow.Cells(0).Value

    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If Val(txtId.Text) <> 0 Then

            Dim where As New List(Of IWhereClause) From {
                    New WhereClause(Constants.IdFieldName, txtId.Text, "")}

            DatabaseHelper.Delete("VisitList", where)

            ShowGrid()

            ResetFormControls()
        Else
            MsgBox("ویزیت مورد نظر را مشخص کنید ")
        End If

    End Sub

    Private Sub BtnView_Click(sender As Object, e As EventArgs) Handles BtnView.Click
        ShowGrid()
    End Sub

    Private Sub SendToDocterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SendToDocterToolStripMenuItem.Click

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

        Dim tableName = "Customer INNER JOIN TypePatient ON Customer.IdTypePatient = TypePatient.ID"
        Dim fields = "Customer.Age, TypePatient.Name, TypePatient.Price"

        Dim where As New List(Of IWhereClause) From {
        New WhereClause("Customer.id", CbCustomer.SelectedValue.ToString(), "Id")
        }
        Dim dt As DataTable = DatabaseHelper.Select(tableName, fields, where)

        If dt.Rows.Count <> 0 Then
            txtType.Text = dt.Rows(0)(1).ToString()
            txtPrice.Text = dt.Rows(0)(2).ToString()
        End If

    End Sub

    Private Sub ResetFormControls()
        MtDate.Text = DateToday
        MtTime.Text = ""
        txtPrice.Text = ""
        txtId.Text = ""
        txtType.Text = ""
    End Sub

    Public WriteOnly Property CustomerTitle As String
        Set
            LblCustomer.Text = Value
        End Set
    End Property
End Class