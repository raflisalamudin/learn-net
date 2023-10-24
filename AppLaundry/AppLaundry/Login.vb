Imports System.Data.SqlClient
Public Class Login
    Sub KondisiAwal()
        TextBox1.Text = "USR01"
        TextBox2.Text = "ADMIN"
    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call KondisiAwal()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call Koneksi()
        Cmd = New SqlCommand("Select * From TB_USER where IdUser='" & TextBox1.Text & "' and PasswordUser='" & TextBox2.Text & "'", Conn)
        Rd = Cmd.ExecuteReader
        If Rd.HasRows Then
            Me.Close()
            Call BukaKunci()
        Else
            MsgBox("Kode User atau Password Salah!!")
            TextBox1.Focus()
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Sub BukaKunci()
        MenuUtama.LOGINToolStripMenuItem.Visible = False
        MenuUtama.LOGOUTToolStripMenuItem.Visible = True
        MenuUtama.MASTERToolStripMenuItem.Visible = True
        MenuUtama.TRANSAKSIToolStripMenuItem.Visible = True
        MenuUtama.UTILITYToolStripMenuItem.Visible = True
        MenuUtama.LAPORANToolStripMenuItem.Visible = True
    End Sub

End Class