<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fromLapBaoCaoNgay
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMaBaoCao = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpNgayLapBaoCao = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnLapBaoCao = New System.Windows.Forms.Button()
        Me.btnLapBaoCaoVaXuat = New System.Windows.Forms.Button()
        Me.btnXemTruoc = New System.Windows.Forms.Button()
        Me.btnDong = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(154, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "--------- Lập báo cáo ngày  ----------"
        '
        'txtMaBaoCao
        '
        Me.txtMaBaoCao.Location = New System.Drawing.Point(132, 51)
        Me.txtMaBaoCao.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMaBaoCao.Name = "txtMaBaoCao"
        Me.txtMaBaoCao.ReadOnly = True
        Me.txtMaBaoCao.Size = New System.Drawing.Size(151, 20)
        Me.txtMaBaoCao.TabIndex = 36
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 54)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Mã báo cáo"
        '
        'dtpNgayLapBaoCao
        '
        Me.dtpNgayLapBaoCao.Location = New System.Drawing.Point(132, 89)
        Me.dtpNgayLapBaoCao.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpNgayLapBaoCao.Name = "dtpNgayLapBaoCao"
        Me.dtpNgayLapBaoCao.Size = New System.Drawing.Size(151, 20)
        Me.dtpNgayLapBaoCao.TabIndex = 38
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 89)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Ngày báo cáo"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(29, 132)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(505, 239)
        Me.DataGridView1.TabIndex = 39
        '
        'btnLapBaoCao
        '
        Me.btnLapBaoCao.Location = New System.Drawing.Point(426, 51)
        Me.btnLapBaoCao.Name = "btnLapBaoCao"
        Me.btnLapBaoCao.Size = New System.Drawing.Size(75, 58)
        Me.btnLapBaoCao.TabIndex = 40
        Me.btnLapBaoCao.Text = "Lập báo cáo"
        Me.btnLapBaoCao.UseVisualStyleBackColor = True
        '
        'btnLapBaoCaoVaXuat
        '
        Me.btnLapBaoCaoVaXuat.Location = New System.Drawing.Point(29, 387)
        Me.btnLapBaoCaoVaXuat.Name = "btnLapBaoCaoVaXuat"
        Me.btnLapBaoCaoVaXuat.Size = New System.Drawing.Size(167, 23)
        Me.btnLapBaoCaoVaXuat.TabIndex = 41
        Me.btnLapBaoCaoVaXuat.Text = "Lập báo cáo và xuất ra máy in"
        Me.btnLapBaoCaoVaXuat.UseVisualStyleBackColor = True
        '
        'btnXemTruoc
        '
        Me.btnXemTruoc.Location = New System.Drawing.Point(284, 387)
        Me.btnXemTruoc.Name = "btnXemTruoc"
        Me.btnXemTruoc.Size = New System.Drawing.Size(75, 23)
        Me.btnXemTruoc.TabIndex = 42
        Me.btnXemTruoc.Text = "Xem Trước"
        Me.btnXemTruoc.UseVisualStyleBackColor = True
        '
        'btnDong
        '
        Me.btnDong.Location = New System.Drawing.Point(459, 387)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(75, 23)
        Me.btnDong.TabIndex = 43
        Me.btnDong.Text = "Đóng"
        Me.btnDong.UseVisualStyleBackColor = True
        '
        'fromLapBaoCaoNgay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(563, 438)
        Me.Controls.Add(Me.btnDong)
        Me.Controls.Add(Me.btnXemTruoc)
        Me.Controls.Add(Me.btnLapBaoCaoVaXuat)
        Me.Controls.Add(Me.btnLapBaoCao)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.dtpNgayLapBaoCao)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtMaBaoCao)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Name = "fromLapBaoCaoNgay"
        Me.Text = "fromLapBaoCaoNgay"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtMaBaoCao As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents dtpNgayLapBaoCao As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnLapBaoCao As Button
    Friend WithEvents btnLapBaoCaoVaXuat As Button
    Friend WithEvents btnXemTruoc As Button
    Friend WithEvents btnDong As Button
End Class
