using OnMuhasebe.Blazor.Services.Base;
using OnMuhasebe.Stoklar;
using Volo.Abp.DependencyInjection;

namespace OnMuhasebe.Blazor.Services;

public class StokService: BaseService<ListStokDto, SelectStokDto> , IScopedDependency
{
}
