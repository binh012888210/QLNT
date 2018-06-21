Imports System.Configuration
Imports System.Data.SqlClient
Imports QLNT_DTO
Imports Utility
Public Class TreEmDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub
    Public Function buildMSTE(ByRef nextMste As String) As Result 'ex: 180001

        nextMste = String.Empty
        Dim y = DateTime.Now.Year
        Dim x = y.ToString().Substring(2)
        nextMste = x + "0000"

        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [MaTreEm] "
        query &= "FROM [tblTreEm] "
        query &= "ORDER BY [MaTreEm] DESC "

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
                    Dim msOnDB As String
                    msOnDB = Nothing
                    If reader.HasRows = True Then
                        While reader.Read()
                            msOnDB = reader("MaTreEm")
                        End While
                    End If
                    If (msOnDB <> Nothing) Then
                        If (msOnDB.Length >= 6) Then
                            Dim currentYear = DateTime.Now.Year.ToString().Substring(2)
                            Dim iCurrentYear = Integer.Parse(currentYear)
                            Dim currentYearOnDB = msOnDB.Substring(0, 2)
                            Dim icurrentYearOnDB = Integer.Parse(currentYearOnDB)
                            Dim year = iCurrentYear
                            If (year < icurrentYearOnDB) Then
                                year = icurrentYearOnDB
                            End If
                            nextMste = year.ToString()
                            Dim v = msOnDB.Substring(2)
                            Dim convertDecimal = Convert.ToDecimal(v)
                            convertDecimal = convertDecimal + 1
                            Dim tmp = convertDecimal.ToString()
                            tmp = tmp.PadLeft(msOnDB.Length - 2, "0")
                            nextMste = nextMste + tmp
                            System.Console.WriteLine(nextMste)
                        End If
                    End If
                Catch ex As Exception
                    conn.Close() ' that bai!!!
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tự động Mã số trẻ em kế tiếp không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function insert1(treEm As TreEmDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblTreEm] ([MaTreEm], [HoTenTreEm], [NgaySinh], [HoTenPhuHuynh], [TenONha], [DiaChi], [DienThoai],[Tuoi])"
        query &= "VALUES (@MaTreEm,@HoTenTreEm,@NgaySinh,@HoTenPhuHuynh,@TenONha,@DiaChi,@DienThoai,@Tuoi)"

        ''get MSHS
        'Dim nextMste = "1"
        'buildMSTE(nextMste)
        'te.StrMaTreEm1 = nextMste

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaTreEm", treEm.StrMaTreEm1)
                    .Parameters.AddWithValue("@HoTenTreEm", treEm.StrHoTenTreEm1)
                    .Parameters.AddWithValue("@NgaySinh", treEm.DateNgaySinh1)
                    .Parameters.AddWithValue("@HoTenPhuHuynh", treEm.StrHoTenPhuHuynh1)
                    .Parameters.AddWithValue("@TenONha", treEm.StrTenONha1)
                    .Parameters.AddWithValue("@DiaChi", treEm.StrDiaChi1)
                    .Parameters.AddWithValue("@DienThoai", treEm.StrDienThoai1)
                    .Parameters.AddWithValue("@Tuoi", treEm.StrTuoi1)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Thêm trẻ em không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function insert2(treEm As TreEmDTO) As Result

        Dim query As String = String.Empty
        query &= "UPDATE [tblTreEm] SET [MaLop] = @malop , [GhiChu]= @ghichu , [NgayNhapHoc]=@ngaynhaphoc WHERE [MaTreEm] = @matreem"
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@matreem", treEm.StrMaTreEm1)
                    .Parameters.AddWithValue("@malop", treEm.StrMaLop1)
                    .Parameters.AddWithValue("@ngaynhaphoc", treEm.DateNgayNhapHoc1)
                    .Parameters.AddWithValue("@ghichu", treEm.StrGhiChu1)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Thêm thêm trẻ em vào lớp không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong

    End Function

    Public Function selectALL(ByRef listTreEm As List(Of TreEmDTO)) As Result

        Dim query As String = String.Empty
        query &= "SELECT [MaTreEm], [HoTenTreEm], [NgaySinh], [HoTenPhuHuynh], [TenONha], [DiaChi], [DienThoai], [Tuoi]"
        query &= "FROM [tblTreEm]"

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
                            listTreEm.Add(New TreEmDTO(reader("MaTreEm"), reader("HoTenTreEm"), reader("NgaySinh"), reader("HoTenPhuHuynh"), reader("TenONha"), reader("DiaChi"), reader("DienThoai"), reader("Tuoi")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả trẻ em không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong

    End Function

    Public Function selectALLbyMaLop(bMaLopNull As Boolean, strMaLop As String, ByRef listTreEm As List(Of TreEmDTO)) As Result

        Dim query As String = String.Empty
        If (bMaLopNull = True) Then
            query &= "SELECT [MaTreEm],[HoTenTreEm],[NgaySinh],[HoTenPhuHuynh],[TenONha],[DiaChi],[DienThoai],[Tuoi],[MaLop] "
            query &= "FROM [tblTreEm] "
            query &= "WHERE [MaLop] is null"
        Else
            query &= "SELECT [MaTreEm],[HoTenTreEm],[NgaySinh],[HoTenPhuHuynh],[TenONha],[DiaChi],[DienThoai],[Tuoi],[MaLop],[NgayNhapHoc],[GhiChu] "
            query &= "FROM [tblTreEm] "
            query &= "WHERE [MaLop] = @malop "

        End If
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    If (bMaLopNull = False) Then
                        .Parameters.AddWithValue("@malop", strMaLop)
                    End If
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    listTreEm.Clear()
                    If reader.HasRows = True Then
                        While reader.Read()
                            If (bMaLopNull = True) Then
                                listTreEm.Add(New TreEmDTO(reader("MaTreEm"), reader("HoTenTreEm"), reader("NgaySinh"), reader("HoTenPhuHuynh"), reader("TenONha"), reader("DiaChi"), reader("DienThoai"), reader("Tuoi")))
                            Else
                                listTreEm.Add(New TreEmDTO(reader("MaTreEm"), reader("HoTenTreEm"), reader("NgaySinh"), reader("HoTenPhuHuynh"), reader("TenONha"), reader("DiaChi"), reader("DienThoai"), reader("NgayNhapHoc"), reader("Tuoi"), reader("GhiChu"), reader("MaLop")))
                            End If
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả trẻ em không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong

    End Function

    Public Function searchByText(searchText As String, ByRef listTreEm As List(Of TreEmDTO)) As Result

        Dim searchText1 As String = searchText
        Dim query As String = String.Empty
        query &= "SELECT * FROM [tblTreEm] WHERE CONCAT(HoTenTreEm,HoTenPhuHuynh) like '%" + searchText1 + "%'"

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
                            listTreEm.Add(New TreEmDTO(reader("MaTreEm"), reader("HoTenTreEm"), reader("NgaySinh"), reader("HoTenPhuHuynh"), reader("TenONha"), reader("DiaChi"), reader("DienThoai"), reader("Tuoi")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả trẻ em không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong

    End Function

    Public Function searchByMaTreEm(strMaTreEm As String, ByRef treEmInfo As TreEmDTO) As Result

        Dim query As String = String.Empty
        query &= "SELECT * "
        query &= "FROM [tblTreEm] "
        query &= "WHERE [MaTreEm]=@matreem"

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
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        While reader.Read()
                            treEmInfo = (New TreEmDTO(reader("MaTreEm"), reader("HoTenTreEm")))
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

    Public Function searchForm(searchInfo As TreEmDTO, searchMaKhoi As String, ByRef table As DataTable) As Result

        Dim query As String = String.Empty
        query &= "SELECT * "
        query &= "FROM [tblTreEm],[tblLop],[tblKhoi] "
        query &= "WHERE [tblTreEm].[MaLop]=[tblLop].[MaLop] AND [tblLop].[MaKhoi]=[tblKhoi].[MaKhoi] "
        query &= "And ([MaTreEm] = @matreem Or [tblKhoi].[MaKhoi] =@makhoi OR [HoTenTreEm] = @hotentreem OR [HoTenPhuHuynh]= @hotenphuhuynh OR [TenONha]=@tenonha OR [DiaChi]=@diachi "
        query &= "OR [DienThoai]=@dienthoai OR [Tuoi]=@tuoi OR [GhiChu]=@ghichu) "
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@matreem", searchInfo.StrMaTreEm1)
                    .Parameters.AddWithValue("@hotentreem", searchInfo.StrHoTenTreEm1)
                    .Parameters.AddWithValue("@hotenphuhuynh", searchInfo.StrHoTenPhuHuynh1)
                    .Parameters.AddWithValue("@tenonha", searchInfo.StrTenONha1)
                    .Parameters.AddWithValue("@diachi", searchInfo.StrDiaChi1)
                    .Parameters.AddWithValue("@dienthoai", searchInfo.StrDienThoai1)
                    .Parameters.AddWithValue("@tuoi", searchInfo.StrTuoi1)
                    .Parameters.AddWithValue("@makhoi", searchMaKhoi)
                    .Parameters.AddWithValue("@ghichu", searchInfo.StrGhiChu1)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    table.Columns.Add("Mã trẻ em", Type.GetType("System.String"))
                    table.Columns.Add("Họ tên trẻ em", Type.GetType("System.String"))
                    table.Columns.Add("Tuổi", Type.GetType("System.String"))
                    table.Columns.Add("Mã khối", Type.GetType("System.String"))
                    table.Columns.Add("Ghi chú", Type.GetType("System.String"))
                    If reader.HasRows = True Then
                        While reader.Read()
                            table.Rows.Add(reader("MaTreEm"), reader("HoTenTreEm"), reader("Tuoi"), reader("MaKhoi"), reader("GhiChu"))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả trẻ em không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong

    End Function

    Public Function updatetByID(treEmInfo As TreEmDTO) As Result

        Dim query As String = String.Empty
        query &= "UPDATE [tblTreEm] "
        query &= "SET [HoTenTreEm] = @hotentreem, [NgaySinh] = @ngaysinh, [HoTenPhuHuynh] = @hotenphuhuynh, [TenONha] = @tenonha, [DiaChi] = @diachi, [DienThoai] = @dienthoai, [Tuoi] = @tuoi "
        query &= "Where [MaTreEm] = @masotreem"
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@masotreem", treEmInfo.StrMaTreEm1)
                    .Parameters.AddWithValue("@hotentreem", treEmInfo.StrHoTenTreEm1)
                    .Parameters.AddWithValue("@ngaysinh", treEmInfo.DateNgaySinh1)
                    .Parameters.AddWithValue("@hotenphuhuynh", treEmInfo.StrHoTenPhuHuynh1)
                    .Parameters.AddWithValue("@tenonha", treEmInfo.StrTenONha1)
                    .Parameters.AddWithValue("@diachi", treEmInfo.StrDiaChi1)
                    .Parameters.AddWithValue("@dienthoai", treEmInfo.StrDienThoai1)
                    .Parameters.AddWithValue("@tuoi", treEmInfo.StrTuoi1)

                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Cập nhật tre em không thành công", ex.StackTrace)
                End Try
            End Using
        End Using

        Return New Result(True) ' thanh cong
    End Function

    Public Function deleteByID(strMaTreEm As String) As Result
        Dim query As String = String.Empty
        query &= "DELETE From [tblTreEm] Where [MaTreEm] = @masotreem"
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@masotreem", strMaTreEm)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Xóa trẻ em không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong

    End Function

    Public Function chuyenLopTreEM(treEm As TreEmDTO, strMalop As String) As Result

        Dim query As String = String.Empty
        query &= "UPDATE [tblTreEm] SET [MaLop] = @malop  WHERE [MaTreEm] = @matreem"
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@matreem", treEm.StrMaTreEm1)
                    .Parameters.AddWithValue("@malop", strMalop)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Chuyển lớp trẻ em vào lớp không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong

    End Function





End Class