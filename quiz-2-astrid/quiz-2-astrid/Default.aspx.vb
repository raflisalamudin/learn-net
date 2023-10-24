Imports System
Imports System.Data
Imports System.Data.OleDb

Partial Public Class _Default
    Inherits System.Web.UI.Page
    Private strSQL As String
    Private objDataTable As DataTable
    Private objReader As OleDbDataReader
    Private objAdapter As OleDbDataAdapter
    Private objDataset As DataSet
    Private myCon As OleDbConnection
    Private objCommand As OleDbCommand
    Private strCon As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            strCon = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=D:\Belajar VB.Net\quiz-2-astrid\quiz-2-astrid\db.mdb;"
            'Note : Untuk semua baris code ini disesuaikan dengan Lokasi Masing-Masing
            If Not IsPostBack Then
                Call ListGrid()
            End If
        Catch ex As Exception
            ShowMessageBox(ex.Message)
        End Try

        txtNik.Focus()
        txtUpahPokok.Enabled = False
        txtUpahJam.Enabled = False
        txtUpahLembur.Enabled = False
        txtJamsostek.Enabled = False
        txtGajiKotor.Enabled = False
        txtPajak.Enabled = False
        txtGajiBersih.Enabled = False

    End Sub

    Private Sub ListGrid()
        Try
            myCon = New OleDbConnection(strCon)
            myCon.Open()

            strSQL = "SELECT * FROM TBL_PAYROLL BY NIK ASC"
            objCommand = New OleDbCommand(strSQL, myCon)
            objReader = objCommand.ExecuteReader

            objDataset = New DataSet
            objDataset.Tables.Add("")
            objDataset.Tables.Add("NIK")
            objDataset.Tables(0).Load(objReader)

            grdList.DataSource = objDataset
            grdList.DataBind()

            objReader.Close()
            myCon.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Protected Sub btnHitung_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnHitung.Click
        Try
            Dim dblUpahPokok, dblUpahHari, dblJumlahHariKerja, dblJumlahLembur, dblUpahJam, dblJamsostek, dblGajiKotor, dblTunjangan, dblUpahLembur, dblPajak, dblPotonganLain As Double

            dblUpahHari = txtUpahHari.Text
            dblJumlahHariKerja = txtJumlahHariKerja.Text
            dblTunjangan = txtTunjangan.Text
            dblJumlahLembur = txtJumlahLembur.Text
            dblPotonganLain = txtPotonganLain.Text

            txtUpahPokok.Text = dblUpahHari * dblJumlahHariKerja

            txtUpahJam.Text = txtUpahPokok.Text / 173

            txtUpahLembur.Text = txtUpahJam.Text * txtJumlahLembur.Text

            txtJamsostek.Text = txtUpahPokok.Text * (2.5 / 100)

            txtGajiKotor.Text = txtUpahPokok.Text + dblTunjangan + txtUpahLembur.Text - txtJamsostek.Text

            If txtGajiKotor.Text <= 5000000 Then
                txtPajak.Text = txtGajiKotor.Text * (5 / 100)
            ElseIf txtGajiKotor.Text > 5000000 Then
                txtPajak.Text = txtGajiKotor.Text * (15 / 100)
            End If

            txtGajiBersih.Text = txtGajiKotor.Text - txtPajak.Text - dblPotonganLain

        Catch ex As Exception
            MsgBox("Silahkan input data yang diperlukan terlebih dahulu!")
        End Try
    End Sub

    Protected Sub btnSimpan_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSimpan.Click
        Try
            If txtNik.Text = "" Then
                ShowMessageBox("NIK tidak boleh kosong")
                txtNik.Focus()
            ElseIf txtNama.Text = "" Then
                ShowMessageBox("Nama tidak boleh kosong")
                txtNama.Focus()
            ElseIf txtDepartement.Text = "" Then
                ShowMessageBox("Departememt tidak boleh kosong")
                txtDepartement.Focus()
            ElseIf txtUpahHari.Text = "" Then
                ShowMessageBox("Upah/hari tidak boleh kosong")
                txtUpahHari.Focus()
            ElseIf txtJumlahHariKerja.Text = "" Then
                ShowMessageBox("Jumlah hari kerja tidak boleh kosong")
                txtJumlahHariKerja.Focus()
            ElseIf txtJumlahLembur.Text = "" Then
                ShowMessageBox("Jumlah lembur tidak boleh kosong atau isi dengan 0")
                txtJumlahLembur.Focus()
            ElseIf txtTunjangan.Text = "" Then
                ShowMessageBox("Tunjangan tidak boleh kosong atau isi dengan 0")
                txtTunjangan.Focus()
            ElseIf txtPotonganLain.Text = "" Then
                ShowMessageBox("Potongan lain tidak boleh kosong atau isi dengan 0")
                txtPotonganLain.Focus()
            ElseIf txtGajiBersih.Text = "" Then
                ShowMessageBox("Gaji bersih tidak boleh kosong, silahkan input seluruh form yang tersedia!!!")
                txtPotonganLain.Focus()

            Else
                myCon = New OleDbConnection(strCon)

                Try
                    myCon.Open()

                    strSQL = "Select * FROM TBL_PAYROLL WHERE NIK = '" & Trim(txtNik.Text) & "'"
                    objCommand = New OleDbCommand(strSQL, myCon)
                    objReader = objCommand.ExecuteReader(CommandBehavior.Default)
                    If objReader.HasRows Then
                        ShowMessageBox("Duplicate Data")
                    Else

                        objCommand.Dispose()
                        strSQL = "INSERT INTO TBL_PAYROLL (NIK,NAMA,DEPARTEMENT,UPAH_HARI,JUMLAH_HARI_KERJA,UPAH_POKOK,UPAH_JAM) VALUES ('" & CDbl(txtNik.Text) & "','" & txtNama.Text & "','" & txtDepartement.Text & "','" & CDbl(txtUpahHari.Text) & "','" & CDbl(txtJumlahHariKerja.Text) & "','" & CDbl(txtUpahPokok.Text) & "','" & CDbl(txtUpahJam.Text) & "')"
                        objCommand = New OleDbCommand(strSQL, myCon)
                        If objCommand.ExecuteNonQuery Then
                            ShowMessageBox("Data berhasil di simpan!!!")
                        Else
                            ShowMessageBox("Data gagal di simpan!!!")
                        End If
                    End If
                    objReader.Close()
                Catch ex As Exception
                    ShowMessageBox(ex.Message)
                Finally
                    myCon.Close()
                    objCommand = Nothing
                    objReader = Nothing
                    myCon = Nothing
                    'Call ListGrid()
                    'Call ClearObject()
                End Try
            End If
           
        Catch ex As Exception
            ShowMessageBox(ex.Message)
        End Try
    End Sub

    Protected Sub btnUpdate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnUpdate.Click
        Try
            myCon = New OleDbConnection(strCon)
            myCon.Open()

            strSQL = "UPDATE TBL_PAYROLL SET NIK='" & txtNik.Text & "', NAMA= '" & txtNama.Text & "',DEPARTEMENT= '" & txtDepartement.Text & "',UPAH_HARI='" & txtUpahHari.Text & "',JUMLAH_HARI_KERJA = '" & txtJumlahHariKerja.Text & "',UPAH_POKOK = '" & txtUpahPokok.Text & "',UPAH_JAM = '" & txtUpahJam.Text & "' WHERE NIK='" & txtNik.Text & "'"

            objCommand = New OleDbCommand(strSQL, myCon)
            If objCommand.ExecuteNonQuery() Then
                ShowMessageBox("Data berhasil di simpan!!!")
                Call ListGrid()
            Else
                ShowMessageBox("Data gagal di simpan!!!")
            End If

            myCon.Close()

        Catch ex As Exception
            ShowMessageBox(ex.Message)
        End Try

    End Sub

    Protected Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDelete.Click
        Try
            myCon = New OleDbConnection(strCon)
            myCon.Open()

            strSQL = "DELETE FROM TBL_PAYROLL WHERE NIK='" & txtNik.Text & "'"


            objCommand = New OleDbCommand(strSQL, myCon)
            If objCommand.ExecuteNonQuery() Then
                ShowMessageBox("Data berhasil di hapus!!!")
                Call ListGrid()
            Else
                ShowMessageBox("Data tidak di hapus!!!")
            End If

            myCon.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Protected Sub btnReset_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnReset.Click
        txtNik.Text = ""
        txtNama.Text = ""
        txtDepartement.Text = ""
        txtUpahHari.Text = ""
        txtJumlahHariKerja.Text = ""
        txtUpahPokok.Text = ""
        txtUpahJam.Text = ""
        txtJumlahLembur.Text = ""
        txtUpahLembur.Text = ""
        txtTunjangan.Text = ""
        txtJamsostek.Text = ""
        txtGajiKotor.Text = ""
        txtPajak.Text = ""
        txtPotonganLain.Text = ""
        txtGajiBersih.Text = ""
    End Sub

    Private Sub ShowMessageBox(ByVal strMessage As String)
        Dim strScript As String = "<script language=JavaScript>"
        strScript += "alert(""" & strMessage & """);"
        strScript += "</script>"
        If (Not ClientScript.IsStartupScriptRegistered("MyMessage")) Then
            ClientScript.RegisterClientScriptBlock(Me.GetType(), "MyMessage", strScript)
        End If
    End Sub

    
End Class