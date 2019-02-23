Imports Model
Imports Logic
Imports System.Xml
Imports System.Web

Public Class RekamMedis
    Inherits System.Web.UI.Page
    Dim logicrm As New LogicRekamMedis
    Dim modelrm As List(Of ModelRekamMedis)

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("login") Is Nothing Then
            Session.RemoveAll()
            Response.Redirect("Default.aspx")
        End If
        tampil()
    End Sub

    Sub tampil()
        modelrm = logicrm.grup()
        Dim i As Integer = 0
        While i < modelrm.Count
            If modelrm(i).pasien.jk = "0" Or modelrm(i).pasien.jk = "False" Then
                modelrm(i).pasien.jk = "Laki-laki"
            Else
                modelrm(i).pasien.jk = "Perempuan"
            End If
            i += 1
        End While
        dgv_tampil.DataSource = modelrm
        dgv_tampil.DataBind()
    End Sub

End Class