Module ValidationModule

    Public Function ValidasiPesanan(ep As ErrorProvider, txtKode As TextBox, txtNama As TextBox, txtAlamat As TextBox, txtHP As TextBox, cbJasa As ComboBox) As Boolean

        If txtKode.Text = "" Then
            ep.SetError(txtKode, "Kode wajib diisi")
            Return False
        ElseIf txtNama.Text = "" Then
            ep.SetError(txtNama, "Nama wajib diisi")
            Return False
        ElseIf txtAlamat.Text = "" Then
            ep.SetError(txtAlamat, "Alamat wajib diisi")
            Return False
        ElseIf txtHP.Text = "" Then
            ep.SetError(txtHP, "No HP wajib diisi")
            Return False
        ElseIf cbJasa.Text = "" Then
            ep.SetError(cbJasa, "Pilih jasa")
            Return False
        End If

        Return True
    End Function

End Module