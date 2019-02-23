Public Class ModelPasien
    Private Property _id_pasien As String
    Private Property _nama As String
    Private Property _alamat As String
    Private Property _ttl As Date
    Private Property _telp As String
    Private Property _jk As String

    Public Property id_pasien() As String
        Set(value As String)
            _id_pasien = value
        End Set
        Get
            Return _id_pasien
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

    Public Property alamat() As String
        Set(value As String)
            _alamat = value
        End Set
        Get
            Return _alamat
        End Get
    End Property

    Public Property ttl() As Date
        Set(value As Date)
            _ttl = value
        End Set
        Get
            Return _ttl
        End Get
    End Property

    Public Property telp() As String
        Set(value As String)
            _telp = value
        End Set
        Get
            Return _telp
        End Get
    End Property

    Public Property jk() As String
        Set(value As String)
            _jk = value
        End Set
        Get
            Return _jk
        End Get
    End Property
End Class
