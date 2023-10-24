Partial Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtGajiPokok.Enabled = False
        txtTunjangan.Enabled = False
        txtPajak.Enabled = False
        txtGajiBersih.Enabled = False
        txtNik.Focus()
    End Sub

    Private Sub btnHitung_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnHitung.Click
        Try
            Dim dblGajiPokok, dblTunjangan, dblPajak As Double

            dblGajiPokok = 0
            dblPajak = 0


            If radioKontrak.Checked Then
                dblGajiPokok = 2500000
                dblTunjangan = 750000
            ElseIf radioTetap.Checked Then
                dblGajiPokok = 3250000
                dblTunjangan = 1000000
            End If

            txtGajiPokok.Text = dblGajiPokok
            txtTunjangan.Text = dblTunjangan
            txtPajak.Text = (dblGajiPokok + dblTunjangan) * (5 / 100)
            txtGajiBersih.Text = dblGajiPokok + dblTunjangan - dblPajak

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnClear_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtNik.Text = ""
        txtNama.Text = ""
        txtBagian.Text = ""
        txtJabatan.Text = ""
        radioKontrak.Checked = False
        radioTetap.Checked = False
        txtTunjangan.Text = ""
        txtGajiBersih.Text = ""
        txtGajiPokok.Text = ""
        txtPajak.Text = ""
    End Sub
End Class