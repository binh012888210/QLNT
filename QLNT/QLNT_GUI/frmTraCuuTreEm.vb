Imports QLNT_BUS
Imports QLNT_DTO
Imports Utility
Public Class frmTraCuuTreEm
    Dim listTreEm As List(Of TreEmDTO)
    Dim listKhoi As List(Of KhoiDTO)
    Private teBUS As TreEmBUS
    Private Sub frmTraCuuTreEm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        teBUS = New TreEmBUS()
        listKhoi = New List(Of KhoiDTO)
        listTreEm = New List(Of TreEmDTO)
    End Sub
    Private Sub btnTraCuu_Click(sender As Object, e As EventArgs) Handles btnTraCuu.Click
        Dim treem As TreEmDTO
        treem = New TreEmDTO()
        treem.StrMaTreEm1 = txtMaTreEm.Text
        treem.StrHoTenTreEm1 = txtHoTen.Text
        treem.StrHoTenPhuHuynh1 = txtHoTenPhuHuynh.Text
        treem.StrTenONha1 = txtTenONha.Text
        treem.StrDiaChi1 = txtDiaChi.Text
        treem.StrDienThoai1 = txtDienThoai.Text
        treem.StrGhiChu1 = txtGhiChu.Text
        treem.StrTuoi1 = txtTuoi.Text

        Dim Result As Result
        Dim table As DataTable
        table = New DataTable
        table.Clear()
        Result = teBUS.searchForm(treem, txtMaKhoi.Text, table)
        If (Result.FlagResult = False) Then
            MessageBox.Show("Tìm kiếm trẻ em không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        dgvDanhSachTreEm.Columns.Clear()
        dgvDanhSachTreEm.DataSource = Nothing
        dgvDanhSachTreEm.DataSource = table
        'loadListTreEm()
    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Close()
    End Sub

    Private Sub btnTraCuuMoi_Click(sender As Object, e As EventArgs) Handles btnTraCuuMoi.Click
        txtMaTreEm.Text = String.Empty
        txtHoTen.Text = String.Empty
        txtHoTenPhuHuynh.Text = String.Empty
        txtTenONha.Text = String.Empty
        txtDiaChi.Text = String.Empty
        txtDienThoai.Text = String.Empty
        txtGhiChu.Text = String.Empty
        txtTuoi.Text = String.Empty
        txtMaKhoi.Text = String.Empty
        dgvDanhSachTreEm.Columns.Clear()
        dgvDanhSachTreEm.DataSource = Nothing
    End Sub

End Class