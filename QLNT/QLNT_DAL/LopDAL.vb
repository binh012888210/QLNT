Imports System.Configuration
Imports System.Data.SqlClient
Imports QLNT_DTO
Imports Utility
Public Class LopDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub
    Public Function selectALL_ByKhoi(iMaKhoi As Integer, ByRef listLop As List(Of LopDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT [MaLop], [TenLop], [MaKhoi], [ThuTuLop] "
        query &= " FROM [tblLop]"
        query &= " WHERE "
        query &= " [MaKhoi] = @makhoi"
        query &= " ORDER BY "
        query &= " [ThuTuLop] ASC "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaKhoi", iMaKhoi)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listLop.Clear()
                        While reader.Read()
                            listLop.Add(New LopDTO(reader("MaLop"), reader("TenLop"), reader("MaKhoi"), reader("ThuTuLop")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy lớp không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function selectALL(ByRef listLop As List(Of KhoiDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT [MaLop], [TenLop], [MaKhoi], [ThuTuLop]"
        query &= " FROM [tblLop]"

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
                    listLop.Clear()
                    If reader.HasRows = True Then
                        While reader.Read()
                            listLop.Add(New KhoiDTO(reader("MaKhoi"), reader("TenKhoi")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả lớp không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
End Class
