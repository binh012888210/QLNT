Imports QLNT_BUS
Imports QLNT_DTO
Imports Utility
Public Class frmXepLop
    Private khBUS As KhoiBUS
    Private lpBUS As LopBUS
    Private teBUS As TreEmBUS
    Private Sub frmXepLop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        khBUS = New KhoiBUS
        lpBUS = New LopBUS
        teBUS = New TreEmBUS
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim treem As TreEmDTO
        treem = New TreEmDTO()
        teBUS = New TreEmBUS()
        If (txtGhiChu.Text = Nothing) Then
            MessageBox.Show("Vui lòng điền vào ghi chú.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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
            dtpNgayNhapHoc.Enabled = False
            txtGhiChu.ReadOnly = True
        Else
            MessageBox.Show("Xếp lớp cho trẻ trẻ em không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim treem As TreEmDTO
        treem = New TreEmDTO()
        teBUS = New TreEmBUS()
        If (txtGhiChu.Text = Nothing) Then
            MessageBox.Show("Vui lòng điền vào ghi chú.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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
            Close()
        Else
            MessageBox.Show("Xếp lớp cho trẻ trẻ em không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub
End Class