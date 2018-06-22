<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmQuanLyLop
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvTreEmCoLop = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvTreEmChuaCoLop = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnThemVaoLop = New System.Windows.Forms.Button()
        Me.btnChuyenLop = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbKhoi = New System.Windows.Forms.ComboBox()
        Me.cbLop = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSoTreEmCuaLop = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtMaKhoi = New System.Windows.Forms.TextBox()
        Me.txtMaLop = New System.Windows.Forms.TextBox()
        Me.txtTuoi = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtpNgayNhapHoc = New System.Windows.Forms.DateTimePicker()
        Me.txtGhiChu = New System.Windows.Forms.TextBox()
        Me.txtHoTen = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnCapNhat = New System.Windows.Forms.Button()
        Me.btnXoaKhoiLop = New System.Windows.Forms.Button()
        Me.txtMaLop1 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtMaSoTreEm = New System.Windows.Forms.TextBox()
        CType(Me.dgvTreEmCoLop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTreEmChuaCoLop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(335, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tên lớp"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(335, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Khối lớp"
        '
        'dgvTreEmCoLop
        '
        Me.dgvTreEmCoLop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTreEmCoLop.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvTreEmCoLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTreEmCoLop.Location = New System.Drawing.Point(338, 184)
        Me.dgvTreEmCoLop.Name = "dgvTreEmCoLop"
        Me.dgvTreEmCoLop.RowHeadersVisible = False
        Me.dgvTreEmCoLop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTreEmCoLop.Size = New System.Drawing.Size(285, 231)
        Me.dgvTreEmCoLop.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(366, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(240, 18)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "----- Danh sách trẻ em theo lớp -----"
        '
        'dgvTreEmChuaCoLop
        '
        Me.dgvTreEmChuaCoLop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTreEmChuaCoLop.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvTreEmChuaCoLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTreEmChuaCoLop.Location = New System.Drawing.Point(22, 276)
        Me.dgvTreEmChuaCoLop.Name = "dgvTreEmChuaCoLop"
        Me.dgvTreEmChuaCoLop.RowHeadersVisible = False
        Me.dgvTreEmChuaCoLop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTreEmChuaCoLop.Size = New System.Drawing.Size(285, 139)
        Me.dgvTreEmChuaCoLop.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(33, 244)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(264, 18)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "----- Danh sách trẻ em chưa có lớp -----"
        '
        'btnThemVaoLop
        '
        Me.btnThemVaoLop.Location = New System.Drawing.Point(107, 218)
        Me.btnThemVaoLop.Name = "btnThemVaoLop"
        Me.btnThemVaoLop.Size = New System.Drawing.Size(119, 23)
        Me.btnThemVaoLop.TabIndex = 12
        Me.btnThemVaoLop.Text = "Thêm vào lớp  --->"
        Me.btnThemVaoLop.UseVisualStyleBackColor = True
        Me.btnThemVaoLop.Visible = False
        '
        'btnChuyenLop
        '
        Me.btnChuyenLop.Location = New System.Drawing.Point(531, 151)
        Me.btnChuyenLop.Name = "btnChuyenLop"
        Me.btnChuyenLop.Size = New System.Drawing.Size(92, 23)
        Me.btnChuyenLop.TabIndex = 13
        Me.btnChuyenLop.Text = "Chuyển lớp"
        Me.btnChuyenLop.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(378, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(201, 18)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "---------- Thông tin lớp ----------"
        '
        'cbKhoi
        '
        Me.cbKhoi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbKhoi.FormattingEnabled = True
        Me.cbKhoi.Location = New System.Drawing.Point(396, 47)
        Me.cbKhoi.Name = "cbKhoi"
        Me.cbKhoi.Size = New System.Drawing.Size(106, 21)
        Me.cbKhoi.TabIndex = 17
        '
        'cbLop
        '
        Me.cbLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbLop.FormattingEnabled = True
        Me.cbLop.Location = New System.Drawing.Point(396, 85)
        Me.cbLop.Name = "cbLop"
        Me.cbLop.Size = New System.Drawing.Size(106, 21)
        Me.cbLop.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(335, 156)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Số trẻ em"
        '
        'txtSoTreEmCuaLop
        '
        Me.txtSoTreEmCuaLop.Location = New System.Drawing.Point(393, 153)
        Me.txtSoTreEmCuaLop.Name = "txtSoTreEmCuaLop"
        Me.txtSoTreEmCuaLop.ReadOnly = True
        Me.txtSoTreEmCuaLop.Size = New System.Drawing.Size(28, 20)
        Me.txtSoTreEmCuaLop.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(524, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Mã khối"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(524, 88)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Mã lớp"
        '
        'txtMaKhoi
        '
        Me.txtMaKhoi.Location = New System.Drawing.Point(586, 47)
        Me.txtMaKhoi.Name = "txtMaKhoi"
        Me.txtMaKhoi.ReadOnly = True
        Me.txtMaKhoi.Size = New System.Drawing.Size(37, 20)
        Me.txtMaKhoi.TabIndex = 32
        '
        'txtMaLop
        '
        Me.txtMaLop.Location = New System.Drawing.Point(586, 85)
        Me.txtMaLop.Name = "txtMaLop"
        Me.txtMaLop.ReadOnly = True
        Me.txtMaLop.Size = New System.Drawing.Size(37, 20)
        Me.txtMaLop.TabIndex = 33
        '
        'txtTuoi
        '
        Me.txtTuoi.Location = New System.Drawing.Point(260, 116)
        Me.txtTuoi.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTuoi.Name = "txtTuoi"
        Me.txtTuoi.ReadOnly = True
        Me.txtTuoi.Size = New System.Drawing.Size(30, 20)
        Me.txtTuoi.TabIndex = 43
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(228, 119)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(28, 13)
        Me.Label10.TabIndex = 42
        Me.Label10.Text = "Tuổi"
        '
        'dtpNgayNhapHoc
        '
        Me.dtpNgayNhapHoc.Location = New System.Drawing.Point(139, 150)
        Me.dtpNgayNhapHoc.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpNgayNhapHoc.Name = "dtpNgayNhapHoc"
        Me.dtpNgayNhapHoc.Size = New System.Drawing.Size(151, 20)
        Me.dtpNgayNhapHoc.TabIndex = 41
        '
        'txtGhiChu
        '
        Me.txtGhiChu.Location = New System.Drawing.Point(139, 184)
        Me.txtGhiChu.Margin = New System.Windows.Forms.Padding(2)
        Me.txtGhiChu.Name = "txtGhiChu"
        Me.txtGhiChu.Size = New System.Drawing.Size(151, 20)
        Me.txtGhiChu.TabIndex = 40
        '
        'txtHoTen
        '
        Me.txtHoTen.Location = New System.Drawing.Point(92, 114)
        Me.txtHoTen.Margin = New System.Windows.Forms.Padding(2)
        Me.txtHoTen.Name = "txtHoTen"
        Me.txtHoTen.ReadOnly = True
        Me.txtHoTen.Size = New System.Drawing.Size(132, 20)
        Me.txtHoTen.TabIndex = 39
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(33, 184)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 13)
        Me.Label11.TabIndex = 37
        Me.Label11.Text = "Ghi chú"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(33, 156)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 13)
        Me.Label12.TabIndex = 36
        Me.Label12.Text = "Ngày nhập học"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(33, 119)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(54, 13)
        Me.Label13.TabIndex = 35
        Me.Label13.Text = "Họ tên trẻ"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(45, 14)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(223, 18)
        Me.Label9.TabIndex = 44
        Me.Label9.Text = "---------- Thông tin trẻ em ----------"
        '
        'btnCapNhat
        '
        Me.btnCapNhat.Location = New System.Drawing.Point(64, 218)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(75, 23)
        Me.btnCapNhat.TabIndex = 45
        Me.btnCapNhat.Text = "Cập nhật  thông tin"
        Me.btnCapNhat.UseVisualStyleBackColor = True
        Me.btnCapNhat.Visible = False
        '
        'btnXoaKhoiLop
        '
        Me.btnXoaKhoiLop.Location = New System.Drawing.Point(195, 218)
        Me.btnXoaKhoiLop.Name = "btnXoaKhoiLop"
        Me.btnXoaKhoiLop.Size = New System.Drawing.Size(75, 23)
        Me.btnXoaKhoiLop.TabIndex = 46
        Me.btnXoaKhoiLop.Text = "Xoá khỏi lớp"
        Me.btnXoaKhoiLop.UseVisualStyleBackColor = True
        Me.btnXoaKhoiLop.Visible = False
        '
        'txtMaLop1
        '
        Me.txtMaLop1.Location = New System.Drawing.Point(139, 44)
        Me.txtMaLop1.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMaLop1.Name = "txtMaLop1"
        Me.txtMaLop1.ReadOnly = True
        Me.txtMaLop1.Size = New System.Drawing.Size(151, 20)
        Me.txtMaLop1.TabIndex = 50
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(33, 47)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(43, 13)
        Me.Label14.TabIndex = 49
        Me.Label14.Text = "Mã Lớp"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(33, 82)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(54, 13)
        Me.Label15.TabIndex = 47
        Me.Label15.Text = "Mã trẻ em"
        '
        'txtMaSoTreEm
        '
        Me.txtMaSoTreEm.Location = New System.Drawing.Point(139, 79)
        Me.txtMaSoTreEm.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMaSoTreEm.Name = "txtMaSoTreEm"
        Me.txtMaSoTreEm.ReadOnly = True
        Me.txtMaSoTreEm.Size = New System.Drawing.Size(151, 20)
        Me.txtMaSoTreEm.TabIndex = 48
        '
        'frmQuanLyLop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(655, 447)
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
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmQuanLyLop"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quản lý lớp"
        CType(Me.dgvTreEmCoLop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTreEmChuaCoLop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvTreEmCoLop As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents dgvTreEmChuaCoLop As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents btnThemVaoLop As Button
    Friend WithEvents btnChuyenLop As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents cbKhoi As ComboBox
    Friend WithEvents cbLop As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtSoTreEmCuaLop As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtMaKhoi As TextBox
    Friend WithEvents txtMaLop As TextBox
    Friend WithEvents txtTuoi As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents dtpNgayNhapHoc As DateTimePicker
    Friend WithEvents txtGhiChu As TextBox
    Friend WithEvents txtHoTen As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnCapNhat As Button
    Friend WithEvents btnXoaKhoiLop As Button
    Friend WithEvents txtMaLop1 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtMaSoTreEm As TextBox
End Class
