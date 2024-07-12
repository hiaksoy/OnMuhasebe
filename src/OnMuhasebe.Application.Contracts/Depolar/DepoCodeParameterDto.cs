using OnMuhasebe.CommonDtos;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace OnMuhasebe.Depolar;
public class DepoCodeParameterDto : IDurum , IEntityDto
{
    public Guid SubeId { get; set; }
    public bool Durum { get; set; }
}
