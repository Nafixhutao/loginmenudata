Imports System.Data.Common
Imports System.Data.OleDb
Imports System.Data.Odbc

Public Class databarang
    Private Conn As OdbcConnection
    Private cmd As OdbcCommand
    Private da As OdbcDataAdapter
    Private ds As DataSet
    Private rd As OdbcDataReader
    Private MyDb As String

    Private Sub databarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call kosong()
        Call tampil()
        Call Atur_grid()

    End Sub
    Sub isi()
        TextBox2.Clear()
        TextBox2.Focus()
    End Sub
    Sub kosong()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox1.Focus()
    End Sub
    Sub Koneksi()
        MyDb = "Driver={MySQL ODBC 8.0 ANSI Driver};Server=localhost;Database=data_brg;User=root;Password=;"
        Conn = New OdbcConnection(MyDb)
        Try
            If Conn.State = ConnectionState.Closed Then
                Conn.Open()
                Console.WriteLine("Connection Successful!")
            End If
        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)
        End Try
    End Sub
    Sub Atur_grid()
        DataGridView1.Columns(0).Width = 70
        DataGridView1.Columns(1).Width = 120
        DataGridView1.Columns(2).Width = 100
        DataGridView1.Columns(0).HeaderText = "ID BARANG"
        DataGridView1.Columns(1).HeaderText = "NAMA BARANG"
        DataGridView1.Columns(2).HeaderText = "HARGA (Rp.)"
    End Sub
    Sub tampil()

        Dim query As String = "SELECT * FROM barang "
        da = New OdbcDataAdapter(query, Conn)
        ds = New DataSet()
        da.Fill(ds, "warnet")
        DataGridView1.DataSource = ds.Tables("warnet")
    End Sub

End Class


