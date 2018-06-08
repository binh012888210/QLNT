<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmXepLop
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnNhap = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSoTreEmChuaCoLop = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSoTreEmCuaLop = New System.Windows.Forms.TextBox()
        Me.btnKhoiTrc = New System.Windows.Forms.Button()
        Me.btnLopTruoc = New System.Windows.Forms.Button()
        Me.btnKhoiSau = New System.Windows.Forms.Button()
        Me.btnLopSau = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnPreview = New System.Windows.Forms.Button()
        Me.btnDong = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tên lớp"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Khối lớp"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(344, 74)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(285, 299)
        Me.DataGridView1.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(372, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(240, 18)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "----- Danh sách trẻ em theo lớp -----"
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(26, 161)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(285, 251)
        Me.DataGridView2.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(36, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(264, 18)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "----- Danh sách trẻ em chưa có lớp -----"
        '
        'btnNhap
        '
        Me.btnNhap.Location = New System.Drawing.Point(219, 128)
        Me.btnNhap.Name = "btnNhap"
        Me.btnNhap.Size = New System.Drawing.Size(92, 23)
        Me.btnNhap.TabIndex = 12
        Me.btnNhap.Text = "Thêm vào lớp"
        Me.btnNhap.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(537, 41)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(92, 23)
        Me.btnXoa.TabIndex = 13
        Me.btnXoa.Text = "Xoá khỏi lớp"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 134)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Số trẻ em"
        '
        'txtSoTreEmChuaCoLop
        '
        Me.txtSoTreEmChuaCoLop.Location = New System.Drawing.Point(81, 131)
        Me.txtSoTreEmChuaCoLop.Name = "txtSoTreEmChuaCoLop"
        Me.txtSoTreEmChuaCoLop.ReadOnly = True
        Me.txtSoTreEmChuaCoLop.Size = New System.Drawing.Size(28, 20)
        Me.txtSoTreEmChuaCoLop.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(56, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(201, 18)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "---------- Thông tin lớp ----------"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(97, 36)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 17
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(97, 74)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(341, 46)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Số trẻ em"
        '
        'txtSoTreEmCuaLop
        '
        Me.txtSoTreEmCuaLop.Location = New System.Drawing.Point(399, 43)
        Me.txtSoTreEmCuaLop.Name = "txtSoTreEmCuaLop"
        Me.txtSoTreEmCuaLop.ReadOnly = True
        Me.txtSoTreEmCuaLop.Size = New System.Drawing.Size(28, 20)
        Me.txtSoTreEmCuaLop.TabIndex = 20
        '
        'btnKhoiTrc
        '
        Me.btnKhoiTrc.Location = New System.Drawing.Point(233, 36)
        Me.btnKhoiTrc.Name = "btnKhoiTrc"
        Me.btnKhoiTrc.Size = New System.Drawing.Size(24, 23)
        Me.btnKhoiTrc.TabIndex = 21
        Me.btnKhoiTrc.Text = "<"
        Me.btnKhoiTrc.UseVisualStyleBackColor = True
        '
        'btnLopTruoc
        '
        Me.btnLopTruoc.Location = New System.Drawing.Point(233, 74)
        Me.btnLopTruoc.Name = "btnLopTruoc"
        Me.btnLopTruoc.Size = New System.Drawing.Size(24, 23)
        Me.btnLopTruoc.TabIndex = 22
        Me.btnLopTruoc.Text = "<"
        Me.btnLopTruoc.UseVisualStyleBackColor = True
        '
        'btnKhoiSau
        '
        Me.btnKhoiSau.Location = New System.Drawing.Point(263, 36)
        Me.btnKhoiSau.Name = "btnKhoiSau"
        Me.btnKhoiSau.Size = New System.Drawing.Size(24, 23)
        Me.btnKhoiSau.TabIndex = 23
        Me.btnKhoiSau.Text = ">"
        Me.btnKhoiSau.UseVisualStyleBackColor = True
        '
        'btnLopSau
        '
        Me.btnLopSau.Location = New System.Drawing.Point(263, 74)
        Me.btnLopSau.Name = "btnLopSau"
        Me.btnLopSau.Size = New System.Drawing.Size(24, 23)
        Me.btnLopSau.TabIndex = 24
        Me.btnLopSau.Text = ">"
        Me.btnLopSau.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(344, 389)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(83, 23)
        Me.btnPrint.TabIndex = 25
        Me.btnPrint.Text = "Xuất ra máy in"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnPreview
        '
        Me.btnPreview.Location = New System.Drawing.Point(446, 389)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(86, 23)
        Me.btnPreview.TabIndex = 26
        Me.btnPreview.Text = "Xem trước "
        Me.btnPreview.UseVisualStyleBackColor = True
        '
        'btnDong
        '
        Me.btnDong.Location = New System.Drawing.Point(554, 389)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(75, 23)
        Me.btnDong.TabIndex = 27
        Me.btnDong.Text = "Đóng"
        Me.btnDong.UseVisualStyleBackColor = True
        '
        'frmXepLop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(657, 433)
        Me.Controls.Add(Me.btnDong)
        Me.Controls.Add(Me.btnPreview)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnLopSau)
        Me.Controls.Add(Me.btnKhoiSau)
        Me.Controls.Add(Me.btnLopTruoc)
        Me.Controls.Add(Me.btnKhoiTrc)
        Me.Controls.Add(Me.txtSoTreEmCuaLop)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtSoTreEmChuaCoLop)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnNhap)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmXepLop"
        Me.Text = "frmXepLop"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents btnNhap As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSoTreEmChuaCoLop As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtSoTreEmCuaLop As TextBox
    Friend WithEvents btnKhoiTrc As Button
    Friend WithEvents btnLopTruoc As Button
    Friend WithEvents btnKhoiSau As Button
    Friend WithEvents btnLopSau As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnPreview As Button
    Friend WithEvents btnDong As Button
End Class
