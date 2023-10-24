Imports System.Data.OleDb
Public Class MasterAdmin

    Private Sub MasterAdmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call KondisiAwal()
    End Sub

    Sub KondisiAwal()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        Button1.Text = "Input"
        Button2.Text = "Edit"
        Button3.Text = "Hapus"
        Button4.Text = "Tutup"
        Call MunculGrid()
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
    End Sub
    Sub MunculGrid()
        Call Koneksi()
        Da = New OleDbDataAdapter("Select KodeAdmin, NamaAdmin, LevelAdmin From TB_ADMIN", CONN)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "TB_ADMIN")
        DataGridView1.DataSource = (Ds.Tables("TB_ADMIN"))
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Button1.Text = "Input" Then
            Button1.Text = "Simpan"
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Text = "Batal"
            TextBox1.Focus()
        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Then
                MsgBox("Pastikan semua data terisi!!")
            Else
                Call Koneksi()
                Dim simpan As String = "Insert Into TB_ADMIN values ('" & TextBox1.Text & "', '" & TextBox2.Text & "', '" & TextBox3.Text & "', '" & ComboBox1.Text & "')"
                Cmd = New OleDbCommand(simpan, CONN)
                Cmd.ExecuteNonQuery()
                MsgBox("Data berhasil di input!!")
                Call KondisiAwal()
            End If

        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Button2.Text = "Edit" Then
            Button2.Text = "Simpan"
            Button1.Enabled = False
            Button3.Enabled = False
            Button4.Text = "Batal"
            TextBox1.Focus()
        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Then
                MsgBox("Pastikan semua data terisi!!")
            Else
                Call Koneksi()
                Dim edit As String = "Update TB_ADMIN set NamaAdmin='" & TextBox2.Text & "', PasswordAdmin='" & TextBox3.Text & "', LevelAdmin='" & ComboBox1.Text & "' where KodeAdmin='" & TextBox1.Text & "'"
                Cmd = New OleDbCommand(edit, CONN)
                Cmd.ExecuteNonQuery()
                MsgBox("Data berhasil di ubah!!")
                Call KondisiAwal()
            End If

        End If
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Button3.Text = "Hapus" Then
            Button3.Text = "Hapus Data"
            Button1.Enabled = False
            Button2.Enabled = False
            Button4.Text = "Batal"
            TextBox1.Focus()
        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Then
                MsgBox("Pastikan semua data terisi!!")
            Else
                Call Koneksi()
                Dim edit As String = "Delete From TB_ADMIN  where KodeAdmin='" & TextBox1.Text & "'"
                Cmd = New OleDbCommand(edit, CONN)
                Cmd.ExecuteNonQuery()
                MsgBox("Data berhasil di hapus!!")
                Call KondisiAwal()
            End If

        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If Button4.Text = "Batal" Then
            Call KondisiAwal()
        Else
            Me.Close()
        End If

    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Koneksi()
            Cmd = New OleDbCommand("Select * From TB_ADMIN where KodeAdmin='" & TextBox1.Text & "'", CONN)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                TextBox2.Text = Rd.Item("NamaAdmin")
                TextBox3.Text = Rd.Item("PasswordAdmin")
                ComboBox1.Text = Rd.Item("LevelAdmin")
            End If

        End If

    End Sub
End Class