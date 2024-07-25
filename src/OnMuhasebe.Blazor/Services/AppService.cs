using BlazorUI.Core.Services;
using OnMuhasebe.Parametreler;
using Volo.Abp.Application.Dtos;
using Volo.Abp.DependencyInjection;

namespace OnMuhasebe.Blazor.Services;

public class AppService : ICoreAppService, IScopedDependency
{
    public IEntityDto FirmaParametre { get; set; } = new SelectFirmaParametreDto
    {
        SubeId = new System.Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"),
        DonemId = new System.Guid("88cef4d4-3f0e-1f97-b5d5-3a13717ee0b9")
    };
}
