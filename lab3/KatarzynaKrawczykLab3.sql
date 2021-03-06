USE [master]
GO
/****** Object:  Database [Pizzeria]    Script Date: 21.04.2018 14:02:29 ******/
CREATE DATABASE [Pizzeria]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Pizzeria', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.FRYGTT\MSSQL\DATA\Pizzeria.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Pizzeria_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.FRYGTT\MSSQL\DATA\Pizzeria_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Pizzeria] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Pizzeria].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Pizzeria] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Pizzeria] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Pizzeria] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Pizzeria] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Pizzeria] SET ARITHABORT OFF 
GO
ALTER DATABASE [Pizzeria] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Pizzeria] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Pizzeria] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Pizzeria] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Pizzeria] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Pizzeria] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Pizzeria] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Pizzeria] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Pizzeria] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Pizzeria] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Pizzeria] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Pizzeria] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Pizzeria] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Pizzeria] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Pizzeria] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Pizzeria] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Pizzeria] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Pizzeria] SET RECOVERY FULL 
GO
ALTER DATABASE [Pizzeria] SET  MULTI_USER 
GO
ALTER DATABASE [Pizzeria] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Pizzeria] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Pizzeria] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Pizzeria] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Pizzeria] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Pizzeria', N'ON'
GO
ALTER DATABASE [Pizzeria] SET QUERY_STORE = OFF
GO
USE [Pizzeria]
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
USE [Pizzeria]
GO
/****** Object:  Table [dbo].[Ingredients]    Script Date: 21.04.2018 14:02:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ingredients](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](31) NOT NULL,
	[PricePerUnit] [money] NOT NULL,
 CONSTRAINT [PK_Ingredients] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pizzas]    Script Date: 21.04.2018 14:02:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pizzas](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](31) NOT NULL,
	[Diameter] [tinyint] NOT NULL,
	[Price] [money] NOT NULL,
	[Seasonal] [bit] NOT NULL,
 CONSTRAINT [PK_Pizzas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Topics]    Script Date: 21.04.2018 14:02:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Topics](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdIngredients] [int] NOT NULL,
	[IdPizza] [int] NOT NULL,
 CONSTRAINT [PK_Topics] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Ingredients] ON 

INSERT [dbo].[Ingredients] ([Id], [Name], [PricePerUnit]) VALUES (1, N'boczek', 2.5000)
INSERT [dbo].[Ingredients] ([Id], [Name], [PricePerUnit]) VALUES (2, N'szpinak', 1.5000)
INSERT [dbo].[Ingredients] ([Id], [Name], [PricePerUnit]) VALUES (3, N'ananas', 0.0000)
INSERT [dbo].[Ingredients] ([Id], [Name], [PricePerUnit]) VALUES (4, N'kurczak', 3.0000)
INSERT [dbo].[Ingredients] ([Id], [Name], [PricePerUnit]) VALUES (5, N'gyros', 3.0000)
INSERT [dbo].[Ingredients] ([Id], [Name], [PricePerUnit]) VALUES (6, N'mozzarella', 2.5000)
INSERT [dbo].[Ingredients] ([Id], [Name], [PricePerUnit]) VALUES (7, N'gorgonzola', 3.0000)
INSERT [dbo].[Ingredients] ([Id], [Name], [PricePerUnit]) VALUES (8, N'pieczarki', 1.5000)
INSERT [dbo].[Ingredients] ([Id], [Name], [PricePerUnit]) VALUES (9, N'jajko', 2.5000)
SET IDENTITY_INSERT [dbo].[Ingredients] OFF
SET IDENTITY_INSERT [dbo].[Pizzas] ON 

INSERT [dbo].[Pizzas] ([Id], [Name], [Diameter], [Price], [Seasonal]) VALUES (5, N'Carbonara', 32, 18.5000, 1)
INSERT [dbo].[Pizzas] ([Id], [Name], [Diameter], [Price], [Seasonal]) VALUES (6, N'Margeritta', 32, 15.0000, 1)
INSERT [dbo].[Pizzas] ([Id], [Name], [Diameter], [Price], [Seasonal]) VALUES (9, N'Arabska', 32, 18.0000, 0)
SET IDENTITY_INSERT [dbo].[Pizzas] OFF
SET IDENTITY_INSERT [dbo].[Topics] ON 

INSERT [dbo].[Topics] ([Id], [IdIngredients], [IdPizza]) VALUES (1, 1, 5)
INSERT [dbo].[Topics] ([Id], [IdIngredients], [IdPizza]) VALUES (2, 9, 5)
INSERT [dbo].[Topics] ([Id], [IdIngredients], [IdPizza]) VALUES (3, 6, 6)
INSERT [dbo].[Topics] ([Id], [IdIngredients], [IdPizza]) VALUES (4, 6, 5)
INSERT [dbo].[Topics] ([Id], [IdIngredients], [IdPizza]) VALUES (5, 5, 9)
INSERT [dbo].[Topics] ([Id], [IdIngredients], [IdPizza]) VALUES (6, 6, 9)
INSERT [dbo].[Topics] ([Id], [IdIngredients], [IdPizza]) VALUES (7, 2, 9)
SET IDENTITY_INSERT [dbo].[Topics] OFF
ALTER TABLE [dbo].[Topics]  WITH CHECK ADD  CONSTRAINT [FK_Topics_Ingredients] FOREIGN KEY([IdIngredients])
REFERENCES [dbo].[Ingredients] ([Id])
GO
ALTER TABLE [dbo].[Topics] CHECK CONSTRAINT [FK_Topics_Ingredients]
GO
ALTER TABLE [dbo].[Topics]  WITH CHECK ADD  CONSTRAINT [FK_Topics_Pizzas] FOREIGN KEY([IdPizza])
REFERENCES [dbo].[Pizzas] ([Id])
GO
ALTER TABLE [dbo].[Topics] CHECK CONSTRAINT [FK_Topics_Pizzas]
GO
USE [master]
GO
ALTER DATABASE [Pizzeria] SET  READ_WRITE 
GO
