<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHuongDanQuanLyGhiNhanTinhTrang
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
        Me.txtNgayGhiNhan = New System.Windows.Forms.TextBox()
        Me.chkbxSortStudent = New System.Windows.Forms.CheckBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbLop = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbTinhTrang = New System.Windows.Forms.ComboBox()
        Me.dgvDanhSachGhiNhan = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTenKhoi = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnDong = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnCapNhat = New System.Windows.Forms.Button()
        Me.btnTaoMoi = New System.Windows.Forms.Button()
        Me.txtHoTenTre = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgvDanhSachTreEm = New System.Windows.Forms.DataGridView()
        Me.txtMaGhiNhan = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
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
        CType(Me.dgvDanhSachGhiNhan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDanhSachTreEm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNgayGhiNhan
        '
        Me.txtNgayGhiNhan.Location = New System.Drawing.Point(337, 304)
        Me.txtNgayGhiNhan.Name = "txtNgayGhiNhan"
        Me.txtNgayGhiNhan.ReadOnly = True
        Me.txtNgayGhiNhan.Size = New System.Drawing.Size(150, 20)
        Me.txtNgayGhiNhan.TabIndex = 127
        '
        'chkbxSortStudent
        '
        Me.chkbxSortStudent.AutoSize = True
        Me.chkbxSortStudent.Location = New System.Drawing.Point(546, 296)
        Me.chkbxSortStudent.Name = "chkbxSortStudent"
        Me.chkbxSortStudent.Size = New System.Drawing.Size(277, 17)
        Me.chkbxSortStudent.TabIndex = 126
        Me.chkbxSortStudent.Text = "Lấy danh sách phiếu ghi nhận của trẻ em được chọn"
        Me.chkbxSortStudent.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(348, 54)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(425, 25)
        Me.Label11.TabIndex = 125
        Me.Label11.Text = "----- Quản Lý Ghi Nhận Tình Trạng Trẻ  -----"
        '
        'cbLop
        '
        Me.cbLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbLop.FormattingEnabled = True
        Me.cbLop.Location = New System.Drawing.Point(735, 113)
        Me.cbLop.Name = "cbLop"
        Me.cbLop.Size = New System.Drawing.Size(95, 21)
        Me.cbLop.TabIndex = 124
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(680, 116)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 123
        Me.Label6.Text = "Chọn lớp"
        '
        'cbTinhTrang
        '
        Me.cbTinhTrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTinhTrang.FormattingEnabled = True
        Me.cbTinhTrang.Location = New System.Drawing.Point(338, 218)
        Me.cbTinhTrang.Name = "cbTinhTrang"
        Me.cbTinhTrang.Size = New System.Drawing.Size(149, 21)
        Me.cbTinhTrang.TabIndex = 122
        '
        'dgvDanhSachGhiNhan
        '
        Me.dgvDanhSachGhiNhan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDanhSachGhiNhan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvDanhSachGhiNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDanhSachGhiNhan.Location = New System.Drawing.Point(509, 322)
        Me.dgvDanhSachGhiNhan.Name = "dgvDanhSachGhiNhan"
        Me.dgvDanhSachGhiNhan.RowHeadersVisible = False
        Me.dgvDanhSachGhiNhan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDanhSachGhiNhan.Size = New System.Drawing.Size(339, 119)
        Me.dgvDanhSachGhiNhan.TabIndex = 121
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(566, 275)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(235, 18)
        Me.Label1.TabIndex = 120
        Me.Label1.Text = "----- Danh sách phiếu ghi nhận -----"
        '
        'txtTenKhoi
        '
        Me.txtTenKhoi.Location = New System.Drawing.Point(338, 261)
        Me.txtTenKhoi.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTenKhoi.Name = "txtTenKhoi"
        Me.txtTenKhoi.ReadOnly = True
        Me.txtTenKhoi.Size = New System.Drawing.Size(149, 20)
        Me.txtTenKhoi.TabIndex = 119
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(251, 264)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 13)
        Me.Label10.TabIndex = 118
        Me.Label10.Text = "Tên khối"
        '
        'btnDong
        '
        Me.btnDong.Location = New System.Drawing.Point(378, 418)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(111, 23)
        Me.btnDong.TabIndex = 117
        Me.btnDong.Text = "Đóng"
        Me.btnDong.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(256, 418)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(97, 23)
        Me.btnXoa.TabIndex = 116
        Me.btnXoa.Text = "Xoá Ghi nhận"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(273, 345)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(187, 18)
        Me.Label9.TabIndex = 115
        Me.Label9.Text = "---------- Chức năng ----------"
        '
        'btnCapNhat
        '
        Me.btnCapNhat.Location = New System.Drawing.Point(377, 379)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(113, 23)
        Me.btnCapNhat.TabIndex = 114
        Me.btnCapNhat.Text = "Cập nhật ghi nhận"
        Me.btnCapNhat.UseVisualStyleBackColor = True
        '
        'btnTaoMoi
        '
        Me.btnTaoMoi.Location = New System.Drawing.Point(256, 379)
        Me.btnTaoMoi.Name = "btnTaoMoi"
        Me.btnTaoMoi.Size = New System.Drawing.Size(97, 23)
        Me.btnTaoMoi.TabIndex = 113
        Me.btnTaoMoi.Text = "Tạo mới"
        Me.btnTaoMoi.UseVisualStyleBackColor = True
        '
        'txtHoTenTre
        '
        Me.txtHoTenTre.Location = New System.Drawing.Point(338, 181)
        Me.txtHoTenTre.Margin = New System.Windows.Forms.Padding(2)
        Me.txtHoTenTre.Name = "txtHoTenTre"
        Me.txtHoTenTre.ReadOnly = True
        Me.txtHoTenTre.Size = New System.Drawing.Size(150, 20)
        Me.txtHoTenTre.TabIndex = 112
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(251, 108)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(236, 18)
        Me.Label8.TabIndex = 111
        Me.Label8.Text = "---------- Thông tin ghi nhận ----------"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(566, 92)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(244, 18)
        Me.Label7.TabIndex = 110
        Me.Label7.Text = "----- Danh sách trẻ em theo lớp  -----"
        '
        'dgvDanhSachTreEm
        '
        Me.dgvDanhSachTreEm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDanhSachTreEm.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvDanhSachTreEm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDanhSachTreEm.Location = New System.Drawing.Point(509, 140)
        Me.dgvDanhSachTreEm.Name = "dgvDanhSachTreEm"
        Me.dgvDanhSachTreEm.RowHeadersVisible = False
        Me.dgvDanhSachTreEm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDanhSachTreEm.Size = New System.Drawing.Size(339, 123)
        Me.dgvDanhSachTreEm.TabIndex = 109
        '
        'txtMaGhiNhan
        '
        Me.txtMaGhiNhan.Location = New System.Drawing.Point(338, 140)
        Me.txtMaGhiNhan.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMaGhiNhan.Name = "txtMaGhiNhan"
        Me.txtMaGhiNhan.ReadOnly = True
        Me.txtMaGhiNhan.Size = New System.Drawing.Size(150, 20)
        Me.txtMaGhiNhan.TabIndex = 108
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(252, 143)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 107
        Me.Label5.Text = "Mã ghi nhận"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(251, 221)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 106
        Me.Label4.Text = "Tên tình trạng"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(252, 307)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 105
        Me.Label3.Text = "Ngày ghi nhận"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(252, 184)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 104
        Me.Label2.Text = "Họ tên trẻ"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(52, 196)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(172, 26)
        Me.Label12.TabIndex = 128
        Me.Label12.Text = "8. Chọn trẻ trong danh sách trẻ " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "để nạp vào Họ tên trẻ và Tên khối"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(52, 143)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(181, 26)
        Me.Label13.TabIndex = 129
        Me.Label13.Text = "7. Mã ghi nhận sẽ được nạp tự động" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "khi thực hiện bước 6"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(52, 384)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(150, 13)
        Me.Label14.TabIndex = 130
        Me.Label14.Text = "6. Tạo một phiếu ghi nhận mới"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(131, 56)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(158, 52)
        Me.Label15.TabIndex = 131
        Me.Label15.Text = "5. Các thông tin của phiếu ghi " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "nhận sẽ được tự động nạp vào " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "thông tin ghi nhậ" &
    "n sau khi " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "thực hiện bước 4"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(869, 160)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(191, 13)
        Me.Label16.TabIndex = 132
        Me.Label16.Text = "2. Chọn trẻ em trong danh sách trẻ em "
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(867, 279)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(193, 39)
        Me.Label17.TabIndex = 133
        Me.Label17.Text = "3. Lấy danh sách phiếu ghi nhận" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "của trẻ em được chọn khi được check" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Nếu không t" &
    "hì lấy tất cả phiếu ghi nhận"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(869, 116)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(158, 13)
        Me.Label18.TabIndex = 134
        Me.Label18.Text = "1. Chọn lớp trong danh sách lớp"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(869, 379)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(144, 26)
        Me.Label19.TabIndex = 135
        Me.Label19.Text = "4. Chọn phiếu ghi nhận trong" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "danh sách phiếu ghi nhận"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(52, 307)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(188, 26)
        Me.Label20.TabIndex = 136
        Me.Label20.Text = "9. Ngày ghi nhận sẽ được tạo tự động" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "và là ngày hiện tại"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(52, 418)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(174, 26)
        Me.Label21.TabIndex = 137
        Me.Label21.Text = "10. Nút Cập nhật để thêm ghi nhận" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "mới hoặc cập nhật ghi nhận cũ"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(52, 469)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(197, 26)
        Me.Label22.TabIndex = 138
        Me.Label22.Text = "11. Nút Xoá ghi nhận để xoá " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "phiếu ghi nhận sau khi thực hiện bước 4"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(52, 469)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(0, 13)
        Me.Label23.TabIndex = 139
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(52, 523)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(93, 13)
        Me.Label24.TabIndex = 140
        Me.Label24.Text = "12. Nút đóng form"
        '
        'frmHuongDanQuanLyGhiNhanTinhTrang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1120, 583)
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
        Me.Name = "frmHuongDanQuanLyGhiNhanTinhTrang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hướng dẫn quản lý ghi nhận tình trạng trẻ"
        CType(Me.dgvDanhSachGhiNhan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDanhSachTreEm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNgayGhiNhan As TextBox
    Friend WithEvents chkbxSortStudent As CheckBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cbLop As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cbTinhTrang As ComboBox
    Friend WithEvents dgvDanhSachGhiNhan As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTenKhoi As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnDong As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents btnCapNhat As Button
    Friend WithEvents btnTaoMoi As Button
    Friend WithEvents txtHoTenTre As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents dgvDanhSachTreEm As DataGridView
    Friend WithEvents txtMaGhiNhan As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
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
