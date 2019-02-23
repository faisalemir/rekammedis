Public Class ModelKondisi
    Private Property _id_kondisi As String
    Private Property _kondisi As String

    Public Property id_kondisi() As String
        Set(value As String)
            _id_kondisi = value
        End Set
        Get
            Return _id_kondisi
        End Get
    End Property

    Public Property kondisi() As String
        Set(value As String)
            _kondisi = value
        End Set
        Get
            Return _kondisi
        End Get
    End Property

End Class
