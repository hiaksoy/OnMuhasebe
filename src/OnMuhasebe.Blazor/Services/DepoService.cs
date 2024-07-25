using OnMuhasebe.Blazor.Services.Base;
using OnMuhasebe.Depolar;
using Volo.Abp.DependencyInjection;

namespace OnMuhasebe.Blazor.Services;

public class DepoService : BaseService<ListDepoDto,SelectDepoDto> , IScopedDependency
{
}
