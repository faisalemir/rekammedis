Imports Model
Imports System.Xml

Public Class DataPasien
    Private service As Other.OtherService = New Other.OtherService()
    Private modellps As List(Of ModelPasien)
    Private modelpsn As New ModelPasien

    Public Function selectall() As List(Of ModelPasien)
        dtSet.Reset()
        dtSet.ReadXml(New XmlNodeReader(service.pasien()))

        modellps = (From row As DataRow In dtSet.Tables(0).Rows
                  Select New ModelPasien() With
                         {
                             .id_pasien = row("id_pasien").ToString,
                             .nama = row("nama_pasien").ToString,
                             .alamat = row("alamat_pasien"),
                             .ttl = row("tgl_lahir").ToString,
                             .telp = row("no_telp").ToString,
                             .jk = row("jk").ToString
                         }
                     ).ToList
        Return modellps
    End Function

    Public Function selectbyid(ByVal id As String) As ModelPasien
        dtSet.Reset()
        dtSet.ReadXml(New XmlNodeReader(service.pasien()))

        If dtSet.Tables.Count > 0 Then
            dtRows = dtSet.Tables(0).Select("id_pasien = '" + id + "'")

            If dtRows.Count > 0 Then
                For Each row As DataRow In dtRows
                    With modelpsn
                        .id_pasien = row("id_pasien").ToString
                        .nama = row("nama_pasien").ToString
                        .alamat = row("alamat_pasien")
                        .ttl = row("tgl_lahir").ToString
                        .telp = row("no_telp").ToString
                        .jk = row("jk").ToString
                    End With
                Next
            End If
        End If
        Return modelpsn
    End Function

    Public Function search(ByVal kata As String) As List(Of ModelPasien)
        dtSet.Reset()
        dtSet.ReadXml(New XmlNodeReader(service.pasien()))
        dtRows = dtSet.Tables(0).Select("nama_pasien LIKE '%" + kata + "%'")

        modellps = (From row As DataRow In dtRows
                  Select New ModelPasien() With
                         {
                             .id_pasien = row("id_pasien").ToString,
                             .nama = row("nama_pasien").ToString,
                             .alamat = row("alamat_pasien"),
                             .ttl = row("tgl_lahir").ToString,
                             .telp = row("no_telp").ToString,
                             .jk = row("jk").ToString
                         }
                     ).ToList
        Return modellps
    End Function
End Class
