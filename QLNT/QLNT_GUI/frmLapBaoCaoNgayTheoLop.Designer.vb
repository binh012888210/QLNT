<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLapBaoCaoNgayTheoLop
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
        Me.cbTenKhoi = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnDong = New System.Windows.Forms.Button()
        Me.btnLapBaoCao = New System.Windows.Forms.Button()
        Me.dgvChuaBaoCao = New System.Windows.Forms.DataGridView()
        Me.dtpNgayLapBaoCao = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMaSoBaoCao = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvChuaBaoCao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbTenKhoi
        '
        Me.cbTenKhoi.FormattingEnabled = True
        Me.cbTenKhoi.Location = New System.Drawing.Point(133, 134)
        Me.cbTenKhoi.Name = "cbTenKhoi"
        Me.cbTenKhoi.Size = New System.Drawing.Size(151, 21)
        Me.cbTenKhoi.TabIndex = 65
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 137)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "Khối lớp"
        '
        'btnDong
        '
        Me.btnDong.Location = New System.Drawing.Point(460, 427)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(75, 23)
        Me.btnDong.TabIndex = 63
        Me.btnDong.Text = "Đóng"
        Me.btnDong.UseVisualStyleBackColor = True
        '
        'btnLapBaoCao
        '
        Me.btnLapBaoCao.Location = New System.Drawing.Point(425, 84)
        Me.btnLapBaoCao.Name = "btnLapBaoCao"
        Me.btnLapBaoCao.Size = New System.Drawing.Size(75, 58)
        Me.btnLapBaoCao.TabIndex = 62
        Me.btnLapBaoCao.Text = "Lập báo cáo"
        Me.btnLapBaoCao.UseVisualStyleBackColor = True
        '
        'dgvChuaBaoCao
        '
        Me.dgvChuaBaoCao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvChuaBaoCao.Location = New System.Drawing.Point(30, 172)
        Me.dgvChuaBaoCao.Name = "dgvChuaBaoCao"
        Me.dgvChuaBaoCao.Size = New System.Drawing.Size(505, 239)
        Me.dgvChuaBaoCao.TabIndex = 61
        '
        'dtpNgayLapBaoCao
        '
        Me.dtpNgayLapBaoCao.Location = New System.Drawing.Point(133, 101)
        Me.dtpNgayLapBaoCao.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpNgayLapBaoCao.Name = "dtpNgayLapBaoCao"
        Me.dtpNgayLapBaoCao.Size = New System.Drawing.Size(151, 20)
        Me.dtpNgayLapBaoCao.TabIndex = 60
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 101)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "Ngày báo cáo"
        '
        'txtMaSoBaoCao
        '
        Me.txtMaSoBaoCao.Location = New System.Drawing.Point(133, 63)
        Me.txtMaSoBaoCao.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMaSoBaoCao.Name = "txtMaSoBaoCao"
        Me.txtMaSoBaoCao.ReadOnly = True
        Me.txtMaSoBaoCao.Size = New System.Drawing.Size(151, 20)
        Me.txtMaSoBaoCao.TabIndex = 58
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 66)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 57
        Me.Label5.Text = "Mã báo cáo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(155, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 18)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "--------- Lập báo cáo ngày  ----------"
        '
        'frmLapBaoCaoNgayTheoLop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(562, 470)
        Me.Controls.Add(Me.cbTenKhoi)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnDong)
        Me.Controls.Add(Me.btnLapBaoCao)
        Me.Controls.Add(Me.dgvChuaBaoCao)
        Me.Controls.Add(Me.dtpNgayLapBaoCao)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtMaSoBaoCao)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmLapBaoCaoNgayTheoLop"
        Me.Text = "LapBaoCaoNgayTheoLop"
        CType(Me.dgvChuaBaoCao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbTenKhoi As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnDong As Button
    Friend WithEvents btnLapBaoCao As Button
    Friend WithEvents dgvChuaBaoCao As DataGridView
    Friend WithEvents dtpNgayLapBaoCao As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMaSoBaoCao As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
End Class
