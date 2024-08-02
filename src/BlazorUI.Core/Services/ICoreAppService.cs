using Volo.Abp.Application.Dtos;

namespace BlazorUI.Core.Services;
public interface ICoreAppService
{
    public IEntityDto FirmaParametre { get; set; }
    public Action HasChanged { get; set; }
    public bool ShowFirmaParametreEditPage { get; set; }
    public bool ShowSubeDonemEditPage { get; set; }
}
