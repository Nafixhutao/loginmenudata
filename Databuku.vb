Imports System.Data.Odbc


Module Module1
    Public Conn As OdbcConnection
    Public da As OdbcDataAdapter
    Public ds As DataSet
    Public cmd As OdbcCommand
    Public rd As OdbcDataReader
    Public MyDb As String

    Public Sub Koneksi()
        MyDb = "Driver={MySQL ODBC 9.1 ANSI Driver};Server=localhost;Port=3306;Database=login_aja;User=root;Password=;"
        Conn = New OdbcConnection(MyDb)
        Try
            If Conn.State = ConnectionState.Closed Then
                Conn.Open()
                Console.WriteLine("Connection Successful!")
            End If
        Catch ex As Exception
            Console.WriteLine("Error : " & ex.Message)
        End Try
    End Sub
End Module
Public Class Databuku
    Private Sub Databuku_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Kosong()
        Call Koneksi()
        Call TampilBuku()
        Call AturGrid()
        Call IsiComboBox()
    End Sub

    Sub Kosong()
        kodebukutxt.Text = ""
        judultxt.Text = ""
        pengarangtxt.Text = ""
        pernebittxt.Text = ""
        jumlahbkutxt.Text = ""
        cbljenisbkutxt.Text = ""
        dkstxt.Text = ""
        hargatxt.Text = ""
    End Sub

    Sub IsiComboBox()
        Dim query As String = "SELECT kodejenis, namajenis FROM milih_jenis"
        Dim dt As New DataTable()

        Try

            If Conn.State = ConnectionState.Closed Then
                Conn.Open()
            End If


            da = New OdbcDataAdapter(query, Conn)
            da.Fill(dt)


            cbljenisbkutxt.DataSource = dt
            cbljenisbkutxt.DisplayMember = "kodejenis"
            cbljenisbkutxt.ValueMember = "namajenis"   '


            cbljenisbkutxt.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub


    Sub TampilBuku()
        Try
            Dim query As String = "SELECT * FROM bukuperpus "
            da = New OdbcDataAdapter(query, Conn)
            ds = New DataSet()
            da.Fill(ds, "bukuperpus")
            DataGridView1.DataSource = ds.Tables("bukuperpus")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
    Sub AturGrid()
        DataGridView1.Columns(0).Width = 60
        DataGridView1.Columns(1).Width = 100
        DataGridView1.Columns(2).Width = 200
        DataGridView1.Columns(3).Width = 100
        DataGridView1.Columns(4).Width = 100
        DataGridView1.Columns(5).Width = 100
        DataGridView1.Columns(6).Width = 90
        DataGridView1.Columns(0).HeaderText = "KODE BUKU"
        DataGridView1.Columns(1).HeaderText = "KODE JENIS"
        DataGridView1.Columns(2).HeaderText = "JUDUL"
        DataGridView1.Columns(3).HeaderText = "PENGARANG"
        DataGridView1.Columns(4).HeaderText = "PENERBIT"
        DataGridView1.Columns(5).HeaderText = "JUMLAH"
        DataGridView1.Columns(6).HeaderText = "HARGA"
        DataGridView1.Columns(7).HeaderText = "DESKRIPSI"
    End Sub


    Private Sub Btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        kodebukutxt.Text = ""
        judultxt.Text = ""
        pengarangtxt.Text = ""
        pernebittxt.Text = ""
        jumlahbkutxt.Text = ""
        cbljenisbkutxt.Text = ""
        dkstxt.Text = ""
        hargatxt.Text = ""
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        Dim query As String = "INSERT INTO bukuperpus (kodebuku,kodejns ,judul, pengarang, penerbit,jmlbuku, harga,deskirpsi) VALUES (?, ?, ?, ?, ?, ?, ?,?)"

        cmd = New OdbcCommand(query, Conn)
        cmd.Parameters.AddWithValue("kodebuku", kodebukutxt.Text)
        cmd.Parameters.AddWithValue("kodejns", cbljenisbkutxt.Text)
        cmd.Parameters.AddWithValue("judul", judultxt.Text)
        cmd.Parameters.AddWithValue("pengarang", pengarangtxt.Text)
        cmd.Parameters.AddWithValue("pernebit", pernebittxt.Text)
        cmd.Parameters.AddWithValue("jumlahbuku", jumlahbkutxt.Text)
        cmd.Parameters.AddWithValue("harga", hargatxt.Text)
        cmd.Parameters.AddWithValue("deskirpsi", dkstxt.Text)
        Try
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data saved successfully!")
            TampilBuku()
            Btnclear_Click(sender, e)

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            kodebukutxt.Text = row.Cells(0).Value.ToString()
            judultxt.Text = row.Cells(1).Value.ToString()
            pengarangtxt.Text = row.Cells(2).Value.ToString()
            pernebittxt.Text = row.Cells(3).Value.ToString()
            jumlahbkutxt.Text = row.Cells(4).Value.ToString()
            hargatxt.Text = row.Cells(5).Value.ToString()
            dkstxt.Text = row.Cells(6).Value.ToString()


        End If
    End Sub

    Private Sub Btnubah_Click(sender As Object, e As EventArgs) Handles btnubah.Click

        Dim query As String = "UPDATE bukuperpus SET judul = ?, pengarang = ?, penerbit = ?, jmlbuku = ?, harga = ? WHERE kodebuku = ?"
        cmd = New OdbcCommand(query, Conn)


        cmd.Parameters.AddWithValue("?", judultxt.Text)
        cmd.Parameters.AddWithValue("?", pengarangtxt.Text)
        cmd.Parameters.AddWithValue("?", pernebittxt.Text)
        cmd.Parameters.AddWithValue("?", jumlahbkutxt.Text)
        cmd.Parameters.AddWithValue("?", hargatxt.Text)
        cmd.Parameters.AddWithValue("?", kodebukutxt.Text)

        Try

            If Conn.State = ConnectionState.Closed Then
                Conn.Open()
            End If

            cmd.ExecuteNonQuery()
            MessageBox.Show("Data berhasil diubah!")

            TampilBuku()
            Btnclear_Click(sender, e)

        Catch ex As Exception

            MessageBox.Show("Error: " & ex.Message & vbCrLf & "Query: " & query)
        End Try
    End Sub


    Private Sub Jumlahbkutxt_TextChanged(sender As Object, e As EventArgs) Handles jumlahbkutxt.TextChanged

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            kodebukutxt.Text = row.Cells(0).Value.ToString()
            judultxt.Text = row.Cells(1).Value.ToString()
            pengarangtxt.Text = row.Cells(2).Value.ToString()
            pernebittxt.Text = row.Cells(3).Value.ToString()
            jumlahbkutxt.Text = row.Cells(4).Value.ToString()
            hargatxt.Text = row.Cells(5).Value.ToString()
            dkstxt.Text = row.Cells(6).Value.ToString()
        End If
    End Sub



    Private Sub Btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click


        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin menghapus data list ini? " & kodebukutxt.Text & "?", "Konfirmasi Hapus", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Dim query As String = "DELETE FROM bukuperpus WHERE kodebuku = ?"
            cmd = New OdbcCommand(query, Conn)
            cmd.Parameters.AddWithValue("?", kodebukutxt.Text)

            Try
                cmd.ExecuteNonQuery()
                MessageBox.Show("Data berhasil dihapus!")
                TampilBuku()
                Btnclear_Click(sender, e)

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End If

    End Sub
    Private Sub Cbljenisbkutxt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbljenisbkutxt.SelectedIndexChanged
        Try

            If TypeOf cbljenisbkutxt.SelectedValue Is String Then
                TextBox1.Text = cbljenisbkutxt.SelectedValue.ToString()
            Else
                TextBox1.Text = ""
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class