using Volo.Abp.Application.Dtos;

namespace OnMuhasebe.BankaSubeler;
public class BankaSubeListParameterDto : PagedResultRequestDto , IEntityDto, IDurum
{
    public Guid BankaId { get; set; }
    public bool Durum { get; set; }

}
