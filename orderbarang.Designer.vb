<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class orderbarang
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
        Checkbox1 = New CheckBox()
        TextBox1 = New TextBox()
        Button1 = New Button()
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        Label2 = New Label()
        txtmakan = New Label()
        txtminum = New Label()
        GroupBox1 = New GroupBox()
        label = New Label()
        total = New Label()
        TextBox2 = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        minum = New Label()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(419, 72)
        Label1.Name = "Label1"
        Label1.Size = New Size(39, 15)
        Label1.TabIndex = 0
        Label1.Text = "Harga"
        ' 
        ' Checkbox1
        ' 
        Checkbox1.AutoSize = True
        Checkbox1.Location = New Point(32, 114)
        Checkbox1.Name = "Checkbox1"
        Checkbox1.Size = New Size(204, 19)
        Checkbox1.TabIndex = 1
        Checkbox1.Text = "Termasuk Pesanan Minuman juga"
        Checkbox1.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(340, 39)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(187, 23)
        TextBox1.TabIndex = 2
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(46, 126)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 3
        Button1.Text = "Hitung"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(32, 64)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(257, 23)
        ComboBox1.TabIndex = 4
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(32, 167)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(257, 23)
        ComboBox2.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(419, 175)
        Label2.Name = "Label2"
        Label2.Size = New Size(39, 15)
        Label2.TabIndex = 6
        Label2.Text = "Harga"
        ' 
        ' txtmakan
        ' 
        txtmakan.AutoSize = True
        txtmakan.Location = New Point(577, 72)
        txtmakan.Name = "txtmakan"
        txtmakan.Size = New Size(13, 15)
        txtmakan.TabIndex = 7
        txtmakan.Text = "0"
        ' 
        ' txtminum
        ' 
        txtminum.AutoSize = True
        txtminum.Location = New Point(577, 167)
        txtminum.Name = "txtminum"
        txtminum.Size = New Size(0, 15)
        txtminum.TabIndex = 8
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(label)
        GroupBox1.Controls.Add(total)
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Location = New Point(32, 253)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(691, 168)
        GroupBox1.TabIndex = 9
        GroupBox1.TabStop = False
        GroupBox1.Text = "Nama pesananan"
        ' 
        ' label
        ' 
        label.AutoSize = True
        label.Location = New Point(405, 130)
        label.Name = "label"
        label.Size = New Size(13, 15)
        label.TabIndex = 14
        label.Text = "L"
        ' 
        ' total
        ' 
        total.AutoSize = True
        total.Location = New Point(406, 134)
        total.Name = "total"
        total.Size = New Size(0, 15)
        total.TabIndex = 13
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(340, 91)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(187, 23)
        TextBox2.TabIndex = 12
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(22, 94)
        Label6.Name = "Label6"
        Label6.Size = New Size(129, 15)
        Label6.TabIndex = 11
        Label6.Text = "Jumlah Porsi Minuman"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(22, 47)
        Label5.Name = "Label5"
        Label5.Size = New Size(126, 15)
        Label5.TabIndex = 10
        Label5.Text = "Jumlah Porsi Makanan"
        ' 
        ' minum
        ' 
        minum.AutoSize = True
        minum.Location = New Point(583, 175)
        minum.Name = "minum"
        minum.Size = New Size(13, 15)
        minum.TabIndex = 10
        minum.Text = "0"
        ' 
        ' orderbarang
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(minum)
        Controls.Add(txtminum)
        Controls.Add(txtmakan)
        Controls.Add(Label2)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox1)
        Controls.Add(Checkbox1)
        Controls.Add(Label1)
        Controls.Add(GroupBox1)
        Name = "orderbarang"
        Text = "orderbarang"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Checkbox1 As CheckBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtmakan As Label
    Friend WithEvents txtminum As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents minum As Label
    Friend WithEvents total As Label
    Friend WithEvents label As Label
End Class
