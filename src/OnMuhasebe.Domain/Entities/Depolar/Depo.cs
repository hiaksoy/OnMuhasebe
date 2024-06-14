namespace OnMuhasebe.Entities.Depolar;
public class Depo: FullAuditedAggregateRoot<Guid>
{
    public string Kod { get; set; }
    public string Ad { get; set; }
    public Guid? OzelKod1Id { get; set; }
    public Guid? OzelKod2Id { get; set; }
    public Guid SubeId { get; set; }
    public string Aciklama { get; set; }
    public bool Durum { get; set; }

    #region Navigation Properties
    public OzelKod OzelKod1 { get; set; }
    public OzelKod OzelKod2 { get; set; }
    public Sube Sube { get; set; }
    public ICollection<FirmaParametre> FirmaParemetreler { get; set; }
    public ICollection<FaturaHareket> FaturaHareketler { get; set; }
    #endregion
}
