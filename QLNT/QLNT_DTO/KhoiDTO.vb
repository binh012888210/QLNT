Public Class KhoiDTO
    Private strMaKhoi As String
    Private strTenKhoi As String
    Public Sub New()
    End Sub
    Public Sub New(strMaKhoi As String, strTenKhoi As String)
        Me.strMaKhoi = strMaKhoi
        Me.strTenKhoi = strTenKhoi
    End Sub

    Public Property StrMaKhoi1 As String
        Get
            Return strMaKhoi
        End Get
        Set(value As String)
            strMaKhoi = value
        End Set
    End Property

    Public Property StrTenKhoi1 As String
        Get
            Return strTenKhoi
        End Get
        Set(value As String)
            strTenKhoi = value
        End Set
    End Property
End Class
