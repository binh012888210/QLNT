Public Class DangNhapDTO
    Private strUserID As String
    Private strUserPassword As String
    Public Sub New()
    End Sub
    Public Sub New(strUserID As String, strUserPassword As String)
        Me.strUserID = strUserID
        Me.strUserPassword = strUserPassword
    End Sub

    Public Property StrUserID1 As String
        Get
            Return strUserID
        End Get
        Set(value As String)
            strUserID = value
        End Set
    End Property

    Public Property StrUserPassword1 As String
        Get
            Return strUserPassword
        End Get
        Set(value As String)
            strUserPassword = value
        End Set
    End Property
End Class
