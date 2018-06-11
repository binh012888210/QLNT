<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCapNhatGhiNhan
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
        Me.btnDong = New System.Windows.Forms.Button()
        Me.btnCapNhat = New System.Windows.Forms.Button()
        Me.dtpNgayGhiNhan = New System.Windows.Forms.DateTimePicker()
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
        Me.SuspendLayout()
        '
        'btnDong
        '
        Me.btnDong.Location = New System.Drawing.Point(206, 267)
        Me.btnDong.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(56, 19)
        Me.btnDong.TabIndex = 85
        Me.btnDong.Text = "Đóng"
        Me.btnDong.UseVisualStyleBackColor = True
        '
        'btnCapNhat
        '
        Me.btnCapNhat.Location = New System.Drawing.Point(57, 267)
        Me.btnCapNhat.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(64, 19)
        Me.btnCapNhat.TabIndex = 83
        Me.btnCapNhat.Text = "Cập nhật"
        Me.btnCapNhat.UseVisualStyleBackColor = True
        '
        'dtpNgayGhiNhan
        '
        Me.dtpNgayGhiNhan.Location = New System.Drawing.Point(105, 171)
        Me.dtpNgayGhiNhan.Name = "dtpNgayGhiNhan"
        Me.dtpNgayGhiNhan.Size = New System.Drawing.Size(200, 20)
        Me.dtpNgayGhiNhan.TabIndex = 82
        '
        'txtTenKhoi
        '
        Me.txtTenKhoi.Location = New System.Drawing.Point(104, 136)
        Me.txtTenKhoi.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTenKhoi.Name = "txtTenKhoi"
        Me.txtTenKhoi.ReadOnly = True
        Me.txtTenKhoi.Size = New System.Drawing.Size(201, 20)
        Me.txtTenKhoi.TabIndex = 81
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(19, 139)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 13)
        Me.Label10.TabIndex = 80
        Me.Label10.Text = "Tên khối"
        '
        'cbTinhTrang
        '
        Me.cbTinhTrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTinhTrang.FormattingEnabled = True
        Me.cbTinhTrang.Location = New System.Drawing.Point(104, 217)
        Me.cbTinhTrang.Name = "cbTinhTrang"
        Me.cbTinhTrang.Size = New System.Drawing.Size(200, 21)
        Me.cbTinhTrang.TabIndex = 79
        '
        'txtHoTenTre
        '
        Me.txtHoTenTre.Location = New System.Drawing.Point(104, 98)
        Me.txtHoTenTre.Margin = New System.Windows.Forms.Padding(2)
        Me.txtHoTenTre.Name = "txtHoTenTre"
        Me.txtHoTenTre.ReadOnly = True
        Me.txtHoTenTre.Size = New System.Drawing.Size(201, 20)
        Me.txtHoTenTre.TabIndex = 78
        '
        'txtMaGhiNhan
        '
        Me.txtMaGhiNhan.Location = New System.Drawing.Point(105, 20)
        Me.txtMaGhiNhan.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMaGhiNhan.Name = "txtMaGhiNhan"
        Me.txtMaGhiNhan.ReadOnly = True
        Me.txtMaGhiNhan.Size = New System.Drawing.Size(200, 20)
        Me.txtMaGhiNhan.TabIndex = 77
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 23)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 76
        Me.Label5.Text = "Mã ghi nhận"
        '
        'txtMaSoTreEm
        '
        Me.txtMaSoTreEm.Location = New System.Drawing.Point(105, 60)
        Me.txtMaSoTreEm.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMaSoTreEm.Name = "txtMaSoTreEm"
        Me.txtMaSoTreEm.ReadOnly = True
        Me.txtMaSoTreEm.Size = New System.Drawing.Size(199, 20)
        Me.txtMaSoTreEm.TabIndex = 75
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 220)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 74
        Me.Label4.Text = "Tình trạng"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 177)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 73
        Me.Label3.Text = "Ngày ghi nhận"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 101)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 72
        Me.Label2.Text = "Họ tên trẻ"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 63)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "Mã trẻ em"
        '
        'frmCapNhatGhiNhan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(331, 318)
        Me.Controls.Add(Me.btnDong)
        Me.Controls.Add(Me.btnCapNhat)
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
        Me.Name = "frmCapNhatGhiNhan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cập nhật ghi nhận"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDong As Button
    Friend WithEvents btnCapNhat As Button
    Friend WithEvents dtpNgayGhiNhan As DateTimePicker
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
End Class
