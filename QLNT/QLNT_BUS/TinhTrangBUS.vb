Imports QLNT_DAL
Imports QLNT_DTO
Imports Utility

Public Class TinhTrangBUS
    Private ttDAL As TinhTrangDAL
    Public Sub New()
        ttDAL = New TinhTrangDAL()
    End Sub
    Public Sub New(connectionString As String)
        ttDAL = New TinhTrangDAL(connectionString)
    End Sub
    Public Function getTinhTrangByMaTinhTrang(strTinhTrang As String, ByRef tinhTrang As TinhTrangDTO) As Result
        Return ttDAL.getTinhTrangByMaTinhTrang(strTinhTrang, tinhTrang)
    End Function
    Public Function selectALL(ByRef listTinhTrang As List(Of TinhTrangDTO)) As Result
        Return ttDAL.selectALL(listTinhTrang)
    End Function
    Public Function update(tt As TinhTrangDTO) As Result
        Return ttDAL.update(tt)
    End Function
End Class
