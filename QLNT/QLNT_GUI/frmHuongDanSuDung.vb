Imports System.Configuration
Public Class frmHuongDanSuDung

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If (rbChuyenLop.Checked = True) Then
            Dim frm As New frmHuongDanChuyenLop
            frm.ShowDialog()
        ElseIf (rbQuanLyGhiNhan.Checked = True) Then
            Dim frm As New frmHuongDanQuanLyGhiNhanTinhTrang
            frm.ShowDialog()
        ElseIf (rbQuanLyLop.Checked = True) Then
            Dim frm As New frmHuongDanQuanLyLop
            frm.ShowDialog()
        ElseIf (rbQuanLyTreEm.Checked = True) Then
            Dim frm As New frmHuongDanQuanLyTreEm
            frm.ShowDialog()
        ElseIf (rbThemTreEm.Checked = True) Then
            Dim frm As New frmHuongDanThemTreEm
            frm.ShowDialog()
        ElseIf (rbTraCuutreEm.Checked = True) Then
            Dim frm As New frmHuongDanTraCuuTreEm
            frm.ShowDialog()
        End If
    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Close()
    End Sub
End Class