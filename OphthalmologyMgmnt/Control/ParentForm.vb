Imports System.Runtime.InteropServices

Public Class ParentForm

    Dim arr(100) As Control
    Dim i As Int32 = 1

    Private Sub ParentForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ReDim arr(100)
        i = 1
        GetAllControl(Me)
        SortControl()
        GenarateString()
    End Sub

    Sub GenarateString()
        St = ""
        Dim parentControl As New Control
        For j As Int32 = 1 To i - 1
            Dim itemX As Control = arr(j)

            If TypeOf itemX Is UTextBox Then
                Dim txt As TextBox = itemX
                If txt.Text <> "" Then

                    If itemX.Parent.Name <> IIf(parentControl Is Nothing, "", parentControl.Name) Then
                        St += vbCrLf + itemX.Parent.Text + vbCrLf + "     "
                        parentControl = itemX.Parent
                    End If

                    If txt.Tag = "*" Then St = Mid(St, 1, St.Length - 3)
                    St += txt.Tag + IIf(txt.Tag = "*", "", ":") + txt.Text + "       "

                End If
            ElseIf TypeOf itemX Is CheckBox Then
                Dim chk As CheckBox = itemX
                If chk.Checked Then

                    If itemX.Parent.Name <> IIf(parentControl Is Nothing, "", parentControl.Name) Then
                        St += vbCrLf + itemX.Parent.Text + vbCrLf + "      "
                        parentControl = itemX.Parent
                    End If

                    St += chk.Text + "       "
                End If
            End If
        Next

    End Sub

    Function GetAllControl(ByVal itemX As Control)

        For Each itemX In itemX.Controls
            If TypeOf itemX Is UTextBox Then
                arr(i) = itemX
                i += 1
            ElseIf TypeOf itemX Is UCheckBox Then
                arr(i) = itemX
                i += 1
            ElseIf TypeOf itemX Is GroupBox Then
                GetAllControl(itemX)
            End If
        Next

    End Function

    Sub SortControl()
        For k As Int32 = 1 To i - 1
            For j As Int32 = 1 To i - 1
                If arr(k).TabIndex < arr(j).TabIndex Then
                    Dim temp = arr(j)
                    arr(j) = arr(k)
                    arr(k) = temp
                End If
            Next
        Next
    End Sub

    Dim x As Object

    Function ResetObjects(ByVal obj As Control) As Object
        Dim itemX As Object
        For Each itemX In obj.Controls
            If TypeOf itemX Is GroupBox Then
                ResetObjects(itemX)
            ElseIf TypeOf itemX Is UTextBox Then
                Dim txt As TextBox = itemX
                txt.Text = ""
                If txt.TabIndex = 1 Then
                    x = txt
                End If
            ElseIf TypeOf itemX Is UCheckBox Then
                Dim chk As CheckBox = itemX
                chk.Checked = False
                If chk.TabIndex = 1 Then x = chk
            End If
        Next

        Return x
    End Function

    Private Sub ParentForm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyValue = Keys.Escape Then
            Me.Close()
        End If
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub ParentForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim x = ResetObjects(Me)

        'If TypeOf x Is UTextBox Then
        '    Dim txt As UTextBox = x
        '    txt.Focus()

        'ElseIf TypeOf x Is UCheckBox Then
        '    Dim chk As UCheckBox = x
        '    chk.Focus()
        'End If

    End Sub
End Class