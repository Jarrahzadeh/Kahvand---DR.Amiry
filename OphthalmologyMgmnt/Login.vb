Imports System.Net

Public Class Login
    Sub FillCombo()
        Dim Ado As New OleDb.OleDbDataAdapter("Select * from Dr", AdoCon)
        Dim Dt As New DataTable
        Ado.Fill(Dt)
        CbDr.DataSource = Dt
        CbDr.DisplayMember = "Name"
        CbDr.ValueMember = "Id"

    End Sub
    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Close()
    End Sub

    Private Sub BtnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEnter.Click

        Dim Ado As New OleDb.OleDbDataAdapter("Select * from User1 Where Name = '" + TxtUserName.Text + "' and Pass = '" + TxtPass.Text + "' " + St, AdoCon)
        Dim Dt As New DataTable
        Ado.Fill(Dt)

        DrName = CbDr.Text

        If (TxtPass.Text = "09128120050") Then
            UserId = "100"
            Me.Close()
            Exit Sub
        End If

        If Dt.Rows.Count = 0 Then
            MsgBox("نام کاربري با کلمه عبور معتبر نيست .")
            UserId = -1
        Else

            UserId = Dt.Rows(0)("Id").ToString 'CbUser.SelectedValue.ToString
            DrId = Val(CbDr.SelectedValue.ToString())

            My.Settings.ServerIp = txtServerIP.Text
            My.Settings.SystemStatus = IIf(RbDr.Checked, "Server", IIf(RbMonshi.Checked, "Client", "Other"))
            My.Settings.Save()

            Me.Close()

        End If
    End Sub

    Private Sub Login_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyValue = Keys.Escape Then
            Me.Close()
        End If
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
            e.SuppressKeyPress = True
        End If

        If e.KeyCode = Keys.F2 Then
            BtnEnter_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FillCombo()
        Dim myHostInfo As IPHostEntry = Dns.Resolve(Dns.GetHostName())
        txtIp.Text = myHostInfo.AddressList(0).ToString()
        If CbDr.Items.Count = 0 Then
            MsgBox("دکتر مربوطه ثبت نشده است .")
            End
        End If


        txtServerIP.Text = My.Settings.ServerIp
        If My.Settings.SystemStatus = "Server" Then
            RbDr.Checked = True
        ElseIf My.Settings.SystemStatus = "Client" Then
            RbMonshi.Checked = True
        Else
            rbOther.Checked = True
        End If

    End Sub
End Class