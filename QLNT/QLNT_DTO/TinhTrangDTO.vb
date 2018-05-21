Public Class TinhTrangDTO
    Private strMaTinhTrang As String
    Private strTenTinhTrang As String
    Public Sub New()
    End Sub
    Public Sub New(strMaTinhTrang As String, strTenTinhTrang As String)
        Me.strMaTinhTrang = strMaTinhTrang
        Me.strTenTinhTrang = strTenTinhTrang
    End Sub
End Class
