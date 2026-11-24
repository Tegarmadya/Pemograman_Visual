Option Strict On
Option Explicit On

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmInventaris
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New System.ComponentModel.Container()
        lblJudulForm = New System.Windows.Forms.Label()
        lblKodeBuku = New System.Windows.Forms.Label()
        txtKodeBuku = New System.Windows.Forms.TextBox()
        lblJudul = New System.Windows.Forms.Label()
        txtJudul = New System.Windows.Forms.TextBox()
        lblPenulis = New System.Windows.Forms.Label()
        txtPenulis = New System.Windows.Forms.TextBox()
        lblKategori = New System.Windows.Forms.Label()
        cboKategori = New System.Windows.Forms.ComboBox()
        lblTahun = New System.Windows.Forms.Label()
        txtTahun = New System.Windows.Forms.TextBox()
        lblStok = New System.Windows.Forms.Label()
        txtStok = New System.Windows.Forms.TextBox()
        btnTambah = New System.Windows.Forms.Button()
        btnBersihkan = New System.Windows.Forms.Button()
        lblCari = New System.Windows.Forms.Label()
        txtCari = New System.Windows.Forms.TextBox()
        lblFilterKategori = New System.Windows.Forms.Label()
        cboFilterKategori = New System.Windows.Forms.ComboBox()
        chkStokHabis = New System.Windows.Forms.CheckBox()
        lblUrut = New System.Windows.Forms.Label()
        cboUrut = New System.Windows.Forms.ComboBox()
        dgvBuku = New System.Windows.Forms.DataGridView()
        bsBuku = New System.Windows.Forms.BindingSource(components)
        lblJumlah = New System.Windows.Forms.Label()
        lblTotalStok = New System.Windows.Forms.Label()
        errBuku = New System.Windows.Forms.ErrorProvider(components)
        CType(dgvBuku, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(bsBuku, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(errBuku, System.ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        '
        'lblJudulForm
        '
        lblJudulForm.AutoSize = True
        lblJudulForm.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        lblJudulForm.Location = New System.Drawing.Point(26, 18)
        lblJudulForm.Name = "lblJudulForm"
        lblJudulForm.Size = New System.Drawing.Size(267, 25)
        lblJudulForm.TabIndex = 0
        lblJudulForm.Text = "Inventaris Buku Perpustakaan"
        '
        'lblKodeBuku
        '
        lblKodeBuku.AutoSize = True
        lblKodeBuku.Location = New System.Drawing.Point(26, 79)
        lblKodeBuku.Name = "lblKodeBuku"
        lblKodeBuku.Size = New System.Drawing.Size(61, 15)
        lblKodeBuku.TabIndex = 1
        lblKodeBuku.Text = "Kode buku"
        '
        'txtKodeBuku
        '
        txtKodeBuku.Location = New System.Drawing.Point(26, 102)
        txtKodeBuku.Name = "txtKodeBuku"
        txtKodeBuku.Size = New System.Drawing.Size(260, 23)
        txtKodeBuku.TabIndex = 0
        '
        'lblJudul
        '
        lblJudul.AutoSize = True
        lblJudul.Location = New System.Drawing.Point(26, 141)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New System.Drawing.Size(62, 15)
        lblJudul.TabIndex = 3
        lblJudul.Text = "Judul buku"
        '
        'txtJudul
        '
        txtJudul.Location = New System.Drawing.Point(26, 164)
        txtJudul.Name = "txtJudul"
        txtJudul.Size = New System.Drawing.Size(260, 23)
        txtJudul.TabIndex = 1
        '
        'lblPenulis
        '
        lblPenulis.AutoSize = True
        lblPenulis.Location = New System.Drawing.Point(26, 203)
        lblPenulis.Name = "lblPenulis"
        lblPenulis.Size = New System.Drawing.Size(47, 15)
        lblPenulis.TabIndex = 5
        lblPenulis.Text = "Penulis"
        '
        'txtPenulis
        '
        txtPenulis.Location = New System.Drawing.Point(26, 226)
        txtPenulis.Name = "txtPenulis"
        txtPenulis.Size = New System.Drawing.Size(260, 23)
        txtPenulis.TabIndex = 2
        '
        'lblKategori
        '
        lblKategori.AutoSize = True
        lblKategori.Location = New System.Drawing.Point(26, 265)
        lblKategori.Name = "lblKategori"
        lblKategori.Size = New System.Drawing.Size(52, 15)
        lblKategori.TabIndex = 7
        lblKategori.Text = "Kategori"
        '
        'cboKategori
        '
        cboKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        cboKategori.FormattingEnabled = True
        cboKategori.Items.AddRange(New Object() {"Fiksi", "Nonfiksi", "Referensi", "Majalah"})
        cboKategori.Location = New System.Drawing.Point(26, 288)
        cboKategori.Name = "cboKategori"
        cboKategori.Size = New System.Drawing.Size(260, 23)
        cboKategori.TabIndex = 3
        '
        'lblTahun
        '
        lblTahun.AutoSize = True
        lblTahun.Location = New System.Drawing.Point(26, 327)
        lblTahun.Name = "lblTahun"
        lblTahun.Size = New System.Drawing.Size(66, 15)
        lblTahun.TabIndex = 9
        lblTahun.Text = "Tahun terbit"
        '
        'txtTahun
        '
        txtTahun.Location = New System.Drawing.Point(26, 350)
        txtTahun.Name = "txtTahun"
        txtTahun.Size = New System.Drawing.Size(260, 23)
        txtTahun.TabIndex = 4
        '
        'lblStok
        '
        lblStok.AutoSize = True
        lblStok.Location = New System.Drawing.Point(26, 389)
        lblStok.Name = "lblStok"
        lblStok.Size = New System.Drawing.Size(30, 15)
        lblStok.TabIndex = 11
        lblStok.Text = "Stok"
        '
        'txtStok
        '
        txtStok.Location = New System.Drawing.Point(26, 412)
        txtStok.Name = "txtStok"
        txtStok.Size = New System.Drawing.Size(260, 23)
        txtStok.TabIndex = 5
        '
        'btnTambah
        '
        btnTambah.Location = New System.Drawing.Point(26, 459)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New System.Drawing.Size(124, 34)
        btnTambah.TabIndex = 6
        btnTambah.Text = "Tambah Buku"
        btnTambah.UseVisualStyleBackColor = True
        '
        'btnBersihkan
        '
        btnBersihkan.CausesValidation = False
        btnBersihkan.Location = New System.Drawing.Point(162, 459)
        btnBersihkan.Name = "btnBersihkan"
        btnBersihkan.Size = New System.Drawing.Size(124, 34)
        btnBersihkan.TabIndex = 7
        btnBersihkan.Text = "Bersihkan"
        btnBersihkan.UseVisualStyleBackColor = True
        '
        'lblCari
        '
        lblCari.AutoSize = True
        lblCari.Location = New System.Drawing.Point(328, 79)
        lblCari.Name = "lblCari"
        lblCari.Size = New System.Drawing.Size(110, 15)
        lblCari.TabIndex = 14
        lblCari.Text = "Cari judul/penulis"
        '
        'txtCari
        '
        txtCari.Location = New System.Drawing.Point(328, 102)
        txtCari.Name = "txtCari"
        txtCari.Size = New System.Drawing.Size(658, 23)
        txtCari.TabIndex = 8
        '
        'lblFilterKategori
        '
        lblFilterKategori.AutoSize = True
        lblFilterKategori.Location = New System.Drawing.Point(328, 141)
        lblFilterKategori.Name = "lblFilterKategori"
        lblFilterKategori.Size = New System.Drawing.Size(83, 15)
        lblFilterKategori.TabIndex = 16
        lblFilterKategori.Text = "Filter kategori"
        '
        'cboFilterKategori
        '
        cboFilterKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        cboFilterKategori.FormattingEnabled = True
        cboFilterKategori.Items.AddRange(New Object() {"Semua", "Fiksi", "Nonfiksi", "Referensi", "Majalah"})
        cboFilterKategori.Location = New System.Drawing.Point(328, 164)
        cboFilterKategori.Name = "cboFilterKategori"
        cboFilterKategori.Size = New System.Drawing.Size(194, 23)
        cboFilterKategori.TabIndex = 9
        '
        'chkStokHabis
        '
        chkStokHabis.AutoSize = True
        chkStokHabis.Location = New System.Drawing.Point(543, 167)
        chkStokHabis.Name = "chkStokHabis"
        chkStokHabis.Size = New System.Drawing.Size(113, 19)
        chkStokHabis.TabIndex = 10
        chkStokHabis.Text = "Hanya stok habis"
        chkStokHabis.UseVisualStyleBackColor = True
        '
        'lblUrut
        '
        lblUrut.AutoSize = True
        lblUrut.Location = New System.Drawing.Point(743, 141)
        lblUrut.Name = "lblUrut"
        lblUrut.Size = New System.Drawing.Size(81, 15)
        lblUrut.TabIndex = 19
        lblUrut.Text = "Urutkan buku"
        '
        'cboUrut
        '
        cboUrut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        cboUrut.FormattingEnabled = True
        cboUrut.Items.AddRange(New Object() {"Urutan awal", "Judul A-Z", "Tahun terbaru", "Stok terbanyak"})
        cboUrut.Location = New System.Drawing.Point(743, 164)
        cboUrut.Name = "cboUrut"
        cboUrut.Size = New System.Drawing.Size(243, 23)
        cboUrut.TabIndex = 11
        '
        'dgvBuku
        '
        dgvBuku.AllowUserToAddRows = False
        dgvBuku.AllowUserToDeleteRows = False
        dgvBuku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvBuku.Location = New System.Drawing.Point(328, 209)
        dgvBuku.MultiSelect = False
        dgvBuku.Name = "dgvBuku"
        dgvBuku.[ReadOnly] = True
        dgvBuku.RowHeadersVisible = False
        dgvBuku.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        dgvBuku.Size = New System.Drawing.Size(658, 330)
        dgvBuku.TabIndex = 12
        '
        'lblJumlah
        '
        lblJumlah.AutoSize = True
        lblJumlah.Location = New System.Drawing.Point(328, 553)
        lblJumlah.Name = "lblJumlah"
        lblJumlah.Size = New System.Drawing.Size(143, 15)
        lblJumlah.TabIndex = 21
        lblJumlah.Text = "Menampilkan 0 dari 0 buku"
        '
        'lblTotalStok
        '
        lblTotalStok.AutoSize = True
        lblTotalStok.Location = New System.Drawing.Point(328, 581)
        lblTotalStok.Name = "lblTotalStok"
        lblTotalStok.Size = New System.Drawing.Size(137, 15)
        lblTotalStok.TabIndex = 22
        lblTotalStok.Text = "Total stok yang tampil: 0"
        '
        'errBuku
        '
        errBuku.ContainerControl = Me
        '
        'FrmInventaris
        '
        AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        ClientSize = New System.Drawing.Size(1010, 622)
        Controls.Add(lblTotalStok)
        Controls.Add(lblJumlah)
        Controls.Add(dgvBuku)
        Controls.Add(cboUrut)
        Controls.Add(lblUrut)
        Controls.Add(chkStokHabis)
        Controls.Add(cboFilterKategori)
        Controls.Add(lblFilterKategori)
        Controls.Add(txtCari)
        Controls.Add(lblCari)
        Controls.Add(btnBersihkan)
        Controls.Add(btnTambah)
        Controls.Add(txtStok)
        Controls.Add(lblStok)
        Controls.Add(txtTahun)
        Controls.Add(lblTahun)
        Controls.Add(cboKategori)
        Controls.Add(lblKategori)
        Controls.Add(txtPenulis)
        Controls.Add(lblPenulis)
        Controls.Add(txtJudul)
        Controls.Add(lblJudul)
        Controls.Add(txtKodeBuku)
        Controls.Add(lblKodeBuku)
        Controls.Add(lblJudulForm)
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "FrmInventaris"
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Text = "Inventaris Buku Perpustakaan"
        CType(dgvBuku, System.ComponentModel.ISupportInitialize).EndInit()
        CType(bsBuku, System.ComponentModel.ISupportInitialize).EndInit()
        CType(errBuku, System.ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents lblJudulForm As System.Windows.Forms.Label
    Friend WithEvents lblKodeBuku As System.Windows.Forms.Label
    Friend WithEvents txtKodeBuku As System.Windows.Forms.TextBox
    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents txtJudul As System.Windows.Forms.TextBox
    Friend WithEvents lblPenulis As System.Windows.Forms.Label
    Friend WithEvents txtPenulis As System.Windows.Forms.TextBox
    Friend WithEvents lblKategori As System.Windows.Forms.Label
    Friend WithEvents cboKategori As System.Windows.Forms.ComboBox
    Friend WithEvents lblTahun As System.Windows.Forms.Label
    Friend WithEvents txtTahun As System.Windows.Forms.TextBox
    Friend WithEvents lblStok As System.Windows.Forms.Label
    Friend WithEvents txtStok As System.Windows.Forms.TextBox
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents btnBersihkan As System.Windows.Forms.Button
    Friend WithEvents lblCari As System.Windows.Forms.Label
    Friend WithEvents txtCari As System.Windows.Forms.TextBox
    Friend WithEvents lblFilterKategori As System.Windows.Forms.Label
    Friend WithEvents cboFilterKategori As System.Windows.Forms.ComboBox
    Friend WithEvents chkStokHabis As System.Windows.Forms.CheckBox
    Friend WithEvents lblUrut As System.Windows.Forms.Label
    Friend WithEvents cboUrut As System.Windows.Forms.ComboBox
    Friend WithEvents dgvBuku As System.Windows.Forms.DataGridView
    Friend WithEvents bsBuku As System.Windows.Forms.BindingSource
    Friend WithEvents lblJumlah As System.Windows.Forms.Label
    Friend WithEvents lblTotalStok As System.Windows.Forms.Label
    Friend WithEvents errBuku As System.Windows.Forms.ErrorProvider

End Class
