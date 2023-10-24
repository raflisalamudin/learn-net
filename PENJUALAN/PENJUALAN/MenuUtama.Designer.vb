<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuUtama
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FILEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BantuanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MASTERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DataBarangToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.DataCustomerToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.TRANSAKSIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TransaksiPenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LAPORANToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LaporanDataBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LaporanDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LaporanPenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.USERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TambahUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LOGOUTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.KasirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SignUpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FILEToolStripMenuItem, Me.MASTERToolStripMenuItem, Me.TRANSAKSIToolStripMenuItem, Me.LAPORANToolStripMenuItem, Me.USERToolStripMenuItem, Me.KasirToolStripMenuItem, Me.LOGOUTToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(524, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FILEToolStripMenuItem
        '
        Me.FILEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BantuanToolStripMenuItem})
        Me.FILEToolStripMenuItem.Name = "FILEToolStripMenuItem"
        Me.FILEToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.FILEToolStripMenuItem.Text = "&FILE"
        '
        'BantuanToolStripMenuItem
        '
        Me.BantuanToolStripMenuItem.Name = "BantuanToolStripMenuItem"
        Me.BantuanToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.BantuanToolStripMenuItem.Text = "&Bantuan"
        '
        'MASTERToolStripMenuItem
        '
        Me.MASTERToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataBarangToolStripMenuItem1, Me.DataCustomerToolStripMenuItem1})
        Me.MASTERToolStripMenuItem.Name = "MASTERToolStripMenuItem"
        Me.MASTERToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.MASTERToolStripMenuItem.Text = "&MASTER"
        '
        'DataBarangToolStripMenuItem1
        '
        Me.DataBarangToolStripMenuItem1.Name = "DataBarangToolStripMenuItem1"
        Me.DataBarangToolStripMenuItem1.Size = New System.Drawing.Size(153, 22)
        Me.DataBarangToolStripMenuItem1.Text = "&Data Barang"
        '
        'DataCustomerToolStripMenuItem1
        '
        Me.DataCustomerToolStripMenuItem1.Name = "DataCustomerToolStripMenuItem1"
        Me.DataCustomerToolStripMenuItem1.Size = New System.Drawing.Size(153, 22)
        Me.DataCustomerToolStripMenuItem1.Text = "&Data Customer"
        '
        'TRANSAKSIToolStripMenuItem
        '
        Me.TRANSAKSIToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TransaksiPenjualanToolStripMenuItem})
        Me.TRANSAKSIToolStripMenuItem.Name = "TRANSAKSIToolStripMenuItem"
        Me.TRANSAKSIToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.TRANSAKSIToolStripMenuItem.Text = "&TRANSAKSI"
        '
        'TransaksiPenjualanToolStripMenuItem
        '
        Me.TransaksiPenjualanToolStripMenuItem.Name = "TransaksiPenjualanToolStripMenuItem"
        Me.TransaksiPenjualanToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.TransaksiPenjualanToolStripMenuItem.Text = "&Transaksi Penjualan"
        '
        'LAPORANToolStripMenuItem
        '
        Me.LAPORANToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LaporanDataBarangToolStripMenuItem, Me.LaporanDataToolStripMenuItem, Me.LaporanPenjualanToolStripMenuItem})
        Me.LAPORANToolStripMenuItem.Name = "LAPORANToolStripMenuItem"
        Me.LAPORANToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.LAPORANToolStripMenuItem.Text = "&LAPORAN"
        '
        'LaporanDataBarangToolStripMenuItem
        '
        Me.LaporanDataBarangToolStripMenuItem.Name = "LaporanDataBarangToolStripMenuItem"
        Me.LaporanDataBarangToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.LaporanDataBarangToolStripMenuItem.Text = "&Laporan Data Barang"
        '
        'LaporanDataToolStripMenuItem
        '
        Me.LaporanDataToolStripMenuItem.Name = "LaporanDataToolStripMenuItem"
        Me.LaporanDataToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.LaporanDataToolStripMenuItem.Text = "&Laporan Data Customer"
        '
        'LaporanPenjualanToolStripMenuItem
        '
        Me.LaporanPenjualanToolStripMenuItem.Name = "LaporanPenjualanToolStripMenuItem"
        Me.LaporanPenjualanToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.LaporanPenjualanToolStripMenuItem.Text = "&Laporan Penjualan"
        '
        'USERToolStripMenuItem
        '
        Me.USERToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TambahUserToolStripMenuItem})
        Me.USERToolStripMenuItem.Name = "USERToolStripMenuItem"
        Me.USERToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.USERToolStripMenuItem.Text = "&USER"
        '
        'TambahUserToolStripMenuItem
        '
        Me.TambahUserToolStripMenuItem.Name = "TambahUserToolStripMenuItem"
        Me.TambahUserToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.TambahUserToolStripMenuItem.Text = "&Info User"
        '
        'LOGOUTToolStripMenuItem
        '
        Me.LOGOUTToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KeluarToolStripMenuItem})
        Me.LOGOUTToolStripMenuItem.Name = "LOGOUTToolStripMenuItem"
        Me.LOGOUTToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.LOGOUTToolStripMenuItem.Text = "&EXIT"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.KeluarToolStripMenuItem.Text = "&Keluar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(144, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(90, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(322, 100)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "SELAMAT DATANG DI MENU UTAMA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SISTEM INFORMASI PENJUALAN" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PT. PERUBAHAN OFFICIA" & _
            "L" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "JL. HARAPAN KM 9999 - BENUA ASIA"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'KasirToolStripMenuItem
        '
        Me.KasirToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SignUpToolStripMenuItem, Me.LoginToolStripMenuItem})
        Me.KasirToolStripMenuItem.Name = "KasirToolStripMenuItem"
        Me.KasirToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.KasirToolStripMenuItem.Text = "&Kasir"
        '
        'SignUpToolStripMenuItem
        '
        Me.SignUpToolStripMenuItem.Name = "SignUpToolStripMenuItem"
        Me.SignUpToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SignUpToolStripMenuItem.Text = "&Sign Up"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LoginToolStripMenuItem.Text = "&Login"
        '
        'MenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 368)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MenuUtama"
        Me.Text = "Menu Utama"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FILEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BantuanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MASTERToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataBarangToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataCustomerToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TRANSAKSIToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransaksiPenjualanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LAPORANToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanDataBarangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanPenjualanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents USERToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TambahUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LOGOUTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents KasirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SignUpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
