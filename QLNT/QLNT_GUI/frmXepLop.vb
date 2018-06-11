Imports QLNT_BUS
Imports QLNT_DTO
Imports Utility
Public Class frmXepLop
    Private teBUS As TreEmBUS

    Private Sub frmXepLop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        teBUS = New TreEmBUS
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim treem As TreEmDTO
        treem = New TreEmDTO()
        If (txtGhiChu.Text = Nothing) Then
            MessageBox.Show("Vui lòng điền vào ghi chú.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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
            MessageBox.Show("Xếp lớp cho trẻ trẻ em thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            System.Console.WriteLine(result.SystemMessage)
            Close()
        Else
            MessageBox.Show("Xếp lớp cho trẻ trẻ em không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Close()
    End Sub
End Class