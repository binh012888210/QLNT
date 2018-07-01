Imports QLNT_BUS
Imports QLNT_DTO
Imports Utility
Public Class frmLapBaoCaoNgayTheoLop
    Private ctbcBUS As ChiTietBaoCaoBUS
    Private gnttBUS As GhiNhanTinhTrangBUS
    Private teBUS As TreEmBUS
    Private khBUS As KhoiBUS
    Private ttBUS As TinhTrangBUS
    Private bcBUS As BaoCaoBUS
    Dim txt As String
    Private Sub frmLapBaoCaoNgayTheoLop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ctbcBUS = New ChiTietBaoCaoBUS()
        gnttBUS = New GhiNhanTinhTrangBUS()
        teBUS = New TreEmBUS()
        khBUS = New KhoiBUS()
        ttBUS = New TinhTrangBUS()
        bcBUS = New BaoCaoBUS()

        txtMaSoBaoCao.Focus()
        Dim result As Result 'tao tu dong ma bao cao
        Dim nextMbc = "1"
        result = bcBUS.buildMbc2(nextMbc)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách tự động mã báo cáo không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        txtMaSoBaoCao.Text = nextMbc
        loadlistChiTietBaoCao()
        Dim listKhoi = New List(Of KhoiDTO) ' tao combo box ten khoi
        Dim result1 As Result
        result1 = khBUS.selectALL(listKhoi)
        If (result1.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách khối không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result1.SystemMessage)
            Me.Close()
            Return
        End If
        cbTenKhoi.DataSource = New BindingSource(listKhoi, String.Empty)
        cbTenKhoi.DisplayMember = "StrTenKhoi1"
        cbTenKhoi.ValueMember = "StrMaKhoi1"
        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(cbTenKhoi.DataSource)
        myCurrencyManager.Refresh()
        If (listKhoi.Count > 0) Then
            cbTenKhoi.SelectedIndex = 0
        End If
        Return
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvChuaBaoCao.CellContentClick

    End Sub
    Private Sub loadlistChiTietBaoCao()
        Dim listChiTietBaoCao = New List(Of ChiTietBaoCaoDTO)
        Dim result As Result
        result = ctbcBUS.selectALL(listChiTietBaoCao)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách chi tiết báo cáo không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)

            Return
        End If
        dgvChuaBaoCao.Columns.Clear()
        dgvChuaBaoCao.DataSource = Nothing

        dgvChuaBaoCao.AutoGenerateColumns = False
        dgvChuaBaoCao.AllowUserToAddRows = False
        dgvChuaBaoCao.DataSource = listChiTietBaoCao

        Dim clMaChiTietBaoCao = New DataGridViewTextBoxColumn()
        clMaChiTietBaoCao.Name = "MaChiTietBaoCao"
        clMaChiTietBaoCao.HeaderText = "Mã Chi Tiết Báo Cáo"
        clMaChiTietBaoCao.DataPropertyName = "StrMaChiTietBaoCao1" 'ten trong DTO
        clMaChiTietBaoCao.ReadOnly = True
        dgvChuaBaoCao.Columns.Add(clMaChiTietBaoCao)


        Dim clMaGhiNhan = New DataGridViewTextBoxColumn()
        clMaGhiNhan.Name = "MaGhiNhan"
        clMaGhiNhan.HeaderText = "Mã Ghi Nhận"
        clMaGhiNhan.DataPropertyName = "StrMaPhieuGhiNhan1" ''ten trong DTO
        clMaGhiNhan.ReadOnly = True
        dgvChuaBaoCao.Columns.Add(clMaGhiNhan)

        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(dgvChuaBaoCao.DataSource)
        myCurrencyManager.Refresh()
    End Sub

    Private Sub btnLapBaoCao_Click(sender As Object, e As EventArgs)
        Dim ctbc As ChiTietBaoCaoDTO
        Dim bc As BaoCaoDTO
        Dim ctbcInfo = New ChiTietBaoCaoDTO
        ctbc = New ChiTietBaoCaoDTO()
        bc = New BaoCaoDTO()

        '1. Mapping data from GUI control
        bc.StrMaBaoCao1 = txtMaSoBaoCao.Text
        bc.DateNgayBaoCao1 = dtpNgayLapBaoCao.Value
        bc.StrMaKhoi1 = cbTenKhoi.SelectedValue

        ctbc.StrMaChiTietBaoCao1 = txt
        ctbc.StrMaBaoCao1 = txtMaSoBaoCao.Text

        Dim result As Result
        Dim result1 As Result
        Dim result2 As Result
        Dim bcInfo = New BaoCaoDTO
        Dim x As Integer
        Dim y As Integer
        Dim z As String
        result2 = bcBUS.checkMaBaoCao(z)
        If (result2.FlagResult = True) Then

        Else
            MessageBox.Show("Check mã báo cáo không thành công", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result2.SystemMessage)
        End If
        x = Convert.ToInt32(z)
        y = Convert.ToInt32(txtMaSoBaoCao.Text)
        If (x = y) Then
            result = ctbcBUS.updatetByID(ctbc)
            result1 = bcBUS.insert(bc)
            If (result.FlagResult = True And result1.FlagResult = True) Then
                MessageBox.Show("Thêm báo cáo thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Thêm báo cáo không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result1.SystemMessage)
            End If
        Else
            result = ctbcBUS.updatetByID(ctbc)
            If (result.FlagResult = True) Then
                MessageBox.Show("Thêm báo cáo thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Thêm báo cáo không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
            End If
        End If

        loadlistChiTietBaoCao()
    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
End Class