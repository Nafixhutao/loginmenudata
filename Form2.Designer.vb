<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Fmenu = New MenuStrip()
        MasterDataToolStripMenuItem = New ToolStripMenuItem()
        DataJenisBukuToolStripMenuItem = New ToolStripMenuItem()
        DataBukuToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem1 = New ToolStripMenuItem()
        TransaksiToolStripMenuItem = New ToolStripMenuItem()
        PeminjamanBukuToolStripMenuItem = New ToolStripMenuItem()
        MonitoringPeminjamanToolStripMenuItem = New ToolStripMenuItem()
        LaporanToolStripMenuItem = New ToolStripMenuItem()
        PengaturanToolStripMenuItem = New ToolStripMenuItem()
        KeluarToolStripMenuItem = New ToolStripMenuItem()
        ToolStrip1 = New ToolStrip()
        ToolStripStatusLabel1 = New ToolStripLabel()
        ToolStripStatusLabel2 = New ToolStripLabel()
        ToolStripStatusLabel3 = New ToolStripLabel()
        ToolStrip2 = New ToolStrip()
        DataGridView1 = New DataGridView()
        Fmenu.SuspendLayout()
        ToolStrip1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Fmenu
        ' 
        Fmenu.Items.AddRange(New ToolStripItem() {MasterDataToolStripMenuItem, TransaksiToolStripMenuItem, LaporanToolStripMenuItem, PengaturanToolStripMenuItem, KeluarToolStripMenuItem})
        Fmenu.Location = New Point(0, 0)
        Fmenu.Name = "Fmenu"
        Fmenu.Size = New Size(800, 24)
        Fmenu.TabIndex = 1
        ' 
        ' MasterDataToolStripMenuItem
        ' 
        MasterDataToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {DataJenisBukuToolStripMenuItem, DataBukuToolStripMenuItem, ToolStripMenuItem1})
        MasterDataToolStripMenuItem.Name = "MasterDataToolStripMenuItem"
        MasterDataToolStripMenuItem.Size = New Size(82, 20)
        MasterDataToolStripMenuItem.Text = "Master Data"
        ' 
        ' DataJenisBukuToolStripMenuItem
        ' 
        DataJenisBukuToolStripMenuItem.Name = "DataJenisBukuToolStripMenuItem"
        DataJenisBukuToolStripMenuItem.Size = New Size(156, 22)
        DataJenisBukuToolStripMenuItem.Text = "Data Jenis Buku"
        ' 
        ' DataBukuToolStripMenuItem
        ' 
        DataBukuToolStripMenuItem.Name = "DataBukuToolStripMenuItem"
        DataBukuToolStripMenuItem.Size = New Size(156, 22)
        DataBukuToolStripMenuItem.Text = "Data Buku"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(156, 22)
        ' 
        ' TransaksiToolStripMenuItem
        ' 
        TransaksiToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {PeminjamanBukuToolStripMenuItem, MonitoringPeminjamanToolStripMenuItem})
        TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        TransaksiToolStripMenuItem.Size = New Size(66, 20)
        TransaksiToolStripMenuItem.Text = "Transaksi"
        ' 
        ' PeminjamanBukuToolStripMenuItem
        ' 
        PeminjamanBukuToolStripMenuItem.Name = "PeminjamanBukuToolStripMenuItem"
        PeminjamanBukuToolStripMenuItem.Size = New Size(204, 22)
        PeminjamanBukuToolStripMenuItem.Text = "Peminjaman Buku"
        ' 
        ' MonitoringPeminjamanToolStripMenuItem
        ' 
        MonitoringPeminjamanToolStripMenuItem.Name = "MonitoringPeminjamanToolStripMenuItem"
        MonitoringPeminjamanToolStripMenuItem.Size = New Size(204, 22)
        MonitoringPeminjamanToolStripMenuItem.Text = "Monitoring Peminjaman"
        ' 
        ' LaporanToolStripMenuItem
        ' 
        LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        LaporanToolStripMenuItem.Size = New Size(62, 20)
        LaporanToolStripMenuItem.Text = "Laporan"
        ' 
        ' PengaturanToolStripMenuItem
        ' 
        PengaturanToolStripMenuItem.Name = "PengaturanToolStripMenuItem"
        PengaturanToolStripMenuItem.Size = New Size(80, 20)
        PengaturanToolStripMenuItem.Text = "Pengaturan"
        ' 
        ' KeluarToolStripMenuItem
        ' 
        KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        KeluarToolStripMenuItem.Size = New Size(52, 20)
        KeluarToolStripMenuItem.Text = "Keluar"
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.Dock = DockStyle.Bottom
        ToolStrip1.Items.AddRange(New ToolStripItem() {ToolStripStatusLabel1, ToolStripStatusLabel2, ToolStripStatusLabel3})
        ToolStrip1.Location = New Point(0, 425)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(800, 25)
        ToolStrip1.TabIndex = 2
        ToolStrip1.Text = "ToolStrip1"
        ' 
        ' ToolStripStatusLabel1
        ' 
        ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        ToolStripStatusLabel1.Size = New Size(119, 22)
        ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        ' 
        ' ToolStripStatusLabel2
        ' 
        ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        ToolStripStatusLabel2.Size = New Size(119, 22)
        ToolStripStatusLabel2.Text = "ToolStripStatusLabel2"
        ' 
        ' ToolStripStatusLabel3
        ' 
        ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        ToolStripStatusLabel3.Size = New Size(119, 22)
        ToolStripStatusLabel3.Text = "ToolStripStatusLabel3"
        ' 
        ' ToolStrip2
        ' 
        ToolStrip2.Location = New Point(0, 24)
        ToolStrip2.Name = "ToolStrip2"
        ToolStrip2.Size = New Size(800, 25)
        ToolStrip2.TabIndex = 3
        ToolStrip2.Text = "ToolStrip2"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(39, 116)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(749, 291)
        DataGridView1.TabIndex = 4
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(DataGridView1)
        Controls.Add(ToolStrip2)
        Controls.Add(ToolStrip1)
        Controls.Add(Fmenu)
        MainMenuStrip = Fmenu
        Name = "Form2"
        Text = "Fmenu"
        Fmenu.ResumeLayout(False)
        Fmenu.PerformLayout()
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Fmenu As MenuStrip
    Friend WithEvents MasterDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataJenisBukuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataBukuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PengaturanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripLabel
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PeminjamanBukuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MonitoringPeminjamanToolStripMenuItem As ToolStripMenuItem
End Class
