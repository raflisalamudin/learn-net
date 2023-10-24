Public Class MenuUtama

    Private Sub MenuUtama_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Terkunci()
    End Sub
    Private Sub EXITToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EXITToolStripMenuItem.Click
        Me.Close()
    End Sub
    Sub Terkunci()
        LOGOUTToolStripMenuItem.Visible = False
        MASTERToolStripMenuItem.Visible = False
        TRANSAKSIToolStripMenuItem.Visible = False
        LAPORANToolStripMenuItem.Visible = False
        UTILITYToolStripMenuItem.Visible = False
    End Sub
    Private Sub LOGINToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOGINToolStripMenuItem.Click
        Login.ShowDialog()
    End Sub

    Private Sub USERToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles USERToolStripMenuItem.Click
        MasterUser.ShowDialog()
    End Sub

    Private Sub CUSTOMERToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CUSTOMERToolStripMenuItem.Click
        MasterCustomer.ShowDialog()
    End Sub
End Class
