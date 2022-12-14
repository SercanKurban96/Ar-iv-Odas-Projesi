USE [master]
GO
/****** Object:  Database [DbArsivOdasi]    Script Date: 4.11.2022 19:43:00 ******/
CREATE DATABASE [DbArsivOdasi]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DbArsivOdasi', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\DbArsivOdasi.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DbArsivOdasi_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\DbArsivOdasi_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [DbArsivOdasi] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DbArsivOdasi].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DbArsivOdasi] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DbArsivOdasi] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DbArsivOdasi] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DbArsivOdasi] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DbArsivOdasi] SET ARITHABORT OFF 
GO
ALTER DATABASE [DbArsivOdasi] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DbArsivOdasi] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DbArsivOdasi] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DbArsivOdasi] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DbArsivOdasi] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DbArsivOdasi] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DbArsivOdasi] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DbArsivOdasi] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DbArsivOdasi] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DbArsivOdasi] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DbArsivOdasi] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DbArsivOdasi] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DbArsivOdasi] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DbArsivOdasi] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DbArsivOdasi] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DbArsivOdasi] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DbArsivOdasi] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DbArsivOdasi] SET RECOVERY FULL 
GO
ALTER DATABASE [DbArsivOdasi] SET  MULTI_USER 
GO
ALTER DATABASE [DbArsivOdasi] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DbArsivOdasi] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DbArsivOdasi] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DbArsivOdasi] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DbArsivOdasi] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DbArsivOdasi] SET QUERY_STORE = OFF
GO
USE [DbArsivOdasi]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [DbArsivOdasi]
GO
/****** Object:  Table [dbo].[TblBolum]    Script Date: 4.11.2022 19:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblBolum](
	[Bolum_ID] [int] IDENTITY(1,1) NOT NULL,
	[Bolum_Adi] [varchar](50) NULL,
	[Oda_ID] [int] NULL,
 CONSTRAINT [PK_TblBolum] PRIMARY KEY CLUSTERED 
(
	[Bolum_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblDosya]    Script Date: 4.11.2022 19:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblDosya](
	[Dosya_ID] [int] IDENTITY(1,1) NOT NULL,
	[Dosya_Adi] [varchar](50) NULL,
	[Klasor_ID] [int] NULL,
	[Raf_ID] [int] NULL,
	[Bolum_ID] [int] NULL,
	[Oda_ID] [int] NULL,
 CONSTRAINT [PK_TblDosya] PRIMARY KEY CLUSTERED 
(
	[Dosya_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblEvrak]    Script Date: 4.11.2022 19:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblEvrak](
	[Evrak_ID] [int] IDENTITY(1,1) NOT NULL,
	[Evrak_Adi] [varchar](50) NULL,
	[GelenGidenEvrak_ID] [int] NULL,
	[Dosya_ID] [int] NULL,
	[Klasor_ID] [int] NULL,
	[Raf_ID] [int] NULL,
	[Bolum_ID] [int] NULL,
	[Oda_ID] [int] NULL,
 CONSTRAINT [PK_TblEvrak] PRIMARY KEY CLUSTERED 
(
	[Evrak_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblGelenGidenEvrak]    Script Date: 4.11.2022 19:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblGelenGidenEvrak](
	[GelenGidenEvrak_ID] [int] IDENTITY(1,1) NOT NULL,
	[GelenGidenEvrak_Adi] [varchar](50) NULL,
 CONSTRAINT [PK_TblGelenGidenEvrak] PRIMARY KEY CLUSTERED 
(
	[GelenGidenEvrak_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblKlasor]    Script Date: 4.11.2022 19:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblKlasor](
	[Klasor_ID] [int] IDENTITY(1,1) NOT NULL,
	[Klasor_Adi] [varchar](50) NULL,
	[Raf_ID] [int] NULL,
	[Bolum_ID] [int] NULL,
	[Oda_ID] [int] NULL,
 CONSTRAINT [PK_TblKlasor] PRIMARY KEY CLUSTERED 
(
	[Klasor_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblKullaniciGirisi]    Script Date: 4.11.2022 19:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblKullaniciGirisi](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Kullanici_Adi] [varchar](50) NULL,
	[Sifre] [varchar](20) NULL,
	[Sifre_Tekrar] [varchar](20) NULL,
	[Guvenlik_Sorusu] [varchar](200) NULL,
	[Guvenlik_Cevap] [varchar](50) NULL,
 CONSTRAINT [PK_TblKullaniciGirisi] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblOda]    Script Date: 4.11.2022 19:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblOda](
	[Oda_ID] [int] IDENTITY(1,1) NOT NULL,
	[Oda_Adi] [varchar](50) NULL,
 CONSTRAINT [PK_TblOda] PRIMARY KEY CLUSTERED 
(
	[Oda_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblRaf]    Script Date: 4.11.2022 19:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblRaf](
	[Raf_ID] [int] IDENTITY(1,1) NOT NULL,
	[Raf_Adi] [varchar](50) NULL,
	[Bolum_ID] [int] NULL,
	[Oda_ID] [int] NULL,
 CONSTRAINT [PK_TblRaf] PRIMARY KEY CLUSTERED 
(
	[Raf_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[TblBolum] ON 

INSERT [dbo].[TblBolum] ([Bolum_ID], [Bolum_Adi], [Oda_ID]) VALUES (1, N'Bölüm-1', 1)
INSERT [dbo].[TblBolum] ([Bolum_ID], [Bolum_Adi], [Oda_ID]) VALUES (2, N'Bölüm-2', 3)
INSERT [dbo].[TblBolum] ([Bolum_ID], [Bolum_Adi], [Oda_ID]) VALUES (3, N'Bölüm-3', 3)
INSERT [dbo].[TblBolum] ([Bolum_ID], [Bolum_Adi], [Oda_ID]) VALUES (4, N'Bölüm-4', 2)
INSERT [dbo].[TblBolum] ([Bolum_ID], [Bolum_Adi], [Oda_ID]) VALUES (7, N'Bölüm-5', 4)
INSERT [dbo].[TblBolum] ([Bolum_ID], [Bolum_Adi], [Oda_ID]) VALUES (8, N'Bölüm-6', 3)
INSERT [dbo].[TblBolum] ([Bolum_ID], [Bolum_Adi], [Oda_ID]) VALUES (9, N'Bölüm-7', 5)
INSERT [dbo].[TblBolum] ([Bolum_ID], [Bolum_Adi], [Oda_ID]) VALUES (10, N'Bölüm-8', 3)
INSERT [dbo].[TblBolum] ([Bolum_ID], [Bolum_Adi], [Oda_ID]) VALUES (11, N'Bölüm-9', 5)
INSERT [dbo].[TblBolum] ([Bolum_ID], [Bolum_Adi], [Oda_ID]) VALUES (12, N'Bölüm-10', 2)
INSERT [dbo].[TblBolum] ([Bolum_ID], [Bolum_Adi], [Oda_ID]) VALUES (13, N'Bölüm-11', 3)
INSERT [dbo].[TblBolum] ([Bolum_ID], [Bolum_Adi], [Oda_ID]) VALUES (14, N'Bölüm-12', 6)
INSERT [dbo].[TblBolum] ([Bolum_ID], [Bolum_Adi], [Oda_ID]) VALUES (15, N'Bölüm-13', 6)
INSERT [dbo].[TblBolum] ([Bolum_ID], [Bolum_Adi], [Oda_ID]) VALUES (16, N'Bölüm-14', 6)
INSERT [dbo].[TblBolum] ([Bolum_ID], [Bolum_Adi], [Oda_ID]) VALUES (17, N'Bölüm-15', 1)
INSERT [dbo].[TblBolum] ([Bolum_ID], [Bolum_Adi], [Oda_ID]) VALUES (18, N'Bölüm-16', 2)
INSERT [dbo].[TblBolum] ([Bolum_ID], [Bolum_Adi], [Oda_ID]) VALUES (19, N'Bölüm-17', 3)
INSERT [dbo].[TblBolum] ([Bolum_ID], [Bolum_Adi], [Oda_ID]) VALUES (20, N'Bölüm-18', 4)
INSERT [dbo].[TblBolum] ([Bolum_ID], [Bolum_Adi], [Oda_ID]) VALUES (21, N'Bölüm-19', 5)
INSERT [dbo].[TblBolum] ([Bolum_ID], [Bolum_Adi], [Oda_ID]) VALUES (22, N'Bölüm-20', 6)
INSERT [dbo].[TblBolum] ([Bolum_ID], [Bolum_Adi], [Oda_ID]) VALUES (23, N'Bölüm-21', 7)
INSERT [dbo].[TblBolum] ([Bolum_ID], [Bolum_Adi], [Oda_ID]) VALUES (24, N'Bölüm-22', 8)
INSERT [dbo].[TblBolum] ([Bolum_ID], [Bolum_Adi], [Oda_ID]) VALUES (25, N'Bölüm-23', 9)
INSERT [dbo].[TblBolum] ([Bolum_ID], [Bolum_Adi], [Oda_ID]) VALUES (26, N'Bölüm-24', 10)
SET IDENTITY_INSERT [dbo].[TblBolum] OFF
SET IDENTITY_INSERT [dbo].[TblDosya] ON 

INSERT [dbo].[TblDosya] ([Dosya_ID], [Dosya_Adi], [Klasor_ID], [Raf_ID], [Bolum_ID], [Oda_ID]) VALUES (2, N'Dosya-1', 6, 10, 1, 1)
INSERT [dbo].[TblDosya] ([Dosya_ID], [Dosya_Adi], [Klasor_ID], [Raf_ID], [Bolum_ID], [Oda_ID]) VALUES (3, N'Dosya-2', 1, 5, 4, 2)
SET IDENTITY_INSERT [dbo].[TblDosya] OFF
SET IDENTITY_INSERT [dbo].[TblKlasor] ON 

INSERT [dbo].[TblKlasor] ([Klasor_ID], [Klasor_Adi], [Raf_ID], [Bolum_ID], [Oda_ID]) VALUES (1, N'Klasör-1', 5, 4, 2)
INSERT [dbo].[TblKlasor] ([Klasor_ID], [Klasor_Adi], [Raf_ID], [Bolum_ID], [Oda_ID]) VALUES (2, N'Klasör-2', 6, 7, 4)
INSERT [dbo].[TblKlasor] ([Klasor_ID], [Klasor_Adi], [Raf_ID], [Bolum_ID], [Oda_ID]) VALUES (3, N'Klasör-3', 9, 11, 5)
INSERT [dbo].[TblKlasor] ([Klasor_ID], [Klasor_Adi], [Raf_ID], [Bolum_ID], [Oda_ID]) VALUES (4, N'Klasör-4', 9, 11, 5)
INSERT [dbo].[TblKlasor] ([Klasor_ID], [Klasor_Adi], [Raf_ID], [Bolum_ID], [Oda_ID]) VALUES (5, N'Klasör-5', 10, 1, 1)
INSERT [dbo].[TblKlasor] ([Klasor_ID], [Klasor_Adi], [Raf_ID], [Bolum_ID], [Oda_ID]) VALUES (6, N'Klasör-6', 10, 1, 1)
SET IDENTITY_INSERT [dbo].[TblKlasor] OFF
SET IDENTITY_INSERT [dbo].[TblKullaniciGirisi] ON 

INSERT [dbo].[TblKullaniciGirisi] ([ID], [Kullanici_Adi], [Sifre], [Sifre_Tekrar], [Guvenlik_Sorusu], [Guvenlik_Cevap]) VALUES (1, N'sercan', N'1', N'1', N'En sevdiğiniz renk nedir?', N'Siyah')
INSERT [dbo].[TblKullaniciGirisi] ([ID], [Kullanici_Adi], [Sifre], [Sifre_Tekrar], [Guvenlik_Sorusu], [Guvenlik_Cevap]) VALUES (2, N'sercan1', N'2', N'2', N'En sevdiğiniz renk nedir?', N'deneme')
SET IDENTITY_INSERT [dbo].[TblKullaniciGirisi] OFF
SET IDENTITY_INSERT [dbo].[TblOda] ON 

INSERT [dbo].[TblOda] ([Oda_ID], [Oda_Adi]) VALUES (1, N'Oda-1')
INSERT [dbo].[TblOda] ([Oda_ID], [Oda_Adi]) VALUES (2, N'Oda-2')
INSERT [dbo].[TblOda] ([Oda_ID], [Oda_Adi]) VALUES (3, N'Oda-3')
INSERT [dbo].[TblOda] ([Oda_ID], [Oda_Adi]) VALUES (4, N'Oda-4')
INSERT [dbo].[TblOda] ([Oda_ID], [Oda_Adi]) VALUES (5, N'Oda-5')
INSERT [dbo].[TblOda] ([Oda_ID], [Oda_Adi]) VALUES (6, N'Oda-6')
INSERT [dbo].[TblOda] ([Oda_ID], [Oda_Adi]) VALUES (7, N'Oda-7')
INSERT [dbo].[TblOda] ([Oda_ID], [Oda_Adi]) VALUES (8, N'Oda-8')
INSERT [dbo].[TblOda] ([Oda_ID], [Oda_Adi]) VALUES (9, N'Oda-9')
INSERT [dbo].[TblOda] ([Oda_ID], [Oda_Adi]) VALUES (10, N'Oda-10')
SET IDENTITY_INSERT [dbo].[TblOda] OFF
SET IDENTITY_INSERT [dbo].[TblRaf] ON 

INSERT [dbo].[TblRaf] ([Raf_ID], [Raf_Adi], [Bolum_ID], [Oda_ID]) VALUES (5, N'Raf-1', 4, 2)
INSERT [dbo].[TblRaf] ([Raf_ID], [Raf_Adi], [Bolum_ID], [Oda_ID]) VALUES (6, N'Raf-2', 7, 4)
INSERT [dbo].[TblRaf] ([Raf_ID], [Raf_Adi], [Bolum_ID], [Oda_ID]) VALUES (7, N'Raf-3', 10, 3)
INSERT [dbo].[TblRaf] ([Raf_ID], [Raf_Adi], [Bolum_ID], [Oda_ID]) VALUES (8, N'Raf-4', 9, 5)
INSERT [dbo].[TblRaf] ([Raf_ID], [Raf_Adi], [Bolum_ID], [Oda_ID]) VALUES (9, N'Raf-5', 11, 5)
INSERT [dbo].[TblRaf] ([Raf_ID], [Raf_Adi], [Bolum_ID], [Oda_ID]) VALUES (10, N'Raf-6', 1, 1)
INSERT [dbo].[TblRaf] ([Raf_ID], [Raf_Adi], [Bolum_ID], [Oda_ID]) VALUES (11, N'Raf-7', 2, 3)
INSERT [dbo].[TblRaf] ([Raf_ID], [Raf_Adi], [Bolum_ID], [Oda_ID]) VALUES (12, N'Raf-8', 1, 1)
INSERT [dbo].[TblRaf] ([Raf_ID], [Raf_Adi], [Bolum_ID], [Oda_ID]) VALUES (13, N'Raf-9', 17, 1)
INSERT [dbo].[TblRaf] ([Raf_ID], [Raf_Adi], [Bolum_ID], [Oda_ID]) VALUES (14, N'Raf-10', 4, 2)
INSERT [dbo].[TblRaf] ([Raf_ID], [Raf_Adi], [Bolum_ID], [Oda_ID]) VALUES (15, N'Raf-11', 12, 2)
INSERT [dbo].[TblRaf] ([Raf_ID], [Raf_Adi], [Bolum_ID], [Oda_ID]) VALUES (16, N'Raf-12', 18, 2)
INSERT [dbo].[TblRaf] ([Raf_ID], [Raf_Adi], [Bolum_ID], [Oda_ID]) VALUES (17, N'Raf-13', 2, 3)
INSERT [dbo].[TblRaf] ([Raf_ID], [Raf_Adi], [Bolum_ID], [Oda_ID]) VALUES (18, N'Raf-14', 3, 3)
INSERT [dbo].[TblRaf] ([Raf_ID], [Raf_Adi], [Bolum_ID], [Oda_ID]) VALUES (19, N'Raf-15', 8, 3)
INSERT [dbo].[TblRaf] ([Raf_ID], [Raf_Adi], [Bolum_ID], [Oda_ID]) VALUES (20, N'Raf-16', 10, 3)
INSERT [dbo].[TblRaf] ([Raf_ID], [Raf_Adi], [Bolum_ID], [Oda_ID]) VALUES (21, N'Raf-17', 13, 3)
INSERT [dbo].[TblRaf] ([Raf_ID], [Raf_Adi], [Bolum_ID], [Oda_ID]) VALUES (22, N'Raf-18', 19, 3)
INSERT [dbo].[TblRaf] ([Raf_ID], [Raf_Adi], [Bolum_ID], [Oda_ID]) VALUES (23, N'Raf-19', 7, 4)
INSERT [dbo].[TblRaf] ([Raf_ID], [Raf_Adi], [Bolum_ID], [Oda_ID]) VALUES (24, N'Raf-20', 20, 4)
INSERT [dbo].[TblRaf] ([Raf_ID], [Raf_Adi], [Bolum_ID], [Oda_ID]) VALUES (25, N'Raf-21', 21, 5)
SET IDENTITY_INSERT [dbo].[TblRaf] OFF
ALTER TABLE [dbo].[TblBolum]  WITH CHECK ADD  CONSTRAINT [FK_TblBolum_TblOda] FOREIGN KEY([Oda_ID])
REFERENCES [dbo].[TblOda] ([Oda_ID])
GO
ALTER TABLE [dbo].[TblBolum] CHECK CONSTRAINT [FK_TblBolum_TblOda]
GO
ALTER TABLE [dbo].[TblDosya]  WITH CHECK ADD  CONSTRAINT [FK_TblDosya_TblKlasor] FOREIGN KEY([Klasor_ID])
REFERENCES [dbo].[TblKlasor] ([Klasor_ID])
GO
ALTER TABLE [dbo].[TblDosya] CHECK CONSTRAINT [FK_TblDosya_TblKlasor]
GO
ALTER TABLE [dbo].[TblEvrak]  WITH CHECK ADD  CONSTRAINT [FK_TblEvrak_TblDosya] FOREIGN KEY([Dosya_ID])
REFERENCES [dbo].[TblDosya] ([Dosya_ID])
GO
ALTER TABLE [dbo].[TblEvrak] CHECK CONSTRAINT [FK_TblEvrak_TblDosya]
GO
ALTER TABLE [dbo].[TblEvrak]  WITH CHECK ADD  CONSTRAINT [FK_TblEvrak_TblGelenGidenEvrak] FOREIGN KEY([GelenGidenEvrak_ID])
REFERENCES [dbo].[TblGelenGidenEvrak] ([GelenGidenEvrak_ID])
GO
ALTER TABLE [dbo].[TblEvrak] CHECK CONSTRAINT [FK_TblEvrak_TblGelenGidenEvrak]
GO
ALTER TABLE [dbo].[TblKlasor]  WITH CHECK ADD  CONSTRAINT [FK_TblKlasor_TblRaf] FOREIGN KEY([Raf_ID])
REFERENCES [dbo].[TblRaf] ([Raf_ID])
GO
ALTER TABLE [dbo].[TblKlasor] CHECK CONSTRAINT [FK_TblKlasor_TblRaf]
GO
ALTER TABLE [dbo].[TblRaf]  WITH CHECK ADD  CONSTRAINT [FK_TblRaf_TblBolum] FOREIGN KEY([Bolum_ID])
REFERENCES [dbo].[TblBolum] ([Bolum_ID])
GO
ALTER TABLE [dbo].[TblRaf] CHECK CONSTRAINT [FK_TblRaf_TblBolum]
GO
USE [master]
GO
ALTER DATABASE [DbArsivOdasi] SET  READ_WRITE 
GO
