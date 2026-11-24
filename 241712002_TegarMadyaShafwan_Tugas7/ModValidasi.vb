Option Strict On
Option Explicit On

Module ModValidasi


    Public Function KodeBukuValid(kode As String) As Boolean
        Dim k As String = kode.Trim().ToUpperInvariant()

        If k.Length <> 6 Then
            Return False
        End If

        If Not k.StartsWith("BK", StringComparison.Ordinal) Then
            Return False
        End If

        Return SemuaDigit(k.Substring(2))
    End Function

    Public Function SemuaDigit(teks As String) As Boolean
        If teks.Length = 0 Then
            Return False
        End If

        For Each c As Char In teks
            If c < "0"c OrElse c > "9"c Then
                Return False
            End If
        Next

        Return True
    End Function

End Module
