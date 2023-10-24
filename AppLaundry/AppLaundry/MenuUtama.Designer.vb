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
        Me.LOGINToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LOGOUTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.EXITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MASTERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.USERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CUSTOMERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TRANSAKSIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LAPORANToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UTILITYToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GANTIPASSWORDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PANDUANToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
        Me.ABOUTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FILEToolStripMenuItem, Me.MASTERToolStripMenuItem, Me.TRANSAKSIToolStripMenuItem, Me.LAPORANToolStripMenuItem, Me.UTILITYToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(769, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FILEToolStripMenuItem
        '
        Me.FILEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LOGINToolStripMenuItem, Me.LOGOUTToolStripMenuItem, Me.ToolStripMenuItem1, Me.EXITToolStripMenuItem})
        Me.FILEToolStripMenuItem.Name = "FILEToolStripMenuItem"
        Me.FILEToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.FILEToolStripMenuItem.Text = "FILE"
        '
        'LOGINToolStripMenuItem
        '
        Me.LOGINToolStripMenuItem.Name = "LOGINToolStripMenuItem"
        Me.LOGINToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.LOGINToolStripMenuItem.Text = "LOGIN"
        '
        'LOGOUTToolStripMenuItem
        '
        Me.LOGOUTToolStripMenuItem.Name = "LOGOUTToolStripMenuItem"
        Me.LOGOUTToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.LOGOUTToolStripMenuItem.Text = "LOGOUT"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(117, 6)
        '
        'EXITToolStripMenuItem
        '
        Me.EXITToolStripMenuItem.Name = "EXITToolStripMenuItem"
        Me.EXITToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.EXITToolStripMenuItem.Text = "EXIT"
        '
        'MASTERToolStripMenuItem
        '
        Me.MASTERToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.USERToolStripMenuItem, Me.CUSTOMERToolStripMenuItem})
        Me.MASTERToolStripMenuItem.Name = "MASTERToolStripMenuItem"
        Me.MASTERToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.MASTERToolStripMenuItem.Text = "MASTER"
        '
        'USERToolStripMenuItem
        '
        Me.USERToolStripMenuItem.Name = "USERToolStripMenuItem"
        Me.USERToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.USERToolStripMenuItem.Text = "USER"
        '
        'CUSTOMERToolStripMenuItem
        '
        Me.CUSTOMERToolStripMenuItem.Name = "CUSTOMERToolStripMenuItem"
        Me.CUSTOMERToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CUSTOMERToolStripMenuItem.Text = "CUSTOMER"
        '
        'TRANSAKSIToolStripMenuItem
        '
        Me.TRANSAKSIToolStripMenuItem.Name = "TRANSAKSIToolStripMenuItem"
        Me.TRANSAKSIToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.TRANSAKSIToolStripMenuItem.Text = "TRANSAKSI"
        '
        'LAPORANToolStripMenuItem
        '
        Me.LAPORANToolStripMenuItem.Name = "LAPORANToolStripMenuItem"
        Me.LAPORANToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.LAPORANToolStripMenuItem.Text = "LAPORAN"
        '
        'UTILITYToolStripMenuItem
        '
        Me.UTILITYToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GANTIPASSWORDToolStripMenuItem, Me.PANDUANToolStripMenuItem, Me.ToolStripMenuItem2, Me.ABOUTToolStripMenuItem})
        Me.UTILITYToolStripMenuItem.Name = "UTILITYToolStripMenuItem"
        Me.UTILITYToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.UTILITYToolStripMenuItem.Text = "UTILITY"
        '
        'GANTIPASSWORDToolStripMenuItem
        '
        Me.GANTIPASSWORDToolStripMenuItem.Name = "GANTIPASSWORDToolStripMenuItem"
        Me.GANTIPASSWORDToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.GANTIPASSWORDToolStripMenuItem.Text = "GANTI PASSWORD"
        '
        'PANDUANToolStripMenuItem
        '
        Me.PANDUANToolStripMenuItem.Name = "PANDUANToolStripMenuItem"
        Me.PANDUANToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.PANDUANToolStripMenuItem.Text = "PANDUAN"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(169, 6)
        '
        'ABOUTToolStripMenuItem
        '
        Me.ABOUTToolStripMenuItem.Name = "ABOUTToolStripMenuItem"
        Me.ABOUTToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.ABOUTToolStripMenuItem.Text = "ABOUT"
        '
        'MenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(769, 473)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MenuUtama"
        Me.Text = "Menu Utama Aplikasi Laundry Versi 1.0"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FILEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LOGINToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LOGOUTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EXITToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MASTERToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents USERToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TRANSAKSIToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LAPORANToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UTILITYToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GANTIPASSWORDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PANDUANToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ABOUTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CUSTOMERToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
