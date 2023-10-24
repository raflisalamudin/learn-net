Imports System
Imports System.Data
Imports System.Data.OleDb

Partial Public Class pgeStockBarang
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
            strCon = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=D:\Belajar VB.Net\inventory\inventory\db.mdb;"
            If Not IsPostBack Then
                Call ListGrid()
            End If
        Catch ex As Exception
            ShowMessageBox(ex.Message)
        End Try
    End Sub

    Private Sub ListGrid()
        Try
            objDataset = New DataSet
            myCon = New OleDbConnection(strCon)
            myCon.Open()
            strSQL = "SELECT A.KD_BRG, A.NM_BRG, A.SAT_BRG, A.SPEC_BRG, A.HRG_SAT, B.QTY_IN, B.QTY_OUT, B.QTY_AKHIR FROM TBL_BARANG A, TBL_STOCK B WHERE A.KD_BRG=B.KD_BRG ORDER BY A.KD_BRG ASC"
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

    Private Sub ShowMessageBox(ByVal strMessage As String)
        Dim strScript As String = "<script language=JavaScript>"
        strScript += "alert(""" & strMessage & """);"
        strScript += "</script>"
        If (Not ClientScript.IsStartupScriptRegistered("MyMessage")) Then
            ClientScript.RegisterClientScriptBlock(Me.GetType(), "MyMessage", strScript)
        End If
    End Sub

End Class