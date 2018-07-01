Imports QLNT_DAL
Imports QLNT_DTO
Imports Utility

Public Class ChiTietBaoCaoBUS
    Private ctbcDAL As ChiTietBaoCaoDAL
    Public Sub New()
        ctbcDAL = New ChiTietBaoCaoDAL()
    End Sub
    Public Sub New(connectionString As String)
        ctbcDAL = New ChiTietBaoCaoDAL(connectionString)
    End Sub
    Public Function selectALL(ByRef listGhiNhan As List(Of ChiTietBaoCaoDTO)) As Result
        Return ctbcDAL.selectALL(listGhiNhan)
    End Function
    Public Function buildMctbc(ByRef nextMctbc As String) As Result 'ex: 290001
        Return ctbcDAL.buildMctbc(nextMctbc)
    End Function
    Public Function selectByBaoCaoChiTietNull(ByRef listBaoCaoChiTiet As List(Of GhiNhanTinhTrangDTO)) As Result
        Return ctbcDAL.selectByBaoCaoChiTietNull(listBaoCaoChiTiet)
    End Function
    Public Function insert(chitietbaocao As ChiTietBaoCaoDTO) As Result
        Return ctbcDAL.insert(chitietbaocao)
    End Function
    Public Function getCTBCByMaCTBC(strMaPhieuGhiNhan As String, ByRef ctbcInfo As ChiTietBaoCaoDTO) As Result
        Return ctbcDAL.getCTBCByMaCTBC(strMaPhieuGhiNhan, ctbcInfo)
    End Function
    Public Function deleteByID(strMaChiTietBaoCao As String) As Result
        Return ctbcDAL.deleteByID(strMaChiTietBaoCao)
    End Function
    ' Public Function updatetByID(strMaChiTietBaoCao As String, chitietbaocao As ChiTietBaoCaoDTO) As Result
    Public Function updatetByID(chitietbaocao As ChiTietBaoCaoDTO) As Result
        Return ctbcDAL.updatetByID(chitietbaocao)
    End Function
    Public Function GetGhiNhanByMaCTBC(strMaChiTietBaoCao As String, ctbcInfo As ChiTietBaoCaoDTO)
        Return ctbcDAL.getCTBCByMaCTBC(strMaChiTietBaoCao, ctbcInfo)
    End Function
    Public Function selectMbcNull(ByRef listbaocao As List(Of ChiTietBaoCaoDTO)) As Result
        Return ctbcDAL.selectMbcNull(listbaocao)
    End Function
End Class
