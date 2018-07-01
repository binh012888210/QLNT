<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHuongDanTraCuuTreEm
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
        Me.btnDong = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbKhoi = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.chkbxTraCuuNangCao = New System.Windows.Forms.CheckBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtHoTen = New System.Windows.Forms.TextBox()
        Me.txtDienThoai = New System.Windows.Forms.TextBox()
        Me.txtDiaChi = New System.Windows.Forms.TextBox()
        Me.txtTenONha = New System.Windows.Forms.TextBox()
        Me.txtHoTenPhuHuynh = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnTraCuuMoi = New System.Windows.Forms.Button()
        Me.btnTraCuu = New System.Windows.Forms.Button()
        Me.txtTuoi = New System.Windows.Forms.TextBox()
        Me.txtGhiChu = New System.Windows.Forms.TextBox()
        Me.txtMaTreEm = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvDanhSachTreEm = New System.Windows.Forms.DataGridView()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        CType(Me.dgvDanhSachTreEm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDong
        '
        Me.btnDong.Location = New System.Drawing.Point(954, 60)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(75, 23)
        Me.btnDong.TabIndex = 129
        Me.btnDong.Text = "Đóng"
        Me.btnDong.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(460, 45)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(252, 25)
        Me.Label11.TabIndex = 128
        Me.Label11.Text = "----- Tra Cứu Trẻ Em  -----"
        '
        'cbKhoi
        '
        Me.cbKhoi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbKhoi.Enabled = False
        Me.cbKhoi.FormattingEnabled = True
        Me.cbKhoi.Location = New System.Drawing.Point(192, 357)
        Me.cbKhoi.Name = "cbKhoi"
        Me.cbKhoi.Size = New System.Drawing.Size(143, 21)
        Me.cbKhoi.TabIndex = 127
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(133, 360)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(49, 13)
        Me.Label13.TabIndex = 126
        Me.Label13.Text = "Tên khối"
        '
        'chkbxTraCuuNangCao
        '
        Me.chkbxTraCuuNangCao.AutoSize = True
        Me.chkbxTraCuuNangCao.Location = New System.Drawing.Point(115, 322)
        Me.chkbxTraCuuNangCao.Name = "chkbxTraCuuNangCao"
        Me.chkbxTraCuuNangCao.Size = New System.Drawing.Size(143, 17)
        Me.chkbxTraCuuNangCao.TabIndex = 125
        Me.chkbxTraCuuNangCao.Text = "Tra cứu trẻ em nâng cao"
        Me.chkbxTraCuuNangCao.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(112, 128)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(88, 13)
        Me.Label12.TabIndex = 124
        Me.Label12.Text = "Thông tin cơ bản"
        '
        'txtHoTen
        '
        Me.txtHoTen.Location = New System.Drawing.Point(422, 165)
        Me.txtHoTen.Margin = New System.Windows.Forms.Padding(2)
        Me.txtHoTen.Name = "txtHoTen"
        Me.txtHoTen.Size = New System.Drawing.Size(143, 20)
        Me.txtHoTen.TabIndex = 123
        '
        'txtDienThoai
        '
        Me.txtDienThoai.Location = New System.Drawing.Point(195, 279)
        Me.txtDienThoai.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDienThoai.Name = "txtDienThoai"
        Me.txtDienThoai.Size = New System.Drawing.Size(141, 20)
        Me.txtDienThoai.TabIndex = 122
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Location = New System.Drawing.Point(422, 241)
        Me.txtDiaChi.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(143, 20)
        Me.txtDiaChi.TabIndex = 121
        '
        'txtTenONha
        '
        Me.txtTenONha.Location = New System.Drawing.Point(193, 238)
        Me.txtTenONha.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTenONha.Name = "txtTenONha"
        Me.txtTenONha.Size = New System.Drawing.Size(143, 20)
        Me.txtTenONha.TabIndex = 120
        '
        'txtHoTenPhuHuynh
        '
        Me.txtHoTenPhuHuynh.Location = New System.Drawing.Point(227, 202)
        Me.txtHoTenPhuHuynh.Margin = New System.Windows.Forms.Padding(2)
        Me.txtHoTenPhuHuynh.Name = "txtHoTenPhuHuynh"
        Me.txtHoTenPhuHuynh.Size = New System.Drawing.Size(143, 20)
        Me.txtHoTenPhuHuynh.TabIndex = 119
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(133, 168)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 118
        Me.Label3.Text = "Mã trẻ em"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(133, 282)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 117
        Me.Label5.Text = "Điện thoại"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(362, 241)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 116
        Me.Label7.Text = "Địa chỉ"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(133, 241)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 13)
        Me.Label9.TabIndex = 115
        Me.Label9.Text = "Tên ở nhà"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(133, 205)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 13)
        Me.Label8.TabIndex = 114
        Me.Label8.Text = "Tên phụ huynh"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(717, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(183, 18)
        Me.Label4.TabIndex = 113
        Me.Label4.Text = "----- Danh sách trẻ em -----"
        '
        'btnTraCuuMoi
        '
        Me.btnTraCuuMoi.Location = New System.Drawing.Point(481, 98)
        Me.btnTraCuuMoi.Name = "btnTraCuuMoi"
        Me.btnTraCuuMoi.Size = New System.Drawing.Size(84, 39)
        Me.btnTraCuuMoi.TabIndex = 112
        Me.btnTraCuuMoi.Text = "Tra cứu mới"
        Me.btnTraCuuMoi.UseVisualStyleBackColor = True
        '
        'btnTraCuu
        '
        Me.btnTraCuu.Location = New System.Drawing.Point(436, 345)
        Me.btnTraCuu.Name = "btnTraCuu"
        Me.btnTraCuu.Size = New System.Drawing.Size(95, 64)
        Me.btnTraCuu.TabIndex = 111
        Me.btnTraCuu.Text = "Tra cứu"
        Me.btnTraCuu.UseVisualStyleBackColor = True
        '
        'txtTuoi
        '
        Me.txtTuoi.Location = New System.Drawing.Point(447, 202)
        Me.txtTuoi.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTuoi.Name = "txtTuoi"
        Me.txtTuoi.Size = New System.Drawing.Size(118, 20)
        Me.txtTuoi.TabIndex = 110
        '
        'txtGhiChu
        '
        Me.txtGhiChu.Location = New System.Drawing.Point(422, 279)
        Me.txtGhiChu.Margin = New System.Windows.Forms.Padding(2)
        Me.txtGhiChu.Name = "txtGhiChu"
        Me.txtGhiChu.Size = New System.Drawing.Size(143, 20)
        Me.txtGhiChu.TabIndex = 109
        '
        'txtMaTreEm
        '
        Me.txtMaTreEm.Location = New System.Drawing.Point(193, 165)
        Me.txtMaTreEm.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMaTreEm.Name = "txtMaTreEm"
        Me.txtMaTreEm.Size = New System.Drawing.Size(143, 20)
        Me.txtMaTreEm.TabIndex = 108
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(387, 205)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 107
        Me.Label2.Text = "Tuổi"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(362, 282)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 13)
        Me.Label10.TabIndex = 106
        Me.Label10.Text = "Ghi chú"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(351, 168)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 105
        Me.Label6.Text = "Họ tên trẻ"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(210, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(226, 18)
        Me.Label1.TabIndex = 104
        Me.Label1.Text = "---------- Thông tin tra cứu ----------"
        '
        'dgvDanhSachTreEm
        '
        Me.dgvDanhSachTreEm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDanhSachTreEm.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvDanhSachTreEm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDanhSachTreEm.Location = New System.Drawing.Point(595, 119)
        Me.dgvDanhSachTreEm.Name = "dgvDanhSachTreEm"
        Me.dgvDanhSachTreEm.RowHeadersVisible = False
        Me.dgvDanhSachTreEm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDanhSachTreEm.Size = New System.Drawing.Size(421, 303)
        Me.dgvDanhSachTreEm.TabIndex = 103
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(112, 396)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(142, 13)
        Me.Label14.TabIndex = 130
        Me.Label14.Text = "3. Chọn tên khối cần tra cứu" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(372, 329)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(193, 13)
        Me.Label15.TabIndex = 131
        Me.Label15.Text = "4. Thực hiện tra cứu trong cơ sở dữ liệu"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(19, 305)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(379, 13)
        Me.Label16.TabIndex = 132
        Me.Label16.Text = "2. Check vào để ưu tiên tra cứu theo thông tin nâng cao - có thể không check"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(24, 90)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(163, 26)
        Me.Label17.TabIndex = 133
        Me.Label17.Text = "1. Điền vào thông tin cần tra cứu" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ít nhất là một thông tin"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(444, 82)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(176, 13)
        Me.Label19.TabIndex = 135
        Me.Label19.Text = "5. Xoá tất cả nội dung đang tra cứu"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(951, 44)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(68, 13)
        Me.Label20.TabIndex = 136
        Me.Label20.Text = "6. Đóng form"
        '
        'frmHuongDanTraCuuTreEm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1174, 513)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.btnDong)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cbKhoi)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.chkbxTraCuuNangCao)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtHoTen)
        Me.Controls.Add(Me.txtDienThoai)
        Me.Controls.Add(Me.txtDiaChi)
        Me.Controls.Add(Me.txtTenONha)
        Me.Controls.Add(Me.txtHoTenPhuHuynh)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnTraCuuMoi)
        Me.Controls.Add(Me.btnTraCuu)
        Me.Controls.Add(Me.txtTuoi)
        Me.Controls.Add(Me.txtGhiChu)
        Me.Controls.Add(Me.txtMaTreEm)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvDanhSachTreEm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmHuongDanTraCuuTreEm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hướng dẫn tra cứu trẻ em"
        CType(Me.dgvDanhSachTreEm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDong As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents cbKhoi As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents chkbxTraCuuNangCao As CheckBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtHoTen As TextBox
    Friend WithEvents txtDienThoai As TextBox
    Friend WithEvents txtDiaChi As TextBox
    Friend WithEvents txtTenONha As TextBox
    Friend WithEvents txtHoTenPhuHuynh As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnTraCuuMoi As Button
    Friend WithEvents btnTraCuu As Button
    Friend WithEvents txtTuoi As TextBox
    Friend WithEvents txtGhiChu As TextBox
    Friend WithEvents txtMaTreEm As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvDanhSachTreEm As DataGridView
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
End Class
