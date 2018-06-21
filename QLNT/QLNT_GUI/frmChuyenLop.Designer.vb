<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChuyenLop
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvListHS_FROM = New System.Windows.Forms.DataGridView()
        Me.cbTuLop = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbSangLop = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnDong = New System.Windows.Forms.Button()
        Me.btnToFROM = New System.Windows.Forms.Button()
        Me.btnFROMTo = New System.Windows.Forms.Button()
        Me.dgvListHS_To = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSiSoLopTu = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSiSoLopSang = New System.Windows.Forms.TextBox()
        Me.txtMaKhoi = New System.Windows.Forms.TextBox()
        Me.txtTenKhoi = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbMaKhoi = New System.Windows.Forms.ComboBox()
        CType(Me.dgvListHS_FROM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvListHS_To, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 82
        Me.Label3.Text = "Mã Khối"
        '
        'dgvListHS_FROM
        '
        Me.dgvListHS_FROM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvListHS_FROM.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvListHS_FROM.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvListHS_FROM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListHS_FROM.Location = New System.Drawing.Point(23, 145)
        Me.dgvListHS_FROM.MultiSelect = False
        Me.dgvListHS_FROM.Name = "dgvListHS_FROM"
        Me.dgvListHS_FROM.RowHeadersVisible = False
        Me.dgvListHS_FROM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListHS_FROM.Size = New System.Drawing.Size(309, 325)
        Me.dgvListHS_FROM.TabIndex = 84
        '
        'cbTuLop
        '
        Me.cbTuLop.FormattingEnabled = True
        Me.cbTuLop.Location = New System.Drawing.Point(81, 109)
        Me.cbTuLop.Name = "cbTuLop"
        Me.cbTuLop.Size = New System.Drawing.Size(118, 21)
        Me.cbTuLop.TabIndex = 85
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 86
        Me.Label2.Text = "Từ Lớp:"
        '
        'cbSangLop
        '
        Me.cbSangLop.FormattingEnabled = True
        Me.cbSangLop.Location = New System.Drawing.Point(492, 109)
        Me.cbSangLop.Name = "cbSangLop"
        Me.cbSangLop.Size = New System.Drawing.Size(115, 21)
        Me.cbSangLop.TabIndex = 88
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(418, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 89
        Me.Label4.Text = "Sang Lớp:"
        '
        'btnDong
        '
        Me.btnDong.Location = New System.Drawing.Point(646, 46)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(75, 23)
        Me.btnDong.TabIndex = 92
        Me.btnDong.Text = "Đóng"
        Me.btnDong.UseVisualStyleBackColor = True
        '
        'btnToFROM
        '
        Me.btnToFROM.Location = New System.Drawing.Point(350, 341)
        Me.btnToFROM.Name = "btnToFROM"
        Me.btnToFROM.Size = New System.Drawing.Size(52, 23)
        Me.btnToFROM.TabIndex = 91
        Me.btnToFROM.Text = "<"
        Me.btnToFROM.UseVisualStyleBackColor = True
        '
        'btnFROMTo
        '
        Me.btnFROMTo.Location = New System.Drawing.Point(350, 275)
        Me.btnFROMTo.Name = "btnFROMTo"
        Me.btnFROMTo.Size = New System.Drawing.Size(52, 23)
        Me.btnFROMTo.TabIndex = 90
        Me.btnFROMTo.Text = ">"
        Me.btnFROMTo.UseVisualStyleBackColor = True
        '
        'dgvListHS_To
        '
        Me.dgvListHS_To.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvListHS_To.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvListHS_To.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvListHS_To.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListHS_To.Location = New System.Drawing.Point(421, 145)
        Me.dgvListHS_To.MultiSelect = False
        Me.dgvListHS_To.Name = "dgvListHS_To"
        Me.dgvListHS_To.ReadOnly = True
        Me.dgvListHS_To.RowHeadersVisible = False
        Me.dgvListHS_To.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListHS_To.Size = New System.Drawing.Size(309, 325)
        Me.dgvListHS_To.TabIndex = 87
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(229, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 93
        Me.Label1.Text = "Sỉ số"
        '
        'txtSiSoLopTu
        '
        Me.txtSiSoLopTu.Location = New System.Drawing.Point(265, 109)
        Me.txtSiSoLopTu.Name = "txtSiSoLopTu"
        Me.txtSiSoLopTu.ReadOnly = True
        Me.txtSiSoLopTu.Size = New System.Drawing.Size(30, 20)
        Me.txtSiSoLopTu.TabIndex = 94
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(643, 114)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 95
        Me.Label5.Text = "Sỉ số"
        '
        'txtSiSoLopSang
        '
        Me.txtSiSoLopSang.Location = New System.Drawing.Point(679, 111)
        Me.txtSiSoLopSang.Name = "txtSiSoLopSang"
        Me.txtSiSoLopSang.ReadOnly = True
        Me.txtSiSoLopSang.Size = New System.Drawing.Size(30, 20)
        Me.txtSiSoLopSang.TabIndex = 96
        '
        'txtMaKhoi
        '
        Me.txtMaKhoi.Location = New System.Drawing.Point(91, 57)
        Me.txtMaKhoi.Name = "txtMaKhoi"
        Me.txtMaKhoi.ReadOnly = True
        Me.txtMaKhoi.Size = New System.Drawing.Size(100, 20)
        Me.txtMaKhoi.TabIndex = 97
        '
        'txtTenKhoi
        '
        Me.txtTenKhoi.Location = New System.Drawing.Point(91, 19)
        Me.txtTenKhoi.Name = "txtTenKhoi"
        Me.txtTenKhoi.ReadOnly = True
        Me.txtTenKhoi.Size = New System.Drawing.Size(100, 20)
        Me.txtTenKhoi.TabIndex = 99
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 98
        Me.Label6.Text = "Tên khối"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(240, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(275, 25)
        Me.Label7.TabIndex = 100
        Me.Label7.Text = "----- Chuyển lớp trẻ em  -----"
        '
        'cbMaKhoi
        '
        Me.cbMaKhoi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMaKhoi.FormattingEnabled = True
        Me.cbMaKhoi.Location = New System.Drawing.Point(91, 18)
        Me.cbMaKhoi.Name = "cbMaKhoi"
        Me.cbMaKhoi.Size = New System.Drawing.Size(100, 21)
        Me.cbMaKhoi.TabIndex = 101
        Me.cbMaKhoi.Visible = False
        '
        'frmChuyenLop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(754, 499)
        Me.Controls.Add(Me.cbMaKhoi)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtTenKhoi)
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
        Me.Name = "frmChuyenLop"
        Me.Text = "Chuyển lớp"
        CType(Me.dgvListHS_FROM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvListHS_To, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents dgvListHS_FROM As DataGridView
    Friend WithEvents cbTuLop As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbSangLop As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnDong As Button
    Friend WithEvents btnToFROM As Button
    Friend WithEvents btnFROMTo As Button
    Friend WithEvents dgvListHS_To As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSiSoLopTu As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSiSoLopSang As TextBox
    Friend WithEvents txtMaKhoi As TextBox
    Friend WithEvents txtTenKhoi As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cbMaKhoi As ComboBox
End Class
