Public Class FormMenu

    Private Sub btnMasuk_Click(sender As Object, e As EventArgs) Handles btnMasuk.Click
        FormPesanan.Show()
        Me.Hide()
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Dim tanya As DialogResult
        tanya = MessageBox.Show("Yakin keluar?", "Konfirmasi", MessageBoxButtons.YesNo)

        If tanya = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

End Class