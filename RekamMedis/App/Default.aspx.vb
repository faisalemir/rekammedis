Imports Logic
Imports Model

Public Class _Default
    Inherits System.Web.UI.Page
    Dim modellog As New ModelLogin
    Dim logiclog As New LogicLogin

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("login") IsNot Nothing Then
            Response.Redirect("RekamMedis.aspx")
        End If
    End Sub

    Protected Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        modellog = logiclog.Login(tbx_username.Text, tbx_password.Text)

        If modellog.nama <> Nothing And modellog.pass <> Nothing Then
            Session("login") = modellog
            Response.Redirect("RekamMedis.aspx")
        Else
            lbl_info.Text = "Username atau Password tidak tepat."
        End If
    End Sub
End Class