Imports System.Data.Odbc
Imports System.Runtime.Intrinsics.Arm

Public Class Pemijamanbuku
    Dim Conne As OdbcConnection
    Dim command As OdbcCommand
    Dim read As OdbcDataReader

    Sub Hubungan()
        Dim connectionString As String = "Driver={MySQL ODBC 9.1 ANSI Driver};Server=localhost;Port=3306;Database=login_aja;User=root;Password=;"
        Conne = New OdbcConnection(connectionString)
        Try
            If Conne.State = ConnectionState.Closed Then
                Conne.Open()
                Console.WriteLine("Connection Successful!")
            End If
        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Pemijamanbuku_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Hubungan()
        Call Tampildatakodepemakai()
        Call Tampildatakodebuku()
        Call Tampildatacombojenis_buku()
    End Sub

    Sub Tampildatakodepemakai()
        ComboBox1.Items.Clear()
        Try
            Dim str2 As String = "SELECT kodepemakai FROM pinjam"
            command = New OdbcCommand(str2, Conne)
            read = command.ExecuteReader()
            If read.HasRows Then
                While read.Read()
                    ComboBox1.Items.Add(read("kodepemakai").ToString())
                End While
            End If
        Catch ex As Exception
            MessageBox.Show("Error saat memuat data kode pemakai: " & ex.Message)
        Finally
            If read IsNot Nothing Then read.Close()
        End Try
    End Sub

    Sub Tampildatakodebuku()
        ComboBox2.Items.Clear()
        Try
            Dim str2 As String = "SELECT kodebuku FROM bukuperpus"
            command = New OdbcCommand(str2, Conne)
            read = command.ExecuteReader()
            If read.HasRows Then
                While read.Read()
                    ComboBox2.Items.Add(read("kodebuku").ToString())
                End While
            End If
        Catch ex As Exception
            MessageBox.Show("Error saat memuat data kode buku: " & ex.Message)
        Finally
            If read IsNot Nothing Then read.Close()
        End Try
    End Sub

    Sub Tampildatacombojenis_buku()
        ComboBox3.Items.Clear()
        Try
            Dim str2 As String = "SELECT namajenis FROM milih_jenis"
            command = New OdbcCommand(str2, Conne)
            read = command.ExecuteReader()
            If read.HasRows Then
                While read.Read()
                    ComboBox3.Items.Add(read("namajenis").ToString())
                End While
            End If
        Catch ex As Exception
            MessageBox.Show("Error saat memuat data kode buku: " & ex.Message)
        Finally
            If read IsNot Nothing Then read.Close()
        End Try
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If String.IsNullOrWhiteSpace(ComboBox1.Text) OrElse
           String.IsNullOrWhiteSpace(ComboBox2.Text) OrElse
           String.IsNullOrWhiteSpace(ComboBox3.Text) OrElse
           String.IsNullOrWhiteSpace(TextBox1.Text) OrElse
           String.IsNullOrWhiteSpace(TextBox2.Text) OrElse
           String.IsNullOrWhiteSpace(DateTimePicker1.Text) OrElse
           String.IsNullOrWhiteSpace(DateTimePicker2.Text) Then
            MessageBox.Show("Data belum lengkap.")
            Return
        End If

        Try
            Dim cmdCheck As New OdbcCommand("SELECT * FROM pinjam WHERE kodebuku=?", Conne)
            cmdCheck.Parameters.AddWithValue("?", TextBox1.Text.Trim())
            Dim rd As OdbcDataReader = cmdCheck.ExecuteReader()

            If Not rd.HasRows Then
                rd.Close()
                Dim sql = "INSERT INTO pinjam (kodepemakai, kodebuku, jenis, nama_buku, jumlah, tglmulai, tglakhir) VALUES (?, ?, ?, ?, ?, ?, ?)"
                Dim cmdInsert As New OdbcCommand(sql, Conne)
                cmdInsert.Parameters.AddWithValue("?", ComboBox1.Text.Trim())
                cmdInsert.Parameters.AddWithValue("?", ComboBox2.Text.Trim())
                cmdInsert.Parameters.AddWithValue("?", ComboBox3.Text.Trim())
                cmdInsert.Parameters.AddWithValue("?", TextBox1.Text.Trim())
                cmdInsert.Parameters.AddWithValue("?", TextBox2.Text.Trim())
                cmdInsert.Parameters.AddWithValue("?", DateTimePicker1.Value)
                cmdInsert.Parameters.AddWithValue("?", DateTimePicker2.Value)
                cmdInsert.ExecuteNonQuery()
                MessageBox.Show("Data berhasil disimpan.")
            Else
                MessageBox.Show("Kode Buku sudah terdaftar.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim tanggalMulai As DateTime = DateTimePicker1.Value
        Dim tanggalAkhir As DateTime = DateTimePicker2.Value
        Dim jumlahHari As Integer
        Dim totalDenda As Integer
        Dim dendaPerHari As Integer = 10000

        If tanggalAkhir < tanggalMulai Then
            MessageBox.Show("Tanggal akhir tidak bisa lebih kecil dari tanggal mulai.")
            Return
        End If

        jumlahHari = (tanggalAkhir - tanggalMulai).Days
        totalDenda = If(jumlahHari > 0, jumlahHari * dendaPerHari, 0)
        MessageBox.Show("Denda total: Rp " & totalDenda.ToString("N0"))
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim tutup As DialogResult = MessageBox.Show("Yakin Mau Keluar?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If tutup = DialogResult.Yes Then
            Me.Hide()
            Form2.Show()
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub
End Class
