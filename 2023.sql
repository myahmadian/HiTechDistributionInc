USE [master]
GO
/****** Object:  Database [HiTechDistributionInc]    Script Date: 10/16/2023 9:50:35 AM ******/
CREATE DATABASE [HiTechDistributionInc]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'HiTechDistributionInc', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\HiTechDistributionInc.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'HiTechDistributionInc_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\HiTechDistributionInc_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [HiTechDistributionInc] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HiTechDistributionInc].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HiTechDistributionInc] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HiTechDistributionInc] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HiTechDistributionInc] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HiTechDistributionInc] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HiTechDistributionInc] SET ARITHABORT OFF 
GO
ALTER DATABASE [HiTechDistributionInc] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [HiTechDistributionInc] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HiTechDistributionInc] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HiTechDistributionInc] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HiTechDistributionInc] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HiTechDistributionInc] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HiTechDistributionInc] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HiTechDistributionInc] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HiTechDistributionInc] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HiTechDistributionInc] SET  DISABLE_BROKER 
GO
ALTER DATABASE [HiTechDistributionInc] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HiTechDistributionInc] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HiTechDistributionInc] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HiTechDistributionInc] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HiTechDistributionInc] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HiTechDistributionInc] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [HiTechDistributionInc] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HiTechDistributionInc] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [HiTechDistributionInc] SET  MULTI_USER 
GO
ALTER DATABASE [HiTechDistributionInc] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HiTechDistributionInc] SET DB_CHAINING OFF 
GO
ALTER DATABASE [HiTechDistributionInc] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [HiTechDistributionInc] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [HiTechDistributionInc] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [HiTechDistributionInc] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [HiTechDistributionInc] SET QUERY_STORE = ON
GO
ALTER DATABASE [HiTechDistributionInc] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [HiTechDistributionInc]
GO
/****** Object:  Table [dbo].[Authors]    Script Date: 10/16/2023 9:50:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Authors](
	[AuthorId] [varchar](11) NOT NULL,
	[LastName] [varchar](40) NOT NULL,
	[FirstName] [varchar](20) NOT NULL,
	[PhoneNumber] [char](13) NOT NULL,
	[Email] [varchar](40) NULL,
	[address] [varchar](40) NULL,
	[city] [varchar](20) NULL,
	[state] [char](2) NULL,
	[PostalCode] [char](6) NULL,
	[contract] [bit] NOT NULL,
 CONSTRAINT [UPKCL_auidind] PRIMARY KEY CLUSTERED 
(
	[AuthorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Books]    Script Date: 10/16/2023 9:50:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Books](
	[ISBN] [varchar](6) NOT NULL,
	[Title] [varchar](80) NOT NULL,
	[type] [char](12) NOT NULL,
	[publisherId] [char](4) NULL,
	[UnitPrice] [money] NULL,
	[advance] [money] NULL,
	[royalty] [int] NULL,
	[ytd_sales] [int] NULL,
	[notes] [varchar](200) NULL,
	[YearPublished] [datetime] NOT NULL,
	[QOH] [int] NOT NULL,
	[CategoryId] [int] NOT NULL,
 CONSTRAINT [UPKCL_ISBNind] PRIMARY KEY CLUSTERED 
(
	[ISBN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AuthorBooks]    Script Date: 10/16/2023 9:50:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AuthorBooks](
	[AuthorId] [varchar](11) NOT NULL,
	[ISBN] [varchar](6) NOT NULL,
	[Edition] [tinyint] NULL,
	[royaltyper] [int] NULL,
	[YearPublished] [datetime] NOT NULL,
 CONSTRAINT [UPKCL_taind] PRIMARY KEY CLUSTERED 
(
	[AuthorId] ASC,
	[ISBN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[titleview]    Script Date: 10/16/2023 9:50:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[titleview]
AS
select Title, Edition, LastName, UnitPrice, ytd_sales, publisherId
from Authors, Books, AuthorBooks
where Authors.AuthorId = AuthorBooks.AuthorId
   AND Books.ISBN = AuthorBooks.ISBN

GO
/****** Object:  Table [dbo].[Categories]    Script Date: 10/16/2023 9:50:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[CategorId] [int] NOT NULL,
	[CategoryName] [varchar](30) NOT NULL,
 CONSTRAINT [UPK_CategorId] PRIMARY KEY CLUSTERED 
(
	[CategorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 10/16/2023 9:50:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[CustomersId] [char](4) NOT NULL,
	[CustomerName] [varchar](40) NULL,
	[CustomerAddress] [varchar](40) NULL,
	[city] [varchar](20) NULL,
	[state] [char](2) NULL,
	[PostalCode] [char](6) NULL,
	[PhoneNumber] [char](13) NOT NULL,
	[FaxNumber] [char](13) NOT NULL,
	[CreditLimit] [money] NULL,
	[Email] [varchar](40) NULL,
 CONSTRAINT [UPK_CustomersId] PRIMARY KEY CLUSTERED 
(
	[CustomersId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[discounts]    Script Date: 10/16/2023 9:50:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[discounts](
	[discounttype] [varchar](40) NOT NULL,
	[CustomersId] [char](4) NULL,
	[lowqty] [smallint] NULL,
	[highqty] [smallint] NULL,
	[discount] [decimal](4, 2) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 10/16/2023 9:50:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[EmployeeID] [varchar](9) NOT NULL,
	[FirstName] [varchar](20) NOT NULL,
	[minit] [char](1) NULL,
	[LastName] [varchar](30) NOT NULL,
	[JobID] [smallint] NOT NULL,
	[job_lvl] [tinyint] NULL,
	[publisherId] [char](4) NOT NULL,
	[hire_date] [datetime] NOT NULL,
	[phoneNumber] [char](13) NOT NULL,
	[Email] [varchar](40) NULL,
	[StatusId] [int] NOT NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [Employees_ind]    Script Date: 10/16/2023 9:50:35 AM ******/
