using OnMuhasebe.Blazor.Services.Base;
using OnMuhasebe.Depolar;
using Volo.Abp.Application.Dtos;
using Volo.Abp.DependencyInjection;

namespace OnMuhasebe.Blazor.Services;

public class DepoService : BaseService<ListDepoDto,SelectDepoDto> , IScopedDependency
{

    public override void SelectEntity(IEntityDto targetEntity)
    {
        switch (targetEntity)
        {
            case SelectFirmaParametreDto firmaparametre:
                firmaparametre.DepoId = SelectedItem.Id;
                firmaparametre.DepoAdi = SelectedItem.Ad;
                break;

            case SelectFaturaHareketDto faturaHareket:
                faturaHareket.DepoId = SelectedItem.Id;
                faturaHareket.DepoAdi = SelectedItem.Ad;
                break;
        }
    }
}
