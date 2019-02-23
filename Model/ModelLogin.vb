Public Class ModelLogin
    Private Property _id_login As String
    Private Property _nama As String
    Private Property _pass As String
    Private Property _akses As String

    Public Property id_login() As String
        Set(value As String)
            _id_login = value
        End Set
        Get
            Return _id_login
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

    Public Property pass() As String
        Set(value As String)
            _pass = value
        End Set
        Get
            Return _pass
        End Get
    End Property

    Public Property akses() As String
        Set(value As String)
            _akses = value
        End Set
        Get
            Return _akses
        End Get
    End Property

End Class
