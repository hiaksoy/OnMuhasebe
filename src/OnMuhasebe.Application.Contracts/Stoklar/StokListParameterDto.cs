using Volo.Abp.Application.Dtos;

namespace OnMuhasebe.Stoklar;
public class StokListParameterDto : PagedResultRequestDto , IEntityDto, IDurum
{
    public bool Durum { get; set; }
}
