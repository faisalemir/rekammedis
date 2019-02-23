Public Class ModelRekamObat
    Private Property _id_rm As String
    Private Property _id_obat As String
    Private Property _jumlah As Integer
    Private Property _obat As ModelObat

    Public Property id_rm() As String
        Set(value As String)
            _id_rm = value
        End Set
        Get
            Return _id_rm
        End Get
    End Property

    Public Property id_obat() As String
        Set(value As String)
            _id_obat = value
        End Set
        Get
            Return _id_obat
        End Get
    End Property

    Public Property jumlah() As Integer
        Set(value As Integer)
            _jumlah = value
        End Set
        Get
            Return _jumlah
        End Get
    End Property

    Public Property obat() As ModelObat
        Set(value As ModelObat)
            _obat = value
        End Set
        Get
            Return _obat
        End Get
    End Property
End Class
