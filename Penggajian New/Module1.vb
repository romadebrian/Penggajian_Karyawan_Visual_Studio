Imports MySql.Data.MySqlClient
Module Module1
    Public Function Koneksi() As MySqlConnection
        Dim Conn As New MySqlConnection
        Conn = New MySqlConnection("server=localhost; database=gajian; user=root; password=;")
        Conn.Open()
        Return Conn
    End Function
End Module
