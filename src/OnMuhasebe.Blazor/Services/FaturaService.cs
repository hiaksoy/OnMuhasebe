using OnMuhasebe.Blazor.Services.Base;
using OnMuhasebe.Faturalar;
using Volo.Abp.DependencyInjection;

namespace OnMuhasebe.Blazor.Services;

public class FaturaService : BaseService<ListFaturaDto, SelectFaturaDto>, IScopedDependency
{
}
