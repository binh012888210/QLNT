Imports QLNT_BUS
Imports QLNT_DTO
Imports Utility
Public Class frmCapNhatGhiNhan

    Private ghinhanBUS As GhiNhanTinhTrangBUS
    Private teBUS As TreEmBUS
    Private khBUS As KhoiBUS
    Private ttBUS As TinhTrangBUS

    Private Sub frmCapNhatGhiNhan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ghinhanBUS = New GhiNhanTinhTrangBUS()
        teBUS = New TreEmBUS
        khBUS = New KhoiBUS
        ttBUS = New TinhTrangBUS
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

    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click 'Thuc hien viec cap nhat
        Dim ghinhan = New GhiNhanTinhTrangDTO
        ghinhan.StrMaPhieuGhiNhan1 = txtMaGhiNhan.Text
        ghinhan.DateNgayGhiNhan1 = dtpNgayGhiNhan.Value
        ghinhan.StrMaTinhTrang1 = cbTinhTrang.SelectedValue
        '2. Insert to DB
        Dim result As Result
        result = ghinhanBUS.updatetByID(ghinhan)
        If (result.FlagResult = True) Then
            MessageBox.Show("Cập nhật ghi nhận thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Close()
        Else
            MessageBox.Show("Cập nhật ghi nhận không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub



    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Close()
    End Sub


End Class