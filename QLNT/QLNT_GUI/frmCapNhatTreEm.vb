Imports QLNT_BUS
Imports QLNT_DTO
Imports Utility
Public Class frmCapNhatTreEm
    Private teBUS As TreEmBUS
    Private tsBUS As ThamSoBUS
    Private peopleCheck As Boolean

    Private Sub frmCapNhatTreEm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        teBUS = New TreEmBUS()
        tsBUS = New ThamSoBUS()

        loadTreEm()
    End Sub
    Private Sub loadTreEm()
        Dim TreEmInfo = New TreEmDTO
    End Sub

    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click 'Thuc hien viec cap nhat

        Dim TreEmInfo = New TreEmDTO
        Dim result As Result
        TreEmInfo.StrMaTreEm1 = txtMaSoTreEm.Text
        TreEmInfo.StrHoTenTreEm1 = txtHoTen.Text
        TreEmInfo.DateNgaySinh1 = dtpNgaySinh.Value
        TreEmInfo.StrHoTenPhuHuynh1 = txtHoTenPhuHuynh.Text
        TreEmInfo.StrTenONha1 = txtTenONha.Text
        TreEmInfo.StrDiaChi1 = txtDiaChi.Text
        TreEmInfo.StrDienThoai1 = txtDienThoai.Text
        TreEmInfo.StrTuoi1 = (Date.Now.Year - dtpNgaySinh.Value.Year).ToString

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
        If (tsBUS.ageCheck(TreEmInfo.DateNgaySinh1) = False) Then
            MessageBox.Show("Học sinh chưa đủ tuổi đi học")
            txtHoTen.Focus()
            Return
        End If

        result = teBUS.updatetByID(TreEmInfo)
        If (result.FlagResult = False) Then
            MessageBox.Show("Cập nhật trẻ em không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        Else
            MessageBox.Show("Cập nhật trẻ em thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            System.Console.WriteLine(result.SystemMessage)
            Close()
            Return
        End If

    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click 'Thuc hien viec dong
        Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged 'Thuc hien viec kiem tra dan toc thieu so khi nhap ten
        If (CheckBox1.Checked = True) Then
            peopleCheck = True
        Else
            peopleCheck = False
        End If
    End Sub
End Class