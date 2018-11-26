Imports MySql.Data.MySqlClient
Public Class login
    Dim koneksi = Module1.Koneksi
    Dim CMD As MySqlCommand
    Dim RD As MySqlDataReader

    Sub formKosong()
        txtusername.Text = ""
        txtpassword.Text = ""
    End Sub

    Sub Kode_Otomatis()
        'Dim Urutan As String
        CMD = New MySqlCommand("Select * From hrd where no_hrd in(select max(no_hrd) from hrd) ", koneksi)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows = 0 Then
            FormulirHRD.txtno.Text = "1"
            RD.Close()
        End If
        If Not RD.HasRows Then
            FormulirHRD.txtno.Text = "1"
            RD.Close()
        Else
            FormulirHRD.txtno.Text = Val(RD.Item("no_hrd").ToString) + 1
            'txtno.Text = Urutan + 1
            RD.Close()
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click

        Dispose()

    End Sub

    Private Sub btnSignUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSignUp.Click
        Call Kode_Otomatis()
        FormulirHRD.Show()
        Me.Hide()
    End Sub

    Private Sub btnSignIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSignIn.Click
        Dim aksi As String = String.Empty
        aksi = "select * from user where username = '" + txtusername.Text + "' AND password = '" + txtpassword.Text + "'"
        Dim Sqlku As New MySqlCommand(aksi, Module1.Koneksi)
        Dim Myreder As MySqlDataReader
        Myreder = Sqlku.ExecuteReader
        If Myreder.HasRows = 0 Then
            MsgBox("Username atau Password ada yang salah !", MsgBoxStyle.Exclamation, "Error Login")
            txtusername.Clear()
            txtpassword.Clear()
            txtusername.Focus()
        Else
            Dim Level As String = String.Empty
            Level = "SELECT user.Level FROM user WHERE username = '" & txtusername.Text & "'"
            Dim command As New MySqlCommand(Level, Module1.Koneksi)
            Dim CariL As MySqlDataReader
            CariL = command.ExecuteReader
            'Module1.Koneksi.Close()
            CariL.Read()
            If CariL.Item(0) = "1" Then
                MsgBox("Login Sebagai Admin Berhasil, Selamat Datang " & txtusername.Text & "!", MsgBoxStyle.Information, "Successful Login")
                'MenuUtama.Show()
                'Admin.lblLevel.Text = "1"
                Me.Hide()
                Admin.Show()
            Else
                MsgBox("Login Berhasil, Selamat Datang " & txtusername.Text & "!", MsgBoxStyle.Information, "Successful Login")
                Me.Hide()
                Menu_HRD.Show()
            End If
        End If
    End Sub

    Private Sub txtusername_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtusername.KeyPress
        If e.KeyChar = Chr(13) Then
            txtpassword.Focus()
        End If
    End Sub

    Private Sub txtpassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpassword.KeyPress
        If e.KeyChar = Chr(13) Then
            btnSignIn.Focus()
        End If
    End Sub

    Private Sub login_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Call formKosong()
        txtusername.Focus()
    End Sub

    Private Sub login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class