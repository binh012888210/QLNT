Imports QLNT_BUS
Imports QLNT_DTO
Imports Utility
Public Class frmCapNhatTreEm
    Private teBUS As TreEmBUS
    Private peopleCheck As Boolean
    Private Sub frmCapNhatTreEm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        teBUS = New TreEmBUS()
        loadTreEm()
    End Sub
    Private Sub loadTreEm()
        Dim TreEmInfo = New TreEmDTO
        Dim result As Result
        result = teBUS.selectByID(txtMaSoTreEm.Text, TreEmInfo)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách trẻ em không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        txtMaSoTreEm.Text = TreEmInfo.StrMaTreEm1
        txtHoTen.Text = TreEmInfo.StrHoTenTreEm1
        dtpNgaySinh.Text = TreEmInfo.DateNgaySinh1
        txtHoTenPhuHuynh.Text = TreEmInfo.StrHoTenPhuHuynh1
        txtTenONha.Text = TreEmInfo.StrTenONha1
        txtDiaChi.Text = TreEmInfo.StrDiaChi1
        txtDienThoai.Text = TreEmInfo.StrDienThoai1
    End Sub

    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        Dim TreEmInfo = New TreEmDTO
        Dim result As Result
        TreEmInfo.StrMaTreEm1 = txtMaSoTreEm.Text
        TreEmInfo.StrHoTenTreEm1 = txtHoTen.Text
        TreEmInfo.DateNgaySinh1 = dtpNgaySinh.Value
        TreEmInfo.StrHoTenPhuHuynh1 = txtHoTenPhuHuynh.Text
        TreEmInfo.StrTenONha1 = txtTenONha.Text
        TreEmInfo.StrDiaChi1 = txtDiaChi.Text
        TreEmInfo.StrDienThoai1 = txtDienThoai.Text
        TreEmInfo.IntTuoi1 = Date.Now.Year - dtpNgaySinh.Value.Year
        result = teBUS.updatetByID(TreEmInfo)
        If (peopleCheck = False) Then
            If (teBUS.isValidName(TreEmInfo.StrHoTenTreEm1) = False) Then
                MessageBox.Show("Họ tên học sinh không đúng")
                txtHoTen.Focus()
                Return
            End If
        Else
            If (teBUS.isValidName1(TreEmInfo.StrHoTenTreEm1) = False) Then
                MessageBox.Show("Họ tên học sinh không đúng")
                txtHoTen.Focus()
                Return
            End If
        End If
        If (result.FlagResult = False) Then
            MessageBox.Show("Cập nhật trẻ em không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        txtHoTen.ReadOnly = True
        dtpNgaySinh.Enabled = False
        txtHoTenPhuHuynh.ReadOnly = True
        txtTenONha.ReadOnly = True
        txtDiaChi.ReadOnly = True
        txtDienThoai.ReadOnly = True
        CheckBox1.Enabled = False
    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Close()
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If (CheckBox1.Checked = True) Then
            peopleCheck = True
        Else
            peopleCheck = False
        End If
    End Sub
End Class