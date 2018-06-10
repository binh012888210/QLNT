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
    'Private Sub loadListTreEm()
    '    dgvDanhSachTreEm.Columns.Clear()
    '    dgvDanhSachTreEm.DataSource = Nothing

    '    dgvDanhSachTreEm.AutoGenerateColumns = False
    '    dgvDanhSachTreEm.AllowUserToAddRows = False
    '    dgvDanhSachTreEm.DataSource = listTreEm

    '    Dim table As New DataTable


    '    Dim clMaTreEm = New DataGridViewTextBoxColumn()
    '    clMaTreEm.Name = "MaTreEm"
    '    clMaTreEm.HeaderText = "Mã Trẻ Em"
    '    clMaTreEm.DataPropertyName = "StrMaTreEm1" ''ten trong DTO
    '    clMaTreEm.ReadOnly = True
    '    dgvDanhSachTreEm.Columns.Add(clMaTreEm)

    '    Dim clTenTreEm = New DataGridViewTextBoxColumn()
    '    clTenTreEm.Name = "HoTenTreEm"
    '    clTenTreEm.HeaderText = "Tên Trẻ Em"
    '    clTenTreEm.DataPropertyName = "StrHoTenTreEm1" 'ten trong DTO
    '    clTenTreEm.ReadOnly = True
    '    dgvDanhSachTreEm.Columns.Add(clTenTreEm)

    '    Dim clTuoi = New DataGridViewTextBoxColumn()
    '    clTuoi.Name = "Tuoi"
    '    clTuoi.HeaderText = "Tuổi"
    '    clTuoi.DataPropertyName = "StrTuoi1" 'ten trong DTO
    '    clTuoi.ReadOnly = True
    '    dgvDanhSachTreEm.Columns.Add(clTuoi)

    '    Dim clGhiChu = New DataGridViewTextBoxColumn()
    '    clGhiChu.Name = "GhiChu"
    '    clGhiChu.HeaderText = "Ghi chú"
    '    clGhiChu.DataPropertyName = "StrGhiChu1" 'ten trong DTO
    '    clGhiChu.ReadOnly = True
    '    dgvDanhSachTreEm.Columns.Add(clGhiChu)

    '    dgvDanhSachTreEm.DataSource = listKhoi

    '    Dim clKhoiLop = New DataGridViewTextBoxColumn()
    '    clKhoiLop.Name = "KhoiLop"
    '    clKhoiLop.HeaderText = "Khối lớp"
    '    clKhoiLop.DataPropertyName = "StrTenKhoi1" 'ten trong DTO
    '    clKhoiLop.ReadOnly = True
    '    dgvDanhSachTreEm.Columns.Add(clKhoiLop)


    '    Dim myCurrencyManager As CurrencyManager = Me.BindingContext(dgvDanhSachTreEm.DataSource)
    '    myCurrencyManager.Refresh()

    'End Sub
End Class