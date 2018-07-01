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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbKhoi = New System.Windows.Forms.ComboBox()
        Me.cbLop = New System.Windows.Forms.ComboBox()
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
        Me.txtMaLop1 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtMaSoTreEm = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnChuyenLop = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSoTreEmCuaLop = New System.Windows.Forms.TextBox()
        Me.btnThemVaoLop = New System.Windows.Forms.Button()
        Me.btnCapNhat = New System.Windows.Forms.Button()
        Me.btnXoaKhoiLop = New System.Windows.Forms.Button()
        Me.txtSearchName = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        CType(Me.dgvTreEmCoLop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTreEmChuaCoLop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(366, 129)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tên lớp"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(366, 93)
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
        Me.dgvTreEmCoLop.Location = New System.Drawing.Point(369, 225)
        Me.dgvTreEmCoLop.Name = "dgvTreEmCoLop"
        Me.dgvTreEmCoLop.RowHeadersVisible = False
        Me.dgvTreEmCoLop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTreEmCoLop.Size = New System.Drawing.Size(285, 255)
        Me.dgvTreEmCoLop.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(397, 160)
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
        Me.dgvTreEmChuaCoLop.Location = New System.Drawing.Point(34, 341)
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
        Me.Label4.Location = New System.Drawing.Point(42, 285)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(264, 18)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "----- Danh sách trẻ em chưa có lớp -----"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(409, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(201, 18)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "---------- Thông tin lớp ----------"
        '
        'cbKhoi
        '
        Me.cbKhoi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbKhoi.FormattingEnabled = True
        Me.cbKhoi.Location = New System.Drawing.Point(427, 88)
        Me.cbKhoi.Name = "cbKhoi"
        Me.cbKhoi.Size = New System.Drawing.Size(106, 21)
        Me.cbKhoi.TabIndex = 17
        '
        'cbLop
        '
        Me.cbLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbLop.FormattingEnabled = True
        Me.cbLop.Location = New System.Drawing.Point(427, 126)
        Me.cbLop.Name = "cbLop"
        Me.cbLop.Size = New System.Drawing.Size(106, 21)
        Me.cbLop.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(555, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Mã khối"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(555, 129)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Mã lớp"
        '
        'txtMaKhoi
        '
        Me.txtMaKhoi.Location = New System.Drawing.Point(617, 88)
        Me.txtMaKhoi.Name = "txtMaKhoi"
        Me.txtMaKhoi.ReadOnly = True
        Me.txtMaKhoi.Size = New System.Drawing.Size(37, 20)
        Me.txtMaKhoi.TabIndex = 32
        '
        'txtMaLop
        '
        Me.txtMaLop.Location = New System.Drawing.Point(617, 126)
        Me.txtMaLop.Name = "txtMaLop"
        Me.txtMaLop.ReadOnly = True
        Me.txtMaLop.Size = New System.Drawing.Size(37, 20)
        Me.txtMaLop.TabIndex = 33
        '
        'txtTuoi
        '
        Me.txtTuoi.Location = New System.Drawing.Point(269, 157)
        Me.txtTuoi.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTuoi.Name = "txtTuoi"
        Me.txtTuoi.ReadOnly = True
        Me.txtTuoi.Size = New System.Drawing.Size(30, 20)
        Me.txtTuoi.TabIndex = 43
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(237, 160)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(28, 13)
        Me.Label10.TabIndex = 42
        Me.Label10.Text = "Tuổi"
        '
        'dtpNgayNhapHoc
        '
        Me.dtpNgayNhapHoc.Location = New System.Drawing.Point(148, 191)
        Me.dtpNgayNhapHoc.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpNgayNhapHoc.Name = "dtpNgayNhapHoc"
        Me.dtpNgayNhapHoc.Size = New System.Drawing.Size(151, 20)
        Me.dtpNgayNhapHoc.TabIndex = 41
        Me.dtpNgayNhapHoc.Value = New Date(2018, 6, 23, 9, 41, 46, 0)
        '
        'txtGhiChu
        '
        Me.txtGhiChu.Location = New System.Drawing.Point(148, 225)
        Me.txtGhiChu.Margin = New System.Windows.Forms.Padding(2)
        Me.txtGhiChu.Name = "txtGhiChu"
        Me.txtGhiChu.Size = New System.Drawing.Size(151, 20)
        Me.txtGhiChu.TabIndex = 40
        '
        'txtHoTen
        '
        Me.txtHoTen.Location = New System.Drawing.Point(101, 155)
        Me.txtHoTen.Margin = New System.Windows.Forms.Padding(2)
        Me.txtHoTen.Name = "txtHoTen"
        Me.txtHoTen.ReadOnly = True
        Me.txtHoTen.Size = New System.Drawing.Size(132, 20)
        Me.txtHoTen.TabIndex = 39
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(42, 225)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 13)
        Me.Label11.TabIndex = 37
        Me.Label11.Text = "Ghi chú"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(42, 197)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 13)
        Me.Label12.TabIndex = 36
        Me.Label12.Text = "Ngày nhập học"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(42, 160)
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
        Me.Label9.Location = New System.Drawing.Point(56, 55)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(223, 18)
        Me.Label9.TabIndex = 44
        Me.Label9.Text = "---------- Thông tin trẻ em ----------"
        '
        'txtMaLop1
        '
        Me.txtMaLop1.Location = New System.Drawing.Point(148, 85)
        Me.txtMaLop1.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMaLop1.Name = "txtMaLop1"
        Me.txtMaLop1.ReadOnly = True
        Me.txtMaLop1.Size = New System.Drawing.Size(151, 20)
        Me.txtMaLop1.TabIndex = 50
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(42, 88)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(43, 13)
        Me.Label14.TabIndex = 49
        Me.Label14.Text = "Mã Lớp"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(42, 123)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(54, 13)
        Me.Label15.TabIndex = 47
        Me.Label15.Text = "Mã trẻ em"
        '
        'txtMaSoTreEm
        '
        Me.txtMaSoTreEm.Location = New System.Drawing.Point(148, 120)
        Me.txtMaSoTreEm.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMaSoTreEm.Name = "txtMaSoTreEm"
        Me.txtMaSoTreEm.ReadOnly = True
        Me.txtMaSoTreEm.Size = New System.Drawing.Size(151, 20)
        Me.txtMaSoTreEm.TabIndex = 48
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(236, 25)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(223, 25)
        Me.Label16.TabIndex = 101
        Me.Label16.Text = "----- Quản Lý Lớp  -----"
        '
        'btnChuyenLop
        '
        Me.btnChuyenLop.Location = New System.Drawing.Point(562, 192)
        Me.btnChuyenLop.Name = "btnChuyenLop"
        Me.btnChuyenLop.Size = New System.Drawing.Size(92, 23)
        Me.btnChuyenLop.TabIndex = 13
        Me.btnChuyenLop.Text = "Chuyển lớp"
        Me.btnChuyenLop.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(366, 197)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Số trẻ em"
        '
        'txtSoTreEmCuaLop
        '
        Me.txtSoTreEmCuaLop.Location = New System.Drawing.Point(424, 194)
        Me.txtSoTreEmCuaLop.Name = "txtSoTreEmCuaLop"
        Me.txtSoTreEmCuaLop.ReadOnly = True
        Me.txtSoTreEmCuaLop.Size = New System.Drawing.Size(28, 20)
        Me.txtSoTreEmCuaLop.TabIndex = 20
        '
        'btnThemVaoLop
        '
        Me.btnThemVaoLop.Location = New System.Drawing.Point(116, 259)
        Me.btnThemVaoLop.Name = "btnThemVaoLop"
        Me.btnThemVaoLop.Size = New System.Drawing.Size(119, 23)
        Me.btnThemVaoLop.TabIndex = 12
        Me.btnThemVaoLop.Text = "Thêm vào lớp  --->"
        Me.btnThemVaoLop.UseVisualStyleBackColor = True
        Me.btnThemVaoLop.Visible = False
        '
        'btnCapNhat
        '
        Me.btnCapNhat.Location = New System.Drawing.Point(73, 259)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(75, 23)
        Me.btnCapNhat.TabIndex = 45
        Me.btnCapNhat.Text = "Cập nhật  thông tin"
        Me.btnCapNhat.UseVisualStyleBackColor = True
        Me.btnCapNhat.Visible = False
        '
        'btnXoaKhoiLop
        '
        Me.btnXoaKhoiLop.Location = New System.Drawing.Point(204, 259)
        Me.btnXoaKhoiLop.Name = "btnXoaKhoiLop"
        Me.btnXoaKhoiLop.Size = New System.Drawing.Size(75, 23)
        Me.btnXoaKhoiLop.TabIndex = 46
        Me.btnXoaKhoiLop.Text = "Xoá khỏi lớp"
        Me.btnXoaKhoiLop.UseVisualStyleBackColor = True
        Me.btnXoaKhoiLop.Visible = False
        '
        'txtSearchName
        '
        Me.txtSearchName.Location = New System.Drawing.Point(204, 309)
        Me.txtSearchName.Name = "txtSearchName"
        Me.txtSearchName.Size = New System.Drawing.Size(115, 20)
        Me.txtSearchName.TabIndex = 102
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(31, 312)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(162, 13)
        Me.Label17.TabIndex = 103
        Me.Label17.Text = "Tra cứu trẻ em theo tên hoặc mã"
        '
        'frmQuanLyLop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(705, 516)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
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
    Friend WithEvents Label6 As Label
    Friend WithEvents cbKhoi As ComboBox
    Friend WithEvents cbLop As ComboBox
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
    Friend WithEvents txtMaLop1 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtMaSoTreEm As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents btnChuyenLop As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtSoTreEmCuaLop As TextBox
    Friend WithEvents btnThemVaoLop As Button
    Friend WithEvents btnCapNhat As Button
    Friend WithEvents btnXoaKhoiLop As Button
    Friend WithEvents txtSearchName As TextBox
    Friend WithEvents Label17 As Label
End Class
