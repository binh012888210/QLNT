Imports System.Configuration
Imports System.Data.SqlClient
Imports QLNT_DTO
Imports Utility
Public Class BaoCaoDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub
    Public Function buildMbc(ByRef nextMbc As String) As Result 'ex: 290001

        nextMbc = String.Empty
        nextMbc = "290000"

        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [MaBaoCao] "
        query &= "FROM [tblBaoCao] "
        query &= "ORDER BY [MaBaoCao] DESC "

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
                    Dim bcOnDB As String
                    bcOnDB = Nothing
                    If reader.HasRows = True Then
                        While reader.Read()
                            bcOnDB = reader("MaBaoCao")
                        End While
                    End If
                    If (bcOnDB <> Nothing) Then
                        If (bcOnDB.Length >= 6) Then
                            Dim v = bcOnDB
                            Dim convertDecimal = Convert.ToDecimal(v)
                            convertDecimal = convertDecimal + 1
                            Dim tmp = convertDecimal.ToString()
                            nextMbc = tmp
                        End If
                    End If
                Catch ex As Exception
                    conn.Close() ' that bai!!!
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tự động mã báo cáo kế tiếp không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function buildMbc2(ByRef nextMbc As String) As Result 'ex: 290001

        nextMbc = String.Empty
        nextMbc = "990000"

        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [MaBaoCao] "
        query &= "FROM [tblBaoCao] "
        query &= "ORDER BY [MaBaoCao] DESC "

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
                    Dim bcOnDB As String
                    bcOnDB = Nothing
                    If reader.HasRows = True Then
                        While reader.Read()
                            bcOnDB = reader("MaBaoCao")
                        End While
                    End If
                    If (bcOnDB <> Nothing) Then
                        If (bcOnDB.Length >= 6) Then
                            Dim v = bcOnDB
                            Dim convertDecimal = Convert.ToDecimal(v)
                            convertDecimal = convertDecimal + 1
                            Dim tmp = convertDecimal.ToString()
                            nextMbc = tmp
                        End If
                    End If
                Catch ex As Exception
                    conn.Close() ' that bai!!!
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tự động mã báo cáo kế tiếp không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function insert(baocao As BaoCaoDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblBaoCao] ([MaBaoCao], [NgayBaoCao], [MaKhoi]) "
        query &= "VALUES (@mabaocao, @ngaybaocao, @makhoi) "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@mabaocao", baocao.StrMaBaoCao1)
                    .Parameters.AddWithValue("@ngaybaocao", baocao.DateNgayBaoCao1)
                    .Parameters.AddWithValue("@makhoi", baocao.StrMaKhoi1)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Thêm báo cáo không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function checkMaBaoCao(strMaBaoCao As String) As Result

        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [MaBaoCao]"
        query &= "FROM [tblBaoCao]"
        'query &= "WHERE [tblTreEm].[MaTreEm]=[tblGhiNhanTinhTrang].[MaTreEm] AND [tblGhiNhanTinhTrang].[MaTreEm]=@matreem"
        'query &= "WHERE [MaBaoCao] = (SELECT MAX([MaBaoCao]) FROM [tblBaoCao])"
        query &= "ORDER BY [MaBaoCao] DESC"
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
                    Dim check As String
                    If reader.HasRows = True Then
                        While reader.Read()
                            'treemInfo = (New TreEmDTO(reader("MaTreEm"), reader("HoTenTreEm"), reader("NgaySinh"), reader("HoTenPhuHuynh"), reader("TenONha"), reader("DiaChi"), reader("DienThoai"), reader("Tuoi"), reader("MaLop"), reader("GhiChu"), reader("NgayNhapHoc")))
                            'bcInfo = (New BaoCaoDTO(reader("NgayBaoCao"), reader("MaBaoCao"), reader("MaKhoi")))
                            check = reader("MaBaoCao")
                            strMaBaoCao = check
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy thông tin mã báo cáo không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
End Class
