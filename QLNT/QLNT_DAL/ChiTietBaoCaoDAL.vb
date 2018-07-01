Imports System.Configuration
Imports System.Data.SqlClient
Imports QLNT_DTO
Imports Utility
Public Class ChiTietBaoCaoDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub
    Public Function buildMctbc(ByRef nextMctbc As String) As Result 'ex: 290001

        nextMctbc = String.Empty
        nextMctbc = "290000"

        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [MaChiTietBaoCao] "
        query &= "FROM [tblChiTietBaoCao] "
        query &= "ORDER BY [MaChiTietBaoCao] DESC "

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
                    Dim gnOnDB As String
                    gnOnDB = Nothing
                    If reader.HasRows = True Then
                        While reader.Read()
                            gnOnDB = reader("MaChiTietBaoCao")
                        End While
                    End If
                    If (gnOnDB <> Nothing) Then
                        If (gnOnDB.Length >= 6) Then
                            Dim v = gnOnDB
                            Dim convertDecimal = Convert.ToDecimal(v)
                            convertDecimal = convertDecimal + 1
                            Dim tmp = convertDecimal.ToString()
                            nextMctbc = tmp
                        End If
                    End If
                Catch ex As Exception
                    conn.Close() ' that bai!!!
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tự động mã chi tiết báo cáo kế tiếp không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function selectALL(ByRef listGhiNhan As List(Of ChiTietBaoCaoDTO)) As Result


        Dim query As String = String.Empty
        query &= "SELECT [MaChiTietBaoCao],[MaPhieuGhiNhan],[MaBaoCao]"
        query &= "FROM [tblChiTietBaoCao]"
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
                    listGhiNhan.Clear()
                    If reader.HasRows = True Then
                        While reader.Read()
                            listGhiNhan.Add(New ChiTietBaoCaoDTO(reader("MaChiTietBaoCao"), reader("MaPhieuGhiNhan"), reader("MaBaoCao")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả chi tiết báo cáo không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function selectMbcNull(ByRef listGhiNhan As List(Of ChiTietBaoCaoDTO)) As Result


        Dim query As String = String.Empty
        'query &= "SELECT [MaChiTietBaoCao],[MaPhieuGhiNhan],[MaBaoCao]]"
        query &= "SELECT *"
        query &= "FROM [tblChiTietBaoCao]"
        query &= "WHERE [MaBaoCao] Not IN (SELECT [BaoCao].[MaChiTietBaoCao] FROM [tblChiTietBaoCao],[tblBaoCao] WHERE ([tblChiTietBaoCao].[MaBaoCao])=[tblBaoCao].[MaBaoCao] ) "
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
                    listGhiNhan.Clear()
                    If reader.HasRows = True Then
                        While reader.Read()
                            listGhiNhan.Add(New ChiTietBaoCaoDTO(reader("MaChiTietBaoCao"), reader("MaPhieuGhiNhan"), reader("MaBaoCao")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả chi tiết báo cáo không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function selectByBaoCaoChiTietNull(ByRef listGhiNhan As List(Of GhiNhanTinhTrangDTO)) As Result
        Dim query As String = String.Empty
        query &= " SELECT  * FROM [tblGhiNhanTinhTrang] "
        query &= "WHERE [MaPhieuGhiNhan] Not IN (SELECT [tblChiTietBaoCao].[MaPhieuGhiNhan] FROM [tblChiTietBaoCao],[tblGhiNhanTinhTrang] WHERE ([tblChiTietBaoCao].[MaPhieuGhiNhan])=[tblGhiNhanTinhTrang].[MaPhieuGhiNhan] ) "
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
                    listGhiNhan.Clear()
                    If reader.HasRows = True Then
                        While reader.Read()
                            listGhiNhan.Add(New GhiNhanTinhTrangDTO(reader("MaPhieuGhiNhan"), reader("MaTreEm"), reader("MaTinhTrang"), reader("NgayGhiNhan")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả danh sách chưa báo cáo chi tiết không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function getCTBCByMaCTBC(strMaPhieuGhiNhan As String, ByRef ctbcInfo As ChiTietBaoCaoDTO) As Result

        Dim query As String = String.Empty
        query &= "SELECT * "
        'query &= "SELECT [][MaTreEm],[HoTenTreEm],[GhiChu]"
        query &= "FROM [tblChiTietBaoCao],[tblGhiNhanTinhTrang] "
        query &= "WHERE [tblGhiNhanTinhTrang].[MaPhieuGhiNhan]=[tblChiTietBaoCao].[MaPhieuGhiNhan] AND [tblChiTietBaoCao].[MaPhieuGhiNhan]=@maphieughinhan"
        'query &= "AND [tblTreEm].[MaLop] Is not NULL"
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maphieughinhan", strMaPhieuGhiNhan)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        While reader.Read()
                            ctbcInfo = (New ChiTietBaoCaoDTO(reader("MaChiTietBaoCao"), reader("MaPhieuGhiNhan"), reader("MaBaoCao")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy thông tin trẻ em không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function insert(chitietbaocao As ChiTietBaoCaoDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblChiTietBaoCao] ([MaChiTietBaoCao], [MaPhieuGhiNhan], [MaBaoCao]) "
        query &= "VALUES (@machitietbaocao,@maphieughinhan,@mabaocao) "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@machitietbaocao", chitietbaocao.StrMaChiTietBaoCao1)
                    .Parameters.AddWithValue("@maphieughinhan", chitietbaocao.StrMaPhieuGhiNhan1)
                    .Parameters.AddWithValue("@mabaocao", chitietbaocao.StrMaBaoCao1)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Thêm chi tiết báo cáo không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function deleteByID(strMaChiTietBaoCao As String) As Result
        Dim query As String = String.Empty
        query &= "DELETE From [tblChiTietBaoCao] Where [MaChiTietBaoCao] = @machitietbaocao"
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@machitietbaocao", strMaChiTietBaoCao)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Xóa chi tiết báo cáo không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function updatetByID(chitietbaocao As ChiTietBaoCaoDTO) As Result

        Dim query As String = String.Empty
        query &= "UPDATE [tblChiTietBaoCao] "
        query &= "SET [MaBaoCao] = @mabaocao "
        'query &= "SET [MaChiTietBaoCao] = @machitietbaocao, [MaBaoCao] = @mabaocao "
        query &= "Where [MaChiTietBaoCao] = @machitietbaocao"
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@machitietbaocao", chitietbaocao.StrMaChiTietBaoCao1)
                    '.Parameters.AddWithValue("@maphieughinhan", chitietbaocao.StrMaPhieuGhiNhan1)
                    .Parameters.AddWithValue("@mabaocao", chitietbaocao.StrMaBaoCao1)

                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Cập nhật mã báo cáo không thành công", ex.StackTrace)
                End Try
            End Using
        End Using

        Return New Result(True) ' thanh cong
    End Function
    Public Function GetGhiNhanByMaCTBC(strMaChiTietBaoCao As String, ctbcInfo As ChiTietBaoCaoDTO)
        Dim query As String = String.Empty
        query &= "SELECT * "
        query &= "FROM [tblChiTietBaoCao]"
        query &= "WHERE [MaChiTietBaoCao]=@machitietbaocao"
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@machitietbaocao", strMaChiTietBaoCao)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        While reader.Read()
                            ctbcInfo = (New ChiTietBaoCaoDTO(reader("MaChiTietBaoCao"), reader("MaPhieuGhiNhan"), reader("MaBaoCao")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy thông tin mã phiếu ghi nhận không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
End Class
