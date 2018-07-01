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
        Dim check As Integer = 0
        Dim i As Integer = 0
        Dim words() As String = HoTenTre.Split(" ")
        For Each word As String In words
            check = check + 1
        Next
        If (check < 2 Or check > 5) Then 'tu 2 den 5 tu
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
        Dim check As Integer = 0
        Dim i As Integer = 0
        Dim words() As String = HoTenTre.Split(" ")
        For Each word As String In words
            check = check + 1
        Next
        If (check > 1) Then 'tu 2 den 5 tu
            Return False
        End If
        i = i + 1 'tai vi chu dau la dau phay
        While (i < HoTenTre.Length)
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

    Public Function selectAll(ByRef listTreEm As List(Of TreEmDTO)) As Result
        Return teDAL.selectALL(listTreEm)
    End Function

    Public Function selectALLbyMaLop(bMaLopNull As Boolean, srtMaLop As String, ByRef listTreEm As List(Of TreEmDTO)) As Result
        Return teDAL.selectALLbyMaLop(bMaLopNull, srtMaLop, listTreEm)
    End Function

    Public Function selectALLbyMaLopIsNotNull(ByRef listTreEm As List(Of TreEmDTO)) As Result
        Return teDAL.selectALLbyMaLopIsNotNull(listTreEm)
    End Function

    Public Function searchByText(searchText As String, ByRef listTreEm As List(Of TreEmDTO)) As Result
        Return teDAL.searchByText(searchText, listTreEm)
    End Function

    Public Function searchByTextAndMaLopIsNull(searchText As String, ByRef listTreEm As List(Of TreEmDTO)) As Result
        Return teDAL.searchByTextAndMaLopIsNull(searchText, listTreEm)
    End Function

    Public Function searchForm(advSearch As Boolean, seearchInfo As TreEmDTO, searchMaKhoi As String, ByRef table As DataTable) As Result
        Return teDAL.searchForm(advSearch, seearchInfo, searchMaKhoi, table)
    End Function

    Public Function searchByID(strMaTreEm As String, ByRef treEmInfo As TreEmDTO) As Result
        Return teDAL.searchByID(strMaTreEm, treEmInfo)
    End Function

    Public Function updatetByID(TreEmInfo As TreEmDTO) As Result
        Return teDAL.updatetByID(TreEmInfo)
    End Function

    Public Function deleteByID(strMaTreEm As String) As Result
        Return teDAL.deleteByID(strMaTreEm)
    End Function

    Public Function deleteClassByID(strMaTreEm As String) As Result
        Return teDAL.deleteClassByID(strMaTreEm)
    End Function

    Public Function chuyenLopTreEM(te As TreEmDTO, strMalop As String) As Result
        Return teDAL.chuyenLopTreEM(te, strMalop)
    End Function

    Public Function getKhoiByID(strMaTreEm As String, ByRef khoiInfo As KhoiDTO) As Result
        Return teDAL.getKhoiByID(strMaTreEm, khoiInfo)
    End Function

    Public Function moveToTemporaryTableByID(strMaTreEm As String) As Result
        Return teDAL.moveToTemporaryTableByID(strMaTreEm)
    End Function

    Public Function restoreFromTemporaryTable() As Result
        Return teDAL.restoreFromTemporaryTable()
    End Function
    Public Function clearTemporaryTable() As Result
        Return teDAL.clearTemporaryTable()
    End Function
End Class
