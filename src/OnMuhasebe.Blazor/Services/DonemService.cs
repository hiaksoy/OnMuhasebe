using OnMuhasebe.Blazor.Services.Base;
using OnMuhasebe.Donemler;
using Volo.Abp.DependencyInjection;

namespace OnMuhasebe.Blazor.Services;

public class DonemService : BaseService<ListDonemDto,SelectDonemDto> , IScopedDependency
{
}
