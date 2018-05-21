Public Class ThamSoDTO
    Private intTuoiToiTieu As String
    Private intTuoiToiDa As String
    Private intSoHocSinhToiDa As String

    Public Property IntTuoiToiTieu1 As String
        Get
            Return intTuoiToiTieu
        End Get
        Set(value As String)
            intTuoiToiTieu = value
        End Set
    End Property

    Public Property IntTuoiToiDa1 As String
        Get
            Return intTuoiToiDa
        End Get
        Set(value As String)
            intTuoiToiDa = value
        End Set
    End Property

    Public Property IntSoHocSinhToiDa1 As String
        Get
            Return intSoHocSinhToiDa
        End Get
        Set(value As String)
            intSoHocSinhToiDa = value
        End Set
    End Property

    Public Sub New()
    End Sub
    Public Sub New(intTuoiToiTieu As String, intTuoiToiDa As String, intSoHocSinhToiDa As String)
        Me.intTuoiToiTieu = intTuoiToiTieu
        Me.intTuoiToiDa = intTuoiToiDa
        Me.intSoHocSinhToiDa = intSoHocSinhToiDa
    End Sub
End Class
