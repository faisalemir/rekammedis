Imports Model
Imports Data

Public Class LogicKondisi
    Dim datakk As New DataKondisi

    Public Function insert(ByVal modelkk As ModelKondisi) As Boolean
        Return datakk.insert(modelkk)
    End Function

    Public Function update(ByVal modelkk As ModelKondisi) As Boolean
        Return datakk.update(modelkk)
    End Function

    Public Function delete(ByVal modelkk As ModelKondisi) As Boolean
        Return datakk.delete(modelkk)
    End Function

    Public Function selectall() As List(Of ModelKondisi)
        Return datakk.selectall()
    End Function

    Public Function selectbyid(ByVal id As String) As ModelKondisi
        Return datakk.selectbyid(id)
    End Function

    Public Function search(ByVal key As String) As List(Of ModelKondisi)
        Return datakk.search(key)
    End Function

End Class
