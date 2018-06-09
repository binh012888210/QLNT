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

    End Sub

    Private Sub cbKhoi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbKhoi.SelectedIndexChanged
        ''Load lop
        Try
            Dim khoi = CType(cbKhoi.SelectedItem, KhoiDTO)
            Dim listLop = New List(Of LopDTO)
            Dim Result2 = lpBUS.selectALL_ByMaNamHoc(khoi.StrMaKhoi1, listLop)
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

    Private Sub btnNhap_Click(sender As Object, e As EventArgs) Handles btnNhap.Click
        Dim frm As frmXepLop = New frmXepLop()
        If (tsBUS.KiemTraSiSo(dgvTreEmCoLop.RowCount)) Then
            Dim currentRowIndex As Integer = dgvTreEmChuaCoLop.CurrentCellAddress.Y
            If (-1 < currentRowIndex And currentRowIndex < dgvTreEmChuaCoLop.RowCount) Then
                Dim te = CType(dgvTreEmChuaCoLop.Rows(currentRowIndex).DataBoundItem, TreEmDTO)
                frm.txtMaSoTreEm.Text = te.StrMaTreEm1
                frm.txtHoTen.Text = te.StrHoTenTreEm1
                frm.txtTuoi.Text = te.IntTuoi1.ToString
                frm.txtMaLop.Text = cbLop.SelectedValue
                frm.ShowDialog()
            Else
                MessageBox.Show("Không có trẻ em nào không có lớp", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                MessageBox.Show("Thêm trẻ em trước khi xếp lớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If
        Else
            MessageBox.Show("Danh sách lớp đã đầy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
    End Sub

    Private Sub btnThemTreEm_Click(sender As Object, e As EventArgs) Handles btnThemTreEm.Click
        Dim frm As frmThemTreEm = New frmThemTreEm()
        frm.Show()
    End Sub

    Private Sub frmQuanLyLop_MouseEnter(sender As Object, e As EventArgs) Handles MyBase.MouseEnter
        loadListTreEmCoLop()
        loadListTreEmChuaCoLop()
    End Sub
End Class