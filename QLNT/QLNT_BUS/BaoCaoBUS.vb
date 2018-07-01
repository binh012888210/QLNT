Imports QLNT_DAL
Imports QLNT_DTO
Imports Utility

Public Class BaoCaoBUS
    Private bcDAL As BaoCaoDAL
    Public Sub New()
        bcDAL = New BaoCaoDAL()
    End Sub
    Public Sub New(connectionString As String)
        bcDAL = New BaoCaoDAL(connectionString)
    End Sub
    Public Function buildMbc(ByRef nextMbc As String) As Result 'ex: 0002\
        Return bcDAL.buildMbc(nextMbc)
    End Function
    Public Function insert(baocao As BaoCaoDTO) As Result
        Return bcDAL.insert(baocao)
    End Function
    Public Function checkMaBaoCao(strMaBaoCao As String) As Result
        Return bcDAL.checkMaBaoCao(strMaBaoCao)
    End Function
    Public Function buildMbc2(ByRef nextMbc As String) As Result 'ex: 290001
        Return bcDAL.buildMbc2(nextMbc)
    End Function
End Class
