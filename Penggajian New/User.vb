Imports MySql.Data.MySqlClient
Public Class User
    Dim koneksi = Module1.Koneksi
    Dim CMD As MySqlCommand
    Dim RD As MySqlDataReader

    Private Sub User_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Call PanggilData()
        Call FormMati()
        btnsimpan.Enabled = False
        btnhapus.Enabled = False
        btnupdate.Enabled = False
    End Sub

    Private Sub User_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.UserTableAdapter1.Fill(Me.GajianDataSet1.user)

    End Sub
 
    Sub FormKosong()
        txtnouser.Text = ""
        txtuser.Text = ""
        txtpassword.Text = ""

        txtuser.Focus()
    End Sub

    Sub FormHidup()
        'txtnouser.Enabled = True
        txtuser.Enabled = True
        txtpassword.Enabled = True
    End Sub

    Sub FormMati()
        'txtnouser.Enabled = False
        txtuser.Enabled = False
        txtpassword.Enabled = False
    End Sub

    Sub FormNormal()
        Call FormKosong()
        btntambah.Enabled = True
        btnhapus.Enabled = False
        btnsimpan.Enabled = False
        btnupdate.Enabled = False
        btnkeluar.Text = "Keluar"
        btntambah.Focus()
    End Sub

    Sub Kode_Otomatis()
        Dim Urutan As String
        CMD = New MySqlCommand("Select * From user where no_user in(select max(no_user) from user) ", koneksi)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows = 0 Then
            txtnouser.Text = "1"
            RD.Close()
        End If

        If Not RD.HasRows Then
            txtnouser.Text = "1"
            RD.Close()
        Else
            Urutan = Val(RD.Item("no_user").ToString)
            txtnouser.Text = Urutan + 1
            RD.Close()
        End If
    End Sub

    Sub GridBerwarna()
        With Me.dguser
            .RowsDefaultCellStyle.BackColor = Color.BlanchedAlmond
            .AlternatingRowsDefaultCellStyle.BackColor = Color.Azure
        End With
    End Sub

    Sub PanggilData()
        Dim Adapter As New MySqlDataAdapter("select * from user", Module1.Koneksi)
        Dim dt As New DataTable("user")
        Adapter.Fill(dt)
        dguser.DataSource = dt
        Call GridBerwarna()
    End Sub

    Private Sub dguser_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs)
        If (e.ColumnIndex <> -1 AndAlso dguser.Columns(e.ColumnIndex).DataPropertyName = "password") Then
            If (Not e.Value Is Nothing) Then
                e.Value = New String("*", e.Value.ToString().Length)
            End If
        End If
    End Sub

    Private Sub txtnouser_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnouser.KeyPress
        If e.KeyChar = Chr(13) Then
            txtuser.Focus()
        End If
        
    End Sub

    Private Sub dguser_CellFormatting1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dguser.CellFormatting
        If (e.ColumnIndex <> -1 AndAlso dguser.Columns(e.ColumnIndex).DataPropertyName = "password") Then
            If (Not e.Value Is Nothing) Then
                e.Value = New String("*", e.Value.ToString().Length)
            End If
        End If
    End Sub

    Private Sub dguser_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dguser.Click
        Dim i As Integer
        i = dguser.CurrentRow.Index
        txtnouser.Text = dguser.Item(0, i).Value
        txtuser.Text = dguser.Item(1, i).Value
        txtpassword.Text = dguser.Item(2, i).Value
        cbLevel.Text = dguser.Item(3, i).Value
        Call FormHidup()
        txtnouser.Enabled = False
        btnhapus.Enabled = True
        btnupdate.Enabled = True
        btntambah.Enabled = False
        btnkeluar.Text = "&Normal"
        btnsimpan.Enabled = False
    End Sub

    Private Sub btnhapus_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnhapus.Click
        Dim peringatan As MessageBoxOptions
        peringatan = MessageBox.Show("Apakah anda ingin menghapus User " & txtuser.Text & " ?", "Hapus Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If peringatan = vbYes Then
            If dguser.CurrentRow.Index > -1 Then
                Dim Sql As String = String.Empty
                Sql = "DELETE from user WHERE no_user = '" & txtnouser.Text & "'"
                Dim command As New MySqlCommand(Sql, Module1.Koneksi)
                command.ExecuteNonQuery()
                Module1.Koneksi.Close()
                MessageBox.Show("User " & txtuser.Text & " Telah di hapus", " Penghapusan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call FormKosong()
                Call FormMati()
                Call PanggilData()
                Call FormNormal()
                btnhapus.Enabled = False
                btnupdate.Enabled = False
            Else
                MessageBox.Show("Pilih dulu data yang akan di hapus", "Tidak ada data yang akan di hapus", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            Call FormNormal()
            Call FormKosong()
            Call FormMati()
            btntambah.Focus()
        End If
    End Sub

    Private Sub btnupdate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        Dim Sql As String = String.Empty
        If txtnouser.Text = "" Then
            MessageBox.Show("No User Belum di Input", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call FormHidup()
            txtnouser.Focus()

        ElseIf txtuser.Text = "" Then
            MessageBox.Show("Username Tidak Boleh Kosong", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtuser.Focus()
        ElseIf txtpassword.Text = "" Then
            MessageBox.Show("Isikan Password", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtpassword.Focus()

        Else
            Sql = "UPDATE user set no_user = '" & txtnouser.Text & "', username = '" & txtuser.Text & "', password = '" & txtpassword.Text & "', Level = '" & cbLevel.Text & "' where	no_user = '" & txtnouser.Text & "'"
            Dim command As New MySqlCommand(Sql, Module1.Koneksi)
            command.ExecuteNonQuery()
            Module1.Koneksi.Close()
            MessageBox.Show("Data dengan kode " & txtnouser.Text & " Sudah di Update", "Update data sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call FormKosong()
            Call FormMati()
            Call PanggilData()
            Call FormNormal()
            btntambah.Focus()
            btnhapus.Enabled = False
            btnupdate.Enabled = False
        End If
    End Sub

    Private Sub txtuser_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtuser.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            txtpassword.Focus()
        End If
    End Sub

    Private Sub txtpassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpassword.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            btnsimpan.Focus()
        End If
    End Sub

    Private Sub btntambah_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles btntambah.Click
        Call FormHidup()
        Call FormKosong()
        Call PanggilData()
        Call Kode_Otomatis()
        btnsimpan.Enabled = True
        btntambah.Enabled = False
        btnhapus.Enabled = False
        btnupdate.Enabled = False
        btnkeluar.Text = "&Normal"
        cbLevel.Text = "1"
        txtuser.Focus()
    End Sub

    Private Sub btnsimpan_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnsimpan.Click
        Dim Sql As String = String.Empty
        If txtnouser.Text = "" Then
            MessageBox.Show("No User Belum di Input", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call FormHidup()
            txtnouser.Focus()

        ElseIf txtuser.Text = "" Then
            MessageBox.Show("Username Tidak Boleh Kosong", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call FormHidup()
            txtuser.Focus()
        ElseIf txtpassword.Text = "" Then
            MessageBox.Show("Isikan Password", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call FormHidup()
            txtpassword.Focus()

        Else
            Sql = "INSERT INTO user (no_user,username,password,Level)" & "VALUES ('" & txtnouser.Text & "','" & txtuser.Text & "','" & txtpassword.Text & "', '" & cbLevel.Text & "') "
            Dim command As New MySqlCommand(Sql, Module1.Koneksi)
            command.ExecuteNonQuery()
            Module1.Koneksi.Close()
            MessageBox.Show("Pendaftaran User " & txtuser.Text & " Berhasil", " Simpan data Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call FormKosong()
            Call FormMati()
            Call FormNormal()
            Call PanggilData()
            cbLevel.Text = ""
            btntambah.Focus()
        End If
    End Sub

    Private Sub btnkeluar_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnkeluar.Click
        If btnkeluar.Text = "Keluar" Then
            'Me.Close()
            Admin.Show()

            Me.Hide()
        Else
            Call FormNormal()
            Call FormMati()
            Call PanggilData()
        End If
    End Sub

End Class