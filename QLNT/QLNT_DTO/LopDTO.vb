Public Class LopDTO
    Private strMaLop As String
    Private strTenLop As String
    Private strMaKhoi As String

    Public Property StrMaLop1 As String
        Get
            Return strMaLop
        End Get
        Set(value As String)
            strMaLop = value
        End Set
    End Property

    Public Property StrTenLop1 As String
        Get
            Return strTenLop
        End Get
        Set(value As String)
            strTenLop = value
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
    Public Sub New(strMaLop As String, strTenLop As String, strMaKhoi As String)
        Me.strMaLop = strMaLop
        Me.strTenLop = strTenLop
        Me.strMaKhoi = strMaKhoi
    End Sub
End Class
