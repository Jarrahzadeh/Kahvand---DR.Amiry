Imports System.Net.Sockets

Module Module1
    Public AdoCon As New OleDb.OleDbConnection
    Public DateToday As String
    Public StrSource As String
    Public Code_Customer As String
    Public UserId As Int32
    Public DrId As Int32
    Public DrName As String

    Public St As String

    Public Code As Integer


    Public listerner As New TcpListener(44444)
    Public client As TcpClient
    Public isShow As Boolean
    'Public frmChat As New Chat
    Public ClientIp As String
    Public Message As String


    Public Sub Reset(ByVal X As Object)
        For Each Obj As Control In X.Controls
            If TypeOf Obj Is TextBox Then
                Obj.Text = ""
            End If
        Next
    End Sub
End Module
