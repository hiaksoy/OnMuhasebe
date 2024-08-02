using OnMuhasebe.Faturalar;
using System.Collections.Generic;

namespace OnMuhasebe.Blazor.Pages.Faturalar;

public partial class AlisFaturaListPage
{
#nullable disable
    public AppService AppService { get; set; }
    protected override async Task GetListDataSourceAsync()
    {
        Service.ListDataSource = (await GetListAsync(new FaturaListParameterDto
        {
            FaturaTuru = FaturaTuru.Alis,
            SubeId = ((SelectFirmaParametreDto)AppService.FirmaParametre).SubeId,
            DonemId = ((SelectFirmaParametreDto)AppService.FirmaParametre).DonemId,
            Durum = Service.IsActiveCards
        })).Items.ToList();

        Service.IsLoaded = true;
    }

    protected override async Task BeforeInsertAsync()
    {
        Service.DataSource = new SelectFaturaDto
        {
            FaturaTuru = FaturaTuru.Alis,
            FaturaTarihi = System.DateTime.Now.Date,
            SubeId = ((SelectFirmaParametreDto)AppService.FirmaParametre).SubeId,
            DonemId = ((SelectFirmaParametreDto)AppService.FirmaParametre).DonemId,
            Durum = Service.IsActiveCards,
            FaturaHareketler = new List<FaturaHareketler.SelectFaturaHareketDto>()
        };
        Service.ShowEditPage();

        await Task.CompletedTask;
    } 
}
