Imports System
Imports System.Drawing
Imports System.Windows.Forms

Namespace SistemParkir

    ''' <summary>
    ''' Form Kalkulator Biaya Parkir.
    ''' Input   : jenis kendaraan, lama parkir (jam), status member
    ''' Proses  : hitung tarif berdasarkan aturan percabangan (progresif per jam + diskon member)
    ''' Output  : total biaya parkir
    ''' </summary>
    Public Class Form1
        Inherits Form

        Private lblJudul As Label
        Private lblKendaraan As Label
        Private cmbKendaraan As ComboBox
        Private lblLama As Label
        Private txtLamaParkir As TextBox
        Private chkMember As CheckBox
        Private btnHitung As Button
        Private lblHasil As Label
        Private lblKeterangan As Label

        Public Sub New()
            InitializeComponent()
        End Sub

        ''' <summary>
        ''' Membangun seluruh komponen antarmuka (UI) secara manual lewat kode,
        ''' setara dengan hasil drag-and-drop di Form Designer.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.Text = "Sistem Perhitungan Biaya Parkir"
            Me.Width = 440
            Me.Height = 360
            Me.StartPosition = FormStartPosition.CenterScreen
            Me.FormBorderStyle = FormBorderStyle.FixedSingle
            Me.MaximizeBox = False

            lblJudul = New Label() With {
                .Text = "Kalkulator Biaya Parkir",
                .Left = 20, .Top = 15, .Width = 350,
                .Font = New Font("Segoe UI", 13, FontStyle.Bold)
            }

            lblKendaraan = New Label() With {
                .Text = "Jenis Kendaraan:",
                .Left = 20, .Top = 65, .Width = 150
            }
            cmbKendaraan = New ComboBox() With {
                .Left = 190, .Top = 62, .Width = 180,
                .DropDownStyle = ComboBoxStyle.DropDownList
            }
            cmbKendaraan.Items.AddRange(New Object() {"Motor", "Mobil"})
            cmbKendaraan.SelectedIndex = 0

            lblLama = New Label() With {
                .Text = "Lama Parkir (jam):",
                .Left = 20, .Top = 105, .Width = 150
            }
            txtLamaParkir = New TextBox() With {
                .Left = 190, .Top = 102, .Width = 180
            }

            chkMember = New CheckBox() With {
                .Text = "Pelanggan Member (diskon 10%)",
                .Left = 190, .Top = 135, .Width = 220
            }

            btnHitung = New Button() With {
                .Text = "Hitung Biaya",
                .Left = 190, .Top = 175, .Width = 130, .Height = 32,
                .BackColor = Color.FromArgb(0, 120, 215),
                .ForeColor = Color.White,
                .FlatStyle = FlatStyle.Flat
            }
            AddHandler btnHitung.Click, AddressOf btnHitung_Click

            lblHasil = New Label() With {
                .Text = "Total Biaya: -",
                .Left = 20, .Top = 230, .Width = 380,
                .Font = New Font("Segoe UI", 12, FontStyle.Bold),
                .ForeColor = Color.DarkGreen
            }

            lblKeterangan = New Label() With {
                .Text = "",
                .Left = 20, .Top = 265, .Width = 380, .Height = 60,
                .ForeColor = Color.DimGray
            }

            Me.Controls.AddRange(New Control() {
                lblJudul, lblKendaraan, cmbKendaraan,
                lblLama, txtLamaParkir, chkMember,
                btnHitung, lblHasil, lblKeterangan
            })
        End Sub

        ''' <summary>
        ''' Menangani klik tombol Hitung: validasi input, lalu menjalankan
        ''' aturan percabangan (Select Case + If-Else) untuk menentukan tarif.
        ''' </summary>
        Private Sub btnHitung_Click(sender As Object, e As EventArgs)
            Dim jenis As String = cmbKendaraan.SelectedItem.ToString()
            Dim lama As Integer

            ' Validasi input
            If Not Integer.TryParse(txtLamaParkir.Text, lama) OrElse lama <= 0 Then
                MessageBox.Show("Masukkan lama parkir yang valid (angka bulat > 0).",
                                 "Input Tidak Valid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim tarifJamPertama As Integer
            Dim tarifJamBerikutnya As Integer
            Const batasJamPertama As Integer = 3

            ' Percabangan 1: tarif dasar berdasarkan jenis kendaraan
            Select Case jenis
                Case "Motor"
                    tarifJamPertama = 2000
                    tarifJamBerikutnya = 1000
                Case "Mobil"
                    tarifJamPertama = 5000
                    tarifJamBerikutnya = 3000
                Case Else
                    tarifJamPertama = 0
                    tarifJamBerikutnya = 0
            End Select

            Dim total As Double
            Dim keterangan As String = ""

            ' Percabangan 2: tarif progresif jika parkir lebih dari batas jam pertama
            If lama <= batasJamPertama Then
                total = lama * tarifJamPertama
                keterangan = $"Tarif normal: {lama} jam x Rp{tarifJamPertama:N0}"
            Else
                Dim sisaJam As Integer = lama - batasJamPertama
                total = (batasJamPertama * tarifJamPertama) + (sisaJam * tarifJamBerikutnya)
                keterangan = $"Tarif progresif: {batasJamPertama} jam pertama x Rp{tarifJamPertama:N0} + {sisaJam} jam berikutnya x Rp{tarifJamBerikutnya:N0}"
            End If

            ' Percabangan 3: diskon tambahan untuk member
            If chkMember.Checked Then
                total = total * 0.9
                keterangan &= ". Diskon member 10% diterapkan."
            End If

            lblHasil.Text = $"Total Biaya: Rp {total:N0}"
            lblKeterangan.Text = keterangan
        End Sub

    End Class

End Namespace
