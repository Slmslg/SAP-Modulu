USE [MALIYET_YONETIMI]
GO
/****** Object:  StoredProcedure [dbo].[CinsEkle]    Script Date: 18.05.2017 13:06:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CinsEkle]
	@turid int ,
	@cinsAd nvarchar(100),
	@aciklama nvarchar(100)
AS
declare @cinsid int
set @cinsid=-1
select @cinsid=CinsId from Cins where CinsAd=@cinsAd

if @cinsid=-1
begin
insert into Cins(cinsAd,Acıklama) values(@cinsAd,@aciklama)
select @cinsid=CinsId from Cins where CinsAd=@cinsAd
end

insert into TurCins(TurId,CinsId)values(@turid,@cinsid)





GO
/****** Object:  Table [dbo].[Cins]    Script Date: 18.05.2017 13:06:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cins](
	[CinsId] [int] IDENTITY(1,1) NOT NULL,
	[CinsAd] [nvarchar](50) NOT NULL,
	[Acıklama] [nvarchar](50) NULL,
 CONSTRAINT [PK_Cins] PRIMARY KEY CLUSTERED 
(
	[CinsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[FIRMALAR]    Script Date: 18.05.2017 13:06:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[FIRMALAR](
	[FirmaID] [int] IDENTITY(1,1) NOT NULL,
	[FirmaAdi] [varchar](50) NULL,
	[Adres] [varchar](50) NULL,
	[Telefon] [varchar](50) NULL,
 CONSTRAINT [PK_FIRMALAR] PRIMARY KEY CLUSTERED 
(
	[FirmaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[GELIRLER]    Script Date: 18.05.2017 13:06:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[GELIRLER](
	[GelirID] [int] IDENTITY(1,1) NOT NULL,
	[Tur] [varchar](50) NULL,
	[Aciklama] [varchar](50) NULL,
	[Tutar] [float] NULL,
	[Tarih] [date] NULL,
 CONSTRAINT [PK_GELIRLER] PRIMARY KEY CLUSTERED 
(
	[GelirID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[GIDERLER]    Script Date: 18.05.2017 13:06:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[GIDERLER](
	[GiderID] [int] IDENTITY(1,1) NOT NULL,
	[Tur] [varchar](50) NULL,
	[Aciklama] [varchar](50) NULL,
	[Tutar] [float] NULL,
	[Tarih] [date] NULL,
 CONSTRAINT [PK_GIDERLER] PRIMARY KEY CLUSTERED 
(
	[GiderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MALZEME]    Script Date: 18.05.2017 13:06:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MALZEME](
	[MalzemeID] [int] IDENTITY(1,1) NOT NULL,
	[MalzemeAdi] [varchar](50) NULL,
	[BirimFiyat] [nvarchar](50) NULL,
	[Aciklama] [varchar](50) NULL,
	[TurCinsId] [int] NULL,
	[Adet] [nvarchar](50) NULL,
	[Birim] [varchar](20) NULL,
 CONSTRAINT [PK_MALZEME] PRIMARY KEY CLUSTERED 
(
	[MalzemeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MUSTERILER]    Script Date: 18.05.2017 13:06:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MUSTERILER](
	[MusteriID] [int] IDENTITY(1,1) NOT NULL,
	[TC] [varchar](50) NULL,
	[MusteriAd] [varchar](50) NULL,
	[MusteriSoyad] [varchar](50) NULL,
	[Adres] [varchar](50) NULL,
	[Telefon] [varchar](15) NULL,
 CONSTRAINT [PK_MUSTERILER] PRIMARY KEY CLUSTERED 
(
	[MusteriID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PERSONEL]    Script Date: 18.05.2017 13:06:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PERSONEL](
	[PersonelID] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [varchar](50) NULL,
	[Soyad] [varchar](50) NULL,
	[TC] [varchar](11) NULL,
	[Unvan] [varchar](50) NULL,
	[Maas] [bigint] NULL,
	[GirisTarihi] [date] NULL,
 CONSTRAINT [PK_PERSONEL] PRIMARY KEY CLUSTERED 
(
	[PersonelID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SATIS]    Script Date: 18.05.2017 13:06:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SATIS](
	[SatisID] [int] IDENTITY(1,1) NOT NULL,
	[UrunID] [int] NULL,
	[Adet] [int] NULL,
	[Tarih] [date] NULL,
	[FirmaId] [int] NULL,
	[Tutar] [float] NULL,
	[Aciklama] [varchar](50) NULL,
	[MusteriID] [int] NULL,
 CONSTRAINT [PK_SATIS] PRIMARY KEY CLUSTERED 
(
	[SatisID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SIPARISLER]    Script Date: 18.05.2017 13:06:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SIPARISLER](
	[SiparisID] [int] IDENTITY(1,1) NOT NULL,
	[MalzemeID] [int] NULL,
	[Adet] [int] NULL,
	[Tarih] [date] NULL,
	[TahminiGelirTarihi] [date] NULL,
	[Aciklama] [varchar](50) NULL,
	[Tutar] [bigint] NULL,
 CONSTRAINT [PK_SIPARISLER] PRIMARY KEY CLUSTERED 
(
	[SiparisID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[STOK]    Script Date: 18.05.2017 13:06:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[STOK](
	[StokID] [int] IDENTITY(1,1) NOT NULL,
	[UrunID] [int] NULL,
	[Adet] [int] NULL,
	[Tarih] [date] NULL,
 CONSTRAINT [PK_STOK] PRIMARY KEY CLUSTERED 
(
	[StokID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TUR]    Script Date: 18.05.2017 13:06:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TUR](
	[TurID] [int] IDENTITY(1,1) NOT NULL,
	[TurAd] [nvarchar](50) NOT NULL,
	[Aciklama] [nvarchar](50) NULL,
 CONSTRAINT [PK_TUR] PRIMARY KEY CLUSTERED 
(
	[TurID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TurCins]    Script Date: 18.05.2017 13:06:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TurCins](
	[TurCinsId] [int] IDENTITY(1,1) NOT NULL,
	[TurID] [int] NOT NULL,
	[CinsId] [int] NOT NULL,
 CONSTRAINT [PK_TurCins] PRIMARY KEY CLUSTERED 
(
	[TurCinsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[URUNLER]    Script Date: 18.05.2017 13:06:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[URUNLER](
	[UrunID] [int] IDENTITY(1,1) NOT NULL,
	[UrunAd] [varchar](50) NULL,
	[BirimFiyat] [bigint] NULL,
	[Aciklama] [varchar](50) NULL,
	[Tur] [nvarchar](50) NULL,
 CONSTRAINT [PK_URUNLER] PRIMARY KEY CLUSTERED 
(
	[UrunID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Cins] ON 

INSERT [dbo].[Cins] ([CinsId], [CinsAd], [Acıklama]) VALUES (3, N'KG', N'Agrılık Ölçü Birimi KG cinsinden')
SET IDENTITY_INSERT [dbo].[Cins] OFF
SET IDENTITY_INSERT [dbo].[FIRMALAR] ON 

INSERT [dbo].[FIRMALAR] ([FirmaID], [FirmaAdi], [Adres], [Telefon]) VALUES (1, N'Düzce Üniversitesi', N'Düzce', N'5045045656')
SET IDENTITY_INSERT [dbo].[FIRMALAR] OFF
SET IDENTITY_INSERT [dbo].[GELIRLER] ON 

INSERT [dbo].[GELIRLER] ([GelirID], [Tur], [Aciklama], [Tutar], [Tarih]) VALUES (1, N'Ürün Satış', N'100 tl lik ürün satışı', 1000, CAST(0xCB3C0B00 AS Date))
SET IDENTITY_INSERT [dbo].[GELIRLER] OFF
SET IDENTITY_INSERT [dbo].[GIDERLER] ON 

INSERT [dbo].[GIDERLER] ([GiderID], [Tur], [Aciklama], [Tutar], [Tarih]) VALUES (56, N'Elektirk Faturası', N'Elektrik Faturası Ödemesi', 1234, CAST(0x5E3D0B00 AS Date))
INSERT [dbo].[GIDERLER] ([GiderID], [Tur], [Aciklama], [Tutar], [Tarih]) VALUES (57, N'Dogal Gaz Faturası', N'Dogal Gaz Faturası Ödemesi', 1500, CAST(0xCA3C0B00 AS Date))
SET IDENTITY_INSERT [dbo].[GIDERLER] OFF
SET IDENTITY_INSERT [dbo].[MALZEME] ON 

INSERT [dbo].[MALZEME] ([MalzemeID], [MalzemeAdi], [BirimFiyat], [Aciklama], [TurCinsId], [Adet], [Birim]) VALUES (2, N'Buğday', N'350', N'asdsada', 3, N'3', N'3 Torba')
SET IDENTITY_INSERT [dbo].[MALZEME] OFF
SET IDENTITY_INSERT [dbo].[MUSTERILER] ON 

INSERT [dbo].[MUSTERILER] ([MusteriID], [TC], [MusteriAd], [MusteriSoyad], [Adres], [Telefon]) VALUES (5, N'987654321', N'Betül', N'Kasarlıoglu', N'Düzce Üniversitesi', N'5045044512')
SET IDENTITY_INSERT [dbo].[MUSTERILER] OFF
SET IDENTITY_INSERT [dbo].[PERSONEL] ON 

INSERT [dbo].[PERSONEL] ([PersonelID], [Ad], [Soyad], [TC], [Unvan], [Maas], [GirisTarihi]) VALUES (1, N'selim', N'silgu', N'12345', N'Ögrenci', 3200, CAST(0x9B3D0B00 AS Date))
SET IDENTITY_INSERT [dbo].[PERSONEL] OFF
SET IDENTITY_INSERT [dbo].[SATIS] ON 

INSERT [dbo].[SATIS] ([SatisID], [UrunID], [Adet], [Tarih], [FirmaId], [Tutar], [Aciklama], [MusteriID]) VALUES (7, 1, 2, CAST(0xCC3C0B00 AS Date), 0, 500, N'aaaa', 5)
INSERT [dbo].[SATIS] ([SatisID], [UrunID], [Adet], [Tarih], [FirmaId], [Tutar], [Aciklama], [MusteriID]) VALUES (8, 1, 1, CAST(0xCD3C0B00 AS Date), 1, 250, N'bbb', 0)
INSERT [dbo].[SATIS] ([SatisID], [UrunID], [Adet], [Tarih], [FirmaId], [Tutar], [Aciklama], [MusteriID]) VALUES (10, 1, 8, CAST(0xD53C0B00 AS Date), 0, 2000, N'asdsda', 5)
SET IDENTITY_INSERT [dbo].[SATIS] OFF
SET IDENTITY_INSERT [dbo].[TUR] ON 

INSERT [dbo].[TUR] ([TurID], [TurAd], [Aciklama]) VALUES (3, N'Agırlık', N'Ölçü Birimi')
SET IDENTITY_INSERT [dbo].[TUR] OFF
SET IDENTITY_INSERT [dbo].[TurCins] ON 

INSERT [dbo].[TurCins] ([TurCinsId], [TurID], [CinsId]) VALUES (3, 3, 3)
SET IDENTITY_INSERT [dbo].[TurCins] OFF
SET IDENTITY_INSERT [dbo].[URUNLER] ON 

INSERT [dbo].[URUNLER] ([UrunID], [UrunAd], [BirimFiyat], [Aciklama], [Tur]) VALUES (1, N'Urun1', 250, N'Urun1 satışa hazır', N'Agırlık')
INSERT [dbo].[URUNLER] ([UrunID], [UrunAd], [BirimFiyat], [Aciklama], [Tur]) VALUES (2, N'Urun3', 350, N'sdsadsadsa', N'Agırlık')
SET IDENTITY_INSERT [dbo].[URUNLER] OFF
ALTER TABLE [dbo].[SATIS] ADD  CONSTRAINT [DF_SATIS_FirmaId]  DEFAULT ((0)) FOR [FirmaId]
GO
ALTER TABLE [dbo].[SATIS] ADD  CONSTRAINT [DF_SATIS_MusteriID]  DEFAULT ((0)) FOR [MusteriID]
GO
ALTER TABLE [dbo].[MALZEME]  WITH CHECK ADD  CONSTRAINT [FK_MALZEME_TurCins] FOREIGN KEY([TurCinsId])
REFERENCES [dbo].[TurCins] ([TurCinsId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[MALZEME] CHECK CONSTRAINT [FK_MALZEME_TurCins]
GO
ALTER TABLE [dbo].[SIPARISLER]  WITH CHECK ADD  CONSTRAINT [FK_SIPARISLER_MALZEME] FOREIGN KEY([MalzemeID])
REFERENCES [dbo].[MALZEME] ([MalzemeID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SIPARISLER] CHECK CONSTRAINT [FK_SIPARISLER_MALZEME]
GO
ALTER TABLE [dbo].[STOK]  WITH CHECK ADD  CONSTRAINT [FK_STOK_URUNLER] FOREIGN KEY([UrunID])
REFERENCES [dbo].[URUNLER] ([UrunID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[STOK] CHECK CONSTRAINT [FK_STOK_URUNLER]
GO
ALTER TABLE [dbo].[TurCins]  WITH CHECK ADD  CONSTRAINT [FK_TurCins_Cins] FOREIGN KEY([CinsId])
REFERENCES [dbo].[Cins] ([CinsId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TurCins] CHECK CONSTRAINT [FK_TurCins_Cins]
GO
ALTER TABLE [dbo].[TurCins]  WITH CHECK ADD  CONSTRAINT [FK_TurCins_TUR] FOREIGN KEY([TurID])
REFERENCES [dbo].[TUR] ([TurID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TurCins] CHECK CONSTRAINT [FK_TurCins_TUR]
GO
