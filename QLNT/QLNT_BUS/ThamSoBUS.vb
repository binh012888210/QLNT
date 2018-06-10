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
End Class
