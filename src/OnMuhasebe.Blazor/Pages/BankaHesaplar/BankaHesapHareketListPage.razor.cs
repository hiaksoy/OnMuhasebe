using BlazorUI.Core.Models;


namespace OnMuhasebe.Blazor.Pages.BankaHesaplar;

public partial class BankaHesapHareketListPage
{
    public AppService AppService { get; set; }
    protected override async Task GetListDataSourceAsync()
    {
              var parameterDto = new MakbuzHareketListParameterDto
        {
            OdemeTuru = (OdemeTuru)Service.OdemeTuru,
            EntityId = (Guid)Service.EntityId,
            SubeId = ((SelectFirmaParametreDto)AppService.FirmaParametre).SubeId,
            DonemId = ((SelectFirmaParametreDto)AppService.FirmaParametre).DonemId,
        };

        var list = await GetListAsync(parameterDto);

        Service.ListDataSource = list.Items.ToList();

        Service.IsLoaded = true;
    }
}
