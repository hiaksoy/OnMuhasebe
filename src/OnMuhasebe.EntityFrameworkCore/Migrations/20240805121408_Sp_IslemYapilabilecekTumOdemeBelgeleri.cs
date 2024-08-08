using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnMuhasebe.Migrations
{
    /// <inheritdoc />
    public partial class Sp_IslemYapilabilecekTumOdemeBelgeleri : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sqlProc = @"CREATE OR ALTER PROCEDURE [dbo].[OdemeBelgeleri]
                                @SubeId uniqueidentifier,
                                @DonemId uniqueidentifier,
                                @OdemeTurleri Varchar(100)
                            AS
                            BEGIN
                                SET NOCOUNT ON
                                DECLARE @SQL VARCHAR(MAX)

                                SET @SQL = 'SELECT      MAX(dbo.AppMakbuzHareketler.Id) AS Id, MAX(dbo.AppMakbuzHareketler.MakbuzId) AS MakbuzId, MAX(dbo.AppMakbuzHareketler.BankaHesapId) AS BankaHesapId, MAX(dbo.AppBankaHesaplar.Ad) AS BankaHesapAdi,
                                                            dbo.AppMakbuzHareketler.CekBankaId, dbo.AppBankalar.Ad AS CekBankaAdi, dbo.AppMakbuzHareketler.CekBankaSubeId, dbo.AppBankaSubeler.Ad AS CekBankaSubeAdi, dbo.AppMakbuzHareketler.Aciklama, dbo. AppMakbuz Hareketler.AsilBorclu,
                                                        MAX(dbo.AppMakbuzHareketler.Belge Durumu) AS BelgeDurumu, dbo.AppMakbuzHareketler.BelgeNo, dbo.AppMakbuzHareketler.CekHesapNo, dbo.AppMakbuzHareketler.Ciranta, dbo.AppMakbuzHareketler.OdemeTuru,
                                                            dbo.AppMakbuzHareketler.Tutar, dbo.AppMakbuzHareketler.Vade, dbo.AppMakbuzlar.DonemId, dbo.AppMakbuzlar.SubeId, MAX(dbo.AppMakbuzHareketler.TakipNo) AS TakipNo, dbo.AppMakbuzHareketler.IsDeleted
                                            FROM            dbo.AppMakbuzHareketler LEFT OUTER JOIN
                                                            dbo.AppMakbuzlar ON dbo.AppMakbuzHareketler.MakbuzId = dbo.AppMakbuzlar.Id LEFT OUTER JOIN
                                                            dbo.AppBankalar ON dbo.AppMakbuzHareketler.CekBankaId = dbo.AppBankalar.Id LEFT OUTER JOIN
                                                            dbo.AppBankaSubeler ON dbo.AppMakbuzHareketler.CekBankaSubeId = dbo.AppBankaSubeler.Id LEFT OUTER JOIN
                                                            dbo.AppBankaHesaplar ON dbo.AppMakbuzHareketler.BankaHesapId = dbo.AppBankaHesaplar.Id
                                            GROUP BY        dbo.AppMakbuzHareketler.CekBankaId, dbo.AppMakbuzHareketler.CekBankaSubeId, dbo.AppMakbuzHareketler.Aciklama, dbo.AppMakbuzHareketler.AsilBorclu, dbo.AppMakbuzHareketler.CekHesapNo, dbo.AppMakbuzHareketler.Ciranta,
                                                            dbo.AppMakbuzHareketler.Tutar, dbo.AppMakbuzHareketler.Vade, dbo.AppMakbuzHareketler.BelgeNo, dbo.AppBankalar.Ad, dbo.AppBankaSubeler.Ad,
                                                            dbo.AppMakbuzlar.DonemId, dbo.AppMakbuzlar.SubeId, dbo.AppMakbuzHareketler.OdemeTuru, dbo.AppMakbuzHareketler.IsDeleted
                                            HAVING          dbo.AppMakbuzlar.SubeId = '''+CONVERT(varchar(MAX), @SubeId)+''' AND
                                                            dbo.AppMakbuzlar.DonemId = '''+CONVERT(varchar(MAX), @DonemId)+''' AND
                                                            dbo.AppMakbuzlar.OdemeTuru IN('+ @OdemeTurleri+') AND
                                                            dbo.AppMakbuzHareketler.IsDeleted = 0
                                            ORDER BY        dbo.AppMakbuzHareketler.Vade'
                                END

                                EXEC(@SQL);";

            migrationBuilder.Sql(sqlProc);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            var sqlProc = "DROP PROC OdemeBelgeleri";
            migrationBuilder.Sql(sqlProc);
        }
    }
}
