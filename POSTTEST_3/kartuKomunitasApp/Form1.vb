Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnUploadFoto_Click(sender As Object, e As EventArgs) Handles btnUploadFoto.Click
        Dim openFile As New OpenFileDialog

        openFile.Filter = "Image Files|*.jpg;*.png;*.jpeg"

        If openFile.ShowDialog = DialogResult.OK Then
            pictureBoxProfile.Image = Image.FromFile(openFile.FileName)
        End If
    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click, btnCetak.Click

        If txtNama.Text = "" Or txtUmur.Text = "" Or txtnoTelp.Text = "" Or txtAlamat.Text = "" Then
            MessageBox.Show("Inputan tidak boleh kosong")
            Exit Sub
        End If

        If radiolakiLaki.Checked = False And radioPerempuan.Checked = False Then
            MessageBox.Show("Pilih jenis kelamin terlebih dahulu")
            Exit Sub
        End If

        If Not (checkboxBernyanyi.Checked Or checkboxMenari.Checked Or checkboxMainPiano.Checked Or checkboxMainMusic.Checked Or checkboxBerenang.Checked Or checkboxmembaca.Checked Or checkboxTraveling.Checked Or checkboxFotographi.Checked Or checkboxMenggambar.Checked Or checkboxMenulis.Checked) Then
            MessageBox.Show("Pilih minimal satu hobi")
            Exit Sub
        End If

        If pictureBoxProfile.Image Is Nothing Then
            MessageBox.Show("Foto harus diupload")
            Exit Sub
        End If

        Dim gender = ""

        If radiolakiLaki.Checked Then
            gender = "Laki-laki"
        ElseIf radioPerempuan.Checked Then
            gender = "Perempuan"
        End If


        Dim hobi = ""

        If checkboxBernyanyi.Checked Then hobi &= "Bernyanyi, "
        If checkboxMenari.Checked Then hobi &= "Menari, "
        If checkboxMainPiano.Checked Then hobi &= "Main Piano, "
        If checkboxMainMusic.Checked Then hobi &= "Main Musik, "
        If checkboxBerenang.Checked Then hobi &= "Berenang, "
        If checkboxmembaca.Checked Then hobi &= "Membaca, "
        If checkboxTraveling.Checked Then hobi &= "Traveling, "
        If checkboxFotographi.Checked Then hobi &= "Fotografi, "
        If checkboxMenggambar.Checked Then hobi &= "Menggambar, "
        If checkboxMenulis.Checked Then hobi &= "Menulis, "


        Dim formHasil As New formCetak

        formHasil.nama = txtNama.Text
        formHasil.umur = txtUmur.Text
        formHasil.notelp = txtnoTelp.Text
        formHasil.tgllahir = datePickerTgllahir.Value.ToShortDateString
        formHasil.alamat = txtAlamat.Text
        formHasil.gender = gender
        formHasil.hobi = hobi
        formHasil.foto = pictureBoxProfile.Image

        formHasil.Show()



    End Sub

    Private Sub txtUmur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUmur.KeyPress

        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtnoTelp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnoTelp.KeyPress

        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress

        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) And e.KeyChar <> " "c Then
            e.Handled = True
        End If

    End Sub

    Private Sub pictureBoxProfile_Click(sender As Object, e As EventArgs) Handles pictureBoxProfile.Click

    End Sub
End Class
