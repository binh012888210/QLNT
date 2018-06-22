Imports QLNT_DAL
Imports QLNT_DTO
Imports Utility

Public Class KhoiBUS
    Private khDAL As KhoiDAL
    Public Sub New()
        khDAL = New KhoiDAL()
    End Sub
    Public Sub New(connectionString As String)
        khDAL = New KhoiDAL(connectionString)
    End Sub
    Public Function selectALL(ByRef listKhoi As List(Of KhoiDTO)) As Result
        Return khDAL.selectALL(listKhoi)
    End Function
End Class
