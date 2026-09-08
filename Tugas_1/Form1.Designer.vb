<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Loginform
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
        Me.picAvatar = New System.Windows.Forms.PictureBox()
        Me.lblRole = New System.Windows.Forms.Label()
        Me.cmbRole = New System.Windows.Forms.ComboBox()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.lblNim = New System.Windows.Forms.Label()
        Me.txtNim = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        CType(Me.picAvatar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '

        Me.picAvatar.Location = New System.Drawing.Point(100, 40)
        Me.picAvatar.Name = "picAvatar"
        Me.picAvatar.Size = New System.Drawing.Size(120, 120)
        Me.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAvatar.TabIndex = 0
        Me.picAvatar.TabStop = False

        Me.lblRole.AutoSize = True
        Me.lblRole.Location = New System.Drawing.Point(40, 190)
        Me.lblRole.Name = "lblRole"
        Me.lblRole.Size = New System.Drawing.Size(38, 13)
        Me.lblRole.TabIndex = 1
        Me.lblRole.Text = "Role :"

        Me.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRole.FormattingEnabled = True
        Me.cmbRole.Location = New System.Drawing.Point(100, 187)
        Me.cmbRole.Name = "cmbRole"
        Me.cmbRole.Size = New System.Drawing.Size(160, 21)
        Me.cmbRole.TabIndex = 2

        Me.lblNama.AutoSize = True
        Me.lblNama.Location = New System.Drawing.Point(40, 230)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(43, 13)
        Me.lblNama.TabIndex = 3
        Me.lblNama.Text = "Nama :"

        Me.txtNama.Location = New System.Drawing.Point(100, 227)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(160, 20)
        Me.txtNama.TabIndex = 4

        Me.lblNim.AutoSize = True
        Me.lblNim.Location = New System.Drawing.Point(40, 270)
        Me.lblNim.Name = "lblNim"
        Me.lblNim.Size = New System.Drawing.Size(35, 13)
        Me.lblNim.TabIndex = 5
        Me.lblNim.Text = "NIM :"

        Me.txtNim.Location = New System.Drawing.Point(100, 267)
        Me.txtNim.Name = "txtNim"
        Me.txtNim.Size = New System.Drawing.Size(160, 20)
        Me.txtNim.TabIndex = 6
        '

        Me.btnLogin.Location = New System.Drawing.Point(120, 320)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(100, 30)
        Me.btnLogin.TabIndex = 7
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True

        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(320, 400)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtNim)
        Me.Controls.Add(Me.lblNim)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.lblNama)
        Me.Controls.Add(Me.cmbRole)
        Me.Controls.Add(Me.lblRole)
        Me.Controls.Add(Me.picAvatar)
        Me.Name = "Loginform"
        Me.Text = "Login"
        CType(Me.picAvatar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picAvatar As PictureBox
    Friend WithEvents lblRole As Label
    Friend WithEvents cmbRole As ComboBox
    Friend WithEvents lblNama As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents lblNim As Label
    Friend WithEvents txtNim As TextBox
    Friend WithEvents btnLogin As Button

End Class