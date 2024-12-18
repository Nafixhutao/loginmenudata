<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formteslogin
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
        Txtuser = New TextBox()
        Txtpassword = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        SuspendLayout()
        ' 
        ' Txtuser
        ' 
        Txtuser.Location = New Point(207, 97)
        Txtuser.Name = "Txtuser"
        Txtuser.Size = New Size(185, 23)
        Txtuser.TabIndex = 0
        ' 
        ' Txtpassword
        ' 
        Txtpassword.Location = New Point(207, 202)
        Txtpassword.Name = "Txtpassword"
        Txtpassword.Size = New Size(185, 23)
        Txtpassword.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(48, 95)
        Label1.Name = "Label1"
        Label1.Size = New Size(42, 21)
        Label1.TabIndex = 2
        Label1.Text = "User"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(48, 204)
        Label2.Name = "Label2"
        Label2.Size = New Size(76, 21)
        Label2.TabIndex = 3
        Label2.Text = "Password"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(72, 305)
        Button1.Name = "Button1"
        Button1.Size = New Size(137, 38)
        Button1.TabIndex = 4
        Button1.Text = "Login"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(292, 305)
        Button2.Name = "Button2"
        Button2.Size = New Size(155, 38)
        Button2.TabIndex = 5
        Button2.Text = "Batal"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(207, 362)
        Button3.Name = "Button3"
        Button3.Size = New Size(75, 23)
        Button3.TabIndex = 6
        Button3.Text = "Button3"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Formteslogin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(565, 450)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Txtpassword)
        Controls.Add(Txtuser)
        Name = "Formteslogin"
        Text = "Formteslogin"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Txtuser As TextBox
    Friend WithEvents Txtpassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
