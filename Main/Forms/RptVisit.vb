Imports Janus.Windows.GridEX

Public Class RptVisit

    Private Sub RptVisit_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnClose.Click
        Close()
    End Sub

    Private Sub BtnView_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnView.Click

        Dim St As String = " where 1=1 "
        If ChDate.Checked Then
            St += " and V.DateVisit >= '" + txtDateFrom.Text + "' and V.DateVisit <= '" + txtDateTo.Text + "' "
        End If
        Dim DtDg As New DataTable

        If RbVisit.Checked Then
            Dim AdoDaDg As New OleDb.OleDbDataAdapter("select C.id as کد ,C.Name as نام , C.Family as فامیلی, Tel as تلفن, NameFather as [نام پدر] , C.DateSave as تاریخ ,TimeVisit as زمان,V.Status as وضعیت , v.price as مبلغ From CustomerForm C inner join VisitList V on (C.id=V.Code_Customer)   " + St + " and C.DrId = " + DrId.ToString() + " order by C.id desc", AdoCon)
            AdoDaDg.Fill(DtDg)
            Dim CmdSum As New OleDb.OleDbCommand("select Sum(v.price) From CustomerForm C inner join VisitList V on (C.id=V.Code_Customer) " + St, AdoCon)
            Dim StSum = CmdSum.ExecuteScalar().ToString()
            TSSLTitel.Text = StSum
            TSSLSummery.Text = Adad(Val(StSum))

        ElseIf RBAmar.Checked Then
            Dim AdoDaDg As New OleDb.OleDbDataAdapter("SELECT (select Count(CAT) From Amar where Cat = True) AS CAT, (select Count(Strabism) From Amar where Strabism = True) as Strabism, (select Count(NLD) From Amar where NLD = True) as NLD, (select Count(LID) From Amar where LID = True) as LID FROM Amar as v " + St, AdoCon)
            AdoDaDg.Fill(DtDg)
            Dim Cat As Int64 = 0
            Dim Strabism As Int64 = 0
            Dim NLD As Int64 = 0
            Dim LID As Int64 = 0
            For i As Int64 = 0 To DtDg.Rows.Count - 1
                Cat += Val(DtDg.Rows(i)("CAT").ToString())
                Strabism += Val(DtDg.Rows(i)("Strabism").ToString())
                NLD += Val(DtDg.Rows(i)("NLD").ToString())
                LID += Val(DtDg.Rows(i)("LID").ToString())
            Next
            Dim dr As DataRow
            dr = DtDg.NewRow()
            dr("CAT") = Cat
            dr("Strabism") = Strabism
            dr("NLD") = NLD
            dr("LID") = LID
            DtDg.Rows.Add(dr)
        ElseIf RbAllVisit.Checked Then
            Dim AdoDaDg As New OleDb.OleDbDataAdapter("select C.id as کد ,C.Name as نام , C.Family as فامیلی, Tel as تلفن, NameFather as [نام پدر] , C.DateSave as تاریخ  , D.Name as Dr From CustomerForm C inner join Dr D on (C.DRid=D.ID)   " + St + " order by C.Drid desc", AdoCon)
            AdoDaDg.Fill(DtDg)
        End If

        Dg.DataSource = DtDg
        Dg.RetrieveStructure()
        Dim x As Janus.Windows.GridEX.GridEXRow = Dg.GetRow(Dg.RowCount - 1)
        'x.RowStyle.BackColor = Color.Bisque

        If RBAmar.Checked Then
            Dim style As New GridEXFormatStyle
            style.BackColor = Color.Coral
            Dg.GetRow(Dg.RowCount - 1).RowStyle = style
        End If

    End Sub

    Private Sub ChDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChDate.CheckedChanged
        txtDateFrom.Enabled = ChDate.Checked
        txtDateTo.Enabled = ChDate.Checked
    End Sub

    Private Sub BtnDetial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDetial.Click
        If RbAllVisit.Checked Or RbVisit.Checked Then
            Dim Frm As New OldVisit
            Frm.TFk_Customer.Text = Dg.CurrentRow.Cells(0).Value.ToString()
            Frm.TName.Text = Dg.CurrentRow.Cells(2).Value.ToString() + " " + Dg.CurrentRow.Cells(1).Value.ToString()
            Frm.ShowDialog()

        End If
    End Sub
End Class