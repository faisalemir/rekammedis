Public Class ModelTerapi
    Private Property _id_terapi As String
    Private Property _id_tarif As String
    Private Property _terapi As String

    Public Property id_terapi() As String
        Set(value As String)
            _id_terapi = value
        End Set
        Get
            Return _id_terapi
        End Get
    End Property

    Public Property id_tarif() As String
        Set(value As String)
            _id_tarif = value
        End Set
        Get
            Return _id_tarif
        End Get
    End Property

    Public Property terapi() As String
        Set(value As String)
            _terapi = value
        End Set
        Get
            Return _terapi
        End Get
    End Property
End Class
