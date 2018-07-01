Imports System.Configuration
Public Class frmMain
    Private ConnectionString As String
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Read ConnectionString value from App.config file
        ConnectionString = ConfigurationManager.AppSettings("ConnectionString")
        Dim frm As New frmDangNhap
        frm.MdiParent = Me
        frm.Show()
    End Sub
    Private Sub ThoátĐăngNhậpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThoátĐăngNhậpToolStripMenuItem.Click
        Dim frm As New frmDangNhap
        If Application.OpenForms().OfType(Of frmDangNhap).Any Then

        Else
            For Each frmApproval As Form In Me.MdiChildren
                frmApproval.Close()
            Next
            frm.MdiParent = Me
            frm.Show()
        End If
    End Sub

    Private Sub QuanLyTreEmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuanLyTreEmToolStripMenuItem.Click
        If Application.OpenForms().OfType(Of frmDangNhap).Any Then
            MessageBox.Show("Đăng nhập để tiếp tục làm việc ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim frm As New frmQuanLyTreEm
            If Application.OpenForms().OfType(Of frmQuanLyTreEm).Any Then
                Application.OpenForms().Item("frmQuanLyTreEm").Activate()
                MessageBox.Show("Form đã được mở ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                frm.TopMost = True
                frm.MdiParent = Me
                frm.Show()
            End If
        End If
    End Sub

    Private Sub TraCứuTrẻEmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TraCứuTrẻEmToolStripMenuItem1.Click
        If Application.OpenForms().OfType(Of frmDangNhap).Any Then
            MessageBox.Show("Đăng nhập để tiếp tục làm việc ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim frm As New frmTraCuuTreEm
            If Application.OpenForms().OfType(Of frmTraCuuTreEm).Any Then
                Application.OpenForms().Item("frmTraCuuTreEm").Activate()
                MessageBox.Show("Form đã được mở ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                frm.TopMost = True
                frm.MdiParent = Me
                frm.Show()
            End If
        End If
    End Sub

    Private Sub BáoCáoNgàyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BáoCáoNgàyToolStripMenuItem.Click
        If Application.OpenForms().OfType(Of frmDangNhap).Any Then
            MessageBox.Show("Đăng nhập để tiếp tục làm việc ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim frm As New frmLapBaoCaoNgay
            If Application.OpenForms().OfType(Of frmLapBaoCaoNgay).Any Then
                Application.OpenForms().Item("frmLapBaoCaoNgay").Activate()
                MessageBox.Show("Form đã được mở ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                frm.TopMost = True
                frm.MdiParent = Me
                frm.Show()
            End If
        End If
    End Sub

    Private Sub BáoCáoNgàyTheoKhốiLớpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BáoCáoNgàyTheoKhốiLớpToolStripMenuItem.Click
        If Application.OpenForms().OfType(Of frmDangNhap).Any Then
            MessageBox.Show("Đăng nhập để tiếp tục làm việc ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim frm As New frmLapBaoCaoNgayTheoLop
            If Application.OpenForms().OfType(Of frmLapBaoCaoNgayTheoLop).Any Then
                Application.OpenForms().Item("frmLapBaoCaoNgayTheoLop").Activate()
                MessageBox.Show("Form đã được mở ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                frm.TopMost = True
                frm.MdiParent = Me
                frm.Show()
            End If
        End If
    End Sub

    Private Sub ThemTreEmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThemTreEmToolStripMenuItem.Click
        If Application.OpenForms().OfType(Of frmDangNhap).Any Then
            MessageBox.Show("Đăng nhập để tiếp tục làm việc ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim frm As New frmThemTreEm
            If Application.OpenForms().OfType(Of frmThemTreEm).Any Then
                Application.OpenForms().Item("frmThemTreEm").Activate()
                MessageBox.Show("Form đã được mở ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                frm.TopMost = True
                frm.MdiParent = Me
                frm.Show()
            End If
        End If
    End Sub

    Private Sub QuảnLýGhiNhậnTìnhTrạngTrẻToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýGhiNhậnTìnhTrạngTrẻToolStripMenuItem.Click
        If Application.OpenForms().OfType(Of frmDangNhap).Any Then
            MessageBox.Show("Đăng nhập để tiếp tục làm việc ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim frm As New frmQuanLyGhiNhanTinhTrangTre
            If Application.OpenForms().OfType(Of frmQuanLyGhiNhanTinhTrangTre).Any Then
                Application.OpenForms().Item("frmQuanLyGhiNhanTinhTrangTre").Activate()
                MessageBox.Show("Form đã được mở ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                frm.TopMost = True
                frm.MdiParent = Me
                frm.Show()
            End If
        End If
    End Sub

    Private Sub QuảnLýLớpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýLớpToolStripMenuItem.Click
        If Application.OpenForms().OfType(Of frmDangNhap).Any Then
            MessageBox.Show("Đăng nhập để tiếp tục làm việc ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim frm As New frmQuanLyLop
            If Application.OpenForms().OfType(Of frmQuanLyLop).Any Then
                Application.OpenForms().Item("frmQuanLyLop").Activate()
                MessageBox.Show("Form đã được mở ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                frm.TopMost = True
                frm.MdiParent = Me
                frm.Show()
            End If
        End If
    End Sub

    Private Sub CậpNhậtQuyĐịnhToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CậpNhậtQuyĐịnhToolStripMenuItem.Click
        If Application.OpenForms().OfType(Of frmDangNhap).Any Then
            MessageBox.Show("Đăng nhập để tiếp tục làm việc ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim frm As New frmCapNhatQuyDinh
            If Application.OpenForms().OfType(Of frmCapNhatQuyDinh).Any Then
                Application.OpenForms().Item("frmCapNhatQuyDinh").Activate()
                MessageBox.Show("Form đã được mở ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                frm.TopMost = True
                frm.MdiParent = Me
                frm.Show()
            End If
        End If
    End Sub

    Private Sub ChuyểnLớpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChuyểnLớpToolStripMenuItem.Click
        If Application.OpenForms().OfType(Of frmDangNhap).Any Then
            MessageBox.Show("Đăng nhập để tiếp tục làm việc ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim frm As New frmChuyenLop
            If Application.OpenForms().OfType(Of frmChuyenLop).Any Then
                Application.OpenForms().Item("frmChuyenLop").Activate()
                MessageBox.Show("Form đã được mở ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                frm.TopMost = True
                frm.MdiParent = Me
                frm.Show()
            End If
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim frm As New frmAbout
        If Application.OpenForms().OfType(Of frmAbout).Any Then
            Application.OpenForms().Item("frmAbout").Activate()
        Else
            frm.TopMost = True
            frm.MdiParent = Me
            frm.Show()
        End If
    End Sub

    Private Sub HướngDẫnSửDụngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HướngDẫnSửDụngToolStripMenuItem.Click
        Dim frm As New frmHuongDanSuDung
        If Application.OpenForms().OfType(Of frmHuongDanSuDung).Any Then
            Application.OpenForms().Item("frmHuongDanSuDung").Activate()
        Else
            frm.TopMost = True
            frm.MdiParent = Me
            frm.Show()
        End If
    End Sub


End Class
