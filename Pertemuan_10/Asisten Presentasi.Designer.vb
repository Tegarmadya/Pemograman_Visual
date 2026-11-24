<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        ToolStrip1 = New ToolStrip()
        Label1 = New Label()
        Label2 = New Label()
        BtnMulaiPresentasi = New Button()
        btnUlangi = New Button()
        BtnModeRingkas = New Button()
        chTetapdiatasaplikasilain = New CheckBox()
        Label3 = New Label()
        chBunyisaatselesai = New CheckBox()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Panel1 = New Panel()
        Label12 = New Label()
        lblMenit = New Label()
        Label10 = New Label()
        DomainUpDown1 = New DomainUpDown()
        DomainUpDown2 = New DomainUpDown()
        Label8 = New Label()
        Label9 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.ImageScalingSize = New Size(18, 18)
        ToolStrip1.Location = New Point(0, 0)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(800, 25)
        ToolStrip1.TabIndex = 0
        ToolStrip1.Text = "ToolStrip1"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11.1272726F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(55, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(152, 23)
        Label1.TabIndex = 1
        Label1.Text = "Asisten Presentasi"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9.163636F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(58, 67)
        Label2.Name = "Label2"
        Label2.Size = New Size(302, 19)
        Label2.TabIndex = 2
        Label2.Text = "Jaga durasi tanpa menghubungkan slide Anda"
        ' 
        ' BtnMulaiPresentasi
        ' 
        BtnMulaiPresentasi.BackColor = SystemColors.ActiveCaption
        BtnMulaiPresentasi.Location = New Point(55, 288)
        BtnMulaiPresentasi.Name = "BtnMulaiPresentasi"
        BtnMulaiPresentasi.Size = New Size(468, 41)
        BtnMulaiPresentasi.TabIndex = 3
        BtnMulaiPresentasi.Text = "Mulai Presentasi"
        BtnMulaiPresentasi.UseVisualStyleBackColor = False
        ' 
        ' btnUlangi
        ' 
        btnUlangi.Location = New Point(558, 288)
        btnUlangi.Name = "btnUlangi"
        btnUlangi.Size = New Size(148, 41)
        btnUlangi.TabIndex = 4
        btnUlangi.Text = "Ulangi"
        btnUlangi.UseVisualStyleBackColor = True
        ' 
        ' BtnModeRingkas
        ' 
        BtnModeRingkas.Location = New Point(558, 340)
        BtnModeRingkas.Name = "BtnModeRingkas"
        BtnModeRingkas.Size = New Size(148, 38)
        BtnModeRingkas.TabIndex = 5
        BtnModeRingkas.Text = "Mode Ringkas"
        BtnModeRingkas.UseVisualStyleBackColor = True
        ' 
        ' chTetapdiatasaplikasilain
        ' 
        chTetapdiatasaplikasilain.AutoSize = True
        chTetapdiatasaplikasilain.Location = New Point(57, 355)
        chTetapdiatasaplikasilain.Name = "chTetapdiatasaplikasilain"
        chTetapdiatasaplikasilain.Size = New Size(178, 23)
        chTetapdiatasaplikasilain.TabIndex = 6
        chTetapdiatasaplikasilain.Text = "Tetap di atas aplikasi lain"
        chTetapdiatasaplikasilain.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(57, 396)
        Label3.Name = "Label3"
        Label3.Size = New Size(114, 19)
        Label3.TabIndex = 7
        Label3.Text = "Durasi presentasi"
        ' 
        ' chBunyisaatselesai
        ' 
        chBunyisaatselesai.AutoSize = True
        chBunyisaatselesai.Location = New Point(440, 424)
        chBunyisaatselesai.Name = "chBunyisaatselesai"
        chBunyisaatselesai.Size = New Size(134, 23)
        chBunyisaatselesai.TabIndex = 8
        chBunyisaatselesai.Text = "Bunyi saat selesai"
        chBunyisaatselesai.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(222, 484)
        Label4.Name = "Label4"
        Label4.Size = New Size(0, 19)
        Label4.TabIndex = 9
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(55, 469)
        Label5.Name = "Label5"
        Label5.Size = New Size(154, 19)
        Label5.TabIndex = 10
        Label5.Text = "Ctrl+Alt+F9: Mulai/jeda"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(55, 488)
        Label6.Name = "Label6"
        Label6.Size = New Size(332, 19)
        Label6.TabIndex = 11
        Label6.Text = "Ctrl+Alt+F10: Ulangi. Tombol tetap dapat digunakan"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(58, 531)
        Label7.Name = "Label7"
        Label7.Size = New Size(414, 19)
        Label7.TabIndex = 12
        Label7.Text = "Timer siap. Aktifkan tetap diatas agar terlihat saat berganti aplikasi"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaptionText
        Panel1.Controls.Add(Label12)
        Panel1.Controls.Add(lblMenit)
        Panel1.Controls.Add(Label10)
        Panel1.Location = New Point(58, 110)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(664, 153)
        Panel1.TabIndex = 13
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.ForeColor = SystemColors.ActiveBorder
        Label12.Location = New Point(218, 121)
        Label12.Name = "Label12"
        Label12.Size = New Size(247, 19)
        Label12.TabIndex = 2
        Label12.Text = "Atur durasi. lalu mulai ketilka anda siap"
        ' 
        ' lblMenit
        ' 
        lblMenit.AutoSize = True
        lblMenit.BackColor = SystemColors.ActiveCaptionText
        lblMenit.Font = New Font("Segoe UI", 18.3272724F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblMenit.ForeColor = SystemColors.ButtonFace
        lblMenit.Location = New Point(285, 56)
        lblMenit.Name = "lblMenit"
        lblMenit.Size = New Size(89, 38)
        lblMenit.TabIndex = 1
        lblMenit.Text = "05:00"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.ForeColor = SystemColors.ActiveBorder
        Label10.Location = New Point(285, 13)
        Label10.Name = "Label10"
        Label10.Size = New Size(100, 19)
        Label10.TabIndex = 0
        Label10.Text = "Siap Presentasi"
        ' 
        ' DomainUpDown1
        ' 
        DomainUpDown1.Location = New Point(127, 423)
        DomainUpDown1.Name = "DomainUpDown1"
        DomainUpDown1.Size = New Size(82, 26)
        DomainUpDown1.TabIndex = 14
        DomainUpDown1.Text = "5"
        ' 
        ' DomainUpDown2
        ' 
        DomainUpDown2.Location = New Point(315, 421)
        DomainUpDown2.Name = "DomainUpDown2"
        DomainUpDown2.Size = New Size(93, 26)
        DomainUpDown2.TabIndex = 15
        DomainUpDown2.Text = "0"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(72, 428)
        Label8.Name = "Label8"
        Label8.Size = New Size(45, 19)
        Label8.TabIndex = 16
        Label8.Text = "Menit"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(264, 425)
        Label9.Name = "Label9"
        Label9.Size = New Size(41, 19)
        Label9.TabIndex = 17
        Label9.Text = "Detik"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 569)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(DomainUpDown2)
        Controls.Add(DomainUpDown1)
        Controls.Add(Panel1)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(chBunyisaatselesai)
        Controls.Add(Label3)
        Controls.Add(chTetapdiatasaplikasilain)
        Controls.Add(BtnModeRingkas)
        Controls.Add(btnUlangi)
        Controls.Add(BtnMulaiPresentasi)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(ToolStrip1)
        Name = "Form1"
        Text = "Asisten Presentasi"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnMulaiPresentasi As Button
    Friend WithEvents btnUlangi As Button
    Friend WithEvents BtnModeRingkas As Button
    Friend WithEvents chTetapdiatasaplikasilain As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents chBunyisaatselesai As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents lblMenit As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents DomainUpDown1 As DomainUpDown
    Friend WithEvents DomainUpDown2 As DomainUpDown
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label

End Class
