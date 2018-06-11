Imports QLNT_BUS
Imports QLNT_DTO
Imports Utility
Public Class frmQuanLyGhiNhanTinhTrangTre
    Private ghinhanBUS As GhiNhanTinhTrangBUS
    Private khBUS As KhoiBUS
    Private teBUS As TreEmBUS
    Private ttBUS As TinhTrangBUS

    Private Sub frmGhiNhanTinhTrangTre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ghinhanBUS = New GhiNhanTinhTrangBUS
        khBUS = New KhoiBUS
        teBUS = New TreEmBUS
        ttBUS = New TinhTrangBUS
        loadListGhiNhan()
    End Sub

    Private Sub loadListGhiNhan() 'Load du lieu vao datagridview
        Dim listGhiNhan = New List(Of GhiNhanTinhTrangDTO)
        Dim result As Result
        result = ghinhanBUS.selectALL(listGhiNhan)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách ghi nhận không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        dgvDanhSachGhiNhan.Columns.Clear()
        dgvDanhSachGhiNhan.DataSource = Nothing

        dgvDanhSachGhiNhan.AutoGenerateColumns = False
        dgvDanhSachGhiNhan.AllowUserToAddRows = False
        dgvDanhSachGhiNhan.DataSource = listGhiNhan

        Dim clMaGhiNhan = New DataGridViewTextBoxColumn()
        clMaGhiNhan.Name = "MaGhiNhan"
        clMaGhiNhan.HeaderText = "Mã Ghi Nhận"
        clMaGhiNhan.DataPropertyName = "StrMaPhieuGhiNhan1" ''ten trong DTO
        clMaGhiNhan.ReadOnly = True
        dgvDanhSachGhiNhan.Columns.Add(clMaGhiNhan)

        Dim clMaTreEm = New DataGridViewTextBoxColumn()
        clMaTreEm.Name = "MaTreEM"
        clMaTreEm.HeaderText = "Mã Trẻ Em"
        clMaTreEm.DataPropertyName = "StrMaTreEm1" 'ten trong DTO
        clMaTreEm.ReadOnly = True
        dgvDanhSachGhiNhan.Columns.Add(clMaTreEm)

        Dim clMaTinhTrang = New DataGridViewTextBoxColumn()
        clMaTinhTrang.Name = "MaTinhTrang"
        clMaTinhTrang.HeaderText = "Mã Tình Trạng"
        clMaTinhTrang.DataPropertyName = "StrMaTinhTrang1" 'ten trong DTO
        clMaTinhTrang.ReadOnly = True
        dgvDanhSachGhiNhan.Columns.Add(clMaTinhTrang)

        Dim clNgayGhiNhan = New DataGridViewTextBoxColumn()
        clNgayGhiNhan.Name = "NgayGhiNhan"
        clNgayGhiNhan.HeaderText = "Ngày Ghi Nhận"
        clNgayGhiNhan.DataPropertyName = "DateNgayGhiNhan1" 'ten trong DTO
        clNgayGhiNhan.ReadOnly = True
        dgvDanhSachGhiNhan.Columns.Add(clNgayGhiNhan)

        Dim clMaKhoi = New DataGridViewTextBoxColumn()
        clMaKhoi.Name = "MaKhoi"
        clMaKhoi.HeaderText = "Mã khối"
        clMaKhoi.DataPropertyName = "StrMaKhoi1" 'ten trong DTO
        clMaKhoi.ReadOnly = True
        dgvDanhSachGhiNhan.Columns.Add(clMaKhoi)


        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(dgvDanhSachGhiNhan.DataSource)
        myCurrencyManager.Refresh()

    End Sub

    Private Sub dgvDanhSachGhiNhan_SelectionChanged(sender As Object, e As EventArgs) Handles dgvDanhSachGhiNhan.SelectionChanged 'Gia tri duoc chon trong dgv thay doi
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvDanhSachGhiNhan.CurrentCellAddress.Y
        If (-1 < currentRowIndex And currentRowIndex < dgvDanhSachGhiNhan.RowCount) Then
            Try
                Dim ghinhan = CType(dgvDanhSachGhiNhan.Rows(currentRowIndex).DataBoundItem, GhiNhanTinhTrangDTO)
                txtMaGhiNhan.Text = ghinhan.StrMaPhieuGhiNhan1
                txtTenKhoi.Text = ghinhan.StrMaKhoi1
                txtNgayGhiNhan.Text = ghinhan.DateNgayGhiNhan1.ToString

                Dim treEmInfo = New TreEmDTO 'Lay ten tre em trong sql
                Dim result As Result
                result = teBUS.searchByMaTreEm(ghinhan.StrMaTreEm1, treEmInfo)
                If (result.FlagResult = False) Then
                    MessageBox.Show("Lấy thông tin khối không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                    Return
                End If

                Dim khoiInfo = New KhoiDTO 'Lay ten khoi trong sql
                result = khBUS.getKhoiByMaKhoi(ghinhan.StrMaKhoi1, khoiInfo)
                If (result.FlagResult = False) Then
                    MessageBox.Show("Lấy thông tin khối không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                    Return
                End If

                Dim tinhTrangInfo = New TinhTrangDTO 'Lay ten tinh trang trong sql
                result = ttBUS.getTinhTrangByMaTinhTrang(ghinhan.StrMaTinhTrang1, tinhTrangInfo)
                If (result.FlagResult = False) Then
                    MessageBox.Show("Lấy thông tin tình trạng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                    Return
                End If

                txtTinhTrang.Text = tinhTrangInfo.StrTenTinhTrang1
                txtHoTenTre.Text = treEmInfo.StrHoTenTreEm1
                txtTenKhoi.Text = khoiInfo.StrTenKhoi1


            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try
        End If

    End Sub

    Private Sub btnGhiNhan_Click(sender As Object, e As EventArgs) Handles btnGhiNhan.Click 'Thuc hien mo form frmThemGhiNhan
        Dim frm As frmThemGhiNhan = New frmThemGhiNhan()
        frm.ShowDialog()
        loadListGhiNhan()
    End Sub

    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhatGhiNhan.Click 'Thuc hien mo form frmCapNhatGhiNhan

        Dim frm As frmCapNhatGhiNhan = New frmCapNhatGhiNhan()
        Dim currentRowIndex As Integer = dgvDanhSachGhiNhan.CurrentCellAddress.Y
        If (-1 < currentRowIndex And currentRowIndex < dgvDanhSachGhiNhan.RowCount) Then
            Dim ghinhan = CType(dgvDanhSachGhiNhan.Rows(currentRowIndex).DataBoundItem, GhiNhanTinhTrangDTO)
            frm.txtMaGhiNhan.Text = ghinhan.StrMaPhieuGhiNhan1
            frm.txtMaSoTreEm.Text = ghinhan.StrMaTreEm1
            frm.txtHoTenTre.Text = txtHoTenTre.Text
            frm.txtTenKhoi.Text = txtTenKhoi.Text
            frm.dtpNgayGhiNhan.Text = ghinhan.DateNgayGhiNhan1
            frm.ShowDialog()
            loadListGhiNhan()
        Else
            MessageBox.Show("Thêm ghi nhận trước khi cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

    End Sub

    Private Sub btnXoaGhiNhan_Click(sender As Object, e As EventArgs) Handles btnXoaGhiNhan.Click

        If (dgvDanhSachGhiNhan.RowCount > 0) Then
            Dim result As Result
            result = ghinhanBUS.deleteByID(txtMaGhiNhan.Text)
            If (result.FlagResult = False) Then
                MessageBox.Show("Xoá ghi nhận không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
                Return
            End If
            loadListGhiNhan()
        Else
            MessageBox.Show("Không còn ghi nhận để xoá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Close()
    End Sub
End Class