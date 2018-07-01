<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHuongDanChuyenLop
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
        Me.cbMaKhoi = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtMaKhoi = New System.Windows.Forms.TextBox()
        Me.txtSiSoLopSang = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSiSoLopTu = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDong = New System.Windows.Forms.Button()
        Me.btnToFROM = New System.Windows.Forms.Button()
        Me.btnFROMTo = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbSangLop = New System.Windows.Forms.ComboBox()
        Me.dgvListHS_To = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbTuLop = New System.Windows.Forms.ComboBox()
        Me.dgvListHS_FROM = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        CType(Me.dgvListHS_To, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvListHS_FROM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbMaKhoi
        '
        Me.cbMaKhoi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMaKhoi.FormattingEnabled = True
        Me.cbMaKhoi.Location = New System.Drawing.Point(323, 89)
        Me.cbMaKhoi.Name = "cbMaKhoi"
        Me.cbMaKhoi.Size = New System.Drawing.Size(100, 21)
        Me.cbMaKhoi.TabIndex = 119
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(264, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(275, 25)
        Me.Label7.TabIndex = 118
        Me.Label7.Text = "----- Chuyển lớp trẻ em  -----"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(248, 93)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 117
        Me.Label6.Text = "Tên khối"
        '
        'txtMaKhoi
        '
        Me.txtMaKhoi.Location = New System.Drawing.Point(512, 89)
        Me.txtMaKhoi.Name = "txtMaKhoi"
        Me.txtMaKhoi.ReadOnly = True
        Me.txtMaKhoi.Size = New System.Drawing.Size(39, 20)
        Me.txtMaKhoi.TabIndex = 116
        '
        'txtSiSoLopSang
        '
        Me.txtSiSoLopSang.Location = New System.Drawing.Point(716, 142)
        Me.txtSiSoLopSang.Name = "txtSiSoLopSang"
        Me.txtSiSoLopSang.ReadOnly = True
        Me.txtSiSoLopSang.Size = New System.Drawing.Size(30, 20)
        Me.txtSiSoLopSang.TabIndex = 115
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(680, 145)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 114
        Me.Label5.Text = "Sỉ số"
        '
        'txtSiSoLopTu
        '
        Me.txtSiSoLopTu.Location = New System.Drawing.Point(302, 140)
        Me.txtSiSoLopTu.Name = "txtSiSoLopTu"
        Me.txtSiSoLopTu.ReadOnly = True
        Me.txtSiSoLopTu.Size = New System.Drawing.Size(30, 20)
        Me.txtSiSoLopTu.TabIndex = 113
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(266, 143)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 112
        Me.Label1.Text = "Sỉ số"
        '
        'btnDong
        '
        Me.btnDong.Location = New System.Drawing.Point(692, 58)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(75, 23)
        Me.btnDong.TabIndex = 111
        Me.btnDong.Text = "Đóng"
        Me.btnDong.UseVisualStyleBackColor = True
        '
        'btnToFROM
        '
        Me.btnToFROM.Location = New System.Drawing.Point(387, 372)
        Me.btnToFROM.Name = "btnToFROM"
        Me.btnToFROM.Size = New System.Drawing.Size(52, 23)
        Me.btnToFROM.TabIndex = 110
        Me.btnToFROM.Text = "<"
        Me.btnToFROM.UseVisualStyleBackColor = True
        '
        'btnFROMTo
        '
        Me.btnFROMTo.Location = New System.Drawing.Point(387, 306)
        Me.btnFROMTo.Name = "btnFROMTo"
        Me.btnFROMTo.Size = New System.Drawing.Size(52, 23)
        Me.btnFROMTo.TabIndex = 109
        Me.btnFROMTo.Text = ">"
        Me.btnFROMTo.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(455, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 108
        Me.Label4.Text = "Sang Lớp:"
        '
        'cbSangLop
        '
        Me.cbSangLop.FormattingEnabled = True
        Me.cbSangLop.Location = New System.Drawing.Point(529, 140)
        Me.cbSangLop.Name = "cbSangLop"
        Me.cbSangLop.Size = New System.Drawing.Size(115, 21)
        Me.cbSangLop.TabIndex = 107
        '
        'dgvListHS_To
        '
        Me.dgvListHS_To.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvListHS_To.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvListHS_To.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvListHS_To.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListHS_To.Location = New System.Drawing.Point(458, 176)
        Me.dgvListHS_To.MultiSelect = False
        Me.dgvListHS_To.Name = "dgvListHS_To"
        Me.dgvListHS_To.ReadOnly = True
        Me.dgvListHS_To.RowHeadersVisible = False
        Me.dgvListHS_To.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListHS_To.Size = New System.Drawing.Size(309, 325)
        Me.dgvListHS_To.TabIndex = 106
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(57, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 105
        Me.Label2.Text = "Từ Lớp:"
        '
        'cbTuLop
        '
        Me.cbTuLop.FormattingEnabled = True
        Me.cbTuLop.Location = New System.Drawing.Point(118, 140)
        Me.cbTuLop.Name = "cbTuLop"
        Me.cbTuLop.Size = New System.Drawing.Size(118, 21)
        Me.cbTuLop.TabIndex = 104
        '
        'dgvListHS_FROM
        '
        Me.dgvListHS_FROM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvListHS_FROM.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvListHS_FROM.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvListHS_FROM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListHS_FROM.Location = New System.Drawing.Point(60, 176)
        Me.dgvListHS_FROM.MultiSelect = False
        Me.dgvListHS_FROM.Name = "dgvListHS_FROM"
        Me.dgvListHS_FROM.RowHeadersVisible = False
        Me.dgvListHS_FROM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListHS_FROM.Size = New System.Drawing.Size(309, 325)
        Me.dgvListHS_FROM.TabIndex = 103
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(441, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 102
        Me.Label3.Text = "Mã Khối"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(731, 31)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(68, 13)
        Me.Label12.TabIndex = 124
        Me.Label12.Text = "6. Đóng form"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(375, 281)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(67, 13)
        Me.Label13.TabIndex = 125
        Me.Label13.Text = "4. Chuyến đi"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(57, 115)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(217, 13)
        Me.Label14.TabIndex = 126
        Me.Label14.Text = "2. Chọn lớp trong danh sách lớp cần chuyển"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(248, 68)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(170, 13)
        Me.Label15.TabIndex = 127
        Me.Label15.Text = "1. Chọn khối trong danh sách khối"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(455, 124)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(206, 13)
        Me.Label17.TabIndex = 129
        Me.Label17.Text = "3. Chọn lớp trong danh sách lớp cần nhận"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(375, 344)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(70, 13)
        Me.Label18.TabIndex = 130
        Me.Label18.Text = "5. Chuyến về"
        '
        'frmHuongDanChuyenLop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(852, 585)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cbMaKhoi)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtMaKhoi)
        Me.Controls.Add(Me.txtSiSoLopSang)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtSiSoLopTu)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDong)
        Me.Controls.Add(Me.btnToFROM)
        Me.Controls.Add(Me.btnFROMTo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbSangLop)
        Me.Controls.Add(Me.dgvListHS_To)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbTuLop)
        Me.Controls.Add(Me.dgvListHS_FROM)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmHuongDanChuyenLop"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hướng dẫn chuyển lớp trẻ em"
        CType(Me.dgvListHS_To, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvListHS_FROM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbMaKhoi As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtMaKhoi As TextBox
    Friend WithEvents txtSiSoLopSang As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSiSoLopTu As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnDong As Button
    Friend WithEvents btnToFROM As Button
    Friend WithEvents btnFROMTo As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents cbSangLop As ComboBox
    Friend WithEvents dgvListHS_To As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents cbTuLop As ComboBox
    Friend WithEvents dgvListHS_FROM As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
End Class
