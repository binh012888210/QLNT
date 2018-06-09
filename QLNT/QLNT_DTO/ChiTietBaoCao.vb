Public Class ChiTietBaoCao
    Private strMaChiTietBaoCao As String
    Private strMaPhieuGhiNhan As String
    Private strMaBaoCao As String

    Public Property StrMaChiTietBaoCao1 As String
        Get
            Return strMaChiTietBaoCao
        End Get
        Set(value As String)
            strMaChiTietBaoCao = value
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

    Public Property StrMaBaoCao1 As String
        Get
            Return strMaBaoCao
        End Get
        Set(value As String)
            strMaBaoCao = value
        End Set
    End Property

    Public Sub New()
    End Sub
    Public Sub New(strMaChiTietBaoCao As String, strMaPhieuGhiNhan As String, strMaBaoCao As String)
        Me.strMaChiTietBaoCao = strMaChiTietBaoCao
        Me.strMaPhieuGhiNhan = strMaPhieuGhiNhan
        Me.strMaBaoCao = strMaBaoCao
    End Sub
End Class
