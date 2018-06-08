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
        Me.btnToFROM = New System.Windows.Forms.Button()
        Me.cbKhoi = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnChuyenHS = New System.Windows.Forms.Button()
        Me.dgvListHS_FROM = New System.Windows.Forms.DataGridView()
        Me.cbTuLop = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvListHS_To = New System.Windows.Forms.DataGridView()
        Me.cbSangLop = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnFROMTo = New System.Windows.Forms.Button()
        Me.btnDong = New System.Windows.Forms.Button()
        CType(Me.dgvListHS_FROM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvListHS_To, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnToFROM
        '
        Me.btnToFROM.Location = New System.Drawing.Point(359, 309)
        Me.btnToFROM.Name = "btnToFROM"
        Me.btnToFROM.Size = New System.Drawing.Size(52, 23)
        Me.btnToFROM.TabIndex = 91
        Me.btnToFROM.Text = "<"
        Me.btnToFROM.UseVisualStyleBackColor = True
        '
        'cbKhoi
        '
        Me.cbKhoi.FormattingEnabled = True
        Me.cbKhoi.Location = New System.Drawing.Point(336, 29)
        Me.cbKhoi.Name = "cbKhoi"
        Me.cbKhoi.Size = New System.Drawing.Size(125, 21)
        Me.cbKhoi.TabIndex = 77
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(287, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 82
        Me.Label3.Text = "Khối:"
        '
        'btnChuyenHS
        '
        Me.btnChuyenHS.Location = New System.Drawing.Point(336, 458)
        Me.btnChuyenHS.Name = "btnChuyenHS"
        Me.btnChuyenHS.Size = New System.Drawing.Size(125, 23)
        Me.btnChuyenHS.TabIndex = 83
        Me.btnChuyenHS.Text = "Chuyển Học Sinh"
        Me.btnChuyenHS.UseVisualStyleBackColor = True
        '
        'dgvListHS_FROM
        '
        Me.dgvListHS_FROM.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvListHS_FROM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListHS_FROM.Location = New System.Drawing.Point(32, 113)
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
        Me.cbTuLop.Location = New System.Drawing.Point(90, 77)
        Me.cbTuLop.Name = "cbTuLop"
        Me.cbTuLop.Size = New System.Drawing.Size(153, 21)
        Me.cbTuLop.TabIndex = 85
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 86
        Me.Label2.Text = "Từ Lớp:"
        '
        'dgvListHS_To
        '
        Me.dgvListHS_To.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvListHS_To.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListHS_To.Location = New System.Drawing.Point(430, 113)
        Me.dgvListHS_To.MultiSelect = False
        Me.dgvListHS_To.Name = "dgvListHS_To"
        Me.dgvListHS_To.ReadOnly = True
        Me.dgvListHS_To.RowHeadersVisible = False
        Me.dgvListHS_To.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListHS_To.Size = New System.Drawing.Size(309, 325)
        Me.dgvListHS_To.TabIndex = 87
        '
        'cbSangLop
        '
        Me.cbSangLop.FormattingEnabled = True
        Me.cbSangLop.Location = New System.Drawing.Point(503, 74)
        Me.cbSangLop.Name = "cbSangLop"
        Me.cbSangLop.Size = New System.Drawing.Size(153, 21)
        Me.cbSangLop.TabIndex = 88
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(427, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 89
        Me.Label4.Text = "Sang Lớp:"
        '
        'btnFROMTo
        '
        Me.btnFROMTo.Location = New System.Drawing.Point(359, 243)
        Me.btnFROMTo.Name = "btnFROMTo"
        Me.btnFROMTo.Size = New System.Drawing.Size(52, 23)
        Me.btnFROMTo.TabIndex = 90
        Me.btnFROMTo.Text = ">"
        Me.btnFROMTo.UseVisualStyleBackColor = True
        '
        'btnDong
        '
        Me.btnDong.Location = New System.Drawing.Point(664, 458)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(75, 23)
        Me.btnDong.TabIndex = 92
        Me.btnDong.Text = "Đóng"
        Me.btnDong.UseVisualStyleBackColor = True
        '
        'frmChuyenLop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(777, 498)
        Me.Controls.Add(Me.btnDong)
        Me.Controls.Add(Me.btnToFROM)
        Me.Controls.Add(Me.btnFROMTo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbSangLop)
        Me.Controls.Add(Me.dgvListHS_To)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbTuLop)
        Me.Controls.Add(Me.dgvListHS_FROM)
        Me.Controls.Add(Me.btnChuyenHS)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbKhoi)
        Me.Name = "frmChuyenLop"
        Me.Text = "ChuyenLop"
        CType(Me.dgvListHS_FROM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvListHS_To, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnToFROM As Button
    Friend WithEvents cbKhoi As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnChuyenHS As Button
    Friend WithEvents dgvListHS_FROM As DataGridView
    Friend WithEvents cbTuLop As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvListHS_To As DataGridView
    Friend WithEvents cbSangLop As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnFROMTo As Button
    Friend WithEvents btnDong As Button
End Class
