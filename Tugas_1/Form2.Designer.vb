<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PenghasilanForm
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblNamaCaption = New System.Windows.Forms.Label()
        Me.lblNamaValue = New System.Windows.Forms.Label()
        Me.lblNimCaption = New System.Windows.Forms.Label()
        Me.lblNimValue = New System.Windows.Forms.Label()
        Me.lblGajiCaption = New System.Windows.Forms.Label()
        Me.txtGaji = New System.Windows.Forms.TextBox()
        Me.btnHitung = New System.Windows.Forms.Button()
        Me.lblPotonganCaption = New System.Windows.Forms.Label()
        Me.lblPotonganValue = New System.Windows.Forms.Label()
        Me.lblBersihCaption = New System.Windows.Forms.Label()
        Me.lblBersihValue = New System.Windows.Forms.Label()
        Me.lblCatatan = New System.Windows.Forms.Label()
        Me.SuspendLayout()

        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.Location = New System.Drawing.Point(30, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(200, 25)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Data Penghasilan"

        Me.lblNamaCaption.AutoSize = True
        Me.lblNamaCaption.Location = New System.Drawing.Point(30, 70)
        Me.lblNamaCaption.Name = "lblNamaCaption"
        Me.lblNamaCaption.Size = New System.Drawing.Size(43, 13)
        Me.lblNamaCaption.TabIndex = 1
        Me.lblNamaCaption.Text = "Nama :"

        Me.lblNamaValue.AutoSize = True
        Me.lblNamaValue.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblNamaValue.Location = New System.Drawing.Point(130, 70)
        Me.lblNamaValue.Name = "lblNamaValue"
        Me.lblNamaValue.Size = New System.Drawing.Size(30, 13)
        Me.lblNamaValue.TabIndex = 2
        Me.lblNamaValue.Text = "-"

        Me.lblNimCaption.AutoSize = True
        Me.lblNimCaption.Location = New System.Drawing.Point(30, 100)
        Me.lblNimCaption.Name = "lblNimCaption"
        Me.lblNimCaption.Size = New System.Drawing.Size(35, 13)
        Me.lblNimCaption.TabIndex = 3
        Me.lblNimCaption.Text = "NIM :"

        Me.lblNimValue.AutoSize = True
        Me.lblNimValue.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblNimValue.Location = New System.Drawing.Point(130, 100)
        Me.lblNimValue.Name = "lblNimValue"
        Me.lblNimValue.Size = New System.Drawing.Size(30, 13)
        Me.lblNimValue.TabIndex = 4
        Me.lblNimValue.Text = "-"

        Me.lblGajiCaption.AutoSize = True
        Me.lblGajiCaption.Location = New System.Drawing.Point(30, 150)
        Me.lblGajiCaption.Name = "lblGajiCaption"
        Me.lblGajiCaption.Size = New System.Drawing.Size(64, 13)
        Me.lblGajiCaption.TabIndex = 5
        Me.lblGajiCaption.Text = "Total Gaji :"

        Me.txtGaji.Location = New System.Drawing.Point(130, 147)
        Me.txtGaji.Name = "txtGaji"
        Me.txtGaji.Size = New System.Drawing.Size(160, 20)
        Me.txtGaji.TabIndex = 6

        Me.btnHitung.Location = New System.Drawing.Point(130, 180)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(100, 30)
        Me.btnHitung.TabIndex = 7
        Me.btnHitung.Text = "Hitung"
        Me.btnHitung.UseVisualStyleBackColor = True

        Me.lblPotonganCaption.AutoSize = True
        Me.lblPotonganCaption.Location = New System.Drawing.Point(30, 230)
        Me.lblPotonganCaption.Name = "lblPotonganCaption"
        Me.lblPotonganCaption.Size = New System.Drawing.Size(58, 13)
        Me.lblPotonganCaption.TabIndex = 8
        Me.lblPotonganCaption.Text = "Potongan :"

        Me.lblPotonganValue.AutoSize = True
        Me.lblPotonganValue.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblPotonganValue.ForeColor = System.Drawing.Color.DarkOrange
        Me.lblPotonganValue.Location = New System.Drawing.Point(130, 230)
        Me.lblPotonganValue.Name = "lblPotonganValue"
        Me.lblPotonganValue.Size = New System.Drawing.Size(30, 13)
        Me.lblPotonganValue.TabIndex = 9
        Me.lblPotonganValue.Text = "-"

        Me.lblBersihCaption.AutoSize = True
        Me.lblBersihCaption.Location = New System.Drawing.Point(30, 260)
        Me.lblBersihCaption.Name = "lblBersihCaption"
        Me.lblBersihCaption.Size = New System.Drawing.Size(70, 13)
        Me.lblBersihCaption.TabIndex = 10
        Me.lblBersihCaption.Text = "Gaji Bersih :"

        Me.lblBersihValue.AutoSize = True
        Me.lblBersihValue.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblBersihValue.ForeColor = System.Drawing.Color.Green
        Me.lblBersihValue.Location = New System.Drawing.Point(130, 258)
        Me.lblBersihValue.Name = "lblBersihValue"
        Me.lblBersihValue.Size = New System.Drawing.Size(30, 15)
        Me.lblBersihValue.TabIndex = 11
        Me.lblBersihValue.Text = "-"

        Me.lblCatatan.AutoSize = False
        Me.lblCatatan.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Italic)
        Me.lblCatatan.ForeColor = System.Drawing.Color.Gray
        Me.lblCatatan.Location = New System.Drawing.Point(30, 300)
        Me.lblCatatan.Name = "lblCatatan"
        Me.lblCatatan.Size = New System.Drawing.Size(280, 70)
        Me.lblCatatan.TabIndex = 12
        Me.lblCatatan.Text = "Catatan skema pajak:" & Global.Microsoft.VisualBasic.ChrW(10) &
            "- Di bawah Rp 5.000.000       : Bebas pajak (0%)" & Global.Microsoft.VisualBasic.ChrW(10) &
            "- Rp 5.000.000 s.d 10.000.000 : Pajak 10%" & Global.Microsoft.VisualBasic.ChrW(10) &
            "- Di atas Rp 10.000.000       : Pajak 15%"

        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(340, 390)
        Me.Controls.Add(Me.lblCatatan)
        Me.Controls.Add(Me.lblBersihValue)
        Me.Controls.Add(Me.lblBersihCaption)
        Me.Controls.Add(Me.lblPotonganValue)
        Me.Controls.Add(Me.lblPotonganCaption)
        Me.Controls.Add(Me.btnHitung)
        Me.Controls.Add(Me.txtGaji)
        Me.Controls.Add(Me.lblGajiCaption)
        Me.Controls.Add(Me.lblNimValue)
        Me.Controls.Add(Me.lblNimCaption)
        Me.Controls.Add(Me.lblNamaValue)
        Me.Controls.Add(Me.lblNamaCaption)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "PenghasilanForm"
        Me.Text = "Data Penghasilan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblNamaCaption As Label
    Friend WithEvents lblNamaValue As Label
    Friend WithEvents lblNimCaption As Label
    Friend WithEvents lblNimValue As Label
    Friend WithEvents lblGajiCaption As Label
    Friend WithEvents txtGaji As TextBox
    Friend WithEvents btnHitung As Button
    Friend WithEvents lblPotonganCaption As Label
    Friend WithEvents lblPotonganValue As Label
    Friend WithEvents lblBersihCaption As Label
    Friend WithEvents lblBersihValue As Label
    Friend WithEvents lblCatatan As Label

End Class