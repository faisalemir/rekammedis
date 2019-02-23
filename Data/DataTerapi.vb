Imports Model
Imports System.Xml

Public Class DataTerapi
    Private service As Other.OtherService = New Other.OtherService()
    Private modelltr As List(Of ModelTerapi)
    Private modelter As New ModelTerapi

    Public Function selectall() As List(Of ModelTerapi)
        dtSet.Reset()
        dtSet.ReadXml(New XmlNodeReader(service.terapi()))

        modelltr = (From row As DataRow In dtSet.Tables(0).Rows
                  Select New ModelTerapi() With
                         {
                             .id_terapi = row("id_terapi").ToString,
                             .id_tarif = row("id_tarif").ToString,
                             .terapi = row("terapi").ToString
                         }
                     ).ToList
        Return modelltr
    End Function

    Public Function selectbyid(ByVal id As String) As ModelTerapi
        dtSet.Reset()
        dtSet.ReadXml(New XmlNodeReader(service.terapi()))

        If dtSet.Tables.Count > 0 Then
            dtRows = dtSet.Tables(0).Select("id_terapi = '" + id + "'")

            If dtRows.Count > 0 Then
                For Each row As DataRow In dtRows
                    With modelter
                        .id_terapi = row("id_terapi").ToString
                        .id_tarif = row("id_terapi").ToString
                        .terapi = row("terapi")
                    End With
                Next
            End If
        End If
        Return modelter
    End Function

    Public Function search(ByVal kata As String) As List(Of ModelTerapi)
        dtSet.Reset()
        dtSet.ReadXml(New XmlNodeReader(service.terapi()))
        dtRows = dtSet.Tables(0).Select("terapi LIKE '%" + kata + "%'")

        modelltr = (From row As DataRow In dtRows
                  Select New ModelTerapi() With
                         {
                             .id_terapi = row("id_terapi").ToString,
                             .id_tarif = row("id_terapi").ToString,
                             .terapi = row("terapi")
                         }
                     ).ToList
        Return modelltr
    End Function
End Class
