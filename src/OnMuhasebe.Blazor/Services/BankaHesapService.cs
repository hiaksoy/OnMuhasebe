using BlazorUI.Core.Models;

namespace OnMuhasebe.Blazor.Services;

public class BankaHesapService : BaseService<ListBankaHesapDto, SelectBankaHesapDto> , IScopedDependency
{
    public BankaHesapTuru? HesapTuru { get; set; }
    
    public void BankaHesapTuruSelectedItemChanged(ComboBoxEnumItem<BankaHesapTuru> selectedItem)
    {
        DataSource.HesapTuru = selectedItem.Value;
    }

    public override void SelectEntity(IEntityDto targetEntity)
    {
        switch (targetEntity)
        {
            case SelectMakbuzHareketDto makbuzHareket:
                makbuzHareket.CekBankaId = SelectedItem.Id;
                makbuzHareket.CekBankaAdi = SelectedItem.Ad;
                break;
        }
    }
}
