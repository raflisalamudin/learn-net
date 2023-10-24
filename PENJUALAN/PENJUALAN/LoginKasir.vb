Imports System
Imports System.Data
Imports System.Data.OleDb
Public Class LoginKasir
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

    Private Sub LoginKasir_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Focus()
    End Sub

    Private Sub CmdLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdLogin.Click
        Koneksi()
        cmd = New OleDbCommand("SELECT * FROM tbkasir where username='" & TextBox1.Text & "' and password='" & TextBox2.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            MsgBox("Login Sukses")
            MenuKasir.Show()
            Me.Hide()
        Else
            MsgBox("Tidak dapat login, periksa kembali ID User dan Password atau bagian salah!!!")
            TextBox1.Focus()
            Me.TextBox1.Text = ""
            Me.TextBox2.Text = ""
        End If
    End Sub

    Private Sub CmdLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdLogout.Click
        Me.Close()
    End Sub
End Class