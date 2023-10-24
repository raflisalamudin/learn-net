Imports System
Imports System.Data
Imports System.Data.OleDb
Public Class Login
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

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Focus()
    End Sub

    Private Sub CmdLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdLogin.Click
        Koneksi()
        cmd = New OleDbCommand("SELECT * FROM tbuser where iduser='" & TextBox1.Text & "' and passworduser='" & TextBox2.Text & "' and bagian='" & ComboBox1.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            MsgBox("Login Sukses")
            If ComboBox1.Text = "Admin" Then
                MenuUtama.USERToolStripMenuItem.Enabled = False
                MenuUtama.MASTERToolStripMenuItem.Enabled = False
            ElseIf ComboBox1.Text = "Manager" Then
                MenuUtama.USERToolStripMenuItem.Enabled = False
                MenuUtama.FILEToolStripMenuItem.Enabled = True
                MenuUtama.MASTERToolStripMenuItem.Enabled = True
                MenuUtama.TRANSAKSIToolStripMenuItem.Enabled = True
            ElseIf ComboBox1.Text = "User" Then
                MenuUtama.USERToolStripMenuItem.Enabled = False
                MenuUtama.FILEToolStripMenuItem.Enabled = True
                MenuUtama.MASTERToolStripMenuItem.Enabled = False
                MenuUtama.TRANSAKSIToolStripMenuItem.Enabled = False
                MenuUtama.LAPORANToolStripMenuItem.Enabled = False
                MenuUtama.KasirToolStripMenuItem.Enabled = True
            End If
            MenuUtama.Show()
            Me.Hide()
        Else
            MsgBox("Tidak dapat login, periksa kembali ID User dan Password atau bagian salah!!!")
            TextBox1.Focus()
            Me.TextBox1.Text = ""
            Me.TextBox2.Text = ""
            Me.ComboBox1.Text = ""
        End If
    End Sub

    Private Sub CmdLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdLogout.Click
        Me.Close()
    End Sub
End Class