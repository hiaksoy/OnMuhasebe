using OnMuhasebe.CommonDtos;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace OnMuhasebe.BankaHesaplar;
public class BankaHesapListParameterDto : PagedResultRequestDto , IEntityDto , IDurum
{
    public BankaHesapTuru? HesapTuru { get; set; }
    public Guid SubeId { get; set; }
    public bool Durum { get; set; }

}
