
using OnMuhasebe.OdemeBelgeleri;

namespace OnMuhasebe.Blazor.Pages.OdemeBelgeleri;

public partial class OdemeBelgeleriListPage
{
    public AppService AppService { get; set; }
    protected override async Task GetListDataSourceAsync()
    {
        if (!Service.IsPopupListPage)
        {
            Service.MakbuzService.MakbuzTuru = 0;
            Service.OdemeTurleri = $"{(byte)OdemeTuru.Cek}, {(byte)OdemeTuru.Senet}, {(byte)OdemeTuru.Pos}";
            Service.KendiBelgemiz = false;
        }
        var listDataSource = (await GetListAsync(new OdemeBelgesiListParameterDto 
        {
            Sql = Service.MakbuzService.MakbuzTuru == MakbuzTuru.BankaIslem ||
                  Service.MakbuzService.MakbuzTuru == MakbuzTuru.KasaIslem ?
                  "IslemYapilabilecekTumOdemeBelgeleri" : 
                  Service.MakbuzService.MakbuzTuru == MakbuzTuru.Odeme ?
                  "IslemYapilabilecekOdemeBelgeleri" : "OdemeBelgeleri",

            SubeId = ((SelectFirmaParametreDto)AppService.FirmaParametre).SubeId,
            DonemId = ((SelectFirmaParametreDto)AppService.FirmaParametre).DonemId,
            KendiBelgemiz = Service.KendiBelgemiz,
            OdemeTurleri = Service.OdemeTurleri

        }))?.Items.ToList();
        
        if (listDataSource != null)
            Service.ListDataSource = listDataSource;

        foreach (var item in Service.ExcludeListItems)
        {
            var entity = Service.ListDataSource.FirstOrDefault(y => y.TakipNo == item);
            Service.ListDataSource.Remove(entity);
        }

        Service.ExcludeListItems = null;
        Service.IsLoaded = true;

    }
}
