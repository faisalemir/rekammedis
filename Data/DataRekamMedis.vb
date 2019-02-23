Imports Model
Imports System.Xml

Public Class DataRekamMedis
    Private service As New RekamMedis.RekamMedis
    Private modellrm As List(Of ModelRekamMedis)
    Private modelrm As New ModelRekamMedis
    Private datakon As New DataKondisi
    Private datapsn As New DataPasien

    Private Function new_dtSet(ByVal modelrm As ModelRekamMedis) As DataSet
        Dim dtSet As New DataSet
        Dim dtTable As New DataTable
        With dtTable
            .Columns.Add("id_rm")
            .Columns.Add("id_pasien")
            .Columns.Add("id_reg")
            .Columns.Add("id_kondisi")
            .Columns.Add("stole_diastole")
            .Columns.Add("respiratory_rate")
            .Columns.Add("suhu")
            .Columns.Add("nadi")
            .Columns.Add("berat_badan")
            .Columns.Add("tinggi_badan")
            .Columns.Add("anamnesia")
            .Columns.Add("tanggal")
            .Rows.Add(modelrm.id_rm,
                      modelrm.id_pasien,
                      modelrm.id_reg,
                      modelrm.id_kondisi,
                      modelrm.stole,
                      modelrm.respiratory,
                      modelrm.suhu,
                      modelrm.nadi,
                      modelrm.berat,
                      modelrm.tinggi,
                      modelrm.anamnesia,
                      modelrm.tanggal)
        End With
        dtSet.Tables.Add(dtTable)
        Return dtSet
    End Function

    Public Function insert(ByVal modelrm As ModelRekamMedis) As Boolean
        Return service.insert(new_dtSet(modelrm))
    End Function

    Public Function update(ByVal modelrm As ModelRekamMedis) As Boolean
        service.update(new_dtSet(modelrm))
        Return True
    End Function

    Public Function delete(ByVal modelrm As ModelRekamMedis) As Boolean
        service.delete(new_dtSet(modelrm))
        Return True
    End Function

    Public Function selectall() As List(Of ModelRekamMedis)
        dtSet.Reset()
        dtSet.ReadXml(New XmlNodeReader(service.selectall()))

        modellrm = (From row As DataRow In dtSet.Tables(0).Rows
                  Select New ModelRekamMedis() With
                         {
                             .id_rm = row("id_rm").ToString,
                             .id_pasien = row("id_pasien").ToString,
                             .id_reg = row("id_reg").ToString,
                             .id_kondisi = row("id_kondisi").ToString,
                             .stole = row("stole_diastole"),
                             .respiratory = row("respiratory_rate"),
                             .suhu = row("suhu"),
                             .nadi = row("nadi").ToString,
                             .berat = row("berat_badan"),
                             .tinggi = row("tinggi_badan"),
                             .anamnesia = row("anamnesia").ToString,
                             .tanggal = row("tanggal").ToString,
                             .kondisi = datakon.selectbyid(.id_kondisi),
                             .pasien = datapsn.selectbyid(.id_pasien)
                         }
                     ).ToList

        Return modellrm
    End Function

    Public Function selectbyid(ByVal id As String) As ModelRekamMedis
        dtSet.Reset()
        dtSet.ReadXml(New XmlNodeReader(service.selectall()))

        If dtSet.Tables.Count > 0 Then
            dtRows = dtSet.Tables(0).Select("id_rm = '" + id + "'")

            If dtRows.Count > 0 Then
                For Each row As DataRow In dtRows
                    With modelrm
                        .id_rm = row("id_rm").ToString
                        .id_pasien = row("id_pasien").ToString
                        .id_reg = row("id_reg").ToString
                        .id_kondisi = row("id_kondisi").ToString
                        .stole = row("stole_diastole")
                        .respiratory = row("respiratory_rate")
                        .suhu = row("suhu")
                        .nadi = row("nadi").ToString
                        .berat = row("berat_badan")
                        .tinggi = row("tinggi_badan")
                        .anamnesia = row("anamnesia").ToString
                        .tanggal = row("tanggal").ToString
                        .kondisi = datakon.selectbyid(.id_kondisi)
                        .pasien = datapsn.selectbyid(.id_pasien)
                    End With
                Next
            End If
        End If
        Return modelrm
    End Function

    Public Function search(ByVal kata As String) As List(Of ModelRekamMedis)
        dtSet.Reset()
        dtSet.ReadXml(New XmlNodeReader(service.selectall()))
        dtRows = dtSet.Tables(0).Select("id_rm LIKE '%" + kata + "%'")

        modellrm = (From row As DataRow In dtRows
                  Select New ModelRekamMedis() With
                         {
                             .id_rm = row("id_rm").ToString,
                             .id_pasien = row("id_pasien").ToString,
                             .id_reg = row("id_reg").ToString,
                             .id_kondisi = row("id_kondisi").ToString,
                             .stole = row("stole_diastole"),
                             .respiratory = row("respiratory_rate"),
                             .suhu = row("suhu"),
                             .nadi = row("nadi").ToString,
                             .berat = row("berat_badan"),
                             .tinggi = row("tinggi_badan"),
                             .anamnesia = row("anamnesia").ToString,
                             .tanggal = row("tanggal").ToString,
                             .kondisi = datakon.selectbyid(.id_kondisi),
                             .pasien = datapsn.selectbyid(.id_pasien)
                         }
                     ).ToList

        Return modellrm
    End Function

    Public Function grup() As List(Of ModelRekamMedis)
        dtSet.Reset()
        dtSet.ReadXml(New XmlNodeReader(service.selectall()))

        modellrm = (From row As DataRow In dtSet.Tables(0).AsEnumerable()
                    Let id_pasien = row.Field(Of String)("id_pasien")
                    Group row By id_pasien Into rm = Group
                    Select New ModelRekamMedis() With
                         {
                             .id_pasien = rm.First().Field(Of String)("id_pasien").ToString,
                             .pasien = datapsn.selectbyid(.id_pasien)
                         }
                     ).ToList

        Return modellrm
    End Function
End Class
