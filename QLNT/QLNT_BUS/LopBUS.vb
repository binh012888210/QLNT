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

End Class
