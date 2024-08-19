using OnMuhasebe.Faturalar;
using System;

namespace OnMuhasebe.Blazor.Pages.Faturalar;

public partial class SatisFaturaListPage
{
#nullable disable
    public AppService AppService { get; set; }
    protected override async Task GetListDataSourceAsync()
    {
        var listDataSource = (await GetListAsync(new FaturaListParameterDto
        {
            FaturaTuru = FaturaTuru.Satis,
            SubeId = ((SelectFirmaParametreDto)AppService.FirmaParametre).SubeId,
            DonemId = ((SelectFirmaParametreDto)AppService.FirmaParametre).DonemId,
            Durum = Service.IsActiveCards
        }))?.Items.ToList();

        Service.IsLoaded = true;

        if (listDataSource != null)
            Service.ListDataSource = listDataSource;
    }

    protected override async Task BeforeInsertAsync()
    {
        Service.DataSource = new SelectFaturaDto
        {
           FaturaNo = await GetCodeAsync(new FaturaNoParameterDto 
           {
               FaturaTuru = FaturaTuru.Satis,
               SubeId = ((SelectFirmaParametreDto)AppService.FirmaParametre).SubeId,
               DonemId = ((SelectFirmaParametreDto)AppService.FirmaParametre).DonemId,
               Durum = Service.IsActiveCards
           }),

            FaturaTuru = FaturaTuru.Satis,
            FaturaTarihi = DateTime.Now.Date,
            SubeId = ((SelectFirmaParametreDto)AppService.FirmaParametre).SubeId,
            DonemId = ((SelectFirmaParametreDto)AppService.FirmaParametre).DonemId,
            Durum = Service.IsActiveCards,
            FaturaHareketler = new System.Collections.Generic.List<FaturaHareketler.SelectFaturaHareketDto>()

        };
        Service.ShowEditPage();

    }
}
