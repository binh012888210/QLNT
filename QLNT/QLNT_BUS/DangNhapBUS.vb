Imports QLNT_DAL
Imports QLNT_DTO
Imports Utility

Public Class DangNhapBUS
    Private dnDAL As DangNhapDAL
    Public Sub New()
        dnDAL = New DangNhapDAL()
    End Sub
    Public Function SearchInformation(strTenDangNhap As String, strMatKhau As String, ByRef checkInfo As Boolean) As Result
        Return dnDAL.SearchInformation(strTenDangNhap, strMatKhau, checkInfo)
    End Function
End Class
