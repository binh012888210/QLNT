﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmQuanLyTreEm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.dgvDanhSachTreEm = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnTaoMoi = New System.Windows.Forms.Button()
        Me.btnCapNhat = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSearchName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtMaSoTreEm = New System.Windows.Forms.TextBox()
        Me.txtHoTen = New System.Windows.Forms.TextBox()
        Me.txtHoTenPhuHuynh = New System.Windows.Forms.TextBox()
        Me.txtTenONha = New System.Windows.Forms.TextBox()
        Me.txtDiaChi = New System.Windows.Forms.TextBox()
        Me.txtDienThoai = New System.Windows.Forms.TextBox()
        Me.chkbxDanTocMienNui = New System.Windows.Forms.CheckBox()
        Me.dtpNgaySinh = New System.Windows.Forms.DateTimePicker()
        Me.lblTieuDe = New System.Windows.Forms.Label()
        Me.btnPhucHoi = New System.Windows.Forms.Button()
        Me.btnXoaVinhVien = New System.Windows.Forms.Button()
        Me.btnXoaFilePhucHoi = New System.Windows.Forms.Button()
        Me.chkbxXoaNangCao = New System.Windows.Forms.CheckBox()
        CType(Me.dgvDanhSachTreEm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvDanhSachTreEm
        '
        Me.dgvDanhSachTreEm.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDanhSachTreEm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDanhSachTreEm.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvDanhSachTreEm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDanhSachTreEm.Location = New System.Drawing.Point(334, 138)
        Me.dgvDanhSachTreEm.MultiSelect = False
        Me.dgvDanhSachTreEm.Name = "dgvDanhSachTreEm"
        Me.dgvDanhSachTreEm.RowHeadersVisible = False
        Me.dgvDanhSachTreEm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDanhSachTreEm.Size = New System.Drawing.Size(439, 344)
        Me.dgvDanhSachTreEm.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(62, 342)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 18)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "---------- Chức năng ----------"
        '
        'btnTaoMoi
        '
        Me.btnTaoMoi.Location = New System.Drawing.Point(27, 374)
        Me.btnTaoMoi.Name = "btnTaoMoi"
        Me.btnTaoMoi.Size = New System.Drawing.Size(117, 23)
        Me.btnTaoMoi.TabIndex = 1
        Me.btnTaoMoi.Text = "Tạo mới"
        Me.btnTaoMoi.UseVisualStyleBackColor = True
        '
        'btnCapNhat
        '
        Me.btnCapNhat.Location = New System.Drawing.Point(166, 374)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(123, 23)
        Me.btnCapNhat.TabIndex = 2
        Me.btnCapNhat.Text = "Cập nhật trẻ em"
        Me.btnCapNhat.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(27, 418)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(117, 23)
        Me.btnXoa.TabIndex = 3
        Me.btnXoa.Text = "Xoá trẻ em"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(467, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 18)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "----- Danh sách trẻ em -----"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(397, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(327, 18)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "----- Tra cứu trẻ em theo tên hoặc mã trẻ em -----"
        '
        'txtSearchName
        '
        Me.txtSearchName.Location = New System.Drawing.Point(334, 86)
        Me.txtSearchName.Name = "txtSearchName"
        Me.txtSearchName.Size = New System.Drawing.Size(439, 20)
        Me.txtSearchName.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(51, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(223, 18)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "---------- Thông tin trẻ em ----------"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 98)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "Mã trẻ em"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(36, 134)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 54
        Me.Label6.Text = "Họ tên trẻ"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(36, 174)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 55
        Me.Label7.Text = "Ngày sinh"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(36, 210)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 13)
        Me.Label8.TabIndex = 56
        Me.Label8.Text = "Họ tên phụ huynh"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(36, 245)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 13)
        Me.Label9.TabIndex = 57
        Me.Label9.Text = "Tên ở nhà"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(37, 279)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 13)
        Me.Label10.TabIndex = 58
        Me.Label10.Text = "Địa chỉ"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(37, 312)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 13)
        Me.Label11.TabIndex = 59
        Me.Label11.Text = "Điện thoại"
        '
        'txtMaSoTreEm
        '
        Me.txtMaSoTreEm.Location = New System.Drawing.Point(138, 98)
        Me.txtMaSoTreEm.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMaSoTreEm.Name = "txtMaSoTreEm"
        Me.txtMaSoTreEm.ReadOnly = True
        Me.txtMaSoTreEm.Size = New System.Drawing.Size(151, 20)
        Me.txtMaSoTreEm.TabIndex = 24
        '
        'txtHoTen
        '
        Me.txtHoTen.Location = New System.Drawing.Point(138, 131)
        Me.txtHoTen.Margin = New System.Windows.Forms.Padding(2)
        Me.txtHoTen.Name = "txtHoTen"
        Me.txtHoTen.Size = New System.Drawing.Size(151, 20)
        Me.txtHoTen.TabIndex = 8
        '
        'txtHoTenPhuHuynh
        '
        Me.txtHoTenPhuHuynh.Location = New System.Drawing.Point(138, 207)
        Me.txtHoTenPhuHuynh.Margin = New System.Windows.Forms.Padding(2)
        Me.txtHoTenPhuHuynh.Name = "txtHoTenPhuHuynh"
        Me.txtHoTenPhuHuynh.Size = New System.Drawing.Size(151, 20)
        Me.txtHoTenPhuHuynh.TabIndex = 11
        '
        'txtTenONha
        '
        Me.txtTenONha.Location = New System.Drawing.Point(138, 245)
        Me.txtTenONha.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTenONha.Name = "txtTenONha"
        Me.txtTenONha.Size = New System.Drawing.Size(151, 20)
        Me.txtTenONha.TabIndex = 12
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Location = New System.Drawing.Point(138, 279)
        Me.txtDiaChi.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(151, 20)
        Me.txtDiaChi.TabIndex = 13
        '
        'txtDienThoai
        '
        Me.txtDienThoai.Location = New System.Drawing.Point(138, 312)
        Me.txtDienThoai.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDienThoai.Name = "txtDienThoai"
        Me.txtDienThoai.Size = New System.Drawing.Size(151, 20)
        Me.txtDienThoai.TabIndex = 14
        '
        'chkbxDanTocMienNui
        '
        Me.chkbxDanTocMienNui.AutoSize = True
        Me.chkbxDanTocMienNui.Location = New System.Drawing.Point(138, 153)
        Me.chkbxDanTocMienNui.Margin = New System.Windows.Forms.Padding(2)
        Me.chkbxDanTocMienNui.Name = "chkbxDanTocMienNui"
        Me.chkbxDanTocMienNui.Size = New System.Drawing.Size(106, 17)
        Me.chkbxDanTocMienNui.TabIndex = 9
        Me.chkbxDanTocMienNui.Text = "Dân tộc miền núi"
        Me.chkbxDanTocMienNui.UseVisualStyleBackColor = True
        '
        'dtpNgaySinh
        '
        Me.dtpNgaySinh.Location = New System.Drawing.Point(138, 175)
        Me.dtpNgaySinh.Name = "dtpNgaySinh"
        Me.dtpNgaySinh.Size = New System.Drawing.Size(151, 20)
        Me.dtpNgaySinh.TabIndex = 10
        '
        'lblTieuDe
        '
        Me.lblTieuDe.AutoSize = True
        Me.lblTieuDe.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTieuDe.Location = New System.Drawing.Point(272, 21)
        Me.lblTieuDe.Name = "lblTieuDe"
        Me.lblTieuDe.Size = New System.Drawing.Size(256, 25)
        Me.lblTieuDe.TabIndex = 51
        Me.lblTieuDe.Text = "----- Quản Lý Trẻ Em  -----"
        '
        'btnPhucHoi
        '
        Me.btnPhucHoi.Location = New System.Drawing.Point(167, 418)
        Me.btnPhucHoi.Name = "btnPhucHoi"
        Me.btnPhucHoi.Size = New System.Drawing.Size(122, 23)
        Me.btnPhucHoi.TabIndex = 5
        Me.btnPhucHoi.Text = "Phục hồi trẻ em bị xoá"
        Me.btnPhucHoi.UseVisualStyleBackColor = True
        '
        'btnXoaVinhVien
        '
        Me.btnXoaVinhVien.Location = New System.Drawing.Point(27, 468)
        Me.btnXoaVinhVien.Name = "btnXoaVinhVien"
        Me.btnXoaVinhVien.Size = New System.Drawing.Size(117, 23)
        Me.btnXoaVinhVien.TabIndex = 4
        Me.btnXoaVinhVien.Text = "Xoá vĩnh viễn"
        Me.btnXoaVinhVien.UseVisualStyleBackColor = True
        Me.btnXoaVinhVien.Visible = False
        '
        'btnXoaFilePhucHoi
        '
        Me.btnXoaFilePhucHoi.Location = New System.Drawing.Point(167, 468)
        Me.btnXoaFilePhucHoi.Name = "btnXoaFilePhucHoi"
        Me.btnXoaFilePhucHoi.Size = New System.Drawing.Size(122, 23)
        Me.btnXoaFilePhucHoi.TabIndex = 6
        Me.btnXoaFilePhucHoi.Text = "Xoá file phục hồi"
        Me.btnXoaFilePhucHoi.UseVisualStyleBackColor = True
        Me.btnXoaFilePhucHoi.Visible = False
        '
        'chkbxXoaNangCao
        '
        Me.chkbxXoaNangCao.AutoSize = True
        Me.chkbxXoaNangCao.Location = New System.Drawing.Point(27, 447)
        Me.chkbxXoaNangCao.Name = "chkbxXoaNangCao"
        Me.chkbxXoaNangCao.Size = New System.Drawing.Size(93, 17)
        Me.chkbxXoaNangCao.TabIndex = 61
        Me.chkbxXoaNangCao.Text = "Xoá nâng cao"
        Me.chkbxXoaNangCao.UseVisualStyleBackColor = True
        '
        'frmQuanLyTreEm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(822, 531)
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
        Me.Name = "frmQuanLyTreEm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quản lý trẻ em"
        CType(Me.dgvDanhSachTreEm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvDanhSachTreEm As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents btnTaoMoi As Button
    Friend WithEvents btnCapNhat As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSearchName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtMaSoTreEm As TextBox
    Friend WithEvents txtHoTen As TextBox
    Friend WithEvents txtHoTenPhuHuynh As TextBox
    Friend WithEvents txtTenONha As TextBox
    Friend WithEvents txtDiaChi As TextBox
    Friend WithEvents txtDienThoai As TextBox
    Friend WithEvents chkbxDanTocMienNui As CheckBox
    Friend WithEvents dtpNgaySinh As DateTimePicker
    Friend WithEvents lblTieuDe As Label
    Friend WithEvents btnPhucHoi As Button
    Friend WithEvents btnXoaVinhVien As Button
    Friend WithEvents btnXoaFilePhucHoi As Button
    Friend WithEvents chkbxXoaNangCao As CheckBox
End Class
