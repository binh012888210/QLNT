<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmQuanLyLop
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
        Me.dgvTreEmCoLop = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvTreEmChuaCoLop = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnNhap = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbKhoi = New System.Windows.Forms.ComboBox()
        Me.cbLop = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSoTreEmCuaLop = New System.Windows.Forms.TextBox()
        Me.btnThemTreEm = New System.Windows.Forms.Button()
        CType(Me.dgvTreEmCoLop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTreEmChuaCoLop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tên lớp"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Khối lớp"
        '
        'dgvTreEmCoLop
        '
        Me.dgvTreEmCoLop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTreEmCoLop.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvTreEmCoLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTreEmCoLop.Location = New System.Drawing.Point(344, 74)
        Me.dgvTreEmCoLop.Name = "dgvTreEmCoLop"
        Me.dgvTreEmCoLop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTreEmCoLop.Size = New System.Drawing.Size(285, 338)
        Me.dgvTreEmCoLop.TabIndex = 2
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
        'dgvTreEmChuaCoLop
        '
        Me.dgvTreEmChuaCoLop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTreEmChuaCoLop.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvTreEmChuaCoLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTreEmChuaCoLop.Location = New System.Drawing.Point(26, 161)
        Me.dgvTreEmChuaCoLop.Name = "dgvTreEmChuaCoLop"
        Me.dgvTreEmChuaCoLop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTreEmChuaCoLop.Size = New System.Drawing.Size(285, 251)
        Me.dgvTreEmChuaCoLop.TabIndex = 10
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
        Me.btnNhap.Text = "Thêm vào lớp ->"
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
        'cbKhoi
        '
        Me.cbKhoi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbKhoi.FormattingEnabled = True
        Me.cbKhoi.Location = New System.Drawing.Point(117, 36)
        Me.cbKhoi.Name = "cbKhoi"
        Me.cbKhoi.Size = New System.Drawing.Size(133, 21)
        Me.cbKhoi.TabIndex = 17
        '
        'cbLop
        '
        Me.cbLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbLop.FormattingEnabled = True
        Me.cbLop.Location = New System.Drawing.Point(117, 74)
        Me.cbLop.Name = "cbLop"
        Me.cbLop.Size = New System.Drawing.Size(133, 21)
        Me.cbLop.TabIndex = 18
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
        'btnThemTreEm
        '
        Me.btnThemTreEm.Location = New System.Drawing.Point(26, 128)
        Me.btnThemTreEm.Name = "btnThemTreEm"
        Me.btnThemTreEm.Size = New System.Drawing.Size(92, 23)
        Me.btnThemTreEm.TabIndex = 29
        Me.btnThemTreEm.Text = "Thêm trẻ em"
        Me.btnThemTreEm.UseVisualStyleBackColor = True
        '
        'frmQuanLyLop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(657, 433)
        Me.Controls.Add(Me.btnThemTreEm)
        Me.Controls.Add(Me.txtSoTreEmCuaLop)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cbLop)
        Me.Controls.Add(Me.cbKhoi)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnNhap)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dgvTreEmChuaCoLop)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgvTreEmCoLop)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmQuanLyLop"
        Me.Text = "Quản lý lớp"
        CType(Me.dgvTreEmCoLop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTreEmChuaCoLop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvTreEmCoLop As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents dgvTreEmChuaCoLop As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents btnNhap As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents cbKhoi As ComboBox
    Friend WithEvents cbLop As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtSoTreEmCuaLop As TextBox
    Friend WithEvents btnThemTreEm As Button
End Class
