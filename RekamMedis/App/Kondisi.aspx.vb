Imports Logic
Imports Model

Public Class Kondisi
    Inherits System.Web.UI.Page
    Dim logickon As New LogicKondisi
    Dim modelkon As New ModelKondisi

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("login") Is Nothing Then
            Session.RemoveAll()
            Response.Redirect("Default.aspx")
        End If
        tampil()
    End Sub

    Sub tampil()
        gdv_kondisi.DataSource = logickon.selectall()
        gdv_kondisi.DataBind()
    End Sub

    Protected Sub btn_cari_Click(sender As Object, e As EventArgs) Handles btn_cari.Click
        gdv_kondisi.DataSource = logickon.search(tbx_cari.Text)
        gdv_kondisi.DataBind()
    End Sub

    Protected Sub gdv_kondisi_RowCommand(sender As Object, e As GridViewCommandEventArgs) Handles gdv_kondisi.RowCommand
        Dim index As Integer = Convert.ToInt32(e.CommandArgument)
        Dim dgvRow As GridViewRow = gdv_kondisi.Rows(index)

        With modelkon
            .id_kondisi = gdv_kondisi.Rows(index).Cells(0).Text
            .kondisi = gdv_kondisi.Rows(index).Cells(1).Text
        End With

        If e.CommandName = "sunting" Then
            pnl_cari.Visible = False
            pnl_sunting.Visible = True
            lbl_id.Text = modelkon.id_kondisi
            tbx_sunting.Text = modelkon.kondisi
        ElseIf e.CommandName = "hapus" Then
            logickon.delete(modelkon)
            tampil()
        End If
    End Sub

    Protected Sub btn_sunting_Click(sender As Object, e As EventArgs) Handles btn_sunting.Click
        With modelkon
            .id_kondisi = lbl_id.Text
            .kondisi = tbx_sunting.Text
        End With
        logickon.update(modelkon)
        pnl_cari.Visible = True
        pnl_sunting.Visible = False
        tampil()
    End Sub

    Protected Sub btn_batal_Click(sender As Object, e As EventArgs) Handles btn_batal.Click
        tbx_sunting.Text = Nothing
        pnl_cari.Visible = True
        pnl_sunting.Visible = False
    End Sub

    Protected Sub btn_tambah_Click(sender As Object, e As EventArgs) Handles btn_tambah.Click
        Response.Redirect("TambahKondisi.aspx")
    End Sub
End Class