CREATE CLUSTERED INDEX [Employees_ind] ON [dbo].[Employees]
(
	[LastName] ASC,
	[FirstName] ASC,
	[minit] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[jobPositions]    Script Date: 10/16/2023 9:50:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[jobPositions](
	[JobID] [smallint] IDENTITY(1,1) NOT NULL,
	[JobTitle] [varchar](50) NOT NULL,
	[min_lvl] [tinyint] NOT NULL,
	[max_lvl] [tinyint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[JobID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetails]    Script Date: 10/16/2023 9:50:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetails](
	[OrderId] [varchar](20) NOT NULL,
	[QuantityOrdered] [smallint] NOT NULL,
	[ISBN] [varchar](6) NOT NULL,
 CONSTRAINT [UPKCL_OrderDetails] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC,
	[ISBN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 10/16/2023 9:50:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[CustomersId] [char](4) NOT NULL,
	[OrderId] [varchar](20) NOT NULL,
	[OrderDate] [datetime] NOT NULL,
	[RequiredDate] [datetime] NOT NULL,
	[ShippingDate] [datetime] NOT NULL,
	[payterms] [varchar](12) NOT NULL,
	[orderType] [varchar](12) NULL,
	[StatusId] [int] NULL,
	[EmployeeId] [varchar](9) NULL,
	[Payment] [money] NULL,
 CONSTRAINT [UPKCL_Orders] PRIMARY KEY CLUSTERED 
(
	[CustomersId] ASC,
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[pub_info]    Script Date: 10/16/2023 9:50:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pub_info](
	[publisherId] [char](4) NOT NULL,
	[logo] [image] NULL,
	[pr_info] [text] NULL,
 CONSTRAINT [UPKCL_pubinfo] PRIMARY KEY CLUSTERED 
(
	[publisherId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[publishers]    Script Date: 10/16/2023 9:50:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[publishers](
	[publisherId] [char](4) NOT NULL,
	[publisherName] [varchar](40) NULL,
	[WebAddress] [varchar](50) NULL,
	[city] [varchar](20) NULL,
	[state] [char](2) NULL,
	[country] [varchar](30) NULL,
 CONSTRAINT [UPKCL_pubind] PRIMARY KEY CLUSTERED 
(
	[publisherId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[roysched]    Script Date: 10/16/2023 9:50:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[roysched](
	[ISBN] [varchar](6) NOT NULL,
	[lorange] [int] NULL,
	[hirange] [int] NULL,
	[royalty] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UsersAccount]    Script Date: 10/16/2023 9:50:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsersAccount](
	[EmployeeID] [varchar](9) NOT NULL,
	[UserID] [varchar](20) NOT NULL,
	[PassWord] [varchar](20) NOT NULL,
 CONSTRAINT [UPK_UserID] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[AuthorBooks] ([AuthorId], [ISBN], [Edition], [royaltyper], [YearPublished]) VALUES (N'172-32-1176', N'PS3333', 1, 100, CAST(N'2019-06-12T00:00:00.000' AS DateTime))
INSERT [dbo].[AuthorBooks] ([AuthorId], [ISBN], [Edition], [royaltyper], [YearPublished]) VALUES (N'213-46-8915', N'BU1032', 2, 40, CAST(N'2019-06-12T00:00:00.000' AS DateTime))
INSERT [dbo].[AuthorBooks] ([AuthorId], [ISBN], [Edition], [royaltyper], [YearPublished]) VALUES (N'213-46-8915', N'BU2075', 1, 100, CAST(N'2019-06-12T00:00:00.000' AS DateTime))
INSERT [dbo].[AuthorBooks] ([AuthorId], [ISBN], [Edition], [royaltyper], [YearPublished]) VALUES (N'238-95-7766', N'PC1035', 1, 100, CAST(N'2019-06-12T00:00:00.000' AS DateTime))
INSERT [dbo].[AuthorBooks] ([AuthorId], [ISBN], [Edition], [royaltyper], [YearPublished]) VALUES (N'267-41-2394', N'BU1111', 2, 40, CAST(N'2019-06-12T00:00:00.000' AS DateTime))
INSERT [dbo].[AuthorBooks] ([AuthorId], [ISBN], [Edition], [royaltyper], [YearPublished]) VALUES (N'267-41-2394', N'TC7777', 2, 30, CAST(N'2019-06-12T00:00:00.000' AS DateTime))
INSERT [dbo].[AuthorBooks] ([AuthorId], [ISBN], [Edition], [royaltyper], [YearPublished]) VALUES (N'274-80-9391', N'BU7832', 1, 100, CAST(N'2019-06-12T00:00:00.000' AS DateTime))
INSERT [dbo].[AuthorBooks] ([AuthorId], [ISBN], [Edition], [royaltyper], [YearPublished]) VALUES (N'409-56-7008', N'BU1032', 1, 60, CAST(N'2019-06-12T00:00:00.000' AS DateTime))
INSERT [dbo].[AuthorBooks] ([AuthorId], [ISBN], [Edition], [royaltyper], [YearPublished]) VALUES (N'427-17-2319', N'PC8888', 1, 50, CAST(N'2019-06-12T00:00:00.000' AS DateTime))
INSERT [dbo].[AuthorBooks] ([AuthorId], [ISBN], [Edition], [royaltyper], [YearPublished]) VALUES (N'472-27-2349', N'TC7777', 3, 30, CAST(N'2019-06-12T00:00:00.000' AS DateTime))
INSERT [dbo].[AuthorBooks] ([AuthorId], [ISBN], [Edition], [royaltyper], [YearPublished]) VALUES (N'486-29-1786', N'PC9999', 1, 100, CAST(N'2019-06-12T00:00:00.000' AS DateTime))
INSERT [dbo].[AuthorBooks] ([AuthorId], [ISBN], [Edition], [royaltyper], [YearPublished]) VALUES (N'486-29-1786', N'PS7777', 1, 100, CAST(N'2019-06-12T00:00:00.000' AS DateTime))
INSERT [dbo].[AuthorBooks] ([AuthorId], [ISBN], [Edition], [royaltyper], [YearPublished]) VALUES (N'648-92-1872', N'TC4203', 1, 100, CAST(N'2019-06-12T00:00:00.000' AS DateTime))
INSERT [dbo].[AuthorBooks] ([AuthorId], [ISBN], [Edition], [royaltyper], [YearPublished]) VALUES (N'672-71-3249', N'TC7777', 1, 40, CAST(N'2019-06-12T00:00:00.000' AS DateTime))
INSERT [dbo].[AuthorBooks] ([AuthorId], [ISBN], [Edition], [royaltyper], [YearPublished]) VALUES (N'712-45-1867', N'MC2222', 1, 100, CAST(N'2019-06-12T00:00:00.000' AS DateTime))
INSERT [dbo].[AuthorBooks] ([AuthorId], [ISBN], [Edition], [royaltyper], [YearPublished]) VALUES (N'722-51-5454', N'MC3021', 1, 75, CAST(N'2019-06-12T00:00:00.000' AS DateTime))
INSERT [dbo].[AuthorBooks] ([AuthorId], [ISBN], [Edition], [royaltyper], [YearPublished]) VALUES (N'724-80-9391', N'BU1111', 1, 60, CAST(N'2019-06-12T00:00:00.000' AS DateTime))
INSERT [dbo].[AuthorBooks] ([AuthorId], [ISBN], [Edition], [royaltyper], [YearPublished]) VALUES (N'724-80-9391', N'PS1372', 2, 25, CAST(N'2019-06-12T00:00:00.000' AS DateTime))
INSERT [dbo].[AuthorBooks] ([AuthorId], [ISBN], [Edition], [royaltyper], [YearPublished]) VALUES (N'756-30-7391', N'PS1372', 1, 75, CAST(N'2019-06-12T00:00:00.000' AS DateTime))
INSERT [dbo].[AuthorBooks] ([AuthorId], [ISBN], [Edition], [royaltyper], [YearPublished]) VALUES (N'807-91-6654', N'TC3218', 1, 100, CAST(N'2019-06-12T00:00:00.000' AS DateTime))
INSERT [dbo].[AuthorBooks] ([AuthorId], [ISBN], [Edition], [royaltyper], [YearPublished]) VALUES (N'846-92-7186', N'PC8888', 2, 50, CAST(N'2019-06-12T00:00:00.000' AS DateTime))
INSERT [dbo].[AuthorBooks] ([AuthorId], [ISBN], [Edition], [royaltyper], [YearPublished]) VALUES (N'899-46-2035', N'MC3021', 2, 25, CAST(N'2019-06-12T00:00:00.000' AS DateTime))
INSERT [dbo].[AuthorBooks] ([AuthorId], [ISBN], [Edition], [royaltyper], [YearPublished]) VALUES (N'899-46-2035', N'PS2091', 2, 50, CAST(N'2019-06-12T00:00:00.000' AS DateTime))
INSERT [dbo].[AuthorBooks] ([AuthorId], [ISBN], [Edition], [royaltyper], [YearPublished]) VALUES (N'998-72-3567', N'PS2091', 1, 50, CAST(N'2019-06-12T00:00:00.000' AS DateTime))
INSERT [dbo].[AuthorBooks] ([AuthorId], [ISBN], [Edition], [royaltyper], [YearPublished]) VALUES (N'998-72-3567', N'PS2106', 1, 100, CAST(N'2019-06-12T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Authors] ([AuthorId], [LastName], [FirstName], [PhoneNumber], [Email], [address], [city], [state], [PostalCode], [contract]) VALUES (N'172-32-1176', N'White', N'Johnson', N'(408)496-7223', N'WhiteJohnson@gmail.com', N'10932 Bigge Rd.', N'Menlo Park', N'CA', N'H3S2S9', 1)
INSERT [dbo].[Authors] ([AuthorId], [LastName], [FirstName], [PhoneNumber], [Email], [address], [city], [state], [PostalCode], [contract]) VALUES (N'213-46-8915', N'Green', N'Marjorie', N'(415)986-7020', N'GreenMarjorie@gmail.com', N'309 63rd St. #411', N'Oakland', N'CA', N'H3S1S2', 1)
INSERT [dbo].[Authors] ([AuthorId], [LastName], [FirstName], [PhoneNumber], [Email], [address], [city], [state], [PostalCode], [contract]) VALUES (N'238-95-7766', N'Carson', N'Cheryl', N'(415)548-7723', N'CarsonCheryl@gmail.com', N'589 Darwin Ln.', N'Berkeley', N'CA', N'H3S1S3', 1)
INSERT [dbo].[Authors] ([AuthorId], [LastName], [FirstName], [PhoneNumber], [Email], [address], [city], [state], [PostalCode], [contract]) VALUES (N'267-41-2394', N'O''Leary', N'Michael', N'(408)286-2428', N'LearyMichael@gmail.com', N'22 Cleveland Av. #14', N'San Jose', N'CA', N'H3S2S6', 1)
INSERT [dbo].[Authors] ([AuthorId], [LastName], [FirstName], [PhoneNumber], [Email], [address], [city], [state], [PostalCode], [contract]) VALUES (N'274-80-9391', N'Straight', N'Dean', N'(415)834-2919', N'StraightDean@gmail.com', N'5420 College Av.', N'Oakland', N'CA', N'H3S2S1', 1)
INSERT [dbo].[Authors] ([AuthorId], [LastName], [FirstName], [PhoneNumber], [Email], [address], [city], [state], [PostalCode], [contract]) VALUES (N'341-22-1782', N'Smith', N'Meander', N'(913)843-0462', N'SmithMeander@gmail.com', N'10 Mississippi Dr.', N'Lawrence', N'KS', N'H3S3S5', 0)
INSERT [dbo].[Authors] ([AuthorId], [LastName], [FirstName], [PhoneNumber], [Email], [address], [city], [state], [PostalCode], [contract]) VALUES (N'409-56-7008', N'Bennet', N'Abraham', N'(415)658-9932', N'BennetAbraham@gmail.com', N'6223 Bateman St.', N'Berkeley', N'CA', N'H3S1S1', 1)
INSERT [dbo].[Authors] ([AuthorId], [LastName], [FirstName], [PhoneNumber], [Email], [address], [city], [state], [PostalCode], [contract]) VALUES (N'427-17-2319', N'Dull', N'Ann', N'(415)836-7128', N'DullAnn@gmail.com', N'3410 Blonde St.', N'Palo Alto', N'CA', N'H3S2S4', 1)
INSERT [dbo].[Authors] ([AuthorId], [LastName], [FirstName], [PhoneNumber], [Email], [address], [city], [state], [PostalCode], [contract]) VALUES (N'472-27-2349', N'Gringlesby', N'Burt', N'(707)938-6445', N'GringlesbyBurt@gmail.com', N'PO Box 792', N'Covelo', N'CA', N'H3S2S7', 1)
INSERT [dbo].[Authors] ([AuthorId], [LastName], [FirstName], [PhoneNumber], [Email], [address], [city], [state], [PostalCode], [contract]) VALUES (N'486-29-1786', N'Locksley', N'Charlene', N'(415)585-4620', N'LocksleyCharlene@gmail.com', N'18 Broadway Av.', N'San Francisco', N'CA', N'H3S3S3', 1)
INSERT [dbo].[Authors] ([AuthorId], [LastName], [FirstName], [PhoneNumber], [Email], [address], [city], [state], [PostalCode], [contract]) VALUES (N'527-72-3246', N'Greene', N'Morningstar', N'(615)297-2723', N'GreeneMorningstar@gmail.com', N'22 Graybar House Rd.', N'Nashville', N'TN', N'H3S2S8', 0)
INSERT [dbo].[Authors] ([AuthorId], [LastName], [FirstName], [PhoneNumber], [Email], [address], [city], [state], [PostalCode], [contract]) VALUES (N'648-92-1872', N'Blotchet-Halls', N'Reginald', N'(503)745-6402', N'Blotchet-HallsReginald@gmail.com', N'55 Hillsdale Bl.', N'Corvallis', N'OR', N'H3S3S4', 1)
INSERT [dbo].[Authors] ([AuthorId], [LastName], [FirstName], [PhoneNumber], [Email], [address], [city], [state], [PostalCode], [contract]) VALUES (N'672-71-3249', N'Yokomoto', N'Akiko', N'(415)935-4228', N'YokomotoAkiko@gmail.com', N'3 Silver Ct.', N'Walnut Creek', N'CA', N'H3S2S5', 1)
INSERT [dbo].[Authors] ([AuthorId], [LastName], [FirstName], [PhoneNumber], [Email], [address], [city], [state], [PostalCode], [contract]) VALUES (N'712-45-1867', N'del Castillo', N'Innes', N'(615)996-8275', N'del CastilloInnes@gmail.com', N'2286 Cram Pl. #86', N'Ann Arbor', N'MI', N'H3S3S1', 1)
INSERT [dbo].[Authors] ([AuthorId], [LastName], [FirstName], [PhoneNumber], [Email], [address], [city], [state], [PostalCode], [contract]) VALUES (N'722-51-5454', N'DeFrance', N'Michel', N'(219)547-9982', N'DeFranceMichel@gmail.com', N'3 Balding Pl.', N'Gary', N'IN', N'H3S1S6', 1)
INSERT [dbo].[Authors] ([AuthorId], [LastName], [FirstName], [PhoneNumber], [Email], [address], [city], [state], [PostalCode], [contract]) VALUES (N'724-08-9931', N'Stringer', N'Dirk', N'(415)843-2991', N'StringerDirk@gmail.com', N'5420 Telegraph Av.', N'Oakland', N'CA', N'H3S1S9', 0)
INSERT [dbo].[Authors] ([AuthorId], [LastName], [FirstName], [PhoneNumber], [Email], [address], [city], [state], [PostalCode], [contract]) VALUES (N'724-80-9391', N'MacFeather', N'Stearns', N'(415)354-7128', N'MacFeatherStearns@gmail.com', N'44 Upland Hts.', N'Oakland', N'CA', N'H3S2S3', 1)
INSERT [dbo].[Authors] ([AuthorId], [LastName], [FirstName], [PhoneNumber], [Email], [address], [city], [state], [PostalCode], [contract]) VALUES (N'756-30-7391', N'Karsen', N'Livia', N'(415)534-9219', N'KarsenLivia@gmail.com', N'5720 McAuley St.', N'Oakland', N'CA', N'H3S2S2', 1)
INSERT [dbo].[Authors] ([AuthorId], [LastName], [FirstName], [PhoneNumber], [Email], [address], [city], [state], [PostalCode], [contract]) VALUES (N'807-91-6654', N'Panteley', N'Sylvia', N'(301)946-8853', N'PanteleySylvia@gmail.com', N'1956 Arlington Pl.', N'Rockville', N'MD', N'H3S1S7', 1)
INSERT [dbo].[Authors] ([AuthorId], [LastName], [FirstName], [PhoneNumber], [Email], [address], [city], [state], [PostalCode], [contract]) VALUES (N'846-92-7186', N'Hunter', N'Sheryl', N'(415)836-7128', N'HunterSheryl@gmail.com', N'3410 Blonde St.', N'Palo Alto', N'CA', N'H3S3S2', 1)
INSERT [dbo].[Authors] ([AuthorId], [LastName], [FirstName], [PhoneNumber], [Email], [address], [city], [state], [PostalCode], [contract]) VALUES (N'893-72-1158', N'McBadden', N'Heather', N'(707)448-4982', N'McBaddenHeather@gmail.com', N'301 Putnam', N'Vacaville', N'CA', N'H3S1S8', 0)
INSERT [dbo].[Authors] ([AuthorId], [LastName], [FirstName], [PhoneNumber], [Email], [address], [city], [state], [PostalCode], [contract]) VALUES (N'899-46-2035', N'Ringer', N'Anne', N'(801)826-0752', N'RingerAnne@gmail.com', N'67 Seventh Av.', N'Salt Lake City', N'UT', N'H3S1S5', 1)
INSERT [dbo].[Authors] ([AuthorId], [LastName], [FirstName], [PhoneNumber], [Email], [address], [city], [state], [PostalCode], [contract]) VALUES (N'998-72-3567', N'Ringer', N'Albert', N'(801)826-0752', N'RingerAlbert@gmail.com', N'67 Seventh Av.', N'Salt Lake City', N'UT', N'H3S1S4', 1)
GO
INSERT [dbo].[Books] ([ISBN], [Title], [type], [publisherId], [UnitPrice], [advance], [royalty], [ytd_sales], [notes], [YearPublished], [QOH], [CategoryId]) VALUES (N'BU1032', N'The Busy Executive''s Database Guide', N'business    ', N'1389', 19.9900, 5000.0000, 10, 4095, N'An overview of available database systems with emphasis on common business applications. Illustrated.', CAST(N'2018-06-12T00:00:00.000' AS DateTime), 400, 1111)
INSERT [dbo].[Books] ([ISBN], [Title], [type], [publisherId], [UnitPrice], [advance], [royalty], [ytd_sales], [notes], [YearPublished], [QOH], [CategoryId]) VALUES (N'BU1111', N'Cooking with Computers: Surreptitious Balance Sheets', N'business    ', N'1389', 11.9500, 5000.0000, 10, 3876, N'Helpful hints on how to use your electronic resources to the best advantage.', CAST(N'2018-06-09T00:00:00.000' AS DateTime), 400, 2222)
INSERT [dbo].[Books] ([ISBN], [Title], [type], [publisherId], [UnitPrice], [advance], [royalty], [ytd_sales], [notes], [YearPublished], [QOH], [CategoryId]) VALUES (N'BU2075', N'You Can Combat Computer Stress!', N'business    ', N'0736', 2.9900, 10125.0000, 24, 18722, N'The latest medical and psychological techniques for living with the electronic office. Easy-to-understand explanations.', CAST(N'2018-06-30T00:00:00.000' AS DateTime), 400, 4444)
INSERT [dbo].[Books] ([ISBN], [Title], [type], [publisherId], [UnitPrice], [advance], [royalty], [ytd_sales], [notes], [YearPublished], [QOH], [CategoryId]) VALUES (N'BU7832', N'Straight Talk About Computers', N'business    ', N'1389', 19.9900, 5000.0000, 10, 4095, N'Annotated analysis of what computers can do for you: a no-hype guide for the critical user.', CAST(N'2018-06-22T00:00:00.000' AS DateTime), 400, 6666)
INSERT [dbo].[Books] ([ISBN], [Title], [type], [publisherId], [UnitPrice], [advance], [royalty], [ytd_sales], [notes], [YearPublished], [QOH], [CategoryId]) VALUES (N'MC2222', N'Silicon Valley Gastronomic Treats', N'mod_cook    ', N'0877', 19.9900, 0.0000, 12, 2032, N'Favorite recipes for quick, easy, and elegant meals.', CAST(N'2018-06-09T00:00:00.000' AS DateTime), 400, 2222)
INSERT [dbo].[Books] ([ISBN], [Title], [type], [publisherId], [UnitPrice], [advance], [royalty], [ytd_sales], [notes], [YearPublished], [QOH], [CategoryId]) VALUES (N'MC3021', N'The Gourmet Microwave', N'mod_cook    ', N'0877', 2.9900, 15000.0000, 24, 22246, N'Traditional French gourmet recipes adapted for modern microwave cooking.', CAST(N'2018-06-18T00:00:00.000' AS DateTime), 400, 5555)
INSERT [dbo].[Books] ([ISBN], [Title], [type], [publisherId], [UnitPrice], [advance], [royalty], [ytd_sales], [notes], [YearPublished], [QOH], [CategoryId]) VALUES (N'MC3026', N'The Psychology of Computer Cooking', N'UNDECIDED   ', N'0877', NULL, NULL, NULL, NULL, NULL, CAST(N'2021-11-14T15:40:06.010' AS DateTime), 400, 5555)
INSERT [dbo].[Books] ([ISBN], [Title], [type], [publisherId], [UnitPrice], [advance], [royalty], [ytd_sales], [notes], [YearPublished], [QOH], [CategoryId]) VALUES (N'PC1035', N'But Is It User Friendly?', N'popular_comp', N'1389', 22.9500, 7000.0000, 16, 8780, N'A survey of software for the naive user, focusing on the ''friendliness'' of each.', CAST(N'2018-06-30T00:00:00.000' AS DateTime), 400, 4444)
INSERT [dbo].[Books] ([ISBN], [Title], [type], [publisherId], [UnitPrice], [advance], [royalty], [ytd_sales], [notes], [YearPublished], [QOH], [CategoryId]) VALUES (N'PC8888', N'Secrets of Silicon Valley', N'popular_comp', N'1389', 20.0000, 8000.0000, 10, 4095, N'Muckraking reporting on the world''s largest computer hardware and software manufacturers.', CAST(N'2019-06-12T00:00:00.000' AS DateTime), 400, 1111)
INSERT [dbo].[Books] ([ISBN], [Title], [type], [publisherId], [UnitPrice], [advance], [royalty], [ytd_sales], [notes], [YearPublished], [QOH], [CategoryId]) VALUES (N'PC9999', N'Net Etiquette', N'popular_comp', N'1389', NULL, NULL, NULL, NULL, N'A must-read for computer conferencing.', CAST(N'2021-11-14T15:40:06.010' AS DateTime), 400, 6666)
INSERT [dbo].[Books] ([ISBN], [Title], [type], [publisherId], [UnitPrice], [advance], [royalty], [ytd_sales], [notes], [YearPublished], [QOH], [CategoryId]) VALUES (N'PS1372', N'Computer Phobic AND Non-Phobic Individuals: Behavior Variations', N'psychology  ', N'0877', 21.5900, 7000.0000, 10, 375, N'A must for the specialist, this book examines the difference between those who hate and fear computers and those who don''t.', CAST(N'2018-10-21T00:00:00.000' AS DateTime), 400, 6666)
INSERT [dbo].[Books] ([ISBN], [Title], [type], [publisherId], [UnitPrice], [advance], [royalty], [ytd_sales], [notes], [YearPublished], [QOH], [CategoryId]) VALUES (N'PS2091', N'Is Anger the Enemy?', N'psychology  ', N'0736', 10.9500, 2275.0000, 12, 2045, N'Carefully researched study of the effects of strong emotions on the body. Metabolic charts included.', CAST(N'2018-06-15T00:00:00.000' AS DateTime), 400, 5555)
INSERT [dbo].[Books] ([ISBN], [Title], [type], [publisherId], [UnitPrice], [advance], [royalty], [ytd_sales], [notes], [YearPublished], [QOH], [CategoryId]) VALUES (N'PS2106', N'Life Without Fear', N'psychology  ', N'0736', 7.0000, 6000.0000, 10, 111, N'New exercise, meditation, and nutritional techniques that can reduce the shock of daily interactions. Popular audience. Sample menus included, exercise video available separately.', CAST(N'2018-10-05T00:00:00.000' AS DateTime), 400, 5555)
INSERT [dbo].[Books] ([ISBN], [Title], [type], [publisherId], [UnitPrice], [advance], [royalty], [ytd_sales], [notes], [YearPublished], [QOH], [CategoryId]) VALUES (N'PS3333', N'Prolonged Data Deprivation: Four Case Studies', N'psychology  ', N'0736', 19.9900, 2000.0000, 10, 4072, N'What happens when the data runs dry?  Searching evaluations of information-shortage effects.', CAST(N'2018-06-12T00:00:00.000' AS DateTime), 400, 1111)
INSERT [dbo].[Books] ([ISBN], [Title], [type], [publisherId], [UnitPrice], [advance], [royalty], [ytd_sales], [notes], [YearPublished], [QOH], [CategoryId]) VALUES (N'PS7777', N'Emotional Security: A New Algorithm', N'psychology  ', N'0736', 7.9900, 4000.0000, 10, 3336, N'Protecting yourself and your loved ones from undue emotional stress in the modern world. Use of computer and nutritional aids emphasized.', CAST(N'2018-06-12T00:00:00.000' AS DateTime), 400, 1111)
INSERT [dbo].[Books] ([ISBN], [Title], [type], [publisherId], [UnitPrice], [advance], [royalty], [ytd_sales], [notes], [YearPublished], [QOH], [CategoryId]) VALUES (N'TC3218', N'Onions, Leeks, and Garlic: Cooking Secrets of the Mediterranean', N'trad_cook   ', N'0877', 20.9500, 7000.0000, 10, 375, N'Profusely illustrated in color, this makes a wonderful gift book for a cuisine-oriented friend.', CAST(N'2018-10-21T00:00:00.000' AS DateTime), 400, 5555)
INSERT [dbo].[Books] ([ISBN], [Title], [type], [publisherId], [UnitPrice], [advance], [royalty], [ytd_sales], [notes], [YearPublished], [QOH], [CategoryId]) VALUES (N'TC4203', N'Fifty Years in Buckingham Palace Kitchens', N'trad_cook   ', N'0877', 11.9500, 4000.0000, 14, 15096, N'More anecdotes from the Queen''s favorite cook describing life among English royalty. Recipes, techniques, tender vignettes.', CAST(N'2018-06-12T00:00:00.000' AS DateTime), 400, 4444)
INSERT [dbo].[Books] ([ISBN], [Title], [type], [publisherId], [UnitPrice], [advance], [royalty], [ytd_sales], [notes], [YearPublished], [QOH], [CategoryId]) VALUES (N'TC7777', N'Sushi, Anyone?', N'trad_cook   ', N'0877', 14.9900, 8000.0000, 10, 4095, N'Detailed instructions on how to make authentic Japanese sushi in your spare time.', CAST(N'2018-06-12T00:00:00.000' AS DateTime), 400, 3333)
GO
INSERT [dbo].[Categories] ([CategorId], [CategoryName]) VALUES (1111, N'business')
INSERT [dbo].[Categories] ([CategorId], [CategoryName]) VALUES (2222, N'mod_cook')
INSERT [dbo].[Categories] ([CategorId], [CategoryName]) VALUES (3333, N'Computer')
INSERT [dbo].[Categories] ([CategorId], [CategoryName]) VALUES (4444, N'popular_comp')
INSERT [dbo].[Categories] ([CategorId], [CategoryName]) VALUES (5555, N'psychology')
INSERT [dbo].[Categories] ([CategorId], [CategoryName]) VALUES (6666, N'trad_cook')
GO
INSERT [dbo].[Customers] ([CustomersId], [CustomerName], [CustomerAddress], [city], [state], [PostalCode], [PhoneNumber], [FaxNumber], [CreditLimit], [Email]) VALUES (N'6380', N'EdvardShan', N'788 Catamaugus Ave.', N'Seattle', N'WA', N'H3S1S5', N'(514)777-5555', N'(514)777-5555', 1000.0000, N'EdvardShan@gmail.com')
INSERT [dbo].[Customers] ([CustomersId], [CustomerName], [CustomerAddress], [city], [state], [PostalCode], [PhoneNumber], [FaxNumber], [CreditLimit], [Email]) VALUES (N'7066', N'ZahraMirzaagha''s', N'567 Pasadena Ave.', N'Tustin', N'CA', N'H3S1S1', N'(514)843-0462', N'(514)843-0462', 6000.0000, N'ZahraMirzaagha@gmail.com')
INSERT [dbo].[Customers] ([CustomersId], [CustomerName], [CustomerAddress], [city], [state], [PostalCode], [PhoneNumber], [FaxNumber], [CreditLimit], [Email]) VALUES (N'7067', N'AlirezaAhmadian', N'577 First St.', N'Los Gatos', N'CA', N'H3S1S2', N'(514)701-6563', N'(514)701-6563', 4000.0000, N'AlirezaAhmadian@gmail.com')
INSERT [dbo].[Customers] ([CustomersId], [CustomerName], [CustomerAddress], [city], [state], [PostalCode], [PhoneNumber], [FaxNumber], [CreditLimit], [Email]) VALUES (N'7131', N'MaryBrown', N'24-A Avogadro Way', N'Remulade', N'WA', N'H3S1S3', N'(514)777-6563', N'(514)777-6563', 5000.0000, N'MaryBrown@gmail.com')
INSERT [dbo].[Customers] ([CustomersId], [CustomerName], [CustomerAddress], [city], [state], [PostalCode], [PhoneNumber], [FaxNumber], [CreditLimit], [Email]) VALUES (N'7896', N'FrankLin', N'89 Madison St.', N'Fremont', N'CA', N'H3S1S6', N'(514)777-3333', N'(514)777-3333', 4000.0000, N'FrankLin@gmail.com')
INSERT [dbo].[Customers] ([CustomersId], [CustomerName], [CustomerAddress], [city], [state], [PostalCode], [PhoneNumber], [FaxNumber], [CreditLimit], [Email]) VALUES (N'8042', N'CatrinRay', N'679 Carson St.', N'Portland', N'OR', N'H3S1S4', N'(514)777-6663', N'(514)777-6663', 2000.0000, N'CatrinRay@gmail.com')
GO
INSERT [dbo].[discounts] ([discounttype], [CustomersId], [lowqty], [highqty], [discount]) VALUES (N'Initial Customer', NULL, NULL, NULL, CAST(10.50 AS Decimal(4, 2)))
INSERT [dbo].[discounts] ([discounttype], [CustomersId], [lowqty], [highqty], [discount]) VALUES (N'Volume Discount', NULL, 100, 1000, CAST(6.70 AS Decimal(4, 2)))
INSERT [dbo].[discounts] ([discounttype], [CustomersId], [lowqty], [highqty], [discount]) VALUES (N'Customer Discount', N'8042', NULL, NULL, CAST(5.00 AS Decimal(4, 2)))
GO
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [minit], [LastName], [JobID], [job_lvl], [publisherId], [hire_date], [phoneNumber], [Email], [StatusId]) VALUES (N'PMA42628M', N'Paolo', N'M', N'Accorti', 13, 35, N'0877', CAST(N'2015-08-27T00:00:00.000' AS DateTime), N'(514)111-1111', N'PaoloAccorti@gmail.com', 111)
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [minit], [LastName], [JobID], [job_lvl], [publisherId], [hire_date], [phoneNumber], [Email], [StatusId]) VALUES (N'PSA89086M', N'Pedro', N'S', N'Afonso', 14, 89, N'1389', CAST(N'2016-12-24T00:00:00.000' AS DateTime), N'(514)111-1111', N'PedroAfonso@gmail.com', 111)
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [minit], [LastName], [JobID], [job_lvl], [publisherId], [hire_date], [phoneNumber], [Email], [StatusId]) VALUES (N'VPA30890F', N'Victoria', N'P', N'Ashworth', 6, 140, N'0877', CAST(N'2016-09-13T00:00:00.000' AS DateTime), N'(514)111-1111', N'VictoriaAshworth@gmail.com', 111)
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [minit], [LastName], [JobID], [job_lvl], [publisherId], [hire_date], [phoneNumber], [Email], [StatusId]) VALUES (N'H-B39728F', N'Helen', N' ', N'Bennett', 12, 35, N'0877', CAST(N'2014-09-21T00:00:00.000' AS DateTime), N'(514)111-1111', N'HelenBennett@gmail.com', 111)
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [minit], [LastName], [JobID], [job_lvl], [publisherId], [hire_date], [phoneNumber], [Email], [StatusId]) VALUES (N'L-B31947F', N'Lesley', N' ', N'Brown', 7, 120, N'0877', CAST(N'2018-02-13T00:00:00.000' AS DateTime), N'(514)111-1111', N'LesleyBrown@gmail.com', 111)
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [minit], [LastName], [JobID], [job_lvl], [publisherId], [hire_date], [phoneNumber], [Email], [StatusId]) VALUES (N'F-C16315M', N'Francisco', N' ', N'Chang', 4, 227, N'9952', CAST(N'2016-11-03T00:00:00.000' AS DateTime), N'(514)111-1111', N'FranciscoChang@gmail.com', 111)
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [minit], [LastName], [JobID], [job_lvl], [publisherId], [hire_date], [phoneNumber], [Email], [StatusId]) VALUES (N'PTC11962M', N'Philip', N'T', N'Cramer', 2, 215, N'9952', CAST(N'2014-11-11T00:00:00.000' AS DateTime), N'(514)111-1111', N'PhilipCramer@gmail.com', 111)
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [minit], [LastName], [JobID], [job_lvl], [publisherId], [hire_date], [phoneNumber], [Email], [StatusId]) VALUES (N'A-C71970F', N'Aria', N' ', N'Cruz', 10, 87, N'1389', CAST(N'2018-10-26T00:00:00.000' AS DateTime), N'(514)111-1111', N'AriaCruz@gmail.com', 111)
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [minit], [LastName], [JobID], [job_lvl], [publisherId], [hire_date], [phoneNumber], [Email], [StatusId]) VALUES (N'AMD15433F', N'Ann', N'M', N'Devon', 3, 200, N'9952', CAST(N'2018-07-16T00:00:00.000' AS DateTime), N'(514)111-1111', N'AnnDevon@gmail.com', 111)
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [minit], [LastName], [JobID], [job_lvl], [publisherId], [hire_date], [phoneNumber], [Email], [StatusId]) VALUES (N'ARD36773F', N'Anabela', N'R', N'Domingues', 8, 100, N'0877', CAST(N'2017-01-27T00:00:00.000' AS DateTime), N'(514)111-1111', N'AnabelaDomingues@gmail.com', 111)
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [minit], [LastName], [JobID], [job_lvl], [publisherId], [hire_date], [phoneNumber], [Email], [StatusId]) VALUES (N'PHF38899M', N'Peter', N'H', N'Franken', 10, 75, N'0877', CAST(N'2015-05-17T00:00:00.000' AS DateTime), N'(514)111-1111', N'PeterFranken@gmail.com', 111)
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [minit], [LastName], [JobID], [job_lvl], [publisherId], [hire_date], [phoneNumber], [Email], [StatusId]) VALUES (N'PXH22250M', N'Paul', N'X', N'Henriot', 5, 159, N'0877', CAST(N'2017-08-19T00:00:00.000' AS DateTime), N'(514)111-1111', N'PaulHenriot@gmail.com', 111)
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [minit], [LastName], [JobID], [job_lvl], [publisherId], [hire_date], [phoneNumber], [Email], [StatusId]) VALUES (N'CFH28514M', N'Carlos', N'F', N'Hernadez', 5, 211, N'9999', CAST(N'2014-04-21T00:00:00.000' AS DateTime), N'(514)111-1111', N'CarlosHernadez@gmail.com', 111)
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [minit], [LastName], [JobID], [job_lvl], [publisherId], [hire_date], [phoneNumber], [Email], [StatusId]) VALUES (N'PDI47470M', N'Palle', N'D', N'Ibsen', 7, 195, N'0736', CAST(N'2017-05-09T00:00:00.000' AS DateTime), N'(514)111-1111', N'PalleIbsen@gmail.com', 111)
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [minit], [LastName], [JobID], [job_lvl], [publisherId], [hire_date], [phoneNumber], [Email], [StatusId]) VALUES (N'KJJ92907F', N'Karla', N'J', N'Jablonski', 9, 170, N'9999', CAST(N'2019-03-11T00:00:00.000' AS DateTime), N'(514)111-1111', N'KarlaJablonski@gmail.com', 111)
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [minit], [LastName], [JobID], [job_lvl], [publisherId], [hire_date], [phoneNumber], [Email], [StatusId]) VALUES (N'KFJ64308F', N'Karin', N'F', N'Josephs', 14, 100, N'0736', CAST(N'2015-10-17T00:00:00.000' AS DateTime), N'(514)111-1111', N'KarinJosephs@gmail.com', 111)
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [minit], [LastName], [JobID], [job_lvl], [publisherId], [hire_date], [phoneNumber], [Email], [StatusId]) VALUES (N'MGK44605M', N'Matti', N'G', N'Karttunen', 6, 220, N'0736', CAST(N'2019-05-01T00:00:00.000' AS DateTime), N'(514)111-1111', N'MattiKarttunen@gmail.com', 111)
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [minit], [LastName], [JobID], [job_lvl], [publisherId], [hire_date], [phoneNumber], [Email], [StatusId]) VALUES (N'POK93028M', N'Pirkko', N'O', N'Koskitalo', 10, 80, N'9999', CAST(N'2017-11-29T00:00:00.000' AS DateTime), N'(514)111-1111', N'PirkkoKoskitalo@gmail.com', 111)
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [minit], [LastName], [JobID], [job_lvl], [publisherId], [hire_date], [phoneNumber], [Email], [StatusId]) VALUES (N'JYL26161F', N'Janine', N'Y', N'Labrune', 5, 172, N'9901', CAST(N'2018-05-26T00:00:00.000' AS DateTime), N'(514)111-1111', N'JanineLabrune@gmail.com', 111)
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [minit], [LastName], [JobID], [job_lvl], [publisherId], [hire_date], [phoneNumber], [Email], [StatusId]) VALUES (N'M-L67958F', N'Maria', N' ', N'Larsson', 7, 135, N'1389', CAST(N'2015-03-27T00:00:00.000' AS DateTime), N'(514)111-1111', N'MariaLarsson@gmail.com', 111)
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [minit], [LastName], [JobID], [job_lvl], [publisherId], [hire_date], [phoneNumber], [Email], [StatusId]) VALUES (N'Y-L77953M', N'Yoshi', N' ', N'Latimer', 12, 32, N'1389', CAST(N'2014-06-11T00:00:00.000' AS DateTime), N'(514)111-1111', N'YoshiLatimer@gmail.com', 111)
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [minit], [LastName], [JobID], [job_lvl], [publisherId], [hire_date], [phoneNumber], [Email], [StatusId]) VALUES (N'LAL21447M', N'Laurence', N'A', N'Lebihan', 5, 175, N'0736', CAST(N'2016-06-03T00:00:00.000' AS DateTime), N'(514)111-1111', N'LaurenceLebihan@gmail.com', 111)
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [minit], [LastName], [JobID], [job_lvl], [publisherId], [hire_date], [phoneNumber], [Email], [StatusId]) VALUES (N'ENL44273F', N'Elizabeth', N'N', N'Lincoln', 14, 35, N'0877', CAST(N'2016-07-24T00:00:00.000' AS DateTime), N'(514)111-1111', N'ElizabethLincoln@gmail.com', 111)
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [minit], [LastName], [JobID], [job_lvl], [publisherId], [hire_date], [phoneNumber], [Email], [StatusId]) VALUES (N'PCM98509F', N'Patricia', N'C', N'McKenna', 11, 150, N'9999', CAST(N'2014-08-01T00:00:00.000' AS DateTime), N'(514)111-1111', N'PatriciaMcKenna@gmail.com', 111)
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [minit], [LastName], [JobID], [job_lvl], [publisherId], [hire_date], [phoneNumber], [Email], [StatusId]) VALUES (N'R-M53550M', N'Roland', N' ', N'Mendel', 11, 150, N'0736', CAST(N'2018-09-05T00:00:00.000' AS DateTime), N'(514)111-1111', N'RolandMendel@gmail.com', 111)
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [minit], [LastName], [JobID], [job_lvl], [publisherId], [hire_date], [phoneNumber], [Email], [StatusId]) VALUES (N'RBM23061F', N'Rita', N'B', N'Muller', 5, 198, N'1622', CAST(N'2017-10-09T00:00:00.000' AS DateTime), N'(514)111-1111', N'RitaMuller@gmail.com', 111)
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [minit], [LastName], [JobID], [job_lvl], [publisherId], [hire_date], [phoneNumber], [Email], [StatusId]) VALUES (N'HAN90777M', N'Helvetius', N'A', N'Nagy', 7, 120, N'9999', CAST(N'2017-03-19T00:00:00.000' AS DateTime), N'(514)111-1111', N'HelvetiusNagy@gmail.com', 111)
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [minit], [LastName], [JobID], [job_lvl], [publisherId], [hire_date], [phoneNumber], [Email], [StatusId]) VALUES (N'TPO55093M', N'Timothy', N'P', N'O''Rourke', 13, 100, N'0736', CAST(N'2013-06-19T00:00:00.000' AS DateTime), N'(514)111-1111', N'TimothyRourke@gmail.com', 111)
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [minit], [LastName], [JobID], [job_lvl], [publisherId], [hire_date], [phoneNumber], [Email], [StatusId]) VALUES (N'SKO22412M', N'Sven', N'K', N'Ottlieb', 5, 150, N'1389', CAST(N'2018-04-05T00:00:00.000' AS DateTime), N'(514)111-1111', N'SvenOttlieb@gmail.com', 111)
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [minit], [LastName], [JobID], [job_lvl], [publisherId], [hire_date], [phoneNumber], [Email], [StatusId]) VALUES (N'MAP77183M', N'Miguel', N'A', N'Paolino', 11, 112, N'1389', CAST(N'2015-12-07T00:00:00.000' AS DateTime), N'(514)111-1111', N'MiguePaolino@gmail.com', 111)
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [minit], [LastName], [JobID], [job_lvl], [publisherId], [hire_date], [phoneNumber], [Email], [StatusId]) VALUES (N'PSP68661F', N'Paula', N'S', N'Parente', 8, 125, N'1389', CAST(N'2019-01-19T00:00:00.000' AS DateTime), N'(514)111-1111', N'PaulaParente@gmail.com', 111)
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [minit], [LastName], [JobID], [job_lvl], [publisherId], [hire_date], [phoneNumber], [Email], [StatusId]) VALUES (N'M-P91209M', N'Manuel', N' ', N'Pereira', 8, 101, N'9999', CAST(N'2014-01-09T00:00:00.000' AS DateTime), N'(514)111-1111', N'ManuelPereira@gmail.com', 111)
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [minit], [LastName], [JobID], [job_lvl], [publisherId], [hire_date], [phoneNumber], [Email], [StatusId]) VALUES (N'MJP25939M', N'Maria', N'J', N'Pontes', 5, 246, N'1756', CAST(N'2014-03-01T00:00:00.000' AS DateTime), N'(514)111-1111', N'MariaPontes@gmail.com', 111)
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [minit], [LastName], [JobID], [job_lvl], [publisherId], [hire_date], [phoneNumber], [Email], [StatusId]) VALUES (N'M-R38834F', N'Martine', N' ', N'Rance', 9, 75, N'0877', CAST(N'2015-02-05T00:00:00.000' AS DateTime), N'(514)111-1111', N'MartineRance@gmail.com', 111)
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [minit], [LastName], [JobID], [job_lvl], [publisherId], [hire_date], [phoneNumber], [Email], [StatusId]) VALUES (N'DWR65030M', N'Diego', N'W', N'Roel', 6, 192, N'1389', CAST(N'2018-12-16T00:00:00.000' AS DateTime), N'(514)111-1111', N'DiegoRoel@gmail.com', 111)
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [minit], [LastName], [JobID], [job_lvl], [publisherId], [hire_date], [phoneNumber], [Email], [StatusId]) VALUES (N'A-R89858F', N'Annette', N' ', N'Roulet', 6, 152, N'9999', CAST(N'2016-02-21T00:00:00.000' AS DateTime), N'(514)111-1111', N'AnnetteRoulet@gmail.com', 111)
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [minit], [LastName], [JobID], [job_lvl], [publisherId], [hire_date], [phoneNumber], [Email], [StatusId]) VALUES (N'MMS49649F', N'Mary', N'M', N'Saveley', 8, 175, N'0736', CAST(N'2017-06-29T00:00:00.000' AS DateTime), N'(514)111-1111', N'MarySaveley@gmail.com', 111)
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [minit], [LastName], [JobID], [job_lvl], [publisherId], [hire_date], [phoneNumber], [Email], [StatusId]) VALUES (N'CGS88322F', N'Carine', N'G', N'Schmitt', 13, 64, N'1389', CAST(N'2015-07-07T00:00:00.000' AS DateTime), N'(514)111-1111', N'CarineSchmitt@gmail.com', 111)
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [minit], [LastName], [JobID], [job_lvl], [publisherId], [hire_date], [phoneNumber], [Email], [StatusId]) VALUES (N'MAS70474F', N'Margaret', N'A', N'Smith', 9, 78, N'1389', CAST(N'2013-09-29T00:00:00.000' AS DateTime), N'(514)111-1111', N'MargaretSmith@gmail.com', 111)
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [minit], [LastName], [JobID], [job_lvl], [publisherId], [hire_date], [phoneNumber], [Email], [StatusId]) VALUES (N'HAS54740M', N'Howard', N'A', N'Snyder', 12, 100, N'0736', CAST(N'2013-11-19T00:00:00.000' AS DateTime), N'(514)111-1111', N'HowardSnyder@gmail.com', 111)
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [minit], [LastName], [JobID], [job_lvl], [publisherId], [hire_date], [phoneNumber], [Email], [StatusId]) VALUES (N'MFS52347M', N'Martin', N'F', N'Sommer', 10, 165, N'0736', CAST(N'2016-04-13T00:00:00.000' AS DateTime), N'(514)111-1111', N'MartinSommer@gmail.com', 111)
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [minit], [LastName], [JobID], [job_lvl], [publisherId], [hire_date], [phoneNumber], [Email], [StatusId]) VALUES (N'GHT50241M', N'Gary', N'H', N'Thomas', 9, 170, N'0736', CAST(N'2013-08-09T00:00:00.000' AS DateTime), N'(514)111-1111', N'GaryThomas@gmail.com', 111)
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [minit], [LastName], [JobID], [job_lvl], [publisherId], [hire_date], [phoneNumber], [Email], [StatusId]) VALUES (N'DBT39435M', N'Daniel', N'B', N'Tonini', 11, 75, N'0877', CAST(N'2016-01-01T00:00:00.000' AS DateTime), N'(514)111-1111', N'DanielTonini@gmail.com', 111)
GO
SET IDENTITY_INSERT [dbo].[jobPositions] ON 

