using OnMuhasebe.CommonDtos;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace OnMuhasebe.Stoklar;
public class StokListParameterDto : PagedResultRequestDto , IEntityDto, IDurum
{
    public bool Durum { get; set; }
}
