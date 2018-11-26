Imports MySql.Data.MySqlClient
Public Class CreateUser
    Dim koneksi = Module1.Koneksi
    Dim CMD As MySqlCommand
    Dim RD As MySqlDataReader

    Private Sub CreateUser_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Call Kode_Otomatis()
    End Sub

    Private Sub CreateUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Sub FormHidup()
        txtuser.Enabled = True
        txtpassword.Enabled = True
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

    Private Sub btnSignUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSignUp.Click
        Dim Sql As String = String.Empty
        Dim Sql2 As String = String.Empty
        Dim peringatan As MessageBoxOptions
            If txtnouser.Text = "" Then
                MessageBox.Show("Nomor HRD Belum Di Input", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtnouser.Focus()

            ElseIf txtuser.Text = "" Then
                MessageBox.Show("Masukan Username", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'Call FormHidup()
                txtuser.Focus()
            ElseIf txtpassword.Text = "" Then
                MessageBox.Show("Masukan Password", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'Call FormHidup()
                txtpassword.Focus()

        Else
            peringatan = MessageBox.Show("Apakah Data Sudah Benar ? ", "Validasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If peringatan = vbYes Then
                Sql = "INSERT INTO user (no_user,username,password,Level)" & "VALUES ('" & txtnouser.Text & "','" & txtuser.Text & "','" & txtpassword.Text & "','2')"
                Dim command As New MySqlCommand(Sql, Module1.Koneksi)
                command.ExecuteNonQuery()
                Sql2 = "INSERT INTO hrd (no_hrd,namaHrd,jenkel_hrd,tglLhr,agamaHrd,statusHrd,tgl_msk)" & "VALUES ('" & FormulirHRD.txtno.Text & "','" & FormulirHRD.txtnamahrd.Text & "','" & FormulirHRD.txtgender.Text & "','" & Format(FormulirHRD.dttgllahir.Value, "yyy-MM-dd") & "','" & FormulirHRD.cbagama.Text & "','" & FormulirHRD.txtstatus.Text & "','" & Format(FormulirHRD.dttglmasuk.Value, "yyy-MM-dd") & "') "
                Dim command2 As New MySqlCommand(Sql2, Module1.Koneksi)
                command2.ExecuteNonQuery()
                Module1.Koneksi.Close()
                MessageBox.Show("Pendaftaran Dengan Username " & txtuser.Text & " Berhasil", " Simpan data Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'Me.Close()
                login.Show()
                Me.Hide()
            Else
                txtuser.Focus()
            End If


        End If
    End Sub

    
    Private Sub btnBersih_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBersih.Click
        'txtnouser.Text = ""
        txtuser.Text = ""
        txtpassword.Text = ""
        txtuser.Focus()
    End Sub

    Private Sub txtuser_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtuser.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            txtpassword.Focus()
        End If
    End Sub

    Private Sub txtpassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpassword.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            btnSignUp.Focus()
        End If
    End Sub

    Private Sub txtuser_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtuser.TextChanged
        Dim Adapter As New MySqlDataAdapter("SELECT * FROM user where username = '" & txtuser.Text & "' ", Module1.Koneksi)
        Dim dt As New DataTable("user")
        Adapter.Fill(dt)
        If dt.Rows.Count <> 0 Then
            MessageBox.Show("Username " & txtuser.Text & " Sudah ada, Masukan Username lain", "Ditemukan data yang sama", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call FormHidup()
            txtuser.Text = ""
            txtuser.Focus()
        End If
    End Sub


    Private Sub cblevel_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(Keys.Enter) Then
            btnSignUp.Focus()
        End If
    End Sub

    Private Sub btnkeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnkeluar.Click
        Dim Sql As String = String.Empty
        Dim peringatan As MessageBoxOptions
        peringatan = MessageBox.Show("Apakah anda ingin membatalkan ? ", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If peringatan = vbYes Then
            'Sql = "DELETE from hrd WHERE no_hrd = '" & FormulirHRD.txtno.Text & "' "
            'Dim command As New MySqlCommand(Sql, Module1.Koneksi)
            'command.ExecuteNonQuery()
            'Module1.Koneksi.Close()
            login.Show()
            Me.Close()
        Else
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FormulirHRD.Show()
        Me.Close()
    End Sub
End Class