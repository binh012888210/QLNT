Imports QLNT_BUS
Imports QLNT_DTO
Imports Utility
Public Class frmDangNhap
    Private dnBUS As DangNhapBUS
    Dim loginCount As Integer
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If (loginCount < 5) Then
            Dim result As New Result
            Dim checkInfo = False
            result = dnBUS.SearchInformation(txtTenDangNhap.Text, txtMatKhau.Text, checkInfo)
            If (result.FlagResult = False) Then
                MessageBox.Show("Không thể kiểm tra đăng nhập vui lòng chờ hệ thống sửa chữa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
                Return
            End If
            If (checkInfo = True) Then
                MessageBox.Show("Đăng nhập thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Hide()
            Else
                MessageBox.Show("Đăng nhập bị từ chối. Bạn còn " + (5 - loginCount).ToString + " đăng nhập", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                loginCount = loginCount + 1
                Return
            End If
        Else
            MessageBox.Show("Hệ thống đã bị khoá do bạn nhập sai tên và mật khẩu quá 5 lần ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            MessageBox.Show("Bạn có thể tiếp tục đăng nhập sau khi mở lại chương trình", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub frmDangNhap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dnBUS = New DangNhapBUS
        loginCount = 0
    End Sub
End Class