Option Strict On
Option Explicit On

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPeminjaman
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
        lblKategori = New System.Windows.Forms.Label()
        cboKategori = New System.Windows.Forms.ComboBox()
        lblNamaPeminjam = New System.Windows.Forms.Label()
        txtNamaPeminjam = New System.Windows.Forms.TextBox()
        lblLamaPinjam = New System.Windows.Forms.Label()
        txtLamaPinjam = New System.Windows.Forms.TextBox()
        btnPinjam = New System.Windows.Forms.Button()
        btnBersihkan = New System.Windows.Forms.Button()
        lstPeminjaman = New System.Windows.Forms.ListBox()
        btnEkspor = New System.Windows.Forms.Button()
        lblStatus = New System.Windows.Forms.Label()
        errPinjam = New System.Windows.Forms.ErrorProvider(components)
        CType(errPinjam, System.ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()

        lblJudulForm.AutoSize = True
        lblJudulForm.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        lblJudulForm.Location = New System.Drawing.Point(28, 18)
        lblJudulForm.Name = "lblJudulForm"
        lblJudulForm.Size = New System.Drawing.Size(158, 25)
        lblJudulForm.TabIndex = 0
        lblJudulForm.Text = "Peminjaman Buku"

        lblKodeBuku.AutoSize = True
        lblKodeBuku.Location = New System.Drawing.Point(28, 66)
        lblKodeBuku.Name = "lblKodeBuku"
        lblKodeBuku.Size = New System.Drawing.Size(61, 15)
        lblKodeBuku.TabIndex = 1
        lblKodeBuku.Text = "Kode Buku"

        txtKodeBuku.Location = New System.Drawing.Point(28, 88)
        txtKodeBuku.Name = "txtKodeBuku"
        txtKodeBuku.Size = New System.Drawing.Size(280, 23)
        txtKodeBuku.TabIndex = 0

        lblJudul.AutoSize = True
        lblJudul.Location = New System.Drawing.Point(28, 124)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New System.Drawing.Size(62, 15)
        lblJudul.TabIndex = 3
        lblJudul.Text = "Judul Buku"

        txtJudul.Location = New System.Drawing.Point(28, 146)
        txtJudul.Name = "txtJudul"
        txtJudul.Size = New System.Drawing.Size(280, 23)
        txtJudul.TabIndex = 1

        lblKategori.AutoSize = True
        lblKategori.Location = New System.Drawing.Point(28, 182)
        lblKategori.Name = "lblKategori"
        lblKategori.Size = New System.Drawing.Size(52, 15)
        lblKategori.TabIndex = 5
        lblKategori.Text = "Kategori"

        cboKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        cboKategori.FormattingEnabled = True
        cboKategori.Items.AddRange(New Object() {"Fiksi", "Nonfiksi", "Referensi", "Majalah"})
        cboKategori.Location = New System.Drawing.Point(28, 204)
        cboKategori.Name = "cboKategori"
        cboKategori.Size = New System.Drawing.Size(280, 23)
        cboKategori.TabIndex = 2

        lblNamaPeminjam.AutoSize = True
        lblNamaPeminjam.Location = New System.Drawing.Point(28, 240)
        lblNamaPeminjam.Name = "lblNamaPeminjam"
        lblNamaPeminjam.Size = New System.Drawing.Size(91, 15)
        lblNamaPeminjam.TabIndex = 7
        lblNamaPeminjam.Text = "Nama Peminjam"

        txtNamaPeminjam.Location = New System.Drawing.Point(28, 262)
        txtNamaPeminjam.Name = "txtNamaPeminjam"
        txtNamaPeminjam.Size = New System.Drawing.Size(280, 23)
        txtNamaPeminjam.TabIndex = 3

        lblLamaPinjam.AutoSize = True
        lblLamaPinjam.Location = New System.Drawing.Point(28, 298)
        lblLamaPinjam.Name = "lblLamaPinjam"
        lblLamaPinjam.Size = New System.Drawing.Size(108, 15)
        lblLamaPinjam.TabIndex = 9
        lblLamaPinjam.Text = "Lama Pinjam (hari)"

        txtLamaPinjam.Location = New System.Drawing.Point(28, 320)
        txtLamaPinjam.Name = "txtLamaPinjam"
        txtLamaPinjam.Size = New System.Drawing.Size(280, 23)
        txtLamaPinjam.TabIndex = 4

        btnPinjam.Location = New System.Drawing.Point(28, 372)
        btnPinjam.Name = "btnPinjam"
        btnPinjam.Size = New System.Drawing.Size(128, 30)
        btnPinjam.TabIndex = 5
        btnPinjam.Text = "Pinjam"
        btnPinjam.UseVisualStyleBackColor = True

        btnBersihkan.CausesValidation = False
        btnBersihkan.Location = New System.Drawing.Point(180, 372)
        btnBersihkan.Name = "btnBersihkan"
        btnBersihkan.Size = New System.Drawing.Size(128, 30)
        btnBersihkan.TabIndex = 6
        btnBersihkan.Text = "Bersihkan"
        btnBersihkan.UseVisualStyleBackColor = True

        lstPeminjaman.FormattingEnabled = True
        lstPeminjaman.HorizontalScrollbar = True
        lstPeminjaman.Location = New System.Drawing.Point(348, 68)
        lstPeminjaman.Name = "lstPeminjaman"
        lstPeminjaman.Size = New System.Drawing.Size(414, 274)
        lstPeminjaman.TabIndex = 8

        btnEkspor.Location = New System.Drawing.Point(348, 372)
        btnEkspor.Name = "btnEkspor"
        btnEkspor.Size = New System.Drawing.Size(128, 30)
        btnEkspor.TabIndex = 7
        btnEkspor.Text = "Ekspor CSV"
        btnEkspor.UseVisualStyleBackColor = True

        lblStatus.AutoSize = True
        lblStatus.Location = New System.Drawing.Point(28, 430)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New System.Drawing.Size(130, 15)
        lblStatus.TabIndex = 15
        lblStatus.Text = "Jumlah peminjaman: 0"

        errPinjam.ContainerControl = Me

        AcceptButton = btnPinjam
        AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        ClientSize = New System.Drawing.Size(790, 470)
        Controls.Add(lblStatus)
        Controls.Add(btnEkspor)
        Controls.Add(lstPeminjaman)
        Controls.Add(btnBersihkan)
        Controls.Add(btnPinjam)
        Controls.Add(txtLamaPinjam)
        Controls.Add(lblLamaPinjam)
        Controls.Add(txtNamaPeminjam)
        Controls.Add(lblNamaPeminjam)
        Controls.Add(cboKategori)
        Controls.Add(lblKategori)
        Controls.Add(txtJudul)
        Controls.Add(lblJudul)
        Controls.Add(txtKodeBuku)
        Controls.Add(lblKodeBuku)
        Controls.Add(lblJudulForm)
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "FrmPeminjaman"
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Text = "Peminjaman Buku"
        CType(errPinjam, System.ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents lblJudulForm As System.Windows.Forms.Label
    Friend WithEvents lblKodeBuku As System.Windows.Forms.Label
    Friend WithEvents txtKodeBuku As System.Windows.Forms.TextBox
    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents txtJudul As System.Windows.Forms.TextBox
    Friend WithEvents lblKategori As System.Windows.Forms.Label
    Friend WithEvents cboKategori As System.Windows.Forms.ComboBox
    Friend WithEvents lblNamaPeminjam As System.Windows.Forms.Label
    Friend WithEvents txtNamaPeminjam As System.Windows.Forms.TextBox
    Friend WithEvents lblLamaPinjam As System.Windows.Forms.Label
    Friend WithEvents txtLamaPinjam As System.Windows.Forms.TextBox
    Friend WithEvents btnPinjam As System.Windows.Forms.Button
    Friend WithEvents btnBersihkan As System.Windows.Forms.Button
    Friend WithEvents lstPeminjaman As System.Windows.Forms.ListBox
    Friend WithEvents btnEkspor As System.Windows.Forms.Button
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents errPinjam As System.Windows.Forms.ErrorProvider

End Class
