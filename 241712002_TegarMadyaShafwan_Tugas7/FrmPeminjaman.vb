Option Strict On
Option Explicit On

Imports System.Globalization
Imports System.IO
Imports System.Text


Public Class FrmPeminjaman

    Private Const PesanKode As String = "Kode buku harus BK diikuti 4 digit, contoh BK0012."

    Private ReadOnly daftarKode As New List(Of String)

    Private Sub FrmPeminjaman_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilkanStatus()
    End Sub

    Private Sub TampilkanStatus()
        lblStatus.Text = "Jumlah peminjaman: " & daftarKode.Count
    End Sub

    Private Function ValidasiInput() As Boolean
        errPinjam.Clear()
        Dim valid As Boolean = True

        Dim kode As String = txtKodeBuku.Text.Trim().ToUpperInvariant()
        If Not KodeBukuValid(kode) Then
            errPinjam.SetError(txtKodeBuku, PesanKode)
            valid = False
        ElseIf daftarKode.Contains(kode) Then
            errPinjam.SetError(txtKodeBuku, "Buku ini sedang dipinjam.")
            valid = False
        End If

        If txtJudul.Text.Trim() = "" Then
            errPinjam.SetError(txtJudul, "Judul buku wajib diisi.")
            valid = False
        End If

        If cboKategori.SelectedIndex = -1 Then
            errPinjam.SetError(cboKategori, "Kategori wajib dipilih.")
            valid = False
        End If

        If txtNamaPeminjam.Text.Trim().Length < 3 Then
            errPinjam.SetError(txtNamaPeminjam, "Nama peminjam minimal 3 karakter.")
            valid = False
        End If

        Dim lama As Integer
        If Not Integer.TryParse(txtLamaPinjam.Text.Trim(), lama) OrElse lama < 1 OrElse lama > 14 Then
            errPinjam.SetError(txtLamaPinjam, "Lama pinjam harus bilangan bulat 1 sampai 14.")
            valid = False
        End If

        Return valid
    End Function

    Private Sub btnPinjam_Click(sender As Object, e As EventArgs) Handles btnPinjam.Click
        If Not ValidasiInput() Then
            lblStatus.Text = "Periksa isian yang bertanda merah."
            Return
        End If

        Dim kode As String = txtKodeBuku.Text.Trim().ToUpperInvariant()
        Dim judul As String = txtJudul.Text.Trim()
        Dim kategori As String = cboKategori.Text
        Dim nama As String = txtNamaPeminjam.Text.Trim()

        Dim lama As Integer
        If Not Integer.TryParse(txtLamaPinjam.Text.Trim(), lama) Then
            Return
        End If

        Dim tanggalKembali As String = Date.Today.AddDays(lama).ToString("dd/MM/yyyy", CultureInfo.InvariantCulture)

        lstPeminjaman.Items.Add(kode & " | " & judul & " | " & kategori & " | " & nama &
                                " | " & lama & " hari | kembali " & tanggalKembali)
        daftarKode.Add(kode)

        BersihkanForm()
        TampilkanStatus()
    End Sub

    Private Sub BersihkanForm()
        errPinjam.Clear()
        txtKodeBuku.Clear()
        txtJudul.Clear()
        cboKategori.SelectedIndex = -1
        txtNamaPeminjam.Clear()
        txtLamaPinjam.Clear()
        txtKodeBuku.Focus()
    End Sub

    Private Sub btnBersihkan_Click(sender As Object, e As EventArgs) Handles btnBersihkan.Click
        BersihkanForm()
        TampilkanStatus()
    End Sub

    Private Sub txtKodeBuku_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtKodeBuku.Validating
        Dim kode As String = txtKodeBuku.Text.Trim().ToUpperInvariant()

        If kode = "" Then
            errPinjam.SetError(txtKodeBuku, "")
        ElseIf Not KodeBukuValid(kode) Then
            errPinjam.SetError(txtKodeBuku, PesanKode)
        ElseIf daftarKode.Contains(kode) Then
            errPinjam.SetError(txtKodeBuku, "Buku ini sedang dipinjam.")
        Else
            errPinjam.SetError(txtKodeBuku, "")
        End If
    End Sub

    Private Sub btnEkspor_Click(sender As Object, e As EventArgs) Handles btnEkspor.Click
        If lstPeminjaman.Items.Count = 0 Then
            MessageBox.Show("Belum ada data peminjaman yang bisa diekspor.",
                            "Ekspor CSV", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim lokasiFile As String = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "peminjaman.csv")

        Dim penulis As StreamWriter = Nothing
        Try
            penulis = New StreamWriter(lokasiFile, False, New UTF8Encoding(True))
            penulis.WriteLine("Kode;Judul;Kategori;Peminjam;Lama (hari);Tanggal Kembali")

            For Each item As Object In lstPeminjaman.Items
                penulis.WriteLine(UbahKeBarisCsv(item.ToString()))
            Next

            MessageBox.Show("Data berhasil diekspor ke:" & vbCrLf & lokasiFile,
                            "Ekspor CSV", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As IOException
            MessageBox.Show("Gagal menulis peminjaman.csv. File kemungkinan sedang dibuka di program lain (misalnya Excel)." &
                            vbCrLf & "Tutup file tersebut, lalu klik Ekspor CSV lagi.",
                            "Ekspor Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Catch ex As UnauthorizedAccessException
            MessageBox.Show("Program tidak punya izin menulis ke folder Documents." &
                            vbCrLf & "Pastikan file peminjaman.csv tidak read-only, atau jalankan program dengan akun yang punya izin.",
                            "Ekspor Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Finally
            If penulis IsNot Nothing Then
                penulis.Close()
            End If
        End Try
    End Sub

    Private Function UbahKeBarisCsv(baris As String) As String
        Dim bagian() As String = baris.Split(New String() {" | "}, StringSplitOptions.None)

        If bagian.Length <> 6 Then
            Return KutipCsv(baris)
        End If

        bagian(4) = bagian(4).Replace(" hari", "")
        bagian(5) = bagian(5).Replace("kembali ", "")

        For i As Integer = 0 To bagian.Length - 1
            bagian(i) = KutipCsv(bagian(i))
        Next

        Return String.Join(";", bagian)
    End Function

    Private Function KutipCsv(teks As String) As String
        Dim q As String = ControlChars.Quote
        If teks.Contains(";") OrElse teks.Contains(q) Then
            Return q & teks.Replace(q, q & q) & q
        End If
        Return teks
    End Function

End Class
