Public Class Kalkulator
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim Angka1, Angka2, Angka3, hasil1 As Double
        Angka1 = Val(TextBox1.Text)
        Angka2 = Val(TextBox2.Text)
        Angka3 = Val(TextBox3.Text)
        hasil1 = Angka1 + Angka2 + Angka3
        TextBox4.Text = hasil1

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim Angka1, Angka2, Angka3, hasil1 As Double
        Angka1 = Val(TextBox1.Text)
        Angka2 = Val(TextBox2.Text)
        Angka3 = Val(TextBox3.Text)
        hasil1 = Angka1 - Angka2 - Angka3
        TextBox4.Text = hasil1

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim Angka1, Angka2, Angka3, hasil1 As Double
        Angka1 = Val(TextBox1.Text)
        Angka2 = Val(TextBox2.Text)
        Angka3 = Val(TextBox3.Text)
        hasil1 = Angka1 * Angka2 * Angka3
        TextBox4.Text = hasil1

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Dim Angka1, Angka2, Angka3, hasil1 As Double
        Angka1 = Val(TextBox1.Text)
        Angka2 = Val(TextBox2.Text)
        Angka3 = Val(TextBox3.Text)
        hasil1 = Angka1 / Angka2 / Angka3
        TextBox4.Text = hasil1

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()

    End Sub
End Class