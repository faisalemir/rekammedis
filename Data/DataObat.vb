Imports Model
Imports System.Xml

Public Class DataObat
    Private service As Other.OtherService = New Other.OtherService()
    Private modellob As List(Of ModelObat)
    Private modelobt As New ModelObat

    Public Function selectall() As List(Of ModelObat)
        dtSet.Reset()
        dtSet.ReadXml(New XmlNodeReader(service.Obat()))

        modellob = (From row As DataRow In dtSet.Tables(0).Rows
                  Select New ModelObat() With
                         {
                             .id_obat = row("id_obat").ToString,
                             .nama = row("nama_obat").ToString,
                             .stok = row("stok_obat"),
                             .jenis = row("jenis").ToString,
                             .keterangan = row("keterangan").ToString,
                             .harga = row("harga")
                         }
                     ).ToList
        Return modellob
    End Function

    Public Function selectbyid(ByVal id As String) As ModelObat
        dtSet.Reset()
        dtSet.ReadXml(New XmlNodeReader(service.obat()))

        If dtSet.Tables.Count > 0 Then
            dtRows = dtSet.Tables(0).Select("id_obat = '" + id + "'")

            If dtRows.Count > 0 Then
                For Each row As DataRow In dtRows
                    With modelobt
                        .id_obat = row("id_obat").ToString
                        .nama = row("nama_obat").ToString
                        .stok = row("stok_obat")
                        .jenis = row("jenis").ToString
                        .keterangan = row("keterangan").ToString
                        .harga = row("harga")
                    End With
                Next
            End If
        End If
        Return modelobt
    End Function

    Public Function search(ByVal kata As String) As List(Of ModelObat)
        dtSet.Reset()
        dtSet.ReadXml(New XmlNodeReader(service.obat()))
        dtRows = dtSet.Tables(0).Select("nama_obat LIKE '%" + kata + "%'")

        modellob = (From row As DataRow In dtRows
                  Select New ModelObat() With
                         {
                             .id_obat = row("id_obat").ToString,
                             .nama = row("nama_obat").ToString,
                             .stok = row("stok_obat"),
                             .jenis = row("jenis").ToString,
                             .keterangan = row("keterangan").ToString,
                             .harga = row("harga")
                         }
                     ).ToList
        Return modellob
    End Function
End Class
