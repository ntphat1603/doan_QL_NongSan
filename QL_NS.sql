USE [QL_NONG_SAN]
GO
/****** Object:  Table [dbo].[hoadon]    Script Date: 6/17/2021 10:41:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hoadon](
	[mahd] [nvarchar](5) NOT NULL,
	[makh] [nvarchar](5) NULL,
	[tenkh] [nvarchar](50) NULL,
	[manv] [nvarchar](5) NULL,
	[ngayban] [smalldatetime] NULL,
	[tongtien] [decimal](18, 0) NULL,
 CONSTRAINT [PK_hoadon] PRIMARY KEY CLUSTERED 
(
	[mahd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[hoadonchitiet]    Script Date: 6/17/2021 10:41:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hoadonchitiet](
	[mahdct] [nvarchar](10) NOT NULL,
	[mahd] [nvarchar](5) NOT NULL,
	[ma_nongsan] [varchar](50) NULL,
	[ten_nongsan] [nvarchar](50) NULL,
	[loai] [nvarchar](50) NULL,
	[soluong] [int] NULL,
	[dongia] [int] NULL,
 CONSTRAINT [PK_hoadonchitiet_1] PRIMARY KEY CLUSTERED 
(
	[mahdct] ASC,
	[mahd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[khachhang]    Script Date: 6/17/2021 10:41:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[khachhang](
	[makh] [nvarchar](5) NOT NULL,
	[tenkh] [nvarchar](50) NULL,
	[gioitinh] [nvarchar](10) NULL,
	[ngaysinh] [smalldatetime] NULL,
	[dienthoai] [varchar](10) NULL,
	[diachi] [nvarchar](50) NULL,
 CONSTRAINT [PK_khachhang] PRIMARY KEY CLUSTERED 
(
	[makh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[loai]    Script Date: 6/17/2021 10:41:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[loai](
	[maloai] [nvarchar](50) NOT NULL,
	[tenloai] [nvarchar](50) NULL,
 CONSTRAINT [PK_loai] PRIMARY KEY CLUSTERED 
(
	[maloai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[nhanvien]    Script Date: 6/17/2021 10:41:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nhanvien](
	[manv] [nvarchar](5) NOT NULL,
	[tennv] [nvarchar](50) NULL,
	[gioitinh] [nvarchar](10) NULL,
	[ngaysinh] [smalldatetime] NULL,
	[dienthoai] [nvarchar](10) NULL,
	[diachi] [nvarchar](50) NULL,
	[quyen] [nvarchar](50) NULL,
	[matkhau] [nchar](255) NULL,
 CONSTRAINT [PK_nhanvien] PRIMARY KEY CLUSTERED 
(
	[manv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[nongsan]    Script Date: 6/17/2021 10:41:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nongsan](
	[ma_nongsan] [varchar](50) NOT NULL,
	[loai_nongsan] [nvarchar](50) NULL,
	[ten_nongsan] [nvarchar](50) NULL,
	[ngay_nhap] [date] NULL,
	[soluongton] [int] NULL,
	[giaban] [int] NULL,
	[gianhap] [int] NULL,
 CONSTRAINT [PK_nongsan_1] PRIMARY KEY CLUSTERED 
(
	[ma_nongsan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[phanquyen]    Script Date: 6/17/2021 10:41:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[phanquyen](
	[maphanquyen] [nvarchar](50) NOT NULL,
	[tenphanquyen] [nvarchar](50) NULL,
 CONSTRAINT [PK_phanquyen_1] PRIMARY KEY CLUSTERED 
(
	[maphanquyen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[hoadon] ([mahd], [makh], [tenkh], [manv], [ngayban], [tongtien]) VALUES (N'HD001', N'KH001', N'Nguyễn Tấn Phát', N'NV001', CAST(N'2021-06-08T00:00:00' AS SmallDateTime), CAST(45000 AS Decimal(18, 0)))
INSERT [dbo].[hoadon] ([mahd], [makh], [tenkh], [manv], [ngayban], [tongtien]) VALUES (N'HD002', N'KH001', N'Nguyễn Văn Cường', N'NV001', CAST(N'2021-06-09T00:00:00' AS SmallDateTime), CAST(150000 AS Decimal(18, 0)))
INSERT [dbo].[hoadon] ([mahd], [makh], [tenkh], [manv], [ngayban], [tongtien]) VALUES (N'HD003', N'KH003', N'Truyền', N'NV001', CAST(N'2021-06-10T00:00:00' AS SmallDateTime), CAST(80000 AS Decimal(18, 0)))
INSERT [dbo].[hoadon] ([mahd], [makh], [tenkh], [manv], [ngayban], [tongtien]) VALUES (N'HD004', N'KH002', N'Trần Thị C', N'NV002', CAST(N'2021-06-11T00:00:00' AS SmallDateTime), CAST(150000 AS Decimal(18, 0)))
INSERT [dbo].[hoadon] ([mahd], [makh], [tenkh], [manv], [ngayban], [tongtien]) VALUES (N'HD005', N'KH003', N'Truyền', N'NV003', CAST(N'2021-06-11T00:00:00' AS SmallDateTime), CAST(120000 AS Decimal(18, 0)))
INSERT [dbo].[hoadon] ([mahd], [makh], [tenkh], [manv], [ngayban], [tongtien]) VALUES (N'HD006', N'KH003', N'Truyền', N'NV001', CAST(N'2021-06-16T00:00:00' AS SmallDateTime), CAST(850000 AS Decimal(18, 0)))
GO
INSERT [dbo].[hoadonchitiet] ([mahdct], [mahd], [ma_nongsan], [ten_nongsan], [loai], [soluong], [dongia]) VALUES (N'HDCT_001', N'HD001', N'NS001', N'Ổi', N'fru_001', 5, 12000)
INSERT [dbo].[hoadonchitiet] ([mahdct], [mahd], [ma_nongsan], [ten_nongsan], [loai], [soluong], [dongia]) VALUES (N'HDCT_001', N'HD004', N'NS008', N'H?t Óc chó', N'veg_005', 5, 30000)
INSERT [dbo].[hoadonchitiet] ([mahdct], [mahd], [ma_nongsan], [ten_nongsan], [loai], [soluong], [dongia]) VALUES (N'HDCT_001', N'HD006', N'NS011', N'Cà r?t', N'veg_003', 50, 17000)
INSERT [dbo].[hoadonchitiet] ([mahdct], [mahd], [ma_nongsan], [ten_nongsan], [loai], [soluong], [dongia]) VALUES (N'HDCT_002', N'HD002', N'NS006', N'Lài sữa', N'veg_006', 10, 20000)
INSERT [dbo].[hoadonchitiet] ([mahdct], [mahd], [ma_nongsan], [ten_nongsan], [loai], [soluong], [dongia]) VALUES (N'HDCT_002', N'HD005', N'NS018', N'Su hào', N'veg_003', 5, 20000)
INSERT [dbo].[hoadonchitiet] ([mahdct], [mahd], [ma_nongsan], [ten_nongsan], [loai], [soluong], [dongia]) VALUES (N'HDCT_002', N'HD006', N'NS012', N'Cà phê', N'veg_005', 50, 15000)
INSERT [dbo].[hoadonchitiet] ([mahdct], [mahd], [ma_nongsan], [ten_nongsan], [loai], [soluong], [dongia]) VALUES (N'HDCT_003', N'HD006', N'NS010', N'Táo', N'fru_002', 20, 15000)
INSERT [dbo].[hoadonchitiet] ([mahdct], [mahd], [ma_nongsan], [ten_nongsan], [loai], [soluong], [dongia]) VALUES (N'HDCT001', N'HD003', N'NS006', N'Lài sữa', N'veg_006', 4, 20000)
INSERT [dbo].[hoadonchitiet] ([mahdct], [mahd], [ma_nongsan], [ten_nongsan], [loai], [soluong], [dongia]) VALUES (N'HDCT002', N'HD003', N'NS012', N'Cà phê', N'veg_005', 9, 15000)
INSERT [dbo].[hoadonchitiet] ([mahdct], [mahd], [ma_nongsan], [ten_nongsan], [loai], [soluong], [dongia]) VALUES (N'HDCT003', N'HD003', N'NS005', N'Gạo Sóc Thường', N'veg_006', 9, 13000)
INSERT [dbo].[hoadonchitiet] ([mahdct], [mahd], [ma_nongsan], [ten_nongsan], [loai], [soluong], [dongia]) VALUES (N'HDCT004', N'HD003', N'NS001', N'?i', N'fru_001', 10, 12000)
INSERT [dbo].[hoadonchitiet] ([mahdct], [mahd], [ma_nongsan], [ten_nongsan], [loai], [soluong], [dongia]) VALUES (N'HDCT005', N'HD003', N'NS018', N'Su hào', N'veg_003', 10, 20000)
INSERT [dbo].[hoadonchitiet] ([mahdct], [mahd], [ma_nongsan], [ten_nongsan], [loai], [soluong], [dongia]) VALUES (N'HDCT006', N'HD003', N'NS019', N'Dâu tây Ðà L?t', N'veg_004', 14, 50000)
GO
INSERT [dbo].[khachhang] ([makh], [tenkh], [gioitinh], [ngaysinh], [dienthoai], [diachi]) VALUES (N'KH001', N'Nguyễn Văn Cường', N'Nam', CAST(N'1999-04-13T00:00:00' AS SmallDateTime), N'0987654321', N'LX')
INSERT [dbo].[khachhang] ([makh], [tenkh], [gioitinh], [ngaysinh], [dienthoai], [diachi]) VALUES (N'KH002', N'Trần Thị C', N'Nữ', CAST(N'1999-04-13T00:00:00' AS SmallDateTime), N'0987654321', N'LX')
INSERT [dbo].[khachhang] ([makh], [tenkh], [gioitinh], [ngaysinh], [dienthoai], [diachi]) VALUES (N'KH003', N'Truyền', N'Nữ', CAST(N'1979-06-12T00:00:00' AS SmallDateTime), N'0987654321', N'LX')
GO
INSERT [dbo].[loai] ([maloai], [tenloai]) VALUES (N'fru_001', N'Trái cây')
INSERT [dbo].[loai] ([maloai], [tenloai]) VALUES (N'fru_002', N'Trái cây tươi')
INSERT [dbo].[loai] ([maloai], [tenloai]) VALUES (N'veg_003', N'Rau củ')
INSERT [dbo].[loai] ([maloai], [tenloai]) VALUES (N'veg_004', N'Nông sản Đà Lạt')
INSERT [dbo].[loai] ([maloai], [tenloai]) VALUES (N'veg_005', N'Các loại hạt')
INSERT [dbo].[loai] ([maloai], [tenloai]) VALUES (N'veg_006', N'Gạo')
GO
INSERT [dbo].[nhanvien] ([manv], [tennv], [gioitinh], [ngaysinh], [dienthoai], [diachi], [quyen], [matkhau]) VALUES (N'NV001', N'Nguyễn Tấn Phát', N'Nam', CAST(N'2000-03-16T00:00:00' AS SmallDateTime), N'0917663865', N'LX', N'Quản lý', N'81dc9bdb52d04dc20036dbd8313ed055                                                                                                                                                                                                                               ')
INSERT [dbo].[nhanvien] ([manv], [tennv], [gioitinh], [ngaysinh], [dienthoai], [diachi], [quyen], [matkhau]) VALUES (N'NV002', N'Nguyễn Tấn Đạt', N'Nam', CAST(N'2000-05-22T00:00:00' AS SmallDateTime), N'0986773531', N'Tịnh Biên', N'Nhân viên', N'81dc9bdb52d04dc20036dbd8313ed055                                                                                                                                                                                                                               ')
INSERT [dbo].[nhanvien] ([manv], [tennv], [gioitinh], [ngaysinh], [dienthoai], [diachi], [quyen], [matkhau]) VALUES (N'NV003', N'Trần Thị B', N'Nữ', CAST(N'2003-06-10T00:00:00' AS SmallDateTime), N'0987654321', N'LX', N'Nhân viên', N'81dc9bdb52d04dc20036dbd8313ed055                                                                                                                                                                                                                               ')
INSERT [dbo].[nhanvien] ([manv], [tennv], [gioitinh], [ngaysinh], [dienthoai], [diachi], [quyen], [matkhau]) VALUES (N'NV004', N'Nguyễn Văn A', N'Nam', CAST(N'1998-06-18T00:00:00' AS SmallDateTime), N'0987654321', N'An Giang', N'Quản lý', N'81dc9bdb52d04dc20036dbd8313ed055                                                                                                                                                                                                                               ')
GO
INSERT [dbo].[nongsan] ([ma_nongsan], [loai_nongsan], [ten_nongsan], [ngay_nhap], [soluongton], [giaban], [gianhap]) VALUES (N'NS001', N'fru_001', N'Ổi', CAST(N'2021-03-12' AS Date), 50, 12000, 20000)
INSERT [dbo].[nongsan] ([ma_nongsan], [loai_nongsan], [ten_nongsan], [ngay_nhap], [soluongton], [giaban], [gianhap]) VALUES (N'NS002', N'veg_003', N'Ớt', CAST(N'2021-05-27' AS Date), 20, 15000, 12000)
INSERT [dbo].[nongsan] ([ma_nongsan], [loai_nongsan], [ten_nongsan], [ngay_nhap], [soluongton], [giaban], [gianhap]) VALUES (N'NS003', N'fru_001', N'Mít', CAST(N'2021-06-01' AS Date), 50, 2000, 15000)
INSERT [dbo].[nongsan] ([ma_nongsan], [loai_nongsan], [ten_nongsan], [ngay_nhap], [soluongton], [giaban], [gianhap]) VALUES (N'NS004', N'veg_006', N'Gạo Sóc Thái', CAST(N'2021-06-01' AS Date), 50, 17000, 15000)
INSERT [dbo].[nongsan] ([ma_nongsan], [loai_nongsan], [ten_nongsan], [ngay_nhap], [soluongton], [giaban], [gianhap]) VALUES (N'NS005', N'veg_006', N'Gạo Sóc Thường', CAST(N'2021-06-01' AS Date), 91, 13000, 12000)
INSERT [dbo].[nongsan] ([ma_nongsan], [loai_nongsan], [ten_nongsan], [ngay_nhap], [soluongton], [giaban], [gianhap]) VALUES (N'NS006', N'veg_006', N'Lài sữa', CAST(N'2021-06-01' AS Date), 26, 20000, 18000)
INSERT [dbo].[nongsan] ([ma_nongsan], [loai_nongsan], [ten_nongsan], [ngay_nhap], [soluongton], [giaban], [gianhap]) VALUES (N'NS007', N'veg_005', N'Điều', CAST(N'2021-06-01' AS Date), 30, 25000, 22000)
INSERT [dbo].[nongsan] ([ma_nongsan], [loai_nongsan], [ten_nongsan], [ngay_nhap], [soluongton], [giaban], [gianhap]) VALUES (N'NS008', N'veg_005', N'Hạt Óc chó', CAST(N'2021-06-01' AS Date), 45, 30000, 27000)
INSERT [dbo].[nongsan] ([ma_nongsan], [loai_nongsan], [ten_nongsan], [ngay_nhap], [soluongton], [giaban], [gianhap]) VALUES (N'NS009', N'veg_004', N'Ớt chuông Đà Lạt', CAST(N'2021-06-01' AS Date), 50, 15000, 13000)
INSERT [dbo].[nongsan] ([ma_nongsan], [loai_nongsan], [ten_nongsan], [ngay_nhap], [soluongton], [giaban], [gianhap]) VALUES (N'NS010', N'fru_002', N'Táo', CAST(N'2021-05-27' AS Date), 0, 15000, 13000)
INSERT [dbo].[nongsan] ([ma_nongsan], [loai_nongsan], [ten_nongsan], [ngay_nhap], [soluongton], [giaban], [gianhap]) VALUES (N'NS011', N'veg_003', N'Cà rốt', CAST(N'2021-05-27' AS Date), 50, 17000, 15000)
INSERT [dbo].[nongsan] ([ma_nongsan], [loai_nongsan], [ten_nongsan], [ngay_nhap], [soluongton], [giaban], [gianhap]) VALUES (N'NS012', N'veg_005', N'Cà phê', CAST(N'2021-05-27' AS Date), 41, 15000, 10000)
INSERT [dbo].[nongsan] ([ma_nongsan], [loai_nongsan], [ten_nongsan], [ngay_nhap], [soluongton], [giaban], [gianhap]) VALUES (N'NS013', N'veg_005', N'Ca cao', CAST(N'2021-06-10' AS Date), 100, 18000, 12000)
INSERT [dbo].[nongsan] ([ma_nongsan], [loai_nongsan], [ten_nongsan], [ngay_nhap], [soluongton], [giaban], [gianhap]) VALUES (N'NS014', N'fru_001', N'Mận', CAST(N'2021-03-12' AS Date), 10, 12000, 20000)
INSERT [dbo].[nongsan] ([ma_nongsan], [loai_nongsan], [ten_nongsan], [ngay_nhap], [soluongton], [giaban], [gianhap]) VALUES (N'NS015', N'veg_003', N'Tiêu', CAST(N'2021-05-27' AS Date), 20, 15000, 12000)
INSERT [dbo].[nongsan] ([ma_nongsan], [loai_nongsan], [ten_nongsan], [ngay_nhap], [soluongton], [giaban], [gianhap]) VALUES (N'NS016', N'fru_001', N'Xoài', CAST(N'2021-06-01' AS Date), 50, 2000, 15000)
INSERT [dbo].[nongsan] ([ma_nongsan], [loai_nongsan], [ten_nongsan], [ngay_nhap], [soluongton], [giaban], [gianhap]) VALUES (N'NS017', N'veg_006', N'Jasmine', CAST(N'2021-06-01' AS Date), 50, 17000, 15000)
INSERT [dbo].[nongsan] ([ma_nongsan], [loai_nongsan], [ten_nongsan], [ngay_nhap], [soluongton], [giaban], [gianhap]) VALUES (N'NS018', N'veg_003', N'Su hào', CAST(N'2021-06-11' AS Date), 25, 20000, 17000)
INSERT [dbo].[nongsan] ([ma_nongsan], [loai_nongsan], [ten_nongsan], [ngay_nhap], [soluongton], [giaban], [gianhap]) VALUES (N'NS019', N'veg_004', N'Dâu tây Đà Lạt', CAST(N'2021-12-06' AS Date), 36, 50000, 45000)
INSERT [dbo].[nongsan] ([ma_nongsan], [loai_nongsan], [ten_nongsan], [ngay_nhap], [soluongton], [giaban], [gianhap]) VALUES (N'NS020', N'fru_001', N'Cóc', CAST(N'2021-06-16' AS Date), 10, 12000, 20000)
INSERT [dbo].[nongsan] ([ma_nongsan], [loai_nongsan], [ten_nongsan], [ngay_nhap], [soluongton], [giaban], [gianhap]) VALUES (N'NS021', N'fru_001', N'Mía', CAST(N'2021-06-16' AS Date), 20, 15000, 12000)
INSERT [dbo].[nongsan] ([ma_nongsan], [loai_nongsan], [ten_nongsan], [ngay_nhap], [soluongton], [giaban], [gianhap]) VALUES (N'NS022', N'veg_004', N'Cải thảo', CAST(N'2021-06-16' AS Date), 50, 2000, 15000)
INSERT [dbo].[nongsan] ([ma_nongsan], [loai_nongsan], [ten_nongsan], [ngay_nhap], [soluongton], [giaban], [gianhap]) VALUES (N'NS023', N'veg_003', N'Cả bó xôi', CAST(N'2021-06-16' AS Date), 40, 20000, 17000)
INSERT [dbo].[nongsan] ([ma_nongsan], [loai_nongsan], [ten_nongsan], [ngay_nhap], [soluongton], [giaban], [gianhap]) VALUES (N'NS024', N'veg_006', N'Gạo Đài Loan', CAST(N'2021-06-16' AS Date), 50, 15000, 13000)
INSERT [dbo].[nongsan] ([ma_nongsan], [loai_nongsan], [ten_nongsan], [ngay_nhap], [soluongton], [giaban], [gianhap]) VALUES (N'NS025', N'veg_006', N'Gạo lức', CAST(N'2021-06-16' AS Date), 40, 18000, 16000)
GO
INSERT [dbo].[phanquyen] ([maphanquyen], [tenphanquyen]) VALUES (N'pq_GD', N'Giám đốc')
INSERT [dbo].[phanquyen] ([maphanquyen], [tenphanquyen]) VALUES (N'pq_NV', N'Nhân viên')
INSERT [dbo].[phanquyen] ([maphanquyen], [tenphanquyen]) VALUES (N'pq_QL', N'Quản lý')
GO
ALTER TABLE [dbo].[hoadon]  WITH CHECK ADD  CONSTRAINT [FK_hoadon_khachhang] FOREIGN KEY([makh])
REFERENCES [dbo].[khachhang] ([makh])
GO
ALTER TABLE [dbo].[hoadon] CHECK CONSTRAINT [FK_hoadon_khachhang]
GO
ALTER TABLE [dbo].[hoadon]  WITH CHECK ADD  CONSTRAINT [FK_hoadon_nhanvien] FOREIGN KEY([manv])
REFERENCES [dbo].[nhanvien] ([manv])
GO
ALTER TABLE [dbo].[hoadon] CHECK CONSTRAINT [FK_hoadon_nhanvien]
GO
ALTER TABLE [dbo].[hoadonchitiet]  WITH CHECK ADD  CONSTRAINT [FK_hoadonchitiet_hoadon] FOREIGN KEY([mahd])
REFERENCES [dbo].[hoadon] ([mahd])
GO
ALTER TABLE [dbo].[hoadonchitiet] CHECK CONSTRAINT [FK_hoadonchitiet_hoadon]
GO
ALTER TABLE [dbo].[hoadonchitiet]  WITH CHECK ADD  CONSTRAINT [FK_hoadonchitiet_nongsan] FOREIGN KEY([ma_nongsan])
REFERENCES [dbo].[nongsan] ([ma_nongsan])
GO
ALTER TABLE [dbo].[hoadonchitiet] CHECK CONSTRAINT [FK_hoadonchitiet_nongsan]
GO
ALTER TABLE [dbo].[nongsan]  WITH CHECK ADD  CONSTRAINT [FK_nongsan_loai1] FOREIGN KEY([loai_nongsan])
REFERENCES [dbo].[loai] ([maloai])
GO
ALTER TABLE [dbo].[nongsan] CHECK CONSTRAINT [FK_nongsan_loai1]
GO
