Imports Model
Imports System.Xml

Public Class DataKondisi
    Private service As New Kondisi.Kondisi
    Private modellkn As List(Of ModelKondisi)
    Private modelkon As New ModelKondisi

    Private Function new_dtSet(ByVal modelkk As ModelKondisi) As DataSet
        Dim dtSet As DataSet = New DataSet()
        Dim dtTable As DataTable = New DataTable()
        With dtTable
            .Columns.Add("id_kondisi")
            .Columns.Add("kondisi")
            .Rows.Add(modelkk.id_kondisi, modelkk.kondisi)
        End With
        dtSet.Tables.Add(dtTable)
        Return dtSet
    End Function

    Public Function insert(ByVal modelkk As ModelKondisi) As Boolean
        Return service.insert(new_dtSet(modelkk))
    End Function

    Public Function update(ByVal modelkk As ModelKondisi) As Boolean
        service.update(new_dtSet(modelkk))
        Return True
    End Function

    Public Function delete(ByVal modelkk As ModelKondisi) As Boolean
        service.delete(new_dtSet(modelkk))
        Return True
    End Function

    Public Function selectall() As List(Of ModelKondisi)
        dtSet.Reset()
        dtSet.ReadXml(New XmlNodeReader(service.selectall()))
        modellkn = (From row As DataRow In dtSet.Tables(0).Rows
                  Select New ModelKondisi() With
                         {
                             .id_kondisi = row("id_kondisi").ToString,
                             .kondisi = row("kondisi").ToString
                         }
                     ).ToList

        Return modellkn
    End Function

    Public Function selectbyid(ByVal id As String) As ModelKondisi
        dtSet.Reset()
        dtSet.ReadXml(New XmlNodeReader(service.selectall()))

        If dtSet.Tables.Count > 0 Then
            dtRows = dtSet.Tables(0).Select("id_kondisi = '" + id + "'")

            If dtRows.Count > 0 Then
                For Each row As DataRow In dtRows
                    With modelkon
                        .id_kondisi = row("id_kondisi").ToString
                        .kondisi = row("kondisi").ToString
                    End With
                Next
            End If
        End If
        Return modelkon
    End Function

    Public Function search(ByVal kata As String) As List(Of ModelKondisi)
        Dim rt As New RekamTerapi.RekamTerapi
        Dim ro As New RekamObat.RekamObat

        service.database()
        rt.database()
        ro.database()

        dtSet.Reset()
        dtSet.ReadXml(New XmlNodeReader(service.selectall()))
        dtRows = dtSet.Tables(0).Select("kondisi LIKE '%" + kata + "%'")
        modellkn = (From row As DataRow In dtRows
                  Select New ModelKondisi() With
                         {
                             .id_kondisi = row("id_kondisi").ToString,
                             .kondisi = row("kondisi").ToString
                         }
                     ).ToList

        Return modellkn
    End Function

End Class
