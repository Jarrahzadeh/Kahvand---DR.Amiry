

Imports System.Text
Imports System.Security.Cryptography
Public Class Encryptor
    Dim i As Integer

    Private RJ As Rijndael = Rijndael.Create
    Private MD As New MD5CryptoServiceProvider

    Public Shared Function md5Create(ByVal input As String) As String
        Dim md5 As MD5 = New MD5CryptoServiceProvider()
        Dim buf As Byte() = ASCIIEncoding.[Default].GetBytes(input)
        Dim sb As New StringBuilder()
        buf = md5.ComputeHash(buf)
        For i As Integer = 0 To buf.Length - 1

            sb.Append(buf(i).ToString("X2"))
        Next

        Return sb.ToString()
    End Function

    Private Function Md5Hash(ByVal Value As String) As Byte()
        Return MD.ComputeHash(ASCIIEncoding.ASCII.GetBytes(Value))
    End Function
    Public Function EncryptText(ByVal TextToEncrypt As String, ByVal Key As String) As String
        RJ.Key = Md5Hash(Key)
        RJ.Mode = CipherMode.ECB
        'RJ.FeedbackSize = 10
        Dim ToEncrypt As Byte() = Encoding.ASCII.GetBytes(TextToEncrypt)
        Return Convert.ToBase64String(RJ.CreateEncryptor().TransformFinalBlock(ToEncrypt, 0, ToEncrypt.Length))
    End Function
    Public Function DecryptText(ByVal EncryptedText As String, ByVal Key As String) As String
        Try
            RJ.Key = Md5Hash(Key)
            RJ.Mode = CipherMode.ECB
            Dim ToDecrypt As Byte() = Convert.FromBase64String(EncryptedText)
            Return ASCIIEncoding.ASCII.GetString(RJ.CreateDecryptor().TransformFinalBlock(ToDecrypt, 0, ToDecrypt.Length))
        Catch ex As Exception
            MessageBox.Show("Invalid Key", "Decryption Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return Nothing
        End Try
    End Function




    Public Function GetReg(ByVal serial As String) As String
        'Dim x As New Encryptor
        Dim St As String
        Dim St2 As String = ""

        St = EncryptText(serial, "6300") 'Encrypt(Convert.ToByte("030222121222"), TxtSerial.Text)
        For i = 1 To St.Length
            St2 += Str(Asc(Mid(St, i, 1)))
        Next
        St2 = St2.Replace(" ", "")

        St = ""
        For i = 1 To St2.Length Step 3
            St += Mid(St2, i, 1)
        Next

        St = Mid(St, 1, 24)

        Return St

    End Function



    Function HDDID() As String
        Dim physicalMedia As New Management.ManagementClass("Win32_PhysicalMedia")
        For Each physicalMedium As Management.ManagementObject In physicalMedia.GetInstances()
            Dim St As String = CStr(physicalMedium("SerialNumber"))

            Dim StTemp As String = ""
            Dim StTemp2 As String = ""
            For i As Integer = 1 To St.Length
                If IsNumeric(Mid(St, i, 1)) = False Then
                    StTemp += i.ToString
                Else
                    StTemp += Mid(St, i, 1)
                End If
            Next


            For i = 1 To StTemp.Length Step 2
                StTemp2 += Mid(StTemp, i, 1)
            Next


            Return StTemp2
            'Exit For
        Next physicalMedium
        Return 0

    End Function


    Public Function CpuId() As String
        Dim computer As String = "."
        Dim wmi As Object = GetObject("winmgmts:" & _
            "{impersonationLevel=impersonate}!\\" & _
            computer & "\root\cimv2")
        Dim processors As Object = wmi.ExecQuery("Select * from " & _
            "Win32_Processor")

        Dim cpu_ids As String = ""
        For Each cpu As Object In processors
            cpu_ids = cpu_ids & ", " & cpu.ProcessorId
        Next cpu
        If cpu_ids.Length > 0 Then cpu_ids = _
            cpu_ids.Substring(2)

        Return cpu_ids
    End Function
    Public Function SerialNumberSystem() As String
        ' Get the Windows Management Instrumentation object.
        Dim wmi As Object = GetObject("WinMgmts:")

        ' Get the "base boards" (mother boards).
        Dim serial_numbers As String = ""
        Dim mother_boards As Object = _
            wmi.InstancesOf("Win32_BaseBoard")
        For Each board As Object In mother_boards
            serial_numbers &= ", " & board.SerialNumber
        Next board
        If serial_numbers.Length > 0 Then serial_numbers = _
            serial_numbers.Substring(2)

        Return serial_numbers
    End Function


End Class

