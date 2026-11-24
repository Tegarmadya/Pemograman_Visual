Option Strict On
Option Explicit On

Imports System.Data
Imports System.Windows.Forms
Imports System.Text

Public Class FrmInventaris

    Private ReadOnly tabelBuku As New DataTable("Buku")

    Private Sub FrmInventaris_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SiapkanTabel()
        bsBuku.DataSource = tabelBuku
        dgvBuku.DataSource = bsBuku
        AturKolom()
        cboFilterKategori.SelectedIndex = 0
        cboUrut.SelectedIndex = 0
        PerbaruiRingkasan()
    End Sub

    Private Sub SiapkanTabel()
        tabelBuku.Columns.Add("KodeBuku", GetType(String))
        tabelBuku.Columns.Add("Judul", GetType(String))
        tabelBuku.Columns.Add("Penulis", GetType(String))
        tabelBuku.Columns.Add("Kategori", GetType(String))
        tabelBuku.Columns.Add("Tahun", GetType(Integer))
        tabelBuku.Columns.Add("Stok", GetType(Integer))

        tabelBuku.Rows.Add("BK0001", "Laskar Pelangi", "Andrea Hirata", "Fiksi", 2005, 8)
        tabelBuku.Rows.Add("BK0002", "Bumi Manusia", "Pramoedya Ananta Toer", "Fiksi", 1980, 0)
        tabelBuku.Rows.Add("BK0003", "Filosofi Teras", "Henry Manampiring", "Nonfiksi", 2018, 5)
        tabelBuku.Rows.Add("BK0004", "Kamus Bahasa Indonesia", "Tim Bahasa", "Referensi", 2020, 3)
        tabelBuku.Rows.Add("BK0005", "Majalah Sains Nusantara", "Redaksi Sains", "Majalah", 2024, 0)
        tabelBuku.Rows.Add("BK0006", "Ma'rifat Cahaya", "Ahmad Fauzi", "Nonfiksi", 2019, 4)
        tabelBuku.Rows.Add("BK0007", "Negeri 5 Menara", "Ahmad Fuadi", "Fiksi", 2009, 6)
        tabelBuku.Rows.Add("BK0008", "Atlas Indonesia", "Tim Kartografi", "Referensi", 2022, 2)
        tabelBuku.Rows.Add("BK0009", "Majalah Taman Kita", "Redaksi Taman", "Majalah", 2023, 7)
        tabelBuku.Rows.Add("BK0010", "Sejarah Nusantara", "Dewi Lestari Putri", "Nonfiksi", 2021, 0)
    End Sub

    Private Sub AturKolom()
        dgvBuku.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvBuku.Columns("KodeBuku").HeaderText = "Kode Buku"
        dgvBuku.Columns("Judul").FillWeight = 200
        dgvBuku.Columns("Penulis").FillWeight = 130
        dgvBuku.Columns("Tahun").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvBuku.Columns("Stok").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub

    Private Function ValidasiInput() As Boolean
        errBuku.Clear()
        Dim valid As Boolean = True

        Dim kode As String = txtKodeBuku.Text.Trim().ToUpperInvariant()
        If Not KodeBukuValid(kode) Then
            errBuku.SetError(txtKodeBuku, "Kode buku harus BK diikuti 4 digit, contoh BK0012.")
            valid = False
        ElseIf KodeSudahAda(kode) Then
            errBuku.SetError(txtKodeBuku, "Kode buku sudah ada.")
            valid = False
        End If

        If txtJudul.Text.Trim() = "" Then
            errBuku.SetError(txtJudul, "Judul wajib diisi.")
            valid = False
        End If

        If txtPenulis.Text.Trim() = "" Then
            errBuku.SetError(txtPenulis, "Penulis wajib diisi.")
            valid = False
        End If

        If cboKategori.SelectedIndex = -1 Then
            errBuku.SetError(cboKategori, "Kategori wajib dipilih.")
            valid = False
        End If

        Dim tahun As Integer
        If Not Integer.TryParse(txtTahun.Text.Trim(), tahun) OrElse tahun < 1900 OrElse tahun > Date.Today.Year Then
            errBuku.SetError(txtTahun, "Tahun harus bilangan bulat 1900 sampai " & Date.Today.Year & ".")
            valid = False
        End If

        Dim stok As Integer
        If Not Integer.TryParse(txtStok.Text.Trim(), stok) OrElse stok < 0 Then
            errBuku.SetError(txtStok, "Stok harus bilangan bulat 0 atau lebih.")
            valid = False
        End If

        Return valid
    End Function

    Private Function KodeSudahAda(kode As String) As Boolean
        For Each baris As DataRow In tabelBuku.Rows
            If baris("KodeBuku").ToString() = kode Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If Not ValidasiInput() Then
            Return
        End If

        Dim tahun As Integer
        Dim stok As Integer
        If Not Integer.TryParse(txtTahun.Text.Trim(), tahun) OrElse Not Integer.TryParse(txtStok.Text.Trim(), stok) Then
            Return
        End If

        tabelBuku.Rows.Add(txtKodeBuku.Text.Trim().ToUpperInvariant(),
                           txtJudul.Text.Trim(),
                           txtPenulis.Text.Trim(),
                           cboKategori.Text,
                           tahun,
                           stok)

        BersihkanForm()
        PerbaruiRingkasan()
    End Sub

    Private Sub BersihkanForm()
        errBuku.Clear()
        txtKodeBuku.Clear()
        txtJudul.Clear()
        txtPenulis.Clear()
        cboKategori.SelectedIndex = -1
        txtTahun.Clear()
        txtStok.Clear()
        txtKodeBuku.Focus()
    End Sub

    Private Sub btnBersihkan_Click(sender As Object, e As EventArgs) Handles btnBersihkan.Click
        BersihkanForm()
    End Sub

    Private Function AmankanFilter(teks As String) As String
        Dim hasil As New StringBuilder()
        For Each c As Char In teks
            Select Case c
                Case "'"c
                    hasil.Append("''")
                Case "["c, "]"c, "%"c, "*"c
                    hasil.Append("[").Append(c).Append("]")
                Case Else
                    hasil.Append(c)
            End Select
        Next
        Return hasil.ToString()
    End Function

    Private Function SusunFilter() As String
        Dim filter As String = ""

        Dim kata As String = txtCari.Text.Trim()
        If kata <> "" Then
            Dim aman As String = AmankanFilter(kata)
            filter = "(Judul LIKE '%" & aman & "%' OR Penulis LIKE '%" & aman & "%')"
        End If

        If cboFilterKategori.SelectedIndex > 0 Then
            If filter <> "" Then
                filter &= " AND "
            End If
            filter &= "Kategori = '" & cboFilterKategori.Text.Replace("'", "''") & "'"
        End If

        If chkStokHabis.Checked Then
            If filter <> "" Then
                filter &= " AND "
            End If
            filter &= "Stok = 0"
        End If

        Return filter
    End Function

    Private Sub FilterBerubah(sender As Object, e As EventArgs) Handles txtCari.TextChanged, cboFilterKategori.SelectedIndexChanged, chkStokHabis.CheckedChanged
        bsBuku.Filter = SusunFilter()
        PerbaruiRingkasan()
    End Sub

    Private Sub cboUrut_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboUrut.SelectedIndexChanged
        Select Case cboUrut.Text
            Case "Judul A-Z"
                bsBuku.Sort = "Judul ASC"
            Case "Tahun terbaru"
                bsBuku.Sort = "Tahun DESC"
            Case "Stok terbanyak"
                bsBuku.Sort = "Stok DESC"
            Case Else
                bsBuku.Sort = ""
        End Select
    End Sub

    Private Sub PerbaruiRingkasan()
        Dim totalStok As Integer = 0
        For Each baris As DataGridViewRow In dgvBuku.Rows
            totalStok += CInt(baris.Cells("Stok").Value)
        Next

        lblJumlah.Text = "Menampilkan " & dgvBuku.Rows.Count & " dari " & tabelBuku.Rows.Count & " buku"
        lblTotalStok.Text = "Total stok yang tampil: " & totalStok
    End Sub

End Class
