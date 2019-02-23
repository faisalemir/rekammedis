Imports Model
Imports System.Xml

Public Class DataLogin
    Private service As New Other.OtherService
    Private kondisi As New Kondisi.Kondisi
    Private terapi As New RekamTerapi.RekamTerapi
    Private obat As New RekamObat.RekamObat
    Private medis As New RekamMedis.RekamMedis
    Private modellog As New ModelLogin

    Public Function Login(ByVal nama As String, ByVal pass As String) As ModelLogin
        dtSet.Reset()
        dtSet.ReadXml(New XmlNodeReader(service.Login(nama, pass)))

        If dtSet.Tables.Count > 0 Then
            If dtSet.Tables(0).Rows.Count > 0 Then
                With modellog
                    .id_login = dtSet.Tables(0).Rows(0)("id_login").ToString
                    .nama = dtSet.Tables(0).Rows(0)("nama").ToString
                    .pass = dtSet.Tables(0).Rows(0)("pass").ToString
                    .akses = dtSet.Tables(0).Rows(0)("akses").ToString
                End With
            End If
        End If
        Return modellog
    End Function

    Public Function Logout()
        kondisi.database()
        medis.database()
        terapi.database()
        obat.database()
        Return True
    End Function

End Class
