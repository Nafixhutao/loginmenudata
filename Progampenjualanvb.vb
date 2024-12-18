Public Class Progampenjualanvb


    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim total_harga As Decimal
        Dim diskon As Decimal = 0
        Dim bonus As Decimal = TextBox9.Text
        If total_harga >= 50000 Then
            bonus = "sabun"
        End If
        TextBox9.Text = bonus


    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class