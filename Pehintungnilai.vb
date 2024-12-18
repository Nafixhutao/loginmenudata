Public Class Pehintungnilai
    Dim nama As String
    Dim nilai As String
    Dim keterangan As String
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            Dim nilai As Integer
            Dim nama As String = TextBox1.Text
            If Integer.TryParse(TextBox2.Text, nilai) Then
                If nilai >= 85 Then
                    TextBox3.Text = nama & ", Lulus, Sangat Memuaskan"
                ElseIf nilai >= 70 Then
                    TextBox3.Text = nama & ", Lulus, Memuaskan"
                ElseIf nilai >= 60 Then
                    TextBox3.Text = nama & ", Lulus, Cukup Memuaskan"
                Else
                    TextBox3.Text = nama & ", Tidak Lulus, Silahkan Mengulang"
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Masukkan nilai yang valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Pehintungnilai_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class