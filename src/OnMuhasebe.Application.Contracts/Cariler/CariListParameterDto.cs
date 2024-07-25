using Volo.Abp.Application.Dtos;

namespace OnMuhasebe.Cariler;
public class CariListParameterDto : PagedResultRequestDto, IEntityDto, IDurum
{
    public bool Durum { get; set; }
}

