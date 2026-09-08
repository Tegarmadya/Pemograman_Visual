Public Class Loginform

    Private Sub Loginform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbRole.Items.Clear()
        cmbRole.Items.Add("Manager")
        cmbRole.Items.Add("Staff")
        cmbRole.SelectedIndex = 0
    End Sub

    Private Sub cmbRole_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRole.SelectedIndexChanged
        Try
            If cmbRole.SelectedItem Is Nothing Then Exit Sub

            Dim imagePath As String

            If cmbRole.SelectedItem.ToString() = "Manager" Then
                imagePath = System.IO.Path.Combine(Application.StartupPath, "Asset/Profile_Male.png")
            Else
                imagePath = System.IO.Path.Combine(Application.StartupPath, "Asset/Profile_Female.png")
            End If

            If System.IO.File.Exists(imagePath) Then
                picAvatar.Image = Image.FromFile(imagePath)
            Else
                MessageBox.Show("File gambar tidak ditemukan di: " & imagePath & vbCrLf &
                                 "Pastikan folder Asset sudah ke-copy ke folder bin\Debug.")
            End If
        Catch ex As Exception
            MessageBox.Show("Gagal load gambar: " & ex.Message)
        End Try
    End Sub

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not (Char.IsLetter(e.KeyChar) OrElse e.KeyChar = " "c OrElse e.KeyChar = ControlChars.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNim_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNim.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse e.KeyChar = ControlChars.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If String.IsNullOrWhiteSpace(txtNama.Text) Then
            MessageBox.Show("Nama belum diisi!")
            txtNama.Focus()
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(txtNim.Text) Then
            MessageBox.Show("NIM belum diisi!")
            txtNim.Focus()
            Exit Sub
        End If

        Const NAMA_VALID As String = "Tegar Madya Shafwan"
        Const NIM_VALID As String = "241712002"

        Dim namaInput As String = txtNama.Text.Trim()
        Dim nimInput As String = txtNim.Text.Trim()

        If String.Equals(namaInput, NAMA_VALID, StringComparison.OrdinalIgnoreCase) AndAlso nimInput = NIM_VALID Then
            Dim frmPenghasilan As New PenghasilanForm(namaInput, nimInput)
            frmPenghasilan.Show()

            Me.Hide()
        Else
            MessageBox.Show("Nama atau NIM tidak sesuai!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

End Class