Public Class ModelRekamTerapi
    Private Property _id_rm As String
    Private Property _id_terapi As String
    Private Property _terapi As ModelTerapi

    Public Property id_rm() As String
        Set(value As String)
            _id_rm = value
        End Set
        Get
            Return _id_rm
        End Get
    End Property

    Public Property id_terapi() As String
        Set(value As String)
            _id_terapi = value
        End Set
        Get
            Return _id_terapi
        End Get
    End Property

    Public Property terapi() As ModelTerapi
        Set(value As ModelTerapi)
            _terapi = value
        End Set
        Get
            Return _terapi
        End Get
    End Property
End Class
