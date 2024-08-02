namespace OnMuhasebe.Blazor.Services;

public class HizmetService : BaseService<ListHizmetDto, SelectHizmetDto> , IScopedDependency
{
    public override void SelectEntity(IEntityDto targetEntity)
    {
        if (targetEntity is SelectFaturaHareketDto hareket)
        {
            hareket.HizmetId = SelectedItem.Id;
            hareket.HizmetKodu = SelectedItem.Kod;
            hareket.HizmetAdi = SelectedItem.Ad;
            hareket.BirimAdi = SelectedItem.BirimAdi;
            hareket.BirimFiyat = SelectedItem.BirimFiyat;
            hareket.KdvOrani = SelectedItem.KdvOrani;
        }
    }
}
