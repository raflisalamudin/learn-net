Public Class MenuUtama

    Private Sub MenuUtama_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DataBarangToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataBarangToolStripMenuItem1.Click
        Barang.Show()
        Me.Hide()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub TambahUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TambahUserToolStripMenuItem.Click
        DataUser.Show()
        Me.Hide()
    End Sub

    Private Sub DataCustomerToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataCustomerToolStripMenuItem1.Click
        DataCustomer.Show()
        Me.Hide()
    End Sub

    Private Sub LaporanDataBarangToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanDataBarangToolStripMenuItem.Click
        LaporanBarang.Show()
        Me.Hide()
    End Sub

    Private Sub TransaksiPenjualanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransaksiPenjualanToolStripMenuItem.Click
        Transaksi.Show()
        Me.Hide()
    End Sub

    Private Sub LaporanDataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanDataToolStripMenuItem.Click
        LaporanCustomer.Show()
    End Sub
End Class