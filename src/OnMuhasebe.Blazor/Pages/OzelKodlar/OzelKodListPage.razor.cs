using OnMuhasebe.OzelKodlar;
using System.Linq;
using System.Threading.Tasks;

namespace OnMuhasebe.Blazor.Pages.OzelKodlar;

public partial class OzelKodListPage
{
    protected override async Task GetListDataSourceAsync()
    {
        Service.ListDataSource = (await GetListAsync(new OzelKodListParameterDto
        {
            KodTuru = Service.KodTuru,
            KartTuru = Service.KartTuru,
            Durum = Service.IsActiveCards
        })).Items.ToList();

        Service.IsLoaded = true;
    }

    protected override async Task BeforeInsertAsync()
    {
        Service.DataSource = new SelectOzelKodDto
        {
            Kod = await GetCodeAsync(new OzelKodCodeParameterDto
            {
                KodTuru = Service.KodTuru,
                KartTuru = Service.KartTuru,
                Durum = Service.IsActiveCards
            }),
            KodTuru = Service.KodTuru,
            KartTuru = Service.KartTuru,
            Durum = Service.IsActiveCards
        };
        Service.ShowEditPage();
    }
}
