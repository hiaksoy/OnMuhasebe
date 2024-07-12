using OnMuhasebe.CommonDtos;
using OnMuhasebe.Faturalar;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace OnMuhasebe.Stoklar;
public class StokHareketListParameterDto : PagedResultRequestDto, IEntityDto, IDurum
{
    public FaturaHareketTuru? HareketTuru { get; set; }
    public Guid EntityId { get; set; }
    public Guid SubeId { get; set; }
    public Guid DonemId { get; set; }
    public bool Durum { get; set; }

}
