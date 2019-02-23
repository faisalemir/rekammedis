Imports Model
Imports Logic

Public Class TambahRekamMedis
    Inherits System.Web.UI.Page
    Dim logickon As New LogicKondisi
    Dim logicrm As New LogicRekamMedis
    Dim logicobt As New LogicObat
    Dim logicter As New LogicTerapi
    Dim logicrob As New LogicRekamObat
    Dim logicrtr As New LogicRekamTerapi
    Dim modelrm As New ModelRekamMedis
    Dim modelrbt As New ModelRekamObat
    Dim modelrtr As New ModelRekamTerapi

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("login") Is Nothing Then
            Session.RemoveAll()
            Response.Redirect("Default.aspx")
        End If
        If Not IsPostBack() Then
            tampil()
        End If
    End Sub

    Sub tampil()
        div_obat.Visible = False
        div_terapi.Visible = False
        btn_selesai.Visible = False

        tbx_idrm.Focus()
        tbx_idpasien.Enabled = False
        tbx_idreg.Enabled = False
        ddl_kondisi.Enabled = False
        tbx_stole.Enabled = False
        tbx_respirate.Enabled = False
        tbx_suhu.Enabled = False
        tbx_nadi.Enabled = False
        tbx_berat.Enabled = False
        tbx_tinggi.Enabled = False
        tbx_anamnesia.Enabled = False

        Session.Remove("arrayobat")
        Session.Remove("arrayterapi")
        With ddl_kondisi
            .DataSource = logickon.selectall()
            .DataTextField = "kondisi"
            .DataValueField = "id_kondisi"
            .DataBind()
        End With

        With gdv_obat
            .DataSource = logicobt.selectall()
            .DataBind()
        End With

        With gdv_terapi
            .DataSource = logicter.selectall()
            .DataBind()
        End With

    End Sub

    Sub bulobat()
        Dim arrayobat As New List(Of ModelRekamObat)
        arrayobat = Session("arrayobat")
        bul_obat.Items.Clear()
        Dim hitung As Integer = 0
        While (hitung < arrayobat.Count)
            bul_obat.Items.Add(arrayobat(hitung).obat.nama.ToString + " @" + arrayobat(hitung).jumlah.ToString)
            hitung += 1
        End While
    End Sub

    Sub bulterapi()
        Dim arrayterapi As New List(Of ModelRekamTerapi)
        arrayterapi = Session("arrayterapi")
        bul_terapi.Items.Clear()
        Dim hitung As Integer = 0
        While (hitung < arrayterapi.Count)
            bul_terapi.Items.Add(arrayterapi(hitung).terapi.terapi.ToString)
            hitung += 1
        End While
    End Sub

    Protected Sub gdv_obat_RowCommand(sender As Object, e As GridViewCommandEventArgs) Handles gdv_obat.RowCommand
        Dim index As Integer = Convert.ToInt32(e.CommandArgument)
        Dim dgvRow As GridViewRow = gdv_obat.Rows(index)
        Dim arrayobat As New List(Of ModelRekamObat)

        If e.CommandName = "tambah_obat" Then
            If Not IsNothing(Session("arrayobat")) Then
                arrayobat = Session("arrayobat")
            End If

            With modelrbt
                .id_obat = dgvRow.Cells(0).Text
                .id_rm = tbx_idrm.Text
                .jumlah = Convert.ToInt32(Convert.ToDecimal(CType(dgvRow.Cells(2).FindControl("tbx_jumlah"), TextBox).Text))
                .obat = logicobt.selectbyid(.id_obat)
            End With

            index = arrayobat.IndexOf(arrayobat.Find(Function(x) x.id_obat = dgvRow.Cells(0).Text))

            If index >= 0 Then
                arrayobat(index).jumlah += modelrbt.jumlah
            Else
                arrayobat.Add(modelrbt)
            End If

            Session("arrayobat") = arrayobat
            bulobat()

        End If
    End Sub

    Protected Sub gdv_terapi_RowCommand(sender As Object, e As GridViewCommandEventArgs) Handles gdv_terapi.RowCommand
        Dim index As Integer = Convert.ToInt32(e.CommandArgument)
        Dim dgvRow As GridViewRow = gdv_terapi.Rows(index)
        Dim arrayterapi As New List(Of ModelRekamTerapi)

        If e.CommandName = "tambah_terapi" Then
            If Not IsNothing(Session("arrayterapi")) Then
                arrayterapi = Session("arrayterapi")
            End If

            With modelrtr
                .id_rm = tbx_idrm.Text
                .id_terapi = dgvRow.Cells(0).Text
                .terapi = logicter.selectbyid(.id_terapi)
            End With

            index = arrayterapi.IndexOf(arrayterapi.Find(Function(x) x.id_terapi = dgvRow.Cells(0).Text))

            If index < 0 Then
                arrayterapi.Add(modelrtr)
            End If

            Session("arrayterapi") = arrayterapi
            bulterapi()
        End If
    End Sub

    Protected Sub btn_obat_Click(sender As Object, e As EventArgs) Handles btn_obat.Click
        With gdv_obat
            .DataSource = logicobt.search(tbx_obat.Text)
            .DataBind()
        End With
    End Sub

    Protected Sub btn_terapi_Click(sender As Object, e As EventArgs) Handles btn_terapi.Click
        With gdv_terapi
            .DataSource = logicter.search(tbx_terapi.Text)
            .DataBind()
        End With
    End Sub

    Protected Sub btn_cek_Click(sender As Object, e As EventArgs) Handles btn_cek.Click
        modelrm = logicrm.selectbyid(tbx_idrm.Text)
        If tbx_idrm.Text = modelrm.id_rm Then
            tbx_idrm.Text = Nothing
            tbx_idrm.Focus()
        Else
            div_obat.Visible = True
            div_terapi.Visible = True
            btn_selesai.Visible = True
            btn_cek.Enabled = False

            tbx_idrm.Enabled = False
            tbx_idpasien.Enabled = True
            tbx_idreg.Enabled = True
            ddl_kondisi.Enabled = True
            tbx_stole.Enabled = True
            tbx_respirate.Enabled = True
            tbx_suhu.Enabled = True
            tbx_nadi.Enabled = True
            tbx_berat.Enabled = True
            tbx_tinggi.Enabled = True
            tbx_anamnesia.Enabled = True
        End If
    End Sub

    Protected Sub btn_selesai_Click(sender As Object, e As EventArgs) Handles btn_selesai.Click
        Dim arrayobat As List(Of ModelRekamObat) = Session("arrayobat")
        Dim arrayterapi As List(Of ModelRekamTerapi) = Session("arrayterapi")
        Dim cek As Boolean = False
        Dim index As Integer

        With modelrm
            .id_rm = tbx_idrm.Text
            .id_pasien = tbx_idpasien.Text
            .id_reg = tbx_idreg.Text
            .id_kondisi = ddl_kondisi.SelectedValue
            .stole = tbx_stole.Text
            .respiratory = tbx_respirate.Text
            .suhu = tbx_suhu.Text
            .nadi = tbx_nadi.Text
            .berat = tbx_berat.Text
            .tinggi = tbx_tinggi.Text
            .anamnesia = tbx_anamnesia.Text
            .tanggal = Date.Now
        End With

        cek = logicrm.insert(modelrm)

        If cek = True Then
            If arrayobat.Count > 0 Then
                index = 0
                While index < arrayobat.Count
                    logicrob.insert(arrayobat(index))
                    index += 1
                End While
            End If

            If arrayterapi.Count > 0 Then
                index = 0
                While index < arrayterapi.Count
                    logicrtr.insert(arrayterapi(index))
                    index += 1
                End While
            End If
            Response.Redirect("RekamMedis.aspx")
        End If
    End Sub
End Class