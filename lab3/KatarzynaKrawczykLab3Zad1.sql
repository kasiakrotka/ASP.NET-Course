USE [master]
GO
/****** Object:  Database [FitApp]    Script Date: 24.04.2018 23:15:33 ******/
CREATE DATABASE [FitApp]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'FitApp', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.FRYGTT\MSSQL\DATA\FitApp.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'FitApp_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.FRYGTT\MSSQL\DATA\FitApp_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [FitApp] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [FitApp].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [FitApp] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [FitApp] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [FitApp] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [FitApp] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [FitApp] SET ARITHABORT OFF 
GO
ALTER DATABASE [FitApp] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [FitApp] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [FitApp] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [FitApp] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [FitApp] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [FitApp] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [FitApp] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [FitApp] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [FitApp] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [FitApp] SET  DISABLE_BROKER 
GO
ALTER DATABASE [FitApp] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [FitApp] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [FitApp] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [FitApp] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [FitApp] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [FitApp] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [FitApp] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [FitApp] SET RECOVERY FULL 
GO
ALTER DATABASE [FitApp] SET  MULTI_USER 
GO
ALTER DATABASE [FitApp] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [FitApp] SET DB_CHAINING OFF 
GO
ALTER DATABASE [FitApp] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [FitApp] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [FitApp] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'FitApp', N'ON'
GO
ALTER DATABASE [FitApp] SET QUERY_STORE = OFF
GO
USE [FitApp]
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
USE [FitApp]
GO
/****** Object:  Table [dbo].[Ingredients]    Script Date: 24.04.2018 23:15:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ingredients](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Kcal] [float] NOT NULL,
	[Protein] [float] NOT NULL,
	[Fats] [float] NOT NULL,
	[Carbs] [float] NOT NULL,
	[Weight] [float] NOT NULL,
 CONSTRAINT [PK_Components] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MealIngredients]    Script Date: 24.04.2018 23:15:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MealIngredients](
	[IdMeal] [int] NOT NULL,
	[IdIngredient] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Meals]    Script Date: 24.04.2018 23:15:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Meals](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Vegetarian] [bit] NOT NULL,
	[Vegan] [bit] NOT NULL,
	[Kcal] [float] NOT NULL,
 CONSTRAINT [PK_Meals] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MealsList]    Script Date: 24.04.2018 23:15:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MealsList](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Date] [date] NOT NULL,
	[IdMeal] [int] NOT NULL,
 CONSTRAINT [PK_MealsList] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Progress]    Script Date: 24.04.2018 23:15:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Progress](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Date] [date] NOT NULL,
	[Weight] [int] NOT NULL,
 CONSTRAINT [PK_Progress] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Workouts]    Script Date: 24.04.2018 23:15:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Workouts](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Time] [int] NOT NULL,
	[Kcal] [float] NOT NULL,
 CONSTRAINT [PK_Workouts] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[WorkoutsList]    Script Date: 24.04.2018 23:15:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WorkoutsList](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Date] [date] NOT NULL,
	[WorkoutId] [int] NOT NULL,
 CONSTRAINT [PK_WorkoutList] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Ingredients] ON 

INSERT [dbo].[Ingredients] ([Id], [Name], [Kcal], [Protein], [Fats], [Carbs], [Weight]) VALUES (1, N'jajko', 155, 12.6, 10.6, 1.1, 100)
INSERT [dbo].[Ingredients] ([Id], [Name], [Kcal], [Protein], [Fats], [Carbs], [Weight]) VALUES (4, N'cebula czerwona', 33, 1.4, 0.4, 5.2, 100)
INSERT [dbo].[Ingredients] ([Id], [Name], [Kcal], [Protein], [Fats], [Carbs], [Weight]) VALUES (5, N'papryka czerwona', 32, 1.3, 0.5, 4.9, 100)
INSERT [dbo].[Ingredients] ([Id], [Name], [Kcal], [Protein], [Fats], [Carbs], [Weight]) VALUES (12, N'kromka chleba', 86, 0.3, 52.7, 8, 35)
INSERT [dbo].[Ingredients] ([Id], [Name], [Kcal], [Protein], [Fats], [Carbs], [Weight]) VALUES (13, N'masło', 37, 82.5, 0.7, 0.7, 5)
INSERT [dbo].[Ingredients] ([Id], [Name], [Kcal], [Protein], [Fats], [Carbs], [Weight]) VALUES (14, N'mleko', 108, 3.5, 5, 3.4, 230)
INSERT [dbo].[Ingredients] ([Id], [Name], [Kcal], [Protein], [Fats], [Carbs], [Weight]) VALUES (15, N'płatki owsiane górskie', 37, 7.2, 69.3, 11.9, 20)
INSERT [dbo].[Ingredients] ([Id], [Name], [Kcal], [Protein], [Fats], [Carbs], [Weight]) VALUES (16, N'garść oliwek', 132, 12.7, 1.7, 1.4, 45)
INSERT [dbo].[Ingredients] ([Id], [Name], [Kcal], [Protein], [Fats], [Carbs], [Weight]) VALUES (17, N'pomidor', 32, 0.2, 2.9, 0.9, 170)
INSERT [dbo].[Ingredients] ([Id], [Name], [Kcal], [Protein], [Fats], [Carbs], [Weight]) VALUES (18, N'ser feta', 130, 10.9, 0.1, 7.7, 50)
INSERT [dbo].[Ingredients] ([Id], [Name], [Kcal], [Protein], [Fats], [Carbs], [Weight]) VALUES (19, N'ogórek ', 25, 0.1, 2.4, 0.7, 180)
INSERT [dbo].[Ingredients] ([Id], [Name], [Kcal], [Protein], [Fats], [Carbs], [Weight]) VALUES (20, N'pita', 219, 1.3, 55, 8.8, 80)
INSERT [dbo].[Ingredients] ([Id], [Name], [Kcal], [Protein], [Fats], [Carbs], [Weight]) VALUES (21, N'sałata lodowa', 16, 0.2, 1.4, 1.5, 100)
INSERT [dbo].[Ingredients] ([Id], [Name], [Kcal], [Protein], [Fats], [Carbs], [Weight]) VALUES (22, N'kurczak grillowany', 150, 10, 0, 28, 75)
INSERT [dbo].[Ingredients] ([Id], [Name], [Kcal], [Protein], [Fats], [Carbs], [Weight]) VALUES (23, N'makaron świderki', 214, 2.1, 80.2, 4.5, 60)
INSERT [dbo].[Ingredients] ([Id], [Name], [Kcal], [Protein], [Fats], [Carbs], [Weight]) VALUES (24, N'twaróg chudy', 113, 0.5, 2.2, 25, 100)
INSERT [dbo].[Ingredients] ([Id], [Name], [Kcal], [Protein], [Fats], [Carbs], [Weight]) VALUES (26, N'łyżeczka cukru', 20, 0, 5, 0, 5)
INSERT [dbo].[Ingredients] ([Id], [Name], [Kcal], [Protein], [Fats], [Carbs], [Weight]) VALUES (27, N'szczypiorek', 2, 0, 0.1, 0.2, 5)
SET IDENTITY_INSERT [dbo].[Ingredients] OFF
INSERT [dbo].[MealIngredients] ([IdMeal], [IdIngredient]) VALUES (2, 12)
INSERT [dbo].[MealIngredients] ([IdMeal], [IdIngredient]) VALUES (2, 13)
INSERT [dbo].[MealIngredients] ([IdMeal], [IdIngredient]) VALUES (4, 14)
INSERT [dbo].[MealIngredients] ([IdMeal], [IdIngredient]) VALUES (4, 15)
INSERT [dbo].[MealIngredients] ([IdMeal], [IdIngredient]) VALUES (6, 16)
INSERT [dbo].[MealIngredients] ([IdMeal], [IdIngredient]) VALUES (6, 17)
INSERT [dbo].[MealIngredients] ([IdMeal], [IdIngredient]) VALUES (6, 18)
INSERT [dbo].[MealIngredients] ([IdMeal], [IdIngredient]) VALUES (6, 19)
INSERT [dbo].[MealIngredients] ([IdMeal], [IdIngredient]) VALUES (7, 17)
INSERT [dbo].[MealIngredients] ([IdMeal], [IdIngredient]) VALUES (7, 19)
INSERT [dbo].[MealIngredients] ([IdMeal], [IdIngredient]) VALUES (7, 4)
INSERT [dbo].[MealIngredients] ([IdMeal], [IdIngredient]) VALUES (7, 20)
INSERT [dbo].[MealIngredients] ([IdMeal], [IdIngredient]) VALUES (7, 21)
INSERT [dbo].[MealIngredients] ([IdMeal], [IdIngredient]) VALUES (7, 22)
INSERT [dbo].[MealIngredients] ([IdMeal], [IdIngredient]) VALUES (8, 23)
INSERT [dbo].[MealIngredients] ([IdMeal], [IdIngredient]) VALUES (8, 24)
INSERT [dbo].[MealIngredients] ([IdMeal], [IdIngredient]) VALUES (8, 26)
INSERT [dbo].[MealIngredients] ([IdMeal], [IdIngredient]) VALUES (10, 1)
INSERT [dbo].[MealIngredients] ([IdMeal], [IdIngredient]) VALUES (10, 1)
INSERT [dbo].[MealIngredients] ([IdMeal], [IdIngredient]) VALUES (10, 13)
INSERT [dbo].[MealIngredients] ([IdMeal], [IdIngredient]) VALUES (10, 27)
INSERT [dbo].[MealIngredients] ([IdMeal], [IdIngredient]) VALUES (16, 27)
INSERT [dbo].[MealIngredients] ([IdMeal], [IdIngredient]) VALUES (16, 1)
INSERT [dbo].[MealIngredients] ([IdMeal], [IdIngredient]) VALUES (16, 5)
INSERT [dbo].[MealIngredients] ([IdMeal], [IdIngredient]) VALUES (16, 4)
INSERT [dbo].[MealIngredients] ([IdMeal], [IdIngredient]) VALUES (17, 16)
INSERT [dbo].[MealIngredients] ([IdMeal], [IdIngredient]) VALUES (17, 17)
INSERT [dbo].[MealIngredients] ([IdMeal], [IdIngredient]) VALUES (17, 4)
INSERT [dbo].[MealIngredients] ([IdMeal], [IdIngredient]) VALUES (17, 5)
INSERT [dbo].[MealIngredients] ([IdMeal], [IdIngredient]) VALUES (17, 21)
SET IDENTITY_INSERT [dbo].[Meals] ON 

INSERT [dbo].[Meals] ([Id], [Name], [Vegetarian], [Vegan], [Kcal]) VALUES (2, N'grzanki', 1, 0, 123)
INSERT [dbo].[Meals] ([Id], [Name], [Vegetarian], [Vegan], [Kcal]) VALUES (4, N'owsianka', 1, 0, 145)
INSERT [dbo].[Meals] ([Id], [Name], [Vegetarian], [Vegan], [Kcal]) VALUES (6, N'sałatka grecka', 0, 0, 319)
INSERT [dbo].[Meals] ([Id], [Name], [Vegetarian], [Vegan], [Kcal]) VALUES (7, N'kebab', 0, 0, 475)
INSERT [dbo].[Meals] ([Id], [Name], [Vegetarian], [Vegan], [Kcal]) VALUES (8, N'makaron z serem', 1, 0, 214)
INSERT [dbo].[Meals] ([Id], [Name], [Vegetarian], [Vegan], [Kcal]) VALUES (10, N'jajecznica', 1, 0, 349)
INSERT [dbo].[Meals] ([Id], [Name], [Vegetarian], [Vegan], [Kcal]) VALUES (16, N'omlet', 1, 0, 222)
INSERT [dbo].[Meals] ([Id], [Name], [Vegetarian], [Vegan], [Kcal]) VALUES (17, N'sałatka wiosenna', 0, 1, 245)
SET IDENTITY_INSERT [dbo].[Meals] OFF
SET IDENTITY_INSERT [dbo].[MealsList] ON 

INSERT [dbo].[MealsList] ([Id], [Date], [IdMeal]) VALUES (3, CAST(N'2018-04-17' AS Date), 2)
INSERT [dbo].[MealsList] ([Id], [Date], [IdMeal]) VALUES (11, CAST(N'2018-04-24' AS Date), 10)
INSERT [dbo].[MealsList] ([Id], [Date], [IdMeal]) VALUES (12, CAST(N'2018-04-24' AS Date), 8)
INSERT [dbo].[MealsList] ([Id], [Date], [IdMeal]) VALUES (13, CAST(N'2018-04-24' AS Date), 4)
INSERT [dbo].[MealsList] ([Id], [Date], [IdMeal]) VALUES (14, CAST(N'2018-04-24' AS Date), 6)
INSERT [dbo].[MealsList] ([Id], [Date], [IdMeal]) VALUES (15, CAST(N'2018-04-23' AS Date), 7)
INSERT [dbo].[MealsList] ([Id], [Date], [IdMeal]) VALUES (16, CAST(N'2018-04-23' AS Date), 7)
INSERT [dbo].[MealsList] ([Id], [Date], [IdMeal]) VALUES (17, CAST(N'2018-04-23' AS Date), 2)
INSERT [dbo].[MealsList] ([Id], [Date], [IdMeal]) VALUES (18, CAST(N'2018-04-23' AS Date), 10)
SET IDENTITY_INSERT [dbo].[MealsList] OFF
SET IDENTITY_INSERT [dbo].[Progress] ON 

INSERT [dbo].[Progress] ([Id], [Date], [Weight]) VALUES (1, CAST(N'2018-04-22' AS Date), 58)
INSERT [dbo].[Progress] ([Id], [Date], [Weight]) VALUES (3, CAST(N'2018-04-12' AS Date), 59)
INSERT [dbo].[Progress] ([Id], [Date], [Weight]) VALUES (5, CAST(N'2018-04-05' AS Date), 60)
INSERT [dbo].[Progress] ([Id], [Date], [Weight]) VALUES (6, CAST(N'2018-04-24' AS Date), 57)
SET IDENTITY_INSERT [dbo].[Progress] OFF
SET IDENTITY_INSERT [dbo].[Workouts] ON 

INSERT [dbo].[Workouts] ([Id], [Name], [Time], [Kcal]) VALUES (2, N'pływanie', 60, 468)
INSERT [dbo].[Workouts] ([Id], [Name], [Time], [Kcal]) VALUES (3, N'odkurzanie', 60, 135)
INSERT [dbo].[Workouts] ([Id], [Name], [Time], [Kcal]) VALUES (4, N'skakanka', 60, 492)
INSERT [dbo].[Workouts] ([Id], [Name], [Time], [Kcal]) VALUES (6, N'czytanie', 60, 38)
INSERT [dbo].[Workouts] ([Id], [Name], [Time], [Kcal]) VALUES (7, N'joga', 60, 175)
INSERT [dbo].[Workouts] ([Id], [Name], [Time], [Kcal]) VALUES (9, N'spacer', 60, 150)
SET IDENTITY_INSERT [dbo].[Workouts] OFF
SET IDENTITY_INSERT [dbo].[WorkoutsList] ON 

INSERT [dbo].[WorkoutsList] ([Id], [Date], [WorkoutId]) VALUES (6, CAST(N'2018-04-24' AS Date), 2)
INSERT [dbo].[WorkoutsList] ([Id], [Date], [WorkoutId]) VALUES (7, CAST(N'2018-04-23' AS Date), 7)
SET IDENTITY_INSERT [dbo].[WorkoutsList] OFF
ALTER TABLE [dbo].[MealIngredients]  WITH CHECK ADD  CONSTRAINT [FK_MealIngredients_Ingredients] FOREIGN KEY([IdIngredient])
REFERENCES [dbo].[Ingredients] ([Id])
GO
ALTER TABLE [dbo].[MealIngredients] CHECK CONSTRAINT [FK_MealIngredients_Ingredients]
GO
ALTER TABLE [dbo].[MealIngredients]  WITH CHECK ADD  CONSTRAINT [FK_MealIngredients_Meals] FOREIGN KEY([IdMeal])
REFERENCES [dbo].[Meals] ([Id])
GO
ALTER TABLE [dbo].[MealIngredients] CHECK CONSTRAINT [FK_MealIngredients_Meals]
GO
ALTER TABLE [dbo].[MealsList]  WITH CHECK ADD  CONSTRAINT [FK_Table_1_Meals] FOREIGN KEY([IdMeal])
REFERENCES [dbo].[Meals] ([Id])
GO
ALTER TABLE [dbo].[MealsList] CHECK CONSTRAINT [FK_Table_1_Meals]
GO
ALTER TABLE [dbo].[WorkoutsList]  WITH CHECK ADD  CONSTRAINT [FK_WorkoutsList_Workouts] FOREIGN KEY([WorkoutId])
REFERENCES [dbo].[Workouts] ([Id])
GO
ALTER TABLE [dbo].[WorkoutsList] CHECK CONSTRAINT [FK_WorkoutsList_Workouts]
GO
USE [master]
GO
ALTER DATABASE [FitApp] SET  READ_WRITE 
GO
