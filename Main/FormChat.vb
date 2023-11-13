Imports System.Data.OleDb
Imports System.Net.Sockets
Imports System.IO
Imports Ophthalmology.Controls.CustomControls
Imports Ophthalmology.Utility.Classes
Imports Ophthalmology.Utility.Connection
Imports Ophthalmology.Utility.Helpers

Public Class FormChat
    Public Sub New()
        InitializeComponent()

        ChatControlGroup.Text = "گروهی"
        ChatControlGroup.AddCustomMessageAction = AddressOf ShowCustomMessageForm
        ChatControlPrivate1.AddCustomMessageAction = AddressOf ShowCustomMessageForm
        ChatControlPrivate2.AddCustomMessageAction = AddressOf ShowCustomMessageForm

        ChatControlGroup.SendMessageAction = AddressOf SendMessageToGroup
        ChatControlPrivate1.SendMessageAction = AddressOf SendMessageToPrivate1
        ChatControlPrivate2.SendMessageAction = AddressOf SendMessageToPrivate2
    End Sub

    Private Sub SendMessageToGroup(sender As ChatControl, msg As String)
        Try
            'If cbType.Text <> "" Then TxtText.Text = cbType.Text
            ' If ClientIp = "" Or TxtText.Text = "" Then
            'MsgBox("Sorry Uncomplete data")
            'Else

            'client = New TcpClient(ClientIp, 44444)
            'Dim writer As New StreamWriter(client.GetStream())
            'writer.Write($"{UserTypeTitle} : {msg}")
            'writer.Flush()

            Dim cl = New Client(ClientIp, 44444)
            cl.Send(msg)
            'ServerListener.SendToClient(ClientIp, $"{UserTypeTitle} : {msg}")

            sender.ClearMessage()

            'End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SendMessageToPrivate1(sender As ChatControl, msg As String)
        Try
            'If cbType.Text <> "" Then TxtText.Text = cbType.Text
            ' If ClientIp = "" Or TxtText.Text = "" Then
            'MsgBox("Sorry Uncomplete data")
            'Else

            client = New TcpClient(ClientIp, 44444)
            Dim writer As New StreamWriter(client.GetStream())
            writer.Write($"{UserTypeTitle} : {msg}")
            writer.Flush()

            sender.ClearMessage()
            'End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SendMessageToPrivate2(sender As ChatControl, msg As String)
        Try
            'If cbType.Text <> "" Then TxtText.Text = cbType.Text
            ' If ClientIp = "" Or TxtText.Text = "" Then
            'MsgBox("Sorry Uncomplete data")
            'Else

            client = New TcpClient(ClientIp, 44444)
            Dim writer As New StreamWriter(client.GetStream())
            writer.Write($"{UserTypeTitle} : {msg}")
            writer.Flush()

            sender.ClearMessage()
            'End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ShowCustomMessageForm(sender As ChatControl)
        TopMost = False
        Dim frm As New SaveMSG With {
            .Tag = "SaveMSG"
        }
        frm.ShowDialog()
        PopulateSavedMessagesToCombo()
        TopMost = True
        sender.ClearMessage()
    End Sub

    Public Sub AddMsg(msg As String)
        'ListBoxGroupChat.Items.Add(msg)
    End Sub

    Private Sub FormChat_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        isShow = False
    End Sub

    Private Sub FormChat_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub

    Private Sub FormChat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetTabsTitle()
        PopulateSavedMessagesToCombo()
    End Sub

    Private Sub SetTabsTitle()
        If UserTypeTitle = ConstDrTitle Then

            TabPagePrivate1.Text = ConstMonshiTitle
            ChatControlPrivate1.Text = ConstMonshiTitle

            TabPagePrivate2.Text = ConstOtherTitle
            ChatControlPrivate2.Text = ConstOtherTitle

        ElseIf UserTypeTitle = ConstMonshiTitle Then

            TabPagePrivate1.Text = ConstDrTitle
            ChatControlPrivate1.Text = ConstDrTitle

            TabPagePrivate2.Text = ConstOtherTitle
            ChatControlPrivate2.Text = ConstOtherTitle

        Else

            TabPagePrivate1.Text = ConstDrTitle
            ChatControlPrivate1.Text = ConstDrTitle

            TabPagePrivate2.Text = ConstMonshiTitle
            ChatControlPrivate2.Text = ConstMonshiTitle

        End If
    End Sub

    'Private Sub BtnSend_Click(sender As Object, e As EventArgs)
    '    Try
    '        If cbType.Text <> "" Then TxtText.Text = cbType.Text
    '        If ClientIp = "" Or TxtText.Text = "" Then
    '            MsgBox("Sorry Uncomplete data")
    '        Else
    '            client = New TcpClient(ClientIp, 44444)
    '            Dim writer As New StreamWriter(client.GetStream())
    '            writer.Write($"{UserTypeTitle} : " + TxtText.Text)
    '            writer.Flush()

    '            ListBoxGroupChat.Items.Add($"من : " + TxtText.Text)
    '            TxtText.Text = ""
    '            cbType.Text = ""
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    'Private Sub TxtText_KeyDown(sender As Object, e As KeyEventArgs)
    '    If e.KeyCode = Keys.Enter Then
    '        BtnSend_Click(Nothing, Nothing)
    '    End If
    'End Sub

    'Private Sub BrowseButton_Click(sender As Object, e As EventArgs)
    '    TopMost = False
    '    Dim frm As New SaveMSG With {
    '        .Tag = "SaveMSG"
    '    }
    '    frm.ShowDialog()
    '    PopulateSavedMessagesToCombo()
    '    TopMost = True
    '    cbType.Text = ""

    'End Sub

    Private Sub PopulateSavedMessagesToCombo()
        Try
            Dim ado As New OleDbDataAdapter("SELECT Name FROM SaveMSG", AdoCon)
            Dim dt As New DataTable
            ado.Fill(dt)

            Dim convertToList = dt.ConvertToList("Name")
            ChatControlGroup.PopulateTextBoxCustomDataSource(convertToList)
            ChatControlPrivate1.PopulateTextBoxCustomDataSource(convertToList)
            ChatControlPrivate2.PopulateTextBoxCustomDataSource(convertToList)

        Catch ex As Exception
            Dim s = ex.Message
        End Try
    End Sub
End Class