﻿using OnMuhasebe.CommonDtos;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace OnMuhasebe.Cariler;
public class SelectCariDto : EntityDto<Guid>, IOzelKod
{
    public string? Kod { get; set; }
    public string? Ad { get; set; }
    public string? VergiDairesi { get; set; }
    public string? VergiNo { get; set; }
    public string? Telefon { get; set; }
    public string? Adres { get; set; }
    public string? OzelKod1Adi { get; set; }
    public string? OzelKod2Adi { get; set; }
    public Guid? OzelKod1Id { get; set; }
    public Guid? OzelKod2Id { get; set; }
    public string? Aciklama { get; set; }
    public bool Durum { get; set; }
}
