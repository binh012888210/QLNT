<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHuongDanQuanLyTreEm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.chkbxXoaNangCao = New System.Windows.Forms.CheckBox()
        Me.btnXoaFilePhucHoi = New System.Windows.Forms.Button()
        Me.btnXoaVinhVien = New System.Windows.Forms.Button()
        Me.btnPhucHoi = New System.Windows.Forms.Button()
        Me.lblTieuDe = New System.Windows.Forms.Label()
        Me.dtpNgaySinh = New System.Windows.Forms.DateTimePicker()
        Me.chkbxDanTocMienNui = New System.Windows.Forms.CheckBox()
        Me.txtDienThoai = New System.Windows.Forms.TextBox()
        Me.txtDiaChi = New System.Windows.Forms.TextBox()
        Me.txtTenONha = New System.Windows.Forms.TextBox()
        Me.txtHoTenPhuHuynh = New System.Windows.Forms.TextBox()
        Me.txtHoTen = New System.Windows.Forms.TextBox()
        Me.txtMaSoTreEm = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSearchName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnCapNhat = New System.Windows.Forms.Button()
        Me.btnTaoMoi = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvDanhSachTreEm = New System.Windows.Forms.DataGridView()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        CType(Me.dgvDanhSachTreEm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkbxXoaNangCao
        '
        Me.chkbxXoaNangCao.AutoSize = True
        Me.chkbxXoaNangCao.Location = New System.Drawing.Point(231, 479)
        Me.chkbxXoaNangCao.Name = "chkbxXoaNangCao"
        Me.chkbxXoaNangCao.Size = New System.Drawing.Size(93, 17)
        Me.chkbxXoaNangCao.TabIndex = 90
        Me.chkbxXoaNangCao.Text = "Xoá nâng cao"
        Me.chkbxXoaNangCao.UseVisualStyleBackColor = True
        '
        'btnXoaFilePhucHoi
        '
        Me.btnXoaFilePhucHoi.Location = New System.Drawing.Point(371, 500)
        Me.btnXoaFilePhucHoi.Name = "btnXoaFilePhucHoi"
        Me.btnXoaFilePhucHoi.Size = New System.Drawing.Size(122, 23)
        Me.btnXoaFilePhucHoi.TabIndex = 69
        Me.btnXoaFilePhucHoi.Text = "Xoá file phục hồi"
        Me.btnXoaFilePhucHoi.UseVisualStyleBackColor = True
        Me.btnXoaFilePhucHoi.Visible = False
        '
        'btnXoaVinhVien
        '
        Me.btnXoaVinhVien.Location = New System.Drawing.Point(231, 500)
        Me.btnXoaVinhVien.Name = "btnXoaVinhVien"
        Me.btnXoaVinhVien.Size = New System.Drawing.Size(117, 23)
        Me.btnXoaVinhVien.TabIndex = 66
        Me.btnXoaVinhVien.Text = "Xoá vĩnh viễn"
        Me.btnXoaVinhVien.UseVisualStyleBackColor = True
        Me.btnXoaVinhVien.Visible = False
        '
        'btnPhucHoi
        '
        Me.btnPhucHoi.Location = New System.Drawing.Point(371, 450)
        Me.btnPhucHoi.Name = "btnPhucHoi"
        Me.btnPhucHoi.Size = New System.Drawing.Size(122, 23)
        Me.btnPhucHoi.TabIndex = 68
        Me.btnPhucHoi.Text = "Phục hồi trẻ em bị xoá"
        Me.btnPhucHoi.UseVisualStyleBackColor = True
        '
        'lblTieuDe
        '
        Me.lblTieuDe.AutoSize = True
        Me.lblTieuDe.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTieuDe.Location = New System.Drawing.Point(422, 36)
        Me.lblTieuDe.Name = "lblTieuDe"
        Me.lblTieuDe.Size = New System.Drawing.Size(256, 25)
        Me.lblTieuDe.TabIndex = 80
        Me.lblTieuDe.Text = "----- Quản Lý Trẻ Em  -----"
        '
        'dtpNgaySinh
        '
        Me.dtpNgaySinh.Location = New System.Drawing.Point(342, 207)
        Me.dtpNgaySinh.Name = "dtpNgaySinh"
        Me.dtpNgaySinh.Size = New System.Drawing.Size(151, 20)
        Me.dtpNgaySinh.TabIndex = 73
        '
        'chkbxDanTocMienNui
        '
        Me.chkbxDanTocMienNui.AutoSize = True
        Me.chkbxDanTocMienNui.Location = New System.Drawing.Point(342, 185)
        Me.chkbxDanTocMienNui.Margin = New System.Windows.Forms.Padding(2)
        Me.chkbxDanTocMienNui.Name = "chkbxDanTocMienNui"
        Me.chkbxDanTocMienNui.Size = New System.Drawing.Size(106, 17)
        Me.chkbxDanTocMienNui.TabIndex = 72
        Me.chkbxDanTocMienNui.Text = "Dân tộc miền núi"
        Me.chkbxDanTocMienNui.UseVisualStyleBackColor = True
        '
        'txtDienThoai
        '
        Me.txtDienThoai.Location = New System.Drawing.Point(342, 344)
        Me.txtDienThoai.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDienThoai.Name = "txtDienThoai"
        Me.txtDienThoai.Size = New System.Drawing.Size(151, 20)
        Me.txtDienThoai.TabIndex = 77
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Location = New System.Drawing.Point(342, 311)
        Me.txtDiaChi.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(151, 20)
        Me.txtDiaChi.TabIndex = 76
        '
        'txtTenONha
        '
        Me.txtTenONha.Location = New System.Drawing.Point(342, 277)
        Me.txtTenONha.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTenONha.Name = "txtTenONha"
        Me.txtTenONha.Size = New System.Drawing.Size(151, 20)
        Me.txtTenONha.TabIndex = 75
        '
        'txtHoTenPhuHuynh
        '
        Me.txtHoTenPhuHuynh.Location = New System.Drawing.Point(342, 239)
        Me.txtHoTenPhuHuynh.Margin = New System.Windows.Forms.Padding(2)
        Me.txtHoTenPhuHuynh.Name = "txtHoTenPhuHuynh"
        Me.txtHoTenPhuHuynh.Size = New System.Drawing.Size(151, 20)
        Me.txtHoTenPhuHuynh.TabIndex = 74
        '
        'txtHoTen
        '
        Me.txtHoTen.Location = New System.Drawing.Point(342, 163)
        Me.txtHoTen.Margin = New System.Windows.Forms.Padding(2)
        Me.txtHoTen.Name = "txtHoTen"
        Me.txtHoTen.Size = New System.Drawing.Size(151, 20)
        Me.txtHoTen.TabIndex = 71
        '
        'txtMaSoTreEm
        '
        Me.txtMaSoTreEm.Location = New System.Drawing.Point(342, 130)
        Me.txtMaSoTreEm.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMaSoTreEm.Name = "txtMaSoTreEm"
        Me.txtMaSoTreEm.ReadOnly = True
        Me.txtMaSoTreEm.Size = New System.Drawing.Size(151, 20)
        Me.txtMaSoTreEm.TabIndex = 78
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(241, 344)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 13)
        Me.Label11.TabIndex = 88
        Me.Label11.Text = "Điện thoại"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(241, 311)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 13)
        Me.Label10.TabIndex = 87
        Me.Label10.Text = "Địa chỉ"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(240, 277)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 13)
        Me.Label9.TabIndex = 86
        Me.Label9.Text = "Tên ở nhà"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(240, 242)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 13)
        Me.Label8.TabIndex = 85
        Me.Label8.Text = "Họ tên phụ huynh"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(240, 206)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 84
        Me.Label7.Text = "Ngày sinh"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(240, 166)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 83
        Me.Label6.Text = "Họ tên trẻ"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(240, 130)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 82
        Me.Label5.Text = "Mã trẻ em"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(255, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(223, 18)
        Me.Label4.TabIndex = 81
        Me.Label4.Text = "---------- Thông tin trẻ em ----------"
        '
        'txtSearchName
        '
        Me.txtSearchName.Location = New System.Drawing.Point(538, 118)
        Me.txtSearchName.Name = "txtSearchName"
        Me.txtSearchName.Size = New System.Drawing.Size(439, 20)
        Me.txtSearchName.TabIndex = 70
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(601, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(327, 18)
        Me.Label3.TabIndex = 79
        Me.Label3.Text = "----- Tra cứu trẻ em theo tên hoặc mã trẻ em -----"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(671, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 18)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "----- Danh sách trẻ em -----"
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(231, 450)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(117, 23)
        Me.btnXoa.TabIndex = 65
        Me.btnXoa.Text = "Xoá trẻ em"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnCapNhat
        '
        Me.btnCapNhat.Location = New System.Drawing.Point(370, 406)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(123, 23)
        Me.btnCapNhat.TabIndex = 64
        Me.btnCapNhat.Text = "Cập nhật trẻ em"
        Me.btnCapNhat.UseVisualStyleBackColor = True
        '
        'btnTaoMoi
        '
        Me.btnTaoMoi.Location = New System.Drawing.Point(231, 406)
        Me.btnTaoMoi.Name = "btnTaoMoi"
        Me.btnTaoMoi.Size = New System.Drawing.Size(117, 23)
        Me.btnTaoMoi.TabIndex = 63
        Me.btnTaoMoi.Text = "Tạo mới"
        Me.btnTaoMoi.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(266, 374)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 18)
        Me.Label1.TabIndex = 89
        Me.Label1.Text = "---------- Chức năng ----------"
        '
        'dgvDanhSachTreEm
        '
        Me.dgvDanhSachTreEm.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDanhSachTreEm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDanhSachTreEm.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvDanhSachTreEm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDanhSachTreEm.Location = New System.Drawing.Point(538, 170)
        Me.dgvDanhSachTreEm.MultiSelect = False
        Me.dgvDanhSachTreEm.Name = "dgvDanhSachTreEm"
        Me.dgvDanhSachTreEm.RowHeadersVisible = False
        Me.dgvDanhSachTreEm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDanhSachTreEm.Size = New System.Drawing.Size(439, 344)
        Me.dgvDanhSachTreEm.TabIndex = 62
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(69, 130)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(166, 26)
        Me.Label12.TabIndex = 91
        Me.Label12.Text = "3. Mã trẻ em sẽ được tạo tự động" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "sau khi thực hiện bước 1"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(80, 79)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(216, 13)
        Me.Label13.TabIndex = 92
        Me.Label13.Text = "2. Điền các thông tin trẻ em vào các ô trống"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(127, 206)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(92, 13)
        Me.Label14.TabIndex = 93
        Me.Label14.Text = "5. Chọn ngày sinh"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(146, 186)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(178, 13)
        Me.Label15.TabIndex = 94
        Me.Label15.Text = "4. Kiểm tra tên nếu là người miền núi"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(28, 406)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(177, 13)
        Me.Label16.TabIndex = 95
        Me.Label16.Text = "1. Bấm nút tạo mới để tạo hồ sơ mới"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(28, 434)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(196, 26)
        Me.Label17.TabIndex = 96
        Me.Label17.Text = "6. Bấm nút cập nhật để thêm trẻ em mới" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " hoặc cập nhật trẻ em cũ"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(28, 479)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(175, 13)
        Me.Label18.TabIndex = 97
        Me.Label18.Text = "9. Bấm nút xoá trẻ em để xoá hồ sơ"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(28, 526)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(227, 13)
        Me.Label19.TabIndex = 98
        Me.Label19.Text = "10. Bấm nút phục hồi để phục hồi tất cả hồ sơ"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(28, 553)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(247, 13)
        Me.Label20.TabIndex = 99
        Me.Label20.Text = "11. Bấm nút xoá vĩnh viễn để không thể phục hồi "
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(28, 579)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(352, 13)
        Me.Label21.TabIndex = 100
        Me.Label21.Text = "12. Bấm nút Xoá file phục hồi để xoá tất cả hồ sơ trong cơ sở dữ liệu phụ"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(858, 65)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(187, 13)
        Me.Label22.TabIndex = 101
        Me.Label22.Text = "7. Điền tên hoặc mã trẻ em để tra cứu"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(688, 540)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(270, 13)
        Me.Label23.TabIndex = 102
        Me.Label23.Text = "8.1 Chọn trẻ em trong danh sách để cập nhật hoặc xoá"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(28, 272)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(153, 52)
        Me.Label24.TabIndex = 132
        Me.Label24.Text = "8.2 Các thông tin của hồ sơ trẻ" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "em sẽ được nạp  tự động vào " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "thông tin trẻ em  " &
    "sau khi " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "thực hiện bước 8.1"
        '
        'frmHuongDanQuanLyTreEm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1063, 649)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.chkbxXoaNangCao)
        Me.Controls.Add(Me.btnXoaFilePhucHoi)
        Me.Controls.Add(Me.btnXoaVinhVien)
        Me.Controls.Add(Me.btnPhucHoi)
        Me.Controls.Add(Me.lblTieuDe)
        Me.Controls.Add(Me.dtpNgaySinh)
        Me.Controls.Add(Me.chkbxDanTocMienNui)
        Me.Controls.Add(Me.txtDienThoai)
        Me.Controls.Add(Me.txtDiaChi)
        Me.Controls.Add(Me.txtTenONha)
        Me.Controls.Add(Me.txtHoTenPhuHuynh)
        Me.Controls.Add(Me.txtHoTen)
        Me.Controls.Add(Me.txtMaSoTreEm)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtSearchName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnCapNhat)
        Me.Controls.Add(Me.btnTaoMoi)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvDanhSachTreEm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmHuongDanQuanLyTreEm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hướng dẫn quản lý trẻ em"
        CType(Me.dgvDanhSachTreEm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkbxXoaNangCao As CheckBox
    Friend WithEvents btnXoaFilePhucHoi As Button
    Friend WithEvents btnXoaVinhVien As Button
    Friend WithEvents btnPhucHoi As Button
    Friend WithEvents lblTieuDe As Label
    Friend WithEvents dtpNgaySinh As DateTimePicker
    Friend WithEvents chkbxDanTocMienNui As CheckBox
    Friend WithEvents txtDienThoai As TextBox
    Friend WithEvents txtDiaChi As TextBox
    Friend WithEvents txtTenONha As TextBox
    Friend WithEvents txtHoTenPhuHuynh As TextBox
    Friend WithEvents txtHoTen As TextBox
    Friend WithEvents txtMaSoTreEm As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSearchName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnCapNhat As Button
    Friend WithEvents btnTaoMoi As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvDanhSachTreEm As DataGridView
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
End Class
