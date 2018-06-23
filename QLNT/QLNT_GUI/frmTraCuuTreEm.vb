Imports QLNT_BUS
Imports QLNT_DTO
Imports Utility
Public Class frmTraCuuTreEm
    Dim listTreEm As List(Of TreEmDTO)
    Private teBUS As TreEmBUS
    Private khBUS As KhoiBUS
    Private Sub frmTraCuuTreEm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        teBUS = New TreEmBUS()
        khBUS = New KhoiBUS()
        listTreEm = New List(Of TreEmDTO)
        Dim listKhoi = New List(Of KhoiDTO)
        Dim result1 As Result
        result1 = khBUS.selectALL(listKhoi)
        If (result1.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách khối không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result1.SystemMessage)
            Me.Close()
            Return
        End If
        cbKhoi.DataSource = New BindingSource(listKhoi, String.Empty)
        cbKhoi.DisplayMember = "StrTenKhoi1"
        cbKhoi.ValueMember = "StrMaKhoi1"
        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(cbKhoi.DataSource)
        myCurrencyManager.Refresh()
        If (listKhoi.Count > 0) Then
            cbKhoi.SelectedIndex = 0
        End If
    End Sub
    Private Sub btnTraCuu_Click(sender As Object, e As EventArgs) Handles btnTraCuu.Click
        Dim treem As TreEmDTO
        treem = New TreEmDTO()
        If (txtMaTreEm.Text = Nothing And txtHoTen.Text = Nothing And txtHoTenPhuHuynh.Text = Nothing And txtTenONha.Text = Nothing And txtDiaChi.Text = Nothing And txtDienThoai.Text = Nothing And txtGhiChu.Text = Nothing And txtTuoi.Text = Nothing) Then
            MessageBox.Show("Vui lòng điền ít nhất một trong các thông tin cần tra cứu", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        treem.StrMaTreEm1 = "%" + txtMaTreEm.Text + "%"
        treem.StrHoTenTreEm1 = "%" + txtHoTen.Text + "%"
        treem.StrHoTenPhuHuynh1 = "%" + txtHoTenPhuHuynh.Text + "%"
        treem.StrTenONha1 = "%" + txtTenONha.Text + "%"
        treem.StrDiaChi1 = "%" + txtDiaChi.Text + "%"
        treem.StrDienThoai1 = "%" + txtDienThoai.Text + "%"
        treem.StrGhiChu1 = "%" + txtGhiChu.Text + "%"
        treem.StrTuoi1 = "%" + txtTuoi.Text + "%"

        Dim Result As Result
        Dim table As DataTable
        table = New DataTable
        table.Clear()
        Result = teBUS.searchForm(CheckBox1.Checked, treem, cbKhoi.SelectedValue, table)
        If (Result.FlagResult = False) Then
            MessageBox.Show("Tìm kiếm trẻ em không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        dgvDanhSachTreEm.Columns.Clear()
        dgvDanhSachTreEm.DataSource = Nothing
        dgvDanhSachTreEm.DataSource = table
        If (dgvDanhSachTreEm.RowCount() = 1) Then
            MessageBox.Show("Không có trẻ em thoả mãn yêu cầu tra cứu", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
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
        dgvDanhSachTreEm.Columns.Clear()
        dgvDanhSachTreEm.DataSource = Nothing
    End Sub
End Class