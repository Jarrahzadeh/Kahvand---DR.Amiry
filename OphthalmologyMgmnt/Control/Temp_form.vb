Public Class Temp_form

    Private Sub Temp_form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Dim Gb As String
    Dim x As Control
    Dim _firstControl As Control

    Dim min As Int32 = 100
    Function GetListObjectData3(ByVal obj As Control) As String
        Dim itemX As Object
        For Each itemX In obj.Controls
            If TypeOf itemX Is GroupBox Then
                Dim gItemX As GroupBox = itemX
                Gb = gItemX.Text
                St += St
                GetListObjectData3(itemX)
                Gb = ""
            Else
                GetFirstControl(obj)
                x.Focus()
                x.Select()
                _firstControl = x
                itemX = _firstControl
                Do
                    If TypeOf itemX Is UTextBox Then
                        Dim txt As TextBox = itemX
                        If txt.Text <> "" Then
                            St += txt.Tag + ":" + txt.Text + " - "
                        End If
                    ElseIf TypeOf itemX Is CheckBox Then
                        Dim chk As CheckBox = itemX
                        If chk.Checked Then
                            St += chk.Tag + ":" + chk.Text + " - "
                        End If
                    End If

                    itemX = GetNextControl(itemX, False)
                    'End While
                    If x Is Nothing Then
                        Exit Do
                    End If
                Loop While itemX.Name <> _firstControl.Name

            End If

        Next
        St += vbCrLf
        Return St
    End Function



    Private Sub GetListObjectData2(ByVal form As Control)
        GetFirstControl(form)
        x.Focus()
        x.Select()
        _firstControl = x

        'x = Me.GetNextControl(x, True)

        ' If TypeOf x Is GroupBox Then
        '     MsgBox(x.Name)
        ' End If
        Do

            If TypeOf x Is GroupBox And form.Name <> x.Name Then
                Dim gItemX As GroupBox = x
                Gb = gItemX.Text
                St += St
                GetListObjectData2(x)
                Gb = ""
            ElseIf TypeOf x Is TextBox Then
                Dim txt As TextBox = x
                If txt.Text <> "" Then
                    St += txt.Tag + ":" + txt.Text + " - "
                End If
            ElseIf TypeOf x Is CheckBox Then
                Dim chk As CheckBox = x
                If chk.Checked Then
                    St += chk.Tag + ":" + chk.Text + " - "
                End If
            End If
            ' x = Me.GetNextControl(x, True)
            'While (Not (TypeOf x Is TextBox))
            Dim z = x
            x = Me.GetNextControl(x, False)
            'End While
            If x Is Nothing Then
                Exit Sub
            End If
        Loop While x.Name <> _firstControl.Name

        ' x.Focus()

        St += vbCrLf
    End Sub
    Function GetFirstControl(ByVal itemX As Control) As Control
        For Each itemX In itemX.Controls
            If TypeOf itemX Is TextBox Then
                Dim txt As TextBox = itemX
                If txt.TabIndex < min Then
                    x = itemX
                    min = txt.TabIndex
                End If
            ElseIf TypeOf itemX Is GroupBox Then
                GetFirstControl(itemX)
            End If
        Next
        Return Nothing
    End Function



    Private Sub ParentForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'ResetObjects(Me)
    End Sub

    'Function GetListObjectData(ByVal obj As Control) As String
    '    Dim itemX As Object
    '    For Each itemX In obj.Controls
    '        If TypeOf itemX Is GroupBox Then
    '            Dim gItemX As GroupBox = itemX
    '            Gb = gItemX.Text
    '            St += St
    '            GetListObjectData(itemX)
    '            Gb = ""
    '        ElseIf TypeOf itemX Is TextBox Then
    '            Dim txt As TextBox = itemX
    '            If txt.Text <> "" Then
    '                St += txt.Tag + ":" + txt.Text + " - "
    '            End If
    '        ElseIf TypeOf itemX Is TextBox Then
    '            Dim chk As CheckBox = itemX
    '            If chk.Checked Then
    '                St += chk.Tag + ":" + chk.Text + " - "
    '            End If
    '        End If

    '    Next
    '    St += vbCrLf
    '    Return St
    'End Function

    'Sub GetData(ByVal itemX As Control)
    '    If TypeOf itemX Is TextBox Then
    '        Dim txt As TextBox = itemX
    '        If txt.Text <> "" Then
    '            St += txt.Tag + ":" + txt.Text + " - "
    '        End If
    '    ElseIf TypeOf itemX Is TextBox Then
    '        Dim chk As CheckBox = itemX
    '        If chk.Checked Then
    '            St += chk.Tag + ":" + chk.Text + " - "
    '        End If
    '    ElseIf TypeOf itemX Is GroupBox Then
    '        GetListObjectData(itemX)
    '    End If

    '  End Sub













End Class