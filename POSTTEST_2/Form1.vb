Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Data awal
        TambahBuku("Harry Potter", "Fantasi")
        TambahBuku("Sherlock Holmes", "Misteri")

        TampilData()

    End Sub


    'Menampilkan data ke DataGridView
    Private Sub TampilData()

        DataGridView1.Rows.Clear()

        For i As Integer = 0 To jumlahBuku - 1
            DataGridView1.Rows.Add(daftarBuku(i, 0), daftarBuku(i, 1))
        Next

    End Sub


    'Button Tambah
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click

        TambahBuku(txtJudul.Text, txtGenre.Text)

        TampilData()

        txtJudul.Clear()
        txtGenre.Clear()

    End Sub


    'Button Hapus
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click

        Dim judul As String = txtJudulHapus.Text

        HapusBuku(judul)

        TampilData()

        txtJudulHapus.Clear()

    End Sub

End Class