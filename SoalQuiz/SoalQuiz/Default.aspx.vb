Partial Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtGajiPokok.Enabled = False
        txtTunjangan.Enabled = False
        txtPajak.Enabled = False
        txtGajiBersih.Enabled = False
        txtNik.Focus()
    End Sub

    Private Sub radioKontrak_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radioKontrak.CheckedChanged
        txtGajiPokok.Text = Format(2500000, "#,##0")
        txtTunjangan.Text = Format(750000, "#,##0")
        txtPajak.Text = Format(162500, "#,##0")
    End Sub

    Private Sub radioTetap_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radioTetap.CheckedChanged
        txtGajiPokok.Text = Format(3250000, "#,##0")
        txtTunjangan.Text = Format(1000000, "#,##0")
        txtPajak.Text = Format(212500, "#,##0")
    End Sub

    Private Sub btnHitung_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnHitung.Click
        Try
            Dim dblGajiPokok, dblTunjangan, dblPajak As Double

            dblGajiPokok = txtGajiPokok.Text
            dblTunjangan = txtTunjangan.Text
            dblPajak = txtPajak.Text

            If radioKontrak.Checked = True Then
                txtGajiBersih.Text = Format(dblGajiPokok + dblTunjangan - dblPajak, "#,##0.00")
            ElseIf radioTetap.Checked = True Then
                txtGajiBersih.Text = Format(dblGajiPokok + dblTunjangan - dblPajak, "#,##0.00")
            Else
                MsgBox("Silahkan pilih status karyawan terlebih dahulu")
            End If

        Catch ex As Exception
            MsgBox("Silahkan pilih status karyawan terlebih dahulu")

            txtGajiPokok.Text = 0
            txtTunjangan.Text = 0
            txtPajak.Text = 0
            txtGajiBersih.Text = 0
        End Try
    End Sub

    Private Sub btnClear_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtNik.Text = ""
        txtNama.Text = ""
        txtBagian.Text = ""
        txtJabatan.Text = ""
        radioKontrak.Checked = False
        radioTetap.Checked = False
        txtGajiPokok.Text = ""
        txtTunjangan.Text = ""
        txtPajak.Text = ""
        txtGajiBersih.Text = ""
    End Sub
End Class