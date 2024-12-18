Imports System.Data.Odbc
Public Class Form2

    Private Sub MasterDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasterDataToolStripMenuItem.Click
        ToolStrip1.Dock = DockStyle.Bottom
    End Sub

    Private Sub ToolStripLabel1_Click_1(sender As Object, e As EventArgs) Handles ToolStripStatusLabel1.Click
        ToolStrip1.Dock = DockStyle.Bottom
    End Sub

    Private Sub DataBukuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataBukuToolStripMenuItem.Click
        Databuku()
        ToolStrip1.Dock = DockStyle.Bottom
    End Sub
    Private Sub ToolStrip2_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip2.ItemClicked
    End Sub
    Private Sub Databuku()
        Try
            Call Koneksi()
            Dim Cmd As New OdbcCommand("SELECT * FROM bukuperpus", Conne)
            Dim da As New OdbcDataAdapter(Cmd)
            Dim ds As New DataSet()

            da.Fill(ds, "bukuperpus")

            If ds.Tables("bukuperpus").Rows.Count > 0 Then
                DataGridView1.DataSource = ds.Tables("bukuperpus")
            Else
                MessageBox.Show("No data found!")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

    End Sub



    Private Sub TransaksiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransaksiToolStripMenuItem.Click

    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Dim tutup As String
        tutup = MessageBox.Show("Yakin Mau Keluar ?", "Konfirmasi",
MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If tutup = MsgBoxResult.Yes Then
            Me.Hide()
            Form1.Show()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PeminjamanBukuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PeminjamanBukuToolStripMenuItem.Click
        Call Pinjam()
    End Sub
    Private Sub Pinjam()
        Dim Cmd As New OdbcCommand("SELECT * FROM pinjam", internet.Conne)
        Dim da As New OdbcDataAdapter(Cmd)
        Dim ds As New DataSet()

        Try
            da.Fill(ds, "pinjam")
            DataGridView1.DataSource = ds.Tables("pinjam")
        Catch ex As Exception
            MessageBox.Show("Error" & ex.Message)
        End Try
    End Sub

    Private Sub MonitoringPeminjamanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MonitoringPeminjamanToolStripMenuItem.Click


        ' Query SQL
        Dim Cmd As New OdbcCommand("SELECT * FROM pinjam", internet.Conne)
        Dim da As New OdbcDataAdapter(Cmd) ' Pastikan "Cmd" adalah objek OdbcCommand
        Dim ds As New DataSet()

        ' Isi dataset
        da.Fill(ds, "pinjam")
        DataGridView1.DataSource = ds.Tables("pinjam") ' Pastikan nama tabel sesuai

    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub
End Class