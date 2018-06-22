Imports System.Configuration
Imports System.Data.SqlClient
Imports QLNT_DTO
Imports Utility
Public Class KhoiDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub
    Public Function selectALL(ByRef listKhoi As List(Of KhoiDTO)) As Result

        Dim query As String = String.Empty
        query &= "SELECT [MaKhoi], [TenKhoi]"
        query &= "FROM [tblKhoi]"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    listKhoi.Clear()
                    If reader.HasRows = True Then
                        While reader.Read()
                            listKhoi.Add(New KhoiDTO(reader("MaKhoi"), reader("TenKhoi")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả khối không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
End Class
