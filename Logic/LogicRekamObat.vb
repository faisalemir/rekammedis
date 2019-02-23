Imports Model
Imports Data

Public Class LogicRekamObat
    Dim dataro As New DataRekamObat

    Public Function insert(ByVal modelro As ModelRekamObat) As Boolean
        Return dataro.insert(modelro)
    End Function

    Public Function update(ByVal modelro As ModelRekamObat) As Boolean
        Return dataro.update(modelro)
    End Function

    Public Function delete(ByVal modelro As ModelRekamObat) As Boolean
        Return dataro.delete(modelro)
    End Function

    Public Function selectall() As List(Of ModelRekamObat)
        Return dataro.selectall()
    End Function

    Public Function selectbyid(ByVal id_rm As String, ByVal id_obat As String) As ModelRekamObat
        Return dataro.selectbyid(id_rm, id_obat)
    End Function

    Public Function search(ByVal id As String) As List(Of ModelRekamObat)
        Return dataro.search(id)
    End Function
End Class
