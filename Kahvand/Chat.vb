Imports System.Net.Sockets
Imports System.IO

Public Class Chat

    Public Sub AddMsg(ByVal msg As String)
        lstMSG.Items.Add(msg)
    End Sub

    Private Sub Chat_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        isShow = False
    End Sub

    Private Sub Chat_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub Chat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bindCombo()
        cbType.Text = ""
    End Sub

    Private Sub BtnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSend.Click
        Try
            If cbType.Text <> "" Then TxtText.Text = cbType.Text
            If ClientIp = "" Or TxtText.Text = "" Then
                MsgBox("Sorry Uncomplete data")
            Else
                client = New TcpClient(ClientIp, 44444)
                Dim writer As New StreamWriter(client.GetStream())
                writer.Write("پیام :" + TxtText.Text)
                writer.Flush()
                'RLC.Items.Add("شما :" + TxtText.Text)
                lstMSG.Items.Add("شما :" + TxtText.Text)
                TxtText.Text = ""
                cbType.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TxtText_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtText.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnSend_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub TxtText_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtText.TextChanged

    End Sub

    Private Sub btnBrows_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrows.Click
        Me.TopMost = False
        Dim frm As New SaveMSG
        frm.Tag = "SaveMSG"
        frm.ShowDialog()
        bindCombo()
        Me.TopMost = True
        cbType.Text = ""

    End Sub
    Private Sub bindCombo()
        Try

            Dim Ado As New OleDb.OleDbDataAdapter("Select id, Name  From SaveMSG", AdoCon)
            Dim Dt As New DataTable
            Ado.Fill(Dt)
            cbType.DataSource = Dt
            cbType.ValueMember = "Id"
            cbType.DisplayMember = "Name"

        Catch ex As Exception

        End Try
    End Sub
End Class