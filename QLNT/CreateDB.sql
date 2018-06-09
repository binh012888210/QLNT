
USE [master]
GO

WHILE EXISTS(select NULL from sys.databases where name='QLNT')
BEGIN
    DECLARE @SQL varchar(max)
    SELECT @SQL = COALESCE(@SQL,'') + 'Kill ' + Convert(varchar, SPId) + ';'
    FROM MASTER..SysProcesses
    WHERE DBId = DB_ID(N'QLNT') AND SPId <> @@SPId
    EXEC(@SQL)
    DROP DATABASE [QLNT]
END
GO


CREATE DATABASE [QLNT]
GO

USE [QLNT]
GO

CREATE TABLE [dbo].[tblTreEm](
	[MaTreEm] [nvarchar](20) NOT NULL,
	[HoTenTreEm] [nvarchar](50) NOT NULL,
	[NgaySinh] [smalldatetime] NOT NULL,
	[HoTenPhuHuynh] [nvarchar](50) NOT NULL,
	[TenONha] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](50) NOT NULL,
	[DienThoai] [nvarchar](20) NOT NULL,
	[Tuoi] [int] NULL,
	[MaLop] [nvarchar](20) NULL,
	[NgayNhapHoc] [smalldatetime] NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblTreEm] PRIMARY KEY CLUSTERED 
