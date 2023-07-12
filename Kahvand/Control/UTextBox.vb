Public Class UTextBox
   Inherits TextBox
    Private _vIsNumber As Boolean = False
    Private _vIsSplit As Boolean = True
    Private _vValue As String
    Private _currentLanguage As InputLanguage
    Private _vIsLanguage As Language = Language.Defualt



    Public Enum Language
        Farsi
        English
        Defualt
    End Enum

    Public Property IsSplit() As Boolean
        Get
            Return _vIsSplit
        End Get
        Set(ByVal value As Boolean)
            _vIsSplit = value
        End Set
    End Property

    Public Property IsNumber() As Boolean
        Get
            Return _vIsNumber
        End Get
        Set(ByVal value As Boolean)
            _vIsNumber = value
        End Set
    End Property

    Public Property IsLanguage() As Language
        Get
            Return _vIsLanguage
        End Get
        Set(ByVal value As Language)
            _vIsLanguage = value
        End Set
    End Property

    Private Sub UTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If Me.Text = "" And e.KeyCode = Keys.Right Then
            'SendKeys("{Tab}")
            SendKeys.Send("{Tab}")
        End If
        If Me.Text = "" And e.KeyCode = Keys.Left Then
            SendKeys.Send("+{Tab}")
        End If
    End Sub


    Private Sub UTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LostFocus
        If _vIsLanguage <> Language.Defualt Then
            InputLanguage.CurrentInputLanguage = _currentLanguage
        End If
        Me.BackColor = Color.White
    End Sub

    Private Sub UTextBox_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        If _vIsLanguage <> Language.Defualt Then
            _currentLanguage = InputLanguage.CurrentInputLanguage
            If _vIsLanguage = Language.Farsi Then
                Dim c As New System.Globalization.CultureInfo("fa-IR")
                InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(c)
            ElseIf _vIsLanguage = Language.English Then
                Dim c As New System.Globalization.CultureInfo("En")
                InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(c)
            End If

        End If
        Me.BackColor = Color.Wheat
    End Sub

    Private Sub UTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If IsNumber = True Then
            'If (e.KeyChar = ".") Or (e.KeyChar = vbBack) Or (e.KeyChar = "-") Then Exit Sub
            'If ((e.KeyChar < "0") Or (e.KeyChar > "9")) Then
            '    e.KeyChar = ""
            'End If
        End If
    End Sub


    Private Sub UTextBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.TextChanged
        'If IsNumber = True And _vIsSplit = True Then
        '    Dim Number As Decimal
        '    If Decimal.TryParse(sender.Text, Number) Then
        '        sender.Text = String.Format("{0:N0}", Number)
        '        sender.SelectionStart = sender.Text.Length
        '    End If
        'End If
    End Sub

    Public Property Value() As String
        Get
            If _vValue <> "" Then
                Return _vValue.Replace(",", "")
            Else
                Return ""
            End If
        End Get
        Set(ByVal value As String)
            _vValue = value
        End Set
    End Property

    Public Overrides Property Text() As String
        Get
            Return MyBase.Text
        End Get
        Set(ByVal value As String)
            MyBase.Text = value
            _vValue = value
        End Set
    End Property


End Class
