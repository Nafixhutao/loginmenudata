<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Databuku
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
        kodebukutxt = New TextBox()
        KodeBuKu = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        judultxt = New TextBox()
        pengarangtxt = New TextBox()
        pernebittxt = New TextBox()
        jumlahbkutxt = New TextBox()
        cbljenisbkutxt = New ComboBox()
        Label6 = New Label()
        dkstxt = New TextBox()
        Label7 = New Label()
        hargatxt = New TextBox()
        BtnSimpan = New Button()
        btnubah = New Button()
        btnhapus = New Button()
        btnclear = New Button()
        Btnbatal = New Button()
        DataGridView1 = New DataGridView()
        TextBox1 = New TextBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' kodebukutxt
        ' 
        kodebukutxt.Location = New Point(112, 65)
        kodebukutxt.Name = "kodebukutxt"
        kodebukutxt.Size = New Size(100, 23)
        kodebukutxt.TabIndex = 0
        ' 
        ' KodeBuKu
        ' 
        KodeBuKu.AutoSize = True
        KodeBuKu.Location = New Point(25, 68)
        KodeBuKu.Name = "KodeBuKu"
        KodeBuKu.Size = New Size(64, 15)
        KodeBuKu.TabIndex = 1
        KodeBuKu.Text = "Kode Buku"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(266, 65)
        Label2.Name = "Label2"
        Label2.Size = New Size(62, 15)
        Label2.TabIndex = 2
        Label2.Text = "Jenis Buku"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(25, 112)
        Label1.Name = "Label1"
        Label1.Size = New Size(35, 15)
        Label1.TabIndex = 3
        Label1.Text = "Judul"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(25, 154)
        Label3.Name = "Label3"
        Label3.Size = New Size(64, 15)
        Label3.TabIndex = 4
        Label3.Text = "Pengarang"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(25, 202)
        Label4.Name = "Label4"
        Label4.Size = New Size(51, 15)
        Label4.TabIndex = 5
        Label4.Text = "Penerbit"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(25, 254)
        Label5.Name = "Label5"
        Label5.Size = New Size(75, 15)
        Label5.TabIndex = 6
        Label5.Text = "Jumlah Buku"
        ' 
        ' judultxt
        ' 
        judultxt.Location = New Point(112, 112)
        judultxt.Name = "judultxt"
        judultxt.Size = New Size(495, 23)
        judultxt.TabIndex = 7
        ' 
        ' pengarangtxt
        ' 
        pengarangtxt.Location = New Point(112, 154)
        pengarangtxt.Name = "pengarangtxt"
        pengarangtxt.Size = New Size(180, 23)
        pengarangtxt.TabIndex = 8
        ' 
        ' pernebittxt
        ' 
        pernebittxt.Location = New Point(112, 202)
        pernebittxt.Name = "pernebittxt"
        pernebittxt.Size = New Size(180, 23)
        pernebittxt.TabIndex = 9
        ' 
        ' jumlahbkutxt
        ' 
        jumlahbkutxt.Location = New Point(112, 246)
        jumlahbkutxt.Name = "jumlahbkutxt"
        jumlahbkutxt.Size = New Size(180, 23)
        jumlahbkutxt.TabIndex = 10
        ' 
        ' cbljenisbkutxt
        ' 
        cbljenisbkutxt.FormattingEnabled = True
        cbljenisbkutxt.Location = New Point(349, 62)
        cbljenisbkutxt.Name = "cbljenisbkutxt"
        cbljenisbkutxt.Size = New Size(113, 23)
        cbljenisbkutxt.TabIndex = 11
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(349, 172)
        Label6.Name = "Label6"
        Label6.Size = New Size(49, 15)
        Label6.TabIndex = 12
        Label6.Text = "Dekripsi"
        ' 
        ' dkstxt
        ' 
        dkstxt.Location = New Point(349, 190)
        dkstxt.Name = "dkstxt"
        dkstxt.Size = New Size(258, 23)
        dkstxt.TabIndex = 13
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(349, 249)
        Label7.Name = "Label7"
        Label7.Size = New Size(39, 15)
        Label7.TabIndex = 14
        Label7.Text = "Harga"
        ' 
        ' hargatxt
        ' 
        hargatxt.Location = New Point(394, 246)
        hargatxt.Name = "hargatxt"
        hargatxt.Size = New Size(159, 23)
        hargatxt.TabIndex = 15
        ' 
        ' BtnSimpan
        ' 
        BtnSimpan.Location = New Point(37, 349)
        BtnSimpan.Name = "BtnSimpan"
        BtnSimpan.Size = New Size(75, 37)
        BtnSimpan.TabIndex = 16
        BtnSimpan.Text = "Simpan"
        BtnSimpan.UseVisualStyleBackColor = True
        ' 
        ' btnubah
        ' 
        btnubah.Location = New Point(118, 349)
        btnubah.Name = "btnubah"
        btnubah.Size = New Size(75, 37)
        btnubah.TabIndex = 17
        btnubah.Text = "Ubah"
        btnubah.UseVisualStyleBackColor = True
        ' 
        ' btnhapus
        ' 
        btnhapus.Location = New Point(199, 349)
        btnhapus.Name = "btnhapus"
        btnhapus.Size = New Size(75, 37)
        btnhapus.TabIndex = 18
        btnhapus.Text = "Hapus"
        btnhapus.UseVisualStyleBackColor = True
        ' 
        ' btnclear
        ' 
        btnclear.Location = New Point(280, 349)
        btnclear.Name = "btnclear"
        btnclear.Size = New Size(75, 37)
        btnclear.TabIndex = 19
        btnclear.Text = "Clear"
        btnclear.UseVisualStyleBackColor = True
        ' 
        ' Btnbatal
        ' 
        Btnbatal.Location = New Point(371, 349)
        Btnbatal.Name = "Btnbatal"
        Btnbatal.Size = New Size(75, 37)
        Btnbatal.TabIndex = 20
        Btnbatal.Text = "Batal"
        Btnbatal.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(25, 409)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(927, 253)
        DataGridView1.TabIndex = 21
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(497, 65)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(193, 23)
        TextBox1.TabIndex = 22
        ' 
        ' Databuku
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(964, 715)
        Controls.Add(TextBox1)
        Controls.Add(DataGridView1)
        Controls.Add(Btnbatal)
        Controls.Add(btnclear)
        Controls.Add(btnhapus)
        Controls.Add(btnubah)
        Controls.Add(BtnSimpan)
        Controls.Add(hargatxt)
        Controls.Add(Label7)
        Controls.Add(dkstxt)
        Controls.Add(Label6)
        Controls.Add(cbljenisbkutxt)
        Controls.Add(jumlahbkutxt)
        Controls.Add(pernebittxt)
        Controls.Add(pengarangtxt)
        Controls.Add(judultxt)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Controls.Add(KodeBuKu)
        Controls.Add(kodebukutxt)
        Name = "Databuku"
        Text = "Databuku"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents kodebukutxt As TextBox
    Friend WithEvents KodeBuKu As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents judultxt As TextBox
    Friend WithEvents pengarangtxt As TextBox
    Friend WithEvents pernebittxt As TextBox
    Friend WithEvents jumlahbkutxt As TextBox
    Friend WithEvents cbljenisbkutxt As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents dkstxt As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents hargatxt As TextBox
    Friend WithEvents BtnSimpan As Button
    Friend WithEvents btnubah As Button
    Friend WithEvents btnhapus As Button
    Friend WithEvents btnclear As Button
    Friend WithEvents Btnbatal As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox1 As TextBox
End Class
