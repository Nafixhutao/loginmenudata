<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Arrayganda
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
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        Label7 = New Label()
        ListView1 = New ListView()
        ComboBox3 = New ComboBox()
        Label8 = New Label()
        ComboBox4 = New ComboBox()
        Label9 = New Label()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(493, 243)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 45)
        Button1.TabIndex = 13
        Button1.Text = "Tambah"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(114, 65)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(203, 23)
        TextBox2.TabIndex = 11
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(114, 15)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(203, 23)
        TextBox1.TabIndex = 10
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(-93, 253)
        Label3.Name = "Label3"
        Label3.Size = New Size(60, 15)
        Label3.TabIndex = 9
        Label3.Text = "FALKUTAS"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(-93, 176)
        Label2.Name = "Label2"
        Label2.Size = New Size(39, 15)
        Label2.TabIndex = 8
        Label2.Text = "Nama"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(-93, 116)
        Label1.Name = "Label1"
        Label1.Size = New Size(30, 15)
        Label1.TabIndex = 7
        Label1.Text = "Nim"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 23)
        Label4.Name = "Label4"
        Label4.Size = New Size(30, 15)
        Label4.TabIndex = 14
        Label4.Text = "Nim"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 73)
        Label5.Name = "Label5"
        Label5.Size = New Size(39, 15)
        Label5.TabIndex = 15
        Label5.Text = "Nama"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(12, 116)
        Label6.Name = "Label6"
        Label6.Size = New Size(78, 15)
        Label6.TabIndex = 16
        Label6.Text = "Jenis Kelamin"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(114, 108)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(203, 23)
        ComboBox1.TabIndex = 17
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(114, 157)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(203, 23)
        ComboBox2.TabIndex = 18
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(12, 165)
        Label7.Name = "Label7"
        Label7.Size = New Size(50, 15)
        Label7.TabIndex = 19
        Label7.Text = "Falkutas"
        ' 
        ' ListView1
        ' 
        ListView1.Location = New Point(12, 312)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(571, 126)
        ListView1.TabIndex = 20
        ListView1.UseCompatibleStateImageBehavior = False
        ' 
        ' ComboBox3
        ' 
        ComboBox3.FormattingEnabled = True
        ComboBox3.Location = New Point(114, 214)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(203, 23)
        ComboBox3.TabIndex = 22
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(16, 217)
        Label8.Name = "Label8"
        Label8.Size = New Size(35, 15)
        Label8.TabIndex = 21
        Label8.Text = "Prodi"
        ' 
        ' ComboBox4
        ' 
        ComboBox4.FormattingEnabled = True
        ComboBox4.Location = New Point(114, 265)
        ComboBox4.Name = "ComboBox4"
        ComboBox4.Size = New Size(203, 23)
        ComboBox4.TabIndex = 23
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(16, 273)
        Label9.Name = "Label9"
        Label9.Size = New Size(50, 15)
        Label9.TabIndex = 24
        Label9.Text = "Semeter"
        ' 
        ' Arrayganda
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(595, 450)
        Controls.Add(Label9)
        Controls.Add(ComboBox4)
        Controls.Add(ComboBox3)
        Controls.Add(Label8)
        Controls.Add(ListView1)
        Controls.Add(Label7)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox1)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Button1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Arrayganda"
        Text = "Arrayganda"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents Label9 As Label
End Class
