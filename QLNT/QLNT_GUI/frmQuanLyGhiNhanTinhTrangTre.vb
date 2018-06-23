Imports QLNT_BUS
Imports QLNT_DTO
Imports Utility
Public Class frmQuanLyGhiNhanTinhTrangTre
    Private ghinhanBUS As GhiNhanTinhTrangBUS
    Private khBUS As KhoiBUS
    Private lpBUS As LopBUS
    Private teBUS As TreEmBUS
    Private ttBUS As TinhTrangBUS
    Private maTreEm As String
    Private newGhiNhan As Boolean

    Private Sub frmGhiNhanTinhTrangTre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ghinhanBUS = New GhiNhanTinhTrangBUS
        khBUS = New KhoiBUS
        lpBUS = New LopBUS
        teBUS = New TreEmBUS
        ttBUS = New TinhTrangBUS
        loadListTreEm()
        loadListGhiNhan()
        loadCBLop()
        newGhiNhan = False

    End Sub

    Private Sub loadListTreEm() 'Load list tre em vao datagridview

        Dim listTreEm = New List(Of TreEmDTO)
        Dim result As Result
        result = teBUS.selectALLbyMaLopIsNotNull(listTreEm)
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
        clTenPhuHuynh.Name = "MaLop"
        clTenPhuHuynh.HeaderText = "Mã Lớp"
        clTenPhuHuynh.DataPropertyName = "StrMaLop1"
        clTenPhuHuynh.ReadOnly = True
        dgvDanhSachTreEm.Columns.Add(clTenPhuHuynh)

        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(dgvDanhSachTreEm.DataSource)
        myCurrencyManager.Refresh()
        If (dgvDanhSachTreEm.RowCount > 0) Then
            Dim te = CType(dgvDanhSachTreEm.Rows(dgvDanhSachTreEm.CurrentCellAddress.Y).DataBoundItem, TreEmDTO)
            maTreEm = te.StrMaTreEm1
        End If
    End Sub

    Private Sub loadListTreEmSelectByClass() 'Load list tre em vao datagridview

        Dim listTreEm = New List(Of TreEmDTO)
        Dim result As Result
        result = teBUS.selectALLbyMaLop(False, cbLop.SelectedValue, listTreEm)
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



        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(dgvDanhSachGhiNhan.DataSource)
        myCurrencyManager.Refresh()

    End Sub

    Private Sub loadListGhiNhanSelectByMaTreEm() 'Load du lieu vao datagridview
        Dim listGhiNhan = New List(Of GhiNhanTinhTrangDTO)
        Dim result As Result
        result = ghinhanBUS.selectALLByMaTreEm(maTreEm, listGhiNhan)
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
        clMaTreEm.Name = "MaTreEm"
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



        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(dgvDanhSachGhiNhan.DataSource)
        myCurrencyManager.Refresh()

    End Sub

    Private Sub loadCBTinhTrang() 'Load cbTinhTrang 
        Dim listTinhTrang = New List(Of TinhTrangDTO)
        Dim result As Result
        result = ttBUS.selectALL(listTinhTrang)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách trẻ em không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        cbTinhTrang.DataSource = New BindingSource(listTinhTrang, String.Empty)
        cbTinhTrang.DisplayMember = "StrTenTinhTrang1"
        cbTinhTrang.ValueMember = "StrMaTinhTrang1"
        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(cbTinhTrang.DataSource)
        myCurrencyManager.Refresh()
    End Sub

    Private Sub loadCBLop() 'Load cbTinhTrang 
        Dim listLop = New List(Of LopDTO)
        Dim result As Result
        result = lpBUS.selectALL(listLop)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách lớp không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        cbLop.DataSource = New BindingSource(listLop, String.Empty)
        cbLop.DisplayMember = "StrTenLop1"
        cbLop.ValueMember = "StrMaLop1"

        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(cbLop.DataSource)
        myCurrencyManager.Refresh()
    End Sub

    Private Sub cbLop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbLop.SelectedIndexChanged
        If (CheckBox1.Checked = True) Then
            loadListTreEmSelectByClass()
        End If
    End Sub

    Private Sub dgvDanhSachTreEm_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvDanhSachTreEm.CellMouseClick
        Dim currentRowIndex As Integer = dgvDanhSachTreEm.CurrentCellAddress.Y 'Cap nhat du lieu tu datagridview
        If (-1 < currentRowIndex And currentRowIndex < dgvDanhSachTreEm.RowCount) Then
            Try
                Dim te = CType(dgvDanhSachTreEm.Rows(currentRowIndex).DataBoundItem, TreEmDTO)


                Dim khoiInfo = New KhoiDTO 'Lay ten tre em trong sql
                Dim result As Result
                result = teBUS.getKhoiByID(te.StrMaTreEm1, khoiInfo)
                If (result.FlagResult = False) Then
                    MessageBox.Show("Lấy thông tin khối không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                    Return
                End If
                maTreEm = te.StrMaTreEm1
                If (newGhiNhan = True) Then
                    txtHoTenTre.Text = te.StrHoTenTreEm1
                    txtTenKhoi.Text = khoiInfo.StrTenKhoi1
                End If
                If (CheckBox2.Checked = True) Then
                    loadListGhiNhanSelectByMaTreEm()
                End If
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try
        End If
    End Sub
    'Private Sub dgvDanhSachTreEm_SelectionChanged(sender As Object, e As EventArgs) Handles dgvDanhSachTreEm.SelectionChanged
    '    Dim currentRowIndex As Integer = dgvDanhSachTreEm.CurrentCellAddress.Y 'Cap nhat du lieu tu datagridview
    '    If (-1 < currentRowIndex And currentRowIndex < dgvDanhSachTreEm.RowCount) Then
    '        Try
    '            Dim te = CType(dgvDanhSachTreEm.Rows(currentRowIndex).DataBoundItem, TreEmDTO)


    '            Dim khoiInfo = New KhoiDTO 'Lay ten tre em trong sql
    '            Dim result As Result
    '            result = teBUS.getKhoiByID(te.StrMaTreEm1, khoiInfo)
    '            If (result.FlagResult = False) Then
    '                MessageBox.Show("Lấy thông tin khối không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                System.Console.WriteLine(result.SystemMessage)
    '                Return
    '            End If
    '            maTreEm = te.StrMaTreEm1
    '            If (newGhiNhan = True) Then
    '                txtHoTenTre.Text = te.StrHoTenTreEm1
    '                txtTenKhoi.Text = khoiInfo.StrTenKhoi1
    '            End If
    '            If (CheckBox2.Checked = True) Then
    '                loadListGhiNhanSelectByMaTreEm()
    '            End If
    '        Catch ex As Exception
    '            Console.WriteLine(ex.StackTrace)
    '        End Try
    '    End If
    'End Sub

    Private Sub dgvDanhSachGhiNhan_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvDanhSachGhiNhan.CellMouseClick
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvDanhSachGhiNhan.CurrentCellAddress.Y
        If (-1 < currentRowIndex And currentRowIndex < dgvDanhSachGhiNhan.RowCount) Then
            Try
                Dim ghinhan = CType(dgvDanhSachGhiNhan.Rows(currentRowIndex).DataBoundItem, GhiNhanTinhTrangDTO)
                txtMaGhiNhan.Text = ghinhan.StrMaPhieuGhiNhan1
                dtpNgayGhiNhan.Value = ghinhan.DateNgayGhiNhan1.ToShortDateString

                Dim treEmInfo = New TreEmDTO 'Lay ten tre em trong sql
                Dim result As Result
                result = teBUS.searchByID(ghinhan.StrMaTreEm1, treEmInfo)
                If (result.FlagResult = False) Then
                    MessageBox.Show("Lấy thông tin trẻ em không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                    Return
                End If

                Dim khoiInfo = New KhoiDTO 'Lay ten khoi trong sql
                result = teBUS.getKhoiByID(treEmInfo.StrMaTreEm1, khoiInfo)
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
                loadCBTinhTrang()
                cbTinhTrang.Text = tinhTrangInfo.StrTenTinhTrang1
                txtHoTenTre.Text = treEmInfo.StrHoTenTreEm1
                txtTenKhoi.Text = khoiInfo.StrTenKhoi1
                maTreEm = ghinhan.StrMaTreEm1


                newGhiNhan = False
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try
        End If
    End Sub

    Private Sub btnXoaGhiNhan_Click(sender As Object, e As EventArgs) Handles btnXoaGhiNhan.Click
        If (txtMaGhiNhan.Text = Nothing) Then
            MessageBox.Show("Chọn ghi nhận cần xoá trong danh sách ghi nhận .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If (dgvDanhSachTreEm.RowCount > 0) Then
            Dim result As Result
            result = ghinhanBUS.deleteByID(txtMaGhiNhan.Text)
            If (result.FlagResult = False) Then
                MessageBox.Show("Xoá ghi nhận không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
                Return
            End If
            If (CheckBox2.Checked = True) Then
                loadListGhiNhanSelectByMaTreEm()
            Else
                loadListGhiNhan()
            End If
            txtMaGhiNhan.Text = String.Empty
            txtHoTenTre.Text = String.Empty
            txtTenKhoi.Text = String.Empty
            dtpNgayGhiNhan.Value = DateTime.Now
            cbTinhTrang.Text = String.Empty
        Else
            MessageBox.Show("Không còn ghi nhận để xoá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Close()
    End Sub

    Private Sub btnThemGhiNhan_Click(sender As Object, e As EventArgs) Handles btnThemGhiNhan.Click

        Dim result As Result
        Dim nextMsgn = "1"
        result = ghinhanBUS.buildMSGN(nextMsgn)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh tự động mã ghi nhận không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        txtMaGhiNhan.Text = nextMsgn
        txtHoTenTre.Text = "Vui long chon tre em  --> "
        txtTenKhoi.Text = String.Empty
        dtpNgayGhiNhan.Value = DateTime.Now
        loadCBTinhTrang()
        newGhiNhan = True
    End Sub

    Private Sub btnCapNhatGhiNhan_Click(sender As Object, e As EventArgs) Handles btnCapNhatGhiNhan.Click
        If (txtMaGhiNhan.Text = Nothing) Then
            MessageBox.Show("Cập nhật ghi nhận không hợp lệ .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Dim ghinhan As GhiNhanTinhTrangDTO
        ghinhan = New GhiNhanTinhTrangDTO()
        '1. Mapping data from GUI control
        ghinhan.StrMaPhieuGhiNhan1 = txtMaGhiNhan.Text
        ghinhan.StrMaTreEm1 = maTreEm
        ghinhan.DateNgayGhiNhan1 = dtpNgayGhiNhan.Value.ToShortDateString
        ghinhan.StrMaTinhTrang1 = cbTinhTrang.SelectedValue
        '2. Insert to DB
        If (txtTenKhoi.Text = Nothing) Then
            MessageBox.Show("Chọn trẻ em trước khi thêm ghi nhận .", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        If (newGhiNhan = True) Then
            newGhiNhan = False
            Dim result As Result
            result = ghinhanBUS.insert(ghinhan)
            If (result.FlagResult = True) Then
                MessageBox.Show("Thêm ghi nhận thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Thêm ghi nhận không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
        Else
            Dim result As Result
            result = ghinhanBUS.updatetByID(ghinhan)
            If (result.FlagResult = True) Then
                MessageBox.Show("Cập nhật ghi nhận thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Cập nhật ghi nhận không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

        End If
        If (CheckBox2.Checked = True) Then
            loadListGhiNhanSelectByMaTreEm()
        Else
            loadListGhiNhan()
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If (CheckBox1.Checked = True) Then
            Label6.Visible = True
            cbLop.Visible = True
            loadListTreEmSelectByClass()
        Else
            Label6.Visible = False
            cbLop.Visible = False
            loadListTreEm()
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If (CheckBox2.Checked = True) Then
            loadListGhiNhanSelectByMaTreEm()
        Else
            loadListGhiNhan()
        End If
    End Sub


End Class