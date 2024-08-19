using BlazorUI.Core.Services;
using OnMuhasebe.Parametreler;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.DependencyInjection;

namespace OnMuhasebe.Blazor.Services;

public class AppService : ICoreAppService, IScopedDependency
{
    public IEntityDto FirmaParametre { get; set; } = new SelectFirmaParametreDto();
   
    public Action? HasChanged { get; set; }
    public bool ShowFirmaParametreEditPage { get; set; }
    public bool ShowSubeDonemEditPage { get; set; }
}
