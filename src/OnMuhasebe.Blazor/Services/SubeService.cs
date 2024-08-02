using OnMuhasebe.Blazor.Services.Base;
using OnMuhasebe.Subeler;
using Volo.Abp.Application.Dtos;
using Volo.Abp.DependencyInjection;

namespace OnMuhasebe.Blazor.Services;

public class SubeService : BaseService<ListSubeDto, SelectSubeDto> , IScopedDependency
{
    public override void SelectEntity(IEntityDto targetEntity)
    {
        switch (targetEntity)
        {
            case SelectFirmaParametreDto firmaparametre:
                firmaparametre.SubeId = SelectedItem.Id;
                firmaparametre.SubeAdi = SelectedItem.Ad;
                break;
        }
    }
}
