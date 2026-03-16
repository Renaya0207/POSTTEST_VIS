Public Class formCetak
    Public nama As String
    Public umur As String
    Public notelp As String
    Public tgllahir As String
    Public alamat As String
    Public gender As String
    Public hobi As String
    Public foto As Image

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNama.Text = nama
        lblUmur.Text = umur
        lblNoTelp.Text = notelp
        lblTglLahir.Text = tgllahir
        lblAlamat.Text = alamat
        lblGender.Text = gender
        lblHobi.Text = hobi

        pictureBoxProfile.Image = foto
    End Sub

End Class