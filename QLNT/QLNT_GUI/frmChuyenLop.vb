Imports QLNT_BUS
Imports QLNT_DTO
Imports Utility
Public Class frmChuyenLop
    Private lpBUS As LopBUS
    Private teBUS As TreEmBUS
    Private tsBUS As ThamSoBUS
    Private khBUS As KhoiBUS
    Private listLopFROM As List(Of LopDTO)

    Private Sub frmChuyenLop_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lpBUS = New LopBUS
        teBUS = New TreEmBUS
        tsBUS = New ThamSoBUS
        khBUS = New KhoiBUS
        listLopFROM = New List(Of LopDTO)

        If (txtMaKhoi.Text = Nothing) Then 'Day la truong hop chuyen lop trong frmMainMenu
            cbMaKhoi.Visible = True 'Hien cbKhoi de chon khoi do khi mo form nay trong main menu thi txtMaKhoi se khong co san
            Dim listKhoi = New List(Of KhoiDTO)
            Dim result1 As Result
            result1 = khBUS.selectALL(listKhoi)
            If (result1.FlagResult = False) Then
                MessageBox.Show("Lấy danh sách khối không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result1.SystemMessage)
                Me.Close()
                Return
            End If
            cbMaKhoi.DataSource = New BindingSource(listKhoi, String.Empty)
            cbMaKhoi.DisplayMember = "StrTenKhoi1"
            cbMaKhoi.ValueMember = "StrMaKhoi1"
            Dim myCurrencyManager As CurrencyManager = Me.BindingContext(cbMaKhoi.DataSource)
            myCurrencyManager.Refresh()
            If (listKhoi.Count > 0) Then
                cbMaKhoi.SelectedIndex = 0
            End If
            Return
        End If

        Try
            If (cbMaKhoi.Visible = False) Then 'Day la truong hop chuyen lop mo trong frmQuanLyLop
                'Load danh sach lop hoc sinh chuyen tu
                Dim Result = lpBUS.selectALL_ByKhoi(txtMaKhoi.Text, listLopFROM)
                If (Result.FlagResult = False) Then
                    MessageBox.Show("Lấy danh sách học sinh từ lớp không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(Result.SystemMessage)
                    Return
                End If

                cbTuLop.DataSource = New BindingSource(listLopFROM, String.Empty)
                cbTuLop.DisplayMember = "StrTenLop1"
                cbTuLop.ValueMember = "StrMaLop1"
                Dim myCurrencyManager As CurrencyManager = Me.BindingContext(cbTuLop.DataSource)
                myCurrencyManager.Refresh()
                If (listLopFROM.Count > 0) Then
                    cbTuLop.SelectedIndex = 0
                End If
                'Load danh sach lop hoc sinh chyen sang
                Dim listLopTO = New List(Of LopDTO)
                listLopTO = buildListLopTo(listLopFROM) 'Tao danh sach lop khac voi (danh sach lop hoc sinh chuyen tu)
                cbSangLop.DataSource = New BindingSource(listLopTO, String.Empty)
                cbSangLop.DisplayMember = "StrTenLop1"
                cbSangLop.ValueMember = "StrMaLop1"
                Dim myCurrencyManager1 As CurrencyManager = Me.BindingContext(cbSangLop.DataSource)
                myCurrencyManager1.Refresh()
                If (listLopTO.Count > 0) Then
                    cbSangLop.SelectedIndex = 0
                End If
            End If

        Catch ex As Exception
            System.Console.WriteLine(ex.StackTrace)
        End Try
        loadListTreEmTuLop() 'load lai danh sach khi co thay doi
        loadListTreEmSangLop() 'load lai danh sach khi co thay doi

    End Sub

    Private Sub cbMaKhoi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMaKhoi.SelectedIndexChanged 'Chuyen lop trong frmMainMenu

        If (cbMaKhoi.Visible = True) Then
            'Load danh sach lop hoc sinh chuyen tu
            Dim khoi = CType(cbMaKhoi.SelectedItem, KhoiDTO)
            Dim Result = lpBUS.selectALL_ByKhoi(khoi.StrMaKhoi1, listLopFROM)
            If (Result.FlagResult = False) Then
                MessageBox.Show("Lấy danh sách học sinh từ lớp không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(Result.SystemMessage)
                Return
            End If

            cbTuLop.DataSource = New BindingSource(listLopFROM, String.Empty)
            cbTuLop.DisplayMember = "StrTenLop1"
            cbTuLop.ValueMember = "StrMaLop1"
            Dim myCurrencyManager As CurrencyManager = Me.BindingContext(cbTuLop.DataSource)
            myCurrencyManager.Refresh()
            If (listLopFROM.Count > 0) Then
                cbTuLop.SelectedIndex = 0
            End If

            'Load danh sach lop hoc sinh chyen sang
            Dim listLopTO = New List(Of LopDTO)
            listLopTO = buildListLopTo(listLopFROM) 'Tao danh sach lop khac voi (danh sach lop chuyen tu)
            cbSangLop.DataSource = New BindingSource(listLopTO, String.Empty)
            cbSangLop.DisplayMember = "StrTenLop1"
            cbSangLop.ValueMember = "StrMaLop1"
            Dim myCurrencyManager1 As CurrencyManager = Me.BindingContext(cbSangLop.DataSource)
            myCurrencyManager1.Refresh()
            If (listLopTO.Count > 0) Then

                cbSangLop.SelectedIndex = 0
            End If
            txtMaKhoi.Text = khoi.StrMaKhoi1
        End If

    End Sub

    Private Function buildListLopTo(listLopFROM As List(Of LopDTO)) As List(Of LopDTO)

        Dim listLopTo = New List(Of LopDTO)
        If (listLopFROM.Count < 1) Then
            Return listLopTo
        End If
        For n = 0 To listLopFROM.Count - 1
            If (n <> cbTuLop.SelectedIndex) Then 'Kiem tra khong lay gia tri giong voi cbTuLop
                listLopTo.Add(listLopFROM(n))
            End If
        Next n
        Return listLopTo

    End Function

    Private Sub cbSangLop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSangLop.SelectedIndexChanged
        loadListTreEmSangLop() 'load lai danh sach khi co thay doi
    End Sub

    Private Sub cbTuLop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTuLop.SelectedIndexChanged 'Kiem tra khi gia tri cbTuLop thay doi

        Try
            Dim lopFROM = CType(cbTuLop.SelectedItem, LopDTO) 'Load lai cbSangLop 
            Dim listLopTO = buildListLopTo(listLopFROM)
            cbSangLop.DataSource = New BindingSource(listLopTO, String.Empty)
            cbSangLop.DisplayMember = "StrTenLop1"
            cbSangLop.ValueMember = "StrMaLop1"
            Dim myCurrencyManager1 As CurrencyManager = Me.BindingContext(cbSangLop.DataSource)
            myCurrencyManager1.Refresh()
            If (listLopTO.Count > 0) Then
                cbSangLop.SelectedIndex = 0
            End If
        Catch ex As Exception
            System.Console.WriteLine(ex.StackTrace)
            Return
        End Try
        loadListTreEmTuLop() 'load lai danh sach khi co thay doi
        loadListTreEmSangLop() 'load lai danh sach khi co thay doi

    End Sub

    Private Sub loadListTreEmTuLop() 'Load du lieu vao datagridview

        Dim listTreEm = New List(Of TreEmDTO)
        Dim result As Result
        result = teBUS.selectALLbyMaLop(False, cbTuLop.SelectedValue.ToString, listTreEm)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách trẻ em không thành công.2", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        dgvListHS_FROM.Columns.Clear()
        dgvListHS_FROM.DataSource = Nothing

        dgvListHS_FROM.AutoGenerateColumns = False
        dgvListHS_FROM.AllowUserToAddRows = False
        dgvListHS_FROM.DataSource = listTreEm

        Dim clMaTreEm = New DataGridViewTextBoxColumn()
        clMaTreEm.Name = "MaTreEm"
        clMaTreEm.HeaderText = "Mã Trẻ Em"
        clMaTreEm.DataPropertyName = "StrMaTreEm1" ''ten trong DTO
        clMaTreEm.ReadOnly = True
        dgvListHS_FROM.Columns.Add(clMaTreEm)

        Dim clTenTreEm = New DataGridViewTextBoxColumn()
        clTenTreEm.Name = "HoTenTreEm"
        clTenTreEm.HeaderText = "Tên Trẻ Em"
        clTenTreEm.DataPropertyName = "StrHoTenTreEm1" 'ten trong DTO
        clTenTreEm.ReadOnly = True
        dgvListHS_FROM.Columns.Add(clTenTreEm)

        Dim clMaLop = New DataGridViewTextBoxColumn()
        clMaLop.Name = "MaLop"
        clMaLop.HeaderText = "Mã Lớp"
        clMaLop.DataPropertyName = "StrMaLop1" 'ten trong DTO
        clMaLop.ReadOnly = True
        dgvListHS_FROM.Columns.Add(clMaLop)


        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(dgvListHS_FROM.DataSource)
        myCurrencyManager.Refresh()

        txtSiSoLopTu.Text = dgvListHS_FROM.RowCount.ToString
    End Sub
    Private Sub loadListTreEmSangLop() 'Load du lieu vao datagridview

        Dim listTreEm = New List(Of TreEmDTO)
        Dim result As Result
        result = teBUS.selectALLbyMaLop(False, cbSangLop.SelectedValue.ToString, listTreEm)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách trẻ em không thành công.2", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        dgvListHS_To.Columns.Clear()
        dgvListHS_To.DataSource = Nothing

        dgvListHS_To.AutoGenerateColumns = False
        dgvListHS_To.AllowUserToAddRows = False
        dgvListHS_To.DataSource = listTreEm

        Dim clMaTreEm = New DataGridViewTextBoxColumn()
        clMaTreEm.Name = "MaTreEm"
        clMaTreEm.HeaderText = "Mã Trẻ Em"
        clMaTreEm.DataPropertyName = "StrMaTreEm1" ''ten trong DTO
        clMaTreEm.ReadOnly = True
        dgvListHS_To.Columns.Add(clMaTreEm)

        Dim clTenTreEm = New DataGridViewTextBoxColumn()
        clTenTreEm.Name = "HoTenTreEm"
        clTenTreEm.HeaderText = "Tên Trẻ Em"
        clTenTreEm.DataPropertyName = "StrHoTenTreEm1" 'ten trong DTO
        clTenTreEm.ReadOnly = True
        dgvListHS_To.Columns.Add(clTenTreEm)

        Dim clMaLop = New DataGridViewTextBoxColumn()
        clMaLop.Name = "MaLop"
        clMaLop.HeaderText = "Mã Lớp"
        clMaLop.DataPropertyName = "StrMaLop1" 'ten trong DTO
        clMaLop.ReadOnly = True
        dgvListHS_To.Columns.Add(clMaLop)


        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(dgvListHS_To.DataSource)
        myCurrencyManager.Refresh()

        txtSiSoLopSang.Text = dgvListHS_To.RowCount.ToString
    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Close()
    End Sub

    Private Sub btnFROMTo_Click(sender As Object, e As EventArgs) Handles btnFROMTo.Click 'Chuyen tu trai qua phai

        If (tsBUS.KiemTraSiSo(dgvListHS_To.RowCount)) Then 'kiem tra xem lop co thoa yeu cau si so toi da
            Dim currentRowIndex As Integer = dgvListHS_FROM.CurrentCellAddress.Y
            If (-1 < currentRowIndex And currentRowIndex < dgvListHS_FROM.RowCount) Then
                Dim te = CType(dgvListHS_FROM.Rows(currentRowIndex).DataBoundItem, TreEmDTO)
                Dim TreEmDuocChuyen = New TreEmDTO
                Dim result As Result
                result = teBUS.chuyenLopTreEM(te, cbSangLop.SelectedValue)
                If (result.FlagResult = False) Then
                    MessageBox.Show("Chuyen lớp khong thành cong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                    Return
                End If
            End If
            loadListTreEmTuLop()
            loadListTreEmSangLop()
        Else
            MessageBox.Show("Danh sách lớp đã đầy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

    End Sub

    Private Sub btnToFROM_Click(sender As Object, e As EventArgs) Handles btnToFROM.Click 'Chuyen tu phai qua trai

        If (tsBUS.KiemTraSiSo(dgvListHS_FROM.RowCount)) Then 'Kiem tra xem lop co thoa yeu cau si so toi da
            Dim currentRowIndex As Integer = dgvListHS_To.CurrentCellAddress.Y
            If (-1 < currentRowIndex And currentRowIndex < dgvListHS_To.RowCount) Then
                Dim te = CType(dgvListHS_To.Rows(currentRowIndex).DataBoundItem, TreEmDTO)
                Dim TreEmDuocChuyen = New TreEmDTO
                Dim result As Result
                result = teBUS.chuyenLopTreEM(te, cbTuLop.SelectedValue)
                If (result.FlagResult = False) Then
                    MessageBox.Show("Chuyen lớp khong thành cong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                    Return
                End If
            End If
            loadListTreEmTuLop()
            loadListTreEmSangLop()
        Else
            MessageBox.Show("Danh sách lớp đã đầy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

    End Sub

End Class