using OnMuhasebe.Blazor.Services.Base;
using OnMuhasebe.Masraflar;
using Volo.Abp.DependencyInjection;

namespace OnMuhasebe.Blazor.Services;

public class MasrafService : BaseService<ListMasrafDto, SelectMasrafDto> , IScopedDependency
{
}
