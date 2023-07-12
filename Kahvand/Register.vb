Public Class Register
    Dim x As New Encryptor

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If TxtEnCode.Text = "1" Then

            Exit Sub
        End If
        If x.GetReg(TxtSerial.Text) = TxtEnCode.Text.Replace("-", "") Then
            SaveSetting("Kahvand", "Startup", "A09128120050", x.GetReg(TxtSerial.Text))
            MsgBox("کد شما پذيرفته شد .  از خريد شما سپاس گذاريم .")
            Code = 1
            Close()
        Else
            MsgBox("کد شما صحيح نيست . با دقت بيشتر دوباره تلاش کنيد .")

        End If

    End Sub

    Private Sub Register_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TxtSerial.Text = x.CpuId  ' + "---" + SerialNumberSystem()
 
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Close()
    End Sub
End Class