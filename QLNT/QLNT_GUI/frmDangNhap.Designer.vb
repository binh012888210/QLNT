<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDangNhap
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
        Me.txtTenDangNhap = New System.Windows.Forms.TextBox()
        Me.txtMatKhau = New System.Windows.Forms.TextBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tên đăng nhập"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mật khẩu"
        '
        'txtTenDangNhap
        '
        Me.txtTenDangNhap.Location = New System.Drawing.Point(122, 32)
        Me.txtTenDangNhap.Name = "txtTenDangNhap"
        Me.txtTenDangNhap.Size = New System.Drawing.Size(119, 20)
        Me.txtTenDangNhap.TabIndex = 2
        '
        'txtMatKhau
        '
        Me.txtMatKhau.Location = New System.Drawing.Point(122, 72)
        Me.txtMatKhau.Name = "txtMatKhau"
        Me.txtMatKhau.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtMatKhau.Size = New System.Drawing.Size(119, 20)
        Me.txtMatKhau.TabIndex = 3
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(108, 124)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 4
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'frmDangNhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 174)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.txtMatKhau)
        Me.Controls.Add(Me.txtTenDangNhap)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDangNhap"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Đăng nhập "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTenDangNhap As TextBox
    Friend WithEvents txtMatKhau As TextBox
    Friend WithEvents btnOK As Button
End Class
