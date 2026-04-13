Public Class FormPesanan

    Private Sub Kosong()
        txtKode.Clear()
        txtNama.Clear()
        txtAlamat.Clear()
        txtHP.Clear()
        cbJasa.SelectedIndex = -1
        txtSearch.Clear()
        ErrorProvider1.Clear()
        txtKode.Focus()
    End Sub

    Private Sub TampilData()
        dgvPesanan.DataSource = GetAllPesanan()
    End Sub

    Private Sub FormPesanan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilData()
        Kosong()
    End Sub

    ' 🔴 INI YANG KAMU TANYA (SUDAH MASUK DI SINI)
    Private Sub FormPesanan_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        FormMenu.Show()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ErrorProvider1.Clear()

        If Not ValidasiPesanan(ErrorProvider1, txtKode, txtNama, txtAlamat, txtHP, cbJasa) Then Exit Sub

        Dim kode As String = txtKode.Text.Trim()
        Dim nama As String = txtNama.Text.Trim()
        Dim alamat As String = txtAlamat.Text.Trim()
        Dim hp As String = txtHP.Text.Trim()
        Dim jasa As String = cbJasa.Text

        If KodeSudahAda(kode) Then
            MessageBox.Show("Kode sudah ada")
            Exit Sub
        End If

        If SimpanPesanan(kode, nama, alamat, hp, jasa) Then
            MessageBox.Show("Data berhasil disimpan")
            TampilData()
            Kosong()
        End If
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If UbahPesanan(txtKode.Text, txtNama.Text, txtAlamat.Text, txtHP.Text, cbJasa.Text) Then
            MessageBox.Show("Data berhasil diubah")
            TampilData()
            Kosong()
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If txtKode.Text = "" Then Exit Sub

        If MessageBox.Show("Hapus data?", "Konfirmasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            If HapusPesanan(txtKode.Text) Then
                MessageBox.Show("Data berhasil dihapus")
                TampilData()
                Kosong()
            End If
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Kosong()
        TampilData()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text = "" Then
            TampilData()
        Else
            dgvPesanan.DataSource = SearchPesanan(txtSearch.Text)
        End If
    End Sub

    Private Sub dgvPesanan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPesanan.CellClick
        If e.RowIndex >= 0 Then
            txtKode.Text = dgvPesanan.Rows(e.RowIndex).Cells("kodePesanan").Value.ToString()
            txtNama.Text = dgvPesanan.Rows(e.RowIndex).Cells("namaPelanggan").Value.ToString()
            txtAlamat.Text = dgvPesanan.Rows(e.RowIndex).Cells("alamat").Value.ToString()
            txtHP.Text = dgvPesanan.Rows(e.RowIndex).Cells("noHP").Value.ToString()
            cbJasa.Text = dgvPesanan.Rows(e.RowIndex).Cells("jenisJasa").Value.ToString()
        End If
    End Sub

End Class