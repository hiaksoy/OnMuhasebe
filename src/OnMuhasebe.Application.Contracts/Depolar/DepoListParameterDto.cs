using Volo.Abp.Application.Dtos;

namespace OnMuhasebe.Depolar;
public class DepoListParameterDto : PagedResultRequestDto, IEntityDto, IDurum
{
    public Guid SubeId { get; set; }
    public bool Durum { get; set; }
}
