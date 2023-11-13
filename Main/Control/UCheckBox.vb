Public Class UCheckBox
    Inherits CheckBox

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub UCheckBox_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Enter
        Me.BackColor = Color.Bisque
    End Sub

    Private Sub UCheckBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Right Then
            SendKeys.Send("{Tab}")
        End If
        If e.KeyCode = Keys.Left Then
            SendKeys.Send("+{Tab}")
        End If
    End Sub

    Private Sub UCheckBox_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Leave
        Me.BackColor = Nothing

    End Sub
End Class
