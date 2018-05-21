Imports System.Configuration
Public Class frmMain
    Private ConnectionString As String
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Read ConnectionString value from App.config file
        ConnectionString = ConfigurationManager.AppSettings("ConnectionString")


    End Sub

    Private Sub ThêmTrẻEmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThêmTrẻEmToolStripMenuItem.Click
        Dim frm As frmThemTreEm = New frmThemTreEm()
        frm.MdiParent = Me
        frm.Show()
    End Sub

End Class
