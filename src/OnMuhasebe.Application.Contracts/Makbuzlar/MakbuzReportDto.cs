﻿using OnMuhasebe.MakbuzHareketler;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace OnMuhasebe.Makbuzlar;
public class MakbuzReportDto : IEntityDto
{
    public string? MakbuzNo { get; set; }
    public DateTime Tarih { get; set; }
    public string? CariKodu { get; set; }
    public string? CariAdi { get; set; }
    public string? KasaAdi { get; set; }
    public string? BankaHesapAdi { get; set; }
    public decimal CekToplam { get; set; }
    public decimal NakitToplam { get; set; }
    public decimal SenetToplam { get; set; }
    public decimal PosToplam { get; set; }
    public decimal BankaToplam { get; set; }
    public decimal GenelToplam => CekToplam + NakitToplam + SenetToplam + PosToplam + BankaToplam;
    public string? SubeAdi { get; set; }
    public string? Aciklama { get; set; }
    public List<MakbuzHareketReportDto>? MakbuzHareketler { get; set; }
}
