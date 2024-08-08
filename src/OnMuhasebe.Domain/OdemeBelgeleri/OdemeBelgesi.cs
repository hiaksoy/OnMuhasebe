﻿using OnMuhasebe.Makbuzlar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnMuhasebe.Entities.OdemeBelgeleri;
public class OdemeBelgesi : Entity<Guid>
{
    public Guid MakbuzId { get; set; }
    public OdemeTuru OdemeTuru { get; set; }
    public string? TakipNo { get; set; }
    public Guid? CekBankaId { get; set; }
    public string? CekBankaAdi { get; set; }
    public Guid? CekBankaSubeId { get; set; }
    public string? CekBankaSubeAdi { get; set; }
    public string? CekHesapNo { get; set; }
    public string? BelgeNo { get; set; }
    public DateTime Vade { get; set; }
    public string? AsilBorclu { get; set; }
    public string? Ciranta { get; set; }
    public Guid? BankaHesapId { get; set; }
    public string? BankaHesapAdi { get; set; }
    public decimal Tutar { get; set; }
    public BelgeDurumu BelgeDurumu { get; set; }
    public bool? KendiBelgemiz { get; set; }
    public string? Aciklama { get; set; }
}
