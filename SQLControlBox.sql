USE [master]
GO
/****** Object:  Database [dbcontrolbox]    Script Date: 24/06/2023 8:14:25 p. m. ******/
CREATE DATABASE [dbcontrolbox]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'dbcontrolbox', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\dbcontrolbox.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'dbcontrolbox_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\dbcontrolbox_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [dbcontrolbox] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [dbcontrolbox].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [dbcontrolbox] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [dbcontrolbox] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [dbcontrolbox] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [dbcontrolbox] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [dbcontrolbox] SET ARITHABORT OFF 
GO
ALTER DATABASE [dbcontrolbox] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [dbcontrolbox] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [dbcontrolbox] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [dbcontrolbox] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [dbcontrolbox] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [dbcontrolbox] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [dbcontrolbox] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [dbcontrolbox] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [dbcontrolbox] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [dbcontrolbox] SET  ENABLE_BROKER 
GO
ALTER DATABASE [dbcontrolbox] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [dbcontrolbox] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [dbcontrolbox] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [dbcontrolbox] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [dbcontrolbox] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [dbcontrolbox] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [dbcontrolbox] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [dbcontrolbox] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [dbcontrolbox] SET  MULTI_USER 
GO
ALTER DATABASE [dbcontrolbox] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [dbcontrolbox] SET DB_CHAINING OFF 
GO
ALTER DATABASE [dbcontrolbox] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [dbcontrolbox] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [dbcontrolbox] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [dbcontrolbox] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [dbcontrolbox] SET QUERY_STORE = ON
GO
ALTER DATABASE [dbcontrolbox] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [dbcontrolbox]
GO
/****** Object:  Table [dbo].[corresponsales]    Script Date: 24/06/2023 8:14:25 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[corresponsales](
	[cor_corresponsal_id] [int] IDENTITY(1,1) NOT NULL,
	[cor_nombre] [varchar](80) NULL,
PRIMARY KEY CLUSTERED 
(
	[cor_corresponsal_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[giros]    Script Date: 24/06/2023 8:14:25 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[giros](
	[gir_giro_id] [int] IDENTITY(1,1) NOT NULL,
	[gir_recibo] [int] NULL,
	[gir_oficina_id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[gir_giro_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[oficinas]    Script Date: 24/06/2023 8:14:25 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[oficinas](
	[ofi_oficina_id] [int] IDENTITY(1,1) NOT NULL,
	[ofi_nombre] [varchar](80) NULL,
	[ofi_corresponsal_id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ofi_oficina_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[corresponsales] ([cor_corresponsal_id], [cor_nombre]) VALUES (1, N'Banque Atlantique Bénin')
GO
INSERT [dbo].[corresponsales] ([cor_corresponsal_id], [cor_nombre]) VALUES (2, N'PAMECAS')
GO
INSERT [dbo].[giros] ([gir_giro_id], [gir_recibo], [gir_oficina_id]) VALUES (1, 1020, 1)
GO
INSERT [dbo].[giros] ([gir_giro_id], [gir_recibo], [gir_oficina_id]) VALUES (2, 1121, 1)
GO
INSERT [dbo].[giros] ([gir_giro_id], [gir_recibo], [gir_oficina_id]) VALUES (3, 1222, 1)
GO
INSERT [dbo].[giros] ([gir_giro_id], [gir_recibo], [gir_oficina_id]) VALUES (4, 1323, 1)
GO
INSERT [dbo].[giros] ([gir_giro_id], [gir_recibo], [gir_oficina_id]) VALUES (5, 1424, 1)
GO
INSERT [dbo].[giros] ([gir_giro_id], [gir_recibo], [gir_oficina_id]) VALUES (6, 2030, 2)
GO
INSERT [dbo].[giros] ([gir_giro_id], [gir_recibo], [gir_oficina_id]) VALUES (7, 2131, 2)
GO
INSERT [dbo].[giros] ([gir_giro_id], [gir_recibo], [gir_oficina_id]) VALUES (8, 2232, 2)
GO
INSERT [dbo].[giros] ([gir_giro_id], [gir_recibo], [gir_oficina_id]) VALUES (9, 2333, 2)
GO
INSERT [dbo].[giros] ([gir_giro_id], [gir_recibo], [gir_oficina_id]) VALUES (10, 3040, 3)
GO
INSERT [dbo].[giros] ([gir_giro_id], [gir_recibo], [gir_oficina_id]) VALUES (11, 3141, 3)
GO
INSERT [dbo].[giros] ([gir_giro_id], [gir_recibo], [gir_oficina_id]) VALUES (12, NULL, 3)
GO
INSERT [dbo].[oficinas] ([ofi_oficina_id], [ofi_nombre], [ofi_corresponsal_id]) VALUES (1, N'Thiaroye', 1)
GO
INSERT [dbo].[oficinas] ([ofi_oficina_id], [ofi_nombre], [ofi_corresponsal_id]) VALUES (2, N'Campus', 1)
GO
INSERT [dbo].[oficinas] ([ofi_oficina_id], [ofi_nombre], [ofi_corresponsal_id]) VALUES (3, N'Main', 2)
GO
ALTER TABLE [dbo].[giros]  WITH CHECK ADD  CONSTRAINT [FK_giros_oficinas] FOREIGN KEY([gir_oficina_id])
REFERENCES [dbo].[oficinas] ([ofi_oficina_id])
GO
ALTER TABLE [dbo].[giros] CHECK CONSTRAINT [FK_giros_oficinas]
GO
ALTER TABLE [dbo].[oficinas]  WITH CHECK ADD  CONSTRAINT [FK_oficinas_corresponsales1] FOREIGN KEY([ofi_corresponsal_id])
REFERENCES [dbo].[corresponsales] ([cor_corresponsal_id])
GO
ALTER TABLE [dbo].[oficinas] CHECK CONSTRAINT [FK_oficinas_corresponsales1]
GO
USE [master]
GO
ALTER DATABASE [dbcontrolbox] SET  READ_WRITE 
GO
