Imports System.Data.SqlClient
Public Class MasterUser
    Sub KondisiAwal()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        ComboBox1.Text = ""
        Button1.Text = "Input"
        Button2.Text = "Edit"
        Button3.Text = "Hapus"
        Button4.Text = "Tutup"
        Call MunculGrid()
    End Sub

    Private Sub MasterUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call KondisiAwal()
    End Sub

    Sub MunculGrid()
        Call Koneksi()
        Da = New SqlDataAdapter("select IdUser, NamaUser, LevelUser from TB_USER", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "TB_USER")
        DataGridView1.DataSource = Ds.Tables("TB_USER")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If Button1.Text = "Input" Then
            Button1.Text = "Simpan"
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Text = "Batal"
        Else
            Call Koneksi()
            Dim simpan As String = "insert into TB_USER values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & ComboBox1.Text & "')"
            Cmd = New SqlCommand(simpan, Conn)
            Cmd.ExecuteNonQuery()
            MsgBox("Input data berhasil!!")
            Call KondisiAwal()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Call Koneksi()
        Dim edit As String = "update TB_USER set NamaUser='" & TextBox2.Text & "', PasswordUser='" & TextBox3.Text & "', LevelUser='" & ComboBox1.Text & "' where IdUser='" & TextBox1.Text & "'"
        Cmd = New SqlCommand(edit, Conn)
        Cmd.ExecuteNonQuery()
        MsgBox("Edit data berhasil!!")
        Call KondisiAwal()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Call Koneksi()
        Dim hapus As String = "delete from TB_USER where IdUser='" & TextBox1.Text & "'"
        Cmd = New SqlCommand(hapus, Conn)
        Cmd.ExecuteNonQuery()
        MsgBox("Data berhasil di hapus", MsgBoxStyle.Information, "Information")
        Call KondisiAwal()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress

        If e.KeyChar = Chr(13) Then
            Call Koneksi()
            Cmd = New SqlCommand("Select * From TB_USER where IdUser='" & TextBox1.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()

            If Not Rd.HasRows Then
                MsgBox("Id user tidak ada!!")
            Else
                TextBox1.Text = Rd.Item("IdUser")
                TextBox2.Text = Rd.Item("NamaUser")
                TextBox3.Text = Rd.Item("PasswordUser")
                ComboBox1.Text = Rd.Item("LevelUser")
            End If

        End If

    End Sub
End Class