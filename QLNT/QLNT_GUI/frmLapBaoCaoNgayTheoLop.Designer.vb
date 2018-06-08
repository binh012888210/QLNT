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
        Me.btnDong = New System.Windows.Forms.Button()
        Me.btnXemTruoc = New System.Windows.Forms.Button()
        Me.btnLapBaoCaoVaXuat = New System.Windows.Forms.Button()
        Me.btnLapBaoCao = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.dtpNgayLapBaoCao = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMaSoBaoCao = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDong
        '
        Me.btnDong.Location = New System.Drawing.Point(462, 424)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(75, 23)
        Me.btnDong.TabIndex = 53
        Me.btnDong.Text = "Đóng"
        Me.btnDong.UseVisualStyleBackColor = True
        '
        'btnXemTruoc
        '
        Me.btnXemTruoc.Location = New System.Drawing.Point(287, 424)
        Me.btnXemTruoc.Name = "btnXemTruoc"
        Me.btnXemTruoc.Size = New System.Drawing.Size(75, 23)
        Me.btnXemTruoc.TabIndex = 52
        Me.btnXemTruoc.Text = "Xem Trước"
        Me.btnXemTruoc.UseVisualStyleBackColor = True
        '
        'btnLapBaoCaoVaXuat
        '
        Me.btnLapBaoCaoVaXuat.Location = New System.Drawing.Point(32, 424)
        Me.btnLapBaoCaoVaXuat.Name = "btnLapBaoCaoVaXuat"
        Me.btnLapBaoCaoVaXuat.Size = New System.Drawing.Size(167, 23)
        Me.btnLapBaoCaoVaXuat.TabIndex = 51
        Me.btnLapBaoCaoVaXuat.Text = "Lập báo cáo và xuất ra máy in"
        Me.btnLapBaoCaoVaXuat.UseVisualStyleBackColor = True
        '
        'btnLapBaoCao
        '
        Me.btnLapBaoCao.Location = New System.Drawing.Point(427, 81)
        Me.btnLapBaoCao.Name = "btnLapBaoCao"
        Me.btnLapBaoCao.Size = New System.Drawing.Size(75, 58)
        Me.btnLapBaoCao.TabIndex = 50
        Me.btnLapBaoCao.Text = "Lập báo cáo"
        Me.btnLapBaoCao.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(32, 169)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(505, 239)
        Me.DataGridView1.TabIndex = 49
        '
        'dtpNgayLapBaoCao
        '
        Me.dtpNgayLapBaoCao.Location = New System.Drawing.Point(135, 98)
        Me.dtpNgayLapBaoCao.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpNgayLapBaoCao.Name = "dtpNgayLapBaoCao"
        Me.dtpNgayLapBaoCao.Size = New System.Drawing.Size(151, 20)
        Me.dtpNgayLapBaoCao.TabIndex = 48
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 98)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Ngày báo cáo"
        '
        'txtMaSoBaoCao
        '
        Me.txtMaSoBaoCao.Location = New System.Drawing.Point(135, 60)
        Me.txtMaSoBaoCao.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMaSoBaoCao.Name = "txtMaSoBaoCao"
        Me.txtMaSoBaoCao.ReadOnly = True
        Me.txtMaSoBaoCao.Size = New System.Drawing.Size(151, 20)
        Me.txtMaSoBaoCao.TabIndex = 46
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(29, 63)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Mã báo cáo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(157, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 18)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "--------- Lập báo cáo ngày  ----------"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 134)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Khối lớp"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(135, 131)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(151, 21)
        Me.ComboBox1.TabIndex = 55
        '
        'frmLapBaoCaoNgayTheoLop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(562, 470)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnDong)
        Me.Controls.Add(Me.btnXemTruoc)
        Me.Controls.Add(Me.btnLapBaoCaoVaXuat)
        Me.Controls.Add(Me.btnLapBaoCao)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.dtpNgayLapBaoCao)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtMaSoBaoCao)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmLapBaoCaoNgayTheoLop"
        Me.Text = "LapBaoCaoNgayTheoLop"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDong As Button
    Friend WithEvents btnXemTruoc As Button
    Friend WithEvents btnLapBaoCaoVaXuat As Button
    Friend WithEvents btnLapBaoCao As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents dtpNgayLapBaoCao As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMaSoBaoCao As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
End Class
