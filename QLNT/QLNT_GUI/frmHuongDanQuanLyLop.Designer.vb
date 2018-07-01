<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHuongDanQuanLyLop
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
        Me.txtSearchName = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtMaLop1 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtMaSoTreEm = New System.Windows.Forms.TextBox()
        Me.btnXoaKhoiLop = New System.Windows.Forms.Button()
        Me.btnCapNhat = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTuoi = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtpNgayNhapHoc = New System.Windows.Forms.DateTimePicker()
        Me.txtGhiChu = New System.Windows.Forms.TextBox()
        Me.txtHoTen = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtMaLop = New System.Windows.Forms.TextBox()
        Me.txtMaKhoi = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSoTreEmCuaLop = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbLop = New System.Windows.Forms.ComboBox()
        Me.cbKhoi = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnChuyenLop = New System.Windows.Forms.Button()
        Me.btnThemVaoLop = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgvTreEmChuaCoLop = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvTreEmCoLop = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        CType(Me.dgvTreEmChuaCoLop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTreEmCoLop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSearchName
        '
        Me.txtSearchName.Location = New System.Drawing.Point(393, 327)
        Me.txtSearchName.Name = "txtSearchName"
        Me.txtSearchName.Size = New System.Drawing.Size(115, 20)
        Me.txtSearchName.TabIndex = 137
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(220, 330)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(162, 13)
        Me.Label17.TabIndex = 138
        Me.Label17.Text = "Tra cứu trẻ em theo tên hoặc mã"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(425, 43)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(223, 25)
        Me.Label16.TabIndex = 136
        Me.Label16.Text = "----- Quản Lý Lớp  -----"
        '
        'txtMaLop1
        '
        Me.txtMaLop1.Location = New System.Drawing.Point(337, 103)
        Me.txtMaLop1.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMaLop1.Name = "txtMaLop1"
        Me.txtMaLop1.ReadOnly = True
        Me.txtMaLop1.Size = New System.Drawing.Size(151, 20)
        Me.txtMaLop1.TabIndex = 135
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(231, 106)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(43, 13)
        Me.Label14.TabIndex = 134
        Me.Label14.Text = "Mã Lớp"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(231, 141)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(54, 13)
        Me.Label15.TabIndex = 132
        Me.Label15.Text = "Mã trẻ em"
        '
        'txtMaSoTreEm
        '
        Me.txtMaSoTreEm.Location = New System.Drawing.Point(337, 138)
        Me.txtMaSoTreEm.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMaSoTreEm.Name = "txtMaSoTreEm"
        Me.txtMaSoTreEm.ReadOnly = True
        Me.txtMaSoTreEm.Size = New System.Drawing.Size(151, 20)
        Me.txtMaSoTreEm.TabIndex = 133
        '
        'btnXoaKhoiLop
        '
        Me.btnXoaKhoiLop.Location = New System.Drawing.Point(430, 277)
        Me.btnXoaKhoiLop.Name = "btnXoaKhoiLop"
        Me.btnXoaKhoiLop.Size = New System.Drawing.Size(75, 23)
        Me.btnXoaKhoiLop.TabIndex = 131
        Me.btnXoaKhoiLop.Text = "Xoá khỏi lớp"
        Me.btnXoaKhoiLop.UseVisualStyleBackColor = True
        '
        'btnCapNhat
        '
        Me.btnCapNhat.Location = New System.Drawing.Point(224, 277)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(75, 23)
        Me.btnCapNhat.TabIndex = 130
        Me.btnCapNhat.Text = "Cập nhật  thông tin"
        Me.btnCapNhat.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(245, 73)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(223, 18)
        Me.Label9.TabIndex = 129
        Me.Label9.Text = "---------- Thông tin trẻ em ----------"
        '
        'txtTuoi
        '
        Me.txtTuoi.Location = New System.Drawing.Point(458, 175)
        Me.txtTuoi.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTuoi.Name = "txtTuoi"
        Me.txtTuoi.ReadOnly = True
        Me.txtTuoi.Size = New System.Drawing.Size(30, 20)
        Me.txtTuoi.TabIndex = 128
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(426, 178)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(28, 13)
        Me.Label10.TabIndex = 127
        Me.Label10.Text = "Tuổi"
        '
        'dtpNgayNhapHoc
        '
        Me.dtpNgayNhapHoc.Location = New System.Drawing.Point(337, 209)
        Me.dtpNgayNhapHoc.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpNgayNhapHoc.Name = "dtpNgayNhapHoc"
        Me.dtpNgayNhapHoc.Size = New System.Drawing.Size(151, 20)
        Me.dtpNgayNhapHoc.TabIndex = 126
        Me.dtpNgayNhapHoc.Value = New Date(2018, 6, 23, 9, 41, 46, 0)
        '
        'txtGhiChu
        '
        Me.txtGhiChu.Location = New System.Drawing.Point(337, 243)
        Me.txtGhiChu.Margin = New System.Windows.Forms.Padding(2)
        Me.txtGhiChu.Name = "txtGhiChu"
        Me.txtGhiChu.Size = New System.Drawing.Size(151, 20)
        Me.txtGhiChu.TabIndex = 125
        '
        'txtHoTen
        '
        Me.txtHoTen.Location = New System.Drawing.Point(290, 173)
        Me.txtHoTen.Margin = New System.Windows.Forms.Padding(2)
        Me.txtHoTen.Name = "txtHoTen"
        Me.txtHoTen.ReadOnly = True
        Me.txtHoTen.Size = New System.Drawing.Size(132, 20)
        Me.txtHoTen.TabIndex = 124
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(231, 243)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 13)
        Me.Label11.TabIndex = 123
        Me.Label11.Text = "Ghi chú"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(231, 215)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 13)
        Me.Label12.TabIndex = 122
        Me.Label12.Text = "Ngày nhập học"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(231, 178)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(54, 13)
        Me.Label13.TabIndex = 121
        Me.Label13.Text = "Họ tên trẻ"
        '
        'txtMaLop
        '
        Me.txtMaLop.Location = New System.Drawing.Point(806, 144)
        Me.txtMaLop.Name = "txtMaLop"
        Me.txtMaLop.ReadOnly = True
        Me.txtMaLop.Size = New System.Drawing.Size(37, 20)
        Me.txtMaLop.TabIndex = 120
        '
        'txtMaKhoi
        '
        Me.txtMaKhoi.Location = New System.Drawing.Point(806, 106)
        Me.txtMaKhoi.Name = "txtMaKhoi"
        Me.txtMaKhoi.ReadOnly = True
        Me.txtMaKhoi.Size = New System.Drawing.Size(37, 20)
        Me.txtMaKhoi.TabIndex = 119
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(744, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 118
        Me.Label5.Text = "Mã khối"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(744, 147)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 117
        Me.Label8.Text = "Mã lớp"
        '
        'txtSoTreEmCuaLop
        '
        Me.txtSoTreEmCuaLop.Location = New System.Drawing.Point(613, 212)
        Me.txtSoTreEmCuaLop.Name = "txtSoTreEmCuaLop"
        Me.txtSoTreEmCuaLop.ReadOnly = True
        Me.txtSoTreEmCuaLop.Size = New System.Drawing.Size(28, 20)
        Me.txtSoTreEmCuaLop.TabIndex = 116
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(555, 215)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 115
        Me.Label7.Text = "Số trẻ em"
        '
        'cbLop
        '
        Me.cbLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbLop.FormattingEnabled = True
        Me.cbLop.Location = New System.Drawing.Point(616, 144)
        Me.cbLop.Name = "cbLop"
        Me.cbLop.Size = New System.Drawing.Size(106, 21)
        Me.cbLop.TabIndex = 114
        '
        'cbKhoi
        '
        Me.cbKhoi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbKhoi.FormattingEnabled = True
        Me.cbKhoi.Location = New System.Drawing.Point(616, 106)
        Me.cbKhoi.Name = "cbKhoi"
        Me.cbKhoi.Size = New System.Drawing.Size(106, 21)
        Me.cbKhoi.TabIndex = 113
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(598, 73)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(201, 18)
        Me.Label6.TabIndex = 112
        Me.Label6.Text = "---------- Thông tin lớp ----------"
        '
        'btnChuyenLop
        '
        Me.btnChuyenLop.Location = New System.Drawing.Point(751, 210)
        Me.btnChuyenLop.Name = "btnChuyenLop"
        Me.btnChuyenLop.Size = New System.Drawing.Size(92, 23)
        Me.btnChuyenLop.TabIndex = 111
        Me.btnChuyenLop.Text = "Chuyển lớp"
        Me.btnChuyenLop.UseVisualStyleBackColor = True
        '
        'btnThemVaoLop
        '
        Me.btnThemVaoLop.Location = New System.Drawing.Point(305, 277)
        Me.btnThemVaoLop.Name = "btnThemVaoLop"
        Me.btnThemVaoLop.Size = New System.Drawing.Size(119, 23)
        Me.btnThemVaoLop.TabIndex = 110
        Me.btnThemVaoLop.Text = "Thêm vào lớp  --->"
        Me.btnThemVaoLop.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(231, 303)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(264, 18)
        Me.Label4.TabIndex = 109
        Me.Label4.Text = "----- Danh sách trẻ em chưa có lớp -----"
        '
        'dgvTreEmChuaCoLop
        '
        Me.dgvTreEmChuaCoLop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTreEmChuaCoLop.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvTreEmChuaCoLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTreEmChuaCoLop.Location = New System.Drawing.Point(223, 359)
        Me.dgvTreEmChuaCoLop.Name = "dgvTreEmChuaCoLop"
        Me.dgvTreEmChuaCoLop.RowHeadersVisible = False
        Me.dgvTreEmChuaCoLop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTreEmChuaCoLop.Size = New System.Drawing.Size(285, 139)
        Me.dgvTreEmChuaCoLop.TabIndex = 108
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(586, 178)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(240, 18)
        Me.Label3.TabIndex = 107
        Me.Label3.Text = "----- Danh sách trẻ em theo lớp -----"
        '
        'dgvTreEmCoLop
        '
        Me.dgvTreEmCoLop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTreEmCoLop.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvTreEmCoLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTreEmCoLop.Location = New System.Drawing.Point(558, 243)
        Me.dgvTreEmCoLop.Name = "dgvTreEmCoLop"
        Me.dgvTreEmCoLop.RowHeadersVisible = False
        Me.dgvTreEmCoLop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTreEmCoLop.Size = New System.Drawing.Size(285, 255)
        Me.dgvTreEmCoLop.TabIndex = 106
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(555, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 105
        Me.Label2.Text = "Khối lớp"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(555, 147)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 104
        Me.Label1.Text = "Tên lớp"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(82, 259)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(135, 26)
        Me.Label18.TabIndex = 139
        Me.Label18.Text = "6. Nút Thêm trẻ em sẽ hiện" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "sau khi thực hiện bước 4"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(59, 393)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(123, 26)
        Me.Label19.TabIndex = 140
        Me.Label19.Text = "4. Chọn trẻ em cần thêm" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " vào lớp được chọn"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(864, 259)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(142, 26)
        Me.Label20.TabIndex = 141
        Me.Label20.Text = "7. Chọn trẻ em cần cập nhật" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "thông tin hoặc xoá"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(864, 147)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(91, 26)
        Me.Label21.TabIndex = 142
        Me.Label21.Text = "2. Chọn lớp trong " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "danh sách lớp"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(864, 101)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(94, 26)
        Me.Label22.TabIndex = 143
        Me.Label22.Text = "1. Chọn khối trong" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " danh sách khối"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(36, 295)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(171, 26)
        Me.Label23.TabIndex = 144
        Me.Label23.Text = "8. Nút Cập nhật và Xoá ra khỏi lớp" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "sẽ hiện sau khi thực hiện bước 7"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(108, 330)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(109, 26)
        Me.Label24.TabIndex = 145
        Me.Label24.Text = "3. Tra cứu trẻ em cần" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "thêm vào lớp"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(66, 231)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(157, 13)
        Me.Label25.TabIndex = 146
        Me.Label25.Text = "5.2 Điền hoặc cập nhật ghi chú"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(98, 202)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(125, 26)
        Me.Label26.TabIndex = 147
        Me.Label26.Text = "5.1 Chọn hoặc cập nhật " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ngày nhập học"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(864, 209)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(119, 26)
        Me.Label27.TabIndex = 148
        Me.Label27.Text = "10. Bấm nút chuyển lớp" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "để mở form chuyển lớp"
        '
        'frmHuongDanQuanLyLop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1055, 600)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtSearchName)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtMaLop1)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtMaSoTreEm)
        Me.Controls.Add(Me.btnXoaKhoiLop)
        Me.Controls.Add(Me.btnCapNhat)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtTuoi)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.dtpNgayNhapHoc)
        Me.Controls.Add(Me.txtGhiChu)
        Me.Controls.Add(Me.txtHoTen)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtMaLop)
        Me.Controls.Add(Me.txtMaKhoi)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtSoTreEmCuaLop)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cbLop)
        Me.Controls.Add(Me.cbKhoi)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnChuyenLop)
        Me.Controls.Add(Me.btnThemVaoLop)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dgvTreEmChuaCoLop)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgvTreEmCoLop)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmHuongDanQuanLyLop"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hướng dẫn quản lý lớp"
        CType(Me.dgvTreEmChuaCoLop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTreEmCoLop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSearchName As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txtMaLop1 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtMaSoTreEm As TextBox
    Friend WithEvents btnXoaKhoiLop As Button
    Friend WithEvents btnCapNhat As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents txtTuoi As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents dtpNgayNhapHoc As DateTimePicker
    Friend WithEvents txtGhiChu As TextBox
    Friend WithEvents txtHoTen As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtMaLop As TextBox
    Friend WithEvents txtMaKhoi As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtSoTreEmCuaLop As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cbLop As ComboBox
    Friend WithEvents cbKhoi As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnChuyenLop As Button
    Friend WithEvents btnThemVaoLop As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents dgvTreEmChuaCoLop As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents dgvTreEmCoLop As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
End Class
