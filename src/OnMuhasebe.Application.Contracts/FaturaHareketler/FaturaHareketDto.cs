﻿using OnMuhasebe.Faturalar;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace OnMuhasebe.FaturaHareketler;
public class FaturaHareketDto : EntityDto<Guid?>
{
    public FaturaHareketTuru? HareketTuru { get; set; }
    public Guid? StokId { get; set; }
    public Guid? MasrafId { get; set; }
    public Guid? HizmetId { get; set; }
    public Guid? DepoId { get; set; }
    public decimal Miktar { get; set; }
    public decimal BirimFiyat { get; set; }
    public decimal BrutTutar { get; set; }
    public decimal IndirimTutar { get; set; }
    public int KdvOrani { get; set; }
    public decimal KdvHaricTutar { get; set; }
    public decimal KdvTutar { get; set; }
    public decimal NetTutar { get; set; }
    public string? Aciklama { get; set; }
}
