using BlazorUI.Core.Models;

namespace OnMuhasebe.Blazor.Services;

public class MakbuzHareketService : BaseHareketService<SelectMakbuzHareketDto>, IScopedDependency
{
    public AppService AppService { get; set; }
    public MakbuzService MakbuzService { get; set; }

    public override void BeforeUpdate()
    {
        if(MakbuzService.MakbuzTuru == MakbuzTuru.Tahsilat || (SelectedItem.BelgeDurumu!=BelgeDurumu.CiroEdildi&&SelectedItem.BelgeDurumu!=BelgeDurumu.TahsilEdildi))
        {
            DataSource = SelectedItem;
            EditPageVisible = true;
        }
    }

    public override void BeforeInsert()
    {
        DataSource = new SelectMakbuzHareketDto
        {
            OdemeTuru = OdemeTuru.Cek,
            Vade = DateTime.Now.Date,
            TakipNo = CreateId()
        };
        EditPageVisible = true; 
    }


    public void MakbuzHareketTuruSelectedItemChanged(ComboBoxEnumItem<OdemeTuru> selectedItem, Action hasChanged)
    {
        TempDataSource.OdemeTuru = selectedItem.Value;
        hasChanged();

        TempDataSource.CekBankaId = null;
        TempDataSource.CekBankaAdi = null;
        TempDataSource.CekBankaSubeId = null;
        TempDataSource.CekBankaSubeAdi = null;
        TempDataSource.CekHesapNo = null;
        TempDataSource.BelgeNo = null;
        TempDataSource.AsilBorclu = null;
        TempDataSource.Ciranta = null;
        TempDataSource.KasaId = null;
        TempDataSource.KasaAdi = null;
        TempDataSource.BankaHesapId = null;
        TempDataSource.BankaHesapAdi = null;
    }

    public override void OnSubmit()
    {
        
    }
}
