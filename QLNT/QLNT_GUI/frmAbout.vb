Public Class frmAbout
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Close()
    End Sub

    Private Sub frmAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtGioiThieu.Text = "      Tên phần mềm " + Environment.NewLine
        txtGioiThieu.Text += "              Phần mềm quản lý nhà trẻ " + Environment.NewLine
        txtGioiThieu.Text += "      Người thực hiện " + Environment.NewLine
        txtGioiThieu.Text += "              16520092 - Lục Thiên Bình - PMCL2016.1 " + Environment.NewLine
        txtGioiThieu.Text += "              16520422 - Bùi Gia Hoà - PMCL2016.1" + Environment.NewLine
        txtGioiThieu.Text += "      Bản quyền phần mềm " + Environment.NewLine
        txtGioiThieu.Text += "              Thuộc về Trường Đại Học CNTT-DHQG" + Environment.NewLine
        txtGioiThieu.Text += "              Vui lòng tôn trọng bản quyền " + Environment.NewLine
        txtGioiThieu.Text += "              Copyright © 2018 UIT" + Environment.NewLine
    End Sub
End Class