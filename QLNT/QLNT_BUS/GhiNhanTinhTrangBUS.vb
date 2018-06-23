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
    Public Function buildMSGN(ByRef nextMsgn As String) As Result
        Return gnttDAL.buildMSGN(nextMsgn)
    End Function
    Public Function insert(ghinhan As GhiNhanTinhTrangDTO) As Result
        Return gnttDAL.insert(ghinhan)
    End Function
    Public Function updatetByID(ghinhan As GhiNhanTinhTrangDTO) As Result
        Return gnttDAL.updatetByID(ghinhan)
    End Function
    Public Function deleteByID(strMaPhieuGhiNhan As String) As Result
        Return gnttDAL.deleteByID(strMaPhieuGhiNhan)
    End Function
    Public Function deleteByMaTreEm(strMaTreEm As String) As Result
        Return gnttDAL.deleteByMaTreEm(strMaTreEm)
    End Function
    Public Function selectALL(ByRef listGhiNhan As List(Of GhiNhanTinhTrangDTO)) As Result
        Return gnttDAL.selectALL(listGhiNhan)
    End Function
    Public Function selectALLByMaTreEm(strMaTreEm As String, ByRef listGhiNhan As List(Of GhiNhanTinhTrangDTO)) As Result
        Return gnttDAL.selectALLByMaTreEm(strMaTreEm, listGhiNhan)
    End Function
End Class
