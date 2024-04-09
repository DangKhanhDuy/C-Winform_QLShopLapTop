CREATE DATABASE [QLShoplaptop]
GO
USE [QLShoplaptop]
GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 11/7/2023 10:28:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADON](
    [MaHD] [nvarchar](50) NOT NULL PRIMARY KEY,
    [MaNV] [nvarchar](50) NOT NULL,
	[MaKH] [nvarchar](50) NOT NULL,
	[MaSP] [nvarchar](50) NOT NULL,
	[NgayBan] [date] NULL,
	[TongTien] [int] NULL,
	[TrangThai] [bit] NULL,
)
GO
CREATE TABLE [dbo].[CHITIETHOADON](
	[MaSP] [nvarchar](50) NOT NULL,
    [MaHD] [nvarchar](50) NOT NULL,
    [SoLuong] [int] NULL,
    [DonGia] [int] NULL,
    [ThanhTien] [int] NULL,
	CONSTRAINT [PK_CHITIETHOADON] PRIMARY KEY ([MaHD] ASC,[MaSP] ASC)
)
GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 11/7/2023 10:28:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[MaKH] [nvarchar](50) NOT NULL PRIMARY KEY,
	[TenKH] [nvarchar](50) NULL,
	[NgaySinh] [date] NULL,
	[GioiTinh] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [int] NULL,
	[EMAIL] [varchar](50) NULL,
	[MATKHAU] [varchar](20) NULL,
)
GO
/****** Object:  Table [dbo].[KHOHANG]    Script Date: 11/30/2023 11:40:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHOHANG](
	[MaKho] [nvarchar](50) NOT NULL,
	[MaSP] [nvarchar](50) NULL,
	[TenSP] [nvarchar](50) NULL,
	[SoLuongTon] [int] NULL,
	[NgayNhap] [date] NULL,
 CONSTRAINT [PK_KHOHANG] PRIMARY KEY ([MaKho])
 )
 GO
/****** Object:  Table [dbo].[NHACUNGCAP]    Script Date: 11/7/2023 10:28:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHACUNGCAP](
	[MaNCC] [nvarchar](50) NOT NULL PRIMARY KEY,
	[TenNCC] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [int] NULL,
)
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 11/7/2023 10:28:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MaNV] [nvarchar](50) NOT NULL,
	[TenNV] [nvarchar](50) NULL,
	[NgaySinh] [date] NULL,
	[GioiTinh] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](max) NULL,
	[SDT] [int] NULL,
 CONSTRAINT [PK_NHANVIEN] PRIMARY KEY (MaNV) 
)
GO
/****** Object:  Table [dbo].[PHANQUYEN]    Script Date: 11/7/2023 10:28:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHANQUYEN](
	[MaQuyen] [int] NOT NULL,
	[TenQuyen] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_QUYEN] PRIMARY KEY (MaQuyen) 
)
GO
/****** Object:  Table [dbo].[SANPHAM]    Script Date: 11/7/2023 10:28:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SANPHAM](
	[MaSP] [nvarchar](50) NOT NULL,
	[TenSP] [nvarchar](50) NULL,
	[SoLuong] [int] NULL,
	[GiaBan] [int] NULL,
	[HinhAnh] [varchar](100) NULL,
	[CPU] [varchar](100) NULL,
	[VGA] [varchar](100) NULL,
	[RAM] [varchar](100) NULL,
	[DISPLAY] [varchar](100) NULL,
	[MaNCC] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_SANPHAM] PRIMARY KEY (MaSP) 
)
GO
/****** Object:  Table [dbo].[TAIKHOAN]    Script Date: 11/7/2023 10:28:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TAIKHOAN](
	[MaTaiKhoan] [nvarchar](50) NOT NULL,
	[TenTaiKhoan] [nvarchar](50) NOT NULL,
	[MatKhau] [nvarchar](100) NULL,
	[MaQuyen] [int] NULL,
 CONSTRAINT [PK_TAIKHOAN] PRIMARY KEY (MaTaiKhoan) 
)
GO
INSERT [dbo].[HOADON] ([MaHD], [MaNV], [MaKH], [MaSP], [NgayBan], [TongTien], [TrangThai]) VALUES (N'HD1', N'NV1', N'KH1', N'SP1', CAST(N'2023-11-07' AS Date), 30000000, 0)
INSERT [dbo].[HOADON] ([MaHD], [MaNV], [MaKH], [MaSP], [NgayBan], [TongTien], [TrangThai]) VALUES (N'HD2', N'NV2', N'KH2', N'SP2', CAST(N'2023-11-07' AS Date), 36000000, 0)
INSERT [dbo].[HOADON] ([MaHD], [MaNV], [MaKH], [MaSP], [NgayBan], [TongTien], [TrangThai]) VALUES (N'HD3', N'NV3', N'KH3', N'SP3', CAST(N'2023-11-07' AS Date), 13000000, 0)
INSERT [dbo].[HOADON] ([MaHD], [MaNV], [MaKH], [MaSP], [NgayBan], [TongTien], [TrangThai]) VALUES (N'HD4', N'NV4', N'KH4', N'SP4', CAST(N'2023-11-07' AS Date), 70000000, 0)
INSERT [dbo].[HOADON] ([MaHD], [MaNV], [MaKH], [MaSP], [NgayBan], [TongTien], [TrangThai]) VALUES (N'HD5', N'NV5', N'KH5', N'SP5', CAST(N'2023-11-07' AS Date), 40000000, 0)
GO
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [EMAIL], [MATKHAU]) VALUES (N'KH1', N'Nguy?n Van A', CAST(N'1990-01-15' AS Date), N'Nam', N'123 Ðu?ng ABC', 123456789, 'nva123456789@gmail.com', '123')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [EMAIL], [MATKHAU]) VALUES (N'KH2', N'Tr?n Th? B', CAST(N'1995-05-20' AS Date), N'N?', N'456 Ðu?ng XYZ', 987654321, 'ttb987654321@gmail.com', '123')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [EMAIL], [MATKHAU]) VALUES (N'KH3', N'Hoàng Minh C', CAST(N'2000-08-10' AS Date), N'Nam', N'789 Ðu?ng KLM', 555555555, 'hmc555555555@gmail.com', '123')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [EMAIL], [MATKHAU]) VALUES (N'KH4', N'Lê Th? D', CAST(N'1985-03-05' AS Date), N'N?', N'321 Ðu?ng PQR', 111111111, 'ltd111111111@gmail.com', '123')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [EMAIL], [MATKHAU]) VALUES (N'KH5', N'Ph?m Van E', CAST(N'1992-12-25' AS Date), N'Nam', N'654 Ðu?ng DEF', 999999999, 'pve999999999@gmail.com', '123')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [EMAIL], [MATKHAU]) VALUES (N'KH6', N'Nguyễn Minh Khoa', CAST(N'2002-07-05' AS Date), N'Nam', N'286 Bình Giang', 0826494184, 'khoanguyen01295611359@gmail.com', '123')
GO
INSERT [dbo].[KHOHANG] ([MaKho], [MaSP], [TenSP], [SoLuongTon], [NgayNhap]) VALUES (N'MK02', N'SP1', N'Laptop Dell XPS', 800, CAST(N'2023-03-15' AS Date))
INSERT [dbo].[KHOHANG] ([MaKho], [MaSP], [TenSP], [SoLuongTon], [NgayNhap]) VALUES (N'MK03', N'SP2', N'Laptop HP Spectre', 900, CAST(N'2023-04-20' AS Date))
INSERT [dbo].[KHOHANG] ([MaKho], [MaSP], [TenSP], [SoLuongTon], [NgayNhap]) VALUES (N'MK04', N'SP3', N'Laptop Asus ZenBook', 950, CAST(N'2023-05-12' AS Date))
INSERT [dbo].[KHOHANG] ([MaKho], [MaSP], [TenSP], [SoLuongTon], [NgayNhap]) VALUES (N'MK05', N'SP4', N'Laptop Lenovo ThinkPad', 850, CAST(N'2023-06-18' AS Date))
INSERT [dbo].[KHOHANG] ([MaKho], [MaSP], [TenSP], [SoLuongTon], [NgayNhap]) VALUES (N'MK06', N'SP5', N'Laptop Acer Swift', 750, CAST(N'2023-07-25' AS Date))
INSERT [dbo].[KHOHANG] ([MaKho], [MaSP], [TenSP], [SoLuongTon], [NgayNhap]) VALUES (N'MK07', N'SP6', N'Laptop Acer Swift', 1200, CAST(N'2023-08-30' AS Date))
INSERT [dbo].[KHOHANG] ([MaKho], [MaSP], [TenSP], [SoLuongTon], [NgayNhap]) VALUES (N'MK08', N'SP7', N'Laptop Huawei MateBook', 1100, CAST(N'2023-09-05' AS Date))
INSERT [dbo].[KHOHANG] ([MaKho], [MaSP], [TenSP], [SoLuongTon], [NgayNhap]) VALUES (N'MK09', N'SP8', N'Laptop Samsung Galaxy Book', 1000, CAST(N'2023-10-10' AS Date))
INSERT [dbo].[KHOHANG] ([MaKho], [MaSP], [TenSP], [SoLuongTon], [NgayNhap]) VALUES (N'MK10', N'SP9', N'Laptop Apple MacBook Air', 1300, CAST(N'2023-11-15' AS Date))
INSERT [dbo].[KHOHANG] ([MaKho], [MaSP], [TenSP], [SoLuongTon], [NgayNhap]) VALUES (N'MK11', N'SP10', N'Laptop Google Pixelbook', 1250, CAST(N'2023-12-20' AS Date))
INSERT [dbo].[KHOHANG] ([MaKho], [MaSP], [TenSP], [SoLuongTon], [NgayNhap]) VALUES (N'MK12', N'SP11', N'Laptop HP Pavilion', 1150, CAST(N'2023-09-05' AS Date))
INSERT [dbo].[KHOHANG] ([MaKho], [MaSP], [TenSP], [SoLuongTon], [NgayNhap]) VALUES (N'MK13', N'SP12', N'Laptop Microsoft Surface', 1200, CAST(N'2023-10-10' AS Date))
INSERT [dbo].[KHOHANG] ([MaKho], [MaSP], [TenSP], [SoLuongTon], [NgayNhap]) VALUES (N'MK14', N'SP13', N'Laptop Razer Blade', 1050, CAST(N'2023-11-15' AS Date))
GO
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChi], [SDT]) VALUES (N'NCC1', N'Công Ty A', N'12 Ðu?ng UVW', 222222222)
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChi], [SDT]) VALUES (N'NCC2', N'Công Ty B', N'34 Ðu?ng XYZ', 333333333)
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChi], [SDT]) VALUES (N'NCC3', N'Công Ty C', N'56 Ðu?ng PQR', 444444444)
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChi], [SDT]) VALUES (N'NCC4', N'Công Ty D', N'78 Ðu?ng EFG', 555555555)
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChi], [SDT]) VALUES (N'NCC5', N'Công Ty E', N'90 Ðu?ng HIJ', 334235554)
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChi], [SDT]) VALUES (N'NCC6', N'Công Ty Hgg', N'34 Ðu?ng XYZ', 333333333)
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChi], [SDT]) VALUES (N'NCC7', N'Công Ty F', N'56 Ðu?ng PQR', 242042400)
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChi], [SDT]) VALUES (N'NCC8', N'Công Ty G', N'90 Ðu?ng HIJ', 666666666)
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChi], [SDT]) VALUES (N'NCC9', N'Công Ty H', N'34 Ðu?ng XYZ', 333333333)
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChi], [SDT]) VALUES (N'NCC10', N'Công Ty X', N'12 Ðu?ng UVW', 673254345)
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChi], [SDT]) VALUES (N'NCC11', N'Công Ty FF', N'56 Ðu?ng PQR', 444444444)
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChi], [SDT]) VALUES (N'NCC12', N'Công Ty W', N'12 Ðu?ng UVW', 444444444)
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChi], [SDT]) VALUES (N'NCC13', N'Công Ty QQ', N'56 Ðu?ng PQR', 121342552)
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChi], [SDT]) VALUES (N'NCC14', N'Công Ty VV', N'56 Ðu?ng PQR', 134545633)

GO
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [DiaChi], [SDT]) VALUES (N'NV1', N'Nguyễn Thị F', CAST(N'1990-02-10' AS Date), N'Nữ', N'987 Đường LMN', 777777777)
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [DiaChi], [SDT]) VALUES (N'NV2', N'Trần Văn G', CAST(N'1987-06-15' AS Date), N'Nam', N'654 Đường XYZ', 888888888)
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [DiaChi], [SDT]) VALUES (N'NV3', N'Hồ Minh H', CAST(N'1992-09-20' AS Date), N'Nam', N'123 Đường ABC', 999999999)
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [DiaChi], [SDT]) VALUES (N'NV4', N'Lê Thị I', CAST(N'1980-11-25' AS Date), N'Nữ', N'456 Đường DEF', 111111111)
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [DiaChi], [SDT]) VALUES (N'NV5', N'Phạm Văn J', CAST(N'1995-12-30' AS Date), N'Nam', N'789 Đường GHI', 222222222)
GO
INSERT [dbo].[PHANQUYEN] ([MaQuyen], [TenQuyen]) VALUES (1, N'Admin')
INSERT [dbo].[PHANQUYEN] ([MaQuyen], [TenQuyen]) VALUES (2, N'User')
GO
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [SoLuong], [GiaBan], [HinhAnh], [CPU], [VGA], [RAM], [DISPLAY], [MaNCC]) VALUES (N'SP1', N'Laptop Dell XPS', 10, 15000000, 'laptop1.jpg', 'i5-12450H', 'RTX-2050', '8GB', '15.6" FHD 144Hz', N'NCC1')
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [SoLuong], [GiaBan], [HinhAnh], [CPU], [VGA], [RAM], [DISPLAY],[MaNCC]) VALUES (N'SP2', N'Laptop HP Spectre', 8, 12000000, 'laptop2.jpg','i7-12700H', 'RTX-2035', '8GB', '14 inch WQXGA OLED',N'NCC2')
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [SoLuong], [GiaBan], [HinhAnh], [CPU], [VGA], [RAM], [DISPLAY],[MaNCC]) VALUES (N'SP3', N'Laptop Asus ZenBook', 12, 13000000, 'laptop3.jpg', 'r7-7725HS', 'RTX-4050', '16GB', '16 inch 165Hz', N'NCC3')
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [SoLuong], [GiaBan], [HinhAnh], [CPU], [VGA], [RAM], [DISPLAY],[MaNCC]) VALUES (N'SP4', N'Laptop Lenovo ThinkPad', 15, 14000000, 'laptop4.jpg', 'i3-12700H', 'RTX-1090', '4GB', '14 inch 144Hz', N'NCC4')
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [SoLuong], [GiaBan], [HinhAnh], [CPU], [VGA], [RAM], [DISPLAY],[MaNCC]) VALUES (N'SP5', N'Laptop Acer Swift', 20, 10000000, 'laptop5.jpg', 'i7-12700H', 'RTX-2050', '8GB', '14 inch WQXGA OLED', N'NCC5')
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [SoLuong], [GiaBan], [HinhAnh], [CPU], [VGA], [RAM], [DISPLAY],[MaNCC]) VALUES (N'SP6', N'Laptop Acer Swift', 20, 10000000, 'laptop6.jpg', 'i5-12450H', 'RTX-2050', '8GB', '15.6" FHD 144Hz',N'NCC6')
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [SoLuong], [GiaBan], [HinhAnh], [CPU], [VGA], [RAM], [DISPLAY],[MaNCC]) VALUES (N'SP7', N'Laptop Huawei MateBook', 18, 11000000, 'laptop7.jpg', 'r7-7725HS', 'RTX-4050', '16GB', '16 inch 165Hz',N'NCC14')
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [SoLuong], [GiaBan], [HinhAnh], [CPU], [VGA], [RAM], [DISPLAY],[MaNCC]) VALUES (N'SP8', N'Laptop Samsung Galaxy Book', 25, 10500000, 'laptop8.jpg', 'i7-12700H', 'RTX-2035', '8GB', '14 inch WQXGA OLED',N'NCC7')
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [SoLuong], [GiaBan], [HinhAnh], [CPU], [VGA], [RAM], [DISPLAY],[MaNCC]) VALUES (N'SP9', N'Laptop Apple MacBook Air', 30, 13500000, 'laptop9.jpg', 'i3-12700H', 'RTX-1090', '4GB', '14 inch 144Hz',N'NCC8')
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [SoLuong], [GiaBan], [HinhAnh], [CPU], [VGA], [RAM], [DISPLAY],[MaNCC]) VALUES (N'SP10', N'Laptop Google Pixelbook', 22, 12800000, 'laptop10.jpg', 'i5-12450H', 'RTX-2050', '8GB', '15.6" FHD 144Hz',N'NCC9')
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [SoLuong], [GiaBan], [HinhAnh], [CPU], [VGA], [RAM], [DISPLAY],[MaNCC]) VALUES (N'SP11', N'Laptop HP Pavilion', 14, 11500000, 'laptop11.jpg', 'i3-12700H', 'RTX-1090', '4GB', '14 inch 144Hz',N'NCC10')
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [SoLuong], [GiaBan], [HinhAnh], [CPU], [VGA], [RAM], [DISPLAY],[MaNCC]) VALUES (N'SP12', N'Laptop Microsoft Surface', 20, 12500000, 'laptop12.jpg', 'i7-12700H', 'RTX-2035', '8GB', '14 inch WQXGA OLED',N'NCC11')
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [SoLuong], [GiaBan], [HinhAnh], [CPU], [VGA], [RAM], [DISPLAY],[MaNCC]) VALUES (N'SP13', N'Laptop Razer Blade', 10, 15500000, 'laptop13.jpg', 'i5-12450H', 'RTX-2050', '8GB', '15.6" FHD 144Hz',N'NCC12')
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [SoLuong], [GiaBan], [HinhAnh], [CPU], [VGA], [RAM], [DISPLAY],[MaNCC]) VALUES (N'SP14', N'Laptop Gigabyte Aero', 18, 14500000, 'laptop14.jpg', 'i5-12450H', 'RTX-2050', '8GB', '15.6" FHD 144Hz',N'NCC13')
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [SoLuong], [GiaBan], [HinhAnh], [CPU], [VGA], [RAM], [DISPLAY],[MaNCC]) VALUES (N'SP15', N'Laptop HP Spectre', 8, 12000000, 'laptop15.jpg', 'r7-7725HS', 'RTX-4050', '16GB', '16 inch 165Hz',N'NCC2')
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [SoLuong], [GiaBan], [HinhAnh], [CPU], [VGA], [RAM], [DISPLAY],[MaNCC]) VALUES (N'SP16', N'Laptop Asus ZenBook', 12, 13000000, 'laptop16.jpg', 'i3-12700H', 'RTX-1090', '4GB', '14 inch 144Hz',N'NCC3')
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [SoLuong], [GiaBan], [HinhAnh], [CPU], [VGA], [RAM], [DISPLAY],[MaNCC]) VALUES (N'SP17', N'Laptop Lenovo ThinkPad', 15, 14000000, 'laptop17.jpg', 'i5-12450H', 'RTX-2050', '8GB', '15.6" FHD 144Hz',N'NCC4')
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [SoLuong], [GiaBan], [HinhAnh], [CPU], [VGA], [RAM], [DISPLAY],[MaNCC]) VALUES (N'SP18', N'Laptop Acer Swift', 20, 10000000, 'laptop18.jpg', 'i3-12700H', 'RTX-1090', '4GB', '14 inch 144Hz',N'NCC5')
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [SoLuong], [GiaBan], [HinhAnh], [CPU], [VGA], [RAM], [DISPLAY],[MaNCC]) VALUES (N'SP19', N'Laptop Acer Swift', 20, 10000000, 'laptop19.jpg', 'i7-12700H', 'RTX-2035', '8GB', '14 inch WQXGA OLED',N'NCC6')
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [SoLuong], [GiaBan], [HinhAnh], [CPU], [VGA], [RAM], [DISPLAY],[MaNCC]) VALUES (N'SP20', N'Laptop Huawei MateBook', 18, 11000000, 'laptop20.jpg', 'i3-12700H', 'RTX-1090', '4GB', '14 inch 144Hz',N'NCC14')
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [SoLuong], [GiaBan], [HinhAnh], [CPU], [VGA], [RAM], [DISPLAY],[MaNCC]) VALUES (N'SP21', N'Laptop Samsung Galaxy Book', 25, 10500000, 'laptop21.jpg', 'i5-12450H', 'RTX-2050', '8GB', '15.6" FHD 144Hz',N'NCC7')
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [SoLuong], [GiaBan], [HinhAnh], [CPU], [VGA], [RAM], [DISPLAY],[MaNCC]) VALUES (N'SP22', N'Laptop Apple MacBook Air', 30, 13500000, 'laptop22.jpg', 'i3-12700H', 'RTX-1090', '4GB', '14 inch 144Hz',N'NCC8')
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [SoLuong], [GiaBan], [HinhAnh], [CPU], [VGA], [RAM], [DISPLAY],[MaNCC]) VALUES (N'SP23', N'Laptop Google Pixelbook', 22, 12800000, 'laptop23.jpg', 'i7-12700H', 'RTX-2035', '8GB', '14 inch WQXGA OLED',N'NCC9')
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [SoLuong], [GiaBan], [HinhAnh], [CPU], [VGA], [RAM], [DISPLAY],[MaNCC]) VALUES (N'SP24', N'Laptop HP Pavilion', 14, 11500000, 'laptop24.jpg', 'r7-7725HS', 'RTX-4050', '16GB', '16 inch 165Hz',N'NCC10')
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [SoLuong], [GiaBan], [HinhAnh], [CPU], [VGA], [RAM], [DISPLAY],[MaNCC]) VALUES (N'SP25', N'Laptop Microsoft Surface', 20, 12500000, 'laptop25.jpg', 'i3-12700H', 'RTX-1090', '4GB', '14 inch 144Hz',N'NCC11')
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [SoLuong], [GiaBan], [HinhAnh], [CPU], [VGA], [RAM], [DISPLAY],[MaNCC]) VALUES (N'SP26', N'Laptop Razer Blade', 10, 15500000, 'laptop26.jpg', 'i7-12700H', 'RTX-2035', '8GB', '14 inch WQXGA OLED',N'NCC12')
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [SoLuong], [GiaBan], [HinhAnh], [CPU], [VGA], [RAM], [DISPLAY],[MaNCC]) VALUES (N'SP27', N'Laptop Gigabyte Aero', 18, 14500000, 'laptop27.jpg', 'i7-12700H', 'RTX-2050', '8GB', '14 inch WQXGA OLED',N'NCC13')
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [SoLuong], [GiaBan], [HinhAnh], [CPU], [VGA], [RAM], [DISPLAY],[MaNCC]) VALUES (N'SP28', N'Laptop Acer Swift', 20, 10000000, 'laptop28.jpg' , 'i5-12450H', 'RTX-2050', '8GB', '15.6" FHD 144Hz',N'NCC6')
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [SoLuong], [GiaBan], [HinhAnh], [CPU], [VGA], [RAM], [DISPLAY],[MaNCC]) VALUES (N'SP29', N'Laptop Huawei MateBook', 18, 11000000, 'laptop29.jpg', 'i7-12700H', 'RTX-2050', '8GB', '14 inch WQXGA OLED',N'NCC14')
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [SoLuong], [GiaBan], [HinhAnh], [CPU], [VGA], [RAM], [DISPLAY],[MaNCC]) VALUES (N'SP30', N'Laptop Samsung Galaxy Book', 25, 10500000, 'laptop30.jpg', 'r7-7725HS', 'RTX-4050', '16GB', '16 inch 165Hz',N'NCC7')
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [SoLuong], [GiaBan], [HinhAnh], [CPU], [VGA], [RAM], [DISPLAY],[MaNCC]) VALUES (N'SP31', N'Laptop Apple MacBook Air', 30, 13500000, 'laptop31.jpg', 'i7-12700H', 'RTX-2035', '8GB', '14 inch WQXGA OLED',N'NCC8')
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [SoLuong], [GiaBan], [HinhAnh], [CPU], [VGA], [RAM], [DISPLAY],[MaNCC]) VALUES (N'SP32', N'Laptop Google Pixelbook', 22, 12800000, 'laptop32.jpg', 'i7-12700H', 'RTX-2050', '8GB', '14 inch WQXGA OLED',N'NCC9')
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [SoLuong], [GiaBan], [HinhAnh], [CPU], [VGA], [RAM], [DISPLAY],[MaNCC]) VALUES (N'SP33', N'Laptop HP Pavilion', 14, 11500000, 'laptop33.jpg', 'i5-12450H', 'RTX-2050', '8GB', '15.6" FHD 144Hz',N'NCC10')
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [SoLuong], [GiaBan], [HinhAnh], [CPU], [VGA], [RAM], [DISPLAY],[MaNCC]) VALUES (N'SP34', N'Laptop Microsoft Surface', 20, 12500000, 'laptop34.jpg', 'i7-12700H', 'RTX-2050', '8GB', '14 inch WQXGA OLED',N'NCC11')
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [SoLuong], [GiaBan], [HinhAnh], [CPU], [VGA], [RAM], [DISPLAY],[MaNCC]) VALUES (N'SP35', N'Laptop Razer Blade', 10, 15500000, 'laptop35.jpg', 'i7-12700H', 'RTX-2050', '8GB', '14 inch WQXGA OLED',N'NCC12')
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [SoLuong], [GiaBan], [HinhAnh], [CPU], [VGA], [RAM], [DISPLAY],[MaNCC]) VALUES (N'SP36', N'Laptop Gigabyte Aero', 18, 14500000, 'laptop36.jpg', 'r7-7725HS', 'RTX-4050', '16GB', '16 inch 165Hz',N'NCC13')
GO
INSERT [dbo].[TAIKHOAN] ([MaTaiKhoan], [TenTaiKhoan], [MatKhau], [MaQuyen]) VALUES (N'1', N'admin', N'123', 1)
INSERT [dbo].[TAIKHOAN] ([MaTaiKhoan], [TenTaiKhoan], [MatKhau], [MaQuyen]) VALUES (N'2', N'user', N'123', 2)
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD FOREIGN KEY([MaKH])
REFERENCES [dbo].[KHACHHANG] ([MaKH])
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO

ALTER TABLE [dbo].[KHOHANG]  WITH CHECK ADD  CONSTRAINT [FK_KHOHANG_SANPHAM] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SANPHAM] ([MaSP])
GO
ALTER TABLE [dbo].[CHITIETHOADON]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETHOADON_SANPHAM] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SANPHAM] ([MaSP])
GO
ALTER TABLE [dbo].[CHITIETHOADON]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETHOADON_HOADON] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HOADON] ([MaHD])
GO

ALTER TABLE [dbo].[SANPHAM]  WITH CHECK ADD FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NHACUNGCAP] ([MaNCC])
GO
ALTER TABLE [dbo].[TAIKHOAN]  WITH CHECK ADD FOREIGN KEY([MaQuyen])
REFERENCES [dbo].[PHANQUYEN] ([MaQuyen])
GO
/****** Object:  StoredProcedure [dbo].[proc_DoiMatKhau]    Script Date: 11/30/2023 11:40:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_DoiMatKhau]
    @tenTaiKhoan NVARCHAR(50),
    @matKhauMoi NVARCHAR(50)
AS
BEGIN
    UPDATE TaiKhoan
    SET MatKhau = @matKhauMoi
    WHERE TenTaiKhoan = @tenTaiKhoan
END
GO
/****** Object:  StoredProcedure [dbo].[proc_login]    Script Date: 11/30/2023 11:40:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[proc_login]
@user nvarchar(50),
@pass nvarchar(50)
as
BEGIN
	SELECT * FROM TAIKHOAN WHERE TenTaiKhoan = @user AND MatKhau = @pass
END

GO
-- Tạo trigger cho bảng CHITIETHOADON
CREATE TRIGGER tr_CHITIETHOADON_AfterInsertUpdate
ON dbo.CHITIETHOADON
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE c
    SET ThanhTien = i.SoLuong * i.DonGia
    FROM dbo.CHITIETHOADON c
    INNER JOIN inserted i ON c.MaHD = i.MaHD AND c.MaSP = i.MaSP;
END;
GO