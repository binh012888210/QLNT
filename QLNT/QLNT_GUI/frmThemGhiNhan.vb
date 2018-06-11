Imports QLNT_BUS
Imports QLNT_DTO
Imports Utility
Public Class frmThemGhiNhan
    Private ghinhanBUS As GhiNhanTinhTrangBUS
    Private teBUS As TreEmBUS
    Private khBUS As KhoiBUS
    Private ttBUS As TinhTrangBUS
    Dim strMaKhoi As String

    Private Sub frmThemGhiNhan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ghinhanBUS = New GhiNhanTinhTrangBUS()
        teBUS = New TreEmBUS
        khBUS = New KhoiBUS
        ttBUS = New TinhTrangBUS
        txtHoTenTre.Focus()
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
        loadListTreEmChuaCoGhiNhan()
        loadCBTinhTrang()
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

    Private Sub loadListTreEmChuaCoGhiNhan() 'load danh sach tre em chua co ghi nhan nao

        Dim listTreEm = New List(Of TreEmDTO)
        Dim result As Result
        result = ghinhanBUS.selectByGhiNhanNull(listTreEm)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách trẻ em không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        dgvListTreEm.Columns.Clear()
        dgvListTreEm.DataSource = Nothing

        dgvListTreEm.AutoGenerateColumns = False
        dgvListTreEm.AllowUserToAddRows = False
        dgvListTreEm.DataSource = listTreEm

        Dim clMaTreEm = New DataGridViewTextBoxColumn()
        clMaTreEm.Name = "MaTreEm"
        clMaTreEm.HeaderText = "Mã Trẻ Em"
        clMaTreEm.DataPropertyName = "StrMaTreEm1" ''ten trong DTO
        clMaTreEm.ReadOnly = True
        dgvListTreEm.Columns.Add(clMaTreEm)

        Dim clTenTreEm = New DataGridViewTextBoxColumn()
        clTenTreEm.Name = "HoTenTreEm"
        clTenTreEm.HeaderText = "Tên Trẻ Em"
        clTenTreEm.DataPropertyName = "StrHoTenTreEm1" 'ten trong DTO
        clTenTreEm.ReadOnly = True
        dgvListTreEm.Columns.Add(clTenTreEm)

        Dim clMaLop = New DataGridViewTextBoxColumn()
        clMaLop.Name = "MaLop"
        clMaLop.HeaderText = "Mã Lớp"
        clMaLop.DataPropertyName = "StrMaLop1" 'ten trong DTO
        clMaLop.ReadOnly = True
        dgvListTreEm.Columns.Add(clMaLop)

        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(dgvListTreEm.DataSource)
        myCurrencyManager.Refresh()


    End Sub
    Private Sub dgvListTreEm_SelectionChanged(sender As Object, e As EventArgs) Handles dgvListTreEm.SelectionChanged 'Chon tre em trong danh sach tr em chua co ghi nhan
        Dim currentRowIndex As Integer = dgvListTreEm.CurrentCellAddress.Y
        If (-1 < currentRowIndex And currentRowIndex < dgvListTreEm.RowCount) Then
            Dim treem = CType(dgvListTreEm.Rows(currentRowIndex).DataBoundItem, TreEmDTO)
            txtMaSoTreEm.Text = treem.StrMaTreEm1
            txtHoTenTre.Text = treem.StrHoTenTreEm1

            Dim khoiInfo = New KhoiDTO
            Dim result As Result
            result = khBUS.getKhoiByMaLop(treem.StrMaLop1, khoiInfo) 'Lay ten khoi
            If (result.FlagResult = False) Then
                MessageBox.Show("Lấy thông tin khối không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
                Return
            End If
            txtTenKhoi.Text = khoiInfo.StrTenKhoi1
            strMaKhoi = khoiInfo.StrMaKhoi1
        Else
            MessageBox.Show("Thêm ghi nhận trước khi cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
    End Sub

    Private Sub btnNhap_Click(sender As Object, e As EventArgs) Handles btnNhap.Click 'Thuc hien viec nhap du lieu
        Dim ghinhan As GhiNhanTinhTrangDTO
        ghinhan = New GhiNhanTinhTrangDTO()
        '1. Mapping data from GUI control
        ghinhan.StrMaPhieuGhiNhan1 = txtMaGhiNhan.Text
        ghinhan.StrMaTreEm1 = txtMaSoTreEm.Text
        ghinhan.StrMaKhoi1 = strMaKhoi
        ghinhan.DateNgayGhiNhan1 = dtpNgayGhiNhan.Value
        ghinhan.StrMaTinhTrang1 = cbTinhTrang.SelectedValue
        '2. Insert to DB
        If (txtMaSoTreEm.Text = Nothing) Then
            MessageBox.Show("Thêm trẻ em và xếp lớp trước khi thêm ghi nhận .", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Close()
            Return
        End If

        Dim result As Result
        result = ghinhanBUS.insert(ghinhan)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm ghi nhận thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Close()
        Else
            MessageBox.Show("Thêm ghi nhận không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If

    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Me.Close()
    End Sub
End Class