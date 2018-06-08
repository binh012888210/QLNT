<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuanLyTreEm
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnTiepNhan = New System.Windows.Forms.Button()
        Me.btnCapNhat = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSearchName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnDong = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtMaSoTreEm = New System.Windows.Forms.TextBox()
        Me.txtHoTen = New System.Windows.Forms.TextBox()
        Me.txtNgaySinh = New System.Windows.Forms.TextBox()
        Me.txtHoTenPhuHuynh = New System.Windows.Forms.TextBox()
        Me.txtTenONha = New System.Windows.Forms.TextBox()
        Me.txtDiaChi = New System.Windows.Forms.TextBox()
        Me.txtDienThoai = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtMaLop = New System.Windows.Forms.TextBox()
        Me.btnSearchName = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(292, 101)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(355, 318)
        Me.DataGridView1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 321)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "---------- Chức năng ----------"
        '
        'btnTiepNhan
        '
        Me.btnTiepNhan.Location = New System.Drawing.Point(20, 353)
        Me.btnTiepNhan.Name = "btnTiepNhan"
        Me.btnTiepNhan.Size = New System.Drawing.Size(104, 23)
        Me.btnTiepNhan.TabIndex = 2
        Me.btnTiepNhan.Text = "Tiếp nhận trẻ em"
        Me.btnTiepNhan.UseVisualStyleBackColor = True
        '
        'btnCapNhat
        '
        Me.btnCapNhat.Location = New System.Drawing.Point(146, 353)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(124, 23)
        Me.btnCapNhat.TabIndex = 3
        Me.btnCapNhat.Text = "Cập nhật trẻ em"
        Me.btnCapNhat.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(20, 396)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(104, 23)
        Me.btnXoa.TabIndex = 4
        Me.btnXoa.Text = "Xoá trẻ em"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(373, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 18)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "----- Danh sách trẻ em -----"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(357, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(219, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "----- Tra cứu trẻ em theo tên -----"
        '
        'txtSearchName
        '
        Me.txtSearchName.Location = New System.Drawing.Point(292, 40)
        Me.txtSearchName.Name = "txtSearchName"
        Me.txtSearchName.Size = New System.Drawing.Size(294, 20)
        Me.txtSearchName.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(32, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(223, 18)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "---------- Thông tin trẻ em ----------"
        '
        'btnDong
        '
        Me.btnDong.Location = New System.Drawing.Point(146, 396)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(124, 23)
        Me.btnDong.TabIndex = 15
        Me.btnDong.Text = "Đóng"
        Me.btnDong.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 47)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Mã trẻ em"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 83)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Họ tên trẻ"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 115)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Ngày sinh"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 151)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Họ tên phụ huynh"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 186)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Tên ở nhà"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(18, 220)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Địa chỉ"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(18, 253)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 13)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Điện thoại"
        '
        'txtMaSoTreEm
        '
        Me.txtMaSoTreEm.Location = New System.Drawing.Point(119, 47)
        Me.txtMaSoTreEm.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMaSoTreEm.Name = "txtMaSoTreEm"
        Me.txtMaSoTreEm.ReadOnly = True
        Me.txtMaSoTreEm.Size = New System.Drawing.Size(151, 20)
        Me.txtMaSoTreEm.TabIndex = 24
        '
        'txtHoTen
        '
        Me.txtHoTen.Location = New System.Drawing.Point(119, 80)
        Me.txtHoTen.Margin = New System.Windows.Forms.Padding(2)
        Me.txtHoTen.Name = "txtHoTen"
        Me.txtHoTen.ReadOnly = True
        Me.txtHoTen.Size = New System.Drawing.Size(151, 20)
        Me.txtHoTen.TabIndex = 25
        '
        'txtNgaySinh
        '
        Me.txtNgaySinh.Location = New System.Drawing.Point(119, 115)
        Me.txtNgaySinh.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNgaySinh.Name = "txtNgaySinh"
        Me.txtNgaySinh.ReadOnly = True
        Me.txtNgaySinh.Size = New System.Drawing.Size(151, 20)
        Me.txtNgaySinh.TabIndex = 26
        '
        'txtHoTenPhuHuynh
        '
        Me.txtHoTenPhuHuynh.Location = New System.Drawing.Point(119, 148)
        Me.txtHoTenPhuHuynh.Margin = New System.Windows.Forms.Padding(2)
        Me.txtHoTenPhuHuynh.Name = "txtHoTenPhuHuynh"
        Me.txtHoTenPhuHuynh.ReadOnly = True
        Me.txtHoTenPhuHuynh.Size = New System.Drawing.Size(151, 20)
        Me.txtHoTenPhuHuynh.TabIndex = 27
        '
        'txtTenONha
        '
        Me.txtTenONha.Location = New System.Drawing.Point(119, 186)
        Me.txtTenONha.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTenONha.Name = "txtTenONha"
        Me.txtTenONha.ReadOnly = True
        Me.txtTenONha.Size = New System.Drawing.Size(151, 20)
        Me.txtTenONha.TabIndex = 28
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Location = New System.Drawing.Point(119, 220)
        Me.txtDiaChi.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.ReadOnly = True
        Me.txtDiaChi.Size = New System.Drawing.Size(151, 20)
        Me.txtDiaChi.TabIndex = 29
        '
        'txtDienThoai
        '
        Me.txtDienThoai.Location = New System.Drawing.Point(119, 253)
        Me.txtDienThoai.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDienThoai.Name = "txtDienThoai"
        Me.txtDienThoai.ReadOnly = True
        Me.txtDienThoai.Size = New System.Drawing.Size(151, 20)
        Me.txtDienThoai.TabIndex = 30
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(18, 292)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(43, 13)
        Me.Label12.TabIndex = 31
        Me.Label12.Text = "Mã Lớp"
        '
        'txtMaLop
        '
        Me.txtMaLop.Location = New System.Drawing.Point(119, 289)
        Me.txtMaLop.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMaLop.Name = "txtMaLop"
        Me.txtMaLop.ReadOnly = True
        Me.txtMaLop.Size = New System.Drawing.Size(151, 20)
        Me.txtMaLop.TabIndex = 32
        '
        'btnSearchName
        '
        Me.btnSearchName.Location = New System.Drawing.Point(592, 38)
        Me.btnSearchName.Name = "btnSearchName"
        Me.btnSearchName.Size = New System.Drawing.Size(55, 23)
        Me.btnSearchName.TabIndex = 33
        Me.btnSearchName.Text = "Tìm"
        Me.btnSearchName.UseVisualStyleBackColor = True
        '
        'frmQuanLyTreEm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(669, 439)
        Me.Controls.Add(Me.btnSearchName)
        Me.Controls.Add(Me.txtMaLop)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtDienThoai)
        Me.Controls.Add(Me.txtDiaChi)
        Me.Controls.Add(Me.txtTenONha)
        Me.Controls.Add(Me.txtHoTenPhuHuynh)
        Me.Controls.Add(Me.txtNgaySinh)
        Me.Controls.Add(Me.txtHoTen)
        Me.Controls.Add(Me.txtMaSoTreEm)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnDong)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtSearchName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnCapNhat)
        Me.Controls.Add(Me.btnTiepNhan)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmQuanLyTreEm"
        Me.Text = "frmQuanLyTreEm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents btnTiepNhan As Button
    Friend WithEvents btnCapNhat As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSearchName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnDong As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtMaSoTreEm As TextBox
    Friend WithEvents txtHoTen As TextBox
    Friend WithEvents txtNgaySinh As TextBox
    Friend WithEvents txtHoTenPhuHuynh As TextBox
    Friend WithEvents txtTenONha As TextBox
    Friend WithEvents txtDiaChi As TextBox
    Friend WithEvents txtDienThoai As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtMaLop As TextBox
    Friend WithEvents btnSearchName As Button
End Class
