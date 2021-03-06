
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

CREATE TABLE [dbo].[tblAccount](
	[userID] [nvarchar](20) NOT NULL,
	[userPassword] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_tblAccount] PRIMARY KEY CLUSTERED 
(
	[userID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

USE [QLNT]
GO

CREATE TABLE [dbo].[tblTreEm](
	[MaTreEm] [nvarchar](20) NOT NULL,
	[HoTenTreEm] [nvarchar](50) NULL,
	[NgaySinh] [smalldatetime] NULL,
	[HoTenPhuHuynh] [nvarchar](50) NULL,
	[TenONha] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[DienThoai] [nvarchar](20) NULL,
	[Tuoi] [nvarchar](20) NULL,
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

CREATE TABLE [dbo].[tblTreEmTemporary](
	[MaTreEm] [nvarchar](20) NOT NULL,
	[HoTenTreEm] [nvarchar](50) NULL,
	[NgaySinh] [smalldatetime] NULL,
	[HoTenPhuHuynh] [nvarchar](50) NULL,
	[TenONha] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[DienThoai] [nvarchar](20) NULL,
	[Tuoi] [nvarchar](20) NULL,
	[MaLop] [nvarchar](20) NULL,
	[NgayNhapHoc] [smalldatetime] NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblTreEmTemporary] PRIMARY KEY CLUSTERED 
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
ALTER TABLE dbo.tblChiTietBaoCao ADD FOREIGN KEY(MaPhieuGhiNhan) REFERENCES dbo.tblGhiNhanTinhTrang(MaPhieuGhiNhan)

GO

USE [QLNT]
GO
ALTER TABLE dbo.tblChiTietBaoCao ADD FOREIGN KEY(MaBaoCao) REFERENCES dbo.tblBaoCao(MaBaoCao)

GO

USE [QLNT]
GO

INSERT INTO[dbo].[tblAccount]([userID],[userPassword]) VALUES(N'admin',N'admin')
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

INSERT INTO[dbo].[tblTinhTrang]([MaTinhTrang],[TenTinhTrang]) VALUES ('1',N'Ngoan')
GO
INSERT INTO[dbo].[tblTinhTrang]([MaTinhTrang],[TenTinhTrang]) VALUES ('2',N'Bieng an')
GO
INSERT INTO[dbo].[tblTinhTrang]([MaTinhTrang],[TenTinhTrang]) VALUES ('3',N'Bi benh')
GO
USE [QLNT]
GO

INSERT INTO[dbo].[tblTreEm]([MaTreEm],[HoTenTreEm],[NgaySinh],[HoTenPhuHuynh],[TenONha],[DiaChi],[DienThoai],[Tuoi],[MaLop],[NgayNhapHoc],[GhiChu]) 
VALUES ('180000',N'Le Cung',convert(datetime,'12/30/2014 00:00:00',101),N'Le Kim',N'Bu',N'22 Nguyen Van Cu',N'012233',N'4','1A',convert(datetime,'03/02/2018 00:00:00',101),N'Hoc Ngu')
GO
INSERT INTO[dbo].[tblTreEm]([MaTreEm],[HoTenTreEm],[NgaySinh],[HoTenPhuHuynh],[TenONha],[DiaChi],[DienThoai],[Tuoi],[MaLop],[NgayNhapHoc],[GhiChu]) 
VALUES ('180001',N'Kim Siu Quan',convert(datetime,'04/26/2015 00:00:00',101),N'Linh Nguyen',N'Bin',N'14 Tran Phu',N'999887',N'3','1B',convert(datetime,'3/21/2018 00:00:00',101),N'Khon Loi')
GO
INSERT INTO[dbo].[tblTreEm]([MaTreEm],[HoTenTreEm],[NgaySinh],[HoTenPhuHuynh],[TenONha],[DiaChi],[DienThoai],[Tuoi],[MaLop],[NgayNhapHoc],[GhiChu]) 
VALUES ('180002',N'Minh Beo',convert(datetime,'09/05/2013 00:00:00',101),N'Minh Nhi',N'Chu Bin',N'6 Ton Duc Thang',N'292929',N'5','1C',convert(datetime,'07/13/2018 00:00:00',101),N'Binh Thuong')
GO
INSERT INTO[dbo].[tblTreEm]([MaTreEm],[HoTenTreEm],[NgaySinh],[HoTenPhuHuynh],[TenONha],[DiaChi],[DienThoai],[Tuoi]) 
VALUES ('180003',N'Do Nan Tram',convert(datetime,'11/20/2014 00:00:00',101),N'Luc Thien Binh',N'Obama',N'18 Thanh Thai',N'363636',N'4')
GO
INSERT INTO[dbo].[tblTreEm]([MaTreEm],[HoTenTreEm],[NgaySinh],[HoTenPhuHuynh],[TenONha],[DiaChi],[DienThoai],[Tuoi]) 
VALUES ('180004',N'Tran Thanh',convert(datetime,'06/15/2013 00:00:00',101),N'Truong Giang',N'Chon Xi Na',N'9 Co Giang',N'55539',N'5')
GO
INSERT INTO[dbo].[tblTreEm]([MaTreEm],[HoTenTreEm],[NgaySinh],[HoTenPhuHuynh],[TenONha],[DiaChi],[DienThoai],[Tuoi]) 
VALUES ('180005',N'Hoai Linh',convert(datetime,'1/1/2015 00:00:00',101),N'Hoai Linh',N'Son Tung MP3',N'1 Tran Hung dao',N'363636',N'3')
GO
INSERT INTO[dbo].[tblTreEm]([MaTreEm],[HoTenTreEm],[NgaySinh],[HoTenPhuHuynh],[TenONha],[DiaChi],[DienThoai],[Tuoi],[MaLop],[NgayNhapHoc],[GhiChu]) 
VALUES ('180006',N'Tap Can Binh',convert(datetime,'11/03/2013 00:00:00',101),N'Thien Binh',N'Kid',N'10 Ung Van Khiem',N'08685',N'5','2A',convert(datetime,'02/22/2018 00:00:00',101),N'Ban ve so')
GO
INSERT INTO[dbo].[tblTreEm]([MaTreEm],[HoTenTreEm],[NgaySinh],[HoTenPhuHuynh],[TenONha],[DiaChi],[DienThoai],[Tuoi],[MaLop],[NgayNhapHoc],[GhiChu]) 
VALUES ('180007',N'Chau Nam Phong',convert(datetime,'01/23/2015 00:00:00',101),N'Kim Binh Mai',N'Di',N'99 Tran Duy Hung',N'020108',N'3','2B',convert(datetime,'05/06/2018 00:00:00',101),N'Lam DJ')
GO
INSERT INTO[dbo].[tblTreEm]([MaTreEm],[HoTenTreEm],[NgaySinh],[HoTenPhuHuynh],[TenONha],[DiaChi],[DienThoai],[Tuoi]) 
VALUES ('180008',N'Phan Thanh Hang',convert(datetime,'09/01/2013 00:00:00',101),N'Tuan Nguyen',N'Cave',N'10 Duy Hung',N'113',N'5')
GO
INSERT INTO[dbo].[tblTreEm]([MaTreEm],[HoTenTreEm],[NgaySinh],[HoTenPhuHuynh],[TenONha],[DiaChi],[DienThoai],[Tuoi],[MaLop],[NgayNhapHoc],[GhiChu]) 
VALUES ('180009',N'Le Cung',convert(datetime,'12/30/2014 00:00:00',101),N'Le Kim',N'Bu',N'22 Nguyen Van Cu',N'012233',N'4','2C',convert(datetime,'03/02/2018 00:00:00',101),N'Hoc Ngu')
GO
INSERT INTO[dbo].[tblTreEm]([MaTreEm],[HoTenTreEm],[NgaySinh],[HoTenPhuHuynh],[TenONha],[DiaChi],[DienThoai],[Tuoi],[MaLop],[NgayNhapHoc],[GhiChu]) 
VALUES ('180010',N'Kim Siu Quan',convert(datetime,'04/26/2015 00:00:00',101),N'Linh Nguyen',N'Bin',N'14 Tran Phu',N'999887',N'3','3A',convert(datetime,'3/21/2018 00:00:00',101),N'Khon Loi')
GO
INSERT INTO[dbo].[tblTreEm]([MaTreEm],[HoTenTreEm],[NgaySinh],[HoTenPhuHuynh],[TenONha],[DiaChi],[DienThoai],[Tuoi],[MaLop],[NgayNhapHoc],[GhiChu]) 
VALUES ('180011',N'Minh Beo',convert(datetime,'09/05/2013 00:00:00',101),N'Minh Nhi',N'Chu Bin',N'6 Ton Duc Thang',N'292929',N'5','3B',convert(datetime,'07/13/2018 00:00:00',101),N'Binh Thuong')
GO
INSERT INTO[dbo].[tblTreEm]([MaTreEm],[HoTenTreEm],[NgaySinh],[HoTenPhuHuynh],[TenONha],[DiaChi],[DienThoai],[Tuoi]) 
VALUES ('180012',N'Do Nan Tram',convert(datetime,'11/20/2014 00:00:00',101),N'Luc Thien Binh',N'Obama',N'18 Thanh Thai',N'363636',N'4')
GO
INSERT INTO[dbo].[tblTreEm]([MaTreEm],[HoTenTreEm],[NgaySinh],[HoTenPhuHuynh],[TenONha],[DiaChi],[DienThoai],[Tuoi]) 
VALUES ('180013',N'Tran Thanh',convert(datetime,'06/15/2013 00:00:00',101),N'Truong Giang',N'Chon Xi Na',N'9 Co Giang',N'55539',N'5')
GO
INSERT INTO[dbo].[tblTreEm]([MaTreEm],[HoTenTreEm],[NgaySinh],[HoTenPhuHuynh],[TenONha],[DiaChi],[DienThoai],[Tuoi]) 
VALUES ('180014',N'Hoai Linh',convert(datetime,'1/1/2015 00:00:00',101),N'Hoai Linh',N'Son Tung MP3',N'1 Tran Hung dao',N'363636',N'3')
GO
INSERT INTO[dbo].[tblTreEm]([MaTreEm],[HoTenTreEm],[NgaySinh],[HoTenPhuHuynh],[TenONha],[DiaChi],[DienThoai],[Tuoi],[MaLop],[NgayNhapHoc],[GhiChu]) 
VALUES ('180015',N'Tap Can Binh',convert(datetime,'11/03/2013 00:00:00',101),N'Thien Binh',N'Kid',N'10 Ung Van Khiem',N'08685',N'5','3C',convert(datetime,'02/22/2018 00:00:00',101),N'Ban ve so')
GO
INSERT INTO[dbo].[tblTreEm]([MaTreEm],[HoTenTreEm],[NgaySinh],[HoTenPhuHuynh],[TenONha],[DiaChi],[DienThoai],[Tuoi],[MaLop],[NgayNhapHoc],[GhiChu]) 
VALUES ('180016',N'Chau Nam Phong',convert(datetime,'01/23/2015 00:00:00',101),N'Kim Binh Mai',N'Di',N'99 Tran Duy Hung',N'020108',N'3','1D',convert(datetime,'05/06/2018 00:00:00',101),N'Lam DJ')
GO
INSERT INTO[dbo].[tblTreEm]([MaTreEm],[HoTenTreEm],[NgaySinh],[HoTenPhuHuynh],[TenONha],[DiaChi],[DienThoai],[Tuoi]) 
VALUES ('180017',N'Phan Thanh Hang',convert(datetime,'09/01/2013 00:00:00',101),N'Tuan Nguyen',N'Cave',N'10 Duy Hung',N'113',N'5')
GO
USE [QLNT]
GO

INSERT INTO[dbo].[tblGhiNhanTinhTrang]([MaPhieuGhiNhan],[MaTreEm],[NgayGhiNhan],[MaTinhTrang]) 
VALUES ('10000',N'180001',convert(datetime,'12/30/2014 00:00:00',101),N'1')
GO
INSERT INTO[dbo].[tblGhiNhanTinhTrang]([MaPhieuGhiNhan],[MaTreEm],[NgayGhiNhan],[MaTinhTrang]) 
VALUES ('10001',N'180007',convert(datetime,'11/03/2013 00:00:00',101),N'2')
GO
INSERT INTO[dbo].[tblGhiNhanTinhTrang]([MaPhieuGhiNhan],[MaTreEm],[NgayGhiNhan],[MaTinhTrang]) 
VALUES ('10002',N'180006',convert(datetime,'1/1/2015 00:00:00',101),N'3')
GO

USE [QLNT]
GO

INSERT INTO[dbo].[tblGhiNhanTinhTrang]([MaPhieuGhiNhan],[MaTreEm],[NgayGhiNhan],[MaTinhTrang],[MaKhoi]) 
VALUES ('10000',N'180001',convert(datetime,'12/30/2014 00:00:00',101),N'1',N'2')
GO
INSERT INTO[dbo].[tblGhiNhanTinhTrang]([MaPhieuGhiNhan],[MaTreEm],[NgayGhiNhan],[MaTinhTrang],[MaKhoi]) 
VALUES ('10001',N'180007',convert(datetime,'11/03/2013 00:00:00',101),N'2',N'1')
GO
INSERT INTO[dbo].[tblGhiNhanTinhTrang]([MaPhieuGhiNhan],[MaTreEm],[NgayGhiNhan],[MaTinhTrang],[MaKhoi]) 
VALUES ('10002',N'180006',convert(datetime,'1/1/2015 00:00:00',101),N'3',N'3')
GO