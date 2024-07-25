using OnMuhasebe.Blazor.Services.Base;
using OnMuhasebe.Kasalar;
using Volo.Abp.DependencyInjection;

namespace OnMuhasebe.Blazor.Services;

public class KasaService : BaseService<ListKasaDto, SelectKasaDto> , IScopedDependency
{
}