(
	[MaTreEm] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

USE [QLNT]
GO


CREATE TABLE [dbo].[tblLop](
	[MaLop] [nvarchar](20) NOT NULL,
	[TenLop] [nvarchar](20) NOT NULL,
	[MaKhoi] [nvarchar](20) NOT NULL,
	[ThuTuLop] [int] NOT NULL,
 CONSTRAINT [PK_tblLop] PRIMARY KEY CLUSTERED 
(
	[MaLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

USE [QLNT]
GO


CREATE TABLE [dbo].[tblKhoi](
	[MaKhoi] [nvarchar](20) NOT NULL,
	[TenKhoi] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_tblKhoi] PRIMARY KEY CLUSTERED 
(
	[MaKhoi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


USE [QLNT]
GO

CREATE TABLE [dbo].[tblTinhTrang](
	[MaTinhTrang] [nvarchar](20) NOT NULL,
	[TenTinhTrang] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_tblTinhTrang] PRIMARY KEY CLUSTERED 
(
	[MaTinhTrang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

USE [QLNT]
GO


CREATE TABLE [dbo].[tblGhiNhanTinhTrang](
	[MaPhieuGhiNhan] [nvarchar](20) NOT NULL,
	[MaTreEm] [nvarchar](20) NOT NULL,
	[MaTinhTrang] [nvarchar](20) NOT NULL,
	[NgayGhiNhan] [smalldatetime] NOT NULL,
	[MaKhoi] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_tblGhiNhanTinhTrang] PRIMARY KEY CLUSTERED 
(
	[MaPhieuGhiNhan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

USE [QLNT]
GO


CREATE TABLE [dbo].[tblBaoCao](
	[MaBaoCao] [nvarchar](20) NOT NULL,
	[NgayBaoCao] [smalldatetime] NOT NULL,
	[MaKhoi] [nvarchar](20) NULL,
 CONSTRAINT [PK_tblBaoCao] PRIMARY KEY CLUSTERED 
(
	[MaBaoCao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

USE [QLNT]
GO


USE [QLNT]
GO


CREATE TABLE [dbo].[tblChiTietBaoCao](
	[MaChiTietBaoCao] [nvarchar](20) NOT NULL,
	[MaPhieuGhiNhan] [nvarchar](20) NOT NULL,
	[MaBaoCao] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_tblChiTietBaoCao] PRIMARY KEY CLUSTERED 
(
	[MaChiTietBaoCao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


USE [QLNT]
GO

CREATE TABLE [dbo].[tblThamSo](
	[TuoiToiTieu] [int] NOT NULL,
	[TuoiToiDa] [int] NOT NULL,
	[SoHocSinhToiDa] [int] NOT NULL
) ON [PRIMARY]
GO


USE [QLNT]
GO

INSERT INTO[dbo].[tblThamSo]([TuoiToiTieu],[TuoiToiDa],[SoHocSinhToiDa]) VALUES(3,5,20)
GO


USE [QLNT]
GO
ALTER TABLE dbo.tblLop ADD FOREIGN KEY(MaKhoi) REFERENCES dbo.tblKhoi(MaKhoi)

GO

USE [QLNT]
GO
ALTER TABLE dbo.tblTreEm ADD FOREIGN KEY(MaLop) REFERENCES dbo.tblLop(MaLop)

GO

USE [QLNT]
GO
ALTER TABLE dbo.tblGhiNhanTinhTrang ADD FOREIGN KEY(MaTreEm) REFERENCES dbo.tblTreEm(MaTreEm)

GO

USE [QLNT]
GO
ALTER TABLE dbo.tblGhiNhanTinhTrang ADD FOREIGN KEY(MaTinhTrang) REFERENCES dbo.tblTinhTrang(MaTinhTrang)

GO

USE [QLNT]
GO
ALTER TABLE dbo.tblGhiNhanTinhTrang ADD FOREIGN KEY(MaKhoi) REFERENCES dbo.tblKhoi(MaKhoi)

GO

USE [QLNT]
GO
ALTER TABLE dbo.tblChiTietBaoCao ADD FOREIGN KEY(MaPhieuGhiNhan) REFERENCES dbo.tblGhiNhanTinhTrang(MaPhieuGhiNhan)

GO

USE [QLNT]
GO
ALTER TABLE dbo.tblChiTietBaoCao ADD FOREIGN KEY(MaBaoCao) REFERENCES dbo.tblBaoCao(MaBaoCao)

GO

USE [QLNT]
GO

INSERT INTO[dbo].[tblKhoi]([MaKhoi],[TenKhoi]) VALUES('1',N'Mầm')
GO
INSERT INTO[dbo].[tblKhoi]([MaKhoi],[TenKhoi]) VALUES('2',N'Chồi')
GO
INSERT INTO[dbo].[tblKhoi]([MaKhoi],[TenKhoi]) VALUES('3',N'Lá')
GO

USE [QLNT]
GO

INSERT INTO[dbo].[tblLop]([MaLop],[TenLop],[MaKhoi],[ThuTuLop]) VALUES('1A',N'Mầm 1','1',1)
GO
INSERT INTO[dbo].[tblLop]([MaLop],[TenLop],[MaKhoi],[ThuTuLop]) VALUES('1B',N'Mầm 2','1',2)
GO
INSERT INTO[dbo].[tblLop]([MaLop],[TenLop],[MaKhoi],[ThuTuLop]) VALUES('1C',N'Mầm 3','1',3)
GO
INSERT INTO[dbo].[tblLop]([MaLop],[TenLop],[MaKhoi],[ThuTuLop]) VALUES('1D',N'Mầm 4','1',4)
GO
INSERT INTO[dbo].[tblLop]([MaLop],[TenLop],[MaKhoi],[ThuTuLop]) VALUES('2A',N'Chồi 1','2',5)
GO
INSERT INTO[dbo].[tblLop]([MaLop],[TenLop],[MaKhoi],[ThuTuLop]) VALUES('2B',N'Chồi 2','2',6)
GO
INSERT INTO[dbo].[tblLop]([MaLop],[TenLop],[MaKhoi],[ThuTuLop]) VALUES('2C',N'Chồi 3','2',7)
GO
INSERT INTO[dbo].[tblLop]([MaLop],[TenLop],[MaKhoi],[ThuTuLop]) VALUES('2D',N'Chồi 4','2',8)
GO
INSERT INTO[dbo].[tblLop]([MaLop],[TenLop],[MaKhoi],[ThuTuLop]) VALUES('3A',N'Lá 1','3',9)
GO
INSERT INTO[dbo].[tblLop]([MaLop],[TenLop],[MaKhoi],[ThuTuLop]) VALUES('3B',N'Lá 2','3',10)
GO
INSERT INTO[dbo].[tblLop]([MaLop],[TenLop],[MaKhoi],[ThuTuLop]) VALUES('3C',N'Lá 3','3',11)
GO
INSERT INTO[dbo].[tblLop]([MaLop],[TenLop],[MaKhoi],[ThuTuLop]) VALUES('3D',N'Lá 4','3',12)
GO

USE [QLNT]
GO

INSERT INTO[dbo].[tblTreEm]([MaTreEm],[HoTenTreEm],[NgaySinh],[HoTenPhuHuynh],[TenONha],[DiaChi],[DienThoai],[Tuoi],[MaLop],[NgayNhapHoc],[GhiChu]) 
VALUES ('180000',N'Le Cung',convert(datetime,'30/12/2014 00:00:00',103),N'Le Kim',N'Bu',N'22 Nguyen Van Cu',N'012233',4,'1D',convert(datetime,'3/2/2018 00:00:00',103),N'Hoc Ngu')
GO
INSERT INTO[dbo].[tblTreEm]([MaTreEm],[HoTenTreEm],[NgaySinh],[HoTenPhuHuynh],[TenONha],[DiaChi],[DienThoai],[Tuoi],[MaLop],[NgayNhapHoc],[GhiChu]) 
VALUES ('180001',N'Linh Dam',convert(datetime,'26/04/2015 00:00:00',103),N'Linh Nguyen',N'Bin',N'14 Tran Phu',N'999887',3,'2C',convert(datetime,'23/1/2018 00:00:00',103),N'Khon Loi')
GO
INSERT INTO[dbo].[tblTreEm]([MaTreEm],[HoTenTreEm],[NgaySinh],[HoTenPhuHuynh],[TenONha],[DiaChi],[DienThoai],[Tuoi],[MaLop],[NgayNhapHoc],[GhiChu]) 
VALUES ('180002',N'Minh Beo',convert(datetime,'5/9/2013 00:00:00',103),N'Minh Nhi',N'Chu Bin',N'6 Ton Duc Thang',N'292929',5,'3A',convert(datetime,'17/3/2018 00:00:00',103),N'Binh Thuong')
GO
INSERT INTO[dbo].[tblTreEm]([MaTreEm],[HoTenTreEm],[NgaySinh],[HoTenPhuHuynh],[TenONha],[DiaChi],[DienThoai],[Tuoi]) 
VALUES ('180003',N'Do Nan Tram',convert(datetime,'20/11/2014 00:00:00',103),N'Luc Thien Binh',N'Obama',N'18 Thanh Thai',N'363636',4)
GO
INSERT INTO[dbo].[tblTreEm]([MaTreEm],[HoTenTreEm],[NgaySinh],[HoTenPhuHuynh],[TenONha],[DiaChi],[DienThoai],[Tuoi]) 
VALUES ('180004',N'Tran Thanh',convert(datetime,'15/06/2013 00:00:00',103),N'truong Giang',N'Chon Xi Na',N'9 Co Giang',N'55539',5)
GO
INSERT INTO[dbo].[tblTreEm]([MaTreEm],[HoTenTreEm],[NgaySinh],[HoTenPhuHuynh],[TenONha],[DiaChi],[DienThoai],[Tuoi]) 
VALUES ('180005',N'Hoai Linh',convert(datetime,'1/1/2015 00:00:00',103),N'Hoai Linh',N'Son Tung MP3',N'1 Tran Hung dao',N'363636',3)
GO