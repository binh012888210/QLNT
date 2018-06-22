<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTraCuuTreEm
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTuoi = New System.Windows.Forms.TextBox()
        Me.txtGhiChu = New System.Windows.Forms.TextBox()
        Me.txtMaTreEm = New System.Windows.Forms.TextBox()
        Me.btnTraCuu = New System.Windows.Forms.Button()
        Me.btnTraCuuMoi = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
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
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cbKhoi = New System.Windows.Forms.ComboBox()
        CType(Me.dgvDanhSachTreEm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvDanhSachTreEm
        '
        Me.dgvDanhSachTreEm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDanhSachTreEm.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvDanhSachTreEm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDanhSachTreEm.Location = New System.Drawing.Point(500, 30)
        Me.dgvDanhSachTreEm.Name = "dgvDanhSachTreEm"
        Me.dgvDanhSachTreEm.RowHeadersVisible = False
        Me.dgvDanhSachTreEm.Size = New System.Drawing.Size(421, 303)
        Me.dgvDanhSachTreEm.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(178, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(207, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "--------- Tra cứu trẻ em ----------"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(256, 79)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Họ tên trẻ"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(267, 193)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 13)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Ghi chú"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(292, 116)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Tuổi"
        '
        'txtTuoi
        '
        Me.txtTuoi.Location = New System.Drawing.Point(352, 113)
        Me.txtTuoi.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTuoi.Name = "txtTuoi"
        Me.txtTuoi.Size = New System.Drawing.Size(118, 20)
        Me.txtTuoi.TabIndex = 41
        '
        'txtGhiChu
        '
        Me.txtGhiChu.Location = New System.Drawing.Point(327, 190)
        Me.txtGhiChu.Margin = New System.Windows.Forms.Padding(2)
        Me.txtGhiChu.Name = "txtGhiChu"
        Me.txtGhiChu.Size = New System.Drawing.Size(143, 20)
        Me.txtGhiChu.TabIndex = 39
        '
        'txtMaTreEm
        '
        Me.txtMaTreEm.Location = New System.Drawing.Point(98, 76)
        Me.txtMaTreEm.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMaTreEm.Name = "txtMaTreEm"
        Me.txtMaTreEm.Size = New System.Drawing.Size(143, 20)
        Me.txtMaTreEm.TabIndex = 35
        '
        'btnTraCuu
        '
        Me.btnTraCuu.Location = New System.Drawing.Point(375, 294)
        Me.btnTraCuu.Name = "btnTraCuu"
        Me.btnTraCuu.Size = New System.Drawing.Size(95, 39)
        Me.btnTraCuu.TabIndex = 42
        Me.btnTraCuu.Text = "Tra cứu"
        Me.btnTraCuu.UseVisualStyleBackColor = True
        '
        'btnTraCuuMoi
        '
        Me.btnTraCuuMoi.Location = New System.Drawing.Point(270, 294)
        Me.btnTraCuuMoi.Name = "btnTraCuuMoi"
        Me.btnTraCuuMoi.Size = New System.Drawing.Size(84, 39)
        Me.btnTraCuuMoi.TabIndex = 43
        Me.btnTraCuuMoi.Text = "Tra cứu mới"
        Me.btnTraCuuMoi.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(605, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(183, 18)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "----- Danh sách trẻ em -----"
        '
        'txtHoTen
        '
        Me.txtHoTen.Location = New System.Drawing.Point(327, 76)
        Me.txtHoTen.Margin = New System.Windows.Forms.Padding(2)
        Me.txtHoTen.Name = "txtHoTen"
        Me.txtHoTen.Size = New System.Drawing.Size(143, 20)
        Me.txtHoTen.TabIndex = 63
        '
        'txtDienThoai
        '
        Me.txtDienThoai.Location = New System.Drawing.Point(100, 190)
        Me.txtDienThoai.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDienThoai.Name = "txtDienThoai"
        Me.txtDienThoai.Size = New System.Drawing.Size(141, 20)
        Me.txtDienThoai.TabIndex = 62
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Location = New System.Drawing.Point(327, 152)
        Me.txtDiaChi.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(143, 20)
        Me.txtDiaChi.TabIndex = 61
        '
        'txtTenONha
        '
        Me.txtTenONha.Location = New System.Drawing.Point(98, 149)
        Me.txtTenONha.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTenONha.Name = "txtTenONha"
        Me.txtTenONha.Size = New System.Drawing.Size(143, 20)
        Me.txtTenONha.TabIndex = 60
        '
        'txtHoTenPhuHuynh
        '
        Me.txtHoTenPhuHuynh.Location = New System.Drawing.Point(132, 113)
        Me.txtHoTenPhuHuynh.Margin = New System.Windows.Forms.Padding(2)
        Me.txtHoTenPhuHuynh.Name = "txtHoTenPhuHuynh"
        Me.txtHoTenPhuHuynh.Size = New System.Drawing.Size(143, 20)
        Me.txtHoTenPhuHuynh.TabIndex = 59
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 79)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "Mã trẻ em"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(38, 193)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "Điện thoại"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(267, 152)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "Địa chỉ"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(38, 152)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 13)
        Me.Label9.TabIndex = 51
        Me.Label9.Text = "Tên ở nhà"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(38, 116)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 13)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "Tên phụ huynh"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(17, 39)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(88, 13)
        Me.Label12.TabIndex = 65
        Me.Label12.Text = "Thông tin cơ bản"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(20, 233)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(143, 17)
        Me.CheckBox1.TabIndex = 66
        Me.CheckBox1.Text = "Tra cứu trẻ em nâng cao"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(38, 271)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(49, 13)
        Me.Label13.TabIndex = 67
        Me.Label13.Text = "Tên khối"
        '
        'cbKhoi
        '
        Me.cbKhoi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbKhoi.FormattingEnabled = True
        Me.cbKhoi.Location = New System.Drawing.Point(97, 268)
        Me.cbKhoi.Name = "cbKhoi"
        Me.cbKhoi.Size = New System.Drawing.Size(143, 21)
        Me.cbKhoi.TabIndex = 68
        '
        'frmTraCuuTreEm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(947, 367)
        Me.Controls.Add(Me.cbKhoi)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.CheckBox1)
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
        Me.Name = "frmTraCuuTreEm"
        Me.Text = "Tra cứu trẻ em"
        Me.TopMost = True
        CType(Me.dgvDanhSachTreEm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvDanhSachTreEm As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTuoi As TextBox
    Friend WithEvents txtGhiChu As TextBox
    Friend WithEvents txtMaTreEm As TextBox
    Friend WithEvents btnTraCuu As Button
    Friend WithEvents btnTraCuuMoi As Button
    Friend WithEvents Label4 As Label
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
    Friend WithEvents Label12 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label13 As Label
    Friend WithEvents cbKhoi As ComboBox
End Class
