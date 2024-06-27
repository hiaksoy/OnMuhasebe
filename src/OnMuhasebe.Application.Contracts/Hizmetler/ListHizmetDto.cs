using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace OnMuhasebe.Hizmetler;
public class ListHizmetDto : EntityDto<Guid>
{
    public string? Kod { get; set; }
    public string? Ad { get; set; }
    public int KdvOrani { get; set; }
    public decimal BirimFiyat { get; set; }
    public string? Barkod { get; set; }
    public string? BirimAdi { get; set; }
    public string? OZelKod1Adi { get; set; }
    public string? OZelKod2Adi { get; set; }
    public string? Aciklama { get; set; }
    public decimal Giren { get; set; }
    public decimal Cikan { get; set; }
}
