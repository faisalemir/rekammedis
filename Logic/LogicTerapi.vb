Imports Model
Imports Data

Public Class LogicTerapi
    Dim datatp As New DataTerapi

    Public Function selectall() As List(Of ModelTerapi)
        Return datatp.selectall()
    End Function

    Public Function selectbyid(ByVal id As String) As ModelTerapi
        Return datatp.selectbyid(id)
    End Function

    Public Function search(ByVal kata As String) As List(Of ModelTerapi)
        Return datatp.search(kata)
    End Function
End Class
