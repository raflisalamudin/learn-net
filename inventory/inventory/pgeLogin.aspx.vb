﻿Public Partial Class pgeLogin
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub btnClear_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtUser.Text = ""
        txtPass.Text = ""
    End Sub

    Private Sub btnLogin_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Try
            If txtUser.Text = "" Then
                ShowMessageBox("USER TIDAK BOLEH KOSONG")
            ElseIf txtPass.Text = "" Then
                ShowMessageBox("PASSWORD TIDAK BOLEH KOSONG")
            Else
                If txtUser.Text = "ADMIN" And txtPass.Text = "123456" Then
                    Response.Redirect("pgeMainMenu.aspx", False)
                Else
                    ShowMessageBox("USER / PASSWORD TIDAK DIKENAL")
                End If
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

End Class

