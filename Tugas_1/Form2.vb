Public Class PenghasilanForm

    Public Sub New(nama As String, nim As String)
        InitializeComponent()
        lblNamaValue.Text = nama
        lblNimValue.Text = nim
    End Sub

    Private Sub txtGaji_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGaji.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse e.KeyChar = ControlChars.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim gaji As Double

        If Not Double.TryParse(txtGaji.Text, gaji) OrElse gaji <= 0 Then
            MessageBox.Show("Masukkan jumlah gaji yang valid!")
            Exit Sub
        End If

        Dim persenPotongan As Double

        If gaji < 5000000 Then
            persenPotongan = 0
        ElseIf gaji <= 10000000 Then
            persenPotongan = 0.1
        Else
            persenPotongan = 0.15
        End If

        Dim nominalPotongan As Double = gaji * persenPotongan
        Dim gajiBersih As Double = gaji - nominalPotongan

        lblPotonganValue.Text = (persenPotongan * 100).ToString("0") & "%  (Rp " & nominalPotongan.ToString("N0") & ")"
        lblBersihValue.Text = "Rp " & gajiBersih.ToString("N0")
    End Sub

    Private Sub PenghasilanForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub

End Class