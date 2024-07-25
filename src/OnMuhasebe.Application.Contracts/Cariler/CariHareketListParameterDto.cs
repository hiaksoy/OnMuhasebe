using Volo.Abp.Application.Dtos;

namespace OnMuhasebe.Cariler;
public class CariHareketListParameterDto : PagedResultRequestDto, IEntityDto , IDurum
{
    public Guid CariId { get; set; }
    public Guid SubeId { get; set; }
    public Guid DonemId { get; set; }
    public bool Durum { get; set; }

}

