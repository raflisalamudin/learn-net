Imports System.Data.OleDb
Public Class Login

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Sub Terbuka()
        MenuUtama.LoginToolStripMenuItem.Enabled = False
        MenuUtama.LogoutToolStripMenuItem.Enabled = True
        MenuUtama.MasterToolStripMenuItem.Enabled = True
        MenuUtama.TransaksiToolStripMenuItem.Enabled = True
        MenuUtama.LaporanToolStripMenuItem.Enabled = True
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Data belum lengkap, silahkan masukkan Kode atau Password!!")
        Else
            Call Koneksi()
            Cmd = New OleDbCommand("select * from TB_ADMIN where KodeAdmin='" & TextBox1.Text & "' and PasswordAdmin='" & TextBox2.Text & "'", CONN)
            Rd = Cmd.ExecuteReader
            Rd.Read()

            If Rd.HasRows Then
                Me.Close()
                Call Terbuka()
            Else
                MsgBox("Kode atau Password salah!!")
            End If

        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class