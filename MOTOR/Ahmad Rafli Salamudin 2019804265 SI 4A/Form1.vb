Imports System.Data.OleDb

Public Class Form1
    Dim conn As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim cmd As OleDbCommand
    Dim rd As OleDbDataReader
    Dim str As String
    Sub Koneksi()
        str = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= D:\Belajar VB.Net\MOTOR\DATABASE.mdb"
        conn = New OleDbConnection(str)
        If conn.State = ConnectionState.Closed Then conn.Open()
    End Sub
    Sub Tampilgrid()
        da = New OleDbDataAdapter("select * from tbmotor", conn)
        ds = New DataSet
        da.Fill(ds, "tbmotor")
        DGV.DataSource = ds.Tables("tbmotor")
    End Sub
    Sub Tampildata()
        TextBox1.Text = rd.Item(1)
        ComboBox1.Text = rd.Item(2)
        TextBox2.Text = rd.Item(3)
        ComboBox2.Text = rd.Item(4)
    End Sub
    Sub TextMati()
        Me.TextBox1.Enabled = False
        Me.ComboBox1.Enabled = False
        Me.TextBox2.Enabled = False
        Me.ComboBox2.Enabled = False
    End Sub
    Sub TextHidup()
        Me.TextBox1.Enabled = True
        Me.ComboBox1.Enabled = True
        Me.TextBox2.Enabled = True
        Me.ComboBox2.Enabled = True
    End Sub
    Sub Kosong()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox1.Focus()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call Tampilgrid()
        Call TextMati()
        Me.BtnTambah.Enabled = True
        Me.BtnSimpan.Enabled = False
        Me.BtnPreview.Enabled = True
        Me.BtnKeluar.Enabled = True
    End Sub

    Private Sub BtnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTambah.Click
        Call Kosong()
        Call TextHidup()
        Me.TextBox1.Focus()
        Me.BtnTambah.Enabled = False
        Me.BtnSimpan.Enabled = True
        Me.BtnPreview.Enabled = True
        Me.BtnKeluar.Enabled = True
    End Sub

    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        If TextBox1.Text = "" Or ComboBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Data belum lengkap, pastikan semua form terisi")
            Exit Sub
        Else
            Call Koneksi()
            Dim simpan As String = "insert into tbmotor (kodemotor, merkmotor, warnamotor, harga) " & " values ('" & TextBox1.Text & "','" & ComboBox1.Text & "','" & ComboBox2.Text & "','" & TextBox2.Text & "')"
            cmd = New OleDbCommand(simpan, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data berhasil di Input", MsgBoxStyle.Information, "Information")
            Me.OleDbConnection1.Close()
            Call Tampilgrid()
            DGV.Refresh()
            Call Koneksi()
            Call Kosong()
            Call TextMati()
            Me.BtnTambah.Enabled = True
            Me.BtnSimpan.Enabled = False
            Me.BtnKeluar.Enabled = True
            Me.BtnPreview.Enabled = True
        End If
    End Sub

    Private Sub BtnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPreview.Click
        Laporan.Show()
    End Sub

    Private Sub BtnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnKeluar.Click
        Me.Close()
    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub
End Class
