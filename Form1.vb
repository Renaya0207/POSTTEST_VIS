Public Class Form1

    Private Sub InputDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InputDataToolStripMenuItem.Click
        FormInput.Show()
    End Sub

    Private Sub LihatKartuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LihatKartuToolStripMenuItem.Click
        FormKartu.Show()
    End Sub

    Private Sub SimpanDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SimpanDataToolStripMenuItem.Click
        MessageBox.Show("Gunakan tombol simpan di Form Input")
    End Sub

    Private Sub BukaDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BukaDataToolStripMenuItem.Click
        OpenFileDialog1.Filter = "Text File|*.txt|CSV File|*.csv"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            MessageBox.Show(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Dim hasil As DialogResult
        hasil = MessageBox.Show("Yakin keluar?", "Konfirmasi", MessageBoxButtons.YesNo)

        If hasil = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

End Class