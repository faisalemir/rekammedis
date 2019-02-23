Imports Model
Imports Data

Public Class LogicObat
    Dim dataob As New DataObat

    Public Function selectall() As List(Of ModelObat)
        Return dataob.selectall()
    End Function

    Public Function selectbyid(ByVal id As String) As ModelObat
        Return dataob.selectbyid(id)
    End Function

    Public Function search(ByVal key As String) As List(Of ModelObat)
        Return dataob.search(key)
    End Function
End Class
