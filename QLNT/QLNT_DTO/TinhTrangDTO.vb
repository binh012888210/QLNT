Public Class TinhTrangDTO
    Private strMaTinhTrang As String
    Private strTenTinhTrang As String
    Public Sub New()
    End Sub
    Public Sub New(strMaTinhTrang As String, strTenTinhTrang As String)
        Me.strMaTinhTrang = strMaTinhTrang
        Me.strTenTinhTrang = strTenTinhTrang
    End Sub

    Public Property StrMaTinhTrang1 As String
        Get
            Return strMaTinhTrang
        End Get
        Set(value As String)
            strMaTinhTrang = value
        End Set
    End Property

    Public Property StrTenTinhTrang1 As String
        Get
            Return strTenTinhTrang
        End Get
        Set(value As String)
            strTenTinhTrang = value
        End Set
    End Property
End Class
