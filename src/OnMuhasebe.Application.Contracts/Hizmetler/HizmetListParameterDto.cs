using Volo.Abp.Application.Dtos;

namespace OnMuhasebe.Hizmetler;
public class HizmetListParameterDto : PagedResultRequestDto, IEntityDto, IDurum
{
    public bool Durum { get; set; }
}
