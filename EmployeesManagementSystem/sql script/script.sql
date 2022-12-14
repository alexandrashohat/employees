USE [master]
GO
/****** Object:  Database [EmployeesManagement]    Script Date: 14/08/2022 11:31:22 ******/
CREATE DATABASE [EmployeesManagement]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'EmployeesManagement', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\EmployeesManagement.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'EmployeesManagement_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\EmployeesManagement_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [EmployeesManagement] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [EmployeesManagement].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [EmployeesManagement] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [EmployeesManagement] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [EmployeesManagement] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [EmployeesManagement] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [EmployeesManagement] SET ARITHABORT OFF 
GO
ALTER DATABASE [EmployeesManagement] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [EmployeesManagement] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [EmployeesManagement] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [EmployeesManagement] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [EmployeesManagement] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [EmployeesManagement] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [EmployeesManagement] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [EmployeesManagement] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [EmployeesManagement] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [EmployeesManagement] SET  DISABLE_BROKER 
GO
ALTER DATABASE [EmployeesManagement] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [EmployeesManagement] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [EmployeesManagement] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [EmployeesManagement] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [EmployeesManagement] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [EmployeesManagement] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [EmployeesManagement] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [EmployeesManagement] SET RECOVERY FULL 
GO
ALTER DATABASE [EmployeesManagement] SET  MULTI_USER 
GO
ALTER DATABASE [EmployeesManagement] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [EmployeesManagement] SET DB_CHAINING OFF 
GO
ALTER DATABASE [EmployeesManagement] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [EmployeesManagement] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [EmployeesManagement] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [EmployeesManagement] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'EmployeesManagement', N'ON'
GO
ALTER DATABASE [EmployeesManagement] SET QUERY_STORE = OFF
GO
USE [EmployeesManagement]
GO
/****** Object:  Table [dbo].[Addresses]    Script Date: 14/08/2022 11:31:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Addresses](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[City] [varchar](100) NOT NULL,
	[Street] [varchar](100) NOT NULL,
	[CustomerId] [int] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
	[Created] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Contacts]    Script Date: 14/08/2022 11:31:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contacts](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [varchar](100) NOT NULL,
	[OfficeNumber] [varchar](100) NULL,
	[Email] [varchar](100) NULL,
	[CustomerId] [int] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
	[Created] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 14/08/2022 11:31:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[CustomerNumber] [int] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
	[Created] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [EmployeesManagement] SET  READ_WRITE 
GO
