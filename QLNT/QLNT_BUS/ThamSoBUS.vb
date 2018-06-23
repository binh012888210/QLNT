Imports QLNT_DAL
Imports QLNT_DTO
Imports Utility

Public Class ThamSoBUS
    Private tsDAL As ThamSoDAL
    Public Sub New()
        tsDAL = New ThamSoDAL()
    End Sub
    Public Sub New(connectionString As String)
        tsDAL = New ThamSoDAL(connectionString)
    End Sub
    Public Function ageCheck(date1 As Date) As Boolean
        Return tsDAL.ageCheck(date1)
    End Function
    Public Function KiemTraSiSo(intSiSoLop As Integer) As Boolean
        Return tsDAL.KiemTraSiSo(intSiSoLop)
    End Function
    Public Function update(ts As ThamSoDTO, text As String) As Result
        Return tsDAL.update(ts, text)
    End Function
    Public Function selectALL(ByRef listTinhTrang As List(Of ThamSoDTO)) As Result
        Return tsDAL.selectALL(listTinhTrang)
    End Function
    Public Function LoadSiSo(ByRef text As String) As Result
        Return tsDAL.LoadSiSo(text)
    End Function
End Class
