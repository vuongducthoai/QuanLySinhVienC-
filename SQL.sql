USE [master]
GO
/****** Object:  Database [dbQuanLySV]    Script Date: 12/21/2024 10:39:08 PM ******/
CREATE DATABASE [dbQuanLySV]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'dbQuanLySV', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\dbQuanLySV.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'dbQuanLySV_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\dbQuanLySV_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [dbQuanLySV] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [dbQuanLySV].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [dbQuanLySV] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [dbQuanLySV] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [dbQuanLySV] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [dbQuanLySV] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [dbQuanLySV] SET ARITHABORT OFF 
GO
ALTER DATABASE [dbQuanLySV] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [dbQuanLySV] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [dbQuanLySV] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [dbQuanLySV] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [dbQuanLySV] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [dbQuanLySV] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [dbQuanLySV] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [dbQuanLySV] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [dbQuanLySV] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [dbQuanLySV] SET  DISABLE_BROKER 
GO
ALTER DATABASE [dbQuanLySV] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [dbQuanLySV] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [dbQuanLySV] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [dbQuanLySV] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [dbQuanLySV] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [dbQuanLySV] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [dbQuanLySV] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [dbQuanLySV] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [dbQuanLySV] SET  MULTI_USER 
GO
ALTER DATABASE [dbQuanLySV] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [dbQuanLySV] SET DB_CHAINING OFF 
GO
ALTER DATABASE [dbQuanLySV] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [dbQuanLySV] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [dbQuanLySV] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [dbQuanLySV] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'dbQuanLySV', N'ON'
GO
ALTER DATABASE [dbQuanLySV] SET QUERY_STORE = ON
GO
ALTER DATABASE [dbQuanLySV] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [dbQuanLySV]
GO
/****** Object:  Table [dbo].[dangnhap]    Script Date: 12/21/2024 10:39:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dangnhap](
	[username] [varchar](32) NOT NULL,
	[password] [nvarchar](64) NOT NULL,
	[fullname] [nvarchar](64) NOT NULL,
	[email] [varchar](32) NULL,
	[mod] [nvarchar](16) NOT NULL,
	[state] [nvarchar](32) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[dbo.Diem]    Script Date: 12/21/2024 10:39:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dbo.Diem](
	[MaSV] [nchar](10) NOT NULL,
	[MaMH] [nchar](10) NULL,
	[DiemTB] [float] NULL,
 CONSTRAINT [PK_dbo.Diem] PRIMARY KEY CLUSTERED 
(
	[MaSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[dbo.Khoa]    Script Date: 12/21/2024 10:39:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dbo.Khoa](
	[MaKhoa] [nchar](10) NOT NULL,
	[TenKhoa] [nchar](10) NULL,
 CONSTRAINT [PK_dbo.Khoa] PRIMARY KEY CLUSTERED 
(
	[MaKhoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[hocsinh]    Script Date: 12/21/2024 10:39:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hocsinh](
	[mahs] [varchar](32) NOT NULL,
	[hoten] [nvarchar](64) NOT NULL,
	[ngaysinh] [datetime] NOT NULL,
	[gioitinh] [nvarchar](16) NOT NULL,
	[quequan] [nvarchar](64) NULL,
	[diemtb] [decimal](14, 2) NULL,
	[maloplt] [varchar](32) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[mahs] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[lop]    Script Date: 12/21/2024 10:39:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[lop](
	[MaLop] [varchar](32) NOT NULL,
	[tenlop] [nvarchar](64) NOT NULL,
	[email] [varchar](32) NULL,
	[hoten] [nvarchar](64) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[dangnhap] ([username], [password], [fullname], [email], [mod], [state]) VALUES (N'AD', N'123456', N'Tô Hà', N'tpt@gmail.com', N'Quản trị viên', N'Còn sử dụng')
INSERT [dbo].[dangnhap] ([username], [password], [fullname], [email], [mod], [state]) VALUES (N'HM', N'123456', N'Hồng My', N'my@gmail.com', N'Người dùng', N'Còn sử dụng')
INSERT [dbo].[dangnhap] ([username], [password], [fullname], [email], [mod], [state]) VALUES (N'US', N'123456', N'User thường', N'us@gmail.com', N'Người dùng', N'Còn sử dụng')
GO
INSERT [dbo].[hocsinh] ([mahs], [hoten], [ngaysinh], [gioitinh], [quequan], [diemtb], [maloplt]) VALUES (N'SV01', N'Tô Hà', CAST(N'2000-06-28T00:00:00.000' AS DateTime), N'Nữ', N'Hà Nội', CAST(9.80 AS Decimal(14, 2)), N'LOP01')
INSERT [dbo].[hocsinh] ([mahs], [hoten], [ngaysinh], [gioitinh], [quequan], [diemtb], [maloplt]) VALUES (N'SV02', N'Nguyễn Thị Mỹ Trinh', CAST(N'2000-11-13T00:00:00.000' AS DateTime), N'Nữ', N'Cà Mau', CAST(8.60 AS Decimal(14, 2)), N'LOP01')
INSERT [dbo].[hocsinh] ([mahs], [hoten], [ngaysinh], [gioitinh], [quequan], [diemtb], [maloplt]) VALUES (N'SV03', N'Lê Thị Hồng Nhung', CAST(N'2000-02-18T00:00:00.000' AS DateTime), N'Nữ', N'Đà Năng', CAST(10.00 AS Decimal(14, 2)), N'LOP02')
INSERT [dbo].[hocsinh] ([mahs], [hoten], [ngaysinh], [gioitinh], [quequan], [diemtb], [maloplt]) VALUES (N'SV04', N'Minh Hiếu', CAST(N'2032-01-01T00:00:00.000' AS DateTime), N'Nam', N'Hồ Chí Minh', CAST(8.00 AS Decimal(14, 2)), N'LOP03')
INSERT [dbo].[hocsinh] ([mahs], [hoten], [ngaysinh], [gioitinh], [quequan], [diemtb], [maloplt]) VALUES (N'SV05', N'VDT', CAST(N'2024-02-15T00:00:00.000' AS DateTime), N'Nam', N'PY', CAST(10.00 AS Decimal(14, 2)), N'LOP01')
GO
INSERT [dbo].[lop] ([MaLop], [tenlop], [email], [hoten]) VALUES (N'LOP01', N'CNTTA1', N'LOP01@gmail.com', N'Trần Lê Nguyễn')
INSERT [dbo].[lop] ([MaLop], [tenlop], [email], [hoten]) VALUES (N'LOP02', N'CNTTA2', N'LOP02@gmail.com', N'Nguyễn Lê Văn')
INSERT [dbo].[lop] ([MaLop], [tenlop], [email], [hoten]) VALUES (N'LOP03', N'KHDL', N'LOP03@gmail.com', N'Trần Minh Hiếu')
GO
ALTER TABLE [dbo].[hocsinh]  WITH CHECK ADD FOREIGN KEY([maloplt])
REFERENCES [dbo].[lop] ([MaLop])
GO
USE [master]
GO
ALTER DATABASE [dbQuanLySV] SET  READ_WRITE 
GO
