Public Class hitunghargavb
    Private Sub hitunghargavb_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox4.Text = (Val(TextBox1.Text) + Val(TextBox2.Text) + Val(TextBox3.Text)).ToString()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""


    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class