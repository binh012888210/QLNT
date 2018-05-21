Imports QLNT_DAL
Imports QLNT_DTO
Imports Utility
Public Class GhiNhanTinhTrangBUS
    Private gnttDAL As GhiNhanTinhTrangDAL
    Public Sub New()
        gnttDAL = New GhiNhanTinhTrangDAL()
    End Sub
    Public Sub New(connectionString As String)
        gnttDAL = New GhiNhanTinhTrangDAL(connectionString)
    End Sub
End Class
