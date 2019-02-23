Public Class ModelRekamMedis
    Private Property _id_rm As String
    Private Property _id_pasien As String
    Private Property _id_reg As String
    Private Property _id_kondisi As String
    Private Property _stole As String
    Private Property _respiratory As String
    Private Property _suhu As Integer
    Private Property _nadi As Integer
    Private Property _berat As Integer
    Private Property _tinggi As Integer
    Private Property _anamnesia As String
    Private Property _pemeriksaan_fisik As String
    Private Property _keadaan As String
    Private Property _tanggal As Date
    Private Property _kondisi As New ModelKondisi
    Private Property _pasien As New ModelPasien

    Public Property id_rm() As String
        Set(value As String)
            _id_rm = value
        End Set
        Get
            Return _id_rm
        End Get
    End Property

    Public Property id_pasien() As String
        Set(value As String)
            _id_pasien = value
        End Set
        Get
            Return _id_pasien
        End Get
    End Property

    Public Property id_reg() As String
        Set(value As String)
            _id_reg = value
        End Set
        Get
            Return _id_reg
        End Get
    End Property

    Public Property id_kondisi() As String
        Set(value As String)
            _id_kondisi = value
        End Set
        Get
            Return _id_kondisi
        End Get
    End Property

    Public Property stole() As String
        Set(value As String)
            _stole = value
        End Set
        Get
            Return _stole
        End Get
    End Property

    Public Property respiratory() As Integer
        Set(value As Integer)
            _respiratory = value
        End Set
        Get
            Return _respiratory
        End Get
    End Property

    Public Property suhu() As Integer
        Set(value As Integer)
            _suhu = value
        End Set
        Get
            Return _suhu
        End Get
    End Property

    Public Property nadi() As Integer
        Set(value As Integer)
            _nadi = value
        End Set
        Get
            Return _nadi
        End Get
    End Property

    Public Property berat() As Integer
        Set(value As Integer)
            _berat = value
        End Set
        Get
            Return _berat
        End Get
    End Property

    Public Property tinggi() As Integer
        Set(value As Integer)
            _tinggi = value
        End Set
        Get
            Return _tinggi
        End Get
    End Property

    Public Property anamnesia() As String
        Set(value As String)
            _anamnesia = value
        End Set
        Get
            Return _anamnesia
        End Get
    End Property

    Public Property tanggal() As Date
        Set(value As Date)
            _tanggal = value
        End Set
        Get
            Return _tanggal
        End Get
    End Property

    Public Property kondisi() As ModelKondisi
        Set(value As ModelKondisi)
            _kondisi = value
        End Set
        Get
            Return _kondisi
        End Get
    End Property

    Public Property pasien() As ModelPasien
        Set(value As ModelPasien)
            _pasien = value
        End Set
        Get
            Return _pasien
        End Get
    End Property
End Class
