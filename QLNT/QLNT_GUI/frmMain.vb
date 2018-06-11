Imports System.Configuration
Public Class frmMain
    Private ConnectionString As String
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Read ConnectionString value from App.config file
        ConnectionString = ConfigurationManager.AppSettings("ConnectionString")


    End Sub

    Private Sub QuanLyTreEmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuanLyTreEmToolStripMenuItem.Click
        Dim frm As frmQuanLyTreEm = New frmQuanLyTreEm()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub TraCứuTrẻEmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TraCứuTrẻEmToolStripMenuItem1.Click
        Dim frm As frmTraCuuTreEm = New frmTraCuuTreEm()
        frm.MdiParent = Me
        frm.Show()
    End Sub
    Private Sub BáoCáoNgàyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BáoCáoNgàyToolStripMenuItem.Click
        Dim frm As frmLapBaoCaoNgay = New frmLapBaoCaoNgay()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub BáoCáoNgàyTheoKhốiLớpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BáoCáoNgàyTheoKhốiLớpToolStripMenuItem.Click
        Dim frm As frmLapBaoCaoNgayTheoLop = New frmLapBaoCaoNgayTheoLop()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ThemTreEmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThemTreEmToolStripMenuItem.Click
        Dim frm As frmThemTreEm = New frmThemTreEm()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub GhiNhậnTìnhTrạngTrẻToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GhiNhậnTìnhTrạngTrẻToolStripMenuItem.Click
        Dim frm As frmQuanLyGhiNhanTinhTrangTre = New frmQuanLyGhiNhanTinhTrangTre()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub QuảnLýLớpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýLớpToolStripMenuItem.Click
        Dim frm As frmQuanLyLop = New frmQuanLyLop()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub CậpNhậtQuyĐịnhToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CậpNhậtQuyĐịnhToolStripMenuItem.Click
        Dim frm As frmCapNhatQuyDinh = New frmCapNhatQuyDinh()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ChuyểnLớpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChuyểnLớpToolStripMenuItem.Click
        Dim frm As frmChuyenLop = New frmChuyenLop()
        frm.MdiParent = Me
        frm.Show()
    End Sub
End Class
