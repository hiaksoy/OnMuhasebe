using Volo.Abp.Application.Dtos;

namespace OnMuhasebe.Donemler;
public class DonemListParameterDto : PagedResultRequestDto, IEntityDto, IDurum
{
    public bool Durum { get; set; }
}


