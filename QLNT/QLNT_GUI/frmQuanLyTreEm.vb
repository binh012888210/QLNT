Imports QLNT_BUS
Imports QLNT_DTO
Imports Utility

Public Class frmQuanLyTreEm
    Private teBUS As TreEmBUS
    Private gnBUS As GhiNhanTinhTrangBUS
    Private tsBUS As ThamSoBUS
    Private newKid As Boolean

    Private Sub frmQuanLyTreEm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        newKid = False
        tsBUS = New ThamSoBUS()
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

    Private Sub dgvDanhSachTreEm_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvDanhSachTreEm.CellMouseClick
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvDanhSachTreEm.CurrentCellAddress.Y 'Cap nhat du lieu tu datagridview
        If (-1 < currentRowIndex And currentRowIndex < dgvDanhSachTreEm.RowCount) Then
            Try
                Dim te = CType(dgvDanhSachTreEm.Rows(currentRowIndex).DataBoundItem, TreEmDTO)
                txtMaSoTreEm.Text = te.StrMaTreEm1
                txtHoTen.Text = te.StrHoTenTreEm1
                dtpNgaySinh.Text = te.DateNgaySinh1.ToShortDateString()
                txtHoTenPhuHuynh.Text = te.StrHoTenPhuHuynh1
                txtTenONha.Text = te.StrTenONha1
                txtDiaChi.Text = te.StrDiaChi1
                txtDienThoai.Text = te.StrDienThoai1
                newKid = False
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try
        End If
    End Sub

    Private Sub btnTaoMoi_Click(sender As Object, e As EventArgs) Handles btnTaoMoi.Click 'Mo form tiep nhan

        newKid = True

        'Xoa noi dung dang co cua textbox
        txtHoTen.Text = String.Empty
        txtHoTenPhuHuynh.Text = String.Empty
        txtTenONha.Text = String.Empty
        txtDiaChi.Text = String.Empty
        txtDienThoai.Text = String.Empty
        dtpNgaySinh.Value = DateTime.Now
        If (chkbxDanTocMienNui.Checked = True) Then
            chkbxDanTocMienNui.Checked = False
        End If

        'tao tu dong ma so tre em
        Dim result As Result
        Dim nextMste = "1"
        result = teBUS.buildMSTE(nextMste)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh tự động mã trẻ em không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        txtMaSoTreEm.Text = nextMste
        If (chkbxDanTocMienNui.Checked = True) Then
            chkbxDanTocMienNui.Checked = False
        End If

    End Sub

    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click 'Mo form cap nhat
        If (txtMaSoTreEm.Text = Nothing) Then
            MessageBox.Show("Cập nhật trẻ em không hợp lệ.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Dim treem As TreEmDTO
        treem = New TreEmDTO()
        '1. Mapping data from GUI control
        treem.StrMaTreEm1 = txtMaSoTreEm.Text
        treem.StrHoTenTreEm1 = txtHoTen.Text
        treem.StrHoTenPhuHuynh1 = txtHoTenPhuHuynh.Text
        treem.StrTenONha1 = txtTenONha.Text
        treem.StrDiaChi1 = txtDiaChi.Text
        treem.StrDienThoai1 = txtDienThoai.Text
        treem.DateNgaySinh1 = dtpNgaySinh.Value
        'tinh tuoi 
        treem.StrTuoi1 = Date.Now.Year - dtpNgaySinh.Value.Year
        If (txtHoTenPhuHuynh.Text = Nothing Or txtTenONha.Text = Nothing Or txtDiaChi.Text = Nothing Or txtDienThoai.Text = Nothing) Then
            MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        '2. Business nhap vao text box
        If (chkbxDanTocMienNui.Checked = False) Then
                If (teBUS.isValidName(treem.StrHoTenTreEm1) = False) Then
                    MessageBox.Show("Họ tên học sinh không đúng")
                    txtHoTen.Focus()
                    Return
                End If
            Else
                If (teBUS.isValidName1(treem.StrHoTenTreEm1) = False) Then
                    MessageBox.Show("Họ tên học sinh không đúng")
                    txtHoTen.Focus()
                    Return
                End If
            End If
        If (tsBUS.ageCheck(treem.DateNgaySinh1) = False) Then
            MessageBox.Show("Học sinh chưa đủ tuổi đi học")
            txtHoTen.Focus()
            Return
        End If
        If (newKid = True) Then
            newKid = False
            '3. Insert to DB
            Dim result As Result
            result = teBUS.insert1(treem)
            If (result.FlagResult = True) Then
                MessageBox.Show("Thêm trẻ em thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Thêm trẻ em không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
        Else
            '3. Update DB
            Dim result As Result
            result = teBUS.updatetByID(treem)
            If (result.FlagResult = True) Then
                MessageBox.Show("Cập nhật trẻ em thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Cập nhật trẻ em không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
        End If
        loadListTreEm()
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click 'Xoa tre em khoi co so du lieu
        If (txtMaSoTreEm.Text = Nothing) Then
            MessageBox.Show("Chọn trẻ em trong danh sách trẻ em trước khi xoá.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If (dgvDanhSachTreEm.RowCount > 0) Then
            Dim result As Result

            result = gnBUS.deleteByMaTreEm(txtMaSoTreEm.Text) 'Xoa KHOA NGOAI THAM CHIEU TRUOC 
            If (result.FlagResult = False) Then
                MessageBox.Show("Xoá ghi nhận của trẻ em không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
                Return
            End If
            result = teBUS.moveToTemporaryTableByID(txtMaSoTreEm.Text)
            If (result.FlagResult = False) Then
                MessageBox.Show("Lưu trẻ em vào bộ nhớ tạm không thành công .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
            txtMaSoTreEm.Text = String.Empty
            txtHoTen.Text = String.Empty
            txtHoTenPhuHuynh.Text = String.Empty
            txtTenONha.Text = String.Empty
            txtDiaChi.Text = String.Empty
            txtDienThoai.Text = String.Empty
            dtpNgaySinh.Text = String.Empty
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


    Private Sub btnDong_Click(sender As Object, e As EventArgs)  'Dong form
        Close()
    End Sub

    Private Sub btnPhucHoi_Click(sender As Object, e As EventArgs) Handles btnPhucHoi.Click
        Dim result As Result
        result = teBUS.restoreFromTemporaryTable()
        If (result.FlagResult = False) Then
            MessageBox.Show("Phục hồi dữ liệu trẻ em không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        result = teBUS.clearTemporaryTable()
        If (result.FlagResult = False) Then
            MessageBox.Show("Xoá dữ liệu tạm thời trẻ em không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        loadListTreEm()
    End Sub

    Private Sub btnXoaVinhVien_Click(sender As Object, e As EventArgs) Handles btnXoaVinhVien.Click
        If (txtMaSoTreEm.Text = Nothing) Then
            MessageBox.Show("Chọn trẻ em trong danh sách trẻ em trước khi xoá.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If (dgvDanhSachTreEm.RowCount > 0) Then
            Dim result As Result

            result = gnBUS.deleteByMaTreEm(txtMaSoTreEm.Text) 'Xoa KHOA NGOAI THAM CHIEU TRUOC 
            If (result.FlagResult = False) Then
                MessageBox.Show("Xoá ghi nhận của trẻ em không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
                Return
            End If
            result = teBUS.moveToTemporaryTableByID(txtMaSoTreEm.Text)
            If (result.FlagResult = False) Then
                MessageBox.Show("Lưu trẻ em vào bộ nhớ tạm không thành công .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
                Return
            End If
            result = teBUS.clearTemporaryTable()
            If (result.FlagResult = False) Then
                MessageBox.Show("Xoá dữ liệu tạm thời trẻ em không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
            txtMaSoTreEm.Text = String.Empty
            txtHoTen.Text = String.Empty
            txtHoTenPhuHuynh.Text = String.Empty
            txtTenONha.Text = String.Empty
            txtDiaChi.Text = String.Empty
            txtDienThoai.Text = String.Empty
            dtpNgaySinh.Text = String.Empty
        End If
    End Sub

    Private Sub btnXoaFilePhucHoi_Click(sender As Object, e As EventArgs) Handles btnXoaFilePhucHoi.Click
        Dim result1 As Integer = MessageBox.Show("Bạn sẽ không thể phục hồi khi xoá file phục hồi.", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        If result1 = DialogResult.OK Then
            MessageBox.Show("File phục hồi đã bị xoá")
            Dim result As Result
            result = teBUS.clearTemporaryTable()
            If (result.FlagResult = False) Then
                MessageBox.Show("Xoá dữ liệu tạm thời trẻ em không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
                Return
            End If
        ElseIf result1 = DialogResult.Cancel Then
            MessageBox.Show("Tác vụ đã bị huỷ ")
            Return
        End If

    End Sub

    Private Sub chkbxXoaNangCao_CheckedChanged(sender As Object, e As EventArgs) Handles chkbxXoaNangCao.CheckedChanged
        If (chkbxXoaNangCao.Checked = True) Then
            btnXoaFilePhucHoi.Visible = True
            btnXoaVinhVien.Visible = True
        Else
            btnXoaFilePhucHoi.Visible = False
            btnXoaVinhVien.Visible = False
        End If
    End Sub
End Class