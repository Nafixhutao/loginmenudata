Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Kalkulaotr2
    Dim nomer As Decimal
    Dim operasi As String
    Dim terakhir As String
    Dim hasil As Decimal
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles Layar.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Layar.Text = Layar.Text & "1"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Layar.Text = Layar.Text & "2"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Layar.Text = Layar.Text & "3"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Layar.Text = Layar.Text & "4"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Layar.Text = Layar.Text & "5"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Layar.Text = Layar.Text & "6"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Layar.Text = Layar.Text & "7"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Layar.Text = Layar.Text & "8"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Layar.Text = Layar.Text & "9"
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Layar.Text = Layar.Text & "0"
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Layar.Clear()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        nomer = Decimal.Parse(Layar.Text)
        operasi = "+ "
        terakhir = Layar.Text
        Layar.Text = terakhir & " " & operasi

    End Sub


    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click

        Dim angkaKedua As Decimal = Decimal.Parse(Layar.Text.Replace(terakhir & " " & operasi, ""))
        If operasi = "+ " Then
            Layar.Text = (nomer + angkaKedua).ToString()
        ElseIf operasi = "- " Then
            Layar.Text = (nomer - angkaKedua).ToString()
        ElseIf operasi = "* " Then
            Layar.Text = (nomer * angkaKedua).ToString()
        ElseIf operasi = "/ " Then
            Layar.Text = Decimal.Round(nomer / angkaKedua, 2).ToString()
        ElseIf operasi = "Mod " Then
            Layar.Text = (nomer Mod angkaKedua).ToString()
        ElseIf operasi = "^ " Then
            Layar.Text = (Math.Pow(nomer, angkaKedua)).ToString()
        End If
        operasi = Nothing
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        nomer = Decimal.Parse(Layar.Text)
        operasi = "* "
        terakhir = Layar.Text
        Layar.Text = terakhir & " " & operasi
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        nomer = Decimal.Parse(Layar.Text)
        operasi = "/ "
        terakhir = Layar.Text
        Layar.Text = terakhir & " " & operasi
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        nomer = Decimal.Parse(Layar.Text)
        hasil = Math.Sqrt(nomer)
        Layar.Text = "√" & nomer.ToString() & " = " & hasil.ToString()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        nomer = Decimal.Parse(Layar.Text)
        operasi = "Mod "
        terakhir = Layar.Text
        Layar.Text &= " " & operasi
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        nomer = Decimal.Parse(Layar.Text)
        operasi = "^ "
        terakhir = Layar.Text
        Layar.Text &= " " & operasi
    End Sub

    Private Sub Kalkulaotr2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class