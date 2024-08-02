using OnMuhasebe.Bankalar;
using OnMuhasebe.Blazor.Services.Base;
using Volo.Abp.Application.Dtos;
using Volo.Abp.DependencyInjection;

namespace OnMuhasebe.Blazor.Services;

public class BankaService : BaseService<ListBankaDto, SelectBankaDto> , IScopedDependency
{
    public override void SelectEntity(IEntityDto targetEntity)
    {
        switch (targetEntity)
        {
            case SelectBankaHesapDto bankaHesap:
                bankaHesap.BankaId = SelectedItem.Id;
                bankaHesap.BankaAdi = SelectedItem.Ad;
                break;
            case SelectMakbuzHareketDto makbuzHareket:
                makbuzHareket.CekBankaId = SelectedItem.Id;
                makbuzHareket.CekBankaAdi = SelectedItem.Ad;
                break;
        }
    }
}
