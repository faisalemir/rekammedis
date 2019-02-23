Imports Model
Imports Data

Public Class LogicRekamTerapi
    Dim datart As New DataRekamTerapi

    Public Function insert(ByVal modelrt As ModelRekamTerapi) As Boolean
        Return datart.insert(modelrt)
    End Function

    Public Function update(ByVal modelrt As ModelRekamTerapi) As Boolean
        Return datart.update(modelrt)
    End Function

    Public Function delete(ByVal modelrt As ModelRekamTerapi) As Boolean
        Return datart.delete(modelrt)
    End Function

    Public Function selectall() As List(Of ModelRekamTerapi)
        Return datart.selectall()
    End Function

    Public Function selectbyid(ByVal id_rm As String, ByVal id_terapi As String) As ModelRekamTerapi
        Return datart.selectbyid(id_rm, id_terapi)
    End Function

    Public Function search(ByVal id As String) As List(Of ModelRekamTerapi)
        Return datart.search(id)
    End Function
End Class
