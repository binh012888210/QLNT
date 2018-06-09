Imports QLNT_DAL
Imports QLNT_DTO
Imports Utility

Public Class LopBUS
    Private lpDAL As LopDAL
    Public Sub New()
        lpDAL = New LopDAL()
    End Sub
    Public Sub New(connectionString As String)
        lpDAL = New LopDAL(connectionString)
    End Sub
    Public Function selectALL(ByRef listLop As List(Of KhoiDTO)) As Result
        Return lpDAL.selectALL(listLop)
    End Function
    Public Function selectALL_ByMaNamHoc(iMaKhoi As Integer, ByRef listLop As List(Of LopDTO)) As Result
        Return lpDAL.selectALL_ByMaNamHoc(iMaKhoi, listLop)
    End Function
End Class
