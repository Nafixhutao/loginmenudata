<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sistemgajivb
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
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        Label4 = New Label()
        TextBox2 = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        TextBox1 = New TextBox()
        Label5 = New Label()
        TextBox5 = New TextBox()
        SuspendLayout()
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(180, 228)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(260, 23)
        TextBox4.TabIndex = 15
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(180, 171)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(260, 23)
        TextBox3.TabIndex = 14
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(43, 228)
        Label4.Name = "Label4"
        Label4.Size = New Size(59, 15)
        Label4.TabIndex = 13
        Label4.Text = "Gaji Kotor"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(180, 112)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(260, 23)
        TextBox2.TabIndex = 12
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(43, 171)
        Label3.Name = "Label3"
        Label3.Size = New Size(47, 15)
        Label3.TabIndex = 11
        Label3.Text = "Jabatan"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(43, 112)
        Label2.Name = "Label2"
        Label2.Size = New Size(39, 15)
        Label2.TabIndex = 10
        Label2.Text = "Nama"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(43, 57)
        Label1.Name = "Label1"
        Label1.Size = New Size(30, 15)
        Label1.TabIndex = 9
        Label1.Text = "Nim"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(180, 57)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(260, 23)
        TextBox1.TabIndex = 8
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(43, 277)
        Label5.Name = "Label5"
        Label5.Size = New Size(96, 15)
        Label5.TabIndex = 16
        Label5.Text = "POTONGAN PPH"
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(180, 274)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(260, 23)
        TextBox5.TabIndex = 17
        ' 
        ' sistemgajivb
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TextBox5)
        Controls.Add(Label5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(Label4)
        Controls.Add(TextBox2)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBox1)
        Name = "sistemgajivb"
        Text = "sistemgajivb"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox5 As TextBox
End Class
