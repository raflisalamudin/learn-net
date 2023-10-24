Imports System
Imports System.Data
Imports System.Data.OleDb

Partial Public Class pgePenerimaanBarang
    Inherits System.Web.UI.Page

    Private strSQL As String
    Private objDataTable As DataTable
    Private objReader As OleDbDataReader
    Private objAdapter As OleDbDataAdapter
    Private objDataset As DataSet
    Private myCon As OleDbConnection
    Private objCommand As OleDbCommand
    Private strCon As String
    Private arrBarang(3) As String
    Private dblNewIn As Double
    Private dblNewAkhir As Double
    Private tmpNewIn As Double
    Private tmpNewAkhir As Double
    Private tmpQty As Double

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            strCon = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=D:\Belajar VB.Net\inventory\inventory\db.mdb;"
            If Not IsPostBack Then
                Call ListGrid()
                Call PopulateBarang()
            End If
        Catch ex As Exception
            ShowMessageBox(ex.Message)
        End Try
    End Sub

    Private Sub ShowMessageBox(ByVal strMessage As String)
        Dim strScript As String = "<script language=JavaScript>"
        strScript += "alert(""" & strMessage & """);"
        strScript += "</script>"
        If (Not ClientScript.IsStartupScriptRegistered("MyMessage")) Then
            ClientScript.RegisterClientScriptBlock(Me.GetType(), "MyMessage", strScript)
        End If
    End Sub

    Private Sub ListGrid()
        Try
            objDataset = New DataSet
            myCon = New OleDbConnection(strCon)
            myCon.Open()
            'strSQL = "SELECT A.NO_PENERIMAAN,A.TGL_TERIMA,A.QTY,A.KD_BRG,B.NM_BRG,B.HRG_SAT,TOT_HRG= A.QTY * B.HRG_SAT FROM TBL_PENERIMAAN A, TBL_BARANG B WHERE A.KD_BRG = B.KD_BRG ORDER BY A.NO_PENERIMAAN,A.KD_BRG ASC"
            'strSQL = "SELECT A.NO_PENERIMAAN,A.TGL_TERIMA,A.QTY,A.KD_BRG,B.NM_BRG,B.HRG_SAT FROM TBL_PENERIMAAN A, TBL_BARANG B WHERE A.KD_BRG = B.KD_BRG ORDER BY A.NO_PENERIMAAN,A.KD_BRG ASC"
            strSQL = "SELECT A.NO_PENERIMAAN,A.TGL_TERIMA,A.QTY,A.KD_BRG,B.NM_BRG,B.HRG_SAT, A.QTY * B.HRG_SAT AS TOT_HRG FROM TBL_PENERIMAAN A, TBL_BARANG B WHERE A.KD_BRG=B.KD_BRG ORDER BY A.NO_PENERIMAAN,A.KD_BRG ASC"

            objAdapter = New OleDbDataAdapter(strSQL, myCon)
            objAdapter.Fill(objDataset)
            grdList.DataSource = objDataset
            grdList.DataBind()
            myCon.Close()
        Catch ex As Exception
            grdList.DataSource = Nothing
            grdList.DataBind()
        End Try
    End Sub

    Private Sub ClearObject()
        Try
            txtNomor.Text = ""
            txtHarga.Text = ""
            txtQty.Text = ""
            dtTglTrans.SelectedDate = Nothing
            ddlBarang.Text = ""
        Catch ex As Exception
        End Try
    End Sub

    Private Sub PopulateBarang()
        Try
            ddlBarang.Items.Clear()
            myCon = New OleDbConnection(strCon)
            objDataTable = New DataTable
            myCon.Open()
            strSQL = "SELECT KD_BRG,NM_BRG,HRG_SAT FROM TBL_BARANG ORDER BY KD_BRG ASC"
            objCommand = New OleDbCommand(strSQL, myCon)
            objReader = objCommand.ExecuteReader(CommandBehavior.Default)
            If objReader.HasRows Then
                ddlBarang.Items.Add("")
                While objReader.Read
                    ddlBarang.Items.Add(objReader(0) & "-" & objReader(1) & "-" & objReader(2))
                End While
            End If
            objCommand.Dispose()
            objReader.Close()
            myCon.Close()
            objCommand = Nothing
            objReader = Nothing
            myCon = Nothing
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        If txtNomor.Text = "" Then
            ShowMessageBox("Nomor penerimaan tidak boleh kosong")
            txtNomor.Focus()
        ElseIf ddlBarang.Text = "" Then
            ShowMessageBox("Kode barang tidak boleh kosong")
            ddlBarang.Focus()
        ElseIf txtQty.Text = "" Then
            ShowMessageBox("Quantity tidak boleh kosong")
            txtQty.Focus()
        Else
            myCon = New OleDbConnection(strCon)
            Try
                arrBarang = Split(ddlBarang.Text, "-")
                myCon.Open()
                strSQL = "SELECT * FROM TBL_PENERIMAAN WHERE NO_PENERIMAAN = '" & Trim(txtNomor.Text) & "'"
                objCommand = New OleDbCommand(strSQL, myCon)
                objReader = objCommand.ExecuteReader(CommandBehavior.Default)
                If objReader.HasRows Then
                    ShowMessageBox("Duplicate Data")
                Else
                    objCommand.Dispose()
                    strSQL = "INSERT INTO TBL_PENERIMAAN(NO_PENERIMAAN,TGL_TERIMA,KD_BRG,QTY) VALUES('" & txtNomor.Text & "','" & dtTglTrans.SelectedDate & "','" & arrBarang(0) & "','" & CDbl(txtQty.Text) & "')"
                    objCommand = New OleDbCommand(strSQL, myCon)
                    If objCommand.ExecuteNonQuery Then
                        ShowMessageBox("Data telah di simpan")
                    Else
                        ShowMessageBox("Data error di simpan")
                    End If
                End If

                objReader.Close()
                strSQL = "SELECT * FROM TBL_STOCK WHERE KD_BRG = '" & arrBarang(0) & "'"
                objCommand = New OleDbCommand(strSQL, myCon)
                objReader = objCommand.ExecuteReader(CommandBehavior.Default)
                If objReader.HasRows Then
                    objReader.Read()
                    dblNewAkhir = CDbl(objReader(3)) + CDbl(txtQty.Text)
                    dblNewIn = CDbl(objReader(1)) + CDbl(txtQty.Text)
                    strSQL = "UPDATE TBL_STOCK SET QTY_IN = " & dblNewIn & ", QTY_AKHIR = " & dblNewAkhir & " WHERE KD_BRG ='" & arrBarang(0) & "'"
                    objCommand = New OleDbCommand(strSQL, myCon)
                    objCommand.ExecuteNonQuery()
                Else
                    strSQL = "INSERT INTO TBL_STOCK(KD_BRG,QTY_IN,QTY_OUT,QTY_AKHIR) VALUES('" & arrBarang(0) & "'," & CDbl(txtQty.Text) & ",0,'" & CDbl(txtQty.Text) & "')"
                    objCommand = New OleDbCommand(strSQL, myCon)
                    objCommand.ExecuteNonQuery()
                End If
            Catch ex As Exception
                ShowMessageBox("ERROR")
            Finally
                myCon.Close()
                objCommand = Nothing
                objReader = Nothing
                myCon = Nothing
                Call ListGrid()
                Call ClearObject()
            End Try
        End If
    End Sub

    Private Sub grdList_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles grdList.SelectedIndexChanged
        Try
            txtNomor.Text = grdList.SelectedRow.Cells(1).Text
            dtTglTrans.SelectedDate = CDate(grdList.SelectedRow.Cells(2).Text)
            ddlBarang.Text = grdList.SelectedRow.Cells(3).Text & "-" & grdList.SelectedRow.Cells(4).Text & "-" & grdList.SelectedRow.Cells(5).Text
            txtQty.Text = Format(CDbl(grdList.SelectedRow.Cells(6).Text), "#,##0")
            txtHarga.Text = Format(CDbl(grdList.SelectedRow.Cells(7).Text), "#,##0.00")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDelete.Click
        If txtNomor.Text = "" Or txtQty.Text = "" Or ddlBarang.Text = "" Then
            ShowMessageBox("Data kosong")
        Else
            myCon = New OleDbConnection(strCon)
            Try
                arrBarang = Split(ddlBarang.Text, "-")
                myCon.Open()
                strSQL = "DELETE FROM TBL_PENERIMAAN WHERE NO_PENERIMAAN = '" & Trim(txtNomor.Text) & "'"
                objCommand = New OleDbCommand(strSQL, myCon)
                If objCommand.ExecuteNonQuery Then
                    ShowMessageBox("Data telah dihapus")
                Else
                    ShowMessageBox("Hapus gagal")
                End If
                strSQL = "SELECT * FROM TBL_STOCK WHERE KD_BRG = '" & arrBarang(0) & "'"
                objCommand = New OleDbCommand(strSQL, myCon)
                objReader = objCommand.ExecuteReader(CommandBehavior.Default)
                If objReader.HasRows Then
                    objReader.Read()
                    dblNewAkhir = CDbl(objReader(3)) - CDbl(txtQty.Text)
                    dblNewIn = CDbl(objReader(1)) - CDbl(txtQty.Text)
                    strSQL = "UPDATE TBL_STOCK SET QTY_IN = " & dblNewIn & ",QTY_AKHIR = " & dblNewAkhir & " WHERE KD_BRG ='" & arrBarang(0) & "'"
                    objCommand = New OleDbCommand(strSQL, myCon)
                    objCommand.ExecuteNonQuery()
                End If
            Catch ex As Exception
                ShowMessageBox("ERROR")
            Finally
                myCon.Close()
                objCommand = Nothing
                objReader = Nothing
                myCon = Nothing
                Call ListGrid()
                Call ClearObject()
            End Try
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClear.Click
        Call ClearObject()
    End Sub

End Class