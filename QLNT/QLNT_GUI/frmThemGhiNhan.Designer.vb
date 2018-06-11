<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThemGhiNhan
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
        Me.txtTenKhoi = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbTinhTrang = New System.Windows.Forms.ComboBox()
        Me.txtHoTenTre = New System.Windows.Forms.TextBox()
        Me.txtMaGhiNhan = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMaSoTreEm = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpNgayGhiNhan = New System.Windows.Forms.DateTimePicker()
        Me.btnDong = New System.Windows.Forms.Button()
        Me.btnNhap = New System.Windows.Forms.Button()
        Me.dgvListTreEm = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.dgvListTreEm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTenKhoi
        '
        Me.txtTenKhoi.Location = New System.Drawing.Point(111, 145)
        Me.txtTenKhoi.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTenKhoi.Name = "txtTenKhoi"
        Me.txtTenKhoi.ReadOnly = True
        Me.txtTenKhoi.Size = New System.Drawing.Size(201, 20)
        Me.txtTenKhoi.TabIndex = 65
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(26, 148)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 13)
        Me.Label10.TabIndex = 64
        Me.Label10.Text = "Tên khối"
        '
        'cbTinhTrang
        '
        Me.cbTinhTrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTinhTrang.FormattingEnabled = True
        Me.cbTinhTrang.Location = New System.Drawing.Point(112, 226)
        Me.cbTinhTrang.Name = "cbTinhTrang"
        Me.cbTinhTrang.Size = New System.Drawing.Size(200, 21)
        Me.cbTinhTrang.TabIndex = 63
        '
        'txtHoTenTre
        '
        Me.txtHoTenTre.Location = New System.Drawing.Point(111, 107)
        Me.txtHoTenTre.Margin = New System.Windows.Forms.Padding(2)
        Me.txtHoTenTre.Name = "txtHoTenTre"
        Me.txtHoTenTre.ReadOnly = True
        Me.txtHoTenTre.Size = New System.Drawing.Size(201, 20)
        Me.txtHoTenTre.TabIndex = 60
        '
        'txtMaGhiNhan
        '
        Me.txtMaGhiNhan.Location = New System.Drawing.Point(112, 29)
        Me.txtMaGhiNhan.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMaGhiNhan.Name = "txtMaGhiNhan"
        Me.txtMaGhiNhan.ReadOnly = True
        Me.txtMaGhiNhan.Size = New System.Drawing.Size(200, 20)
        Me.txtMaGhiNhan.TabIndex = 58
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 32)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 57
        Me.Label5.Text = "Mã ghi nhận"
        '
        'txtMaSoTreEm
        '
        Me.txtMaSoTreEm.Location = New System.Drawing.Point(112, 69)
        Me.txtMaSoTreEm.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMaSoTreEm.Name = "txtMaSoTreEm"
        Me.txtMaSoTreEm.ReadOnly = True
        Me.txtMaSoTreEm.Size = New System.Drawing.Size(200, 20)
        Me.txtMaSoTreEm.TabIndex = 56
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 229)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "Tình trạng"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 186)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "Ngày ghi nhận"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 110)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Họ tên trẻ"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 72)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Mã trẻ em"
        '
        'dtpNgayGhiNhan
        '
        Me.dtpNgayGhiNhan.Location = New System.Drawing.Point(112, 180)
        Me.dtpNgayGhiNhan.Name = "dtpNgayGhiNhan"
        Me.dtpNgayGhiNhan.Size = New System.Drawing.Size(200, 20)
        Me.dtpNgayGhiNhan.TabIndex = 66
        '
        'btnDong
        '
        Me.btnDong.Location = New System.Drawing.Point(195, 282)
        Me.btnDong.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(56, 19)
        Me.btnDong.TabIndex = 69
        Me.btnDong.Text = "Đóng"
        Me.btnDong.UseVisualStyleBackColor = True
        '
        'btnNhap
        '
        Me.btnNhap.Location = New System.Drawing.Point(64, 282)
        Me.btnNhap.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNhap.Name = "btnNhap"
        Me.btnNhap.Size = New System.Drawing.Size(56, 19)
        Me.btnNhap.TabIndex = 67
        Me.btnNhap.Text = "Nhập"
        Me.btnNhap.UseVisualStyleBackColor = True
        '
        'dgvListTreEm
        '
        Me.dgvListTreEm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvListTreEm.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvListTreEm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListTreEm.Location = New System.Drawing.Point(338, 61)
        Me.dgvListTreEm.Name = "dgvListTreEm"
        Me.dgvListTreEm.RowHeadersVisible = False
        Me.dgvListTreEm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListTreEm.Size = New System.Drawing.Size(332, 240)
        Me.dgvListTreEm.TabIndex = 71
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(380, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(253, 18)
        Me.Label7.TabIndex = 89
        Me.Label7.Text = "----- Danh sách trẻ chưa ghi nhận -----"
        '
        'frmThemGhiNhan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(699, 329)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dgvListTreEm)
        Me.Controls.Add(Me.btnDong)
        Me.Controls.Add(Me.btnNhap)
        Me.Controls.Add(Me.dtpNgayGhiNhan)
        Me.Controls.Add(Me.txtTenKhoi)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cbTinhTrang)
        Me.Controls.Add(Me.txtHoTenTre)
        Me.Controls.Add(Me.txtMaGhiNhan)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtMaSoTreEm)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmThemGhiNhan"
        Me.Text = "Thêm ghi nhận"
        Me.TopMost = True
        CType(Me.dgvListTreEm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTenKhoi As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cbTinhTrang As ComboBox
    Friend WithEvents txtHoTenTre As TextBox
    Friend WithEvents txtMaGhiNhan As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtMaSoTreEm As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpNgayGhiNhan As DateTimePicker
    Friend WithEvents btnDong As Button
    Friend WithEvents btnNhap As Button
    Friend WithEvents dgvListTreEm As DataGridView
    Friend WithEvents Label7 As Label
End Class
