Imports QLNT_DAL
Imports QLNT_DTO
Imports Utility

Public Class TreEmBUS
    Private teDAL As TreEmDAL
    Public Sub New()
        teDAL = New TreEmDAL()
    End Sub
    Public Sub New(connectionString As String)
        teDAL = New TreEmDAL(connectionString)
    End Sub
    Public Function buildMSTE(ByRef nextMste As String) As Result
        Return teDAL.buildMSTE(nextMste)
    End Function

    Public Function isValidName(HoTenTre As String) As Boolean
        Dim check As Integer
        Dim i As Integer
        Dim words() As String = HoTenTre.Split(" ")
        For Each word As String In words
            check = check + 1
        Next
        If (HoTenTre.Length < 1) Then 'text box khong dc rong
            Return False
        End If
        If (check < 1 Or check > 5) Then 'tu 2 den 5 tu
            Return False
        End If
        While (i < HoTenTre.Length)
            If (HoTenTre(i) <> " ") Then
                check = Asc(HoTenTre(i))
                If (check < 65) Then
                    Return False
                End If
                If (check > 90) Then
                    If (check < 97) Then
                        Return False
                    End If
                    If (check > 122) Then
                        Return False
                    End If
                End If
            End If
            i = i + 1
        End While
        Return True
    End Function
    Public Function isValidName1(HoTenTre As String) As Boolean 'danh cho dan toc thieu so
        Dim check As Integer
        Dim i As Integer
        Dim words() As String = HoTenTre.Split(" ")
        For Each word As String In words
            check = check + 1
        Next
        If (HoTenTre.Length < 1) Then 'text box khong dc rong
            Return False
        End If
        If (check > 2) Then 'tu 2 den 5 tu
            Return False
        End If
        While (i < HoTenTre.Length)
            If (HoTenTre(i) <> " " And HoTenTre(i) <> "'") Then
                check = Asc(HoTenTre(i))
                If (check < 65) Then
                    Return False
                End If
                If (check > 90) Then
                    If (check < 97) Then
                        Return False
                    End If
                    If (check > 122) Then
                        Return False
                    End If
                End If
            End If
            i = i + 1
        End While
        Return True
    End Function
    Public Function insert1(te As TreEmDTO) As Result
        Return teDAL.insert1(te)
    End Function

    Public Function insert2(te As TreEmDTO) As Result
        Return teDAL.insert2(te)
    End Function

    Public Function deleteByID(iMaTreEm As String) As Result
        Return teDAL.deleteByID(iMaTreEm)
    End Function

    Public Function selectByID(iMaTreEm As String, ByRef TreEmInfo As TreEmDTO) As Result
        Return teDAL.selectByID(iMaTreEm, TreEmInfo)
    End Function

    Public Function searchByText(searchText As String, ByRef listTreEm As List(Of TreEmDTO)) As Result
        Return teDAL.searchByText(searchText, listTreEm)
    End Function

    Public Function selectALLbyMaLop(bMaLopNull As Boolean, srtMaLop As String, ByRef listTreEm As List(Of TreEmDTO)) As Result
        Return teDAL.selectALLbyMaLop(bMaLopNull, srtMaLop, listTreEm)
    End Function
    Public Function selectAll(ByRef listTreEm As List(Of TreEmDTO)) As Result
        Return teDAL.selectALL(listTreEm)
    End Function

    Public Function updatetByID(TreEmInfo As TreEmDTO) As Result
        Return teDAL.updatetByID(TreEmInfo)
    End Function
End Class
