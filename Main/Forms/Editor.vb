Public Class Editor
    Dim textCurent As String
    Dim IsSave As Boolean = False
    Dim t As Int64

    Sub CallDtl(ByVal x As String)
        IsSave = True
        St = ""
        Select Case x
            Case "F1"
                F1_Ref.ShowDialog()
            Case "F2"
                F2_Cat.ShowDialog()
            Case "F3"
                F3_Cornea.ShowDialog()
            Case "F4"
                F4_Strabisam.ShowDialog()
            Case "F5"
                F5_Fundus.ShowDialog()
            Case "F6"
                F6_Conjunctiva.ShowDialog()
            Case "F7"
                F7_Nld.ShowDialog()
            Case "F8"
                F8_Lid.ShowDialog()
            Case "F9"
                F9_Surgery.ShowDialog()

        End Select
        textCurent += textCurent + St
        rtbMain.Text = St + rtbMain.Text

        ViewGrapicData()


    End Sub

    Private Sub Editor_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If IsSave = True Then
            Dim x = MessageBox.Show("ایا می خواهید داده ها ذخیره شود ؟", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If x = DialogResult.Yes Then
                BtnSave_Click(Nothing, Nothing)
            End If
            If x = DialogResult.Cancel Then
                e.Cancel = True
            End If
        End If

        My.Settings.EditorSize = Me.Size
        My.Settings.Save()

    End Sub
    Private Sub Editor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            CallDtl("F1")
        ElseIf e.KeyCode = Keys.F2 Then
            CallDtl("F2")
        ElseIf e.KeyCode = Keys.F3 Then
            CallDtl("F3")
        ElseIf e.KeyCode = Keys.F4 Then
            CallDtl("F4")
        ElseIf e.KeyCode = Keys.F5 Then
            CallDtl("F5")
        ElseIf e.KeyCode = Keys.F6 Then
            CallDtl("F6")
        ElseIf e.KeyCode = Keys.F7 Then
            CallDtl("F7")
        ElseIf e.KeyCode = Keys.F8 Then
            CallDtl("F8")
        ElseIf e.KeyCode = Keys.F9 Then
            CallDtl("F9")
        End If
    End Sub

    Private Sub Editor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            Me.Size = My.Settings.EditorSize

            txtDrName.Text = DrName

            Dim c As New System.Globalization.CultureInfo("En")
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(c)


            TDateVisit.Text = DateToday

            For i As Int16 = 5 To 72
                CbFont.Items.Add(i)
            Next
            CbFont.Text = 12
            LblStatus.Text = 0
            Dim Cmd As New OleDb.OleDbCommand("Select * from TblText where Fk_Customer = " + TFk_Customer.Text)
            Cmd.Connection = AdoCon
            Dim dr As Data.OleDb.OleDbDataReader = Cmd.ExecuteReader()
            dr.Read()
            If dr.HasRows Then
                rtbMain.Text = dr("TextVisit").ToString()
                lblId.Text = dr("id").ToString()
                LblStatus.Text = 1
            End If
            '  RTxt.Text = vbCrLf + "---------------------------" + DateToday + RTxt.Text

            ViewGrapicData()

            Dim Ado As New OleDb.OleDbDataAdapter("SELECT CustomerForm.Age, TypePatient.Name, TypePatient.Price,CustomerForm.Address FROM CustomerForm INNER JOIN TypePatient ON CustomerForm.IdTypePatient = TypePatient.ID where CustomerForm.id = " + TFk_Customer.Text, AdoCon)
            Dim Dt As New DataTable
            Ado.Fill(Dt)
            txtAge.Text = Dt.Rows(0)(0).ToString()
            txtType.Text = Dt.Rows(0)(1).ToString()
            txtAddress.Text = Dt.Rows(0)("Address").ToString()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ViewGrapicData()
        Dim range As Int32

        While (True)
            range = rtbMain.Find("OS", range, RichTextBoxFinds.None)
            range += 1
            rtbMain.SelectionColor = Color.Blue
            If range = 0 Then Exit While
        End While

        While (True)
            range = rtbMain.Find("OD", range, RichTextBoxFinds.None)
            range += 1
            rtbMain.SelectionColor = Color.Red
            If range = 0 Then Exit While
        End While

        Dim keyWord() As String = {"Strabism", "Cornea", "Cat", "Cont", "Lens", "ref", "GL", "Pre", "Fundus", "ARMD", "Vascular", "DRP", "Conjunctiva", "NLD", "Lid", "ptosis", "Surgery"}

        Dim i As Integer = 0
        While (i <> keyWord.Count() - 1)
            Dim key = keyWord(i)
            While (True)
                range = rtbMain.Find(key, range, RichTextBoxFinds.None)
                range += 1
                rtbMain.SelectionColor = Color.ForestGreen
                Dim x As FontStyle = rtbMain.SelectionFont.Style
                x = FontStyle.Bold
                rtbMain.SelectionFont = New Font(rtbMain.SelectionFont.FontFamily, rtbMain.SelectionFont.Size, x)
                If range = 0 Then Exit While

            End While
            i += 1
        End While


    End Sub

    Private Sub CbFont_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbFont.SelectedIndexChanged

        rtbMain.Font = New Font(rtbMain.Font.FontFamily, Val(CbFont.Text))


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Not isShow Then
            ChatForm.Show()
            isShow = True
        End If
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()

    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        IsSave = False


        rtbMain.Text = rtbMain.Text.Replace("------------------------------------------------" + DateToday, "")
        rtbMain.Text = vbCrLf + "------------------------------------------------" + DateToday + vbCrLf + rtbMain.Text

        Dim ststusBimar As String = "ویزیت شده"
        If My.Settings.SystemStatus = "Other" Then ststusBimar = "اپتومتری"

        Dim CmdVisitList As New OleDb.OleDbCommand("Update VisitList Set Status = '" + ststusBimar + "' Where Code_customer = " + TFk_Customer.Text + " and DateVisit = '" + TDateVisit.Text + "'", AdoCon)
        CmdVisitList.ExecuteNonQuery()


        If LblStatus.Text = 0 Then
            Dim Cmd As New OleDb.OleDbCommand("insert into TblText(Fk_Customer,DateVisit,textvisit)" & _
            " Values(@Fk_Customer,@DateVisit,@textVisit)", AdoCon)
            Cmd.Parameters.Add("@Fk_Customer", OleDb.OleDbType.Numeric).Value = TFk_Customer.Text
            Cmd.Parameters.Add("@DateVisit", OleDb.OleDbType.VarChar).Value = TDateVisit.Text
            Cmd.Parameters.Add("@text", OleDb.OleDbType.VarChar).Value = rtbMain.Text
            Cmd.ExecuteNonQuery()
        End If

        If LblStatus.Text = 1 Then

            Dim Cmd As New OleDb.OleDbCommand("update TblText set Fk_Customer=@Fk_Customer,DateVisit=@DateVisit,textvisit=@textVisit where id = " + lblId.Text, AdoCon)
            Cmd.Parameters.Add("@Fk_Customer", OleDb.OleDbType.Numeric).Value = TFk_Customer.Text
            Cmd.Parameters.Add("@DateVisit", OleDb.OleDbType.VarChar).Value = TDateVisit.Text
            Cmd.Parameters.Add("@textVisit", OleDb.OleDbType.VarChar).Value = rtbMain.Text
            Cmd.ExecuteNonQuery()

        End If

        Dim Cat As Boolean
        Dim Strabism As Boolean
        Dim NLD As Boolean
        Dim Lid As Boolean

        If InStr(1, textCurent, "Cat") Then
            Cat = True
        End If

        If InStr(1, textCurent, "Strabism") Then
            Strabism = True
        End If

        If InStr(1, textCurent, "NLD") Then
            NLD = True
        End If

        If InStr(1, textCurent, "Lid") Then
            Lid = True
        End If
        If Cat Or Strabism Or NLD Or Lid Then
            Dim CmdAmar As New OleDb.OleDbCommand("insert into Amar (idCustomer, DateVisit, CAT, Strabism, NLD, LID) Values (@idCustomer, @DateVisit, @CAT, @Strabism, @NLD, @LID)", AdoCon)
            CmdAmar.Parameters.Add("@idCustomer", OleDb.OleDbType.Integer).Value = TFk_Customer.Text
            CmdAmar.Parameters.Add("@DateVisit", OleDb.OleDbType.VarChar).Value = TDateVisit.Text
            CmdAmar.Parameters.Add("@CAT", OleDb.OleDbType.Boolean).Value = Cat
            CmdAmar.Parameters.Add("@Strabism", OleDb.OleDbType.Boolean).Value = Strabism
            CmdAmar.Parameters.Add("@NLD", OleDb.OleDbType.Boolean).Value = NLD
            CmdAmar.Parameters.Add("@LID", OleDb.OleDbType.Boolean).Value = Lid
            CmdAmar.ExecuteNonQuery()
        End If


        Me.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        CallDtl("F1")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        CallDtl("F2")

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        CallDtl("F3")

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        CallDtl("F4")

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        CallDtl("F5")

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        CallDtl("F6")

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        CallDtl("F7")

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        CallDtl("F8")

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        CallDtl("F9")

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        t += 1
        lblTime.Text = (t \ 60).ToString("00") + ":" + (t Mod 60).ToString("00")

    End Sub

    Private Sub rtbMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles rtbMain.KeyDown
        IsSave = True
    End Sub

    Private Sub rtbMain_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rtbMain.TextChanged


    End Sub

    Private Sub کپیToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles کپیToolStripMenuItem.Click
        rtbMain.Copy()

    End Sub

    Private Sub الحاقToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles الحاقToolStripMenuItem1.Click

        rtbMain.Paste()

    End Sub
End Class