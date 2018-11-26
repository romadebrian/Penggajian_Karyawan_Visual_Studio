Imports MySql.Data.MySqlClient
Public Class FormulirHRD
    Dim koneksi = Module1.Koneksi
    Dim gender As String
    Dim Status As String
    Dim CMD As MySqlCommand
    Dim RD As MySqlDataReader

    Private Sub FormulirHRD_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        'Call Kode_Otomatis()
    End Sub

    Sub Kode_Otomatis()
        'Dim Urutan As String
        CMD = New MySqlCommand("Select * From hrd where no_hrd in(select max(no_hrd) from hrd) ", koneksi)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows = 0 Then
            txtno.Text = "1"
            RD.Close()
        End If
        If Not RD.HasRows Then
            txtno.Text = "1"
            RD.Close()
        Else
            txtno.Text = Val(RD.Item("no_hrd").ToString) + 1
            'txtno.Text = Urutan + 1
            RD.Close()
        End If
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        login.Show()
        Me.Hide()
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        Dim Sql As String = String.Empty
        If rblaki.Checked = True Then
            gender = rblaki.Text
        ElseIf rbperempuan.Checked = True Then
            gender = rbperempuan.Text
        End If

        If rbkawin.Checked = True Then
            Status = rbkawin.Text
        Else
            Status = rbtidakkawin.Text
        End If

        If txtno.Text = "" Then
            MessageBox.Show("Nomor HRD Belum Di Input", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)

            txtno.Focus()

        ElseIf txtnamahrd.Text = "" Then
            MessageBox.Show("Masukan Nama HRD", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)

            txtnamahrd.Focus()

        ElseIf gender = "" Then
            MessageBox.Show("Pilih Jenis Kelamin", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)

            rblaki.Focus()

        ElseIf cbagama.Text = "" Then
            MessageBox.Show("Pilih Agama", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)

            cbagama.Focus()

        ElseIf rbkawin.Checked = False And rbtidakkawin.Checked = False Then
            MessageBox.Show("Pilih Status Perkawinan", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)

            rbkawin.Focus()

        Else
            'Sql = "INSERT INTO hrd (no_hrd,namaHrd,jenkel_hrd,tglLhr,agamaHrd,statusHrd,tgl_msk)" & "VALUES ('" & txtno.Text & "','" & txtnamahrd.Text & "','" & gender & "','" & Format(dttgllahir.Value, "yyy-MM-dd") & "','" & cbagama.Text & "','" & Status & "','" & Format(dttglmasuk.Value, "yyy-MM-dd") & "') "
            'Dim command As New MySqlCommand(Sql, Module1.Koneksi)
            'command.ExecuteNonQuery()
            'Module1.Koneksi.Close()
            'MessageBox.Show("Pendaftaran HRD dengan Nama " & txtnamahrd.Text & " Berhasil", " Simpan data Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CreateUser.Show()
            Me.Hide()
            txtgender.Text = gender
            txtstatus.Text = Status
        End If
        
    End Sub

    Private Sub txtnamahrd_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnamahrd.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            rblaki.Focus()
        End If
    End Sub

    Private Sub rblaki_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles rblaki.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            dttgllahir.Focus()
        End If
    End Sub

    Private Sub rbperempuan_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles rbperempuan.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            dttgllahir.Focus()
        End If
    End Sub

    Private Sub dttgllahir_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dttgllahir.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            cbagama.Focus()
        End If
    End Sub

    Private Sub cbagama_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbagama.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            rbkawin.Focus()
        End If
    End Sub

    Private Sub rbkawin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles rbkawin.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            dttglmasuk.Focus()
        End If
    End Sub

    Private Sub rbtidakkawin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles rbtidakkawin.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            dttglmasuk.Focus()
        End If
    End Sub

    Private Sub dttglmasuk_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dttglmasuk.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            btnNext.Focus()
        End If
    End Sub

    Private Sub btnkeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnkeluar.Click

        End

    End Sub

    Private Sub FormulirHRD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    
End Class