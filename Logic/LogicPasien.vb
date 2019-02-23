Imports Model
Imports Data

Public Class LogicPasien
    Dim dataps As New DataPasien

    Public Function selectall() As List(Of ModelPasien)
        Return dataps.selectall()
    End Function

    Public Function selectbyid(ByVal id As String) As ModelPasien
        Return dataps.selectbyid(id)
    End Function

    Public Function search(ByVal key As String) As List(Of ModelPasien)
        Return dataps.search(key)
    End Function
End Class
