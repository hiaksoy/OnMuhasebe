namespace OnMuhasebe.Blazor.Pages.BankaHesaplar;

public partial class BankaHesapListPage
{
    public AppService? AppService { get; set; }
    protected override async Task GetListDataSourceAsync()
    {
        var listDataSource = (await GetListAsync(new BankaHesapListParameterDto
        {
            HesapTuru = Service.HesapTuru,
            SubeId = ((SelectFirmaParametreDto)AppService.FirmaParametre).SubeId,
            Durum = Service.IsActiveCards
        }))?.Items.ToList();

        Service.IsLoaded = true;

        if (listDataSource != null)
            Service.ListDataSource = listDataSource;
    }

    protected override async Task BeforeInsertAsync()
    {
        Service.DataSource = new SelectBankaHesapDto
        {
            Kod = await GetCodeAsync(new BankaHesapCodeParameterDto
            {
                SubeId = ((SelectFirmaParametreDto)AppService.FirmaParametre).SubeId,
                Durum = Service.IsActiveCards
            }),
            HesapTuru = BankaHesapTuru.VadesizMevduatHesabi,
            SubeId = ((SelectFirmaParametreDto)AppService.FirmaParametre).SubeId,
            Durum = Service.IsActiveCards
        };
        Service.ShowEditPage();
    }
}
