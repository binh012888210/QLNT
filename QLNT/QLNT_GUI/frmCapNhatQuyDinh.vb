Imports System.Windows.Forms
Imports QLNT_BUS
Imports QLNT_DTO
Imports Utility
Public Class frmCapNhatQuyDinh

    Private ghinhanBUS As GhiNhanTinhTrangBUS
    Private teBUS As TreEmBUS
    Private khBUS As KhoiBUS
    Private ttBUS As TinhTrangBUS
    Private tsBUS As ThamSoBUS

    Private Sub frmCapNhatQuyDinh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ttBUS = New TinhTrangBUS
        tsBUS = New ThamSoBUS
        loadCBTinhTrang()
        TestloadtxtSiSoToiDa()
    End Sub
    Private Sub loadCBTinhTrang() 'loadComboBoxTinhTrang
        Dim listTinhTrang = New List(Of TinhTrangDTO)
        Dim result As Result
        result = ttBUS.selectALL(listTinhTrang)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách tình trạng trẻ em không thành công", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        cbTinhTrang.DataSource = New BindingSource(listTinhTrang, String.Empty)
        cbTinhTrang.DisplayMember = "StrTenTinhTrang1"
        cbTinhTrang.ValueMember = "StrMaTinhTrang1"
        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(cbTinhTrang.DataSource)
        myCurrencyManager.Refresh()
    End Sub
    Private Sub TestloadtxtSiSoToiDa() 'loadtextSiSoToiDa
        Dim result As Result
        Dim text As String
        result = tsBUS.LoadSiSo(text)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy số học sinh tối đa không thành công", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        txtSiSoToiDa.Text = text
    End Sub

    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        Dim tinhtrang = New TinhTrangDTO
        Dim thamso = New ThamSoDTO
        tinhtrang.StrMaTinhTrang1 = cbTinhTrang.SelectedValue
        tinhtrang.StrTenTinhTrang1 = txtTinhTrangMoi.Text
        thamso.IntSoHocSinhToiDa1 = txtSiSoToiDaMoi.Text
        '2. Insert to DB
        Dim result As Result
        Dim result2 As Result
        Dim text As String
        text = txtSiSoToiDaMoi.Text
        result = ttBUS.update(tinhtrang)
        result2 = tsBUS.update(thamso, text)
        If (result.FlagResult = True And result2.FlagResult = True) Then
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