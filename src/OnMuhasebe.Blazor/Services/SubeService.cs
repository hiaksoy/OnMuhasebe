using OnMuhasebe.Blazor.Services.Base;
using OnMuhasebe.Subeler;
using Volo.Abp.DependencyInjection;

namespace OnMuhasebe.Blazor.Services;

public class SubeService : BaseService<ListSubeDto, SelectSubeDto> , IScopedDependency
{
}
