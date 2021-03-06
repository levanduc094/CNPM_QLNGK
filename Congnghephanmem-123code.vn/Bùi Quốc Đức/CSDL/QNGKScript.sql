USE [master]
GO
/****** Object:  Database [CNPM_QLNGK1]    Script Date: 5/27/2019 9:35:53 AM ******/
CREATE DATABASE [CNPM_QLNGK1]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CNPM_QLNGK1', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\CNPM_QLNGK1.mdf' , SIZE = 3136KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'CNPM_QLNGK1_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\CNPM_QLNGK1_log.ldf' , SIZE = 784KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [CNPM_QLNGK1] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CNPM_QLNGK1].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CNPM_QLNGK1] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CNPM_QLNGK1] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CNPM_QLNGK1] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CNPM_QLNGK1] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CNPM_QLNGK1] SET ARITHABORT OFF 
GO
ALTER DATABASE [CNPM_QLNGK1] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [CNPM_QLNGK1] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CNPM_QLNGK1] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CNPM_QLNGK1] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CNPM_QLNGK1] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CNPM_QLNGK1] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CNPM_QLNGK1] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CNPM_QLNGK1] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CNPM_QLNGK1] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CNPM_QLNGK1] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CNPM_QLNGK1] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CNPM_QLNGK1] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CNPM_QLNGK1] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CNPM_QLNGK1] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CNPM_QLNGK1] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CNPM_QLNGK1] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CNPM_QLNGK1] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CNPM_QLNGK1] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [CNPM_QLNGK1] SET  MULTI_USER 
GO
ALTER DATABASE [CNPM_QLNGK1] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CNPM_QLNGK1] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CNPM_QLNGK1] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CNPM_QLNGK1] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [CNPM_QLNGK1]
GO
/****** Object:  UserDefinedFunction [dbo].[giaD11]    Script Date: 5/27/2019 9:35:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[giaD11] (@maD int)
returns int
as
begin
declare @giaF int

select @giaF=price 
from Food
where idFood=@maD
return @giaF
end
GO
/****** Object:  UserDefinedFunction [dbo].[PriceDrink]    Script Date: 5/27/2019 9:35:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[PriceDrink] (@maD int)
returns int
as
begin
declare @giaD int

select @giaD=price 
from Drink
where idDrink=@maD
return @giaD
end
GO
/****** Object:  UserDefinedFunction [dbo].[PriceFood]    Script Date: 5/27/2019 9:35:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[PriceFood] (@maD int)
returns int
as
begin
declare @giaF int

select @giaF=price 
from Food
where idFood=@maD
return @giaF
end
GO
/****** Object:  Table [dbo].[Account]    Script Date: 5/27/2019 9:35:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](100) NULL,
	[DisplayName] [nvarchar](100) NULL,
	[Password] [nvarchar](100) NULL,
	[Type] [int] NULL,
 CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bill]    Script Date: 5/27/2019 9:35:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bill](
	[idBill] [int] IDENTITY(1,1) NOT NULL,
	[DateCheckIn] [date] NOT NULL,
	[DateCheckOut] [date] NULL,
	[idTable] [int] NOT NULL,
	[status] [int] NOT NULL,
	[discount] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idBill] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BillInfo]    Script Date: 5/27/2019 9:35:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BillInfo](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idBill] [int] NOT NULL,
	[idFood] [int] NOT NULL,
	[countF] [int] NULL,
	[idDrink] [int] NULL,
	[countD] [float] NOT NULL,
	[totalPrice] [int] NULL,
	[idEmp] [nvarchar](25) NULL,
 CONSTRAINT [PK__BillInfo__3213E83FA7649D71] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BookedTable]    Script Date: 5/27/2019 9:35:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BookedTable](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idTable] [int] NULL,
	[CustomerName] [nvarchar](30) NULL,
	[CustomerPhone] [nchar](12) NULL,
	[CustomerAddress] [nvarchar](60) NULL,
	[BookDate] [nchar](10) NULL,
	[BookTimeStart] [nchar](10) NULL,
	[BookTimeEnd] [nchar](10) NULL,
 CONSTRAINT [PK_BookedTables] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Drink]    Script Date: 5/27/2019 9:35:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Drink](
	[idDrink] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
	[idCategoryDrink] [int] NOT NULL,
	[price] [int] NOT NULL,
	[image] [nvarchar](50) NULL,
 CONSTRAINT [PK__Drink__2B658F5C0D142180] PRIMARY KEY CLUSTERED 
(
	[idDrink] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DrinkCategory]    Script Date: 5/27/2019 9:35:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DrinkCategory](
	[idCategoryDrink] [int] NOT NULL,
	[name] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_DrinkCategory] PRIMARY KEY CLUSTERED 
(
	[idCategoryDrink] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 5/27/2019 9:35:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[idEmp] [nvarchar](25) NOT NULL,
	[name] [nvarchar](50) NULL,
	[address] [nvarchar](60) NULL,
	[phone] [char](10) NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[idEmp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Food]    Script Date: 5/27/2019 9:35:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Food](
	[idFood] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
	[idCategoryFood] [int] NOT NULL,
	[price] [int] NOT NULL,
	[image] [nvarchar](50) NULL,
 CONSTRAINT [PK__Food__69D92BAA99B5FAC3] PRIMARY KEY CLUSTERED 
(
	[idFood] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FoodCategory]    Script Date: 5/27/2019 9:35:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FoodCategory](
	[idCategoryFood] [int] NOT NULL,
	[name] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_FoodCategory] PRIMARY KEY CLUSTERED 
(
	[idCategoryFood] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Table]    Script Date: 5/27/2019 9:35:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Table](
	[idTable] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
	[status] [bit] NOT NULL,
 CONSTRAINT [PK__TableFoo__716BDE2455247FE7] PRIMARY KEY CLUSTERED 
(
	[idTable] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Account] ON 

INSERT [dbo].[Account] ([id], [Username], [DisplayName], [Password], [Type]) VALUES (1, N'admin', N'aminaa', N'123', 1)
INSERT [dbo].[Account] ([id], [Username], [DisplayName], [Password], [Type]) VALUES (2, N'test', N'tester', N'12345', 1)
INSERT [dbo].[Account] ([id], [Username], [DisplayName], [Password], [Type]) VALUES (3, N'admin', N'admin', N'1', 1)
INSERT [dbo].[Account] ([id], [Username], [DisplayName], [Password], [Type]) VALUES (4, N'ng ', NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Account] OFF
SET IDENTITY_INSERT [dbo].[Bill] ON 

INSERT [dbo].[Bill] ([idBill], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount]) VALUES (5, CAST(N'2019-05-25' AS Date), CAST(N'2019-05-25' AS Date), 5, 0, 0)
INSERT [dbo].[Bill] ([idBill], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount]) VALUES (6, CAST(N'2019-03-21' AS Date), CAST(N'2019-05-15' AS Date), 4, 0, 0)
SET IDENTITY_INSERT [dbo].[Bill] OFF
SET IDENTITY_INSERT [dbo].[BillInfo] ON 

INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [countF], [idDrink], [countD], [totalPrice], [idEmp]) VALUES (1, 5, 2, 20, 2, 30, 30, N'NV01')
SET IDENTITY_INSERT [dbo].[BillInfo] OFF
SET IDENTITY_INSERT [dbo].[BookedTable] ON 

INSERT [dbo].[BookedTable] ([id], [idTable], [CustomerName], [CustomerPhone], [CustomerAddress], [BookDate], [BookTimeStart], [BookTimeEnd]) VALUES (1, 5, N'ád', N'0787        ', N'2_2018_2019', N'20/12/2018', N'5         ', N'6         ')
INSERT [dbo].[BookedTable] ([id], [idTable], [CustomerName], [CustomerPhone], [CustomerAddress], [BookDate], [BookTimeStart], [BookTimeEnd]) VALUES (2, 6, N'ád', N'qưqe        ', N'qưew', N'qưew      ', N'qewq      ', N'queqw     ')
INSERT [dbo].[BookedTable] ([id], [idTable], [CustomerName], [CustomerPhone], [CustomerAddress], [BookDate], [BookTimeStart], [BookTimeEnd]) VALUES (3, 7, N'ád', N'sad         ', N'ấ', N'đa        ', N'?         ', N'123       ')
INSERT [dbo].[BookedTable] ([id], [idTable], [CustomerName], [CustomerPhone], [CustomerAddress], [BookDate], [BookTimeStart], [BookTimeEnd]) VALUES (4, 4, N'd', N'sdf         ', N'sdf', N'â         ', N'aâ        ', N'â         ')
SET IDENTITY_INSERT [dbo].[BookedTable] OFF
SET IDENTITY_INSERT [dbo].[Drink] ON 

INSERT [dbo].[Drink] ([idDrink], [name], [idCategoryDrink], [price], [image]) VALUES (2, N'Trà Đào', 1, 20000, NULL)
INSERT [dbo].[Drink] ([idDrink], [name], [idCategoryDrink], [price], [image]) VALUES (3, N'Nước Cam', 2, 20000, NULL)
INSERT [dbo].[Drink] ([idDrink], [name], [idCategoryDrink], [price], [image]) VALUES (5, N'Nước Dâu', 2, 20000, NULL)
INSERT [dbo].[Drink] ([idDrink], [name], [idCategoryDrink], [price], [image]) VALUES (6, N'Trà Sữa', 4, 30000, NULL)
INSERT [dbo].[Drink] ([idDrink], [name], [idCategoryDrink], [price], [image]) VALUES (7, N'Cacao', 4, 50000, NULL)
SET IDENTITY_INSERT [dbo].[Drink] OFF
INSERT [dbo].[DrinkCategory] ([idCategoryDrink], [name]) VALUES (1, N'Trà')
INSERT [dbo].[DrinkCategory] ([idCategoryDrink], [name]) VALUES (2, N'Nước trái cây')
INSERT [dbo].[DrinkCategory] ([idCategoryDrink], [name]) VALUES (3, N'Nước ngọt')
INSERT [dbo].[DrinkCategory] ([idCategoryDrink], [name]) VALUES (4, N'Đồ uống khác')
INSERT [dbo].[Employees] ([idEmp], [name], [address], [phone]) VALUES (N'NV01', N'Bui duc', N'ha tinh', N'0321456   ')
INSERT [dbo].[Employees] ([idEmp], [name], [address], [phone]) VALUES (N'NV02', N'Dương dat', N'nghe an', N'0123456789')
INSERT [dbo].[Employees] ([idEmp], [name], [address], [phone]) VALUES (N'Nv03', N'Nguyen tuan', N'nghe an', N'0145269787')
SET IDENTITY_INSERT [dbo].[Food] ON 

INSERT [dbo].[Food] ([idFood], [name], [idCategoryFood], [price], [image]) VALUES (2, N'Kem', 1, 20000, N'tradau.png')
INSERT [dbo].[Food] ([idFood], [name], [idCategoryFood], [price], [image]) VALUES (3, N'KFC', 1, 30000, N'tradau.png')
INSERT [dbo].[Food] ([idFood], [name], [idCategoryFood], [price], [image]) VALUES (4, N'Khoai Tây chiên', 2, 20000, N'trabacha.jpg')
SET IDENTITY_INSERT [dbo].[Food] OFF
INSERT [dbo].[FoodCategory] ([idCategoryFood], [name]) VALUES (1, N'Thức ăn nhanh')
INSERT [dbo].[FoodCategory] ([idCategoryFood], [name]) VALUES (2, N'Thức ăn nhẹ')
SET IDENTITY_INSERT [dbo].[Table] ON 

INSERT [dbo].[Table] ([idTable], [name], [status]) VALUES (4, N'Ban 1', 1)
INSERT [dbo].[Table] ([idTable], [name], [status]) VALUES (5, N'Banf 2', 0)
INSERT [dbo].[Table] ([idTable], [name], [status]) VALUES (6, N'Ban1', 1)
INSERT [dbo].[Table] ([idTable], [name], [status]) VALUES (7, N'Ban 3', 1)
INSERT [dbo].[Table] ([idTable], [name], [status]) VALUES (10, N'Ban 98', 1)
INSERT [dbo].[Table] ([idTable], [name], [status]) VALUES (11, N'bàn 2', 0)
SET IDENTITY_INSERT [dbo].[Table] OFF
ALTER TABLE [dbo].[Bill] ADD  DEFAULT (getdate()) FOR [DateCheckIn]
GO
ALTER TABLE [dbo].[Bill] ADD  DEFAULT ((0)) FOR [status]
GO
ALTER TABLE [dbo].[BillInfo] ADD  CONSTRAINT [DF__BillInfo__count__1A14E395]  DEFAULT ((0)) FOR [countD]
GO
ALTER TABLE [dbo].[Drink] ADD  CONSTRAINT [DF__Drink__name__239E4DCF]  DEFAULT (N'Chưa đặt tên') FOR [name]
GO
ALTER TABLE [dbo].[Drink] ADD  CONSTRAINT [DF__Drink__price__24927208]  DEFAULT ((0)) FOR [price]
GO
ALTER TABLE [dbo].[DrinkCategory] ADD  CONSTRAINT [DF__DrinkCateg__name__2D27B809]  DEFAULT (N'Chưa đặt tên') FOR [name]
GO
ALTER TABLE [dbo].[Food] ADD  CONSTRAINT [DF__Food__name__267ABA7A]  DEFAULT (N'Chưa đặt tên') FOR [name]
GO
ALTER TABLE [dbo].[Food] ADD  CONSTRAINT [DF__Food__price__276EDEB3]  DEFAULT ((0)) FOR [price]
GO
ALTER TABLE [dbo].[FoodCategory] ADD  CONSTRAINT [DF__FoodCatego__name__239E4DCF]  DEFAULT (N'Chưa đặt tên') FOR [name]
GO
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD  CONSTRAINT [FK_Bill_Table] FOREIGN KEY([idTable])
REFERENCES [dbo].[Table] ([idTable])
GO
ALTER TABLE [dbo].[Bill] CHECK CONSTRAINT [FK_Bill_Table]
GO
ALTER TABLE [dbo].[BillInfo]  WITH CHECK ADD  CONSTRAINT [FK_BillInfo_Bill] FOREIGN KEY([idBill])
REFERENCES [dbo].[Bill] ([idBill])
GO
ALTER TABLE [dbo].[BillInfo] CHECK CONSTRAINT [FK_BillInfo_Bill]
GO
ALTER TABLE [dbo].[BillInfo]  WITH CHECK ADD  CONSTRAINT [FK_BillInfo_Drink] FOREIGN KEY([idDrink])
REFERENCES [dbo].[Drink] ([idDrink])
GO
ALTER TABLE [dbo].[BillInfo] CHECK CONSTRAINT [FK_BillInfo_Drink]
GO
ALTER TABLE [dbo].[BillInfo]  WITH CHECK ADD  CONSTRAINT [FK_BillInfo_Employees] FOREIGN KEY([idEmp])
REFERENCES [dbo].[Employees] ([idEmp])
GO
ALTER TABLE [dbo].[BillInfo] CHECK CONSTRAINT [FK_BillInfo_Employees]
GO
ALTER TABLE [dbo].[BillInfo]  WITH CHECK ADD  CONSTRAINT [FK_BillInfo_Food] FOREIGN KEY([idFood])
REFERENCES [dbo].[Food] ([idFood])
GO
ALTER TABLE [dbo].[BillInfo] CHECK CONSTRAINT [FK_BillInfo_Food]
GO
ALTER TABLE [dbo].[BookedTable]  WITH CHECK ADD  CONSTRAINT [FK_BookedTable_Table] FOREIGN KEY([idTable])
REFERENCES [dbo].[Table] ([idTable])
GO
ALTER TABLE [dbo].[BookedTable] CHECK CONSTRAINT [FK_BookedTable_Table]
GO
ALTER TABLE [dbo].[Drink]  WITH CHECK ADD  CONSTRAINT [FK_Drink_DrinkCategory] FOREIGN KEY([idCategoryDrink])
REFERENCES [dbo].[DrinkCategory] ([idCategoryDrink])
GO
ALTER TABLE [dbo].[Drink] CHECK CONSTRAINT [FK_Drink_DrinkCategory]
GO
ALTER TABLE [dbo].[Food]  WITH CHECK ADD  CONSTRAINT [FK_Food_FoodCategory] FOREIGN KEY([idCategoryFood])
REFERENCES [dbo].[FoodCategory] ([idCategoryFood])
GO
ALTER TABLE [dbo].[Food] CHECK CONSTRAINT [FK_Food_FoodCategory]
GO
/****** Object:  StoredProcedure [dbo].[aaaa]    Script Date: 5/27/2019 9:35:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[aaaa](@id int)
as
begin
PriceFood(@id)
end
GO
/****** Object:  StoredProcedure [dbo].[bbbb]    Script Date: 5/27/2019 9:35:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[bbbb](@id int)
as
begin
PriceDrink(@id)
end
GO
/****** Object:  StoredProcedure [dbo].[giaD]    Script Date: 5/27/2019 9:35:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[giaD] (@giaF int out, @maD int)
as
select price 
from Food
where idFood=@maD
GO
USE [master]
GO
ALTER DATABASE [CNPM_QLNGK1] SET  READ_WRITE 
GO
