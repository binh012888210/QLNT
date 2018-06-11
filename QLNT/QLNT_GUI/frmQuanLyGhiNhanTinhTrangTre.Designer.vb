<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.dgvDanhSachGhiNhan = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtHoTenTre = New System.Windows.Forms.TextBox()
        Me.btnGhiNhan = New System.Windows.Forms.Button()
        Me.btnCapNhatGhiNhan = New System.Windows.Forms.Button()
        Me.txtNgayGhiNhan = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnXoaGhiNhan = New System.Windows.Forms.Button()
        Me.btnDong = New System.Windows.Forms.Button()
        Me.txtTinhTrang = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTenKhoi = New System.Windows.Forms.TextBox()
        CType(Me.dgvDanhSachGhiNhan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 97)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Họ tên trẻ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 220)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Ngày ghi nhận"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 134)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Tên tình trạng"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 56)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Mã ghi nhận"
        '
        'txtMaGhiNhan
        '
        Me.txtMaGhiNhan.Location = New System.Drawing.Point(102, 53)
        Me.txtMaGhiNhan.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMaGhiNhan.Name = "txtMaGhiNhan"
        Me.txtMaGhiNhan.ReadOnly = True
        Me.txtMaGhiNhan.Size = New System.Drawing.Size(151, 20)
        Me.txtMaGhiNhan.TabIndex = 28
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(352, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(196, 18)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "----- Danh sách ghi nhận -----"
        '
        'dgvDanhSachGhiNhan
        '
        Me.dgvDanhSachGhiNhan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDanhSachGhiNhan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvDanhSachGhiNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDanhSachGhiNhan.Location = New System.Drawing.Point(274, 56)
        Me.dgvDanhSachGhiNhan.Name = "dgvDanhSachGhiNhan"
        Me.dgvDanhSachGhiNhan.RowHeadersVisible = False
        Me.dgvDanhSachGhiNhan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDanhSachGhiNhan.Size = New System.Drawing.Size(374, 298)
        Me.dgvDanhSachGhiNhan.TabIndex = 34
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(236, 18)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "---------- Thông tin ghi nhận ----------"
        '
        'txtHoTenTre
        '
        Me.txtHoTenTre.Location = New System.Drawing.Point(102, 94)
        Me.txtHoTenTre.Margin = New System.Windows.Forms.Padding(2)
        Me.txtHoTenTre.Name = "txtHoTenTre"
        Me.txtHoTenTre.ReadOnly = True
        Me.txtHoTenTre.Size = New System.Drawing.Size(151, 20)
        Me.txtHoTenTre.TabIndex = 40
        '
        'btnGhiNhan
        '
        Me.btnGhiNhan.Location = New System.Drawing.Point(21, 292)
        Me.btnGhiNhan.Name = "btnGhiNhan"
        Me.btnGhiNhan.Size = New System.Drawing.Size(97, 23)
        Me.btnGhiNhan.TabIndex = 42
        Me.btnGhiNhan.Text = "Thêm Ghi nhận"
        Me.btnGhiNhan.UseVisualStyleBackColor = True
        '
        'btnCapNhatGhiNhan
        '
        Me.btnCapNhatGhiNhan.Location = New System.Drawing.Point(142, 292)
        Me.btnCapNhatGhiNhan.Name = "btnCapNhatGhiNhan"
        Me.btnCapNhatGhiNhan.Size = New System.Drawing.Size(113, 23)
        Me.btnCapNhatGhiNhan.TabIndex = 43
        Me.btnCapNhatGhiNhan.Text = "Cập nhật ghi nhận"
        Me.btnCapNhatGhiNhan.UseVisualStyleBackColor = True
        '
        'txtNgayGhiNhan
        '
        Me.txtNgayGhiNhan.Location = New System.Drawing.Point(100, 217)
        Me.txtNgayGhiNhan.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNgayGhiNhan.Name = "txtNgayGhiNhan"
        Me.txtNgayGhiNhan.ReadOnly = True
        Me.txtNgayGhiNhan.Size = New System.Drawing.Size(151, 20)
        Me.txtNgayGhiNhan.TabIndex = 44
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(38, 258)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(187, 18)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "---------- Chức năng ----------"
        '
        'btnXoaGhiNhan
        '
        Me.btnXoaGhiNhan.Location = New System.Drawing.Point(21, 331)
        Me.btnXoaGhiNhan.Name = "btnXoaGhiNhan"
        Me.btnXoaGhiNhan.Size = New System.Drawing.Size(97, 23)
        Me.btnXoaGhiNhan.TabIndex = 46
        Me.btnXoaGhiNhan.Text = "Xoá Ghi nhận"
        Me.btnXoaGhiNhan.UseVisualStyleBackColor = True
        '
        'btnDong
        '
        Me.btnDong.Location = New System.Drawing.Point(143, 331)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(111, 23)
        Me.btnDong.TabIndex = 47
        Me.btnDong.Text = "Đóng"
        Me.btnDong.UseVisualStyleBackColor = True
        '
        'txtTinhTrang
        '
        Me.txtTinhTrang.Location = New System.Drawing.Point(102, 131)
        Me.txtTinhTrang.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTinhTrang.Name = "txtTinhTrang"
        Me.txtTinhTrang.ReadOnly = True
        Me.txtTinhTrang.Size = New System.Drawing.Size(151, 20)
        Me.txtTinhTrang.TabIndex = 48
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(16, 177)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 13)
        Me.Label10.TabIndex = 50
        Me.Label10.Text = "Tên khối"
        '
        'txtTenKhoi
        '
        Me.txtTenKhoi.Location = New System.Drawing.Point(101, 174)
        Me.txtTenKhoi.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTenKhoi.Name = "txtTenKhoi"
        Me.txtTenKhoi.ReadOnly = True
        Me.txtTenKhoi.Size = New System.Drawing.Size(151, 20)
        Me.txtTenKhoi.TabIndex = 51
        '
        'frmQuanLyGhiNhanTinhTrangTre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(672, 379)
        Me.Controls.Add(Me.txtTenKhoi)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtTinhTrang)
        Me.Controls.Add(Me.btnDong)
        Me.Controls.Add(Me.btnXoaGhiNhan)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtNgayGhiNhan)
        Me.Controls.Add(Me.btnCapNhatGhiNhan)
        Me.Controls.Add(Me.btnGhiNhan)
        Me.Controls.Add(Me.txtHoTenTre)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dgvDanhSachGhiNhan)
        Me.Controls.Add(Me.txtMaGhiNhan)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmQuanLyGhiNhanTinhTrangTre"
        Me.Text = "Quản lý ghi nhận tình trạng trẻ em"
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
    Friend WithEvents dgvDanhSachGhiNhan As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents txtHoTenTre As TextBox
    Friend WithEvents btnGhiNhan As Button
    Friend WithEvents btnCapNhatGhiNhan As Button
    Friend WithEvents txtNgayGhiNhan As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnXoaGhiNhan As Button
    Friend WithEvents btnDong As Button
    Friend WithEvents txtTinhTrang As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtTenKhoi As TextBox
End Class
