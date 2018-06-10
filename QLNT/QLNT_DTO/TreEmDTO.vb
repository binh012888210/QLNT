Public Class TreEmDTO
    Private strMaTreEm As String
    Private strHoTenTreEm As String
    Private dateNgaySinh As DateTime
    Private strHoTenPhuHuynh As String
    Private strTenONha As String
    Private strDiaChi As String
    Private strDienThoai As String
    Private dateNgayNhapHoc As String
    Private strGhiChu As String
    Private strTuoi As String
    Private strMaLop As String

    Public Property StrMaTreEm1 As String
        Get
            Return strMaTreEm
        End Get
        Set(value As String)
            strMaTreEm = value
        End Set
    End Property

    Public Property StrHoTenTreEm1 As String
        Get
            Return strHoTenTreEm
        End Get
        Set(value As String)
            strHoTenTreEm = value
        End Set
    End Property

    Public Property DateNgaySinh1 As Date
        Get
            Return dateNgaySinh
        End Get
        Set(value As Date)
            dateNgaySinh = value
        End Set
    End Property

    Public Property StrHoTenPhuHuynh1 As String
        Get
            Return strHoTenPhuHuynh
        End Get
        Set(value As String)
            strHoTenPhuHuynh = value
        End Set
    End Property

    Public Property StrTenONha1 As String
        Get
            Return strTenONha
        End Get
        Set(value As String)
            strTenONha = value
        End Set
    End Property

    Public Property StrDiaChi1 As String
        Get
            Return strDiaChi
        End Get
        Set(value As String)
            strDiaChi = value
        End Set
    End Property

    Public Property StrDienThoai1 As String
        Get
            Return strDienThoai
        End Get
        Set(value As String)
            strDienThoai = value
        End Set
    End Property

    Public Property StrMaLop1 As String
        Get
            Return strMaLop
        End Get
        Set(value As String)
            strMaLop = value
        End Set
    End Property

    Public Property StrGhiChu1 As String
        Get
            Return strGhiChu
        End Get
        Set(value As String)
            strGhiChu = value
        End Set
    End Property

    Public Property DateNgayNhapHoc1 As String
        Get
            Return dateNgayNhapHoc
        End Get
        Set(value As String)
            dateNgayNhapHoc = value
        End Set
    End Property

    Public Property StrTuoi1 As String
        Get
            Return strTuoi
        End Get
        Set(value As String)
            strTuoi = value
        End Set
    End Property

    Public Sub New()
    End Sub
    Public Sub New(strMaTreEm As String, strHoTenTreEm As String, dateNgaySinh As DateTime, strHoTenPhuHuynh As String, strTenONha As String, strDiaChi As String, strDienThoai As String, dateNgayNhapHoc As String, strTuoi As String, strGhiChu As String, strMaLop As String)
        Me.strMaTreEm = strMaTreEm
        Me.strHoTenTreEm = strHoTenTreEm
        Me.dateNgaySinh = dateNgaySinh
        Me.strHoTenPhuHuynh = strHoTenPhuHuynh
        Me.strTenONha = strTenONha
        Me.strDiaChi = strDiaChi
        Me.strDienThoai = strDienThoai
        Me.strMaLop = strMaLop
        Me.strGhiChu = strGhiChu
        Me.strTuoi = strTuoi
        Me.dateNgayNhapHoc = dateNgayNhapHoc
    End Sub
    Public Sub New(strMaTreEm As String, strHoTenTreEm As String, dateNgaySinh As DateTime, strHoTenPhuHuynh As String, strTenONha As String, strDiaChi As String, strDienThoai As String, strTuoi As String)
        Me.strMaTreEm = strMaTreEm
        Me.strHoTenTreEm = strHoTenTreEm
        Me.dateNgaySinh = dateNgaySinh
        Me.strHoTenPhuHuynh = strHoTenPhuHuynh
        Me.strTenONha = strTenONha
        Me.strDiaChi = strDiaChi
        Me.strDienThoai = strDienThoai
        Me.strTuoi = strTuoi
    End Sub
    Public Sub New(strMaTreEm As String, strHoTenTreEm As String, dateNgaySinh As DateTime, strHoTenPhuHuynh As String, strTenONha As String, strDiaChi As String, strDienThoai As String, strTuoi As String, strMaLop As String)
        Me.strMaTreEm = strMaTreEm
        Me.strHoTenTreEm = strHoTenTreEm
        Me.dateNgaySinh = dateNgaySinh
        Me.strHoTenPhuHuynh = strHoTenPhuHuynh
        Me.strTenONha = strTenONha
        Me.strDiaChi = strDiaChi
        Me.strDienThoai = strDienThoai
        Me.strTuoi = strTuoi
        Me.strMaLop = strMaLop
    End Sub
    Public Sub New(strMaTreEm As String, strHoTenTreEm As String, strTuoi As String, strGhiChu As String)
        Me.strMaTreEm = strMaTreEm
        Me.strHoTenTreEm = strHoTenTreEm
        Me.strTuoi = strTuoi
        Me.strGhiChu = strGhiChu
    End Sub
End Class
