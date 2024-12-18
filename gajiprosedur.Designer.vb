<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class gajiprosedur
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        txtNIp = New TextBox()
        TxtNama = New TextBox()
        Txtgaji = New TextBox()
        TxtGajiBersih = New TextBox()
        cbljabatan = New ComboBox()
        hitungGaji = New Button()
        Button2 = New Button()
        Btnclear = New Button()
        TextBox1 = New TextBox()
        Label7 = New Label()
        Button4 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        DataGridView1 = New DataGridView()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(44, 46)
        Label1.Name = "Label1"
        Label1.Size = New Size(26, 15)
        Label1.TabIndex = 0
        Label1.Text = "Nip"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(44, 83)
        Label2.Name = "Label2"
        Label2.Size = New Size(39, 15)
        Label2.TabIndex = 1
        Label2.Text = "Nama"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(44, 118)
        Label3.Name = "Label3"
        Label3.Size = New Size(47, 15)
        Label3.TabIndex = 2
        Label3.Text = "Jabatan"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(-288, 215)
        Label4.Name = "Label4"
        Label4.Size = New Size(41, 15)
        Label4.TabIndex = 3
        Label4.Text = "Label4"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(44, 145)
        Label5.Name = "Label5"
        Label5.Size = New Size(59, 15)
        Label5.TabIndex = 4
        Label5.Text = "Gaji Kotor"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(44, 212)
        Label6.Name = "Label6"
        Label6.Size = New Size(62, 15)
        Label6.TabIndex = 5
        Label6.Text = "Gaji bersih"
        ' 
        ' txtNIp
        ' 
        txtNIp.Location = New Point(216, 46)
        txtNIp.Name = "txtNIp"
        txtNIp.Size = New Size(205, 23)
        txtNIp.TabIndex = 6
        ' 
        ' TxtNama
        ' 
        TxtNama.Location = New Point(216, 75)
        TxtNama.Name = "TxtNama"
        TxtNama.Size = New Size(357, 23)
        TxtNama.TabIndex = 7
        ' 
        ' Txtgaji
        ' 
        Txtgaji.Location = New Point(216, 147)
        Txtgaji.Name = "Txtgaji"
        Txtgaji.Size = New Size(218, 23)
        Txtgaji.TabIndex = 9
        ' 
        ' TxtGajiBersih
        ' 
        TxtGajiBersih.Location = New Point(216, 212)
        TxtGajiBersih.Name = "TxtGajiBersih"
        TxtGajiBersih.Size = New Size(218, 23)
        TxtGajiBersih.TabIndex = 10
        ' 
        ' cbljabatan
        ' 
        cbljabatan.FormattingEnabled = True
        cbljabatan.Location = New Point(216, 118)
        cbljabatan.Name = "cbljabatan"
        cbljabatan.Size = New Size(357, 23)
        cbljabatan.TabIndex = 11
        ' 
        ' hitungGaji
        ' 
        hitungGaji.Location = New Point(467, 163)
        hitungGaji.Name = "hitungGaji"
        hitungGaji.Size = New Size(88, 72)
        hitungGaji.TabIndex = 12
        hitungGaji.Text = "Proses Gaji"
        hitungGaji.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(240, 305)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 38)
        Button2.TabIndex = 13
        Button2.Text = "Hapus"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Btnclear
        ' 
        Btnclear.Location = New Point(346, 305)
        Btnclear.Name = "Btnclear"
        Btnclear.Size = New Size(75, 38)
        Btnclear.TabIndex = 14
        Btnclear.Text = "Clear"
        Btnclear.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(216, 175)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(218, 23)
        TextBox1.TabIndex = 15
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(44, 183)
        Label7.Name = "Label7"
        Label7.Size = New Size(126, 15)
        Label7.TabIndex = 16
        Label7.Text = "POTONGAN (pph/ 2%)"
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(147, 305)
        Button4.Name = "Button4"
        Button4.Size = New Size(75, 38)
        Button4.TabIndex = 17
        Button4.Text = "Ubah"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(53, 305)
        Button5.Name = "Button5"
        Button5.Size = New Size(75, 38)
        Button5.TabIndex = 18
        Button5.Text = "Simpan"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(456, 305)
        Button6.Name = "Button6"
        Button6.Size = New Size(75, 38)
        Button6.TabIndex = 19
        Button6.Text = "Batal"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(28, 362)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(640, 150)
        DataGridView1.TabIndex = 20
        ' 
        ' gajiprosedur
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(705, 536)
        Controls.Add(DataGridView1)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Label7)
        Controls.Add(TextBox1)
        Controls.Add(Btnclear)
        Controls.Add(Button2)
        Controls.Add(hitungGaji)
        Controls.Add(cbljabatan)
        Controls.Add(TxtGajiBersih)
        Controls.Add(Txtgaji)
        Controls.Add(TxtNama)
        Controls.Add(txtNIp)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "gajiprosedur"
        Text = "Ubah"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNIp As TextBox
    Friend WithEvents TxtNama As TextBox
    Friend WithEvents Txtgaji As TextBox
    Friend WithEvents TxtGajiBersih As TextBox
    Friend WithEvents cbljabatan As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Btnclear As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents hitungGaji As Button
End Class
