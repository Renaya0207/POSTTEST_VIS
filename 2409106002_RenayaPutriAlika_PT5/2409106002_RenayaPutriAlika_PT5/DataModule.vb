Imports MySqlConnector

Module DataModule

    Public Function GetAllPesanan() As DataTable
        Dim dt As New DataTable()
        Dim query As String = "SELECT * FROM tbpesanan"
        Using conn = GetConnection()
            Using da As New MySqlDataAdapter(query, conn)
                da.Fill(dt)
            End Using
        End Using
        Return dt
    End Function

    Public Function SearchPesanan(keyword As String) As DataTable
        Dim dt As New DataTable()
        Dim query As String = "SELECT * FROM tbpesanan WHERE kodePesanan LIKE @key OR namaPelanggan LIKE @key"
        Using conn = GetConnection()
            Using da As New MySqlDataAdapter(query, conn)
                da.SelectCommand.Parameters.AddWithValue("@key", "%" & keyword & "%")
                da.Fill(dt)
            End Using
        End Using
        Return dt
    End Function

    Public Function KodeSudahAda(kode As String) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM tbpesanan WHERE kodePesanan=@kode"
        Using conn = GetConnection()
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@kode", kode)
                Return Convert.ToInt32(cmd.ExecuteScalar()) > 0
            End Using
        End Using
    End Function

    Public Function SimpanPesanan(kode As String, nama As String, alamat As String, hp As String, jasa As String) As Boolean
        Dim query As String = "INSERT INTO tbpesanan VALUES (@kode,@nama,@alamat,@hp,@jasa)"
        Using conn = GetConnection()
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@kode", kode)
                cmd.Parameters.AddWithValue("@nama", nama)
                cmd.Parameters.AddWithValue("@alamat", alamat)
                cmd.Parameters.AddWithValue("@hp", hp)
                cmd.Parameters.AddWithValue("@jasa", jasa)
                cmd.ExecuteNonQuery()
            End Using
        End Using
        Return True
    End Function

    Public Function UbahPesanan(kode As String, nama As String, alamat As String, hp As String, jasa As String) As Boolean
        Dim query As String = "UPDATE tbpesanan SET namaPelanggan=@nama, alamat=@alamat, noHP=@hp, jenisJasa=@jasa WHERE kodePesanan=@kode"
        Using conn = GetConnection()
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@kode", kode)
                cmd.Parameters.AddWithValue("@nama", nama)
                cmd.Parameters.AddWithValue("@alamat", alamat)
                cmd.Parameters.AddWithValue("@hp", hp)
                cmd.Parameters.AddWithValue("@jasa", jasa)
                cmd.ExecuteNonQuery()
            End Using
        End Using
        Return True
    End Function

    Public Function HapusPesanan(kode As String) As Boolean
        Dim query As String = "DELETE FROM tbpesanan WHERE kodePesanan=@kode"
        Using conn = GetConnection()
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@kode", kode)
                cmd.ExecuteNonQuery()
            End Using
        End Using
        Return True
    End Function

End Module