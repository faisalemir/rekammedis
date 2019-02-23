Imports Model
Imports System.Xml

Public Class DataRekamTerapi
    Private service As New RekamTerapi.RekamTerapi
    Private modelltr As List(Of ModelRekamTerapi)
    Private modelrtr As New ModelRekamTerapi
    Private datater As New DataTerapi

    Private Function new_dtSet(ByVal modelrt As ModelRekamTerapi) As DataSet
        Dim dtSet As DataSet = New DataSet()
        Dim dtTable As DataTable = New DataTable()
        With dtTable
            .Columns.Add("id_rm")
            .Columns.Add("id_terapi")
            .Columns.Add("jumlah")
            .Rows.Add(modelrt.id_rm, modelrt.id_terapi)
        End With
        dtSet.Tables.Add(dtTable)
        Return dtSet
    End Function

    Public Function insert(ByVal modelrt As ModelRekamTerapi) As Boolean
        Return service.insert(new_dtSet(modelrt))
    End Function

    Public Function update(ByVal modelrt As ModelRekamTerapi) As Boolean
        service.insert(new_dtSet(modelrt))
        Return True
    End Function

    Public Function delete(ByVal modelrt As ModelRekamTerapi) As Boolean
        service.delete(new_dtSet(modelrt))
        Return True
    End Function

    Public Function selectall() As List(Of ModelRekamTerapi)
        dtSet.Reset()
        dtSet.ReadXml(New XmlNodeReader(service.selectall()))

        modelltr = (From row As DataRow In dtSet.Tables(0).Rows
                  Select New ModelRekamTerapi() With
                         {
                             .id_rm = row("id_rm").ToString,
                             .id_terapi = row("id_terapi").ToString,
                             .terapi = datater.selectbyid(.id_terapi)
                         }
                     ).ToList

        Return modelltr
    End Function

    Public Function selectbyid(ByVal rm As String, ByVal ob As String) As ModelRekamTerapi
        dtSet.Reset()
        dtSet.ReadXml(New XmlNodeReader(service.selectall()))

        If dtSet.Tables.Count > 0 Then
            dtRows = dtSet.Tables(0).Select("id_rm = '" + rm + "' And id_obat = '" + ob + "'")

            If dtRows.Count > 0 Then
                For Each row As DataRow In dtRows
                    With modelrtr
                        .id_rm = row("id_rm").ToString
                        .id_terapi = row("id_terapi").ToString
                        .terapi = datater.selectbyid(.id_terapi)
                    End With
                Next
            End If
        End If
        Return modelrtr
    End Function

    Public Function search(ByVal kata As String) As List(Of ModelRekamTerapi)
        dtSet.Reset()
        dtSet.ReadXml(New XmlNodeReader(service.selectall()))
        dtRows = dtSet.Tables(0).Select("id_rm LIKE '%" + kata + "%'")

        modelltr = (From row As DataRow In dtRows
                  Select New ModelRekamTerapi() With
                         {
                             .id_rm = row("id_rm").ToString,
                             .id_terapi = row("id_terapi").ToString,
                             .terapi = datater.selectbyid(.id_terapi)
                         }
                     ).ToList

        Return modelltr
    End Function

End Class
