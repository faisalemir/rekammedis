Public Class ModelObat
    Private Property _id_obat As String
    Private Property _nama As String
    Private Property _stok As Integer
    Private Property _jenis As String
    Private Property _keterangan As String
    Private Property _harga As Decimal

    Public Property id_obat() As String
        Set(value As String)
            _id_obat = value
        End Set
        Get
            Return _id_obat
        End Get
    End Property

    Public Property nama() As String
        Set(value As String)
            _nama = value
        End Set
        Get
            Return _nama
        End Get
    End Property

    Public Property stok() As Integer
        Set(value As Integer)
            _stok = value
        End Set
        Get
            Return _stok
        End Get
    End Property

    Public Property jenis() As String
        Set(value As String)
            _jenis = value
        End Set
        Get
            Return _jenis
        End Get
    End Property

    Public Property keterangan() As String
        Set(value As String)
            _keterangan = value
        End Set
        Get
            Return _keterangan
        End Get
    End Property

    Public Property harga() As Decimal
        Set(value As Decimal)
            _harga = value
        End Set
        Get
            Return _harga
        End Get
    End Property

End Class
