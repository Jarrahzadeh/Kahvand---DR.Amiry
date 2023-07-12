Public Class OldVisit

    Private Sub OldVisit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim Ado As New OleDb.OleDbDataAdapter("Select * From images where Fk_Customer = " + TFk_Customer.Text + " Order By id Desc", AdoCon)
        Dim Dt As New DataTable
        Ado.Fill(Dt)

        CbPicList.DataSource = Dt
        CbPicList.DisplayMember = "Name"
        CbPicList.ValueMember = "DateVisit"


        Dim Adotext As New OleDb.OleDbDataAdapter("Select * From tbltext where Fk_Customer = " + TFk_Customer.Text + " Order By id Desc", AdoCon)
        Dim Dttext As New DataTable
        Adotext.Fill(Dttext)

        CbText.DataSource = Dttext
        CbText.DisplayMember = "Datevisit"
        CbText.ValueMember = "id"


        Try
            Pic1.ImageLocation = StrSource + "\Images\" + Dt.Rows(0)("Name").ToString
            Pic1.Tag = Dt.Rows(0)("Name").ToString
            Pic2.ImageLocation = StrSource + "\Images\" + Dt.Rows(1)("Name").ToString
            Pic2.Tag = Dt.Rows(0)("Name").ToString
            Pic3.ImageLocation = StrSource + "\Images\" + Dt.Rows(2)("Name").ToString
            Pic3.Tag = Dt.Rows(0)("Name").ToString
            Pic4.ImageLocation = StrSource + "\Images\" + Dt.Rows(3)("Name").ToString
            Pic4.Tag = Dt.Rows(0)("Name").ToString

        Catch ex As Exception

        End Try


        Dim Adotxt As New OleDb.OleDbDataAdapter("Select * From tbltext where Fk_Customer = " + TFk_Customer.Text + " Order By id Desc", AdoCon)
        Dim Dttxt As New DataTable
        Adotxt.Fill(Dttxt)
        If Dttxt.Rows.Count >= 1 Then TXT1.Text = Dttxt.Rows(0)("textvisit").ToString : TXT1.Tag = Dttxt.Rows(0)("id").ToString
        If Dttxt.Rows.Count >= 2 Then Txt2.Text = Dttxt.Rows(1)("textvisit").ToString : Txt2.Tag = Dttxt.Rows(1)("id").ToString
        If Dttxt.Rows.Count >= 3 Then Txt3.Text = Dttxt.Rows(2)("textvisit").ToString : Txt3.Tag = Dttxt.Rows(2)("id").ToString
        If Dttxt.Rows.Count >= 4 Then Txt4.Text = Dttxt.Rows(3)("textvisit").ToString : Txt4.Tag = Dttxt.Rows(3)("id").ToString

    End Sub

    Private Sub Pic1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pic1.Click, Pic2.Click, Pic3.Click, Pic4.Click

        Pb.Image = sender.Image
        Pb.Tag = sender.Tag

    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click

        Me.Close()

    End Sub

    Private Sub CbPicList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbPicList.SelectedIndexChanged

        Pb.ImageLocation = StrSource + "\Images\" + CbPicList.Text
        Pb.Tag = CbPicList.Text

    End Sub

    Private Sub Pb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pb.Click

    End Sub

    Private Sub Pb_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Pb.DoubleClick

        If TName.Text = "" Then
            MsgBox("ویزیتی برای ویرایش وجود ندارد")
            Exit Sub
        End If

        Dim Frm As New Visit
        Frm.TFk_Customer.Text = TFk_Customer.Text
        Frm.TName.Text = TName.Text
        Frm.LblPicName.Text = Pb.Tag
        'Frm.LblStatus.Text = "ویرایش"
        Frm.Pb.Image = Pb.Image
        Frm.Show()
        Me.Close()

    End Sub

    Private Sub B2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B2.Click
        Pb_DoubleClick(Nothing, Nothing)
    End Sub

    Private Sub TXT1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TXT1.DoubleClick, Txt2.DoubleClick, Txt3.DoubleClick, Txt4.DoubleClick

        If sender.tag = "" Then
            MsgBox("اطلاعاتی موجود نیست .")
            Exit Sub
        End If

        Dim Frm As New Editor
        Frm.TFk_Customer.Text = TFk_Customer.Text
        Frm.TName.Text = TName.Text
        Frm.rtbMain.Text = sender.text
        Frm.rtbMain.Tag = sender.tag
        Frm.LblStatus.Text = "ویرایش"
        'Frm.Pb.Image = Pb.Image
        Frm.Show()
        Me.Close()



    End Sub

    Private Sub TXT1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT1.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If CbText.Items.Count = 0 Then
            MsgBox("اطلاعاتی برای نمایش موجود نیست")
            Exit Sub
        End If
        Dim Frm As New Editor
        Frm.TFk_Customer.Text = TFk_Customer.Text
        Frm.TName.Text = TName.Text

        Dim cmd As New OleDb.OleDbCommand("select * from tbltext where id = " + CbText.SelectedValue.ToString, AdoCon)
        Dim dr As Data.OleDb.OleDbDataReader
        dr = cmd.ExecuteReader

        dr.Read()
        Frm.rtbMain.Text = dr("textvisit").ToString
        Frm.rtbMain.Tag = CbText.SelectedValue.ToString
        Frm.LblStatus.Text = "ویرایش"
        'Frm.Pb.Image = Pb.Image
        Frm.Show()
        Me.Close()

    End Sub
End Class