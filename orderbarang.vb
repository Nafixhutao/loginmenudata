Public Class orderbarang

    Dim hargamakanan As Integer
    Dim hargaminuman As Integer

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.Text
            Case “Nasi Goreng”
                txtmakan.Text = "Rp15000"
                hargamakanan = 15000
            Case “ayam goreng”
                txtmakan.Text = "Rp25000"
                hargamakanan = 25000
            Case “rames”
                txtmakan.Text = "Rp10000"
                hargamakanan = 10000
        End Select
    End Sub

    Private Sub orderbarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Nasi Goreng")
        ComboBox1.Items.Add("ayam goreng")
        ComboBox1.Items.Add("rames")
        ComboBox2.Items.Add("Air minum")
        ComboBox2.Items.Add("coca cola")
        ComboBox2.Items.Add("teajus")
    End Sub
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Select Case ComboBox2.Text
            Case “Air minum”
                minum.Text = "Rp 15000"
                hargaminuman = 15000
            Case “coca cola”
                minum.Text = "Rp 5000"
                hargaminuman = 5000
            Case “teajus”
                minum.Text = "Rp 5000"
                hargaminuman = 5000
        End Select

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim porsimakan, porsiminum, jumlah As Integer
        Dim pajak As Decimal
        porsimakan = TextBox1.Text
        porsiminum = TextBox2.Text
        jumlah = (porsimakan * hargamakanan) + (porsiminum * hargaminuman)
        pajak = jumlah * 0.15
        jumlah += pajak
        label.Text = "Rp " & jumlah.ToString()
    End Sub

End Class