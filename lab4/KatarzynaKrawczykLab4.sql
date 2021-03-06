USE [master]
GO
/****** Object:  Database [KatarzynaKrawczykLab4]    Script Date: 29.04.2018 21:29:09 ******/
CREATE DATABASE [KatarzynaKrawczykLab4]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'KatarzynaKrawczykLab4', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.FRYGTT\MSSQL\DATA\KatarzynaKrawczykLab4.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'KatarzynaKrawczykLab4_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.FRYGTT\MSSQL\DATA\KatarzynaKrawczykLab4_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [KatarzynaKrawczykLab4] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [KatarzynaKrawczykLab4].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [KatarzynaKrawczykLab4] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [KatarzynaKrawczykLab4] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [KatarzynaKrawczykLab4] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [KatarzynaKrawczykLab4] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [KatarzynaKrawczykLab4] SET ARITHABORT OFF 
GO
ALTER DATABASE [KatarzynaKrawczykLab4] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [KatarzynaKrawczykLab4] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [KatarzynaKrawczykLab4] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [KatarzynaKrawczykLab4] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [KatarzynaKrawczykLab4] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [KatarzynaKrawczykLab4] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [KatarzynaKrawczykLab4] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [KatarzynaKrawczykLab4] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [KatarzynaKrawczykLab4] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [KatarzynaKrawczykLab4] SET  ENABLE_BROKER 
GO
ALTER DATABASE [KatarzynaKrawczykLab4] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [KatarzynaKrawczykLab4] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [KatarzynaKrawczykLab4] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [KatarzynaKrawczykLab4] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [KatarzynaKrawczykLab4] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [KatarzynaKrawczykLab4] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [KatarzynaKrawczykLab4] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [KatarzynaKrawczykLab4] SET RECOVERY FULL 
GO
ALTER DATABASE [KatarzynaKrawczykLab4] SET  MULTI_USER 
GO
ALTER DATABASE [KatarzynaKrawczykLab4] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [KatarzynaKrawczykLab4] SET DB_CHAINING OFF 
GO
ALTER DATABASE [KatarzynaKrawczykLab4] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [KatarzynaKrawczykLab4] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [KatarzynaKrawczykLab4] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'KatarzynaKrawczykLab4', N'ON'
GO
ALTER DATABASE [KatarzynaKrawczykLab4] SET QUERY_STORE = OFF
GO
USE [KatarzynaKrawczykLab4]
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
USE [KatarzynaKrawczykLab4]
GO
/****** Object:  Table [dbo].[__MigrationHistory]    Script Date: 29.04.2018 21:29:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__MigrationHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ContextKey] [nvarchar](300) NOT NULL,
	[Model] [varbinary](max) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC,
	[ContextKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Games]    Script Date: 29.04.2018 21:29:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Games](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Producer] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_dbo.Games] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reviews]    Script Date: 29.04.2018 21:29:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reviews](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Text] [nvarchar](max) NOT NULL,
	[Date] [datetime] NOT NULL,
	[GameId] [int] NOT NULL,
	[Score] [int] NOT NULL,
 CONSTRAINT [PK_dbo.Reviews] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__MigrationHistory] ([MigrationId], [ContextKey], [Model], [ProductVersion]) VALUES (N'201804261801492_Init', N'KatarzynaKrawczykLab4.Migrations.Configuration', 0x1F8B0800000000000400ED59DB6EE336107D2FD07F10F4D41659CBCEEE431BD8BB489D0B8C5C11398BBE05B4347688A52895A4B2F616FDB23EF493FA0B1D8ABA5F7CCB26688B224060539C33179E19CEC87FFDF1E7F0C33260D6130849433EB207BDBE6D01F7429FF2C5C88ED5FCCD8FF687F7DF7E333CF583A5F531DBF756EF43492E47F6A352D191E348EF1102227B01F54428C3B9EA7961E0103F740EFBFD9F9CC1C00184B011CBB2867731573480E40B7E1D87DC8348C5845D853E3099AEE3133741B5AE490032221E8CEC0BA288F8B2E2E44290CFDE97D5A74B327BD73372B675CC28419B5C6073DB229C878A28B4F8E85E82AB44C8176E840B844D5711E0BE396112524F8E8AEDDB3AD53FD44E39856006E5C55285C18E8083B769949CBAF85EB1B6F328621C4F31DE6AA5BD4E6239B2CFF1BF6DD5151D8D99D09BD687B9A7850FACD62D073949904BFAEFC01AC74CC502461C6225083BB06EE319A3DE05ACA6E127E0231E33563616CDC56795055CBA15610442ADEE609EBA30F16DCBA9CA3975C15CAC24631C9C70F5F6D0B6AE51399931C8B9500A86AB4201E7C0411005FE2D510A04D7189044B3A1BDA6EB3A09B1D186E4C38CB2AD2BB2BC04BE508F231B3FDAD6195D829FADA416DC738A0988424AC4D062E17AADF8D58F3D10AFA0F99A3CD14512AA9A0D77F044E133A6E31DB0E4B97CA491C9CA9E79F660F87726C2E02E64B948B2FC302562010A1D089BCFDC30165ECD94A153D07B2DE90DD0DEB437E2FF137F1305A7B054AF4FFC13B435D3AA3F4F69B03B88E6D8E6506D9B0786E4FB254146F4B624C812649B24389632F4686240250B8CF2AA23A7DCB7D658620EB4B01F4F15194E23E4342A1ED93F3422D30E98E77701682251851BD8F554B8E127C0408175EC995B754CA447FCE689602CFCEA0A660F084D5FC2B0DB90988F94AB66AA51EED188B06EA36B225BE6A7362907AF3F398108B84EADEED86FA335A36E5373AEA016A44D31193A25F2340B2BCA289400911A701C457A2949FE4685C5062C2DB232CDEF3A5334A40BAAE40D5E2005A72B4469D0AC2A9CDF3F0DF18CB83580929F759434494B3B5A72B81EF2F589949B5BB2B4716AEB53A7049146AA9E0155975A0A457E7C45B7ED98763B6BCB9D8EBE7C7845A208AB7AA94F4F572CD734E9E337EEEE3D6B60301C4FB6B4AEB9B5B926BCA3C8026A4F51355A7A46855478079019D1E57AEC078D6D25B27670295354E663F390327E65BBF56723B1B1836EC9EA14E50C3D0B7441482EE2DA5937C592398930225AEEFC71C8E28077D7A56E69D3BE96E5AF5B726F1D42D18A96518AD526D2D0A945A051CB1A116F14FEEAF16D75B859167EB5E34DCBCCEE07DC25F832476C1AB5B2BC59D91EC1345D6504B3B23D42766D9531BAAEB2172648A332D6B7E4DAF30A59AB84C3B42A6D7E8DD12853668B6D61789EA8AF4B94BB920A829EDED0737F656346D1DF62C315E1740E529959C23EEC0F0E6BEF3FFE39EF221C297DB6C50B89571F86A88EE8C67167C721A23CF8F32722BC4722BE0BC8F2FB670FF3BBA0ED3A15FF37625F9E3D9F17FBF23CE9E367F5FC7932F1B8D11A4FB0375F8EECDF1291236BF2CB83913AB06E04E6F991D5B77EDFF3ACF71BFECECB2FAE5E653AAB37BB7B0D9B7B8D781D8DD80B0D75FF8E41AED9426F9ED53A473573AF610ACD423C55C3E0F691A57D8A5B33C4B541770C542F38E195BD2F9AF4CD035DCB1CF832535CB32741C6947E8041AE4ABA2820F4CF311CBC0A57F23D133E0F33CAD62CCAB6D44AE0152882F5931C0B45E7C453F8D8032993B7821F098B71CB6930037FC26F6215C50A5D8660C62A6F1935F5D7E94F46D5AACDC39B2879E9F6355C4033A9BE026EF8CF31657E6EF7594B25EE80D039955E73FA2C95BEEE16AB1CE93AE45B02A5E1CB4BC11482882198BCE12E79827D6CBB9770090BE2ADB2D6B21B64F34154C33E3CA164214820538C421EBF2287FD60F9FE6F947B50E1871C0000, N'6.2.0-61023')
INSERT [dbo].[__MigrationHistory] ([MigrationId], [ContextKey], [Model], [ProductVersion]) VALUES (N'201804261811221_add Score', N'KatarzynaKrawczykLab4.Migrations.Configuration', 0x1F8B0800000000000400ED59596FE336107E2FD0FF20E8A92DB29693DD87D6B077913A07821C0E2267D1B78096C60EB114A59254D6DEA2BFAC0FFD49FD0B1D8ABA0F5FD9046D510408246AE69B8333C319FAAF3FFE1C7E5806CC7A022169C847F661AF6F5BC0BDD0A77C31B263357FF3A3FDE1FDB7DF0C4FFD60697DCCE8DE6A3AE4E472643F2A150D1C477A8F1010D90BA8274219CE55CF0B0387F8A173D4EFFFE41C1E3A8010366259D6F02EE68A0690BCE0EB38E41E442A26EC3AF481C9741DBFB809AA7543029011F160645F1245C497152797827CF6BEAC3E5D91D9BB9EE1B3AD634609EAE4029BDB16E13C5444A1C6837B09AE12215FB8112E10365D45807473C224A4960C0AF26D8DEA1F69A39C823183F262A9C26047C0C3B7A9979C3AFB5EBEB6732FA21F4FD1DF6AA5AD4E7C39B2CFF1BF6DD5050DC64C68A2F56EEE69E603AB95E4200F128C25FD77608D63A66201230EB112841D58B7F18C51EF1256D3F013F0118F192B2B8BEAE2B7CA022EDD8A3002A15677304F4DB8F06DCBA9F23975C69CADC4630CBCE0EAED916DDDA070326390C742C919AE0A059C03074114F8B74429105C6340E2CD86F49AAC9BC4C5461A061F66946D5D93E515F0857A1CD9F8685B6774097EB6926A70CF292620322911438B86EBA5E2AB1F7B205E41F20D79A28BC455351DEEE089C2674CC73B60C977F9482393953DF3EDC1C4DF990883BB90E52CC9F2C39488052834206C7E73C358783555864E11DE6B83DE00ED1DF686FDFFC0DF14825358AAD70FFC13D43593AA9FA734D81DC4F5D0F24D9E5A0FA1C374B3B7B74D259327FBE551962B6D7994E5D83679742C65E8D144814A2219E155434EB96FADD1C4C444A13F060626098D302D50F0C8FEA1E19976C0BC441480C61355B843BB9E4D137E020C1458C79E3998C7447AC46FEE08FAC2AFAE600282D0194018362C12539A72D5CC56CA3D1A11D6AD748D65CB14D72AE5E0F52F271001D7D9D9EDFB6DA466A1DB949C0BA83969934F864E29789AB519791472804815388E22BD94D48F4691C61E2EADD3322D11F548D1902EA89235780615315D099446985599F323ACC19E056E0DA064671D254DD212454B0ED75DBE3E9172754B9A36766D7DEA9420524FD533A06A524BA1C8B7AF68D81DD3B1679DBDD3D1DA0FAF4914E1C1506AF5D315CB357DFEF88DBB7BDB1B180CC7932DDD6FAE6D2E098F39B280DA57148D9A9E5121151E23644674B91EFB4183AC14AC1DB194092AC7637393B2F8CAA8F5B3E1D8D884B764758A72869605BA202467796DAF9B6CC9A84518112D6DC3386471C0BBEB5237B7E980CBFC372DB9B70EA1E866CB28C56A1369E8D43CD0A8650D8F370A7F75FBB6DADC2C0BBFDAF6A66566F70DEE627C992D36BD5E99DFAC6C8F60FAB6328259D91E216DDACA10E9D2F618D9D15706E93A0E5F38C81AD5B54E924BCFAB6CAD9A0ED3CAB6F936A551EA0C896DA17B9EA8AFCB9CBB920A829E26E8B9BFB231A3686F41704D389D835466A4B18FFA8747B56B987FCE958823A5CFB6B81779F5998C6A8F6E9CBA761C44CAF70FFC8908EF9188EF02B2FCFED9770ABBA0ED3A9CFF377C5F1E819FE7FBF258EBE3B37AF6589B18FCACA1364168F4E71738202C47F66F09CBC0BAF8E5C1701D581381856260F5ADDFF70C96FD26D0F3F205DCAB8C88F58E7BAF8977AF39B3A31B7CA1C9F2DF314D36FBF8CD0363E7BC680E46CCC15988BB6A22B87D6E6A1F25D74C926DD01D53DD0B8E9965EB8B4961F354D9328CBECC28D96C6A30624A3F2461AC4ABA2820F4CF4A1CBC4AACE434177C1E66215BD32823A995C06B50040B3039168ACE89A7F0B3075226B79B1F098B91E43498817FC127B18A62852643306395DB521DFAEBE427F37255E7E1244A6EFEBE8609A826D567C884FF1C53E6E77A9FB554E20E089D53E939A9F752E9F372B1CA916E42BE2550EABEBC144C21881882C90977C913ECA3DBBD842B58106F95F5A6DD209B37A2EAF6E109250B4102996214FCF88A31EC07CBF77F03F5CC9DEC4F1D0000, N'6.2.0-61023')
SET IDENTITY_INSERT [dbo].[Games] ON 

INSERT [dbo].[Games] ([Id], [Name], [Producer]) VALUES (1, N'Witcher3', N'CD Project Red')
INSERT [dbo].[Games] ([Id], [Name], [Producer]) VALUES (2, N'Biedronks', N'BB')
INSERT [dbo].[Games] ([Id], [Name], [Producer]) VALUES (3, N'Name', N'XXX')
INSERT [dbo].[Games] ([Id], [Name], [Producer]) VALUES (4, N'fff', N'fff')
SET IDENTITY_INSERT [dbo].[Games] OFF
/****** Object:  Index [IX_GameId]    Script Date: 29.04.2018 21:29:10 ******/
CREATE NONCLUSTERED INDEX [IX_GameId] ON [dbo].[Reviews]
(
	[GameId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Reviews] ADD  DEFAULT ((0)) FOR [Score]
GO
ALTER TABLE [dbo].[Reviews]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Reviews_dbo.Games_GameId] FOREIGN KEY([GameId])
REFERENCES [dbo].[Games] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Reviews] CHECK CONSTRAINT [FK_dbo.Reviews_dbo.Games_GameId]
GO
USE [master]
GO
ALTER DATABASE [KatarzynaKrawczykLab4] SET  READ_WRITE 
GO
