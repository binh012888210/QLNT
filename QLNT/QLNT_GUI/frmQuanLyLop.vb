Imports QLNT_BUS
Imports QLNT_DTO
Imports Utility
Public Class frmQuanLyLop
    Private khBUS As KhoiBUS
    Private lpBUS As LopBUS
    Private teBUS As TreEmBUS
    Private tsBUS As ThamSoBUS
    Private Sub frmQuanLyLop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        khBUS = New KhoiBUS
        lpBUS = New LopBUS
        teBUS = New TreEmBUS
        tsBUS = New ThamSoBUS
        'Load Khoi List
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
        txtMaKhoi.Text = cbKhoi.SelectedValue.ToString
    End Sub

    Private Sub cbKhoi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbKhoi.SelectedIndexChanged
        ''Load lop
        Try
            Dim khoi = CType(cbKhoi.SelectedItem, KhoiDTO)
            Dim listLop = New List(Of LopDTO)
            Dim Result2 = lpBUS.selectALL_ByKhoi(khoi.StrMaKhoi1, listLop)
            If (Result2.FlagResult = False) Then
                MessageBox.Show("Lấy danh sách lớp theo khối không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(Result2.SystemMessage)
                Return
            End If

            cbLop.DataSource = New BindingSource(listLop, String.Empty)
            cbLop.DisplayMember = "StrTenLop1"
            cbLop.ValueMember = "StrMaLop1"
            Dim myCurrencyManager As CurrencyManager = Me.BindingContext(cbLop.DataSource)
            myCurrencyManager.Refresh()
            If (listLop.Count > 0) Then
                cbLop.SelectedIndex = 0
            End If
        Catch ex As Exception
            System.Console.WriteLine(ex.StackTrace)

        End Try

        loadListTreEmChuaCoLop()
        loadListTreEmCoLop()
        txtMaLop.Text = cbLop.SelectedValue.ToString
    End Sub
    Private Sub cbLop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbLop.SelectedIndexChanged
        txtMaKhoi.Text = cbKhoi.SelectedValue.ToString 'Chu Y
        txtMaLop.Text = cbLop.SelectedValue.ToString
        loadListTreEmCoLop()
    End Sub
    Private Sub loadListTreEmChuaCoLop()
        Dim listTreEm = New List(Of TreEmDTO)
        Dim result3 As Result
        result3 = teBUS.selectALLbyMaLop(True, cbLop.SelectedValue.ToString, listTreEm)
        If (result3.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách trẻ em không thành công.1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result3.SystemMessage)
            Return
        End If
        dgvTreEmChuaCoLop.Columns.Clear()
        dgvTreEmChuaCoLop.DataSource = Nothing

        dgvTreEmChuaCoLop.AutoGenerateColumns = False
        dgvTreEmChuaCoLop.AllowUserToAddRows = False
        dgvTreEmChuaCoLop.DataSource = listTreEm

        Dim clMaTreEm = New DataGridViewTextBoxColumn()
        clMaTreEm.Name = "MaTreEm"
        clMaTreEm.HeaderText = "Mã Trẻ Em"
        clMaTreEm.DataPropertyName = "StrMaTreEm1" ''ten trong DTO
        clMaTreEm.ReadOnly = True
        dgvTreEmChuaCoLop.Columns.Add(clMaTreEm)

        Dim clTenTreEm = New DataGridViewTextBoxColumn()
        clTenTreEm.Name = "HoTenTreEm"
        clTenTreEm.HeaderText = "Tên Trẻ Em"
        clTenTreEm.DataPropertyName = "StrHoTenTreEm1" 'ten trong DTO
        clTenTreEm.ReadOnly = True
        dgvTreEmChuaCoLop.Columns.Add(clTenTreEm)

        Dim clTenPhuHuynh = New DataGridViewTextBoxColumn()
        clTenPhuHuynh.Name = "TenPhuHuynh"
        clTenPhuHuynh.HeaderText = "Tên Phụ Huynh"
        clTenPhuHuynh.DataPropertyName = "StrHoTenPhuHuynh1" 'ten trong DTO
        clTenPhuHuynh.ReadOnly = True
        dgvTreEmChuaCoLop.Columns.Add(clTenPhuHuynh)


        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(dgvTreEmChuaCoLop.DataSource)
        myCurrencyManager.Refresh()
    End Sub
    Private Sub loadListTreEmCoLop()

        Dim listTreEm = New List(Of TreEmDTO)
        Dim result3 As Result
        result3 = teBUS.selectALLbyMaLop(False, cbLop.SelectedValue.ToString, listTreEm)
        If (result3.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách trẻ em không thành công.2", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result3.SystemMessage)
            Return
        End If
        dgvTreEmCoLop.Columns.Clear()
        dgvTreEmCoLop.DataSource = Nothing

        dgvTreEmCoLop.AutoGenerateColumns = False
        dgvTreEmCoLop.AllowUserToAddRows = False
        dgvTreEmCoLop.DataSource = listTreEm

        Dim clMaTreEm = New DataGridViewTextBoxColumn()
        clMaTreEm.Name = "MaTreEm"
        clMaTreEm.HeaderText = "Mã Trẻ Em"
        clMaTreEm.DataPropertyName = "StrMaTreEm1" ''ten trong DTO
        clMaTreEm.ReadOnly = True
        dgvTreEmCoLop.Columns.Add(clMaTreEm)

        Dim clTenTreEm = New DataGridViewTextBoxColumn()
        clTenTreEm.Name = "HoTenTreEm"
        clTenTreEm.HeaderText = "Tên Trẻ Em"
        clTenTreEm.DataPropertyName = "StrHoTenTreEm1" 'ten trong DTO
        clTenTreEm.ReadOnly = True
        dgvTreEmCoLop.Columns.Add(clTenTreEm)

        Dim clMaLop = New DataGridViewTextBoxColumn()
        clMaLop.Name = "MaLop"
        clMaLop.HeaderText = "Mã Lớp"
        clMaLop.DataPropertyName = "StrMaLop1" 'ten trong DTO
        clMaLop.ReadOnly = True
        dgvTreEmCoLop.Columns.Add(clMaLop)


        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(dgvTreEmCoLop.DataSource)
        myCurrencyManager.Refresh()

        txtSoTreEmCuaLop.Text = dgvTreEmCoLop.RowCount.ToString
    End Sub

    Private Sub dgvTreEmCoLop_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvTreEmCoLop.CellMouseClick
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvTreEmCoLop.CurrentCellAddress.Y 'Cap nhat du lieu tu datagridview
        If (-1 < currentRowIndex And currentRowIndex < dgvTreEmCoLop.RowCount) Then
            Try
                Dim te = CType(dgvTreEmCoLop.Rows(currentRowIndex).DataBoundItem, TreEmDTO)
                txtMaLop1.Text = te.StrMaLop1
                txtMaSoTreEm.Text = te.StrMaTreEm1
                txtHoTen.Text = te.StrHoTenTreEm1
                txtTuoi.Text = te.StrTuoi1
                dtpNgayNhapHoc.Text = te.DateNgayNhapHoc1.ToShortDateString()
                txtGhiChu.Text = te.StrGhiChu1
                btnCapNhat.Visible = True
                btnXoaKhoiLop.Visible = True
                btnThemVaoLop.Visible = False
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try
        End If
    End Sub
    Private Sub dgvTreEmChuaCoLop_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvTreEmChuaCoLop.CellMouseClick
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvTreEmChuaCoLop.CurrentCellAddress.Y 'Cap nhat du lieu tu datagridview
        If (-1 < currentRowIndex And currentRowIndex < dgvTreEmChuaCoLop.RowCount) Then
            Try
                Dim te = CType(dgvTreEmChuaCoLop.Rows(currentRowIndex).DataBoundItem, TreEmDTO)
                txtMaLop1.Text = "Trẻ em chưa được xếp lớp"
                txtMaSoTreEm.Text = te.StrMaTreEm1
                txtHoTen.Text = te.StrHoTenTreEm1
                txtTuoi.Text = te.StrTuoi1
                dtpNgayNhapHoc.Text = Date.Now
                txtGhiChu.Text = String.Empty
                btnCapNhat.Visible = False
                btnXoaKhoiLop.Visible = False
                btnThemVaoLop.Visible = True
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try
        End If
    End Sub

    Private Sub btnThemVaoLop_Click(sender As Object, e As EventArgs) Handles btnThemVaoLop.Click
        Dim treem As TreEmDTO
        treem = New TreEmDTO()
        If (txtGhiChu.Text = Nothing) Then
            MessageBox.Show("Vui lòng điền vào ghi chú.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        '1. Mapping data from GUI control
        treem.StrMaTreEm1 = txtMaSoTreEm.Text
        treem.StrMaLop1 = txtMaLop.Text
        treem.DateNgayNhapHoc1 = dtpNgayNhapHoc.Value.ToShortDateString
        treem.StrGhiChu1 = txtGhiChu.Text
        '2. Insert to DB
        Dim result As Result
        result = teBUS.insert2(treem)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm trẻ '" + txtHoTen.Text + "' vào lớp '" + cbLop.Text + "' thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            System.Console.WriteLine(result.SystemMessage)
        Else
            MessageBox.Show("Thêm trẻ '" + txtHoTen.Text + "' vào lớp '" + cbLop.Text + "' không thành công", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
        loadListTreEmChuaCoLop()
        loadListTreEmCoLop()
    End Sub
    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        Dim treem As TreEmDTO
        treem = New TreEmDTO()
        If (txtGhiChu.Text = Nothing) Then
            MessageBox.Show("Vui lòng điền vào ghi chú.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        '1. Mapping data from GUI control
        treem.StrMaTreEm1 = txtMaSoTreEm.Text
        treem.StrMaLop1 = txtMaLop.Text
        treem.DateNgayNhapHoc1 = dtpNgayNhapHoc.Value.ToShortDateString
        treem.StrGhiChu1 = txtGhiChu.Text
        '2. Insert to DB
        Dim result As Result
        result = teBUS.insert2(treem)
        If (result.FlagResult = True) Then
            MessageBox.Show("Cập nhật trẻ '" + txtHoTen.Text + "' thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            System.Console.WriteLine(result.SystemMessage)
        Else
            MessageBox.Show("Cập nhật trẻ '" + txtHoTen.Text + "' không thành công", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
        loadListTreEmChuaCoLop()
        loadListTreEmCoLop()
    End Sub
    Private Sub btnChuyenLop_Click(sender As Object, e As EventArgs) Handles btnChuyenLop.Click
        Dim frm As frmChuyenLop = New frmChuyenLop()
        frm.ShowDialog()
        loadListTreEmCoLop()
    End Sub

    Private Sub btnXoaKhoiLop_Click(sender As Object, e As EventArgs) Handles btnXoaKhoiLop.Click
        Dim treem As TreEmDTO
        treem = New TreEmDTO()
        '1. Mapping data from GUI control
        treem.StrMaTreEm1 = txtMaSoTreEm.Text
        '2. Insert to DB
        Dim result As Result
        result = teBUS.deleteClassByID(txtMaSoTreEm.Text)
        If (result.FlagResult = True) Then
            MessageBox.Show("Xoá trẻ '" + txtHoTen.Text + "' khỏi lớp '" + cbLop.Text + "' thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Xoá trẻ '" + txtHoTen.Text + "' khỏi lớp '" + cbLop.Text + "' không thành công", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        txtMaSoTreEm.Text = String.Empty
        txtMaLop1.Text = String.Empty
        txtHoTen.Text = String.Empty
        txtTuoi.Text = String.Empty
        dtpNgayNhapHoc.Value.ToShortDateString()
        txtGhiChu.Text = String.Empty
        loadListTreEmChuaCoLop()
        loadListTreEmCoLop()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Close()
    End Sub
    Private Sub txtSearchName_TextChanged(sender As Object, e As EventArgs) Handles txtSearchName.TextChanged 'tim kiem theo ten tre em hoac ten phu huynh

        Dim listTreEm = New List(Of TreEmDTO)
        Dim result As Result
        result = teBUS.searchByTextAndMaLopIsNull(txtSearchName.Text, listTreEm)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách trẻ em không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        dgvTreEmChuaCoLop.Columns.Clear()
        dgvTreEmChuaCoLop.DataSource = Nothing

        dgvTreEmChuaCoLop.AutoGenerateColumns = False
        dgvTreEmChuaCoLop.AllowUserToAddRows = False
        dgvTreEmChuaCoLop.DataSource = listTreEm

        Dim clMaTreEm = New DataGridViewTextBoxColumn()
        clMaTreEm.Name = "MaTreEm"
        clMaTreEm.HeaderText = "Mã Trẻ Em"
        clMaTreEm.DataPropertyName = "StrMaTreEm1"
        clMaTreEm.ReadOnly = True
        dgvTreEmChuaCoLop.Columns.Add(clMaTreEm)

        Dim clTenTreEm = New DataGridViewTextBoxColumn()
        clTenTreEm.Name = "HoTenTreEm"
        clTenTreEm.HeaderText = "Tên Trẻ Em"
        clTenTreEm.DataPropertyName = "StrHoTenTreEm1"
        clTenTreEm.ReadOnly = True
        dgvTreEmChuaCoLop.Columns.Add(clTenTreEm)

        Dim clTenPhuHuynh = New DataGridViewTextBoxColumn()
        clTenPhuHuynh.Name = "TenPhuHuynh"
        clTenPhuHuynh.HeaderText = "Tên Phụ Huynh"
        clTenPhuHuynh.DataPropertyName = "StrHoTenPhuHuynh1" '
        clTenPhuHuynh.ReadOnly = True
        dgvTreEmChuaCoLop.Columns.Add(clTenPhuHuynh)


        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(dgvTreEmChuaCoLop.DataSource)
        myCurrencyManager.Refresh()

    End Sub
End Class