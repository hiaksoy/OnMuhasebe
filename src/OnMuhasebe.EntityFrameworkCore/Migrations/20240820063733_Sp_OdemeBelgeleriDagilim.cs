﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnMuhasebe.Migrations
{
    /// <inheritdoc />
    public partial class Sp_OdemeBelgeleriDagilim : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sqlProc = @"CREATE OR ALTER PROCEDURE [dbo].[OdemeBelgeleriDagilim]
                    @SubeId uniqueidentifier,
                    @DonemId uniqueidentifier
                AS
                BEGIN

                DECLARE
                        @Giren MONEY, 
                        @Cikan MONEY
                SET NOCOUNT ON;

                SELECT @Giren = COALESCE(SUM(Tutar),0) FROM AppMakbuzHareketler mbh LEFT JOIN
                                AppMakbuzlar mb ON mbh.MakbuzId=mb.Id 
                WHERE mbh.KasaId IS NOT NULL AND (mb.MakbuzTuru=1 OR (mb.MakbuzTuru=3 AND mbh.KendiBelgemiz=0)) AND
                      mb.SubeId = CONVERT(varchar(MAX), @SubeId) AND 
                      mb.DonemId = CONVERT (varchar(MAX), @DonemId) AND
                      mbh.IsDeleted=0
                SELECT @Cikan = COALESCE (SUM(Tutar),0) FROM AppMakbuzHareketler mbh LEFT JOIN 
                                AppMakbuzlar mb ON mbh.MakbuzId=mb.Id
                WHERE mbh.KasaId IS NOT NULL AND (mb.MakbuzTuru=2 OR (mb.MakbuzTuru=3 AND mbh.KendiBelgemiz=1)) AND
                      mb.SubeId = CONVERT(varchar(MAX), @SubeId) AND 
                      mb.DonemId = CONVERT (varchar(MAX), @DonemId) AND
                      mbh.IsDeleted=0

                Select @Giren As Giren, @Cikan As Cikan, @Giren-@Cikan As Bakiye
            END";

            migrationBuilder.Sql(sqlProc);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP PROC OdemeBelgeleriDagilim");
        }
    }
}
