

Imports System.IO
Imports System.Net.Sockets


Public Class Main

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim Frm As New Customer2VisitList
        Frm.ShowDialog()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Frm As New Customer
        Frm.ShowDialog()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Dim Frm As New RptVisit
        Frm.ShowDialog()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        End
    End Sub

    Sub CheckLock()

        Dim x As New Encryptor
        If x.GetReg(x.CpuId()) <> GetSetting("Kahvand", "Startup", "A09128120050") Then
            'If x.GetReg(x.HDDID()) <> GetSetting("PhonBook", "Startup", "A09128120050") Then
            If GetSetting("Kahvand", "Startup", "A09128120050") = "TERIAL" Then
                ' LblError.Text = "نسخه آزمايشي"
                ' CheckTrial()
            Else

                MsgBox("شما ابتدا بايد برنامه را رجيستر کنيد .")
                Dim frmR As New Register
                Code = 0
                frmR.ShowDialog()

                If Code = -1 Then
                    'CheckTrial()
                End If

                If Code = 0 Then
                    End
                End If

            End If
        End If


    End Sub


    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'یCheckLock()

        StrSource = My.Computer.FileSystem.CurrentDirectory.ToString

        If (My.Computer.FileSystem.FileExists(My.Computer.FileSystem.CurrentDirectory.ToString + "\Source.txt")) Then
            StrSource = My.Computer.FileSystem.ReadAllText(My.Computer.FileSystem.CurrentDirectory + "\Source.txt")
        End If

        Try
            AdoCon.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data source=" + StrSource + "\db2.mdb"
            AdoCon.Open()

        Catch ex As Exception
            MsgBox("در باز کردن بانک اطلاعاتی خطلای پیش آمده")
        End Try

        If Not (My.Computer.FileSystem.DirectoryExists(StrSource + "\Images")) Then My.Computer.FileSystem.CreateDirectory("Images")

        Dim X As New Globalization.PersianCalendar
        DateToday = X.GetYear(Now).ToString + "/" + X.GetMonth(Now).ToString + "/" + X.GetDayOfMonth(Now).ToString

        If Len(X.GetMonth(Now).ToString) < 2 Then
            DateToday = Mid(DateToday, 1, 5) + "0" + Mid(DateToday, 6)
        End If

        If Len(X.GetDayOfMonth(Now).ToString) < 2 Then
            DateToday = Mid(DateToday, 1, 8) + "0" + Mid(DateToday, 9)
        End If
        ' MsgBox(DateToday)

        Try
            Dim c As New System.Globalization.CultureInfo("fa-IR")
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(c)
        Catch ex As Exception
            MsgBox("سیستم عامل شما امکان پشتیبانی از زبان فارسی را ندارد .!!!")
        End Try

        Try
            CheckUpdate()
        Catch ex As Exception

        End Try

        DrId = 1
        UserId = 0
        Dim frm As New Login
        frm.ShowDialog()
        If UserId = 0 Or UserId = -1 Then
            End
        End If
        Me.Activate()

        txtDrName.Text = DrName

        If My.Settings.ServerIp <> "" Then
            ClientIp = My.Settings.ServerIp
            listerner.Start()
            Timer1.Enabled = True
            Timer1.Start()

        End If
        

    End Sub

    Private Sub CheckUpdate()
        Try
            Dim ado As New OleDb.OleDbDataAdapter("Select Top 1 * from TypePatient", AdoCon)
            Dim dt As New DataTable
            ado.Fill(dt)
        Catch ex As Exception
            Dim cmd As New OleDb.OleDbCommand("Create TABLE TypePatient (ID IDENTITY(1,1),Name Text(255))", AdoCon)
            cmd.ExecuteNonQuery()
        End Try

        Try
            Dim ado As New OleDb.OleDbDataAdapter("Select Top 1 Address from Customer", AdoCon)
            Dim dt As New DataTable
            ado.Fill(dt)
        Catch ex As Exception
            Dim cmd As New OleDb.OleDbCommand("Alter TABLE Customer Add COLUMN Address Text(255) , IdTypePatient int;", AdoCon)
            cmd.ExecuteNonQuery()
        End Try

        Try
            Dim ado As New OleDb.OleDbDataAdapter("Select Top 1 Price from TypePatient", AdoCon)
            Dim dt As New DataTable
            ado.Fill(dt)
        Catch ex As Exception
            Dim cmd As New OleDb.OleDbCommand("Alter TABLE TypePatient Add COLUMN Price Text(255) ", AdoCon)
            cmd.ExecuteNonQuery()
        End Try


        Try
            Dim ado As New OleDb.OleDbDataAdapter("Select Top 1 * from SaveMSG", AdoCon)
            Dim dt As New DataTable
            ado.Fill(dt)
        Catch ex As Exception
            Dim cmd As New OleDb.OleDbCommand("Create TABLE SaveMSG (ID IDENTITY(1,1),Name Text(255))", AdoCon)
            cmd.ExecuteNonQuery()
        End Try

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Try
            Dim SFD As New SaveFileDialog
            SFD.InitialDirectory = Application.StartupPath + "\BackUp"
            SFD.FileName = Replace(DateToday, "/", "-") + "#" + TimeOfDay.Hour.ToString("00") + "_" + TimeOfDay.Minute.ToString("00")

            If SFD.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Dim x As New ECP.ZipUtility
                AdoCon.Close()
                x.CompressFile(Application.StartupPath + "\" + "db2.mdb", SFD.FileName)
                AdoCon.Open()
                MsgBox("عملیات پشتیبان گیری انجام شد .")
            End If

        Catch ex As Exception
            MsgBox("با خطا مواجه شدیم . لطفا از برنامه خارج شده و دوباره تلاش نمایید. پشتیبان گیری فقط از روی سرور امکان پذیر است .")
        End Try
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim OFD As New OpenFileDialog
        If OFD.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim x As New ECP.ZipUtility
            AdoCon.Close()
            x.DecompressFile(OFD.FileName, Application.StartupPath + "\" + "db2.mdb")
            AdoCon.Open()
            MsgBox("باز گرداني اطلاعات انجام شد .")
            MsgBox("برای مشاهده تنظیمات و اطلاعات قبلی باید از برنامه خارج شده و دوباره وارد شوید")
            End
        End If
    End Sub

    Private Sub btnUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUser.Click
        Dim frm As New Users
        frm.ShowDialog()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        'If My.Settings.SystemStatus = "Server" Then
        '    Dim frm As New Server
        '    frm.ShowDialog()
        'ElseIf My.Settings.SystemStatus = "Client" Then
        '    Dim frm As New Client
        '    frm.ShowDialog()
        'End If

        If Not isShow Then
            Chat.Show()
            isShow = True
        End If


    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try
            If listerner.Pending = True Then
                'Dim frmChat As New Chat

   
                Message = ""
                client = listerner.AcceptTcpClient
                Dim reader As New StreamReader(client.GetStream())
                While reader.Peek > -1
                    Message = Message + Convert.ToChar(reader.Read()).ToString
                End While

                If Message <> "" Then
                    If Mid(Message, 1, 1) = "#" Then
                        If Mid(Message, 1, 4) = "#CMR" Then
                            Dim st = Mid(Message, 5)

                            If MessageBox.Show("اطلاعات بیمار ارسال شده آیا مشاهده می کنید ؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

                                Dim Cmd As New OleDb.OleDbCommand("Select * from Customer where Id = " + st, AdoCon)
                                Dim dr As OleDb.OleDbDataReader = Cmd.ExecuteReader()
                                dr.Read()
                                If Not dr.HasRows Then Exit Sub
                                Dim Frm As New Editor
                                Frm.TFk_Customer.Text = dr("Id").ToString()
                                Frm.TName.Text = dr("Family").ToString() + " " + dr("Name").ToString() 'DG.CurrentRow.Cells("فامیلی").Value + " " + DG.CurrentRow.Cells("نام").Value

                                NI.BalloonTipTitle = dr("Family").ToString() + " " + dr("Name").ToString()
                                NI.BalloonTipText = "بیمار مراجعه کننده"
                                NI.Text = dr("Family").ToString() + " " + dr("Name").ToString()
                                NI.ShowBalloonTip(20)
                                dr.Close()
                                Frm.ShowDialog()

                            End If


                            Exit Sub
                        End If
                    End If
                End If


                If Not isShow Then
                    Chat.Show()
                    isShow = True
                End If

                Me.Focus()

                Chat.AddMsg(Message)

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class