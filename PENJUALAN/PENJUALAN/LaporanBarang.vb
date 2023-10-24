Public Class LaporanBarang

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CrystalReportViewer1.SelectionFormula = "{tbbarang.kodebarang}='" & TextBox1.Text & "'"
        CrystalReportViewer1.ReportSource = "D:\Belajar VB.Net\PENJUALAN\PENJUALAN\LaporanDataBarang.rpt"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MenuUtama.Show()
        Me.Hide()
    End Sub

    Private Sub LaporanBarang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub
End Class