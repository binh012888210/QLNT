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
    Public Function ageMax(date1 As Date) As Boolean
        Dim query As String = String.Empty
        query &= "SELECT [TuoiToiDa] "
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
                If reader.HasRows = True Then
                    While reader.Read()
                        max = reader("TuoiToiDa")
                    End While
                End If
                Dim date2 = Date.Now
                If ((date2.Year - date1.Year) > max) Then
                    Return False
                Else
                    Return True
                End If
            End Using
        End Using
    End Function
    Public Function ageMin(date1 As Date) As Boolean
        Dim query As String = String.Empty
        query &= "SELECT [TuoiToiTieu] "
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
                Dim min As Integer
                min = Nothing
                If reader.HasRows = True Then
                    While reader.Read()
                        min = reader("TuoiToiTieu")
                    End While
                End If
                Dim date2 = Date.Now
                If ((date2.Year - date1.Year) < min) Then
                    Return False
                Else
                    Return True
                End If
            End Using
        End Using
    End Function
End Class
