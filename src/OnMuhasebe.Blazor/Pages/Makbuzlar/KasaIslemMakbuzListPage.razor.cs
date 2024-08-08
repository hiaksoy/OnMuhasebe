namespace OnMuhasebe.Blazor.Pages.Makbuzlar;

public partial class KasaIslemMakbuzListPage
{
    public AppService? AppService { get; set; }
    protected override async Task GetListDataSourceAsync()
    {
        Service.ListDataSource = (await GetListAsync(new MakbuzListParameterDto
        {
            MakbuzTuru = MakbuzTuru.KasaIslem,
            SubeId = ((SelectFirmaParametreDto)AppService.FirmaParametre).SubeId,
            DonemId = ((SelectFirmaParametreDto)AppService.FirmaParametre).DonemId,
            Durum = Service.IsActiveCards
        })).Items.ToList();

        Service.IsLoaded = true;
    }

    protected override async Task BeforeInsertAsync()
    {
        Service.DataSource = new SelectMakbuzDto
        {
            MakbuzNo = await GetCodeAsync(new MakbuzNoParameterDto
            {
                MakbuzTuru = MakbuzTuru.KasaIslem,
                SubeId = ((SelectFirmaParametreDto)AppService.FirmaParametre).SubeId,
                DonemId = ((SelectFirmaParametreDto)AppService.FirmaParametre).DonemId,
                Durum = Service.IsActiveCards
            }),
            MakbuzTuru = MakbuzTuru.KasaIslem,
            Tarih = DateTime.Now.Date,
            SubeId = ((SelectFirmaParametreDto)AppService.FirmaParametre).SubeId,
            DonemId = ((SelectFirmaParametreDto)AppService.FirmaParametre).DonemId,
            Durum = Service.IsActiveCards,
            MakbuzHareketler = new List<SelectMakbuzHareketDto>()
        };
        Service.ShowEditPage();

        await Task.CompletedTask;
    }
}
