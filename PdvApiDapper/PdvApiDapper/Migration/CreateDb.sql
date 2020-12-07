USE [master]
GO
/****** Object:  Database [DbPDV]    Script Date: 07/12/2020 12:58:32 ******/
CREATE DATABASE [DbPDV]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DbPDV', FILENAME = N'H:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\DbPDV.mdf' , SIZE = 4288KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'DbPDV_log', FILENAME = N'H:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\DbPDV_log.ldf' , SIZE = 1072KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [DbPDV] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DbPDV].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DbPDV] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DbPDV] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DbPDV] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DbPDV] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DbPDV] SET ARITHABORT OFF 
GO
ALTER DATABASE [DbPDV] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DbPDV] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DbPDV] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DbPDV] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DbPDV] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DbPDV] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DbPDV] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DbPDV] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DbPDV] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DbPDV] SET  ENABLE_BROKER 
GO
ALTER DATABASE [DbPDV] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DbPDV] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DbPDV] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DbPDV] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DbPDV] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DbPDV] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [DbPDV] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DbPDV] SET RECOVERY FULL 
GO
ALTER DATABASE [DbPDV] SET  MULTI_USER 
GO
ALTER DATABASE [DbPDV] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DbPDV] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DbPDV] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DbPDV] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [DbPDV] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'DbPDV', N'ON'
GO
USE [DbPDV]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 07/12/2020 12:58:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PDVS]    Script Date: 07/12/2020 12:58:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PDVS](
	[PDVId] [int] IDENTITY(1,1) NOT NULL,
	[Pagamento] [float] NOT NULL,
	[Preco] [float] NOT NULL,
	[Troco] [float] NOT NULL,
	[NotasMoedas] [nvarchar](max) NULL,
 CONSTRAINT [PK_PDVS] PRIMARY KEY CLUSTERED 
(
	[PDVId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201206031614_PrimeiraMigracao', N'2.2.4-servicing-10062')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201206041807_SegundaMigracao', N'2.2.4-servicing-10062')
GO
SET IDENTITY_INSERT [dbo].[PDVS] ON 
GO
INSERT [dbo].[PDVS] ([PDVId], [Pagamento], [Preco], [Troco], [NotasMoedas]) VALUES (1, 100, 24.33, 75.67, N'
1nota(s) de R$50
1nota(s) de R$20
1nota(s) de R$5

1moeda(s) de50centavo(s)
1moeda(s) de10centavo(s)
1moeda(s) de5centavo(s)
2moeda(s) de1centavo(s)
')
GO
INSERT [dbo].[PDVS] ([PDVId], [Pagamento], [Preco], [Troco], [NotasMoedas]) VALUES (2, 1000, 250.45, 749.55, N'
7nota(s) de R$100
2nota(s) de R$20
1nota(s) de R$5
2nota(s) de R$2

1moeda(s) de50centavo(s)
1moeda(s) de5centavo(s)
')
GO
INSERT [dbo].[PDVS] ([PDVId], [Pagamento], [Preco], [Troco], [NotasMoedas]) VALUES (3, 50, 10.3, 39.7, N'
1 nota(s) de R$20
1 nota(s) de R$10
1 nota(s) de R$5
2 nota(s) de R$2

1 moeda(s) de 50 centavo(s)
2 moeda(s) de 10 centavo(s)
')
GO
INSERT [dbo].[PDVS] ([PDVId], [Pagamento], [Preco], [Troco], [NotasMoedas]) VALUES (4, 100, 75.45, 24.549999999999997, N'
1 nota(s) de R$ 20 - 
2 nota(s) de R$ 2 - 

1 moeda(s) de 50 centavo(s) - 
1 moeda(s) de 5 centavo(s) - 
')
GO
INSERT [dbo].[PDVS] ([PDVId], [Pagamento], [Preco], [Troco], [NotasMoedas]) VALUES (5, 50, 9.45, 40.55, N'
2 nota(s) de R$ 20 
 
1 moeda(s) de 50 centavo(s) 
 1 moeda(s) de 5 centavo(s) 
 ')
GO
INSERT [dbo].[PDVS] ([PDVId], [Pagamento], [Preco], [Troco], [NotasMoedas]) VALUES (6, 20, 5.75, 14.25, N'
1 nota(s) de R$ 10 
 2 nota(s) de R$ 2 
 
1 moeda(s) de 25 centavo(s) 
 ')
GO
INSERT [dbo].[PDVS] ([PDVId], [Pagamento], [Preco], [Troco], [NotasMoedas]) VALUES (7, 50, 33.33, 16.67, N'
1 nota(s) de R$ 10 
 1 nota(s) de R$ 5 
 1 nota(s) de R$ 1 
 
1 moeda(s) de 50 centavo(s) 
 1 moeda(s) de 10 centavo(s) 
 1 moeda(s) de 5 centavo(s) 
 2 moeda(s) de 1 centavo(s) 
 ')
GO
SET IDENTITY_INSERT [dbo].[PDVS] OFF
GO
USE [master]
GO
ALTER DATABASE [DbPDV] SET  READ_WRITE 
GO
