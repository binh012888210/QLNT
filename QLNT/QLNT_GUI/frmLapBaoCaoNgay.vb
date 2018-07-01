Imports QLNT_BUS
Imports QLNT_DTO
Imports Utility
Public Class frmLapBaoCaoNgay
    Private ctbcBUS As ChiTietBaoCaoBUS
    Private gnttBUS As GhiNhanTinhTrangBUS
    Private teBUS As TreEmBUS
    Private khBUS As KhoiBUS
    Private ttBUS As TinhTrangBUS
    Private bcBUS As BaoCaoBUS
    Dim txt As String

    Private Sub frmLapBaoCaoNgay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ctbcBUS = New ChiTietBaoCaoBUS()
        gnttBUS = New GhiNhanTinhTrangBUS()
        teBUS = New TreEmBUS()
        khBUS = New KhoiBUS()
        ttBUS = New TinhTrangBUS()
        bcBUS = New BaoCaoBUS()
        txtMaBaoCao.Focus()
        Dim result As Result 'tao tu dong ma bao cao
        Dim nextMbc = "1"
        result = bcBUS.buildMbc(nextMbc)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách tự động mã báo cáo không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        txtMaBaoCao.Text = nextMbc
        loadListChiTietBaoCao()
    End Sub

    Private Sub dtpNgayLapBaoCao_ValueChanged(sender As Object, e As EventArgs)

    End Sub
    Private Sub loadListChiTietBaoCao() 'Load du lieu vao datagridview
        Dim listChiTietBaoCao = New List(Of ChiTietBaoCaoDTO)
        Dim result As Result
        result = ctbcBUS.selectALL(listChiTietBaoCao)
        'result = ctbcBUS.selectMbcNull(listChiTietBaoCao)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách chi tiết báo cáo không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)

            Return
        End If
        dgvLapBaoCaoNgay2.Columns.Clear()
        dgvLapBaoCaoNgay2.DataSource = Nothing

        dgvLapBaoCaoNgay2.AutoGenerateColumns = False
        dgvLapBaoCaoNgay2.AllowUserToAddRows = False
        dgvLapBaoCaoNgay2.DataSource = listChiTietBaoCao

        Dim clMaChiTietBaoCao = New DataGridViewTextBoxColumn()
        clMaChiTietBaoCao.Name = "MaChiTietBaoCao"
        clMaChiTietBaoCao.HeaderText = "Mã Chi Tiết Báo Cáo"
        clMaChiTietBaoCao.DataPropertyName = "StrMaChiTietBaoCao1" 'ten trong DTO
        clMaChiTietBaoCao.ReadOnly = True
        dgvLapBaoCaoNgay2.Columns.Add(clMaChiTietBaoCao)

        Dim clMaGhiNhan = New DataGridViewTextBoxColumn()
        clMaGhiNhan.Name = "MaGhiNhan"
        clMaGhiNhan.HeaderText = "Mã Ghi Nhận"
        clMaGhiNhan.DataPropertyName = "StrMaPhieuGhiNhan1" ''ten trong DTO
        clMaGhiNhan.ReadOnly = True
        dgvLapBaoCaoNgay2.Columns.Add(clMaGhiNhan)

        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(dgvLapBaoCaoNgay2.DataSource)
        myCurrencyManager.Refresh()

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click, Label10.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnThemChiTietBaoCao.Click

    End Sub

    Private Sub btnXoaChiTietBaoCao_Click(sender As Object, e As EventArgs) Handles btnXoaChiTietBaoCao.Click

    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub dgvLapBaoCaoNgay2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLapBaoCaoNgay2.CellContentClick

    End Sub

    Private Sub btnLapBaoCao_Click(sender As Object, e As EventArgs)
        Dim ctbc As ChiTietBaoCaoDTO
        Dim bc As BaoCaoDTO
        Dim ctbcInfo = New ChiTietBaoCaoDTO
        ctbc = New ChiTietBaoCaoDTO()
        bc = New BaoCaoDTO()

        '1. Mapping data from GUI control
        bc.StrMaBaoCao1 = txtMaBaoCao.Text
        bc.DateNgayBaoCao1 = dtpNgayLapBaoCao.Value
        txt = "1"
        bc.StrMaKhoi1 = txt

        ctbc.StrMaChiTietBaoCao1 = txtMaCTBC.Text
        ctbc.StrMaBaoCao1 = txtMaBaoCao.Text

        Dim result As Result
        Dim result1 As Result
        Dim bcInfo = New BaoCaoDTO
        Dim x As Integer
        Dim y As Integer
        Dim z As String
        'result2 = bcBUS.checkMaBaoCao(z)
        'If (result2.FlagResult = True) Then

        'Else
        'MessageBox.Show("Check mã báo cáo không thành công", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'System.Console.WriteLine(result2.SystemMessage)
        'End If
        x = Convert.ToInt32(z)
        y = Convert.ToInt32(txtMaBaoCao.Text)
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

        loadListChiTietBaoCao()
    End Sub

    Private Sub txtMaBaoCao_TextChanged(sender As Object, e As EventArgs)

        'Else

        'End If


    End Sub
End Class