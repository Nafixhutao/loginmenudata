Imports System.ComponentModel.DataAnnotations

Public Class perulanagan
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        ListBox1.ClearSelected()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer
        Dim teks As String
        Dim jumlah As String
        teks = TextBox1.Text
        jumlah = TextBox2.Text
        For i = 1 To jumlah
            ListBox1.Items.Add(teks)
        Next i
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim i As Integer

        Do While i <= 10
            ListBox1.Items.Add("Do while:i " & i)
            i = i + 1
        Loop
    End Sub
End Class