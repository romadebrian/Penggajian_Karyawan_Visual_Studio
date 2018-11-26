Imports MySql.Data.MySqlClient
Public Class HRD
    Dim koneksi = Module1.Koneksi
    Dim gender As String
    Dim Status As String
    Dim CMD As MySqlCommand
    Dim RD As MySqlDataReader

    Private Sub HRD_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.HrdTableAdapter.Fill(Me.GajianDataSet.hrd)
    End Sub

    Private Sub HRD_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Call PanggilData()
        Call FormMati()
        btnsimpan.Enabled = False
        btnhapus.Enabled = False
        btnupdate.Enabled = False
    End Sub

    Sub FormKosong()
        txtno.Text = ""
        txtnamahrd.Text = ""
        rblaki.Checked = True
        rbperempuan.Checked = False
        cbagama.Text = ""
        rbkawin.Checked = True
        rbtidakkawin.Checked = False
        cbagama.Text = "Islam"

        txtno.Focus()
    End Sub

    Sub FormHidup()
        'txtno.Enabled = True
        txtnamahrd.Enabled = True
        rblaki.Enabled = True
        rbperempuan.Enabled = True
        cbagama.Enabled = True
        rbkawin.Enabled = True
        rbtidakkawin.Enabled = True
        dttgllahir.Enabled = True
        dttglmasuk.Enabled = True
    End Sub

    Sub FormMati()
        txtno.ReadOnly = True
        txtnamahrd.Enabled = False
        rblaki.Enabled = False
        rbperempuan.Enabled = False
        cbagama.Enabled = False
        rbkawin.Enabled = False
        rbtidakkawin.Enabled = False
        dttgllahir.Enabled = False
        dttglmasuk.Enabled = False
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

    Sub GridBerwarna()
        With Me.dghrd
            .RowsDefaultCellStyle.BackColor = Color.BlanchedAlmond
            .AlternatingRowsDefaultCellStyle.BackColor = Color.Azure
        End With
    End Sub

    Sub PanggilData()
        Dim Adapter As New MySqlDataAdapter("select * from hrd", Module1.Koneksi)
        Dim dt As New DataTable("hrd")
        Adapter.Fill(dt)
        dghrd.DataSource = dt
        Call GridBerwarna()
    End Sub

    Private Sub btnhapus_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnhapus.Click
        Dim peringatan As MessageBoxOptions
        peringatan = MessageBox.Show("Apakah anda ingin menghapus HRD Dengan Nama " & txtnamahrd.Text & " ?", "Hapus Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If peringatan = vbYes Then
            If dghrd.CurrentRow.Index > -1 Then
                Dim Sql As String = String.Empty
                Sql = "DELETE from hrd WHERE no_hrd = '" & txtno.Text & "'"
                Dim command As New MySqlCommand(Sql, Module1.Koneksi)
                command.ExecuteNonQuery()
                Module1.Koneksi.Close()
                MessageBox.Show("HRD dengan Nama " & txtnamahrd.Text & " Sudah di hapus", " Penghapusan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
            Call FormHidup()
            txtno.Focus()

        ElseIf txtnamahrd.Text = "" Then
            MessageBox.Show("Masukan Nama HRD", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call FormHidup()
            txtnamahrd.Focus()
        ElseIf cbagama.Text = "" Then
            MessageBox.Show("Pilih Agama", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call FormHidup()
            cbagama.Focus()

        Else
            Sql = "UPDATE hrd set no_hrd = '" & txtno.Text & "', namaHrd = '" & txtnamahrd.Text & "', jenkel_hrd = '" & gender & "', tglLhr = '" & Format(dttgllahir.Value, "yyy-MM-dd") & "', agamaHrd = '" & cbagama.Text & "', statusHrd = '" & Status & "', tgl_msk = '" & Format(dttglmasuk.Value, "yyy-MM-dd") & "' where	no_hrd = '" & txtno.Text & "'"
            Dim command As New MySqlCommand(Sql, Module1.Koneksi)
            command.ExecuteNonQuery()
            Module1.Koneksi.Close()
            MessageBox.Show("Data dengan No " & txtno.Text & " Sudah di Update", "Update data sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call FormKosong()
            Call FormMati()
            Call PanggilData()
            Call FormNormal()
            btntambah.Focus()
            btnhapus.Enabled = False
            btnupdate.Enabled = False
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
        txtnamahrd.Focus()
    End Sub

    Private Sub btnsimpan_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnsimpan.Click
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
            Call FormHidup()
            txtno.Focus()

        ElseIf txtnamahrd.Text = "" Then
            MessageBox.Show("Masukan Nama HRD", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call FormHidup()
            txtnamahrd.Focus()
        ElseIf cbagama.Text = "" Then
            MessageBox.Show("Pilih Agama", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call FormHidup()
            cbagama.Focus()

        Else
            Sql = "INSERT INTO hrd (no_hrd,namaHrd,jenkel_hrd,tglLhr,agamaHrd,statusHrd,tgl_msk)" & "VALUES ('" & txtno.Text & "','" & txtnamahrd.Text & "','" & gender & "','" & Format(dttgllahir.Value, "yyy-MM-dd") & "','" & cbagama.Text & "','" & Status & "','" & Format(dttglmasuk.Value, "yyy-MM-dd") & "') "
            Dim command As New MySqlCommand(Sql, Module1.Koneksi)
            command.ExecuteNonQuery()
            Module1.Koneksi.Close()
            MessageBox.Show("Pendaftaran HRD dengan Nama " & txtnamahrd.Text & " Berhasil", " Simpan data Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call FormKosong()
            Call FormMati()
            Call FormNormal()
            Call PanggilData()
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


    Private Sub txtno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtno.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            txtnamahrd.Focus()
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
            btnsimpan.Focus()
        End If
    End Sub

    Private Sub dghrd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dghrd.Click
        Dim i As Integer
        i = dghrd.CurrentRow.Index
        txtno.Text = dghrd.Item(0, i).Value
        txtnamahrd.Text = dghrd.Item(1, i).Value

        If dghrd.Item(2, i).Value = "Laki - laki" Then
            rblaki.Checked = True
        Else
            rbperempuan.Checked = True
        End If

        dttgllahir.Text = dghrd.Item(3, i).Value
        cbagama.Text = dghrd.Item(4, i).Value

        If dghrd.Item(5, i).Value = "Kawin" Then
            rbkawin.Checked = True
        Else
            rbtidakkawin.Checked = True
        End If

        dttglmasuk.Text = dghrd.Item(6, i).Value

        Call FormHidup()
        btnhapus.Enabled = True
        btnupdate.Enabled = True
        btntambah.Enabled = False
        btnkeluar.Text = "&Normal"
        btnsimpan.Enabled = False
    End Sub

End Class