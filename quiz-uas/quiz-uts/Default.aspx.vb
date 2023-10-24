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
            strCon = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=D:\Belajar VB.Net\quiz-uas\quiz-uts\db.mdb;"
            'Note : Untuk semua baris code ini disesuaikan dengan Lokasi Masing-Masing
            If Not IsPostBack Then
                'Call ListGrid()
            End If
        Catch ex As Exception
            ShowMessageBox(ex.Message)
        End Try

        txtNoKendaraan.Focus()
        txtPpn.Enabled = False
        txtTotal.Enabled = False
    End Sub

    Private Sub btnCalculate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        Try
            Dim dblHarga, dblPpn As Double


            If radioRodaDua.Checked Then
                dblPpn = 10 / 100 * txtHarga.Text
                dblHarga = txtHarga.Text
            ElseIf radioRodaEmpat.Checked Then
                dblPpn = 15 / 100 * txtHarga.Text
                dblHarga = txtHarga.Text
            End If

            txtPpn.Text = dblPpn
            txtTotal.Text = dblHarga + dblPpn


        Catch ex As Exception
            MsgBox("Silahkan input harga atau pilih jenis kendaraan!")
        End Try
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            If txtNoKendaraan.Text = "" Then
                ShowMessageBox("No kendaraan tidak boleh kosong")
                txtNoKendaraan.Focus()
            ElseIf txtPemilik.Text = "" Then
                ShowMessageBox("Pemilik kendaraan tidak boleh kosong")
                txtPemilik.Focus()
            ElseIf txtNama.Text = "" Then
                ShowMessageBox("Nama Kendaraan tidak boleh kosong")
                txtNama.Focus()
            ElseIf txtNoRangka.Text = "" Then
                ShowMessageBox("No Rangka tidak boleh kosong")
                txtNoRangka.Focus()
            ElseIf txtWarna.Text = "" Then
                ShowMessageBox("Warna kendaraan tidak boleh kosong")
                txtWarna.Focus()
            ElseIf txtTahun.Text = "" Then
                ShowMessageBox("Tahun pembuatan tidak boleh kosong")
                txtTahun.Focus()
            ElseIf radioRodaDua.Checked = True Then
                myCon = New OleDbConnection(strCon)

                Try
                    myCon.Open()

                    strSQL = "Select * FROM TBL_KENDARAAN WHERE NO_KENDARAAN = '" & Trim(txtNoKendaraan.Text) & "'"
                    objCommand = New OleDbCommand(strSQL, myCon)
                    objReader = objCommand.ExecuteReader(CommandBehavior.Default)
                    If objReader.HasRows Then
                        ShowMessageBox("Duplicate Data")
                    Else

                        objCommand.Dispose()
                        strSQL = "INSERT INTO TBL_KENDARAAN (NO_KENDARAAN,PEMILIK,NAMA,NO_RANGKA,WARNA,JENIS_KENDARAAN,TAHUN,PPN,HARGA,TOTAL) VALUES ('" & txtNoKendaraan.Text & "','" & txtPemilik.Text & "','" & txtNama.Text & "','" & txtNoRangka.Text & "','" & txtWarna.Text & "','" & "Roda Dua" & "','" & txtTahun.Text & "','" & CDbl(txtPpn.Text) & "','" & txtHarga.Text & "','" & CDbl(txtTotal.Text) & "')"
                        objCommand = New OleDbCommand(strSQL, myCon)
                        If objCommand.ExecuteNonQuery Then
                            ShowMessageBox("Data telah di simpan")
                        Else
                            ShowMessageBox("Data error di simpan")
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

            Else
                myCon = New OleDbConnection(strCon)

                Try
                    myCon.Open()

                    strSQL = "Select * FROM TBL_KENDARAAN WHERE NO_KENDARAAN = '" & Trim(txtNoKendaraan.Text) & "'"
                    objCommand = New OleDbCommand(strSQL, myCon)
                    objReader = objCommand.ExecuteReader(CommandBehavior.Default)
                    If objReader.HasRows Then
                        ShowMessageBox("Duplicate Data")
                    Else

                        objCommand.Dispose()
                        strSQL = "INSERT INTO TBL_KENDARAAN (NO_KENDARAAN,PEMILIK,NAMA,NO_RANGKA,WARNA,JENIS_KENDARAAN,TAHUN,PPN,HARGA,TOTAL) VALUES ('" & txtNoKendaraan.Text & "','" & txtPemilik.Text & "','" & txtNama.Text & "','" & txtNoRangka.Text & "','" & txtWarna.Text & "','" & "Roda Empat" & "','" & txtTahun.Text & "','" & CDbl(txtPpn.Text) & "','" & txtHarga.Text & "','" & CDbl(txtTotal.Text) & "')"
                        objCommand = New OleDbCommand(strSQL, myCon)
                        If objCommand.ExecuteNonQuery Then
                            ShowMessageBox("Data telah di simpan")
                        Else
                            ShowMessageBox("Data error di simpan")
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

    Private Sub btnClear_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtNoKendaraan.Text = ""
        txtPemilik.Text = ""
        txtNama.Text = ""
        txtNoRangka.Text = ""
        txtWarna.Text = ""
        txtTahun.Text = ""
        txtPpn.Text = ""
        radioRodaDua.Checked = False
        radioRodaEmpat.Checked = False
        txtHarga.Text = ""
        txtTotal.Text = ""
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