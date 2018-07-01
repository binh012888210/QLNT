Imports System.Configuration
Imports System.Data.SqlClient
Imports QLNT_DTO
Imports Utility
Public Class DangNhapDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub
    Public Function SearchInformation(strTenDangNhap As String, strMatKhau As String, ByRef checkInfo As Boolean) As Result
        Dim query As String = String.Empty
        query &= "SELECT *"
        query &= "FROM [tblAccount] WHERE [userID]=@TenDangNhap AND [userPassword]=@MatKhau"
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@TenDangNhap", strTenDangNhap)
                    .Parameters.AddWithValue("@MatKhau", strMatKhau)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        checkInfo = True
                    Else
                        checkInfo = False
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Kiểm tra thông tin đăng nhập không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
End Class