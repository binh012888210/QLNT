Public Class BaoCaoDTO
    Private strMaBaoCao As String
    Private dateNgayBaoCao As String
    Private strMaKhoi As String

    Public Property StrMaBaoCao1 As String
        Get
            Return strMaBaoCao
        End Get
        Set(value As String)
            strMaBaoCao = value
        End Set
    End Property

    Public Property DateNgayBaoCao1 As String
        Get
            Return dateNgayBaoCao
        End Get
        Set(value As String)
            dateNgayBaoCao = value
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

    Public Sub New()
    End Sub
    Public Sub New(strMaBaoCao As String, dateNgayBaoCao As String, strMaKhoi As String)
        Me.strMaBaoCao = strMaBaoCao
        Me.dateNgayBaoCao = dateNgayBaoCao
        Me.strMaKhoi = strMaKhoi
    End Sub
End Class
