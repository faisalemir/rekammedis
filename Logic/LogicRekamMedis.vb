Imports Model
Imports Data

Public Class LogicRekamMedis
    Dim datarm As New DataRekamMedis

    Public Function insert(ByVal modelrm As ModelRekamMedis) As Boolean
        Return datarm.insert(modelrm)
    End Function

    Public Function update(ByVal modelrm As ModelRekamMedis) As Boolean
        Return datarm.update(modelrm)
    End Function

    Public Function delete(ByVal modelrm As ModelRekamMedis) As Boolean
        Return datarm.delete(modelrm)
    End Function

    Public Function selectall() As List(Of ModelRekamMedis)
        Return datarm.selectall()
    End Function

    Public Function selectbyid(ByVal id As String) As ModelRekamMedis
        Return datarm.selectbyid(id)
    End Function

    Public Function search(ByVal kata As String) As List(Of ModelRekamMedis)
        Return datarm.search(kata)
    End Function

    Public Function grup() As List(Of ModelRekamMedis)
        Return datarm.grup()
    End Function
End Class
