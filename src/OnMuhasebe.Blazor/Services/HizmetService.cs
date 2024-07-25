using OnMuhasebe.Blazor.Services.Base;
using OnMuhasebe.Hizmetler;
using Volo.Abp.DependencyInjection;

namespace OnMuhasebe.Blazor.Services;

public class HizmetService : BaseService<ListHizmetDto, SelectHizmetDto> , IScopedDependency
{
}
