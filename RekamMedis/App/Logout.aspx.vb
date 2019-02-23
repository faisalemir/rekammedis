Imports Logic

Public Class Logout
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim db As New LogicLogin
        db.Logout()
        Session.RemoveAll()
        Response.Redirect("Default.aspx")
    End Sub

End Class