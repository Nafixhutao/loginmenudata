<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class databarang
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
        TextBox1 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        TextBox2 = New TextBox()
        Label4 = New Label()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        DataGridView1 = New DataGridView()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(172, 54)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(260, 23)
        TextBox1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(35, 54)
        Label1.Name = "Label1"
        Label1.Size = New Size(76, 15)
        Label1.TabIndex = 1
        Label1.Text = "Kode_Barang"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(35, 109)
        Label2.Name = "Label2"
        Label2.Size = New Size(81, 15)
        Label2.TabIndex = 2
        Label2.Text = "Nama_Barang"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(35, 168)
        Label3.Name = "Label3"
        Label3.Size = New Size(39, 15)
        Label3.TabIndex = 3
        Label3.Text = "Harga"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(172, 109)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(260, 23)
        TextBox2.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(35, 225)
        Label4.Name = "Label4"
        Label4.Size = New Size(43, 15)
        Label4.TabIndex = 5
        Label4.Text = "Satuan"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(172, 168)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(196, 23)
        TextBox3.TabIndex = 6
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(172, 225)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(196, 23)
        TextBox4.TabIndex = 7
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(41, 287)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 37)
        Button1.TabIndex = 8
        Button1.Text = "Simpan"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(172, 287)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 37)
        Button2.TabIndex = 9
        Button2.Text = "Ubah"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(293, 287)
        Button3.Name = "Button3"
        Button3.Size = New Size(75, 37)
        Button3.TabIndex = 10
        Button3.Text = "Hapus"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(401, 287)
        Button4.Name = "Button4"
        Button4.Size = New Size(75, 37)
        Button4.TabIndex = 11
        Button4.Text = "Batal"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(35, 352)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(619, 208)
        DataGridView1.TabIndex = 12
        ' 
        ' databarang
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(745, 592)
        Controls.Add(DataGridView1)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(Label4)
        Controls.Add(TextBox2)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBox1)
        Name = "databarang"
        Text = "databarang"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
