Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class gajiprosedur
    Public gajioperator, gajioficeboy, gajistaff, gajisupervisor, gajimananger As Integer
    Private dtGaji As DataTable

    Private Sub Prosedur_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNIp.Text = 1001
        TxtNama.Focus()

        ' Populate the job titles in ComboBox
        For i = 1 To 4
            Select Case i
                Case 1
                    cbljabatan.Items.Add("Operator")
                Case 2
                    cbljabatan.Items.Add("Office Boy")
                Case 3
                    cbljabatan.Items.Add("Staff")
                Case 4
                    cbljabatan.Items.Add("Supervisor")
            End Select
        Next i

        ' Initialize DataTable and DataGridView
        InitializeDataTable()
        DataGridView1.DataSource = dtGaji
    End Sub


    Private Sub InitializeDataTable()
        dtGaji = New DataTable()
        dtGaji.Columns.Add("NIP", GetType(String))
        dtGaji.Columns.Add("Name", GetType(String))
        dtGaji.Columns.Add("Jabatan", GetType(String))
        dtGaji.Columns.Add("Gaji Kotor", GetType(String))
        dtGaji.Columns.Add("Potongan (pph 2%)", GetType(String))
        dtGaji.Columns.Add("Gaji Bersih", GetType(String))
    End Sub





    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Clear input fields
        txtNIp.Text = ""
        TxtNama.Text = ""
        cbljabatan.Text = ""
        Txtgaji.Text = ""
        TxtGajiBersih.Text = ""
        TextBox1.Text = ""
    End Sub

    Private Sub cbljabatan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbljabatan.SelectedIndexChanged
        ' Display base salary for selected job title
        Select Case cbljabatan.Text
            Case "Operator"
                Txtgaji.Text = "Rp. 3.500.000"
                gajioperator = 3500000
            Case "Office Boy"
                Txtgaji.Text = "Rp. 2.500.000"
                gajioficeboy = 2500000
            Case "Staff"
                Txtgaji.Text = "Rp. 4.000.000"
                gajistaff = 4000000
            Case "Supervisor"
                Txtgaji.Text = "Rp. 5.000.000"
                gajisupervisor = 5000000
        End Select
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Btnclear.Click
        Dim tutup As String
        tutup = MessageBox.Show("Yakin mau keluar", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If tutup = MsgBoxResult.Yes Then
            End
        Else
            Exit Sub
        End If
    End Sub

    Private Sub hitungGaji_Click(sender As Object, e As EventArgs) Handles hitungGaji.Click
        Dim gaji = 0
        Dim gajiBersih = 0
        Dim potongan As Double = 0
        Dim Nip = txtNIp.Text
        Dim nama = TxtNama.Text

        If String.IsNullOrWhiteSpace(Nip) OrElse String.IsNullOrWhiteSpace(nama) Then
            MessageBox.Show("Nama dan NIP harus diisi!")
            Return
        End If

        ' Determine salary based on selected position
        Select Case cbljabatan.Text
            Case "Operator"
                gaji = 3500000
            Case "Office Boy"
                gaji = 2500000
            Case "Staff"
                gaji = 4000000
            Case "Supervisor"
                gaji = 5000000
            Case Else
                Return
        End Select

        ' Calculate deductions and net salary
        potongan = gaji * 0.02
        gajiBersih = gaji - potongan

        ' Display calculated amounts
        Txtgaji.Text = "Rp. " & gaji.ToString
        TextBox1.Text = "Rp. " & potongan.ToString
        TxtGajiBersih.Text = "Rp. " & gajiBersih.ToString

        ' Add entry to DataTable
        dtGaji.Rows.Add(Nip, nama, cbljabatan.Text, "Rp. " & gaji.ToString, "Rp. " & potongan.ToString, "Rp. " & gajiBersih.ToString)
    End Sub
End Class
