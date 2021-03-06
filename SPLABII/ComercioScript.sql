USE [master]
GO
/****** Object:  Database [ComercioHamburguesas]    Script Date: 24/11/2020 18:39:15 ******/
CREATE DATABASE [ComercioHamburguesas]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ComercioEmpanadas', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\ComercioEmpanadas.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ComercioEmpanadas_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\ComercioEmpanadas_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [ComercioHamburguesas] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ComercioHamburguesas].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ComercioHamburguesas] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ComercioHamburguesas] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ComercioHamburguesas] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ComercioHamburguesas] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ComercioHamburguesas] SET ARITHABORT OFF 
GO
ALTER DATABASE [ComercioHamburguesas] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ComercioHamburguesas] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ComercioHamburguesas] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ComercioHamburguesas] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ComercioHamburguesas] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ComercioHamburguesas] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ComercioHamburguesas] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ComercioHamburguesas] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ComercioHamburguesas] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ComercioHamburguesas] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ComercioHamburguesas] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ComercioHamburguesas] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ComercioHamburguesas] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ComercioHamburguesas] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ComercioHamburguesas] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ComercioHamburguesas] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ComercioHamburguesas] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ComercioHamburguesas] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ComercioHamburguesas] SET  MULTI_USER 
GO
ALTER DATABASE [ComercioHamburguesas] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ComercioHamburguesas] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ComercioHamburguesas] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ComercioHamburguesas] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ComercioHamburguesas] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ComercioHamburguesas] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [ComercioHamburguesas] SET QUERY_STORE = OFF
GO
USE [ComercioHamburguesas]
GO
/****** Object:  Table [dbo].[ComercioHamburguesas]    Script Date: 24/11/2020 18:39:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ComercioHamburguesas](
	[Id] [int] IDENTITY(546,1) NOT NULL,
	[producto] [nvarchar](50) NOT NULL,
	[medioDePago] [nvarchar](50) NOT NULL,
	[domicilio] [nvarchar](50) NULL,
	[contactoNumero] [nvarchar](50) NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ComercioHamburguesas] ON 

INSERT [dbo].[ComercioHamburguesas] ([Id], [producto], [medioDePago], [domicilio], [contactoNumero]) VALUES (581, N'HamburguesaSimple', N'efectivo', N'LOCAL', N'LOCAL')
INSERT [dbo].[ComercioHamburguesas] ([Id], [producto], [medioDePago], [domicilio], [contactoNumero]) VALUES (582, N'Hamburguesa Completa', N'efectivo', N'LOCAL', N'LOCAL')
INSERT [dbo].[ComercioHamburguesas] ([Id], [producto], [medioDePago], [domicilio], [contactoNumero]) VALUES (583, N'Hamburguesa Con Queso', N'tarjeta', N'Av Corrientes 1500', N'1147458569')
INSERT [dbo].[ComercioHamburguesas] ([Id], [producto], [medioDePago], [domicilio], [contactoNumero]) VALUES (584, N'Hamburguesa Simple', N'cheque', N'LOCAL', N'LOCAL')
INSERT [dbo].[ComercioHamburguesas] ([Id], [producto], [medioDePago], [domicilio], [contactoNumero]) VALUES (585, N'Hamburguesa Mega', N'tarjeta', N'Juramento 4700', N'1174526987')
INSERT [dbo].[ComercioHamburguesas] ([Id], [producto], [medioDePago], [domicilio], [contactoNumero]) VALUES (589, N'Hamburguesa Mega', N'efectivo', N'EN LOCAL', N'EN LOCAL')
INSERT [dbo].[ComercioHamburguesas] ([Id], [producto], [medioDePago], [domicilio], [contactoNumero]) VALUES (590, N'Hamburguesa Mega', N'medioElectronico', N'EN LOCAL', N'EN LOCAL')
INSERT [dbo].[ComercioHamburguesas] ([Id], [producto], [medioDePago], [domicilio], [contactoNumero]) VALUES (603, N'Hamburguesa Mega', N'tarjeta', N'Baragas 789', N'1565874')
INSERT [dbo].[ComercioHamburguesas] ([Id], [producto], [medioDePago], [domicilio], [contactoNumero]) VALUES (592, N'Hamburguesa Mega', N'tarjeta', N'Av de la Independecia 870', N'11658594')
INSERT [dbo].[ComercioHamburguesas] ([Id], [producto], [medioDePago], [domicilio], [contactoNumero]) VALUES (596, N'Hamburguesa Mega', N'tarjeta', N'Av Libertador 4700', N'115897854')
INSERT [dbo].[ComercioHamburguesas] ([Id], [producto], [medioDePago], [domicilio], [contactoNumero]) VALUES (604, N'Hamburguesa Mega', N'tarjeta', N'Libertador 544', N'35535')
INSERT [dbo].[ComercioHamburguesas] ([Id], [producto], [medioDePago], [domicilio], [contactoNumero]) VALUES (605, N'Hamburguesa Queso', N'tarjeta', N'Brazil 789', N'55698745')
INSERT [dbo].[ComercioHamburguesas] ([Id], [producto], [medioDePago], [domicilio], [contactoNumero]) VALUES (606, N'Hamburguesa Queso', N'cheque', N'EN LOCAL', N'EN LOCAL')
INSERT [dbo].[ComercioHamburguesas] ([Id], [producto], [medioDePago], [domicilio], [contactoNumero]) VALUES (607, N'Hamburguesa Queso', N'tarjeta', N'Colombia 7896', N'88745658')
SET IDENTITY_INSERT [dbo].[ComercioHamburguesas] OFF
GO
USE [master]
GO
ALTER DATABASE [ComercioHamburguesas] SET  READ_WRITE 
GO
