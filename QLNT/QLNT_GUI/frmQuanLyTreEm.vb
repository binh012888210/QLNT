Imports QLNT_BUS
Imports QLNT_DTO
Imports Utility

Public Class frmQuanLyTreEm
    Private teBUS As TreEmBUS
    Private gnBUS As GhiNhanTinhTrangBUS

    Private Sub frmQuanLyTreEm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        teBUS = New TreEmBUS()
        gnBUS = New GhiNhanTinhTrangBUS()
        loadListTreEm()

    End Sub

    Private Sub loadListTreEm() 'Load list tre em vao datagridview

        Dim listTreEm = New List(Of TreEmDTO)
        Dim result As Result
        result = teBUS.selectAll(listTreEm)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách trẻ em không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        dgvDanhSachTreEm.Columns.Clear()
        dgvDanhSachTreEm.DataSource = Nothing

        dgvDanhSachTreEm.AutoGenerateColumns = False
        dgvDanhSachTreEm.AllowUserToAddRows = False
        dgvDanhSachTreEm.DataSource = listTreEm

        Dim clMaTreEm = New DataGridViewTextBoxColumn()
        clMaTreEm.Name = "MaTreEm"
        clMaTreEm.HeaderText = "Mã Trẻ Em"
        clMaTreEm.DataPropertyName = "StrMaTreEm1" 'ten trong DTO
        clMaTreEm.ReadOnly = True
        dgvDanhSachTreEm.Columns.Add(clMaTreEm)

        Dim clTenTreEm = New DataGridViewTextBoxColumn()
        clTenTreEm.Name = "HoTenTreEm"
        clTenTreEm.HeaderText = "Tên Trẻ Em"
        clTenTreEm.DataPropertyName = "StrHoTenTreEm1"
        clTenTreEm.ReadOnly = True
        dgvDanhSachTreEm.Columns.Add(clTenTreEm)

        Dim clTenPhuHuynh = New DataGridViewTextBoxColumn()
        clTenPhuHuynh.Name = "TenPhuHuynh"
        clTenPhuHuynh.HeaderText = "Tên Phụ Huynh"
        clTenPhuHuynh.DataPropertyName = "StrHoTenPhuHuynh1"
        clTenPhuHuynh.ReadOnly = True
        dgvDanhSachTreEm.Columns.Add(clTenPhuHuynh)

        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(dgvDanhSachTreEm.DataSource)
        myCurrencyManager.Refresh()

    End Sub

    Private Sub dgvDanhSachTreEm_SelectionChanged(sender As Object, e As EventArgs) Handles dgvDanhSachTreEm.SelectionChanged

        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvDanhSachTreEm.CurrentCellAddress.Y 'Cap nhat du lieu tu datagridview
        If (-1 < currentRowIndex And currentRowIndex < dgvDanhSachTreEm.RowCount) Then
            Try
                Dim te = CType(dgvDanhSachTreEm.Rows(currentRowIndex).DataBoundItem, TreEmDTO)
                txtMaSoTreEm.Text = te.StrMaTreEm1
                txtHoTen.Text = te.StrHoTenTreEm1
                txtNgaySinh.Text = te.DateNgaySinh1.ToShortDateString()
                txtHoTenPhuHuynh.Text = te.StrHoTenPhuHuynh1
                txtTenONha.Text = te.StrTenONha1
                txtDiaChi.Text = te.StrDiaChi1
                txtDienThoai.Text = te.StrDienThoai1
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try
        End If

    End Sub
    Private Sub btnTiepNhan_Click(sender As Object, e As EventArgs) Handles btnTiepNhan.Click 'Mo form tiep nhan

        Dim frm As frmThemTreEm = New frmThemTreEm()
        frm.ShowDialog()
        loadListTreEm()

    End Sub

    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click 'Mo form cap nhat

        Dim frm As frmCapNhatTreEm = New frmCapNhatTreEm()
        Dim currentRowIndex As Integer = dgvDanhSachTreEm.CurrentCellAddress.Y
        If (-1 < currentRowIndex And currentRowIndex < dgvDanhSachTreEm.RowCount) Then
            Dim te = CType(dgvDanhSachTreEm.Rows(currentRowIndex).DataBoundItem, TreEmDTO)
            frm.txtMaSoTreEm.Text = te.StrMaTreEm1
            frm.txtHoTen.Text = te.StrHoTenTreEm1
            frm.dtpNgaySinh.Text = te.DateNgaySinh1
            frm.txtHoTenPhuHuynh.Text = te.StrHoTenPhuHuynh1
            frm.txtTenONha.Text = te.StrTenONha1
            frm.txtDiaChi.Text = te.StrDiaChi1
            frm.txtDienThoai.Text = te.StrDienThoai1
            frm.ShowDialog()
            loadListTreEm()
        Else
            MessageBox.Show("Thêm trẻ em trước khi cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return

        End If
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click 'Xoa tre em khoi co so du lieu

        If (dgvDanhSachTreEm.RowCount > 0) Then
            Dim result As Result
            result = gnBUS.deleteByMaTreEm(txtMaSoTreEm.Text) 'Xoa KHOA NGOAI THAM CHIEU TRUOC 
            If (result.FlagResult = False) Then
                MessageBox.Show("Xoá ghi nhận của trẻ em không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
                Return
            End If
            result = teBUS.deleteByID(txtMaSoTreEm.Text)
            If (result.FlagResult = False) Then
                MessageBox.Show("Xoá trẻ em không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
                Return
            End If
            loadListTreEm()
        Else
            MessageBox.Show("Không còn trẻ em để xoá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub txtSearchName_TextChanged(sender As Object, e As EventArgs) Handles txtSearchName.TextChanged 'tim kiem theo ten tre em hoac ten phu huynh

        Dim listTreEm = New List(Of TreEmDTO)
        Dim result As Result
        result = teBUS.searchByText(txtSearchName.Text, listTreEm)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách trẻ em không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        dgvDanhSachTreEm.Columns.Clear()
        dgvDanhSachTreEm.DataSource = Nothing

        dgvDanhSachTreEm.AutoGenerateColumns = False
        dgvDanhSachTreEm.AllowUserToAddRows = False
        dgvDanhSachTreEm.DataSource = listTreEm

        Dim clMaTreEm = New DataGridViewTextBoxColumn()
        clMaTreEm.Name = "MaTreEm"
        clMaTreEm.HeaderText = "Mã Trẻ Em"
        clMaTreEm.DataPropertyName = "StrMaTreEm1"
        clMaTreEm.ReadOnly = True
        dgvDanhSachTreEm.Columns.Add(clMaTreEm)

        Dim clTenTreEm = New DataGridViewTextBoxColumn()
        clTenTreEm.Name = "HoTenTreEm"
        clTenTreEm.HeaderText = "Tên Trẻ Em"
        clTenTreEm.DataPropertyName = "StrHoTenTreEm1"
        clTenTreEm.ReadOnly = True
        dgvDanhSachTreEm.Columns.Add(clTenTreEm)

        Dim clTenPhuHuynh = New DataGridViewTextBoxColumn()
        clTenPhuHuynh.Name = "TenPhuHuynh"
        clTenPhuHuynh.HeaderText = "Tên Phụ Huynh"
        clTenPhuHuynh.DataPropertyName = "StrHoTenPhuHuynh1" '
        clTenPhuHuynh.ReadOnly = True
        dgvDanhSachTreEm.Columns.Add(clTenPhuHuynh)


        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(dgvDanhSachTreEm.DataSource)
        myCurrencyManager.Refresh()

    End Sub


    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click 'Dong form
        Close()
    End Sub
End Class