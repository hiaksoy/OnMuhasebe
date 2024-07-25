using OnMuhasebe.Birimler;
using OnMuhasebe.Blazor.Services.Base;
using OnMuhasebe.Entities.Masraflar;
using OnMuhasebe.Hizmetler;
using OnMuhasebe.Masraflar;
using OnMuhasebe.Stoklar;
using Volo.Abp.Application.Dtos;
using Volo.Abp.DependencyInjection;

namespace OnMuhasebe.Blazor.Services;

public class BirimService : BaseService<ListBirimDto, SelectBirimDto>, IScopedDependency
{
    public override void SelectEntity(IEntityDto targetEntity)
    {
        switch (targetEntity)
        {
            case SelectHizmetDto hizmet:
                hizmet.BirimId = SelectedItem.Id;
                hizmet.BirimAdi = SelectedItem.Ad;
                break;
            case SelectMasrafDto masraf:
                masraf.BirimId = SelectedItem.Id;
                masraf.BirimAdi = SelectedItem.Ad;
                break;
            case SelectStokDto stok:
                stok.BirimId = SelectedItem.Id;
                stok.BirimAdi = SelectedItem.Ad;
                break;
        }
    }
}
