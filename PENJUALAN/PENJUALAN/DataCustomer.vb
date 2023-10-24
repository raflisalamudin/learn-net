Imports System.Data.OleDb

Public Class DataCustomer
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
    Sub Tampilgrid()
        da = New OleDbDataAdapter("select * from tbcustomer", conn)
        ds = New DataSet
        da.Fill(ds, "tbcustomer")
        DGV.DataSource = ds.Tables("tbcustomer")
    End Sub
    Sub Tampildata()
        TextBox2.Text = rd.Item(1)
        TextBox3.Text = rd.Item(2)
        TextBox4.Text = rd.Item(3)
        TextBox5.Text = rd.Item(4)
    End Sub
    Sub TextMati()
        Me.TextBox1.Enabled = False
        Me.TextBox2.Enabled = False
        Me.TextBox3.Enabled = False
        Me.TextBox4.Enabled = False
        Me.TextBox5.Enabled = False
    End Sub
    Sub TextHidup()
        Me.TextBox1.Enabled = True
        Me.TextBox2.Enabled = True
        Me.TextBox3.Enabled = True
        Me.TextBox4.Enabled = True
        Me.TextBox5.Enabled = True
    End Sub
    Sub Kosong()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox1.Focus()
    End Sub

    Private Sub DataCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call Tampilgrid()
        Call TextMati()
        Me.BtnAdd.Enabled = True
        Me.BtnSave.Enabled = False
        Me.BtnEdit.Enabled = False
        Me.BtnUpdate.Enabled = False
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
        Me.BtnEdit.Enabled = False
        Me.BtnUpdate.Enabled = False
        Me.BtnCancel.Enabled = True
        Me.BtnDelete.Enabled = False
        Me.BtnExit.Enabled = True
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
            MsgBox("Data belum lengkap, Pastikan semua form terisi")
            Exit Sub
        Else
            Call Koneksi()
            Dim simpan As String = "insert into tbcustomer (kodecustomer, namacustomer, telepon, email, alamat) " & " values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "')"
            cmd = New OleDbCommand(simpan, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data berhasil di Input", MsgBoxStyle.Information, "Information")
            Me.OleDbConnection1.Close()
            Call Tampilgrid()
            DGV.Refresh()
            Call Koneksi()
            Call Kosong()
            Call TextMati()
            Me.BtnAdd.Enabled = True
            Me.BtnSave.Enabled = False
            Me.BtnEdit.Enabled = False
            Me.BtnUpdate.Enabled = False
            Me.BtnCancel.Enabled = True
            Me.BtnDelete.Enabled = False
            Me.BtnExit.Enabled = True
        End If
    End Sub

    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        Call TextHidup()
        TextBox1.Enabled = False
        BtnAdd.Enabled = False
        BtnSave.Enabled = False
        BtnEdit.Enabled = False
        BtnUpdate.Enabled = True
        BtnCancel.Enabled = True
        BtnDelete.Enabled = True
        BtnExit.Enabled = True
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Call Kosong()
        Call TextMati()
        Me.BtnAdd.Enabled = True
        Me.BtnSave.Enabled = False
        Me.BtnEdit.Enabled = False
        Me.BtnUpdate.Enabled = False
        Me.BtnCancel.Enabled = False
        Me.BtnDelete.Enabled = False
        Me.BtnExit.Enabled = True
    End Sub

    Private Sub BtnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdate.Click
        Dim Sql As String
        If MsgBox("Do You Want save again ?", MsgBoxStyle.YesNo, "Message") = vbYes Then
            Sql = "update tbcustomer set namacustomer='" & TextBox2.Text & "',telepon='" & TextBox3.Text & "',email='" & TextBox4.Text & "',alamat='" & TextBox5.Text & "' where kodecustomer='" & TextBox1.Text & "'"
            cmd = New OleDbCommand(Sql, conn)
            cmd.ExecuteNonQuery()
            DGV.Refresh()
            Me.OleDbConnection1.Close()

            Call TextMati()
            Call Kosong()
            Me.BtnAdd.Enabled = True
            Me.BtnSave.Enabled = False
            Me.BtnEdit.Enabled = False
            Me.BtnUpdate.Enabled = False
            Me.BtnCancel.Enabled = False
            Me.BtnDelete.Enabled = False
            Me.BtnExit.Enabled = True
            DGV.Refresh()
            Call Tampilgrid()
        End If
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        If TextBox1.Text = "" Then
            MsgBox("Kode belum diisi")
            TextBox1.Focus()
            Exit Sub
        Else
            If MessageBox.Show("Yakin akan dihapus..?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Dim hapus As String = "Delete * from tbcustomer where kodecustomer='" & TextBox1.Text & "'"
                cmd = New OleDbCommand(hapus, conn)
                cmd.ExecuteNonQuery()
                Call Tampilgrid()
                Call Kosong()
                Me.BtnAdd.Enabled = True
                Me.BtnSave.Enabled = False
                Me.BtnEdit.Enabled = False
                Me.BtnUpdate.Enabled = False
                Me.BtnCancel.Enabled = False
                Me.BtnDelete.Enabled = False
                Me.BtnExit.Enabled = True
            Else
                Call TextMati()
            End If
        End If
    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        MenuUtama.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.LostFocus
        str = "SELECT * FROM tbcustomer Where kodecustomer = '" & TextBox1.Text & "'"
        cmd = New OleDbCommand(str, conn)
        rd = cmd.ExecuteReader
        Try
            While rd.Read
                TextBox2.Text = rd.GetString(1)
                TextBox3.Text = rd.GetString(2)
                TextBox4.Text = rd.GetValue(3)
                TextBox5.Text = rd.GetValue(4)
                TextMati()
                Me.BtnAdd.Enabled = False
                Me.BtnSave.Enabled = False
                Me.BtnEdit.Enabled = True
                Me.BtnUpdate.Enabled = False
                Me.BtnCancel.Enabled = False
                Me.BtnDelete.Enabled = False
                Me.BtnExit.Enabled = True
            End While
        Finally
            rd.Close()
        End Try
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        TextBox2.MaxLength = 30
        If e.KeyChar = Chr(13) Then TextBox3.Focus()
    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        TextBox3.MaxLength = 30
        If e.KeyChar = Chr(13) Then TextBox3.Focus()
    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        TextBox3.MaxLength = 100
        If e.KeyChar = Chr(13) Then TextBox4.Focus()
    End Sub

    Private Sub TextBox5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        TextBox4.MaxLength = 100
        If e.KeyChar = Chr(13) Then BtnSave.Focus()
    End Sub
End Class