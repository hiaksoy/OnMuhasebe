using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnMuhasebe.Migrations
{
    /// <inheritdoc />
    public partial class degisiklik : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Aciklama",
                table: "AppSubeler",
                type: "VarChar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VarChar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Barkod",
                table: "AppStoklar",
                type: "VarChar(128)",
                maxLength: 128,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VarChar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "Aciklama",
                table: "AppStoklar",
                type: "VarChar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VarChar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Aciklama",
                table: "AppOzelKodlar",
                type: "VarChar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VarChar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Barkod",
                table: "AppMasraflar",
                type: "VarChar(128)",
                maxLength: 128,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VarChar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "Aciklama",
                table: "AppMasraflar",
                type: "VarChar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VarChar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Aciklama",
                table: "AppMakbuzlar",
                type: "VarChar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VarChar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "TakipNo",
                table: "AppMakbuzHareketler",
                type: "VarChar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VarChar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Ciranta",
                table: "AppMakbuzHareketler",
                type: "VarChar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VarChar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "CekHesapNo",
                table: "AppMakbuzHareketler",
                type: "VarChar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VarChar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "BelgeNo",
                table: "AppMakbuzHareketler",
                type: "VarChar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VarChar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "AsilBorclu",
                table: "AppMakbuzHareketler",
                type: "VarChar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VarChar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Aciklama",
                table: "AppMakbuzHareketler",
                type: "VarChar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VarChar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Aciklama",
                table: "AppKasalar",
                type: "VarChar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VarChar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Barkod",
                table: "AppHizmetler",
                type: "VarChar(128)",
                maxLength: 128,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VarChar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "Aciklama",
                table: "AppHizmetler",
                type: "VarChar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VarChar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Aciklama",
                table: "AppFaturalar",
                type: "VarChar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VarChar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Aciklama",
                table: "AppFaturaHareketler",
                type: "VarChar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VarChar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Aciklama",
                table: "AppDonemler",
                type: "VarChar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VarChar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Aciklama",
                table: "AppDepolar",
                type: "VarChar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VarChar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "VergiNo",
                table: "AppCariler",
                type: "VarChar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VarChar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "VergiDairesi",
                table: "AppCariler",
                type: "VarChar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VarChar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Telefon",
                table: "AppCariler",
                type: "VarChar(15)",
                maxLength: 15,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VarChar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "Adres",
                table: "AppCariler",
                type: "VarChar(150)",
                maxLength: 150,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VarChar(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "Aciklama",
                table: "AppCariler",
                type: "VarChar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VarChar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Aciklama",
                table: "AppBirimler",
                type: "VarChar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VarChar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Aciklama",
                table: "AppBankaSubeler",
                type: "VarChar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VarChar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Aciklama",
                table: "AppBankalar",
                type: "VarChar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VarChar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "IbanNo",
                table: "AppBankaHesaplar",
                type: "VarChar(26)",
                maxLength: 26,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VarChar(26)",
                oldMaxLength: 26);

            migrationBuilder.AlterColumn<string>(
                name: "Aciklama",
                table: "AppBankaHesaplar",
                type: "VarChar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VarChar(200)",
                oldMaxLength: 200);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Aciklama",
                table: "AppSubeler",
                type: "VarChar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "VarChar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Barkod",
                table: "AppStoklar",
                type: "VarChar(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "VarChar(128)",
                oldMaxLength: 128,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Aciklama",
                table: "AppStoklar",
                type: "VarChar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "VarChar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Aciklama",
                table: "AppOzelKodlar",
                type: "VarChar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "VarChar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Barkod",
                table: "AppMasraflar",
                type: "VarChar(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "VarChar(128)",
                oldMaxLength: 128,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Aciklama",
                table: "AppMasraflar",
                type: "VarChar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "VarChar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Aciklama",
                table: "AppMakbuzlar",
                type: "VarChar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "VarChar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TakipNo",
                table: "AppMakbuzHareketler",
                type: "VarChar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "VarChar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Ciranta",
                table: "AppMakbuzHareketler",
                type: "VarChar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "VarChar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CekHesapNo",
                table: "AppMakbuzHareketler",
                type: "VarChar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "VarChar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BelgeNo",
                table: "AppMakbuzHareketler",
                type: "VarChar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "VarChar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AsilBorclu",
                table: "AppMakbuzHareketler",
                type: "VarChar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "VarChar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Aciklama",
                table: "AppMakbuzHareketler",
                type: "VarChar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "VarChar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Aciklama",
                table: "AppKasalar",
                type: "VarChar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "VarChar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Barkod",
                table: "AppHizmetler",
                type: "VarChar(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "VarChar(128)",
                oldMaxLength: 128,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Aciklama",
                table: "AppHizmetler",
                type: "VarChar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "VarChar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Aciklama",
                table: "AppFaturalar",
                type: "VarChar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "VarChar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Aciklama",
                table: "AppFaturaHareketler",
                type: "VarChar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "VarChar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Aciklama",
                table: "AppDonemler",
                type: "VarChar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "VarChar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Aciklama",
                table: "AppDepolar",
                type: "VarChar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "VarChar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "VergiNo",
                table: "AppCariler",
                type: "VarChar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "VarChar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "VergiDairesi",
                table: "AppCariler",
                type: "VarChar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "VarChar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Telefon",
                table: "AppCariler",
                type: "VarChar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "VarChar(15)",
                oldMaxLength: 15,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Adres",
                table: "AppCariler",
                type: "VarChar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "VarChar(150)",
                oldMaxLength: 150,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Aciklama",
                table: "AppCariler",
                type: "VarChar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "VarChar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Aciklama",
                table: "AppBirimler",
                type: "VarChar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "VarChar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Aciklama",
                table: "AppBankaSubeler",
                type: "VarChar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "VarChar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Aciklama",
                table: "AppBankalar",
                type: "VarChar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "VarChar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IbanNo",
                table: "AppBankaHesaplar",
                type: "VarChar(26)",
                maxLength: 26,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "VarChar(26)",
                oldMaxLength: 26,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Aciklama",
                table: "AppBankaHesaplar",
                type: "VarChar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "VarChar(200)",
                oldMaxLength: 200,
                oldNullable: true);
        }
    }
}
