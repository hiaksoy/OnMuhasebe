using OnMuhasebe.Blazor.Services.Base;
using OnMuhasebe.Cariler;
using OnMuhasebe.Faturalar;
using Volo.Abp.Application.Dtos;
using Volo.Abp.DependencyInjection;

namespace OnMuhasebe.Blazor.Services;

public class CariService : BaseService<ListCariDto, SelectCariDto>, IScopedDependency
{
    public override void SelectEntity(IEntityDto targetEntity)
    {
        switch (targetEntity)
        {
            case SelectFaturaDto fatura:
                fatura.CariId = SelectedItem.Id;
                fatura.CariAdi = SelectedItem.Ad;
                break;
        }
    }
}
