Imports QLNT_BUS
Imports QLNT_DTO
Imports Utility
Public Class frmThemTreEm
    Private teBUS As TreEmBUS
    Private tsBUS As ThamSoBUS
    Private peopleCheck As Boolean
    Private Sub frmThemTreEm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        teBUS = New TreEmBUS()
        txtHoTen.Focus()
        Dim result As Result
        Dim nextMste = "1"
        result = teBUS.buildMSTE(nextMste)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh tự động mã trẻ em không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        txtMaSoTreEm.Text = nextMste
    End Sub

    Private Sub btnNhap_Click(sender As Object, e As EventArgs) Handles btnNhap.Click
        Dim treem As TreEmDTO
        treem = New TreEmDTO()
        teBUS = New TreEmBUS()
        tsBUS = New ThamSoBUS()
        If (txtHoTenPhuHuynh.Text = Nothing Or txtTenONha.Text = Nothing Or txtDiaChi.Text = Nothing Or txtDienThoai.Text = Nothing) Then
            MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        '1. Mapping data from GUI control
        treem.StrMaTreEm1 = txtMaSoTreEm.Text
        treem.StrHoTenTreEm1 = txtHoTen.Text
        treem.DateNgaySinh1 = dtpNgaySinh.Value
        treem.StrHoTenPhuHuynh1 = txtHoTenPhuHuynh.Text
        treem.StrTenONha1 = txtTenONha.Text
        treem.StrDiaChi1 = txtDiaChi.Text
        treem.StrDienThoai1 = txtDienThoai.Text
        'tinh tuoi 
        treem.IntTuoi1 = Date.Now.Year - dtpNgaySinh.Value.Year
        '2. Business nhap vao text box
        If (peopleCheck = False) Then
            If (teBUS.isValidName(treem.StrHoTenTreEm1) = False) Then
                MessageBox.Show("Họ tên học sinh không đúng")
                txtHoTen.Focus()
                Return
            End If
        Else
            If (teBUS.isValidName1(treem.StrHoTenTreEm1) = False) Then
                MessageBox.Show("Họ tên học sinh không đúng")
                txtHoTen.Focus()
                Return
            End If
        End If
        If (tsBUS.ageMin(treem.DateNgaySinh1) = False) Then
            MessageBox.Show("Học sinh chưa đủ tuổi đi học")
            txtHoTen.Focus()
            Return
        End If
        If (tsBUS.ageMax(treem.DateNgaySinh1) = False) Then
            MessageBox.Show("Học sinh quá tuổi đi học")
            txtHoTen.Focus()
            Return
        End If
        '3. Insert to DB
        Dim result As Result
        result = teBUS.insert(treem)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm trẻ em thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'set MSSH auto
            Dim nextMste = "1"
            result = teBUS.buildMSTE(nextMste)
            If (result.FlagResult = False) Then
                MessageBox.Show("Lấy danh tự động mã trẻ em không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                Return
            End If
            txtMaSoTreEm.Text = nextMste
            txtHoTen.Text = String.Empty
            txtHoTenPhuHuynh.Text = String.Empty
            txtTenONha.Text = String.Empty
            txtDiaChi.Text = String.Empty
            txtDienThoai.Text = String.Empty

        Else
            MessageBox.Show("Thêm trẻ em không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If

    End Sub

    Private Sub btnNhapVaDong_Click(sender As Object, e As EventArgs) Handles btnNhapVaDong.Click
        Dim treem As TreEmDTO
        treem = New TreEmDTO()
        If (txtHoTenPhuHuynh.Text = Nothing Or txtTenONha.Text = Nothing Or txtDiaChi.Text = Nothing Or txtDienThoai.Text = Nothing) Then
            MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        '1. Mapping data from GUI control
        treem.StrMaTreEm1 = txtMaSoTreEm.Text
        treem.StrHoTenTreEm1 = txtHoTen.Text
        treem.DateNgaySinh1 = dtpNgaySinh.Value
        treem.StrHoTenPhuHuynh1 = txtHoTenPhuHuynh.Text
        treem.StrTenONha1 = txtTenONha.Text
        treem.StrDiaChi1 = txtDiaChi.Text
        treem.StrDienThoai1 = txtDienThoai.Text
        '2. Business nhap vao text box
        If (peopleCheck = False) Then
            If (teBUS.isValidName(treem.StrHoTenTreEm1) = False) Then
                MessageBox.Show("Họ tên học sinh không đúng")
                txtHoTen.Focus()
                Return
            End If
        Else
            If (teBUS.isValidName1(treem.StrHoTenTreEm1) = False) Then
                MessageBox.Show("Họ tên học sinh không đúng")
                txtHoTen.Focus()
                Return
            End If
        End If
        If (tsBUS.ageMin(treem.DateNgaySinh1) = False) Then
            MessageBox.Show("Học sinh chưa đủ tuổi đi học")
            txtHoTen.Focus()
            Return
        End If
        If (tsBUS.ageMax(treem.DateNgaySinh1) = False) Then
            MessageBox.Show("Học sinh quá tuổi đi học")
            txtHoTen.Focus()
            Return
        End If
        '3. Insert to DB
        Dim result As Result
        result = teBUS.insert(treem)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm trẻ em thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Else
            MessageBox.Show("Thêm trẻ em không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If (CheckBox1.Checked = True) Then
            peopleCheck = True
        Else
            peopleCheck = False
        End If
    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Me.Close()
    End Sub
End Class