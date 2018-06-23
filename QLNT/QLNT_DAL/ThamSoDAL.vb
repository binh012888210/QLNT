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
    Public Function update(ts As ThamSoDTO, text As String) As Result
        Dim query As String = String.Empty
        ' Dim number As Integer
        'Number =
        query &= "UPDATE [tblThamSo] "
        'query &= "SET [MaTinhTrang] = @matinhtrang, [TenTinhTrang] = @tentinhtrang  "
        'query &= "SET [TenTinhTrang] = @tentinhtrang"
        query &= "SET [SoHocSinhToiDa] = @sohocsinhtoida"
        'query &= "Where [SoHocSinhToiDa] = @sohocsinhtoida"
        'query &= "Where [SoHocSinhToiDa] = '" & text.ToString() & "'"
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@SoHocSinhToiDa", ts.IntSoHocSinhToiDa1)
                    '.Parameters.AddWithValue("@tentinhtrang", tt.StrTenTinhTrang1)
                    '.Parameters.AddWithValue("@maphieughinhan", ghinhan.StrMaPhieuGhiNhan1)
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
    Public Function selectALL(ByRef listTinhTrang As List(Of ThamSoDTO)) As Result

        Dim query As String = String.Empty
        query &= "SELECT * "
        query &= "FROM [tblThamSo]"

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
                            ' listTinhTrang.Add(New ThamSoDTO(reader("MaTinhTrang"), reader("TenTinhTrang")))
                            listTinhTrang.Add(New ThamSoDTO(reader("TuoiToiTieu"), reader("TuoiToiDa"), reader("SoHocSinhToiDa")))

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
    Public Function LoadSiSo(ByRef text As String) As Result

        Dim query As String = String.Empty
        query &= "SELECT * "
        query &= "FROM [tblThamSo]"

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
                    If reader.HasRows = True Then
                        While reader.Read()
                            ' listTinhTrang.Add(New ThamSoDTO(reader("MaTinhTrang"), reader("TenTinhTrang")))
                            ' listTinhTrang.Add(New ThamSoDTO(reader("TuoiToiTieu"), reader("TuoiToiDa"), reader("SoHocSinhToiDa")))
                            'Dim number = reader.GetString("SoHocSinhToiDa")
                            'text = number
                            text = (reader("SoHocSinhToiDa").ToString())
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
End Class
