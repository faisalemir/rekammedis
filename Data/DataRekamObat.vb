Imports Model
Imports System.Xml

Public Class DataRekamObat
    Private service As New RekamObat.RekamObat
    Private modellro As List(Of ModelRekamObat)
    Private modelrbt As New ModelRekamObat
    Private dataobt As New DataObat

    Private Function new_dtSet(ByVal modelro As ModelRekamObat) As DataSet
        Dim dtSet As DataSet = New DataSet()
        Dim dtTable As DataTable = New DataTable()
        With dtTable
            .Columns.Add("id_rm")
            .Columns.Add("id_obat")
            .Columns.Add("jumlah")
            .Rows.Add(modelro.id_rm, modelro.id_obat, modelro.jumlah)
        End With
        dtSet.Tables.Add(dtTable)
        Return dtSet
    End Function

    Public Function insert(ByVal modelro As ModelRekamObat) As Boolean
        Return service.insert(new_dtSet(modelro))
    End Function

    Public Function update(ByVal modelro As ModelRekamObat) As Boolean
        service.update(new_dtSet(modelro))
        Return True
    End Function

    Public Function delete(ByVal modelro As ModelRekamObat) As Boolean
        service.delete(new_dtSet(modelro))
        Return True
    End Function

    Public Function selectall() As List(Of ModelRekamObat)
        dtSet.Reset()
        dtSet.ReadXml(New XmlNodeReader(service.selectall()))

        modellro = (From row As DataRow In dtSet.Tables(0).Rows
                  Select New ModelRekamObat() With
                         {
                             .id_rm = row("id_rm").ToString,
                             .id_obat = row("id_obat").ToString,
                             .jumlah = row("jumlah"),
                             .obat = dataobt.selectbyid(.id_obat)
                         }
                     ).ToList

        Return modellro
    End Function

    Public Function selectbyid(ByVal rm As String, ByVal ob As String) As ModelRekamObat
        dtSet.Reset()
        dtSet.ReadXml(New XmlNodeReader(service.selectall()))

        If dtSet.Tables.Count > 0 Then
            dtRows = dtSet.Tables(0).Select("id_rm = '" + rm + "' And id_obat = '" + ob + "'")

            If dtRows.Count > 0 Then
                For Each row As DataRow In dtRows
                    With modelrbt
                        .id_rm = row("id_rm").ToString
                        .id_obat = row("id_obat").ToString
                        .jumlah = row("jumlah")
                        .obat = dataobt.selectbyid(.id_obat)
                    End With
                Next
            End If
        End If
        Return modelrbt
    End Function

    Public Function search(ByVal kata As String) As List(Of ModelRekamObat)
        dtSet.Reset()
        dtSet.ReadXml(New XmlNodeReader(service.selectall()))
        dtRows = dtSet.Tables(0).Select("id_rm LIKE '%" + kata + "%'")

        modellro = (From row As DataRow In dtRows
                  Select New ModelRekamObat() With
                         {
                             .id_rm = row("id_rm").ToString,
                             .id_obat = row("id_obat").ToString,
                             .jumlah = row("jumlah"),
                             .obat = dataobt.selectbyid(.id_obat)
                         }
                     ).ToList

        Return modellro
    End Function
End Class
