using Microsoft.EntityFrameworkCore;
using OnMuhasebe.Consts;
using OnMuhasebe.Entities.BankaHesaplar;
using OnMuhasebe.Entities.Bankalar;
using OnMuhasebe.Entities.BankaSubeler;
using OnMuhasebe.Entities.Birimler;
using OnMuhasebe.Entities.Cariler;
using OnMuhasebe.Entities.Depolar;
using OnMuhasebe.Entities.Donemler;
using OnMuhasebe.Entities.Faturalar;
using OnMuhasebe.Entities.Hizmetler;
using OnMuhasebe.Entities.Kasalar;
using OnMuhasebe.Entities.Makbuzlar;
using OnMuhasebe.Entities.Masraflar;
using OnMuhasebe.Entities.OzelKodlar;
using OnMuhasebe.Entities.Parametreler;
using OnMuhasebe.Entities.Stoklar;
using OnMuhasebe.Entities.Subeler;
using System.Data;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.BackgroundJobs.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.FeatureManagement.EntityFrameworkCore;
using Volo.Abp.Identity;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.OpenIddict.EntityFrameworkCore;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;
using Volo.Abp.TenantManagement;
using Volo.Abp.TenantManagement.EntityFrameworkCore;

namespace OnMuhasebe.EntityFrameworkCore;

[ReplaceDbContext(typeof(IIdentityDbContext))]
[ReplaceDbContext(typeof(ITenantManagementDbContext))]
[ConnectionStringName("Default")]
public class OnMuhasebeDbContext :
    AbpDbContext<OnMuhasebeDbContext>,
    IIdentityDbContext,
    ITenantManagementDbContext
{
    /* Add DbSet properties for your Aggregate Roots / Entities here. */

    #region Entities from the modules

    public DbSet<Banka> Bankalar { get; set; }
    public DbSet<BankaSube> BankaSubeler { get; set; }
    public DbSet<BankaHesap> BankaHesaplar { get; set; }
    public DbSet<Birim> Birimler { get; set; }
    public DbSet<Cari> Cariler { get; set; }
    public DbSet<Depo> Depolar { get; set; }
    public DbSet<Donem> Donemler { get; set; }
    public DbSet<FirmaParametre> FirmaParametreler { get; set; }
    public DbSet<Fatura> Faturalar { get; set; }
    public DbSet<Hizmet> Hizmetler { get; set; }
    public DbSet<Kasa> Kasalar { get; set; }
    public DbSet<Makbuz> Makbuzlar { get; set; }
    public DbSet<Masraf> Masraflar { get; set; }
    public DbSet<OzelKod> OzelKodlar { get; set; }
    public DbSet<Stok> Stoklar { get; set; }
    public DbSet<Sube> Subeler { get; set; }



    //Identity
    public DbSet<IdentityUser> Users { get; set; }
    public DbSet<IdentityRole> Roles { get; set; }
    public DbSet<IdentityClaimType> ClaimTypes { get; set; }
    public DbSet<OrganizationUnit> OrganizationUnits { get; set; }
    public DbSet<IdentitySecurityLog> SecurityLogs { get; set; }
    public DbSet<IdentityLinkUser> LinkUsers { get; set; }
    public DbSet<IdentityUserDelegation> UserDelegations { get; set; }

    // Tenant Management
    public DbSet<Tenant> Tenants { get; set; }
    public DbSet<TenantConnectionString> TenantConnectionStrings { get; set; }

    #endregion

    public OnMuhasebeDbContext(DbContextOptions<OnMuhasebeDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        /* Include modules to your migration db context */

        builder.ConfigurePermissionManagement();
        builder.ConfigureSettingManagement();
        builder.ConfigureBackgroundJobs();
        builder.ConfigureAuditLogging();
        builder.ConfigureIdentity();
        builder.ConfigureOpenIddict();
        builder.ConfigureFeatureManagement();
        builder.ConfigureTenantManagement();

        /* Configure your own tables/entities inside here */

        builder.Entity<Banka>(b =>
        {
            b.ToTable(OnMuhasebeConsts.DbTablePrefix + "Bankalar", OnMuhasebeConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props
            //properties
            b.Property(x => x.Kod)
            .IsRequired()
            .HasColumnType(SqlDbType.VarChar.ToString())
            .HasMaxLength(EntityConsts.MaxKodLength);
            b.Property(x => x.Ad)
            .IsRequired()
            .HasColumnType(SqlDbType.VarChar.ToString())
            .HasMaxLength(EntityConsts.MaxAdLength);
            b.Property(x => x.OzelKod1Id)
            .HasColumnType(SqlDbType.UniqueIdentifier.ToString());
            b.Property(x => x.OzelKod2Id)
            .HasColumnType(SqlDbType.UniqueIdentifier.ToString());
            b.Property(x => x.Aciklama)
            .HasColumnType(SqlDbType.VarChar.ToString())
            .HasMaxLength(EntityConsts.MaxAciklamaLength);
            b.Property(x => x.Durum)
            .HasColumnType(SqlDbType.Bit.ToString());
            //indexes
            b.HasIndex(x => x.Kod);
            //relations
            b.HasOne(x => x.OzelKod1)
            .WithMany(y => y.OzelKod1Bankalar)
            .OnDelete(DeleteBehavior.NoAction);
            b.HasOne(x => x.OzelKod2)
            .WithMany(y => y.OzelKod2Bankalar)
            .OnDelete(DeleteBehavior.NoAction);
        });
    }
}
