Imports System.Data.SqlClient
Public Class MasterCustomer
    Sub KondisiAwal()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""

        Button1.Text = "Input"
        Button2.Text = "Edit"
        Button3.Text = "Hapus"
        Button4.Text = "Tutup"

        Call MunculGrid()
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        TextBox1.MaxLength = 6
    End Sub
    Sub MunculGrid()
        Call Koneksi()
        Da = New SqlDataAdapter("select * from TB_CUSTOMER", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "TB_CUSTOMER")
        DataGridView1.DataSource = Ds.Tables("TB_CUSTOMER")
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If Button1.Text = "Input" Then
            Button1.Text = "Simpan"
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Text = "Batal"
        Else
            Call Koneksi()
            Dim simpan As String = "insert into TB_CUSTOMER values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "')"
            Cmd = New SqlCommand(simpan, Conn)
            Cmd.ExecuteNonQuery()
            MsgBox("Input data berhasil!!")
            Call KondisiAwal()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Call Koneksi()
        Dim edit As String = "update TB_CUSTOMER set NamaCustomer='" & TextBox2.Text & "', AlamatCustomer='" & TextBox3.Text & "', TelpCustomer='" & TextBox4.Text & "', KetCustomer='" & TextBox5.Text & "' where IdCustomer='" & TextBox1.Text & "'"
        Cmd = New SqlCommand(edit, Conn)
        Cmd.ExecuteNonQuery()
        MsgBox("Edit data berhasil!!")
        Call KondisiAwal()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Call Koneksi()
        Dim hapus As String = "delete from TB_CUSTOMER where IdCustomer='" & TextBox1.Text & "'"
        Cmd = New SqlCommand(hapus, Conn)
        Cmd.ExecuteNonQuery()
        MsgBox("Data berhasil di hapus", MsgBoxStyle.Information, "Information")
        Call KondisiAwal()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

    End Sub

    Private Sub MasterCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call KondisiAwal()
    End Sub
    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress

        If e.KeyChar = Chr(13) Then
            Call Koneksi()
            Cmd = New SqlCommand("Select * From TB_CUSTOMER where IdCustomer='" & TextBox1.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()

            If Not Rd.HasRows Then
                MsgBox("Id customer tidak ada!!")
            Else
                TextBox1.Text = Rd.Item("IdCustomer")
                TextBox2.Text = Rd.Item("NamaCustomer")
                TextBox3.Text = Rd.Item("AlamatCustomer")
                TextBox4.Text = Rd.Item("TelpCustomer")
                TextBox5.Text = Rd.Item("KetCustomer")
            End If

        End If

    End Sub
End Class