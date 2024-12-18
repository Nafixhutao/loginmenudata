Imports System.Data.Odbc
Module internet
    Public Conne As OdbcConnection
    Public comand As OdbcCommand
    Public read As OdbcDataReader

    Public Sub Hubungan()
        Dim punya As String = "Driver={MySQL ODBC 9.1 ANSI Driver};Server=localhost;Port=3306;Database=login_aja;User=root;Password=;"
        Conne = New OdbcConnection(punya)
        Try
            If Conne.State = ConnectionState.Closed Then
                Conne.Open()
                Console.WriteLine("Connection Successful!")
            End If
        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)
        End Try
    End Sub
End Module

Public Class Formteslogin
    Private Sub Formteslogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Hubungan()
        Call Kosong1()
    End Sub

    Sub Kosong1()
        Txtuser.Text = ""
        Txtpassword.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Txtuser.Clear()
        Txtpassword.Clear()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            If Conne.State = ConnectionState.Closed Then
                Conne.Open()
            End If


            Dim query As String = "SELECT * FROM login WHERE Nama_Pmk = ? AND Password_Pmk = ?"
            Dim comand As New OdbcCommand(query, Conne)
            comand.Parameters.Add("Nama_Pmk", OdbcType.VarChar).Value = Txtuser.Text
            comand.Parameters.Add("Password_Pmk", OdbcType.VarChar).Value = Txtpassword.Text

            Dim read As OdbcDataReader = comand.ExecuteReader()

            If read.Read() Then
                MessageBox.Show("Login berhasil! Selamat datang, " & Txtuser.Text & ".", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)


                Me.Visible = False
                Form2.Show()
                Form2.ToolStripStatusLabel1.Text = read.GetString(0)
                Form2.ToolStripStatusLabel2.Text = read.GetString(1)
                Form2.ToolStripStatusLabel3.Text = read.GetString(2)


                Form2.Fmenu.Enabled = (Form2.ToolStripStatusLabel3.Text.Trim() = "")
            Else
                '
                MessageBox.Show("Username atau password salah.", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If


        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

            If Conne.State = ConnectionState.Open Then
                Conne.Close()
            End If
        End Try
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Try
            If Conne.State = ConnectionState.Closed Then
                Conne.Open()
            End If

            Dim query As String = "INSERT INTO daftar (nama_pmk, sandi_pmk) VALUES (?, ?)"
            Dim comand As New OdbcCommand(query, Conne)
            comand.Parameters.Add("nama_pmk", OdbcType.VarChar).Value = Txtuser.Text ' Nama pengguna
            comand.Parameters.Add("sandi_pmk", OdbcType.VarChar).Value = Txtpassword.Text ' Sandi

            If comand.ExecuteNonQuery() > 0 Then
                MessageBox.Show("Pendaftaran berhasil!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Setelah pendaftaran berhasil, buka Form2
                Dim form2 As New Form2()
                Me.Hide() ' Sembunyikan Form1
                form2.Show() ' Tampilkan Form2
            Else
                MessageBox.Show("Pendaftaran gagal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If Conne.State = ConnectionState.Open Then
                Conne.Close()
            End If
        End Try
    End Sub



End Class