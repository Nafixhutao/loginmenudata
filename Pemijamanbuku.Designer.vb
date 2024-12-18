<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pemijamanbuku
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
        Button1 = New Button()
        Label1 = New Label()
        TextBox1 = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        TextBox2 = New TextBox()
        Button2 = New Button()
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        ComboBox3 = New ComboBox()
        DateTimePicker1 = New DateTimePicker()
        DateTimePicker2 = New DateTimePicker()
        Button3 = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(133, 394)
        Button1.Name = "Button1"
        Button1.Size = New Size(93, 33)
        Button1.TabIndex = 0
        Button1.Text = "Simpan "
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(41, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(82, 15)
        Label1.TabIndex = 2
        Label1.Text = "Kode Pemakai"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(265, 197)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(272, 23)
        TextBox1.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(41, 97)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 15)
        Label2.TabIndex = 4
        Label2.Text = "Kode Buku"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(41, 151)
        Label3.Name = "Label3"
        Label3.Size = New Size(35, 15)
        Label3.TabIndex = 5
        Label3.Text = " Jenis"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(42, 200)
        Label4.Name = "Label4"
        Label4.Size = New Size(72, 15)
        Label4.TabIndex = 6
        Label4.Text = "Nama Buku " & vbCrLf
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(41, 277)
        Label5.Name = "Label5"
        Label5.Size = New Size(55, 15)
        Label5.TabIndex = 7
        Label5.Text = "Tgl Mulai"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(42, 320)
        Label7.Name = "Label7"
        Label7.Size = New Size(53, 15)
        Label7.TabIndex = 9
        Label7.Text = "Tgl Akhir"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(42, 239)
        Label8.Name = "Label8"
        Label8.Size = New Size(45, 15)
        Label8.TabIndex = 13
        Label8.Text = "Jumlah"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(266, 239)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(165, 23)
        TextBox2.TabIndex = 14
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(305, 394)
        Button2.Name = "Button2"
        Button2.Size = New Size(103, 33)
        Button2.TabIndex = 17
        Button2.Text = "Batal"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(265, 37)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(165, 23)
        ComboBox1.TabIndex = 18
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(265, 89)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(165, 23)
        ComboBox2.TabIndex = 19
        ' 
        ' ComboBox3
        ' 
        ComboBox3.FormattingEnabled = True
        ComboBox3.Location = New Point(266, 148)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(164, 23)
        ComboBox3.TabIndex = 20
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(265, 277)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(200, 23)
        DateTimePicker1.TabIndex = 21
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Location = New Point(265, 320)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(200, 23)
        DateTimePicker2.TabIndex = 22
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(444, 394)
        Button3.Name = "Button3"
        Button3.Size = New Size(93, 33)
        Button3.TabIndex = 23
        Button3.Text = "Denda"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Pemijamanbuku
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button3)
        Controls.Add(DateTimePicker2)
        Controls.Add(DateTimePicker1)
        Controls.Add(ComboBox3)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox1)
        Controls.Add(Button2)
        Controls.Add(TextBox2)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Name = "Pemijamanbuku"
        Text = "Pemijamanbuku"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Button3 As Button
End Class
