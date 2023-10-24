Imports System.Data.OleDb
Module Module1
    Public CONN As OleDbConnection
    Public Da As OleDbDataAdapter
    Public Ds As DataSet
    Public Rd As OleDbDataReader
    Public Cmd As OleDbCommand
    Public LokasiData As String
    Public Sub Koneksi()
        LokasiData = "provider=microsoft.jet.oledb.4.0;data source=D:\Belajar VB.Net\AppMiniMarket\DBMiniMarket.mdb"
        CONN = New OleDbConnection(LokasiData)
        If CONN.State = ConnectionState.Closed Then CONN.Open()
    End Sub
End Module
