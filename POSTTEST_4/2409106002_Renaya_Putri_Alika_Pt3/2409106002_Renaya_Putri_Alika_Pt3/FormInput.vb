Public Class FormInput

    Private Sub FormInput_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TabControl1.SelectedTab = tabData

        ' isi ComboBox
        cmbKomunitas.Items.Add("Avengers")
        cmbKomunitas.Items.Add("Spider-Man")
        cmbKomunitas.Items.Add("Guardians")
        cmbKomunitas.Items.Add("X-Men")

        cmbKomunitas.Text = "Pilih Komunitas"
    End Sub

    '================ VALIDASI =================
    Private Function ValidasiInput() As Boolean
        ErrorProvider1.Clear()

        If txtNama.Text = "" Then
            ErrorProvider1.SetError(txtNama, "Nama tidak boleh kosong")
            Return False
        End If

        If txtID.Text = "" Then
            ErrorProvider1.SetError(txtID, "ID tidak boleh kosong")
            Return False
        End If

        If cmbKomunitas.Text = "Pilih Komunitas" Or cmbKomunitas.Text = "" Then
            ErrorProvider1.SetError(cmbKomunitas, "Pilih komunitas terlebih dahulu")
            Return False
        End If

        If Not mtbHP.MaskCompleted Then
            ErrorProvider1.SetError(mtbHP, "Nomor harus lengkap")
            Return False
        End If

        If Not (cb1.Checked Or cb2.Checked Or cb3.Checked Or cb4.Checked Or cb5.Checked Or cb6.Checked Or cb7.Checked Or cb8.Checked) Then
            MessageBox.Show("Pilih minimal 1 hobby")
            Return False
        End If

        Return True
    End Function

    '================ INPUT FILTER =================
    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) And e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtID.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    '================ OPEN FILE FOTO =================
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.png"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            picFoto.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    '================ SIMPAN DATA =================
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click

        If Not ValidasiInput() Then Exit Sub

        Dim hasil As DialogResult
        hasil = MessageBox.Show("Simpan data?", "Konfirmasi", MessageBoxButtons.YesNoCancel)

        If hasil = DialogResult.Yes Then

            SaveFileDialog1.Filter = "Text File|*.txt"

            If SaveFileDialog1.ShowDialog() = DialogResult.OK Then

                Dim hobby As String = ""
                If cb1.Checked Then hobby &= cb1.Text & ", "
                If cb2.Checked Then hobby &= cb2.Text & ", "
                If cb3.Checked Then hobby &= cb3.Text & ", "
                If cb4.Checked Then hobby &= cb4.Text & ", "
                If cb5.Checked Then hobby &= cb5.Text & ", "
                If cb6.Checked Then hobby &= cb6.Text & ", "
                If cb7.Checked Then hobby &= cb7.Text & ", "
                If cb8.Checked Then hobby &= cb8.Text & ", "

                Dim data As String =
                    "Nama: " & txtNama.Text & vbCrLf &
                    "ID: " & txtID.Text & vbCrLf &
                    "Komunitas: " & cmbKomunitas.Text & vbCrLf &
                    "HP: " & mtbHP.Text & vbCrLf &
                    "Hobby: " & hobby

                IO.File.WriteAllText(SaveFileDialog1.FileName, data)

                MessageBox.Show("Data berhasil disimpan")

                ' kirim ke FormKartu
                FormKartu.lblNama.Text = txtNama.Text
                FormKartu.lblID.Text = txtID.Text
                FormKartu.lblKomunitas.Text = cmbKomunitas.Text
                FormKartu.lblKontak.Text = mtbHP.Text
                FormKartu.lblHobby.Text = hobby

                If picFoto.Image IsNot Nothing Then
                    FormKartu.PicKartu.Image = picFoto.Image
                End If

                FormKartu.Show()

            End If

        ElseIf hasil = DialogResult.No Then
            MessageBox.Show("Data tidak disimpan")
        Else
            MessageBox.Show("Dibatalkan")
        End If

    End Sub

End Class