﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmQuanLyGhiNhanTinhTrangTre
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMaGhiNhan = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgvDanhSachTreEm = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtHoTenTre = New System.Windows.Forms.TextBox()
        Me.btnTaoMoi = New System.Windows.Forms.Button()
        Me.btnCapNhat = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnDong = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTenKhoi = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvDanhSachGhiNhan = New System.Windows.Forms.DataGridView()
        Me.cbTinhTrang = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbLop = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.chkbxSortStudent = New System.Windows.Forms.CheckBox()
        Me.txtNgayGhiNhan = New System.Windows.Forms.TextBox()
        CType(Me.dgvDanhSachTreEm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDanhSachGhiNhan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(49, 151)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Họ tên trẻ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(49, 274)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Ngày ghi nhận"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(48, 188)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Tên tình trạng"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(49, 110)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Mã ghi nhận"
        '
        'txtMaGhiNhan
        '
        Me.txtMaGhiNhan.Location = New System.Drawing.Point(135, 107)
        Me.txtMaGhiNhan.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMaGhiNhan.Name = "txtMaGhiNhan"
        Me.txtMaGhiNhan.ReadOnly = True
        Me.txtMaGhiNhan.Size = New System.Drawing.Size(150, 20)
        Me.txtMaGhiNhan.TabIndex = 28
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(363, 59)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(244, 18)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "----- Danh sách trẻ em theo lớp  -----"
        '
        'dgvDanhSachTreEm
        '
        Me.dgvDanhSachTreEm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDanhSachTreEm.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvDanhSachTreEm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDanhSachTreEm.Location = New System.Drawing.Point(306, 107)
        Me.dgvDanhSachTreEm.Name = "dgvDanhSachTreEm"
        Me.dgvDanhSachTreEm.RowHeadersVisible = False
        Me.dgvDanhSachTreEm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDanhSachTreEm.Size = New System.Drawing.Size(339, 123)
        Me.dgvDanhSachTreEm.TabIndex = 34
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(48, 75)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(236, 18)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "---------- Thông tin ghi nhận ----------"
        '
        'txtHoTenTre
        '
        Me.txtHoTenTre.Location = New System.Drawing.Point(135, 148)
        Me.txtHoTenTre.Margin = New System.Windows.Forms.Padding(2)
        Me.txtHoTenTre.Name = "txtHoTenTre"
        Me.txtHoTenTre.ReadOnly = True
        Me.txtHoTenTre.Size = New System.Drawing.Size(150, 20)
        Me.txtHoTenTre.TabIndex = 40
        '
        'btnTaoMoi
        '
        Me.btnTaoMoi.Location = New System.Drawing.Point(53, 346)
        Me.btnTaoMoi.Name = "btnTaoMoi"
        Me.btnTaoMoi.Size = New System.Drawing.Size(97, 23)
        Me.btnTaoMoi.TabIndex = 42
        Me.btnTaoMoi.Text = "Tạo mới"
        Me.btnTaoMoi.UseVisualStyleBackColor = True
        '
        'btnCapNhat
        '
        Me.btnCapNhat.Location = New System.Drawing.Point(174, 346)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(113, 23)
        Me.btnCapNhat.TabIndex = 43
        Me.btnCapNhat.Text = "Cập nhật ghi nhận"
        Me.btnCapNhat.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(70, 312)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(187, 18)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "---------- Chức năng ----------"
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(53, 385)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(97, 23)
        Me.btnXoa.TabIndex = 46
        Me.btnXoa.Text = "Xoá Ghi nhận"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnDong
        '
        Me.btnDong.Location = New System.Drawing.Point(175, 385)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(111, 23)
        Me.btnDong.TabIndex = 47
        Me.btnDong.Text = "Đóng"
        Me.btnDong.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(48, 231)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 13)
        Me.Label10.TabIndex = 50
        Me.Label10.Text = "Tên khối"
        '
        'txtTenKhoi
        '
        Me.txtTenKhoi.Location = New System.Drawing.Point(135, 228)
        Me.txtTenKhoi.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTenKhoi.Name = "txtTenKhoi"
        Me.txtTenKhoi.ReadOnly = True
        Me.txtTenKhoi.Size = New System.Drawing.Size(149, 20)
        Me.txtTenKhoi.TabIndex = 51
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(363, 242)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(235, 18)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "----- Danh sách phiếu ghi nhận -----"
        '
        'dgvDanhSachGhiNhan
        '
        Me.dgvDanhSachGhiNhan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDanhSachGhiNhan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvDanhSachGhiNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDanhSachGhiNhan.Location = New System.Drawing.Point(306, 289)
        Me.dgvDanhSachGhiNhan.Name = "dgvDanhSachGhiNhan"
        Me.dgvDanhSachGhiNhan.RowHeadersVisible = False
        Me.dgvDanhSachGhiNhan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDanhSachGhiNhan.Size = New System.Drawing.Size(339, 119)
        Me.dgvDanhSachGhiNhan.TabIndex = 53
        '
        'cbTinhTrang
        '
        Me.cbTinhTrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTinhTrang.FormattingEnabled = True
        Me.cbTinhTrang.Location = New System.Drawing.Point(135, 185)
        Me.cbTinhTrang.Name = "cbTinhTrang"
        Me.cbTinhTrang.Size = New System.Drawing.Size(149, 21)
        Me.cbTinhTrang.TabIndex = 55
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(477, 83)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "Chọn lớp"
        '
        'cbLop
        '
        Me.cbLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbLop.FormattingEnabled = True
        Me.cbLop.Location = New System.Drawing.Point(532, 80)
        Me.cbLop.Name = "cbLop"
        Me.cbLop.Size = New System.Drawing.Size(95, 21)
        Me.cbLop.TabIndex = 58
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(145, 21)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(425, 25)
        Me.Label11.TabIndex = 101
        Me.Label11.Text = "----- Quản Lý Ghi Nhận Tình Trạng Trẻ  -----"
        '
        'chkbxSortStudent
        '
        Me.chkbxSortStudent.AutoSize = True
        Me.chkbxSortStudent.Location = New System.Drawing.Point(343, 263)
        Me.chkbxSortStudent.Name = "chkbxSortStudent"
        Me.chkbxSortStudent.Size = New System.Drawing.Size(277, 17)
        Me.chkbxSortStudent.TabIndex = 102
        Me.chkbxSortStudent.Text = "Lấy danh sách phiếu ghi nhận của trẻ em được chọn"
        Me.chkbxSortStudent.UseVisualStyleBackColor = True
        '
        'txtNgayGhiNhan
        '
        Me.txtNgayGhiNhan.Location = New System.Drawing.Point(134, 271)
        Me.txtNgayGhiNhan.Name = "txtNgayGhiNhan"
        Me.txtNgayGhiNhan.ReadOnly = True
        Me.txtNgayGhiNhan.Size = New System.Drawing.Size(150, 20)
        Me.txtNgayGhiNhan.TabIndex = 103
        '
        'frmQuanLyGhiNhanTinhTrangTre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(696, 453)
        Me.Controls.Add(Me.txtNgayGhiNhan)
        Me.Controls.Add(Me.chkbxSortStudent)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cbLop)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbTinhTrang)
        Me.Controls.Add(Me.dgvDanhSachGhiNhan)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTenKhoi)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnDong)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnCapNhat)
        Me.Controls.Add(Me.btnTaoMoi)
        Me.Controls.Add(Me.txtHoTenTre)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dgvDanhSachTreEm)
        Me.Controls.Add(Me.txtMaGhiNhan)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmQuanLyGhiNhanTinhTrangTre"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quản lý ghi nhận tình trạng trẻ em"
        CType(Me.dgvDanhSachTreEm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDanhSachGhiNhan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtMaGhiNhan As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents dgvDanhSachTreEm As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents txtHoTenTre As TextBox
    Friend WithEvents btnTaoMoi As Button
    Friend WithEvents btnCapNhat As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnDong As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents txtTenKhoi As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvDanhSachGhiNhan As DataGridView
    Friend WithEvents cbTinhTrang As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cbLop As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents chkbxSortStudent As CheckBox
    Friend WithEvents txtNgayGhiNhan As TextBox
End Class
