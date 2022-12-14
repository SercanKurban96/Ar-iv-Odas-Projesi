USE [master]
GO
/****** Object:  Database [DbArsivOdasi]    Script Date: 8.11.2022 22:24:20 ******/
CREATE DATABASE [DbArsivOdasi]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DbArsivOdasi', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SERCANKURBAN\MSSQL\DATA\DbArsivOdasi.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DbArsivOdasi_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SERCANKURBAN\MSSQL\DATA\DbArsivOdasi_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
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
ALTER DATABASE [DbArsivOdasi] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'DbArsivOdasi', N'ON'
GO
ALTER DATABASE [DbArsivOdasi] SET QUERY_STORE = OFF
GO
USE [DbArsivOdasi]
GO
/****** Object:  Table [dbo].[TblBolum]    Script Date: 8.11.2022 22:24:21 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblDosya]    Script Date: 8.11.2022 22:24:21 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblEvrak]    Script Date: 8.11.2022 22:24:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblEvrak](
	[Evrak_ID] [int] IDENTITY(1,1) NOT NULL,
	[Evrak_Adi] [varchar](100) NULL,
	[Evrak_Konusu] [varchar](2000) NULL,
	[Dosya_ID] [int] NULL,
	[Klasor_ID] [int] NULL,
	[Raf_ID] [int] NULL,
	[Bolum_ID] [int] NULL,
	[Oda_ID] [int] NULL,
 CONSTRAINT [PK_TblEvrak] PRIMARY KEY CLUSTERED 
(
	[Evrak_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblKlasor]    Script Date: 8.11.2022 22:24:21 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblKullaniciGirisi]    Script Date: 8.11.2022 22:24:21 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblOda]    Script Date: 8.11.2022 22:24:21 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblRaf]    Script Date: 8.11.2022 22:24:21 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[TblBolum] ON 

INSERT [dbo].[TblBolum] ([Bolum_ID], [Bolum_Adi], [Oda_ID]) VALUES (1, N'Bölüm-1', 1)
INSERT [dbo].[TblBolum] ([Bolum_ID], [Bolum_Adi], [Oda_ID]) VALUES (2, N'Bölüm-2', 1)
SET IDENTITY_INSERT [dbo].[TblBolum] OFF
GO
SET IDENTITY_INSERT [dbo].[TblDosya] ON 

INSERT [dbo].[TblDosya] ([Dosya_ID], [Dosya_Adi], [Klasor_ID], [Raf_ID], [Bolum_ID], [Oda_ID]) VALUES (1, N'Dosya-1', 1, 1, 1, 1)
INSERT [dbo].[TblDosya] ([Dosya_ID], [Dosya_Adi], [Klasor_ID], [Raf_ID], [Bolum_ID], [Oda_ID]) VALUES (2, N'Dosya-2', 1, 1, 1, 1)
SET IDENTITY_INSERT [dbo].[TblDosya] OFF
GO
SET IDENTITY_INSERT [dbo].[TblKlasor] ON 

INSERT [dbo].[TblKlasor] ([Klasor_ID], [Klasor_Adi], [Raf_ID], [Bolum_ID], [Oda_ID]) VALUES (1, N'Klasör-1', 1, 1, 1)
INSERT [dbo].[TblKlasor] ([Klasor_ID], [Klasor_Adi], [Raf_ID], [Bolum_ID], [Oda_ID]) VALUES (2, N'Klasör-2', 1, 1, 1)
SET IDENTITY_INSERT [dbo].[TblKlasor] OFF
GO
SET IDENTITY_INSERT [dbo].[TblKullaniciGirisi] ON 

INSERT [dbo].[TblKullaniciGirisi] ([ID], [Kullanici_Adi], [Sifre], [Sifre_Tekrar], [Guvenlik_Sorusu], [Guvenlik_Cevap]) VALUES (1, N'sercan', N'1', N'1', N'En sevdiğiniz renk nedir?', N'siyah')
INSERT [dbo].[TblKullaniciGirisi] ([ID], [Kullanici_Adi], [Sifre], [Sifre_Tekrar], [Guvenlik_Sorusu], [Guvenlik_Cevap]) VALUES (2, N'deneme', N'123', N'123', N'İlkokul öğretmeninizin adı nedir?', N'bilmiyorum')
SET IDENTITY_INSERT [dbo].[TblKullaniciGirisi] OFF
GO
SET IDENTITY_INSERT [dbo].[TblOda] ON 

INSERT [dbo].[TblOda] ([Oda_ID], [Oda_Adi]) VALUES (1, N'Oda-1')
INSERT [dbo].[TblOda] ([Oda_ID], [Oda_Adi]) VALUES (2, N'Oda-2')
INSERT [dbo].[TblOda] ([Oda_ID], [Oda_Adi]) VALUES (3, N'Oda-3')
INSERT [dbo].[TblOda] ([Oda_ID], [Oda_Adi]) VALUES (4, N'Oda-4')
SET IDENTITY_INSERT [dbo].[TblOda] OFF
GO
SET IDENTITY_INSERT [dbo].[TblRaf] ON 

INSERT [dbo].[TblRaf] ([Raf_ID], [Raf_Adi], [Bolum_ID], [Oda_ID]) VALUES (1, N'Raf-1', 1, 1)
INSERT [dbo].[TblRaf] ([Raf_ID], [Raf_Adi], [Bolum_ID], [Oda_ID]) VALUES (2, N'Raf-2', 1, 1)
SET IDENTITY_INSERT [dbo].[TblRaf] OFF
GO
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
