USE [master]
GO
/****** Object:  Database [KatarzynaKrawczykLab5Zad1]    Script Date: 13.05.2018 19:56:08 ******/
CREATE DATABASE [KatarzynaKrawczykLab5Zad1]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'KatarzynaKrawczykLab5Zad1', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.FRYGTT\MSSQL\DATA\KatarzynaKrawczykLab5Zad1.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'KatarzynaKrawczykLab5Zad1_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.FRYGTT\MSSQL\DATA\KatarzynaKrawczykLab5Zad1_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [KatarzynaKrawczykLab5Zad1] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [KatarzynaKrawczykLab5Zad1].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [KatarzynaKrawczykLab5Zad1] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [KatarzynaKrawczykLab5Zad1] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [KatarzynaKrawczykLab5Zad1] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [KatarzynaKrawczykLab5Zad1] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [KatarzynaKrawczykLab5Zad1] SET ARITHABORT OFF 
GO
ALTER DATABASE [KatarzynaKrawczykLab5Zad1] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [KatarzynaKrawczykLab5Zad1] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [KatarzynaKrawczykLab5Zad1] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [KatarzynaKrawczykLab5Zad1] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [KatarzynaKrawczykLab5Zad1] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [KatarzynaKrawczykLab5Zad1] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [KatarzynaKrawczykLab5Zad1] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [KatarzynaKrawczykLab5Zad1] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [KatarzynaKrawczykLab5Zad1] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [KatarzynaKrawczykLab5Zad1] SET  DISABLE_BROKER 
GO
ALTER DATABASE [KatarzynaKrawczykLab5Zad1] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [KatarzynaKrawczykLab5Zad1] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [KatarzynaKrawczykLab5Zad1] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [KatarzynaKrawczykLab5Zad1] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [KatarzynaKrawczykLab5Zad1] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [KatarzynaKrawczykLab5Zad1] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [KatarzynaKrawczykLab5Zad1] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [KatarzynaKrawczykLab5Zad1] SET RECOVERY FULL 
GO
ALTER DATABASE [KatarzynaKrawczykLab5Zad1] SET  MULTI_USER 
GO
ALTER DATABASE [KatarzynaKrawczykLab5Zad1] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [KatarzynaKrawczykLab5Zad1] SET DB_CHAINING OFF 
GO
ALTER DATABASE [KatarzynaKrawczykLab5Zad1] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [KatarzynaKrawczykLab5Zad1] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [KatarzynaKrawczykLab5Zad1] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'KatarzynaKrawczykLab5Zad1', N'ON'
GO
ALTER DATABASE [KatarzynaKrawczykLab5Zad1] SET QUERY_STORE = OFF
GO
USE [KatarzynaKrawczykLab5Zad1]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [KatarzynaKrawczykLab5Zad1]
GO
/****** Object:  Table [dbo].[Art]    Script Date: 13.05.2018 19:56:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Art](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ArtName] [nvarchar](64) NOT NULL,
	[ArtDescription] [nvarchar](256) NULL,
	[Photo] [nchar](128) NULL,
 CONSTRAINT [PK_Art] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Client]    Script Date: 13.05.2018 19:56:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](32) NOT NULL,
	[Surname] [nvarchar](32) NOT NULL,
	[Adress] [nvarchar](128) NOT NULL,
	[City] [nvarchar](32) NOT NULL,
	[Email] [nvarchar](32) NULL,
 CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 13.05.2018 19:56:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClientId] [int] NOT NULL,
	[ProductId] [int] NOT NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 13.05.2018 19:56:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](64) NOT NULL,
	[Description] [nvarchar](256) NULL,
	[Photo] [nvarchar](128) NULL,
	[Price] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Art] ON 

INSERT [dbo].[Art] ([Id], [ArtName], [ArtDescription], [Photo]) VALUES (2, N'Coconuts', N'Coconut nut is my favourite nut. If You it too much you will get very fat.', N'/Content/ArtImages/coconuts.jpg                                                                                                 ')
INSERT [dbo].[Art] ([Id], [ArtName], [ArtDescription], [Photo]) VALUES (3, N'Diego and I', N'He reminds me of my forhead so much...', N'/Content/ArtImages/diego_and_i.jpg                                                                                              ')
INSERT [dbo].[Art] ([Id], [ArtName], [ArtDescription], [Photo]) VALUES (4, N'Flower of life', N'This is a flower of my life. ', N'/Content/ArtImages/flower_of_life.jpg                                                                                           ')
INSERT [dbo].[Art] ([Id], [ArtName], [ArtDescription], [Photo]) VALUES (5, N'Coconuts', N'Coconut ', N'/Content/ArtImages/coconuts.jpg                                                                                                 ')
INSERT [dbo].[Art] ([Id], [ArtName], [ArtDescription], [Photo]) VALUES (6, N'Flower of life', N'Nice flower', N'/Content/ArtImages/flower_of_life.jpg                                                                                           ')
SET IDENTITY_INSERT [dbo].[Art] OFF
SET IDENTITY_INSERT [dbo].[Client] ON 

INSERT [dbo].[Client] ([Id], [Name], [Surname], [Adress], [City], [Email]) VALUES (1, N'Janusz', N'Tracz', N'Januszowa 24/5', N'Januszowo', N'Janusz.Tacz@onet.pl')
SET IDENTITY_INSERT [dbo].[Client] OFF
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([Id], [Name], [Description], [Photo], [Price]) VALUES (1, N'Round Clock', N'It''s time to show off your favourite art, photos, and text with a custom round wall clock', N'\Content\ProductImages\clock_theme_1.jpg', CAST(33 AS Decimal(18, 0)))
INSERT [dbo].[Product] ([Id], [Name], [Description], [Photo], [Price]) VALUES (3, N'Portrait Notebook', N'Organise your day with a custom notebook! ', N'\Content\ProductImages\notebook_theme_1.jpg', CAST(5 AS Decimal(18, 0)))
INSERT [dbo].[Product] ([Id], [Name], [Description], [Photo], [Price]) VALUES (4, N'Portrait Tote Bag', N'Versatile, trendy, and durable, this custom tote means you''ll always look fashionable!', N'\Content\ProductImages\bag_theme_1.jpg', CAST(12 AS Decimal(18, 0)))
INSERT [dbo].[Product] ([Id], [Name], [Description], [Photo], [Price]) VALUES (5, N'Water Bottle', N'Drink more water. Your skin, hair, body and mind will thank you. ', N'\Content\ProductImages\water_bottle_theme_1.jpg', CAST(29 AS Decimal(18, 0)))
INSERT [dbo].[Product] ([Id], [Name], [Description], [Photo], [Price]) VALUES (7, N'Coffe Mug', N'Add a pop of colour to your morning coffee! ', N'\Content\ProductImages\coffe_mug_theme_1.jpg', CAST(14 AS Decimal(18, 0)))
SET IDENTITY_INSERT [dbo].[Product] OFF
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Client] FOREIGN KEY([ClientId])
REFERENCES [dbo].[Client] ([Id])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Client]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Product] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Product] ([Id])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Product]
GO
USE [master]
GO
ALTER DATABASE [KatarzynaKrawczykLab5Zad1] SET  READ_WRITE 
GO
