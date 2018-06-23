Imports System.Configuration
Imports System.Data.SqlClient
Imports QLNT_DTO
Imports Utility
Public Class TinhTrangDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub
    Public Function selectALL(ByRef listTinhTrang As List(Of TinhTrangDTO)) As Result

        Dim query As String = String.Empty
        query &= "SELECT * "
        query &= "FROM [tblTinhTrang]"

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
                    listTinhTrang.Clear()
                    If reader.HasRows = True Then
                        While reader.Read()
                            listTinhTrang.Add(New TinhTrangDTO(reader("MaTinhTrang"), reader("TenTinhTrang")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả tình trạng không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function getTinhTrangByMaTinhTrang(strTinhTrang As String, ByRef tinhTrang As TinhTrangDTO) As Result

        Dim query As String = String.Empty
        query &= "SELECT * "
        query &= "FROM [tblTinhTrang] WHERE [MaTinhTrang]=@matinhtrang "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@matinhtrang", strTinhTrang)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        While reader.Read()
                            tinhTrang = (New TinhTrangDTO(reader("MaTinhTrang"), reader("TenTinhTrang")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy thông tin khối không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function update(tt As TinhTrangDTO) As Result
        Dim query As String = String.Empty
        query &= "UPDATE [tblTinhTrang] "
        query &= "SET [MaTinhTrang] = @matinhtrang, [TenTinhTrang] = @tentinhtrang  "
        query &= "Where [MaTinhTrang] = @matinhtrang"
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@matinhtrang", tt.StrMaTinhTrang1)
                    .Parameters.AddWithValue("@tentinhtrang", tt.StrTenTinhTrang1)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Cập nhật ghi nhận không thành công", ex.StackTrace)
                End Try
            End Using
        End Using

        Return New Result(True) ' thanh cong
    End Function
End Class
