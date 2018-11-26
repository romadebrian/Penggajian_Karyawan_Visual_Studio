Imports MySql.Data.MySqlClient
Public Class karyawan
    Dim koneksi = Module1.Koneksi
    Dim gender As String
    Dim Status As String
    Dim f As Double

    Private Sub karyawan_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Call PanggilData()
        Call FormMati()
        btnsimpan.Enabled = False
        btnhapus.Enabled = False
        btnupdate.Enabled = False
        cbjabatan.Text = "Sekretaris"
    End Sub

    Private Sub karyawan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Sub FormKosong()
        txtnip.Text = ""
        txtnama.Text = ""
        rblaki.Checked = True
        rbperempuan.Checked = False
        cbagama.Text = ""
        rbkawin.Checked = True
        rbtidakkawin.Checked = False
        txtalamat.Text = ""
        txttelp.Text = ""
        cbjabatan.Text = ""
        txtgaji.Text = ""
        cbagama.Text = "Islam"
        txtnip.Focus()
    End Sub

    Sub FormHidup()
        txtnip.Enabled = True
        txtnama.Enabled = True
        rblaki.Enabled = True
        rbperempuan.Enabled = True
        cbagama.Enabled = True
        rbkawin.Enabled = True
        rbtidakkawin.Enabled = True
        txtalamat.Enabled = True
        txttelp.Enabled = True
        cbjabatan.Enabled = True
        'txtgaji.Enabled = True
        dttgllahir.Enabled = True
        dttglmasuk.Enabled = True
    End Sub

    Sub FormMati()
        txtnip.Enabled = False
        txtnama.Enabled = False
        rblaki.Enabled = False
        rbperempuan.Enabled = False
        cbagama.Enabled = False
        rbkawin.Enabled = False
        rbtidakkawin.Enabled = False
        txtalamat.Enabled = False
        txttelp.Enabled = False
        cbjabatan.Enabled = False
        'txtgaji.Enabled = False
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

    Sub GridBerwarna()
        With Me.dgkaryawan
            .RowsDefaultCellStyle.BackColor = Color.BlanchedAlmond
            .AlternatingRowsDefaultCellStyle.BackColor = Color.Azure
        End With
    End Sub

    Sub PanggilData()
        Dim Adapter As New MySqlDataAdapter("select * from karyawan", Module1.Koneksi)
        Dim dt As New DataTable("karyawan")
        Adapter.Fill(dt)
        dgkaryawan.DataSource = dt
        Call GridBerwarna()
    End Sub

    Private Sub dgkaryawan_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgkaryawan.Click
        Dim i As Integer
        i = dgkaryawan.CurrentRow.Index
        Call FormHidup()
        txtnip.Text = dgkaryawan.Item(0, i).Value
        txtnama.Text = dgkaryawan.Item(1, i).Value

        If dgkaryawan.Item(2, i).Value = "Laki - laki" Then
            rblaki.Checked = True
        Else
            rbperempuan.Checked = True
        End If

        txtalamat.Text = dgkaryawan.Item(3, i).Value
        txttelp.Text = dgkaryawan.Item(4, i).Value
        dttgllahir.Text = dgkaryawan.Item(5, i).Value
        cbagama.Text = dgkaryawan.Item(6, i).Value

        If dgkaryawan.Item(7, i).Value = "Kawin" Then
            rbkawin.Checked = True
        Else
            rbtidakkawin.Checked = True
        End If

        dttglmasuk.Text = dgkaryawan.Item(8, i).Value
        cbjabatan.Text = dgkaryawan.Item(9, i).Value
        txtgaji.Text = dgkaryawan.Item(10, i).Value


        btnhapus.Enabled = True
        btnupdate.Enabled = True
        btntambah.Enabled = False
        btnkeluar.Text = "&Normal"
        btnsimpan.Enabled = False
    End Sub

    Private Sub btnhapus_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnhapus.Click
        Dim peringatan As MessageBoxOptions
        peringatan = MessageBox.Show("Apakah anda ingin menghapus Karyawan Dengan NIP " & txtnip.Text & " ?", "Hapus Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If peringatan = vbYes Then
            If dgkaryawan.CurrentRow.Index > -1 Then
                Dim Sql As String = String.Empty
                Sql = "DELETE from karyawan WHERE NIP = '" & txtnip.Text & "'"
                Dim command As New MySqlCommand(Sql, Module1.Koneksi)
                command.ExecuteNonQuery()
                Module1.Koneksi.Close()
                MessageBox.Show("Karyawan Dengan NIP " & txtnip.Text & " Sudah di hapus", " Penghapusan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
        If txtnip.Text = "" Then
            MessageBox.Show("NIP Karyawan Belum Di Masukan", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call FormHidup()
            txtnip.Focus()

        ElseIf txtnama.Text = "" Then
            MessageBox.Show("Nama Karyawan Belum Di Masukan", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call FormHidup()
            txtnama.Focus()
        ElseIf cbagama.Text = "" Then
            MessageBox.Show("Agama Belum Di Pilih", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call FormHidup()
            cbagama.Focus()
        ElseIf txtalamat.Text = "" Then
            MessageBox.Show("Alamat Karyawan Belum Di Masukan", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call FormHidup()
            txtalamat.Focus()
        ElseIf txttelp.Text = "" Then
            MessageBox.Show("Nomor Telepon Belum Di Masukan", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call FormHidup()
            txttelp.Focus()
        ElseIf cbjabatan.Text = "" Then
            MessageBox.Show("Jabatan Belum Di Pilih", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call FormHidup()
            cbjabatan.Focus()
        ElseIf txtgaji.Text = "" Then
            MessageBox.Show("Masukan Gaji Karyawan", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call FormHidup()
            txtgaji.Focus()

        Else
            Sql = "UPDATE karyawan set NIP = '" & txtnip.Text & "', namaKar = '" & txtnama.Text & "', Jenkel = '" & gender & "', alamat = '" & txtalamat.Text & "', no_hp = '" & txttelp.Text & "', tgl_lahir = '" & Format(dttgllahir.Value, "yyy-MM-dd") & "', agama = '" & cbagama.Text & "', status = '" & Status & "', tgl_masuk = '" & Format(dttglmasuk.Value, "yyy-MM-dd") & "', jabatan = '" & cbjabatan.Text & "', gajiPokok = '" & txtgaji.Text & "' where NIP = '" & txtnip.Text & "'"
            Dim command As New MySqlCommand(Sql, Module1.Koneksi)
            command.ExecuteNonQuery()
            Module1.Koneksi.Close()
            MessageBox.Show("Data dengan NIP " & txtnip.Text & " Sudah di Update", "Update data sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
        txtnip.Enabled = True
        btnsimpan.Enabled = True
        btntambah.Enabled = False
        btnhapus.Enabled = False
        btnupdate.Enabled = False
        btnkeluar.Text = "&Normal"
        txtnip.Focus()
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

        If txtnip.Text = "" Then
            MessageBox.Show("NIP Karyawan Belum Di Masukan", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtnip.Enabled = True
            txtnip.Focus()
            btnsimpan.Enabled = True

        ElseIf txtnama.Enabled = False Then
            MessageBox.Show("Anda Belum Menekan ENTER di NIP", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtnip.Enabled = True
            txtnip.Focus()
            btnsimpan.Enabled = True
        ElseIf txtnama.Text = "" Then
            MessageBox.Show("Nama Karyawan Belum Di Masukan", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call FormHidup()
            txtnama.Focus()
            btnsimpan.Enabled = True
        ElseIf cbagama.Text = "" Then
            MessageBox.Show("Agama Belum Di Pilih", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call FormHidup()
            cbagama.Focus()
            btnsimpan.Enabled = True
        ElseIf txtalamat.Text = "" Then
            MessageBox.Show("Alamat Karyawan Belum Di Masukan", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call FormHidup()
            txtalamat.Focus()
            btnsimpan.Enabled = True
        ElseIf txttelp.Text = "" Then
            MessageBox.Show("Nomor Telepon Belum Di Masukan", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call FormHidup()
            txttelp.Focus()
            btnsimpan.Enabled = True
        ElseIf cbjabatan.Text = "" Then
            MessageBox.Show("Jabatan Belum Di Pilih", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call FormHidup()
            cbjabatan.Focus()
            btnsimpan.Enabled = True
        ElseIf txtgaji.Text = "" Then
            MessageBox.Show("Masukan Gaji Karyawan", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call FormHidup()
            txtgaji.Focus()
            btnsimpan.Enabled = True

        Else
            Sql = "INSERT INTO karyawan (NIP,namaKar,Jenkel,alamat,no_hp,tgl_lahir,agama,status,tgl_masuk,jabatan,gajiPokok)" & "VALUES ('" & txtnip.Text & "','" & txtnama.Text & "','" & gender & "','" & txtalamat.Text & "','" & txttelp.Text & "','" & Format(dttgllahir.Value, "yyy-MM-dd") & "','" & cbagama.Text & "','" & Status & "','" & Format(dttglmasuk.Value, "yyy-MM-dd") & "','" & cbjabatan.Text & "','" & txtgaji.Text & "') "
            Dim command As New MySqlCommand(Sql, Module1.Koneksi)
            command.ExecuteNonQuery()
            Module1.Koneksi.Close()
            MessageBox.Show("Pendaftaran Karyawan Dengan Nama " & txtnama.Text & " Berhasil", " Simpan data Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
            Menu_HRD.Show()
            Me.Hide()
        Else
            Call FormNormal()
            Call FormMati()
            Call PanggilData()
        End If
    End Sub

    Private Sub txtnip_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnip.KeyPress
        Dim Adapter As New MySqlDataAdapter("SELECT * FROM karyawan where NIP = '" & txtnip.Text & "' ", Module1.Koneksi)
        Dim dt As New DataTable("karyawan")
        Adapter.Fill(dt)
        If e.KeyChar = Chr(Keys.Enter) Then
            If txtnip.Text = "" Then
                MessageBox.Show("NIP Belum di Input", "Ditemukan data yang sama", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtnip.Enabled = True
                txtnip.Text = ""
                txtnip.Focus()
                dgkaryawan.DataSource = dt
                btnsimpan.Enabled = True
            ElseIf dt.Rows.Count <> 0 Then
                MessageBox.Show("NIP " & txtnip.Text & " Sudah ada, inputkan data lain", "Ditemukan data yang sama", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtnip.Enabled = True
                txtnip.Text = ""
                txtnip.Focus()
                dgkaryawan.DataSource = dt
                btnsimpan.Enabled = True
            Else
                Call FormHidup()
                txtnama.Focus()
            End If
        End If
    End Sub

    Private Sub txtnama_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnama.KeyPress
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
            txtalamat.Focus()
        End If
    End Sub

    Private Sub rbtidakkawin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles rbtidakkawin.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            txtalamat.Focus()
        End If
    End Sub

    Private Sub txttelp_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttelp.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If

        If e.KeyChar = Chr(Keys.Enter) Then
            dttglmasuk.Focus()
        End If
    End Sub

    Private Sub dttglmasuk_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dttglmasuk.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            cbjabatan.Focus()
        End If
    End Sub

    Private Sub cbjabatan_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbjabatan.DropDownClosed
        If cbjabatan.Text = "Sekretaris" Then
            txtgaji.Text = "4000000"
        ElseIf cbjabatan.Text = "Staff Full Time" Then
            txtgaji.Text = "3500000"
        Else
            cbjabatan.Text = "Staff Part Time"
            txtgaji.Text = "2500000"
        End If
    End Sub

    Private Sub cbjabatan_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbjabatan.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            btnsimpan.Focus()
            If cbjabatan.Text = "Sekretaris" Then
                txtgaji.Text = "4000000"
            ElseIf cbjabatan.Text = "Staff Full Time" Then
                txtgaji.Text = "3500000"
            Else
                cbjabatan.Text = "Staff Part Time"
                txtgaji.Text = "2500000"
            End If
        End If

    End Sub

    Private Sub txtgaji_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtgaji.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
        If e.KeyChar = Chr(Keys.Enter) Then
            btnsimpan.Focus()
        End If
    End Sub

    Private Sub txtalamat_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtalamat.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            txttelp.Focus()
        End If
    End Sub


    Private Sub txtgaji_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtgaji.TextChanged
        If txtgaji.Text = "" Or Not IsNumeric(txtgaji.Text) Then
            Exit Sub
        End If
        f = txtgaji.Text
        txtgaji.Text = Format(f, "#,###") 'menjadikan format corrency
        txtgaji.SelectionStart = Len(txtgaji.Text)
    End Sub

    Private Sub cbjabatan_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbjabatan.TextChanged
        
    End Sub

    Private Sub dttgllahir_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles dttgllahir.Leave
        Call FormHidup()
        cbagama.Focus()
        dttglmasuk.Enabled = True
        btnsimpan.Enabled = True
    End Sub

    Private Sub dttgllahir_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dttgllahir.LostFocus
        
    End Sub
End Class

