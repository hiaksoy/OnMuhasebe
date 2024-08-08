using OnMuhasebe.Entities.Makbuzlar;
using OnMuhasebe.MakbuzHareketler;
using OnMuhasebe.Makbuzlar;
using OnMuhasebe.OdemeBelgeleri;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Repositories;

namespace OnMuhasebe.BankaHesaplar;
public class BankaHesapHareketAppService : OnMuhasebeAppService, IBankaHesapHareketAppService
{
    private readonly IMakbuzHareketRepository _makbuzHareketRepository;

    public BankaHesapHareketAppService(IMakbuzHareketRepository makbuzHareketRepository)
    {
        _makbuzHareketRepository = makbuzHareketRepository;
    }

    public Task<SelectMakbuzHareketDto> CreateAsync(MakbuzHareketDto input) => throw new NotImplementedException();

    public Task DeleteAsync(Guid id) => throw new NotImplementedException();

    public Task<SelectMakbuzHareketDto> GetAsync(Guid id) => throw new NotImplementedException();

    public Task<string> GetCodeAsync(MakbuzNoParameterDto input) => throw new NotImplementedException();

    public Task<SelectMakbuzHareketDto> UpdateAsync(Guid id, MakbuzHareketDto input) => throw new NotImplementedException();
   
    public async Task<PagedResultDto<ListOdemeBelgesiHareketDto>> GetListAsync(MakbuzHareketListParameterDto input)
    {
        var hareketler = await _makbuzHareketRepository.GetPagedListAsync(input.SkipCount, input.MaxResultCount,
           x => input.OdemeTuru == OdemeTuru.Banka
         ? x.BankaHesapId == input.EntityId 
         : x.KasaId == input.EntityId
        && x.Makbuz.SubeId == input.SubeId && x.Makbuz.DonemId == input.DonemId && x.Makbuz.Durum,
        x => x.Makbuz.Tarih, x => x.Makbuz);

        var totalCount = await _makbuzHareketRepository.CountAsync(x => input.OdemeTuru == OdemeTuru.Banka
         ? x.BankaHesapId == input.EntityId
         : x.KasaId == input.EntityId
        && x.Makbuz.SubeId == input.SubeId && x.Makbuz.DonemId == input.DonemId && x.Makbuz.Durum);

        var mappedDtos = ObjectMapper.Map<List<MakbuzHareket>, List<ListOdemeBelgesiHareketDto>>(hareketler);

        foreach (var item in mappedDtos)
        {
            item.OdemeTuruAdi = L[$"Enum:OdemeTuru:{(byte)item.OdemeTuru}"];
            item.MakbuzTuruAdi = L[$"Enum:MakbuzTuru:{(byte)item.MakbuzTuru}"];
            item.BelgeDurumuAdi = L[$"Enum:BelgeDurumu:{(byte)item.BelgeDurumu}"];
        }
        return new PagedResultDto<ListOdemeBelgesiHareketDto>(totalCount, mappedDtos);
    }

}
