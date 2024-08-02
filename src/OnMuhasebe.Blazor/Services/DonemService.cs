using OnMuhasebe.Blazor.Services.Base;
using OnMuhasebe.Donemler;
using Volo.Abp.Application.Dtos;
using Volo.Abp.DependencyInjection;

namespace OnMuhasebe.Blazor.Services;

public class DonemService : BaseService<ListDonemDto,SelectDonemDto> , IScopedDependency
{
    public override void SelectEntity(IEntityDto targetEntity)
    {
        switch (targetEntity)
        {
            case SelectFirmaParametreDto firmaparametre:
                firmaparametre.DonemId = SelectedItem.Id;
                firmaparametre.DonemAdi = SelectedItem.Ad;
                break;
        }
    }
}
