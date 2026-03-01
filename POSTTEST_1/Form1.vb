Public Class Form1

    Dim totalIP As Double = 0
    Dim jumlahSemester As Integer = 0

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click

        Dim ipSemester As Double

        ' Ganti koma jadi titik supaya aman
        Dim inputAngka As String = txtIPS.Text.Replace(",", ".")

        If Double.TryParse(inputAngka, ipSemester) Then

            If ipSemester >= 0 And ipSemester <= 4 Then

                totalIP += ipSemester
                jumlahSemester += 1

                Dim ipk As Double = totalIP / jumlahSemester

                txtIPK.Text = ipk.ToString("0.00")

                If ipk >= 2.0 And ipk <= 2.75 Then
                    lblPredikat.Text = "Cukup"
                ElseIf ipk >= 2.76 And ipk <= 3.0 Then
                    lblPredikat.Text = "Memuaskan"
                ElseIf ipk >= 3.01 Then
                    lblPredikat.Text = "Sangat Memuaskan"
                Else
                    lblPredikat.Text = "-"
                End If

                txtIPS.Clear()
                txtIPS.Focus()

            Else
                MessageBox.Show("IP Semester harus antara 0 - 4")
            End If

        Else
            MessageBox.Show("Masukkan angka yang valid!")
        End If

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        totalIP = 0
        jumlahSemester = 0

        txtIPS.Clear()
        txtIPK.Clear()
        lblPredikat.Text = "-"
        txtIPS.Focus()

    End Sub

End Class