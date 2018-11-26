Imports MySql.Data.MySqlClient
Public Class EntryDataGaji
    Dim f, G As Double
    Dim CMD As MySqlCommand
    Dim RD As MySqlDataReader

    Private Sub EntryDataGaji_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Dim RD2 As MySqlDataReader
        Call FormMati()
        Call PanggilData()
        btnsimpan.Enabled = False
        btnhapus.Enabled = False
        btnupdate.Enabled = False
        btnCetak.Enabled = False
        Dim aksi2 As String = String.Empty
        'aksi = "select * from user where username = '" + txtusername.Text + "' AND password = '" + txtpassword.Text + "'"
        aksi2 = "SELECT * FROM karyawan"
        'Dim Sqlku As New MySqlCommand(aksi, Module1.Koneksi)
        'Dim Myreder As MySqlDataReader

        'Myreder = Sqlku.ExecuteReader

        Dim comDB As New MySqlCommand(aksi2, Module1.Koneksi)
        RD2 = comDB.ExecuteReader
        If RD2.HasRows = True Then
            txtnip1.Items.Clear()
            While RD2.Read()
                txtnip1.Items.Add(RD2("NIP"))
            End While
        End If
        RD2.Close()
    End Sub

    Sub FormKosong()
        txtslip.Text = ""
        txtnip1.Text = ""
        txtnama.Text = ""
        cbjabatan.Text = ""
        txtgajibersih.Text = ""
        txtgaji.Text = ""
        txtbiaya.Text = ""
        txtlembur.Text = ""
        txtasuransi.Text = ""
        txtbonus.Text = ""

        txtslip.Focus()
    End Sub

    Sub FormHidup()
        'txtslip.Enabled = True
        txtnip1.Enabled = True
        txtnama.Enabled = True
        cbjabatan.Enabled = True
        txtgajibersih.Enabled = True
        txtgaji.Enabled = True
        txtbiaya.Enabled = True
        txtlembur.Enabled = True
        txtasuransi.Enabled = True
        txtbonus.Enabled = True
        dttglgajian.Enabled = True

    End Sub

    Sub FormMati()
        'txtslip.Enabled = False
        txtnip1.Enabled = False
        txtnama.Enabled = False
        cbjabatan.Enabled = False
        txtgajibersih.Enabled = False
        txtgaji.Enabled = False
        txtbiaya.Enabled = False
        txtlembur.Enabled = False
        txtasuransi.Enabled = False
        txtbonus.Enabled = False
        dttglmasuk.Enabled = False
        dttglgajian.Enabled = False
    End Sub

    Sub FormRedOnly()
        txtnama.ReadOnly = True
        cbjabatan.ReadOnly = True
        txtgaji.ReadOnly = True
        txtbiaya.ReadOnly = True
        txtasuransi.ReadOnly = True
        txtbonus.ReadOnly = True
        dttglmasuk.Enabled = False
    End Sub

    Sub FormRedOnlyOFF()
        txtnama.ReadOnly = False
        cbjabatan.ReadOnly = False
        txtgaji.ReadOnly = False
        txtbiaya.ReadOnly = False
        txtasuransi.ReadOnly = False
        txtbonus.ReadOnly = False
    End Sub

    Sub FormNormal()
        Call FormKosong()
        btntambah.Enabled = True
        btnhapus.Enabled = False
        btnsimpan.Enabled = False
        btnupdate.Enabled = False
        btnkeluar.Text = ""
        btntambah.Focus()
    End Sub

    Sub GridBerwarna()
        With Me.dgtransaksi
            .RowsDefaultCellStyle.BackColor = Color.BlanchedAlmond
            .AlternatingRowsDefaultCellStyle.BackColor = Color.Azure
        End With
    End Sub

    Sub PanggilData()
        Dim Adapter As New MySqlDataAdapter("select * from transaksi", Module1.Koneksi)
        Dim dt As New DataTable("transaksi")
        Adapter.Fill(dt)
        dgtransaksi.DataSource = dt
        Call GridBerwarna()
    End Sub

    Sub Kode_Otomatis()
        Dim Urutan As String
        Dim Hitung, Cari As Long
        CMD = New MySqlCommand("Select * From transaksi where no_slip in(select max(no_slip) from transaksi) ", Koneksi)
        RD = CMD.ExecuteReader
        RD.Read()
        If Not RD.HasRows Then
            Urutan = "Slip/" & "000001"
        Else
            Cari = Microsoft.VisualBasic.Right(RD.GetString(0), 6)
            'If Microsoft.VisualBasic.Left(RD.GetString(0), 9) <> "RKMI" & Date.Now.Year & "/" & Cari Then
            If Not RD.HasRows Then
                Urutan = "Slip/" & "000001"
                'Urutan = "RKM/" & Date.Now.Year & "/" & Val(Microsoft.VisualBasic.Right(RD.GetString(0), 6)) + 1
            Else
                Hitung = Microsoft.VisualBasic.Right(RD.GetString(0), 6) + 1
                Urutan = "Slip/" & Microsoft.VisualBasic.Right("000000" & Hitung, 6)
            End If
        End If
        RD.Close()
        txtslip.Text = Urutan
    End Sub

    Private Sub dgtransaksi_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgtransaksi.Click
        Dim i As Integer
        i = dgtransaksi.CurrentRow.Index
        txtslip.Text = dgtransaksi.Item(0, i).Value
        dttglgajian.Text = dgtransaksi.Item(1, i).Value
        txtnip1.Text = dgtransaksi.Item(2, i).Value
        txtnama.Text = dgtransaksi.Item(3, i).Value
        dttglmasuk.Text = dgtransaksi.Item(4, i).Value
        cbjabatan.Text = dgtransaksi.Item(5, i).Value
        txtgaji.Text = dgtransaksi.Item(6, i).Value
        txtbiaya.Text = dgtransaksi.Item(7, i).Value
        txtlembur.Text = dgtransaksi.Item(8, i).Value
        txtbonus.Text = dgtransaksi.Item(9, i).Value
        txtasuransi.Text = dgtransaksi.Item(10, i).Value
        txtgajibersih.Text = dgtransaksi.Item(11, i).Value

        Call FormHidup()
        'txtslip.Enabled = False
        btnhapus.Enabled = True
        btnupdate.Enabled = True
        btntambah.Enabled = False
        btnkeluar.Text = "&"
        btnsimpan.Enabled = False
        txtslip.ReadOnly = True
        txtnama.ReadOnly = True
        dttglmasuk.Enabled = False
        cbjabatan.ReadOnly = True
        txtgaji.ReadOnly = True
        txtbiaya.ReadOnly = True
        txtasuransi.ReadOnly = True
        txtbonus.ReadOnly = True

    End Sub

    Private Sub btnhapus_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnhapus.Click
        Dim peringatan As MessageBoxOptions
        peringatan = MessageBox.Show("Apakah anda ingin menghapus Slip Denagn Nomor " & txtslip.Text & " ?", "Hapus Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If peringatan = vbYes Then
            If dgtransaksi.CurrentRow.Index > -1 Then
                Dim Sql As String = String.Empty
                Sql = "DELETE from transaksi WHERE no_slip = '" & txtslip.Text & "'"
                Dim command As New MySqlCommand(Sql, Module1.Koneksi)
                command.ExecuteNonQuery()
                Module1.Koneksi.Close()
                MessageBox.Show("Slip dengan nomor " & txtslip.Text & " Sudah di hapus", " Penghapusan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

        If txtslip.Text = "" Then
            MessageBox.Show("No Slip Belum Di Masukan", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call FormHidup()
            txtslip.Focus()

        ElseIf txtnip1.Text = "" Then
            MessageBox.Show("NIP Belum Di Input", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call FormHidup()
            txtnip1.Focus()
        ElseIf txtnama.Text = "" Then
            MessageBox.Show("Anda Belum Menekan Enter Di Kolom NIP", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call FormHidup()
            txtnip1.Focus()
        ElseIf txtgajibersih.Text = "" Then
            MessageBox.Show("Gaji Bersih Belum Di Input", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call FormHidup()
            txtgajibersih.Focus()
        ElseIf txtlembur.Text = "" Then
            MessageBox.Show("Total Lembur Belum Di Input", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call FormHidup()
            txtlembur.Focus()

        ElseIf txtbonus.Text = "" Then
            MessageBox.Show("Anda Belum Menekan Enter Di Kolom Total Jam Lembur", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call FormHidup()
            txtlembur.Focus()
        Else
            Sql = "UPDATE transaksi set no_slip = '" & txtslip.Text & "', tgl_gajian = '" & Format(dttglgajian.Value, "yyy-MM-dd") & "', NIP = '" & txtnip1.Text & "', namaKar = '" & txtnama.Text & "', tgl_masuk = '" & Format(dttglmasuk.Value, "yyy-MM-dd") & "', jabatan = '" & cbjabatan.Text & "', gajiPokok = '" & txtgaji.Text & "', biayaLembur = '" & txtbiaya.Text & "', totalLembur = '" & txtlembur.Text & "', bonus = '" & txtbonus.Text & "', Asuransi = '" & txtasuransi.Text & "', gajiBersih = '" & txtgajibersih.Text & "' where no_slip = '" & txtslip.Text & "'"
            Dim command As New MySqlCommand(Sql, Module1.Koneksi)
            command.ExecuteNonQuery()
            Module1.Koneksi.Close()
            MessageBox.Show("Data dengan kode " & txtslip.Text & " Sudah di Update", "Update data sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
        Call FormRedOnly()
        Call Kode_Otomatis()
        btnsimpan.Enabled = True
        btntambah.Enabled = False
        btnhapus.Enabled = False
        btnupdate.Enabled = False
        btnkeluar.Text = "&"
        txtnip1.Focus()
    End Sub

    Private Sub btnsimpan_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnsimpan.Click
        Dim Sql As String = String.Empty
        If txtslip.Text = "" Then
            MessageBox.Show("No Slip Belum Di Masukan", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call FormHidup()
            txtslip.Focus()

        ElseIf txtnip1.Text = "" Then
            MessageBox.Show("NIP Belum Di Input", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call FormNormal()
            txtnip1.Focus()
        ElseIf txtnama.Text = "" Then
            MessageBox.Show("Anda Belum Menekan Enter Di Kolom NIP", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call FormNormal()
            txtnip1.Focus()
        ElseIf txtgajibersih.Text = "" Then
            MessageBox.Show("Gaji Bersih Belum Di Input", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call FormNormal()
            txtgajibersih.Focus()
        ElseIf txtlembur.Text = "" Then
            MessageBox.Show("Total Lembur Belum Di Input", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call FormNormal()
            txtlembur.Focus()

            'ElseIf txtbonus.Text = "" Then
            'MessageBox.Show("Anda Belum Menekan Enter Di Kolom Total Jam Lembur", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Call FormHidup()
            'txtlembur.Focus()
        Else
            Sql = "INSERT INTO transaksi (no_slip,tgl_gajian,NIP,namaKar,tgl_masuk,jabatan,gajiPokok,biayaLembur,totalLembur,bonus,Asuransi,gajiBersih)" & "VALUES ('" & txtslip.Text & "','" & Format(dttglgajian.Value, "yyy-MM-dd") & "','" & txtnip1.Text & "','" & txtnama.Text & "','" & Format(dttglmasuk.Value, "yyy-MM-dd") & "','" & cbjabatan.Text & "','" & txtgaji.Text & "','" & txtbiaya.Text & "','" & txtlembur.Text & "','" & txtbonus.Text & "','" & txtasuransi.Text & "','" & txtgajibersih.Text & "') "
            Dim command As New MySqlCommand(Sql, Module1.Koneksi)
            command.ExecuteNonQuery()
            Module1.Koneksi.Close()
            MessageBox.Show("Data dengan No Slip " & txtslip.Text & " Berhasil Di Simpan", " Simpan data Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call PanggilData()
            btnsimpan.Enabled = False
            btnCetak.Enabled = True
            btnCetak.Focus()
        End If
    End Sub

    Private Sub btnkeluar_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnkeluar.Click
        If btnkeluar.Text = "" Then
            'Me.Close()
            Menu_HRD.Show()
            Me.Hide()
        Else
            Call FormNormal()
            Call FormMati()
            Call PanggilData()
            btnCetak.Enabled = False
        End If
    End Sub

    Private Sub txtslip_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtslip.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            txtnip1.Focus()
        End If
    End Sub

    Private Sub txtnip1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(Keys.Enter) Then
            Dim aksi As String = String.Empty
            aksi = "select * from karyawan where NIP = '" & txtnip1.Text & "'"
            Dim sqlku As New MySqlCommand(aksi, Module1.Koneksi)
            Dim myreader As MySqlDataReader
            myreader = sqlku.ExecuteReader
            If myreader.Read Then
                txtnama.Text = myreader.Item(1)
                dttglmasuk.Text = myreader.Item(8)
                cbjabatan.Text = myreader.Item(9)
                txtgaji.Text = myreader.Item(10)

                txtnama.ReadOnly = True
                dttglmasuk.Enabled = False
                cbjabatan.ReadOnly = True
                txtgaji.ReadOnly = True

                txtbiaya.Text = 150000
                txtbiaya.ReadOnly = True
                txtlembur.Focus()
            Else
                MessageBox.Show("NIP Karyawan tidak terdaftar ....", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtnip1.Text = ""
                txtnip1.Focus()
            End If
        End If
    End Sub

    Private Sub txtlembur_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtlembur.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If

        If e.KeyChar = Chr(Keys.Enter) Then
            'Dim total As Integer
            Dim biaya, lembur, gajipok, asuran, us As Double

            gajipok = txtgaji.Text
            biaya = txtbiaya.Text
            lembur = txtlembur.Text
            txtasuransi.Text = 200000
            asuran = txtasuransi.Text

            If txtlembur.Text = "0" Then
                'asuran = txtasuransi.Text
                txtbonus.Text = "0"
                txtgajibersih.Text = gajipok - asuran
            Else
                txtbonus.Text = biaya * lembur
                us = txtbonus.Text
                txtbonus.Text = Format(us, "#,###")
                'txtbonus.ReadOnly = True
                'txtasuransi.ReadOnly = True
                'gajipok = txtgaji.Text
                txtgajibersih.Text = gajipok + us - asuran
                'txtgajibersih.ReadOnly = True
            End If
            dttglgajian.Focus()
        End If

    End Sub

    Private Sub txtgajibersih_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtgajibersih.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If

        If e.KeyChar = Chr(Keys.Enter) Then
            btnsimpan.Focus()
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

    Private Sub txtbiaya_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtbiaya.TextChanged
        If txtbiaya.Text = "" Or Not IsNumeric(txtbiaya.Text) Then
            Exit Sub
        End If
        f = txtbiaya.Text
        txtbiaya.Text = Format(f, "#,###") 'menjadikan format corrency
        txtbiaya.SelectionStart = Len(txtbiaya.Text)
    End Sub

    Private Sub txtasuransi_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtasuransi.TextChanged
        If txtasuransi.Text = "" Or Not IsNumeric(txtasuransi.Text) Then
            Exit Sub
        End If
        f = txtasuransi.Text
        txtasuransi.Text = Format(f, "#,###") 'menjadikan format corrency
        txtasuransi.SelectionStart = Len(txtasuransi.Text)
    End Sub

    Private Sub txtgajibersih_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtgajibersih.TextChanged
        If txtgajibersih.Text = "" Or Not IsNumeric(txtgajibersih.Text) Then
            Exit Sub
        End If
        f = txtgajibersih.Text
        txtgajibersih.Text = Format(f, "#,###") 'menjadikan format corrency
        txtgajibersih.SelectionStart = Len(txtgajibersih.Text)
    End Sub

    Private Sub txtbonus_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtbonus.TextChanged
        'If txtbonus.Text = "" Or Not IsNumeric(txtbonus.Text) Then
        'Exit Sub
        'End If
        'f = txtbonus.Text
        'txtbonus.Text = Format(f, "#,###") 'menjadikan format corrency
        'txtbonus.SelectionStart = Len(txtbonus.Text)
    End Sub

    Private Sub btnCetak_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCetak.Click
        With PrintDocument1
            .PrinterSettings.DefaultPageSettings.Landscape = False
            .Print()
            btnkeluar.Focus()
        End With
        'btnCetak.Enabled = True
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString("Nomor SLIP : ", Font, Brushes.Black, 50, 50)
        e.Graphics.DrawString(txtslip.Text, txtslip.Font, Brushes.Black, 150, 50)
        e.Graphics.DrawString("Tanggal Gajian : ", Font, Brushes.Black, 320, 50)
        e.Graphics.DrawString(dttglgajian.Text, dttglgajian.Font, Brushes.Black, 400, 50)
        e.Graphics.DrawString("NIP ", Font, Brushes.Black, 50, 70)
        e.Graphics.DrawString(txtnip1.Text, txtnip1.Font, Brushes.Black, 150, 70)
        e.Graphics.DrawString("Nama Karyawan ", Font, Brushes.Black, 50, 90)
        e.Graphics.DrawString(txtnama.Text, txtnama.Font, Brushes.Black, 150, 90)
        e.Graphics.DrawString("Tanggal Masuk ", Font, Brushes.Black, 50, 110)
        e.Graphics.DrawString(dttglmasuk.Text, dttglmasuk.Font, Brushes.Black, 150, 110)
        e.Graphics.DrawString("Jabatan ", Font, Brushes.Black, 50, 130)
        e.Graphics.DrawString(cbjabatan.Text, cbjabatan.Font, Brushes.Black, 150, 130)
        e.Graphics.DrawString("Gaji Pokok ", Font, Brushes.Black, 50, 150)
        e.Graphics.DrawString(txtgaji.Text, txtgaji.Font, Brushes.Black, 150, 150)
        e.Graphics.DrawString("Biaya Lembur ", Font, Brushes.Black, 320, 150)
        e.Graphics.DrawString(txtbiaya.Text, txtbiaya.Font, Brushes.Black, 400, 150)
        e.Graphics.DrawString("Total Jam Lembur", Font, Brushes.Black, 50, 170)
        e.Graphics.DrawString(txtlembur.Text, txtlembur.Font, Brushes.Black, 150, 170)
        e.Graphics.DrawString("Asuransi ", Font, Brushes.Black, 320, 170)
        e.Graphics.DrawString(txtasuransi.Text, txtasuransi.Font, Brushes.Black, 400, 170)
        e.Graphics.DrawString("Bonus Gaji ", Font, Brushes.Black, 320, 190)
        e.Graphics.DrawString(txtbonus.Text, txtbonus.Font, Brushes.Black, 400, 190)
        e.Graphics.DrawString(" Total Gaji Bersih '" & txtgajibersih.Text & "'", Font, Brushes.Black, 200, 250)
    End Sub

    
    Private Sub dttglgajian_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dttglgajian.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            btnsimpan.Focus()
        End If
    End Sub

    Private Sub txtnip1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtnip1.TextChanged
        Dim aksi As String '= String.Empty
        aksi = "select * from karyawan where NIP = '" & txtnip1.Text & "'"
        Dim sqlku As New MySqlCommand(aksi, Module1.Koneksi)
        Dim myreader As MySqlDataReader
        myreader = sqlku.ExecuteReader
        If myreader.Read Then
            txtnama.Text = myreader.Item(1)
            dttglmasuk.Text = myreader.Item(8)
            cbjabatan.Text = myreader.Item(9)
            txtgaji.Text = myreader.Item(10)

            txtnama.ReadOnly = True
            dttglmasuk.Enabled = False
            cbjabatan.ReadOnly = True
            txtgaji.ReadOnly = True

            txtbiaya.Text = 150000
            txtbiaya.ReadOnly = True
            txtlembur.Focus()
        Else
            'MessageBox.Show("NIP Karyawan tidak terdaftar ....", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtnip1.Text = ""
            'cbNIP.Focus()
        End If
    End Sub


End Class