

Public Class UForm

    Inherits Form
    Private VCriteria As String = ""
    Private VAction As String = ""

    Public Property Criteria() As String
        Get
            Return VCriteria
        End Get
        Set(ByVal value As String)
            VCriteria = value
        End Set
    End Property

    Public Property Action() As String
        Get
            Return VAction
        End Get
        Set(ByVal value As String)
            VAction = value
        End Set
    End Property

    Private Sub UForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
