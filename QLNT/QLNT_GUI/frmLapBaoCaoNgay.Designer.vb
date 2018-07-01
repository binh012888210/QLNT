<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLapBaoCaoNgay
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
        Me.btnXoaChiTietBaoCao = New System.Windows.Forms.Button()
        Me.btnThemChiTietBaoCao = New System.Windows.Forms.Button()
        Me.txtGhiChu = New System.Windows.Forms.TextBox()
        Me.txtTenKhoi = New System.Windows.Forms.TextBox()
        Me.txtTenTinhTrang = New System.Windows.Forms.TextBox()
        Me.txtHoTenTre = New System.Windows.Forms.TextBox()
        Me.txtMaCTBC = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnDong = New System.Windows.Forms.Button()
        Me.btnLapBaoCao = New System.Windows.Forms.Button()
        Me.dgvLapBaoCaoNgay2 = New System.Windows.Forms.DataGridView()
        Me.dtpNgayLapBaoCao = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMaBaoCao = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvLapBaoCaoNgay2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnXoaChiTietBaoCao
        '
        Me.btnXoaChiTietBaoCao.Location = New System.Drawing.Point(221, 363)
        Me.btnXoaChiTietBaoCao.Name = "btnXoaChiTietBaoCao"
        Me.btnXoaChiTietBaoCao.Size = New System.Drawing.Size(149, 23)
        Me.btnXoaChiTietBaoCao.TabIndex = 69
        Me.btnXoaChiTietBaoCao.Text = "Xóa Chi tiết báo cáo"
        Me.btnXoaChiTietBaoCao.UseVisualStyleBackColor = True
        '
        'btnThemChiTietBaoCao
        '
        Me.btnThemChiTietBaoCao.Location = New System.Drawing.Point(42, 363)
        Me.btnThemChiTietBaoCao.Name = "btnThemChiTietBaoCao"
        Me.btnThemChiTietBaoCao.Size = New System.Drawing.Size(149, 23)
        Me.btnThemChiTietBaoCao.TabIndex = 68
        Me.btnThemChiTietBaoCao.Text = "Thêm Chi tiết báo cáo"
        Me.btnThemChiTietBaoCao.UseVisualStyleBackColor = True
        '
        'txtGhiChu
        '
        Me.txtGhiChu.Location = New System.Drawing.Point(139, 233)
        Me.txtGhiChu.Name = "txtGhiChu"
        Me.txtGhiChu.ReadOnly = True
        Me.txtGhiChu.Size = New System.Drawing.Size(198, 20)
        Me.txtGhiChu.TabIndex = 67
        '
        'txtTenKhoi
        '
        Me.txtTenKhoi.Location = New System.Drawing.Point(139, 192)
        Me.txtTenKhoi.Name = "txtTenKhoi"
        Me.txtTenKhoi.ReadOnly = True
        Me.txtTenKhoi.Size = New System.Drawing.Size(198, 20)
        Me.txtTenKhoi.TabIndex = 66
        '
        'txtTenTinhTrang
        '
        Me.txtTenTinhTrang.Location = New System.Drawing.Point(139, 147)
        Me.txtTenTinhTrang.Name = "txtTenTinhTrang"
        Me.txtTenTinhTrang.ReadOnly = True
        Me.txtTenTinhTrang.Size = New System.Drawing.Size(198, 20)
        Me.txtTenTinhTrang.TabIndex = 65
        '
        'txtHoTenTre
        '
        Me.txtHoTenTre.Location = New System.Drawing.Point(139, 111)
        Me.txtHoTenTre.Name = "txtHoTenTre"
        Me.txtHoTenTre.ReadOnly = True
        Me.txtHoTenTre.Size = New System.Drawing.Size(198, 20)
        Me.txtHoTenTre.TabIndex = 64
        '
        'txtMaCTBC
        '
        Me.txtMaCTBC.Location = New System.Drawing.Point(139, 76)
        Me.txtMaCTBC.Name = "txtMaCTBC"
        Me.txtMaCTBC.ReadOnly = True
        Me.txtMaCTBC.Size = New System.Drawing.Size(198, 20)
        Me.txtMaCTBC.TabIndex = 63
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(35, 240)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 13)
        Me.Label9.TabIndex = 61
        Me.Label9.Text = "Ghi chú"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(35, 199)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 60
        Me.Label8.Text = "Tên khối"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(35, 154)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 13)
        Me.Label7.TabIndex = 62
        Me.Label7.Text = "Tên tình trạng"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(35, 114)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 59
        Me.Label6.Text = "Họ tên trẻ"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 13)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "Mã chi tiết báo cáo"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(78, 322)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(249, 18)
        Me.Label10.TabIndex = 57
        Me.Label10.Text = "-----------------Chức năng-----------------"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(319, 18)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "----------------Thông tin tình trạng trẻ-----------------"
        '
        'btnDong
        '
        Me.btnDong.Location = New System.Drawing.Point(778, 420)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(149, 23)
        Me.btnDong.TabIndex = 55
        Me.btnDong.Text = "Đóng"
        Me.btnDong.UseVisualStyleBackColor = True
        '
        'btnLapBaoCao
        '
        Me.btnLapBaoCao.Location = New System.Drawing.Point(819, 76)
        Me.btnLapBaoCao.Name = "btnLapBaoCao"
        Me.btnLapBaoCao.Size = New System.Drawing.Size(75, 58)
        Me.btnLapBaoCao.TabIndex = 54
        Me.btnLapBaoCao.Text = "Lập báo cáo"
        Me.btnLapBaoCao.UseVisualStyleBackColor = True
        '
        'dgvLapBaoCaoNgay2
        '
        Me.dgvLapBaoCaoNgay2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLapBaoCaoNgay2.Location = New System.Drawing.Point(422, 157)
        Me.dgvLapBaoCaoNgay2.Name = "dgvLapBaoCaoNgay2"
        Me.dgvLapBaoCaoNgay2.Size = New System.Drawing.Size(505, 239)
        Me.dgvLapBaoCaoNgay2.TabIndex = 53
        '
        'dtpNgayLapBaoCao
        '
        Me.dtpNgayLapBaoCao.Location = New System.Drawing.Point(525, 114)
        Me.dtpNgayLapBaoCao.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpNgayLapBaoCao.Name = "dtpNgayLapBaoCao"
        Me.dtpNgayLapBaoCao.Size = New System.Drawing.Size(151, 20)
        Me.dtpNgayLapBaoCao.TabIndex = 52
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(419, 114)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Ngày báo cáo"
        '
        'txtMaBaoCao
        '
        Me.txtMaBaoCao.Location = New System.Drawing.Point(525, 76)
        Me.txtMaBaoCao.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMaBaoCao.Name = "txtMaBaoCao"
        Me.txtMaBaoCao.ReadOnly = True
        Me.txtMaBaoCao.Size = New System.Drawing.Size(151, 20)
        Me.txtMaBaoCao.TabIndex = 50
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(419, 79)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "Mã báo cáo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(587, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 18)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "--------- Lập báo cáo ngày  ----------"
        '
        'frmLapBaoCaoNgay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(966, 477)
        Me.Controls.Add(Me.btnXoaChiTietBaoCao)
        Me.Controls.Add(Me.btnThemChiTietBaoCao)
        Me.Controls.Add(Me.txtGhiChu)
        Me.Controls.Add(Me.txtTenKhoi)
        Me.Controls.Add(Me.txtTenTinhTrang)
        Me.Controls.Add(Me.txtHoTenTre)
        Me.Controls.Add(Me.txtMaCTBC)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnDong)
        Me.Controls.Add(Me.btnLapBaoCao)
        Me.Controls.Add(Me.dgvLapBaoCaoNgay2)
        Me.Controls.Add(Me.dtpNgayLapBaoCao)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtMaBaoCao)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmLapBaoCaoNgay"
        Me.Text = "fromLapBaoCaoNgay"
        CType(Me.dgvLapBaoCaoNgay2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnXoaChiTietBaoCao As Button
    Friend WithEvents btnThemChiTietBaoCao As Button
    Friend WithEvents txtGhiChu As TextBox
    Friend WithEvents txtTenKhoi As TextBox
    Friend WithEvents txtTenTinhTrang As TextBox
    Friend WithEvents txtHoTenTre As TextBox
    Friend WithEvents txtMaCTBC As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnDong As Button
    Friend WithEvents btnLapBaoCao As Button
    Friend WithEvents dgvLapBaoCaoNgay2 As DataGridView
    Friend WithEvents dtpNgayLapBaoCao As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMaBaoCao As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
End Class
