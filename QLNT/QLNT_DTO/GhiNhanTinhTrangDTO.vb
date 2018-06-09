Public Class GhiNhanTinhTrangDTO
    Private strMaPhieuGhiNhan As String
    Private strMaTreEm As String
    Private strMaTinhTrang As String
    Private dateNgayGhiNhan As String
    Private strMaKhoi As String

    Public Property StrMaTreEm1 As String
        Get
            Return strMaTreEm
        End Get
        Set(value As String)
            strMaTreEm = value
        End Set
    End Property

    Public Property StrMaTinhTrang1 As String
        Get
            Return strMaTinhTrang
        End Get
        Set(value As String)
            strMaTinhTrang = value
        End Set
    End Property

    Public Property DateNgayGhiNhan1 As String
        Get
            Return dateNgayGhiNhan
        End Get
        Set(value As String)
            dateNgayGhiNhan = value
        End Set
    End Property

    Public Property StrMaKhoi1 As String
        Get
            Return strMaKhoi
        End Get
        Set(value As String)
            strMaKhoi = value
        End Set
    End Property

    Public Property StrMaPhieuGhiNhan1 As String
        Get
            Return strMaPhieuGhiNhan
        End Get
        Set(value As String)
            strMaPhieuGhiNhan = value
        End Set
    End Property

    Public Sub New()
    End Sub
    Public Sub New(strMaPhieuGhiNhan As String, strMaTreEm As String, strMaTinhTrang As String, dateNgayGhiNhan As String, strMaKhoi As String)
        Me.strMaPhieuGhiNhan = strMaPhieuGhiNhan
        Me.strMaTreEm = strMaTreEm
        Me.strMaTinhTrang = strMaTinhTrang
        Me.dateNgayGhiNhan = dateNgayGhiNhan
        Me.strMaKhoi = strMaKhoi
    End Sub
End Class
