Imports System.Data.OleDb

Public Class Transaksi
    Dim conn As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim cmd As OleDbCommand
    Dim rd As OleDbDataReader
    Dim str As String
    Sub Koneksi()
        str = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= D:\Belajar VB.Net\PENJUALAN\DBPENJUALAN.mdb"
        conn = New OleDbConnection(str)
        If conn.State = ConnectionState.Closed Then conn.Open()
    End Sub

    Sub TextMati()
        Me.TextBox1.Enabled = False
        Me.TextBox2.Enabled = False
        Me.TextBox3.Enabled = False
        Me.TextBox4.Enabled = False
        Me.TextBox5.Enabled = False
        Me.TextBox6.Enabled = False
        Me.TextBox7.Enabled = False
        Me.TextBox8.Enabled = False
        Me.TextBox9.Enabled = False
        Me.TextBox10.Enabled = False
        Me.TextBox11.Enabled = False
    End Sub
    Sub TextHidup()
        Me.TextBox1.Enabled = True
        Me.TextBox2.Enabled = True
        Me.TextBox3.Enabled = True
        Me.TextBox4.Enabled = True
        Me.TextBox5.Enabled = True
        Me.TextBox6.Enabled = True
        Me.TextBox7.Enabled = True
        Me.TextBox8.Enabled = True
        Me.TextBox9.Enabled = True
        Me.TextBox10.Enabled = True
        Me.TextBox11.Enabled = True
    End Sub
    Sub Kosong()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
        TextBox10.Clear()
    End Sub
   
    Sub Tampilcustomer(ByVal kode As String)
        da = New OleDbDataAdapter("select * from tbcustomer where kodecustomer='" & kode & "'", conn)
        ds = New DataSet
        da.Fill(ds, "tbcustomer")
        If ds.Tables(0).Rows.Count > 0 Then
            For Each dsData As DataRow In ds.Tables(0).Rows
                TextBox3.Text = dsData("namacustomer")
                TextBox4.Text = dsData("telepon")
                TextBox5.Text = dsData("email")
                TextBox6.Text = dsData("alamat")
            Next
        End If
    End Sub
    Sub Tampilbarang(ByVal kode As String)
        da = New OleDbDataAdapter("select * from tbbarang where kodebarang='" & kode & "'", conn)
        ds = New DataSet
        da.Fill(ds, "tbbarang")
        If ds.Tables(0).Rows.Count > 0 Then
            For Each dsData As DataRow In ds.Tables(0).Rows
                TextBox8.Text = dsData("namabarang")
                TextBox9.Text = dsData("satuan")

            Next
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call Tampilcustomer(TextBox2.Text)
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Call Tampilbarang(TextBox7.Text)
    End Sub

    Sub Tampilgrid()
        da = New OleDbDataAdapter("select * from tbcustomer", conn)
        ds = New DataSet
        da.Fill(ds, "tbcustomer")

    End Sub

    Private Sub Transaksi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Koneksi()
        TextBox11.Text = Now.Date
        Call TextMati()
        Me.BtnAdd.Enabled = True
        Me.BtnSave.Enabled = False
        Me.BtnCancel.Enabled = False
        Me.BtnDelete.Enabled = False
        Me.BtnExit.Enabled = True
    End Sub

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        Call Kosong()
        Call TextHidup()
        Me.TextBox1.Focus()
        Me.BtnAdd.Enabled = False
        Me.BtnSave.Enabled = True
        Me.BtnCancel.Enabled = True
        Me.BtnDelete.Enabled = True
        Me.BtnExit.Enabled = True
    End Sub
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If TextBox1.Text = "" Then
            MsgBox("Data belum lengkap, Pastikan semua form terisi!!!")
            Exit Sub
        Else
            Call Koneksi()
            Dim simpan As String = "insert into tbtransaksi (kodetransaksi,kodecustomer,kodebarang,jumlahjual,tanggal) " & " values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox7.Text & "','" & TextBox10.Text & "','" & TextBox11.Text & "')"
            cmd = New OleDbCommand(simpan, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil Di Simpan", MsgBoxStyle.Information, "Information")
            Me.OleDbConnection1.Close()

            Call Koneksi()

            Me.TextBox1.Enabled = False
            Me.TextBox2.Enabled = False
            Me.TextBox3.Enabled = False
            Me.TextBox4.Enabled = False
            Me.TextBox5.Enabled = False
            Me.TextBox6.Enabled = False
            Me.TextBox11.Enabled = False
            TextBox7.Clear()
            TextBox8.Clear()
            TextBox9.Clear()
            TextBox10.Clear()
            Me.BtnAdd.Enabled = False

        End If
    End Sub
    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Call Kosong()
        Call TextMati()
        Me.BtnAdd.Enabled = True
    End Sub
    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        If TextBox1.Text = "" Then
            MsgBox("Kode belum diisi")
            TextBox1.Focus()
            Exit Sub
        Else
            If MessageBox.Show("Yakin akan dihapus..?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Dim hapus As String = "DELETE * FROM tbtransaksi where kodetransaksi='" & TextBox1.Text & "'"
                cmd = New OleDbCommand(hapus, conn)
                cmd.ExecuteNonQuery()

                Call Kosong()
                Me.BtnAdd.Enabled = True

            Else
                Call TextMati()
            End If
        End If
    End Sub
    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        MenuUtama.Show()
        Me.Close()
    End Sub
    Private Sub BtnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPreview.Click
        LaporanBarang.Show()
    End Sub


    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        TextBox1.MaxLength = 10
        If e.KeyChar = Chr(13) Then TextBox2.Focus()
    End Sub
    Private Sub TextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.LostFocus
        str = "SELECT * FROM tbtransaksi Where kodetransaksi = '" & TextBox1.Text & "'"
        cmd = New OleDbCommand(str, conn)
        rd = cmd.ExecuteReader
        Try
            While rd.Read
                TextBox2.Text = rd.GetString(1)
                TextBox7.Text = rd.GetString(2)
                TextBox10.Text = rd.GetValue(3)
                TextBox11.Text = rd.GetValue(4)
                TextBox2.Focus()
            End While
        Finally
            rd.Close()
        End Try
    End Sub
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        TextBox2.MaxLength = 10
        If e.KeyChar = Chr(13) Then TextBox7.Focus()
    End Sub
    Private Sub TextBox2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.LostFocus
        str = "SELECT * FROM tbcustomer Where kodecustomer = '" & TextBox2.Text & "'"
        cmd = New OleDbCommand(str, conn)
        rd = cmd.ExecuteReader
        Try
            While rd.Read
                TextBox3.Text = rd.GetString(1)
                TextBox4.Text = rd.GetString(2)
                TextBox5.Text = rd.GetValue(3)
                TextBox6.Text = rd.GetValue(4)
                TextBox7.Focus()
            End While
        Finally
            rd.Close()
        End Try
    End Sub
    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox7_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox7.KeyPress
        TextBox7.MaxLength = 10
        If e.KeyChar = Chr(13) Then TextBox10.Focus()
    End Sub
    Private Sub TextBox7_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox7.LostFocus
        str = "SELECT * FROM tbbarang Where kodebarang = '" & TextBox7.Text & "'"
        cmd = New OleDbCommand(str, conn)
        rd = cmd.ExecuteReader
        Try
            While rd.Read
                TextBox8.Text = rd.GetString(1)
                TextBox9.Text = rd.GetString(2)
                TextBox11.Focus()
            End While
        Finally
            rd.Close()
        End Try
    End Sub

    Private Sub ReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportViewer1.Load

    End Sub
End Class