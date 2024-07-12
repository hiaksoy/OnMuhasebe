using OnMuhasebe.CommonDtos;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace OnMuhasebe.Makbuzlar;
public class MakbuzListParameterDto : PagedResultRequestDto, IEntityDto, IDurum
{
    public MakbuzTuru MakbuzTuru { get; set; }
    public Guid SubeId { get; set; }
    public Guid DonemId { get; set; }
    public bool Durum { get; set; }
}
