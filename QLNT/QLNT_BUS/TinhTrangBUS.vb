Imports QLNT_DAL
Imports QLNT_DTO
Imports Utility

Public Class TinhTrangBUS
    Private ttBUS As TinhTrangBUS
    Public Sub New()
        ttBUS = New TinhTrangBUS()
    End Sub
    Public Sub New(connectionString As String)
        ttBUS = New TinhTrangBUS(connectionString)
    End Sub

End Class
