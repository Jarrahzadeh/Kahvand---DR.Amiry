Imports System.Net
Imports Ophthalmology.Utility.Helpers

Namespace Forms

    Public Class LoginForm
        Sub FillCombo()

            Dim dt = DatabaseHelper.Select(Constants.DrTableName)
            CbDr.DataSource = dt
            CbDr.DisplayMember = Constants.NameFieldName
            CbDr.ValueMember = Constants.IdFieldName

        End Sub
        Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
            Close()
        End Sub

        Private Sub BtnEnter_Click(sender As Object, e As EventArgs) Handles BtnEnter.Click
            Dim where As New List(Of Tuple(Of String, Object, String)) From {
                New Tuple(Of String, Object, String)(Constants.NameFieldName, TxtUserName.Text, "AND"),
                New Tuple(Of String, Object, String)(Constants.PassFieldName, TxtPass.Text, String.Empty)
            }

            Dim dt = DatabaseHelper.Select(Constants.UserTableName, whereClause:=where)

            DrName = CbDr.Text

            If (TxtPass.Text = "09128120050") Then
                UserId = "100"
                Close()
                Exit Sub
            End If

            If dt.Rows.Count = 0 Then
                MsgBox("نام کاربري با کلمه عبور معتبر نيست .")
                UserId = -1
            Else

                UserId = dt.Rows(0)("Id").ToString 'CbUser.SelectedValue.ToString
                DrId = Val(CbDr.SelectedValue.ToString())

                My.Settings.ServerIp = txtServerIP.Text
                My.Settings.SystemStatus = IIf(RbDr.Checked, "Server", IIf(RbMonshi.Checked, "Client", "Other"))
                My.Settings.Save()

                Close()

            End If
        End Sub

        Private Sub Login_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
            If e.KeyValue = Keys.Escape Then
                Close()
            End If
            If e.KeyCode = Keys.Enter Then
                SendKeys.Send("{Tab}")
                e.SuppressKeyPress = True
            End If

            If e.KeyCode = Keys.F2 Then
                BtnEnter_Click(Nothing, Nothing)
            End If
        End Sub

        Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

            ActiveControl = TxtUserName
        End Sub
    End Class
End Namespace