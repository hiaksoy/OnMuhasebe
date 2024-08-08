using OnMuhasebe.Extensions;
using Volo.Abp.Domain.Services;

namespace OnMuhasebe.Entities.Kasalar;
public class KasaManager : DomainService
{
    private readonly IKasaRepository _kasaRepository;
    private readonly ISubeRepository _subeRepository;
    private readonly IOzelKodRepository _ozelKodRepository;

    public KasaManager(IKasaRepository kasaRepository, ISubeRepository subeRepository, IOzelKodRepository ozelKodRepository)
    {
        _kasaRepository = kasaRepository;
        _subeRepository = subeRepository;
        _ozelKodRepository = ozelKodRepository;
    }

    public async Task CheckCreateAsync(string kod, Guid? ozelKod1Id, Guid? ozelKod2Id ,Guid? subeId)
    {
        await _subeRepository.EntityAnyAsync(subeId, x => x.Id == subeId);
        await _kasaRepository.KodAnyAsync(kod, x => x.Kod == kod && x.SubeId == subeId);
        await _ozelKodRepository.EntityAnyAsync(ozelKod1Id, OzelKodTuru.OzelKod1, KartTuru.Kasa);
        await _ozelKodRepository.EntityAnyAsync(ozelKod2Id, OzelKodTuru.OzelKod2, KartTuru.Kasa);
    }


    public async Task CheckUpdateAsync(Guid id, string kod, Kasa entity, Guid? ozelKod1Id, Guid? ozelKod2Id)
    {
        await _kasaRepository.KodAnyAsync(kod, x => x.Id != id && x.Kod == kod && x.SubeId == entity.SubeId, entity.Kod != kod);
        await _ozelKodRepository.EntityAnyAsync(ozelKod1Id, OzelKodTuru.OzelKod1, KartTuru.Kasa, entity.OzelKod1Id != ozelKod1Id);
        await _ozelKodRepository.EntityAnyAsync(ozelKod2Id, OzelKodTuru.OzelKod2, KartTuru.Kasa, entity.OzelKod2Id != ozelKod2Id);
    }

    public async Task CheckDeleteAsync(Guid id)
    {
        await _kasaRepository.RelationalEntityAnyAsync(x => x.MakbuzHareketler.Any(y => y.KasaId == id) || x.Makbuzlar.Any(y => y.KasaId == id));
    }

}
