Imports System.Configuration
Imports System.Data.SqlClient
Imports QLNT_DTO
Imports Utility
Public Class ThamSoDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub
    Public Function ageCheck(date1 As Date) As Boolean
        Dim query As String = String.Empty
        query &= "SELECT [TuoiToiDa],[TuoiToiTieu] "
        query &= "FROM [tblThamSo] "
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                End With
                conn.Open()
                Dim reader As SqlDataReader
                reader = comm.ExecuteReader()
                Dim max As Integer
                max = Nothing
                Dim min As Integer
                min = Nothing
                If reader.HasRows = True Then
                    While reader.Read()
                        max = reader("TuoiToiDa")
                        min = reader("TuoiToiTieu")
                    End While
                End If
                Dim date2 = Date.Now
                If (((date2.Year - date1.Year) > max) Or ((date2.Year - date1.Year) < min)) Then
                    Return False
                Else
                    Return True
                End If
            End Using
        End Using
    End Function

    Public Function KiemTraSiSo(intSiSoLop As Integer) As Boolean
        Dim query As String = String.Empty
        query &= "SELECT [SoHocSinhToiDa] "
        query &= "FROM [tblThamSo] "
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                End With
                conn.Open()
                Dim reader As SqlDataReader
                reader = comm.ExecuteReader()
                Dim siSoToiDa As Integer
                siSoToiDa = Nothing
                If reader.HasRows = True Then
                    While reader.Read()
                        siSoToiDa = reader("SoHocSinhToiDa")
                    End While
                End If
                If (intSiSoLop < siSoToiDa + 1) Then
                    Return True
                Else
                    Return False
                End If
            End Using
        End Using
    End Function
End Class
