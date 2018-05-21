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
End Class
