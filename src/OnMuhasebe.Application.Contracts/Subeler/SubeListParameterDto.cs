using OnMuhasebe.CommonDtos;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace OnMuhasebe.Subeler;
public class SubeListParameterDto : PagedResultRequestDto , IDurum , IEntityDto
{
    public bool Durum { get; set; }
}
