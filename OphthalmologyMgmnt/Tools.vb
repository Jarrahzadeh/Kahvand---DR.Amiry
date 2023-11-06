Imports Microsoft.VisualBasic

Module Tools

    Private Const hezar = " هزار"
    Private Const melun = " ميليون "
    Private Const melyard = " ميليارد "
    Private Const va = " و "
    Public Function Adad(ByVal Adad_En As Double) As String
        Dim hooroof As String
        Dim SS As Integer  'sadgan
        Dim hh As Integer   'hezargan
        Dim mm As Integer  'melungan
        Dim yy As Integer   'melyardgan
        Dim STRAdad_En As String
        Dim LENAdad_En As Integer
        hooroof = ""
        STRAdad_En = Str(Val(Str(Adad_En)))
        LENAdad_En = Len(STRAdad_En)

        Select Case Adad_En
            Case Is = 0
                hooroof = "صفر"
            Case 1 To 999
                hooroof = Adad_En_Heji(Adad_En)

            Case 1000 To 999999

                If (Adad_En Mod 1000 = 0) Then hooroof = Adad_En_Heji(Int(Adad_En / 1000)) + hezar
                If (Adad_En Mod 1000 <> 0) Then hooroof = Adad_En_Heji(Int(Adad_En / 1000)) + hezar + va + (Adad_En_Heji(Adad_En Mod 1000))

            Case 1000000 To 999999999

                SS = Val(Right$(STRAdad_En, 3))
                hh = Val(Mid$(STRAdad_En, LENAdad_En - 5, 3))
                mm = Val(Left$(STRAdad_En, LENAdad_En - 6))

                If (SS = 0 And hh = 0) Then hooroof = Adad_En_Heji(mm) + melun
                If (SS = 0 And hh <> 0) Then hooroof = Adad_En_Heji(mm) + melun + va + Adad_En_Heji(hh) + hezar
                If (SS <> 0 And hh = 0) Then hooroof = Adad_En_Heji(mm) + melun + va + Adad_En_Heji(SS)
                If (SS <> 0 And hh <> 0) Then hooroof = Adad_En_Heji(mm) + melun + va + Adad_En_Heji(hh) + hezar + va + Adad_En_Heji(SS)

            Case 1000000000 To 999999999999.0#

                SS = Val(Right$(STRAdad_En, 3))
                hh = Val(Mid$(STRAdad_En, LENAdad_En - 5, 3))
                mm = Val(Mid$(STRAdad_En, LENAdad_En - 8, 3))
                yy = Val(Left$(STRAdad_En, LENAdad_En - 9))

                If (SS = 0 And hh = 0 And mm = 0) Then hooroof = Adad_En_Heji(yy) + melyard
                If (SS = 0 And hh = 0 And mm <> 0) Then hooroof = Adad_En_Heji(yy) + melyard + va + Adad_En_Heji(mm) + melun
                If (SS = 0 And hh <> 0 And mm <> 0) Then hooroof = Adad_En_Heji(yy) + melyard + va + Adad_En_Heji(mm) + melun + va + Adad_En_Heji(hh) + hezar
                If (SS <> 0 And hh <> 0 And mm <> 0) Then hooroof = Adad_En_Heji(yy) + melyard + va + Adad_En_Heji(mm) + melun + va + Adad_En_Heji(hh) + hezar + va + Adad_En_Heji(SS)

            Case Is > 999999999999.0#
                hooroof = "عدد وارد شده خارج از محدوده مي باشد "

        End Select

        Adad = hooroof
    End Function

    Private Function Adad_En_Heji(ByVal Adad_En As Integer) As String
        Dim yekan As Byte
        Dim dahgan As Byte
        Dim sadgan As Byte
        Dim behooroof As String = ""

        Dim heji(19) As String
        Dim heji_dahgan(9) As String
        Dim heji_sadgan(9) As String
        '-------------------------------
        heji(1) = "يك" : heji(2) = "دو" : heji(3) = "سه" : heji(4) = "چهار" : heji(5) = "پنج"
        heji(6) = "شش" : heji(7) = "هفت" : heji(8) = "هشت" : heji(9) = "نه" : heji(10) = "ده"
        heji(11) = "يازده" : heji(12) = "دوازده" : heji(13) = "سيزده" : heji(14) = "چهارده" : heji(15) = "پانزده"
        heji(16) = "شانزده" : heji(17) = "هفده" : heji(18) = "هيجده" : heji(19) = "نوزده"
        '-------------------------------
        heji_dahgan(1) = "ده"
        heji_dahgan(2) = "بيست"
        heji_dahgan(3) = "سي" : heji_dahgan(4) = "چهل" : heji_dahgan(5) = "پنجاه"
        heji_dahgan(6) = "شصت" : heji_dahgan(7) = "هفتاد" : heji_dahgan(8) = "هشتاد"
        heji_dahgan(9) = "نود"
        '------------------------
        heji_sadgan(1) = "يكصد" : heji_sadgan(2) = "دويست" : heji_sadgan(3) = "سيصد"
        heji_sadgan(4) = "چهارصد" : heji_sadgan(5) = "پانصد" : heji_sadgan(6) = "ششصد"
        heji_sadgan(7) = "هفتصد" : heji_sadgan(8) = "هشتصد" : heji_sadgan(9) = "نهصد"
        '------------------------------------------------------------------------------------------------------------
        yekan = Adad_En Mod 10
        dahgan = Adad_En Mod 100
        sadgan = Int(Adad_En / 100)
        '------------------------------------------------------------------------------------------------------------
        If dahgan < 20 Then

            If (sadgan = 0) Then behooroof = heji(dahgan)
            If (sadgan <> 0) Then behooroof = heji_sadgan(sadgan) + va + heji(dahgan)
            If (yekan = 0 And dahgan = 0) Then behooroof = heji_sadgan(sadgan)

        Else
            dahgan = (Adad_En Mod 100) - yekan

            If (sadgan = 0 And yekan = 0) Then behooroof = heji_dahgan(dahgan / 10)
            If (sadgan = 0 And yekan <> 0) Then behooroof = heji_dahgan(dahgan / 10) + va + heji(yekan)
            If (sadgan <> 0 And yekan = 0) Then behooroof = heji_sadgan(sadgan) + va + heji_dahgan(dahgan / 10)
            If (sadgan <> 0 And yekan <> 0) Then behooroof = heji_sadgan(sadgan) + va + heji_dahgan(dahgan / 10) + va + heji(yekan)

        End If

        Adad_En_Heji = behooroof
    End Function



    Function TarikhShamsi(Optional ByRef date1 As String = "", Optional ByRef SmallDate1 As Boolean = False) As String

        '====================================================
        Dim Ds, P1, Ms, i, rp, u, Mm, w, d, p, mon, Ym, v, x, Ys, Dm, D1, DateShamsi As Object
        d = New Object() {20, 19, 20, 20, 21, 21, 22, 22, 22, 22, 21, 21}
        p = New Object() {11, 12, 10, 12, 11, 11, 10, 10, 10, 9, 10, 10}
        w = New Object() {"يكشنبه", "دوشنبه", "سه شنبه", "چهارشنبه", "پنجشنبه", "جمعه", "شنبه"}

        If SmallDate1 = True Then
            mon = New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"}
        Else
            mon = New Object() {"فروردين", "ارديبهشت", "خرداد", "تير", "مرداد", "شهريور", "مهر", "آبان", "آذر", "دي", "بهمن", "اسفند"}
        End If

        If date1 = "" Then date1 = CStr(Today)

        Dm = Day(CDate(date1))

        Mm = Month(CDate(date1))
        Ym = Year(CDate(date1))
        u = 0
        rp = 0
        If (Ym Mod 4) = 0 Then u = 1
        If ((Ym Mod 100) = 0 And (Ym Mod 400) <> 0) Then u = 0
        Ys = Ym - 622
        x = Ys - 22
        x = x Mod 33
        If ((x Mod 4) = 0 And x <> 32) Then rp = 1
        i = Not (rp - 2) + Not (u - 2) * 2
        x = 0
        If (i = 0 And Mm = 3) Then x = 1
        If i = 0 Then i = 3
        Ms = (9 + Mm) Mod 13
        If Ms < 10 Then Ms = Ms + 1
        D1 = d(Mm - 1)
        If (i = 1 And Mm > 2) Then D1 = D1 - 1
        If (i = 2 And Mm < 3) Then D1 = D1 - 1
        P1 = p(Mm - 1)
        If (i = 1 And Mm > 2) Then P1 = P1 + 1
        If (i = 2 And Mm < 4) Then P1 = P1 + 1
        If (Dm > 0 And Dm <= D1) Then
            Ds = P1 + Dm + x - 1
            x = 1
        Else
            Ds = Dm - D1
            Ms = Ms + 1
            If Ms = 13 Then Ms = 1
            x = 2
        End If
        If ((Mm = 3 And x = 2) Or Mm > 3) Then Ys = Ys + 1
        If SmallDate1 = True Then
            TarikhShamsi = Trim(Str(Ys)) & "/" & Trim(mon(Ms - 1)) & "/" & Trim(Str(Ds))
        Else
            TarikhShamsi = w(Weekday(Today) - 1) + " " + Str(Ds) + " " + mon(Ms - 1) + " " + Str(Ys)
        End If

    End Function


End Module
