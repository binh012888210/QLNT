Imports QLNT_BUS
Imports QLNT_DTO
Imports Utility

Public Class frmQuanLyTreEm
    Dim Change As Integer
    Private teBUS As TreEmBUS
    Private Sub frmQuanLyTreEm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        teBUS = New TreEmBUS()
        loadListTreEm()
    End Sub
    Private Sub loadListTreEm()
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
        clMaTreEm.DataPropertyName = "StrMaTreEm1" ''ten trong DTO
        clMaTreEm.ReadOnly = True
        dgvDanhSachTreEm.Columns.Add(clMaTreEm)

        Dim clTenTreEm = New DataGridViewTextBoxColumn()
        clTenTreEm.Name = "HoTenTreEm"
        clTenTreEm.HeaderText = "Tên Trẻ Em"
        clTenTreEm.DataPropertyName = "StrHoTenTreEm1" 'ten trong DTO
        clTenTreEm.ReadOnly = True
        dgvDanhSachTreEm.Columns.Add(clTenTreEm)

        Dim clTenPhuHuynh = New DataGridViewTextBoxColumn()
        clTenPhuHuynh.Name = "TenPhuHuynh"
        clTenPhuHuynh.HeaderText = "Tên Phụ Huynh"
        clTenPhuHuynh.DataPropertyName = "StrHoTenPhuHuynh1" 'ten trong DTO
        clTenPhuHuynh.ReadOnly = True
        dgvDanhSachTreEm.Columns.Add(clTenPhuHuynh)


        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(dgvDanhSachTreEm.DataSource)
        myCurrencyManager.Refresh()
        Change = 0
    End Sub

    Private Sub dgvDanhSachTreEm_SelectionChanged(sender As Object, e As EventArgs) Handles dgvDanhSachTreEm.SelectionChanged
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvDanhSachTreEm.CurrentCellAddress.Y
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
                If (te.StrMaLop1 = Nothing) Then
                    txtMaLop.Text = ("Chưa xếp lớp")
                Else
                    txtMaLop.Text = te.StrMaLop1
                End If
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try
        End If
    End Sub
    Private Sub btnTiepNhan_Click(sender As Object, e As EventArgs) Handles btnTiepNhan.Click
        Change = 1
        Dim frm As frmThemTreEm = New frmThemTreEm()
        frm.Show()
    End Sub

    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        Change = 1
        Dim frm As frmCapNhatTreEm = New frmCapNhatTreEm()
        frm.txtMaSoTreEm.Text = txtMaSoTreEm.Text
        frm.Show()
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim TreEmInfo = New TreEmDTO
        Dim result As Result
        result = teBUS.deleteByID(txtMaSoTreEm.Text)
        If (result.FlagResult = False) Then
            MessageBox.Show("Xoá trẻ em không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
    End Sub

    Private Sub frmQuanLyTreEm_MouseEnter(sender As Object, e As EventArgs) Handles MyBase.MouseEnter
        If (Change = 1) Then
            loadListTreEm()
        End If
    End Sub

    Private Sub txtSearchName_TextChanged(sender As Object, e As EventArgs) Handles txtSearchName.TextChanged
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
        clMaTreEm.DataPropertyName = "StrMaTreEm1" ''ten trong DTO
        clMaTreEm.ReadOnly = True
        dgvDanhSachTreEm.Columns.Add(clMaTreEm)

        Dim clTenTreEm = New DataGridViewTextBoxColumn()
        clTenTreEm.Name = "HoTenTreEm"
        clTenTreEm.HeaderText = "Tên Trẻ Em"
        clTenTreEm.DataPropertyName = "StrHoTenTreEm1" 'ten trong DTO
        clTenTreEm.ReadOnly = True
        dgvDanhSachTreEm.Columns.Add(clTenTreEm)

        Dim clTenPhuHuynh = New DataGridViewTextBoxColumn()
        clTenPhuHuynh.Name = "TenPhuHuynh"
        clTenPhuHuynh.HeaderText = "Tên Phụ Huynh"
        clTenPhuHuynh.DataPropertyName = "StrHoTenPhuHuynh1" 'ten trong DTO
        clTenPhuHuynh.ReadOnly = True
        dgvDanhSachTreEm.Columns.Add(clTenPhuHuynh)


        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(dgvDanhSachTreEm.DataSource)
        myCurrencyManager.Refresh()
        Change = 0
    End Sub
End Class