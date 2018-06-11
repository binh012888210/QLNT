Imports System.Configuration
Imports System.Data.SqlClient
Imports QLNT_DTO
Imports Utility
Public Class GhiNhanTinhTrangDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub
    Public Function buildMSGN(ByRef nextMsgn As String) As Result 'ex: 180001

        nextMsgn = String.Empty
        nextMsgn = "10000"

        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [MaPhieuGhiNhan] "
        query &= "FROM [tblGhiNhanTinhTrang] "
        query &= "ORDER BY [MaPhieuGhiNhan] DESC "

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
                            gnOnDB = reader("MaPhieuGhiNhan")
                        End While
                    End If
                    If (gnOnDB <> Nothing) Then
                        If (gnOnDB.Length >= 5) Then
                            Dim v = gnOnDB
                            Dim convertDecimal = Convert.ToDecimal(v)
                            convertDecimal = convertDecimal + 1
                            Dim tmp = convertDecimal.ToString()
                            nextMsgn = tmp
                        End If
                    End If
                Catch ex As Exception
                    conn.Close() ' that bai!!!
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tự động Mã số ghi nhận kế tiếp không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function insert(ghinhan As GhiNhanTinhTrangDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblGhiNhanTinhTrang] ([MaPhieuGhiNhan], [MaTreEm], [MaTinhTrang], [NgayGhiNhan], [MaKhoi]) "
        query &= "VALUES (@maphieughinhan,@matreem,@matinhtrang,@ngayghinhan,@makhoi) "

        'Dim nextID = 0
        'Dim result As Result
        'result = buildMSGN(nextID)
        'If (result.FlagResult = False) Then
        '    Return result
        'End If
        'ghinhan.StrMaPhieuGhiNhan1 = nextID

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maphieughinhan", ghinhan.StrMaPhieuGhiNhan1)
                    .Parameters.AddWithValue("@matreem", ghinhan.StrMaTreEm1)
                    .Parameters.AddWithValue("@matinhtrang", ghinhan.StrMaTinhTrang1)
                    .Parameters.AddWithValue("@ngayghinhan", ghinhan.DateNgayGhiNhan1)
                    .Parameters.AddWithValue("@makhoi", ghinhan.StrMaKhoi1)

                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Thêm ghi nhận không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function selectALL(ByRef listGhiNhan As List(Of GhiNhanTinhTrangDTO)) As Result

        Dim query As String = String.Empty
        query &= "SELECT [MaPhieuGhiNhan], [MaTreEm], [MaTinhTrang], [NgayGhiNhan], [MaKhoi] "
        query &= "FROM [tblGhiNhanTinhTrang]"

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
                            listGhiNhan.Add(New GhiNhanTinhTrangDTO(reader("MaPhieuGhiNhan"), reader("MaTreEm"), reader("MaTinhTrang"), reader("NgayGhiNhan"), reader("MaKhoi")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả ghi nhận em không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function updatetByID(ghinhan As GhiNhanTinhTrangDTO) As Result

        Dim query As String = String.Empty
        query &= "UPDATE [tblGhiNhanTinhTrang] "
        query &= "SET [MaTinhTrang] = @matinhtrang, [NgayGhiNhan] = @ngayghinhan  "
        query &= "Where [MaPhieuGhiNhan] = @maphieughinhan"
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@matinhtrang", ghinhan.StrMaTinhTrang1)
                    .Parameters.AddWithValue("@ngayghinhan", ghinhan.DateNgayGhiNhan1)
                    .Parameters.AddWithValue("@maphieughinhan", ghinhan.StrMaPhieuGhiNhan1)
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
    Public Function deleteByID(strMaPhieuGhiNhan As String) As Result
        Dim query As String = String.Empty
        query &= "DELETE From [tblGhiNhanTinhTrang] Where [MaPhieuGhiNhan] = @maphieughinhan"
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
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Xóa ghi nhận không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function deleteByMaTreEm(strMaTreEm As String) As Result
        Dim query As String = String.Empty
        query &= "DELETE From [tblGhiNhanTinhTrang] Where [MaTreEm] = @matreem"
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@matreem", strMaTreEm)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Xóa ghi nhận không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function selectByGhiNhanNull(ByRef listTreEm As List(Of TreEmDTO)) As Result
        Dim query As String = String.Empty

        query &= " SELECT * FROM [tblTreEm] "
        query &= "WHERE [MaTreEm] Not IN (SELECT [tblTreEm].[MaTreEm] FROM [tblTreEm],[tblGhiNhanTinhTrang] WHERE ([tblTreEm].[MaTreEm])=[tblGhiNhanTinhTrang].[MaTreEm] ) "
        query &= "AND [MaLop] Is not null"


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
                    listTreEm.Clear()
                    If reader.HasRows = True Then
                        While reader.Read()
                            listTreEm.Add(New TreEmDTO(reader("MaTreEm"), reader("HoTenTreEm"), reader("NgaySinh"), reader("HoTenPhuHuynh"), reader("TenONha"), reader("DiaChi"), reader("DienThoai"), reader("Tuoi"), reader("MaLop")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả ghi nhận không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
End Class
