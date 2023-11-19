Imports Ophthalmology.Utility.Helpers

Public Class Visit
    Dim X1, Y1 As Integer
    Dim Flag As Byte = 0


    Private Sub Visit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TDateVisit.Text = DateTimeHelper.GetPersianDate
        '        Pb.a()

    End Sub

    Private Sub Visit_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove


    End Sub

    Private Sub Pb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pb.Click

    End Sub

    Private Sub Pb_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Pb.MouseMove

        If e.Button = MouseButtons.Left Then
            If X1 <> 0 And Y1 <> 0 Then

                If Flag = 1 Then
                    Dim pe As New Pen(Color.Black, Val(TB.Value))
                    Dim ge As Graphics = Pb.CreateGraphics()
                    ge.FillEllipse(Brushes.White, e.X, e.Y, 15, 15)
                ElseIf Flag = 0 Then
                    Dim p As New Pen(Color.Black, Val(TB.Value))
                    Dim g As Graphics = Pb.CreateGraphics()
                    g.DrawLine(p, X1, Y1, e.X, e.Y)
                End If
            End If

            X1 = e.X
            Y1 = e.Y
        End If


    End Sub
    Private Sub Pb_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Pb.MouseUp
        X1 = 0
        Y1 = 0
    End Sub
    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()

    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click


        Dim St As String = TDateVisit.Text.Replace("/", "-") + "#" + TFk_Customer.Text
        Dim CmdExist As New OleDb.OleDbCommand("Select Count(*) From Images Where DateVisit ='" + TDateVisit.Text + "'", AdoCon)
        St = St + "=" + CmdExist.ExecuteScalar().ToString + ".jpg"

        Dim bmp As New Bitmap(Pb.Width, Pb.Height)
        Dim g As Graphics = Graphics.FromImage(bmp)

        If LblStatus.Text = "ویرایش" Then
            g.CopyFromScreen(Me.Left + Pb.Left, Me.Top + Pb.Top + 25, 0, 0, Pb.Size)
            bmp.Save(StrSource + "\Images\" + LblPicName.Text)


            Dim Frm As New OldVisit
            Frm.TFk_Customer.Text = TFk_Customer.Text
            Frm.TName.Text = TName.Text
            Frm.Show()


            Me.Close()
            Exit Sub
        End If

        'Try

       
        g.CopyFromScreen(Me.Left + Pb.Left, Me.Top + Pb.Top + 25, 0, 0, Pb.Size)
        bmp.Save(StrSource + "\Images\" + St)

        'Catch ex As Exception
        '    MsgBox("خطای در ذخیره عکس روخ داده - ویزیت را دستی وارد کنید")
        'End Try

        Try
            Dim Cmd As New OleDb.OleDbCommand("insert into Images(Name,Fk_Customer,DateVisit)" & _
           " Values(@Name,@Fk_Customer,@DateVisit)", AdoCon)

            Cmd.Parameters.Add("@Name", OleDb.OleDbType.VarChar).Value = St
            Cmd.Parameters.Add("@Fk_Customer", OleDb.OleDbType.Numeric).Value = TFk_Customer.Text
            Cmd.Parameters.Add("@DateVisit", OleDb.OleDbType.VarChar).Value = TDateVisit.Text
            Cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("خطای در ذخیره در دیتابیس رخ داده است")
        End Try


        Try

            Dim CmdVisitList As New OleDb.OleDbCommand("Update VisitList Set Status = 'ویزیت شده' Where Code_customer = " + TFk_Customer.Text + " and DateVisit = '" + TDateVisit.Text + "'", AdoCon)
            CmdVisitList.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("خطای در تغییر وضعیت به دلیل همزمانی تغییر اطلاعات ")
            Try

                Dim CmdVisitList2 As New OleDb.OleDbCommand("Update VisitList Set Status = 'ویزیت شده' Where Code_customer = " + TFk_Customer.Text + " and DateVisit = '" + TDateVisit.Text + "'", AdoCon)
                CmdVisitList2.ExecuteNonQuery()

                MsgBox("اطلاعات ثبت شد .")

            Catch ex21 As Exception

            End Try


        End Try



        Me.Close()

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Refresh()
    End Sub


    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click
        Flag = 1

    End Sub

    Private Sub BtnPen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPen.Click
        Flag = 0
    End Sub

    Private Sub btnOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpen.Click

        Dim x As New OpenFileDialog
        If x.ShowDialog() = DialogResult.OK Then
            Pb.Image = Image.FromFile(x.FileName)

        End If

    End Sub
End Class