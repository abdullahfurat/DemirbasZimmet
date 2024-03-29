USE [Demirbas]
GO
/****** Object:  StoredProcedure [dbo].[BolumDuzenle]    Script Date: 20.05.2020 12:03:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BolumDuzenle]
@BolumKodu varchar(20),
@BolumAdi varchar(50),
@Telefon varchar(11),
@Faks varchar(11),
@AdresKodu int
AS
BEGIN TRY
	BEGIN TRANSACTION;
	SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;

	--Düzenlenmek istenen malzeme adının sistemde önceden olup olmadığı kontrolü yapılmıştır.
	IF(EXISTS(SELECT TOP 1 * FROM Bölüm WHERE BölümAdı = @BolumAdi))
		THROW 50001, 'Bu Bölüm Adıyla Sisteme Kayıtlı Bir Bölüm Bulunmamaktadır.',1;

	UPDATE Bölüm SET  BölümAdı=@BolumAdi, BölümKodu=@BolumKodu, Telefon=@Telefon, Faks=@Faks, AdresKodu=@AdresKodu WHERE BölümKodu=@BolumKodu;

	COMMIT TRANSACTION;
	SELECT 0 AS Sonuc, 'İşlem tamam' AS Mesaj;
END TRY
BEGIN CATCH
	IF(@@TRANCOUNT>0)
		ROLLBACK TRANSACTION;
	SELECT 1 AS Sonuc,ERROR_MESSAGE() as Mesaj;
END CATCH;
GO
/****** Object:  StoredProcedure [dbo].[BolumOlustur]    Script Date: 20.05.2020 12:03:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BolumOlustur]
@BolumKodu varchar(20),
@BolumAdi varchar(50),
@Telefon varchar(11),
@Faks varchar(11),
@AdresKodu int
AS
BEGIN TRY
	BEGIN TRANSACTION;
	SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;

	--Bölüm kodunun sistemden kontrolu yapılmıştır.
	IF(EXISTS(SELECT TOP 1 * FROM Bölüm WHERE BölümKodu=@BolumKodu))
		THROW 50001, 'Bu Bölüm Koduyla Sisteme Kayıtlı Bir Bölüm Bulunmamaktadır.',1;

	INSERT INTO Bölüm VALUES(@BolumKodu,@BolumAdi,@Telefon,@Faks,@AdresKodu);

	COMMIT TRANSACTION;
	SELECT 0 AS Sonuc, 'İşlem tamam' AS Mesaj;
END TRY
BEGIN CATCH
	IF(@@TRANCOUNT>0)
		ROLLBACK TRANSACTION;
	SELECT 1 AS Sonuc,ERROR_MESSAGE() as Mesaj;
END CATCH;
GO
/****** Object:  StoredProcedure [dbo].[BolumSil]    Script Date: 20.05.2020 12:03:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BolumSil]
@BolumKodu varchar(20),
@BolumAdi varchar(50),
@Telefon varchar(11),
@Faks varchar(11),
@AdresKodu int
AS
BEGIN TRY
	BEGIN TRANSACTION;
	SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;

	--Silinmek istenen bölüm koduyla sisteme kayıtlı personel varsa silme işlemi engellenmiştir.
	IF(EXISTS(SELECT TOP 1 * FROM Personel WHERE BölümKodu=@BolumKodu))
		THROW 50001, 'Bu Bölüm Koduyla Sisteme Kayıtlı Personel Bulunduğu İçin Silme İşlemi Yapılamaz.',1;

	DELETE FROM Bölüm WHERE BölümKodu=@BolumKodu;

	COMMIT TRANSACTION;
	SELECT 0 AS Sonuc, 'İşlem tamam' AS Mesaj;
END TRY
BEGIN CATCH
	IF(@@TRANCOUNT>0)
		ROLLBACK TRANSACTION;
	SELECT 1 AS Sonuc,ERROR_MESSAGE() as Mesaj;
END CATCH;

GO
/****** Object:  StoredProcedure [dbo].[DemirbasDuzenle]    Script Date: 20.05.2020 12:03:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DemirbasDuzenle]
@DemirbasKodu varchar(20),
@DemirbasAdi varchar(50),
@MalzemeKodu varchar(20),
@BolumKodu varchar(20)
AS
BEGIN TRY
	BEGIN TRANSACTION;
	SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;

	--Bu demirbaskoduna sahip demirbas kontrolü
	IF(NOT EXISTS(SELECT TOP 1 * FROM Demirbaş WHERE DemirbaşKodu = @DemirbasKodu))
		THROW 50001, 'Demirbaş kodunda değişiklik yapılamaz.',1;

	UPDATE Demirbaş SET DemirbaşKodu=@DemirbasKodu, DemirbaşAdı=@DemirbasAdi, MalzemeKodu=@MalzemeKodu,BölümKodu=@BolumKodu WHERE DemirbaşKodu=@DemirbasKodu;

	COMMIT TRANSACTION;
	SELECT 0 AS Sonuc, 'İşlem tamam' AS Mesaj;
END TRY
BEGIN CATCH
	IF(@@TRANCOUNT>0)
		ROLLBACK TRANSACTION;
	SELECT 1 AS Sonuc,ERROR_MESSAGE() as Mesaj;
END CATCH;
GO
/****** Object:  StoredProcedure [dbo].[DemirbasOlustur]    Script Date: 20.05.2020 12:03:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DemirbasOlustur]
@DemirbasKodu varchar(20),
@DemirbasAdi varchar(50),
@MalzemeKodu varchar(20),
@BolumKodu varchar(20)
AS
BEGIN TRY
	BEGIN TRANSACTION;
	SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;

	--Bu demirbaskoduna sahip demirbas kontrolü
	IF(EXISTS(SELECT TOP 1 * FROM Demirbaş WHERE DemirbaşKodu=@DemirbasKodu))
		THROW 50001, 'Bu demir baskoduyla Sisteme Kayıtlı Bir Demirbas Bulunmaktadır.',1;

	INSERT INTO Demirbaş VALUES(@DemirbasKodu,@DemirbasAdi,1,@MalzemeKodu,@BolumKodu);

	COMMIT TRANSACTION;
	SELECT 0 AS Sonuc, 'İşlem tamam' AS Mesaj;
END TRY
BEGIN CATCH
	IF(@@TRANCOUNT>0)
		ROLLBACK TRANSACTION;
	SELECT 1 AS Sonuc,ERROR_MESSAGE() as Mesaj;
END CATCH;
GO
/****** Object:  StoredProcedure [dbo].[DemirbasSil]    Script Date: 20.05.2020 12:03:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DemirbasSil]
@DemirbasKodu varchar(20),
@DemirbasAdi varchar(50),
@MalzemeKodu varchar(20),
@BolumKodu varchar(20)
AS
BEGIN TRY
	BEGIN TRANSACTION;
	SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;

	--Demirbaşın zimmetli olup olmadığı kontrolü
	IF(EXISTS(SELECT TOP 1 * FROM Demirbaş WHERE DemirbaşKodu=@DemirbasKodu AND DemirbaşDurumu=0))
		THROW 50001, 'Bu Demirbas Koduyla Sisteme Kayıtlı Bir Zimmetleme Bulunmamaktadır.',1;

	DELETE FROM Demirbaş WHERE DemirbaşKodu =@DemirbasKodu;

	COMMIT TRANSACTION;
	SELECT 0 AS Sonuc, 'İşlem tamam' AS Mesaj;
END TRY
BEGIN CATCH
	IF(@@TRANCOUNT>0)
		ROLLBACK TRANSACTION;
	SELECT 1 AS Sonuc,ERROR_MESSAGE() as Mesaj;
END CATCH;
GO
/****** Object:  StoredProcedure [dbo].[DemirbasZimmetDuzenle]    Script Date: 20.05.2020 12:03:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DemirbasZimmetDuzenle]
@SicilNo int,
@DemirbasKodu varchar(20),
@BaslangicTarihi date,
@BitisTarihi date
AS
BEGIN TRY
	BEGIN TRANSACTION;
	SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;
	IF((@BitisTarihi)<GETDATE())
		THROW 50001, 'Geçmiş tarihlere zimmet düzenleme işlemi yapılamaz.', 1;

	UPDATE DemirbasZimmetleme SET SicilNo=@SicilNo, BaşlangıcTarihi=@BaslangicTarihi,BitisTarihi=@BitisTarihi WHERE  DemirbasKodu=@DemirbasKodu and SicilNo=@SicilNo;

	COMMIT TRANSACTION;
	SELECT 0 AS Sonuc, 'İşlem tamam' AS Mesaj;
END TRY
BEGIN CATCH
	IF(@@TRANCOUNT>0)
		ROLLBACK TRANSACTION;
	SELECT 1 AS Sonuc,ERROR_MESSAGE() as Mesaj;
END CATCH;
GO
/****** Object:  StoredProcedure [dbo].[DemirbasZimmetIptal]    Script Date: 20.05.2020 12:03:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DemirbasZimmetIptal]
@SicilNo int,
@DemirbasKodu varchar(20)
AS
BEGIN TRY
	BEGIN TRANSACTION;
	SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;

	UPDATE Demirbaş SET DemirbaşDurumu=1 WHERE DemirbaşKodu=(SELECT RIGHT('000'+ISNULL(@DemirbasKodu,''),7));

	DELETE FROM DemirbasZimmetleme WHERE DemirbasKodu=@DemirbasKodu and SicilNo=@SicilNo;

	COMMIT TRANSACTION;
	SELECT 0 AS Sonuc, 'İşlem tamam' AS Mesaj;
END TRY
BEGIN CATCH
	IF(@@TRANCOUNT>0)
		ROLLBACK TRANSACTION;
	SELECT 1 AS Sonuc,ERROR_MESSAGE() as Mesaj;
END CATCH;
GO
/****** Object:  StoredProcedure [dbo].[DemirbasZimmetOlustur]    Script Date: 20.05.2020 12:03:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DemirbasZimmetOlustur]
@SicilNo int,
@DemirbasKodu varchar(20),
@BaslangicTarihi date,
@BitisTarihi date
AS
BEGIN TRY
	BEGIN TRANSACTION;
	SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;

	--Sicil numarasının sistemden kontrolu yapılmıştır.
	IF(NOT EXISTS(SELECT TOP 1 * FROM Personel WHERE SicilNumarası=@SicilNo))
		THROW 50001, 'Bu Sicil Numarasıyla Sisteme Kayıtlı Biri Bulunmamaktadır.',1;

	--demirbaş kodunun sistemden kontrolu yapılmıştır.
	IF(NOT EXISTS(SELECT TOP 1 * FROM Demirbaş WHERE DemirbaşKodu=(SELECT RIGHT('000'+ISNULL(@DemirbasKodu,''),7))))
		THROW 50001, 'Bu demirbaş Kodu ile Sisteme Kayıtlı Bir Demirbaş Bulunmamaktadır.',1;
	
	--Geçmiş günlere yapılmaya çalışılan zimmet işlemleri engellenmiştir.
	IF((@BaslangicTarihi)<GETDATE()-1)
		THROW 50001, 'Geçmiş tarihlere zimmet işlemi yapılamaz.', 1;
	UPDATE Demirbaş SET DemirbaşDurumu=0 WHERE DemirbaşKodu=(SELECT RIGHT('000'+ISNULL(@DemirbasKodu,''),7));

	INSERT INTO DemirbasZimmetleme (SicilNo,DemirbasKodu,BaşlangıcTarihi,BitisTarihi) VALUES(@SicilNo,@DemirbasKodu,@BaslangicTarihi,@BitisTarihi);

	COMMIT TRANSACTION;
	SELECT 0 AS Sonuc, 'İşlem tamam' AS Mesaj;
END TRY
BEGIN CATCH
	IF(@@TRANCOUNT>0)
		ROLLBACK TRANSACTION;
	SELECT 1 AS Sonuc,ERROR_MESSAGE() as Mesaj;
END CATCH;
GO
/****** Object:  StoredProcedure [dbo].[MalzemeDuzenle]    Script Date: 20.05.2020 12:03:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MalzemeDuzenle]
@MalzemeKodu varchar(20),
@MalzemeAdi varchar(50),
@MalzemeTuru varchar(50),
@Adet int
AS
BEGIN TRY
	BEGIN TRANSACTION;
	SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;

	--Düzenlenmek istenen malzeme adının sistemde önceden olup olmadığı kontrolü yapılmıştır.
	IF(EXISTS(SELECT TOP 1 * FROM Malzeme WHERE MalzemeAdı = @MalzemeAdi) and EXISTS(SELECT TOP 1 * FROM Malzeme WHERE MalzemeTürü = @MalzemeTuru))
		THROW 50001, 'Bu Malzeme Adı ve Türüyle Sisteme Kayıtlı Bir Malzeme Bulunmamaktadır.',1;


	--Adet 0 olarak girilemez.
	IF(@Adet<1)
		THROW 50001, 'Eklenmek istenen malzemede en az bir demirbaş bulunmalıdır.',1;

	UPDATE Malzeme SET  MalzemeAdı=@MalzemeAdi, MalzemeTürü=@MalzemeTuru, Adet=@Adet WHERE MalzemeKodu=@MalzemeKodu;

	COMMIT TRANSACTION;
	SELECT 0 AS Sonuc, 'İşlem tamam' AS Mesaj;
END TRY
BEGIN CATCH
	IF(@@TRANCOUNT>0)
		ROLLBACK TRANSACTION;
	SELECT 1 AS Sonuc,ERROR_MESSAGE() as Mesaj;
END CATCH;
GO
/****** Object:  StoredProcedure [dbo].[MalzemeOlustur]    Script Date: 20.05.2020 12:03:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MalzemeOlustur]
@MalzemeKodu varchar(20),
@MalzemeAdi varchar(50),
@MalzemeTuru varchar(50),
@Adet int
AS
BEGIN TRY
	BEGIN TRANSACTION;
	SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;

	--Eklenmek istenen malzeme kodunun sistemde önceden olup olmadığı kontrolü yapılmıştır.
	IF(EXISTS(SELECT TOP 1 * FROM Malzeme WHERE MalzemeKodu=@MalzemeKodu))
		THROW 50001, 'Bu Malzeme Koduyla Sisteme Kayıtlı Bir Malzeme Bulunmamaktadır.',1;

	INSERT INTO Malzeme VALUES(@MalzemeKodu,@MalzemeAdi,@MalzemeTuru,@Adet);

	COMMIT TRANSACTION;
	SELECT 0 AS Sonuc, 'İşlem tamam' AS Mesaj;
END TRY
BEGIN CATCH
	IF(@@TRANCOUNT>0)
		ROLLBACK TRANSACTION;
	SELECT 1 AS Sonuc,ERROR_MESSAGE() as Mesaj;
END CATCH;
GO
/****** Object:  StoredProcedure [dbo].[MalzemeSil]    Script Date: 20.05.2020 12:03:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MalzemeSil]
@MalzemeKodu varchar(20),
@MalzemeAdi varchar(50),
@MalzemeTuru varchar(50),
@Adet int
AS
BEGIN TRY
	BEGIN TRANSACTION;
	SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;

	--Silinmek istenen malzeme koduyla sisteme kayıtlı demirbaş varsa silme işlemi engellenmiştir.
	IF(EXISTS(SELECT TOP 1 * FROM Demirbaş WHERE MalzemeKodu=@MalzemeKodu))
		THROW 50001, 'Bu Malzeme Koduyla Sisteme Kayıtlı Demirbaşlar Bulunduğu İçin Silme İşlemi Yapılamaz.',1;

	DELETE FROM Malzeme WHERE MalzemeKodu=@MalzemeKodu;

	COMMIT TRANSACTION;
	SELECT 0 AS Sonuc, 'İşlem tamam' AS Mesaj;
END TRY
BEGIN CATCH
	IF(@@TRANCOUNT>0)
		ROLLBACK TRANSACTION;
	SELECT 1 AS Sonuc,ERROR_MESSAGE() as Mesaj;
END CATCH;
GO
/****** Object:  StoredProcedure [dbo].[PersonelDuzenle]    Script Date: 20.05.2020 12:03:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PersonelDuzenle]
@SicilNumarasi int,
@PersonelAdi varchar(20),
@PersonelSoyadi varchar(20),
@Unvan varchar(20),
@BolumKodu varchar(20),
@AdresKodu int
AS
BEGIN TRY
	BEGIN TRANSACTION;
	SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;

	--Bu sicil numarasına sahip personel kontrolü
	IF(EXISTS(SELECT TOP 1 * FROM Personel WHERE SicilNumarası=@SicilNumarasi AND PersonelAdı !=@PersonelAdi AND PersonelSoyadı !=@PersonelSoyadi))
		THROW 50001, 'Bu Sicil Numarasıyla Sisteme Kayıtlı Bir Personel Bulunmamaktadır.',1;

	UPDATE Personel SET SicilNumarası=@SicilNumarasi,PersonelAdı=@PersonelAdi,PersonelSoyadı=@PersonelSoyadi,Unvan=@Unvan,BölümKodu=@BolumKodu,AdresKodu=@AdresKodu WHERE SicilNumarası=@SicilNumarasi

	COMMIT TRANSACTION;
	SELECT 0 AS Sonuc, 'İşlem tamam' AS Mesaj;
END TRY
BEGIN CATCH
	IF(@@TRANCOUNT>0)
		ROLLBACK TRANSACTION;
	SELECT 1 AS Sonuc,ERROR_MESSAGE() as Mesaj;
END CATCH;
GO
/****** Object:  StoredProcedure [dbo].[PersonelOlustur]    Script Date: 20.05.2020 12:03:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PersonelOlustur]
@SicilNumarasi int,
@PersonelAdi varchar(20),
@PersonelSoyadi varchar(20),
@Unvan varchar(20),
@BolumKodu varchar(20),
@AdresKodu int
AS
BEGIN TRY
	BEGIN TRANSACTION;
	SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;

	--Bu sicil numarasına sahip personel kontrolü
	IF(EXISTS(SELECT TOP 1 * FROM Personel WHERE SicilNumarası=@SicilNumarasi))
		THROW 50001, 'Bu Sicil Numarasıyla Sisteme Kayıtlı Bir Personel Bulunmaktadır.',1;

	INSERT INTO Personel VALUES(@SicilNumarasi,@PersonelAdi,@PersonelSoyadi,@Unvan,@BolumKodu,@AdresKodu);

	COMMIT TRANSACTION;
	SELECT 0 AS Sonuc, 'İşlem tamam' AS Mesaj;
END TRY
BEGIN CATCH
	IF(@@TRANCOUNT>0)
		ROLLBACK TRANSACTION;
	SELECT 1 AS Sonuc,ERROR_MESSAGE() as Mesaj;
END CATCH;
GO
/****** Object:  StoredProcedure [dbo].[PersonelSil]    Script Date: 20.05.2020 12:03:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PersonelSil]
@SicilNumarasi int,
@PersonelAdi varchar(20),
@PersonelSoyadi varchar(20),
@Unvan varchar(20),
@BolumKodu varchar(20),
@AdresKodu int
AS
BEGIN TRY
	BEGIN TRANSACTION;
	SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;

	--Bu sicil numarasına sahip personele ait bir demirbaş zimmetleme işlemi kontrolü
	IF(EXISTS(SELECT TOP 1 * FROM DemirbasZimmetleme WHERE SicilNo=@SicilNumarasi))
		THROW 50001, 'Bu Sicil Numarasıyla Sisteme Kayıtlı Bir Zimmetleme İşlemi Bulunmamaktadır.',1;

	DELETE FROM Personel WHERE SicilNumarası=@SicilNumarasi;

	COMMIT TRANSACTION;
	SELECT 0 AS Sonuc, 'İşlem tamam' AS Mesaj;
END TRY
BEGIN CATCH
	IF(@@TRANCOUNT>0)
		ROLLBACK TRANSACTION;
	SELECT 1 AS Sonuc,ERROR_MESSAGE() as Mesaj;
END CATCH;
GO
