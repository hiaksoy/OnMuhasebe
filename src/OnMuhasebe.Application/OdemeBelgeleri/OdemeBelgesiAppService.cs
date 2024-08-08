using OnMuhasebe.Entities.OdemeBelgeleri;
using OnMuhasebe.MakbuzHareketler;
using OnMuhasebe.Makbuzlar;
using Volo.Abp.Application.Dtos;

namespace OnMuhasebe.OdemeBelgeleri;
public class OdemeBelgesiAppService : OnMuhasebeAppService, IOdemeBelgesiAppService
{
    public OdemeBelgesiAppService(IOdemeBelgesiRepository repository)
    {
        _repository = repository;
    }
    private readonly IOdemeBelgesiRepository _repository;
    public async Task<PagedResultDto<ListOdemeBelgesiDto>> GetListAsync(OdemeBelgesiListParameterDto input)
    {
        IList<OdemeBelgesi> _odemeBelgeleri;

        if (input.Sql == "IslemYapilabilecekOdemeBelgeleri")
            _odemeBelgeleri = await _repository.FromSqlRawAsync($"{input.Sql} " +
                                                                $"@SubeId= '{input.SubeId}', " +
                                                                $"@DonemId='{input.DonemId}', " +
                                                                $"@KendiBelgemiz={input.KendiBelgemiz}, " +
                                                                $"@OdemeTurleri='{input.OdemeTurleri}'");
        else
            _odemeBelgeleri = await _repository.FromSqlRawAsync($"{input.Sql} " +
                                                                $"@SubeId= '{input.SubeId}', " +
                                                                $"@DonemId='{input.DonemId}', " +
                                                                $"@OdemeTurleri='{input.OdemeTurleri}'");

        var mappedEntities = ObjectMapper.Map<List<OdemeBelgesi>, List<ListOdemeBelgesiDto>>(_odemeBelgeleri.ToList());

        foreach (var item in mappedEntities)
        {
            item.OdemeTuruAdi = L[$"Enum:OdemeTuru:{(byte)item.OdemeTuru}"];
            item.BelgeDurumuAdi = L[$"Enum:BelgeDurumu:{(byte)item.BelgeDurumu}"];

        }

        return new PagedResultDto<ListOdemeBelgesiDto>
        {
            TotalCount = _odemeBelgeleri.Count,
            Items = mappedEntities
        };
    }
    public Task<SelectMakbuzHareketDto> GetAsync(Guid id) => throw new NotImplementedException();
    public Task<SelectMakbuzHareketDto> CreateAsync(MakbuzHareketDto input) => throw new NotImplementedException();
    public Task DeleteAsync(Guid id) => throw new NotImplementedException();
    public Task<string> GetCodeAsync(MakbuzNoParameterDto input) => throw new NotImplementedException();
    public Task<SelectMakbuzHareketDto> UpdateAsync(Guid id, MakbuzHareketDto input) => throw new NotImplementedException();
}
