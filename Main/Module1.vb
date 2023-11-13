Imports System.Net.Sockets
Imports Ophthalmology.Utility.Classes
Imports Ophthalmology.Utility.Connection
Imports Ophthalmology.Utility.Helpers

Module Module1
    Public AdoCon As New OleDb.OleDbConnection
    Public DateToday As String = DateTimeHelper.GetPersianDate()
    Private _userTypeTitle As String
    Public ReadOnly Property UserTypeTitle As String
        Get
            If Not String.IsNullOrWhiteSpace(_userTypeTitle) Then
                Return _userTypeTitle
            End If

            If My.Settings.SystemStatus = "Server" Then
                _userTypeTitle = ConstDrTitle
            ElseIf My.Settings.SystemStatus = "Client" Then
                _userTypeTitle = ConstMonshiTitle
            Else
                _userTypeTitle = ConstOtherTitle
            End If

            Return _userTypeTitle
        End Get
    End Property

    Public StrSource As String
    Public Code_Customer As String
    Public UserId As Int32
    Public DrId As Int32
    Public DrName As String

    Public St As String

    Public Code As Integer

    Public ServerListener As Server
    'Public listerner As New TcpListener(44444)
    Public client As TcpClient
    Public isShow As Boolean
    'Public frmChat As New Chat
    Public ClientIp As String
    Public Message As String

    Public Const ConstDrTitle As String = "دکتر"
    Public Const ConstMonshiTitle As String = "منشی"
    Public Const ConstOtherTitle As String = "اپتومتریست"

    Public Sub Reset(ByVal X As Object)
        For Each Obj As Control In X.Controls
            If TypeOf Obj Is TextBox Then
                Obj.Text = ""
            End If
        Next
    End Sub
End Module
