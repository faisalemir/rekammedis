Imports Model
Imports Logic

Public Class TambahKondisi
    Inherits System.Web.UI.Page
    Dim logickon As New LogicKondisi

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("login") Is Nothing Then
            Session.RemoveAll()
            Response.Redirect("Default.aspx")
        End If
    End Sub

    Protected Sub btn_tambah_Click(sender As Object, e As EventArgs) Handles btn_tambah.Click
        Dim modelkon As New ModelKondisi

        With modelkon
            .id_kondisi = tbx_id.Text
            .kondisi = tbx_kondisi.Text
        End With

        logickon.insert(modelkon)
        Response.Redirect("Kondisi.aspx")
    End Sub

    Protected Sub btn_batal_Click(sender As Object, e As EventArgs) Handles btn_batal.Click
        Response.Redirect("Kondisi.aspx")
    End Sub
End Class