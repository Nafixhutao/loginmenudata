Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Arrayganda
    Private Sub Arrayganda_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ListView1.View = View.Details
        ListView1.GridLines = True

        Dim Arr(6, 1) As String

        Arr(0, 0) = "NIM"
        Arr(0, 1) = "NAMA"
        Arr(1, 0) = "JENIS KELAMIN"
        Arr(1, 1) = "FAKULTAS"
        Arr(2, 0) = "Laki-Laki"
        Arr(2, 1) = "Perempuan"
        Arr(3, 0) = "Sosial"
        Arr(3, 1) = "Sains Teknologi"
        Arr(4, 0) = "Teknik Informatika"
        Arr(4, 1) = "Teknik Mesin"
        Arr(5, 0) = "Sistem Informasi"
        Arr(5, 1) = "Teknik Elektro"

        For Baris = 0 To 1
            For kolom = 0 To 1
                ListView1.Columns.Add(Arr(Baris, kolom), 100)
            Next kolom
        Next Baris
        ListView1.Columns.Add("PRODI", 100)


        For Baris = 2 To 2
            For kolom = 0 To 1
                ComboBox1.Items.Add(Arr(Baris, kolom))
            Next kolom
        Next Baris

        For Baris = 3 To 3
            For kolom = 0 To 1
                ComboBox2.Items.Add(Arr(Baris, kolom))
            Next kolom
        Next Baris

        For Baris = 4 To 4
            For kolom = 0 To 1
                ComboBox3.Items.Add(Arr(Baris, kolom))

            Next kolom

            ListView1.Columns.Add("Semester", 100)
            For i = 1 To 8
                ComboBox4.Items.Add(i.ToString())
            Next i
        Next Baris

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Arr(6) As String
        Arr(0) = TextBox1.Text
        Arr(1) = TextBox2.Text
        Arr(2) = ComboBox1.Text
        Arr(3) = ComboBox2.Text
        Arr(4) = ComboBox3.Text
        Arr(5) = ComboBox4.Text

        Dim listitem As ListViewItem
        listitem = New ListViewItem(Arr(0))
        listitem.SubItems.Add(Arr(1))
        listitem.SubItems.Add(Arr(2))
        listitem.SubItems.Add(Arr(3))
        listitem.SubItems.Add(Arr(4))
        listitem.SubItems.Add(Arr(5))
        TextBox1.Text = 100
        TextBox1.Text = TextBox1.Text + 1
        TextBox2.Text = ""
        TextBox2.Focus()
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        ComboBox4.Text = ""


        ListView1.Items.Add(listitem)
    End Sub
End Class
