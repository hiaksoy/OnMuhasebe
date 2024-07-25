using BlazorUI.Core.Models;
using OnMuhasebe.BankaHesaplar;
using OnMuhasebe.Blazor.Services.Base;
using Volo.Abp.DependencyInjection;

namespace OnMuhasebe.Blazor.Services;

public class BankaHesapService : BaseService<ListBankaHesapDto, SelectBankaHesapDto> , IScopedDependency
{
    public BankaHesapTuru? HesapTuru { get; set; }
    
    public void BankaHesapTuruSelectedItemChanged(ComboBoxEnumItem<BankaHesapTuru> selectedItem)
    {
        DataSource.HesapTuru = selectedItem.Value;
    }
}
