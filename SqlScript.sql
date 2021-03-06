USE [master]
GO
/****** Object:  Database [EntityCodeFirst]    Script Date: 2/26/2020 2:31:11 PM ******/
CREATE DATABASE [EntityCodeFirst]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'EntityCodeFirst', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\EntityCodeFirst.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'EntityCodeFirst_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\EntityCodeFirst_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [EntityCodeFirst] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [EntityCodeFirst].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [EntityCodeFirst] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [EntityCodeFirst] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [EntityCodeFirst] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [EntityCodeFirst] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [EntityCodeFirst] SET ARITHABORT OFF 
GO
ALTER DATABASE [EntityCodeFirst] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [EntityCodeFirst] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [EntityCodeFirst] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [EntityCodeFirst] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [EntityCodeFirst] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [EntityCodeFirst] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [EntityCodeFirst] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [EntityCodeFirst] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [EntityCodeFirst] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [EntityCodeFirst] SET  DISABLE_BROKER 
GO
ALTER DATABASE [EntityCodeFirst] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [EntityCodeFirst] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [EntityCodeFirst] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [EntityCodeFirst] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [EntityCodeFirst] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [EntityCodeFirst] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [EntityCodeFirst] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [EntityCodeFirst] SET RECOVERY FULL 
GO
ALTER DATABASE [EntityCodeFirst] SET  MULTI_USER 
GO
ALTER DATABASE [EntityCodeFirst] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [EntityCodeFirst] SET DB_CHAINING OFF 
GO
ALTER DATABASE [EntityCodeFirst] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [EntityCodeFirst] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [EntityCodeFirst] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'EntityCodeFirst', N'ON'
GO
USE [EntityCodeFirst]
GO
/****** Object:  Table [dbo].[DepartmentMaster]    Script Date: 2/26/2020 2:31:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DepartmentMaster](
	[DId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Origin] [nvarchar](50) NULL,
	[Slogan] [nvarchar](50) NULL,
	[OId] [int] NOT NULL,
 CONSTRAINT [PK_DepartmentMaster] PRIMARY KEY CLUSTERED 
(
	[DId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[EmployeeMaster]    Script Date: 2/26/2020 2:31:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmployeeMaster](
	[EId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Age] [int] NULL,
	[Gender] [nvarchar](2) NULL,
	[Address] [nvarchar](100) NULL,
	[City] [nvarchar](50) NULL,
	[ContactNo] [nvarchar](50) NULL,
	[DId] [int] NULL,
 CONSTRAINT [PK_EmployeeMaster] PRIMARY KEY CLUSTERED 
(
	[EId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[OrganizationMaster]    Script Date: 2/26/2020 2:31:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrganizationMaster](
	[OId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Address] [nvarchar](500) NULL,
	[City] [nvarchar](50) NULL,
	[Country] [nvarchar](50) NULL,
 CONSTRAINT [PK_OrganizationMaster] PRIMARY KEY CLUSTERED 
(
	[OId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[DepartmentMaster] ON 

INSERT [dbo].[DepartmentMaster] ([DId], [Name], [Origin], [Slogan], [OId]) VALUES (1, N'Engineering', N'India', N'Bring Life to work', 1)
INSERT [dbo].[DepartmentMaster] ([DId], [Name], [Origin], [Slogan], [OId]) VALUES (2, N'Support', N'India', N'Bring Life to Work', 1)
INSERT [dbo].[DepartmentMaster] ([DId], [Name], [Origin], [Slogan], [OId]) VALUES (3, N'Engineering', N'USA', N'We Do Business', 2)
INSERT [dbo].[DepartmentMaster] ([DId], [Name], [Origin], [Slogan], [OId]) VALUES (4, N'Sales', N'USA', N'We Do Business', 2)
SET IDENTITY_INSERT [dbo].[DepartmentMaster] OFF
SET IDENTITY_INSERT [dbo].[EmployeeMaster] ON 

INSERT [dbo].[EmployeeMaster] ([EId], [Name], [Age], [Gender], [Address], [City], [ContactNo], [DId]) VALUES (1, N'Nikhil', 28, N'M', N'Wagholi', N'Pune', N'8668426979', 1)
SET IDENTITY_INSERT [dbo].[EmployeeMaster] OFF
SET IDENTITY_INSERT [dbo].[OrganizationMaster] ON 

INSERT [dbo].[OrganizationMaster] ([OId], [Name], [Address], [City], [Country]) VALUES (1, N'Cybage', N'Kalyani nagar', N'Pune', N'India')
INSERT [dbo].[OrganizationMaster] ([OId], [Name], [Address], [City], [Country]) VALUES (2, N'IBM', N'Yervada', N'Hyderabad', N'India')
INSERT [dbo].[OrganizationMaster] ([OId], [Name], [Address], [City], [Country]) VALUES (3, N'Infosys', N'Hinjewadi', N'Pune', N'India')
SET IDENTITY_INSERT [dbo].[OrganizationMaster] OFF
ALTER TABLE [dbo].[DepartmentMaster]  WITH CHECK ADD  CONSTRAINT [FK_DepartmentMaster_OrganizationMaster] FOREIGN KEY([OId])
REFERENCES [dbo].[OrganizationMaster] ([OId])
GO
ALTER TABLE [dbo].[DepartmentMaster] CHECK CONSTRAINT [FK_DepartmentMaster_OrganizationMaster]
GO
ALTER TABLE [dbo].[EmployeeMaster]  WITH CHECK ADD  CONSTRAINT [FK_EmployeeMaster_DepartmentMaster] FOREIGN KEY([DId])
REFERENCES [dbo].[DepartmentMaster] ([DId])
GO
ALTER TABLE [dbo].[EmployeeMaster] CHECK CONSTRAINT [FK_EmployeeMaster_DepartmentMaster]
GO
USE [master]
GO
ALTER DATABASE [EntityCodeFirst] SET  READ_WRITE 
GO
