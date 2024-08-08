using BlazorUI.Core.Models;
using DevExpress.Blazor.Internal;
using OnMuhasebe.Blazor.Helpers;
using OnMuhasebe.Blazor.Services.Base;
using OnMuhasebe.FaturaHareketler;
using Volo.Abp.DependencyInjection;

namespace OnMuhasebe.Blazor.Services;

public class FaturaHareketService : BaseHareketService<SelectFaturaHareketDto>, IScopedDependency
{
    public AppService? AppService { get; set; }
    public FaturaService? FaturaService { get; set; }
    public override void BeforeInsert()
    {
        DataSource = new SelectFaturaHareketDto
        {
            DepoId = ((SelectFirmaParametreDto)AppService.FirmaParametre).DepoId,
            DepoAdi = ((SelectFirmaParametreDto)AppService.FirmaParametre).DepoAdi,
            HareketTuru = FaturaHareketTuru.Stok
        };
        EditPageVisible = true;
    }
    public override void GetTotal()
    {
        FaturaService.DataSource.BrutTutar = ListDataSource.Sum(x => x.BrutTutar);
        FaturaService.DataSource.IndirimTutar = ListDataSource.Sum(x => x.IndirimTutar);
        FaturaService.DataSource.KdvHaricTutar = ListDataSource.Sum(x => x.KdvHaricTutar);
        FaturaService.DataSource.KdvTutar = ListDataSource.Sum(x => x.KdvTutar);
        FaturaService.DataSource.NetTutar = ListDataSource.Sum(x => x.NetTutar);
        FaturaService.DataSource.HareketSayisi = ListDataSource.Count;

    }

    public override void OnSubmit()
    {
        var validator = new SelectFaturaHareketDtoValidator(L);
        var result = validator.Validate(TempDataSource);

        if (result.IsValid)
        {
            DataSource = TempDataSource;
            DataSource.HareketTuruAdi = L[$"Enum:FaturaHareketTuru:" + $"{(byte)DataSource.HareketTuru}"];
            InsertOrUpdate();
            HasChanged();
        }
        else
            MessageService.Error(result.Errors.CreateValidationErrorMessage(L));
    }

    public void FaturaHareketTuruSelectedItemChanged(ComboBoxEnumItem<FaturaHareketTuru> selectedItem, Action hasChanged)
    {
        TempDataSource.HareketTuru = selectedItem.Value;
        hasChanged();

        TempDataSource.StokId = null;
        TempDataSource.StokAdi = null;
        TempDataSource.StokKodu = null;
        TempDataSource.HizmetId = null;
        TempDataSource.HizmetAdi = null;
        TempDataSource.HizmetKodu = null;
        TempDataSource.MasrafId = null;
        TempDataSource.MasrafAdi = null;
        TempDataSource.MasrafKodu = null;
        TempDataSource.BirimFiyat = 0;
        TempDataSource.KdvOrani = 0;

        if(TempDataSource.HareketTuru == FaturaHareketTuru.Stok)
        {
            TempDataSource.DepoId = ((SelectFirmaParametreDto)AppService.FirmaParametre).DepoId;
            TempDataSource.DepoAdi = ((SelectFirmaParametreDto)AppService.FirmaParametre).DepoAdi;
        }
        else
        {
            TempDataSource.DepoId = null;
            TempDataSource.DepoAdi = null;

        }

    }

    public override void Hesapla(object value, string propertyName)
    {
        TempDataSource.GetType().GetProperty(propertyName).SetValue(TempDataSource,value);

        TempDataSource.BrutTutar = TempDataSource.Miktar * TempDataSource.BirimFiyat;
        TempDataSource.IndirimTutar = TempDataSource.IndirimTutar > TempDataSource.BrutTutar ? TempDataSource.BrutTutar : TempDataSource.IndirimTutar; 
        TempDataSource.KdvHaricTutar = (TempDataSource.Miktar*TempDataSource.BirimFiyat) - TempDataSource.IndirimTutar;
        TempDataSource.KdvTutar = TempDataSource.KdvHaricTutar * TempDataSource.KdvOrani / 100;
        TempDataSource.NetTutar = TempDataSource.KdvHaricTutar + TempDataSource.KdvTutar;
    }
}