INSERT [dbo].[jobPositions] ([JobID], [JobTitle], [min_lvl], [max_lvl]) VALUES (1, N'New Hire - Job not specified', 10, 10)
INSERT [dbo].[jobPositions] ([JobID], [JobTitle], [min_lvl], [max_lvl]) VALUES (2, N'Chief Executive Officer', 200, 250)
INSERT [dbo].[jobPositions] ([JobID], [JobTitle], [min_lvl], [max_lvl]) VALUES (3, N'Business Operations Manager', 175, 225)
INSERT [dbo].[jobPositions] ([JobID], [JobTitle], [min_lvl], [max_lvl]) VALUES (4, N'Chief Financial Officier', 175, 250)
INSERT [dbo].[jobPositions] ([JobID], [JobTitle], [min_lvl], [max_lvl]) VALUES (5, N'Publisher', 150, 250)
INSERT [dbo].[jobPositions] ([JobID], [JobTitle], [min_lvl], [max_lvl]) VALUES (6, N'Managing Editor', 140, 225)
INSERT [dbo].[jobPositions] ([JobID], [JobTitle], [min_lvl], [max_lvl]) VALUES (7, N'Marketing Manager', 120, 200)
INSERT [dbo].[jobPositions] ([JobID], [JobTitle], [min_lvl], [max_lvl]) VALUES (8, N'Public Relations Manager', 100, 175)
INSERT [dbo].[jobPositions] ([JobID], [JobTitle], [min_lvl], [max_lvl]) VALUES (9, N'Acquisitions Manager', 75, 175)
INSERT [dbo].[jobPositions] ([JobID], [JobTitle], [min_lvl], [max_lvl]) VALUES (10, N'Productions Manager', 75, 165)
INSERT [dbo].[jobPositions] ([JobID], [JobTitle], [min_lvl], [max_lvl]) VALUES (11, N'Operations Manager', 75, 150)
INSERT [dbo].[jobPositions] ([JobID], [JobTitle], [min_lvl], [max_lvl]) VALUES (12, N'Editor', 25, 100)
INSERT [dbo].[jobPositions] ([JobID], [JobTitle], [min_lvl], [max_lvl]) VALUES (13, N'Sels Representative', 25, 100)
INSERT [dbo].[jobPositions] ([JobID], [JobTitle], [min_lvl], [max_lvl]) VALUES (14, N'Designer', 25, 100)
SET IDENTITY_INSERT [dbo].[jobPositions] OFF
GO
INSERT [dbo].[OrderDetails] ([OrderId], [QuantityOrdered], [ISBN]) VALUES (N'423LL922', 15, N'MC3021')
INSERT [dbo].[OrderDetails] ([OrderId], [QuantityOrdered], [ISBN]) VALUES (N'423LL930', 10, N'BU1032')
INSERT [dbo].[OrderDetails] ([OrderId], [QuantityOrdered], [ISBN]) VALUES (N'6871', 5, N'BU1032')
INSERT [dbo].[OrderDetails] ([OrderId], [QuantityOrdered], [ISBN]) VALUES (N'722a', 3, N'PS2091')
INSERT [dbo].[OrderDetails] ([OrderId], [QuantityOrdered], [ISBN]) VALUES (N'A2976', 50, N'PC8888')
INSERT [dbo].[OrderDetails] ([OrderId], [QuantityOrdered], [ISBN]) VALUES (N'D4482', 10, N'PS2091')
INSERT [dbo].[OrderDetails] ([OrderId], [QuantityOrdered], [ISBN]) VALUES (N'N914008', 20, N'PS2091')
INSERT [dbo].[OrderDetails] ([OrderId], [QuantityOrdered], [ISBN]) VALUES (N'N914014', 25, N'MC3021')
INSERT [dbo].[OrderDetails] ([OrderId], [QuantityOrdered], [ISBN]) VALUES (N'P2121', 40, N'TC3218')
INSERT [dbo].[OrderDetails] ([OrderId], [QuantityOrdered], [ISBN]) VALUES (N'P2121', 20, N'TC4203')
INSERT [dbo].[OrderDetails] ([OrderId], [QuantityOrdered], [ISBN]) VALUES (N'P2121', 20, N'TC7777')
INSERT [dbo].[OrderDetails] ([OrderId], [QuantityOrdered], [ISBN]) VALUES (N'P3087a', 20, N'PS1372')
INSERT [dbo].[OrderDetails] ([OrderId], [QuantityOrdered], [ISBN]) VALUES (N'P3087a', 25, N'PS2106')
INSERT [dbo].[OrderDetails] ([OrderId], [QuantityOrdered], [ISBN]) VALUES (N'P3087a', 15, N'PS3333')
INSERT [dbo].[OrderDetails] ([OrderId], [QuantityOrdered], [ISBN]) VALUES (N'P3087a', 25, N'PS7777')
INSERT [dbo].[OrderDetails] ([OrderId], [QuantityOrdered], [ISBN]) VALUES (N'P723', 25, N'BU1111')
INSERT [dbo].[OrderDetails] ([OrderId], [QuantityOrdered], [ISBN]) VALUES (N'QA7442.3', 75, N'PS2091')
INSERT [dbo].[OrderDetails] ([OrderId], [QuantityOrdered], [ISBN]) VALUES (N'QA879.1', 30, N'PC1035')
INSERT [dbo].[OrderDetails] ([OrderId], [QuantityOrdered], [ISBN]) VALUES (N'QQ2299', 15, N'BU7832')
INSERT [dbo].[OrderDetails] ([OrderId], [QuantityOrdered], [ISBN]) VALUES (N'TQ456', 10, N'MC2222')
INSERT [dbo].[OrderDetails] ([OrderId], [QuantityOrdered], [ISBN]) VALUES (N'X999', 35, N'BU2075')
GO
INSERT [dbo].[pub_info] ([publisherId], [logo], [pr_info]) VALUES (N'0736', 0xFFFFFFFF, N'None yet')
INSERT [dbo].[pub_info] ([publisherId], [logo], [pr_info]) VALUES (N'0877', 0xFFFFFFFF, N'None yet')
INSERT [dbo].[pub_info] ([publisherId], [logo], [pr_info]) VALUES (N'1389', 0xFFFFFFFF, N'None yet')
INSERT [dbo].[pub_info] ([publisherId], [logo], [pr_info]) VALUES (N'1622', 0xFFFFFFFF, N'None yet')
INSERT [dbo].[pub_info] ([publisherId], [logo], [pr_info]) VALUES (N'1756', 0xFFFFFFFF, N'None yet')
INSERT [dbo].[pub_info] ([publisherId], [logo], [pr_info]) VALUES (N'9901', 0xFFFFFFFF, N'None yet')
INSERT [dbo].[pub_info] ([publisherId], [logo], [pr_info]) VALUES (N'9952', 0xFFFFFFFF, N'None yet')
INSERT [dbo].[pub_info] ([publisherId], [logo], [pr_info]) VALUES (N'9999', 0xFFFFFFFF, N'None yet')
GO
INSERT [dbo].[publishers] ([publisherId], [publisherName], [WebAddress], [city], [state], [country]) VALUES (N'0736', N'New Moon Books', N'www.NewMoonBooks.com', N'Boston', N'MA', N'USA')
INSERT [dbo].[publishers] ([publisherId], [publisherName], [WebAddress], [city], [state], [country]) VALUES (N'0877', N'Binnet & Hardley', N'www.Binnet&Hardley.com', N'Washington', N'DC', N'USA')
INSERT [dbo].[publishers] ([publisherId], [publisherName], [WebAddress], [city], [state], [country]) VALUES (N'1389', N'Algodata Infosystems', N'www.AlgodataInfosystems.com', N'Berkeley', N'CA', N'USA')
INSERT [dbo].[publishers] ([publisherId], [publisherName], [WebAddress], [city], [state], [country]) VALUES (N'1622', N'Five Lakes Publishing', N'www.FiveLakesPublishing.com', N'Chicago', N'IL', N'USA')
INSERT [dbo].[publishers] ([publisherId], [publisherName], [WebAddress], [city], [state], [country]) VALUES (N'1756', N'Ramona Publishers', N'www.RamonaPublishers.com', N'Dallas', N'TX', N'USA')
INSERT [dbo].[publishers] ([publisherId], [publisherName], [WebAddress], [city], [state], [country]) VALUES (N'9901', N'GGG&G', N'www.GGG&G.com', N'Mnchen', NULL, N'Germany')
INSERT [dbo].[publishers] ([publisherId], [publisherName], [WebAddress], [city], [state], [country]) VALUES (N'9952', N'Scootney Books', N'www.ScootneyBooks.com', N'New York', N'NY', N'USA')
INSERT [dbo].[publishers] ([publisherId], [publisherName], [WebAddress], [city], [state], [country]) VALUES (N'9999', N'Lucerne Publishing', N'www.LucernePublishing.com', N'Paris', NULL, N'France')
GO
INSERT [dbo].[roysched] ([ISBN], [lorange], [hirange], [royalty]) VALUES (N'BU1032', 0, 5000, 10)
INSERT [dbo].[roysched] ([ISBN], [lorange], [hirange], [royalty]) VALUES (N'BU1032', 5001, 50000, 12)
INSERT [dbo].[roysched] ([ISBN], [lorange], [hirange], [royalty]) VALUES (N'PC1035', 0, 2000, 10)
INSERT [dbo].[roysched] ([ISBN], [lorange], [hirange], [royalty]) VALUES (N'PC1035', 2001, 3000, 12)
INSERT [dbo].[roysched] ([ISBN], [lorange], [hirange], [royalty]) VALUES (N'PC1035', 3001, 4000, 14)
INSERT [dbo].[roysched] ([ISBN], [lorange], [hirange], [royalty]) VALUES (N'PC1035', 4001, 10000, 16)
INSERT [dbo].[roysched] ([ISBN], [lorange], [hirange], [royalty]) VALUES (N'PC1035', 10001, 50000, 18)
INSERT [dbo].[roysched] ([ISBN], [lorange], [hirange], [royalty]) VALUES (N'BU2075', 0, 1000, 10)
INSERT [dbo].[roysched] ([ISBN], [lorange], [hirange], [royalty]) VALUES (N'BU2075', 1001, 3000, 12)
INSERT [dbo].[roysched] ([ISBN], [lorange], [hirange], [royalty]) VALUES (N'BU2075', 3001, 5000, 14)
INSERT [dbo].[roysched] ([ISBN], [lorange], [hirange], [royalty]) VALUES (N'BU2075', 5001, 7000, 16)
INSERT [dbo].[roysched] ([ISBN], [lorange], [hirange], [royalty]) VALUES (N'BU2075', 7001, 10000, 18)
INSERT [dbo].[roysched] ([ISBN], [lorange], [hirange], [royalty]) VALUES (N'BU2075', 10001, 12000, 20)
INSERT [dbo].[roysched] ([ISBN], [lorange], [hirange], [royalty]) VALUES (N'BU2075', 12001, 14000, 22)
INSERT [dbo].[roysched] ([ISBN], [lorange], [hirange], [royalty]) VALUES (N'BU2075', 14001, 50000, 24)
INSERT [dbo].[roysched] ([ISBN], [lorange], [hirange], [royalty]) VALUES (N'PS2091', 0, 1000, 10)
INSERT [dbo].[roysched] ([ISBN], [lorange], [hirange], [royalty]) VALUES (N'PS2091', 1001, 5000, 12)
INSERT [dbo].[roysched] ([ISBN], [lorange], [hirange], [royalty]) VALUES (N'PS2091', 5001, 10000, 14)
INSERT [dbo].[roysched] ([ISBN], [lorange], [hirange], [royalty]) VALUES (N'PS2091', 10001, 50000, 16)
INSERT [dbo].[roysched] ([ISBN], [lorange], [hirange], [royalty]) VALUES (N'PS2106', 0, 2000, 10)
INSERT [dbo].[roysched] ([ISBN], [lorange], [hirange], [royalty]) VALUES (N'PS2106', 2001, 5000, 12)
INSERT [dbo].[roysched] ([ISBN], [lorange], [hirange], [royalty]) VALUES (N'PS2106', 5001, 10000, 14)
INSERT [dbo].[roysched] ([ISBN], [lorange], [hirange], [royalty]) VALUES (N'PS2106', 10001, 50000, 16)
INSERT [dbo].[roysched] ([ISBN], [lorange], [hirange], [royalty]) VALUES (N'MC3021', 0, 1000, 10)
INSERT [dbo].[roysched] ([ISBN], [lorange], [hirange], [royalty]) VALUES (N'MC3021', 1001, 2000, 12)
INSERT [dbo].[roysched] ([ISBN], [lorange], [hirange], [royalty]) VALUES (N'MC3021', 2001, 4000, 14)
INSERT [dbo].[roysched] ([ISBN], [lorange], [hirange], [royalty]) VALUES (N'MC3021', 4001, 6000, 16)
INSERT [dbo].[roysched] ([ISBN], [lorange], [hirange], [royalty]) VALUES (N'MC3021', 6001, 8000, 18)
INSERT [dbo].[roysched] ([ISBN], [lorange], [hirange], [royalty]) VALUES (N'MC3021', 8001, 10000, 20)
INSERT [dbo].[roysched] ([ISBN], [lorange], [hirange], [royalty]) VALUES (N'MC3021', 10001, 12000, 22)
INSERT [dbo].[roysched] ([ISBN], [lorange], [hirange], [royalty]) VALUES (N'MC3021', 12001, 50000, 24)
INSERT [dbo].[roysched] ([ISBN], [lorange], [hirange], [royalty]) VALUES (N'TC3218', 0, 2000, 10)
INSERT [dbo].[roysched] ([ISBN], [lorange], [hirange], [royalty]) VALUES (N'TC3218', 2001, 4000, 12)
INSERT [dbo].[roysched] ([ISBN], [lorange], [hirange], [royalty]) VALUES (N'TC3218', 4001, 6000, 14)
INSERT [dbo].[roysched] ([ISBN], [lorange], [hirange], [royalty]) VALUES (N'TC3218', 6001, 8000, 16)
INSERT [dbo].[roysched] ([ISBN], [lorange], [hirange], [royalty]) VALUES (N'TC3218', 8001, 10000, 18)
INSERT [dbo].[roysched] ([ISBN], [lorange], [hirange], [royalty]) VALUES (N'TC3218', 10001, 12000, 20)
INSERT [dbo].[roysched] ([ISBN], [lorange], [hirange], [royalty]) VALUES (N'TC3218', 12001, 14000, 22)
INSERT [dbo].[roysched] ([ISBN], [lorange], [hirange], [royalty]) VALUES (N'TC3218', 14001, 50000, 24)
INSERT [dbo].[roysched] ([ISBN], [lorange], [hirange], [royalty]) VALUES (N'PC8888', 0, 5000, 10)
INSERT [dbo].[roysched] ([ISBN], [lorange], [hirange], [royalty]) VALUES (N'PC8888', 5001, 10000, 12)
INSERT [dbo].[roysched] ([ISBN], [lorange], [hirange], [royalty]) VALUES (N'PC8888', 10001, 15000, 14)
INSERT [dbo].[roysched] ([ISBN], [lorange], [hirange], [royalty]) VALUES (N'PC8888', 15001, 50000, 16)
INSERT [dbo].[roysched] ([ISBN], [lorange], [hirange], [royalty]) VALUES (N'PS7777', 0, 5000, 10)
INSERT [dbo].[roysched] ([ISBN], [lorange], [hirange], [royalty]) VALUES (N'PS7777', 5001, 50000, 12)
INSERT [dbo].[roysched] ([ISBN], [lorange], [hirange], [royalty]) VALUES (N'PS3333', 0, 5000, 10)
INSERT [dbo].[roysched] ([ISBN], [lorange], [hirange], [royalty]) VALUES (N'PS3333', 5001, 10000, 12)
INSERT [dbo].[roysched] ([ISBN], [lorange], [hirange], [royalty]) VALUES (N'PS3333', 10001, 15000, 14)
INSERT [dbo].[roysched] ([ISBN], [lorange], [hirange], [royalty]) VALUES (N'PS3333', 15001, 50000, 16)
INSERT [dbo].[roysched] ([ISBN], [lorange], [hirange], [royalty]) VALUES (N'BU1111', 0, 4000, 10)
INSERT [dbo].[roysched] ([ISBN], [lorange], [hirange], [royalty]) VALUES (N'BU1111', 4001, 8000, 12)
INSERT [dbo].[roysched] ([ISBN], [lorange], [hirange], [royalty]) VALUES (N'BU1111', 8001, 10000, 14)
INSERT [dbo].[roysched] ([ISBN], [lorange], [hirange], [royalty]) VALUES (N'BU1111', 12001, 16000, 16)
INSERT [dbo].[roysched] ([ISBN], [lorange], [hirange], [royalty]) VALUES (N'BU1111', 16001, 20000, 18)
INSERT [dbo].[roysched] ([ISBN], [lorange], [hirange], [royalty]) VALUES (N'BU1111', 20001, 24000, 20)
INSERT [dbo].[roysched] ([ISBN], [lorange], [hirange], [royalty]) VALUES (N'BU1111', 24001, 28000, 22)
INSERT [dbo].[roysched] ([ISBN], [lorange], [hirange], [royalty]) VALUES (N'BU1111', 28001, 50000, 24)
INSERT [dbo].[roysched] ([ISBN], [lorange], [hirange], [royalty]) VALUES (N'MC2222', 0, 2000, 10)
INSERT [dbo].[roysched] ([ISBN], [lorange], [hirange], [royalty]) VALUES (N'MC2222', 2001, 4000, 12)
INSERT [dbo].[roysched] ([ISBN], [lorange], [hirange], [royalty]) VALUES (N'MC2222', 4001, 8000, 14)
INSERT [dbo].[roysched] ([ISBN], [lorange], [hirange], [royalty]) VALUES (N'MC2222', 8001, 12000, 16)
INSERT [dbo].[roysched] ([ISBN], [lorange], [hirange], [royalty]) VALUES (N'MC2222', 12001, 20000, 18)
INSERT [dbo].[roysched] ([ISBN], [lorange], [hirange], [royalty]) VALUES (N'MC2222', 20001, 50000, 20)
INSERT [dbo].[roysched] ([ISBN], [lorange], [hirange], [royalty]) VALUES (N'TC7777', 0, 5000, 10)
INSERT [dbo].[roysched] ([ISBN], [lorange], [hirange], [royalty]) VALUES (N'TC7777', 5001, 15000, 12)
INSERT [dbo].[roysched] ([ISBN], [lorange], [hirange], [royalty]) VALUES (N'TC7777', 15001, 50000, 14)
INSERT [dbo].[roysched] ([ISBN], [lorange], [hirange], [royalty]) VALUES (N'TC4203', 0, 2000, 10)
INSERT [dbo].[roysched] ([ISBN], [lorange], [hirange], [royalty]) VALUES (N'TC4203', 2001, 8000, 12)
INSERT [dbo].[roysched] ([ISBN], [lorange], [hirange], [royalty]) VALUES (N'TC4203', 8001, 16000, 14)
INSERT [dbo].[roysched] ([ISBN], [lorange], [hirange], [royalty]) VALUES (N'TC4203', 16001, 24000, 16)
INSERT [dbo].[roysched] ([ISBN], [lorange], [hirange], [royalty]) VALUES (N'TC4203', 24001, 32000, 18)
INSERT [dbo].[roysched] ([ISBN], [lorange], [hirange], [royalty]) VALUES (N'TC4203', 32001, 40000, 20)
INSERT [dbo].[roysched] ([ISBN], [lorange], [hirange], [royalty]) VALUES (N'TC4203', 40001, 50000, 22)
INSERT [dbo].[roysched] ([ISBN], [lorange], [hirange], [royalty]) VALUES (N'BU7832', 0, 5000, 10)
INSERT [dbo].[roysched] ([ISBN], [lorange], [hirange], [royalty]) VALUES (N'BU7832', 5001, 10000, 12)
INSERT [dbo].[roysched] ([ISBN], [lorange], [hirange], [royalty]) VALUES (N'BU7832', 10001, 15000, 14)
INSERT [dbo].[roysched] ([ISBN], [lorange], [hirange], [royalty]) VALUES (N'BU7832', 15001, 20000, 16)
INSERT [dbo].[roysched] ([ISBN], [lorange], [hirange], [royalty]) VALUES (N'BU7832', 20001, 25000, 18)
INSERT [dbo].[roysched] ([ISBN], [lorange], [hirange], [royalty]) VALUES (N'BU7832', 25001, 30000, 20)
INSERT [dbo].[roysched] ([ISBN], [lorange], [hirange], [royalty]) VALUES (N'BU7832', 30001, 35000, 22)
INSERT [dbo].[roysched] ([ISBN], [lorange], [hirange], [royalty]) VALUES (N'BU7832', 35001, 50000, 24)
INSERT [dbo].[roysched] ([ISBN], [lorange], [hirange], [royalty]) VALUES (N'PS1372', 0, 10000, 10)
INSERT [dbo].[roysched] ([ISBN], [lorange], [hirange], [royalty]) VALUES (N'PS1372', 10001, 20000, 12)
INSERT [dbo].[roysched] ([ISBN], [lorange], [hirange], [royalty]) VALUES (N'PS1372', 20001, 30000, 14)
INSERT [dbo].[roysched] ([ISBN], [lorange], [hirange], [royalty]) VALUES (N'PS1372', 30001, 40000, 16)
INSERT [dbo].[roysched] ([ISBN], [lorange], [hirange], [royalty]) VALUES (N'PS1372', 40001, 50000, 18)
GO
INSERT [dbo].[UsersAccount] ([EmployeeID], [UserID], [PassWord]) VALUES (N'ARD36773F', N'AnabelaDomingues', N'AnabelaDomingues')
INSERT [dbo].[UsersAccount] ([EmployeeID], [UserID], [PassWord]) VALUES (N'AMD15433F', N'AnnDevon', N'AnnDevon')
INSERT [dbo].[UsersAccount] ([EmployeeID], [UserID], [PassWord]) VALUES (N'A-R89858F', N'AnnetteRoulet', N'AnnetteRoulet')
INSERT [dbo].[UsersAccount] ([EmployeeID], [UserID], [PassWord]) VALUES (N'A-C71970F', N'AriaCruz', N'AriaCruz')
INSERT [dbo].[UsersAccount] ([EmployeeID], [UserID], [PassWord]) VALUES (N'CGS88322F', N'CarineSchmitt', N'CarineSchmitt')
INSERT [dbo].[UsersAccount] ([EmployeeID], [UserID], [PassWord]) VALUES (N'CFH28514M', N'CarlosHernadez', N'CarlosHernadez')
INSERT [dbo].[UsersAccount] ([EmployeeID], [UserID], [PassWord]) VALUES (N'DBT39435M', N'DanielTonini', N'DanielTonini')
INSERT [dbo].[UsersAccount] ([EmployeeID], [UserID], [PassWord]) VALUES (N'DWR65030M', N'DiegoRoel', N'DiegoRoel')
INSERT [dbo].[UsersAccount] ([EmployeeID], [UserID], [PassWord]) VALUES (N'ENL44273F', N'ElizabethLincoln', N'ElizabethLincoln')
INSERT [dbo].[UsersAccount] ([EmployeeID], [UserID], [PassWord]) VALUES (N'F-C16315M', N'FranciscoChang', N'FranciscoChang')
INSERT [dbo].[UsersAccount] ([EmployeeID], [UserID], [PassWord]) VALUES (N'GHT50241M', N'GaryThomas', N'GaryThomas')
INSERT [dbo].[UsersAccount] ([EmployeeID], [UserID], [PassWord]) VALUES (N'H-B39728F', N'HelenBennett', N'HelenBennett')
INSERT [dbo].[UsersAccount] ([EmployeeID], [UserID], [PassWord]) VALUES (N'HAN90777M', N'HelvetiusNagy', N'HelvetiusNagy')
INSERT [dbo].[UsersAccount] ([EmployeeID], [UserID], [PassWord]) VALUES (N'HAS54740M', N'HowardSnyder', N'HowardSnyder')
INSERT [dbo].[UsersAccount] ([EmployeeID], [UserID], [PassWord]) VALUES (N'JYL26161F', N'JanineLabrune', N'JanineLabrune')
INSERT [dbo].[UsersAccount] ([EmployeeID], [UserID], [PassWord]) VALUES (N'KFJ64308F', N'KarinJosephs', N'KarinJosephs')
INSERT [dbo].[UsersAccount] ([EmployeeID], [UserID], [PassWord]) VALUES (N'KJJ92907F', N'KarlaJablonski', N'KarlaJablonski')
INSERT [dbo].[UsersAccount] ([EmployeeID], [UserID], [PassWord]) VALUES (N'LAL21447M', N'LaurenceLebihan', N'LaurenceLebihan')
INSERT [dbo].[UsersAccount] ([EmployeeID], [UserID], [PassWord]) VALUES (N'L-B31947F', N'LesleyBrown', N'LesleyBrown')
INSERT [dbo].[UsersAccount] ([EmployeeID], [UserID], [PassWord]) VALUES (N'M-P91209M', N'ManuelPereira', N'ManuelPereira')
INSERT [dbo].[UsersAccount] ([EmployeeID], [UserID], [PassWord]) VALUES (N'MAS70474F', N'MargaretSmith', N'MargaretSmith')
INSERT [dbo].[UsersAccount] ([EmployeeID], [UserID], [PassWord]) VALUES (N'M-L67958F', N'MariaLarsson', N'MariaLarsson')
INSERT [dbo].[UsersAccount] ([EmployeeID], [UserID], [PassWord]) VALUES (N'MJP25939M', N'MariaPontes', N'MariaPontes')
INSERT [dbo].[UsersAccount] ([EmployeeID], [UserID], [PassWord]) VALUES (N'M-R38834F', N'MartineRance', N'MartineRance')
INSERT [dbo].[UsersAccount] ([EmployeeID], [UserID], [PassWord]) VALUES (N'MFS52347M', N'MartinSommer', N'MartinSommer')
INSERT [dbo].[UsersAccount] ([EmployeeID], [UserID], [PassWord]) VALUES (N'MMS49649F', N'MarySaveley', N'MarySaveley')
INSERT [dbo].[UsersAccount] ([EmployeeID], [UserID], [PassWord]) VALUES (N'MGK44605M', N'MattiKarttunen', N'MattiKarttunen')
INSERT [dbo].[UsersAccount] ([EmployeeID], [UserID], [PassWord]) VALUES (N'MAP77183M', N'MiguelPaolino', N'MiguelPaolino')
INSERT [dbo].[UsersAccount] ([EmployeeID], [UserID], [PassWord]) VALUES (N'PDI47470M', N'PalleIbsen', N'PalleIbsen')
INSERT [dbo].[UsersAccount] ([EmployeeID], [UserID], [PassWord]) VALUES (N'PMA42628M', N'PaoloAccorti', N'PaoloAccorti')
INSERT [dbo].[UsersAccount] ([EmployeeID], [UserID], [PassWord]) VALUES (N'PCM98509F', N'PatriciaMcKenna', N'PatriciaMcKenna')
INSERT [dbo].[UsersAccount] ([EmployeeID], [UserID], [PassWord]) VALUES (N'PSP68661F', N'PaulaParente', N'PaulaParente')
INSERT [dbo].[UsersAccount] ([EmployeeID], [UserID], [PassWord]) VALUES (N'PXH22250M', N'PaulHenriot', N'PaulHenriot')
INSERT [dbo].[UsersAccount] ([EmployeeID], [UserID], [PassWord]) VALUES (N'PSA89086M', N'PedroAfonso', N'PedroAfonso')
INSERT [dbo].[UsersAccount] ([EmployeeID], [UserID], [PassWord]) VALUES (N'PHF38899M', N'PeterFranken', N'PeterFranken')
INSERT [dbo].[UsersAccount] ([EmployeeID], [UserID], [PassWord]) VALUES (N'PTC11962M', N'PhilipCramer', N'PhilipCramer')
INSERT [dbo].[UsersAccount] ([EmployeeID], [UserID], [PassWord]) VALUES (N'POK93028M', N'PirkkoKoskitalo', N'PirkkoKoskitalo')
INSERT [dbo].[UsersAccount] ([EmployeeID], [UserID], [PassWord]) VALUES (N'RBM23061F', N'RitaMuller', N'RitaMuller')
INSERT [dbo].[UsersAccount] ([EmployeeID], [UserID], [PassWord]) VALUES (N'R-M53550M', N'RolandMendel', N'RolandMendel')
INSERT [dbo].[UsersAccount] ([EmployeeID], [UserID], [PassWord]) VALUES (N'SKO22412M', N'SvenOttlieb', N'SvenOttlieb')
INSERT [dbo].[UsersAccount] ([EmployeeID], [UserID], [PassWord]) VALUES (N'TPO55093M', N'TimothyRourke', N'TimothyRourke')
INSERT [dbo].[UsersAccount] ([EmployeeID], [UserID], [PassWord]) VALUES (N'VPA30890F', N'VictoriaAshworth', N'VictoriaAshworth')
INSERT [dbo].[UsersAccount] ([EmployeeID], [UserID], [PassWord]) VALUES (N'Y-L77953M', N'YoshiLatimer', N'YoshiLatimer')
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [taind]    Script Date: 10/16/2023 9:50:35 AM ******/
CREATE NONCLUSTERED INDEX [taind] ON [dbo].[AuthorBooks]
(
	[AuthorId] ASC,
	[ISBN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [auidind]    Script Date: 10/16/2023 9:50:35 AM ******/
CREATE NONCLUSTERED INDEX [auidind] ON [dbo].[Authors]
(
	[LastName] ASC,
	[FirstName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [ISBNind]    Script Date: 10/16/2023 9:50:35 AM ******/
CREATE NONCLUSTERED INDEX [ISBNind] ON [dbo].[Books]
(
	[Title] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [PK_EmployeeID]    Script Date: 10/16/2023 9:50:35 AM ******/
ALTER TABLE [dbo].[Employees] ADD  CONSTRAINT [PK_EmployeeID] PRIMARY KEY NONCLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [OrderDetails]    Script Date: 10/16/2023 9:50:35 AM ******/
CREATE NONCLUSTERED INDEX [OrderDetails] ON [dbo].[OrderDetails]
(
	[ISBN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [bookidind]    Script Date: 10/16/2023 9:50:35 AM ******/
CREATE NONCLUSTERED INDEX [bookidind] ON [dbo].[roysched]
(
	[ISBN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AuthorBooks] ADD  DEFAULT (getdate()) FOR [YearPublished]
GO
ALTER TABLE [dbo].[Authors] ADD  DEFAULT ('UNKNOWN') FOR [PhoneNumber]
GO
ALTER TABLE [dbo].[Books] ADD  DEFAULT ('UNDECIDED') FOR [type]
GO
ALTER TABLE [dbo].[Books] ADD  DEFAULT (getdate()) FOR [YearPublished]
GO
ALTER TABLE [dbo].[Customers] ADD  DEFAULT ('UNKNOWN') FOR [PhoneNumber]
GO
ALTER TABLE [dbo].[Customers] ADD  DEFAULT ('UNKNOWN') FOR [FaxNumber]
GO
ALTER TABLE [dbo].[Customers] ADD  DEFAULT ('UNKNOWN') FOR [Email]
GO
ALTER TABLE [dbo].[Employees] ADD  DEFAULT ((1)) FOR [JobID]
GO
ALTER TABLE [dbo].[Employees] ADD  DEFAULT ((10)) FOR [job_lvl]
GO
ALTER TABLE [dbo].[Employees] ADD  DEFAULT ('9952') FOR [publisherId]
GO
ALTER TABLE [dbo].[Employees] ADD  DEFAULT (getdate()) FOR [hire_date]
GO
ALTER TABLE [dbo].[Employees] ADD  DEFAULT ('UNKNOWN') FOR [phoneNumber]
GO
ALTER TABLE [dbo].[Employees] ADD  DEFAULT ('UNKNOWN') FOR [Email]
GO
ALTER TABLE [dbo].[jobPositions] ADD  DEFAULT ('New Position - title not formalized yet') FOR [JobTitle]
GO
ALTER TABLE [dbo].[publishers] ADD  DEFAULT ('USA') FOR [country]
GO
ALTER TABLE [dbo].[AuthorBooks]  WITH CHECK ADD FOREIGN KEY([AuthorId])
REFERENCES [dbo].[Authors] ([AuthorId])
GO
ALTER TABLE [dbo].[AuthorBooks]  WITH CHECK ADD FOREIGN KEY([ISBN])
REFERENCES [dbo].[Books] ([ISBN])
GO
ALTER TABLE [dbo].[Books]  WITH CHECK ADD FOREIGN KEY([publisherId])
REFERENCES [dbo].[publishers] ([publisherId])
GO
ALTER TABLE [dbo].[discounts]  WITH CHECK ADD FOREIGN KEY([CustomersId])
REFERENCES [dbo].[Customers] ([CustomersId])
GO
ALTER TABLE [dbo].[Employees]  WITH CHECK ADD FOREIGN KEY([JobID])
REFERENCES [dbo].[jobPositions] ([JobID])
GO
ALTER TABLE [dbo].[Employees]  WITH CHECK ADD FOREIGN KEY([publisherId])
REFERENCES [dbo].[publishers] ([publisherId])
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD FOREIGN KEY([ISBN])
REFERENCES [dbo].[Books] ([ISBN])
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD FOREIGN KEY([CustomersId])
REFERENCES [dbo].[Customers] ([CustomersId])
GO
ALTER TABLE [dbo].[pub_info]  WITH CHECK ADD FOREIGN KEY([publisherId])
REFERENCES [dbo].[publishers] ([publisherId])
GO
ALTER TABLE [dbo].[roysched]  WITH CHECK ADD FOREIGN KEY([ISBN])
REFERENCES [dbo].[Books] ([ISBN])
GO
ALTER TABLE [dbo].[Authors]  WITH CHECK ADD CHECK  (([AuthorId] like '[0-9][0-9][0-9]-[0-9][0-9]-[0-9][0-9][0-9][0-9]'))
GO
ALTER TABLE [dbo].[Authors]  WITH CHECK ADD CHECK  (([PostalCode] like '[A-Z][0-9][A-Z][0-9][A-Z][0-9]'))
GO
ALTER TABLE [dbo].[Customers]  WITH CHECK ADD CHECK  (([PostalCode] like '[A-Z][0-9][A-Z][0-9][A-Z][0-9]'))
GO
ALTER TABLE [dbo].[Employees]  WITH CHECK ADD  CONSTRAINT [CK_EmployeeID] CHECK  (([EmployeeID] like '[A-Z][A-Z][A-Z][1-9][0-9][0-9][0-9][0-9][FM]' OR [EmployeeID] like '[A-Z]-[A-Z][1-9][0-9][0-9][0-9][0-9][FM]'))
GO
ALTER TABLE [dbo].[Employees] CHECK CONSTRAINT [CK_EmployeeID]
GO
ALTER TABLE [dbo].[jobPositions]  WITH CHECK ADD CHECK  (([max_lvl]<=(250)))
GO
ALTER TABLE [dbo].[jobPositions]  WITH CHECK ADD CHECK  (([min_lvl]>=(10)))
GO
ALTER TABLE [dbo].[publishers]  WITH CHECK ADD CHECK  (([publisherId]='1756' OR [publisherId]='1622' OR [publisherId]='0877' OR [publisherId]='0736' OR [publisherId]='1389' OR [publisherId] like '99[0-9][0-9]'))
GO
/****** Object:  StoredProcedure [dbo].[byroyalty]    Script Date: 10/16/2023 9:50:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[byroyalty] @percentage int
AS
select AuthorId from AuthorBooks
where AuthorBooks.royaltyper = @percentage

GO
/****** Object:  StoredProcedure [dbo].[reptq1]    Script Date: 10/16/2023 9:50:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[reptq1] AS
select publisherId, ISBN, UnitPrice, YearPublished
from Books
where UnitPrice is NOT NULL
order by publisherId

GO
/****** Object:  StoredProcedure [dbo].[reptq2]    Script Date: 10/16/2023 9:50:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[reptq2] AS
select type, publisherId, Books.ISBN, Edition,
   Name = substring (LastName, 1,15), ytd_sales
from Books, Authors, AuthorBooks
where Books.ISBN = AuthorBooks.ISBN AND Authors.AuthorId = AuthorBooks.AuthorId
   AND publisherId is NOT NULL
order by publisherId, type

GO
/****** Object:  StoredProcedure [dbo].[reptq3]    Script Date: 10/16/2023 9:50:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[reptq3] @lolimit money, @hilimit money,
@type char(12)
AS
select publisherId, type, ISBN, UnitPrice
from Books
where UnitPrice >@lolimit AND UnitPrice <@hilimit AND type = @type OR type LIKE '%cook%'
order by publisherId, type

GO
USE [master]
GO
ALTER DATABASE [HiTechDistributionInc] SET  READ_WRITE 
GO
