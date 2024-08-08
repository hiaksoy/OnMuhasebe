using OnMuhasebe.Extensions;
using Volo.Abp.Domain.Services;

namespace OnMuhasebe.Entities.Faturalar;
public class FaturaHareketManager : DomainService
{

    private readonly IDepoRepository _depoRepository;
    private readonly IStokRepository _stokRepository;
    private readonly IHizmetRepository _hizmetRepository;
    private readonly IMasrafRepository _masrafRepository;

    public FaturaHareketManager(IDepoRepository depoRepository, IStokRepository stokRepository, IHizmetRepository hizmetRepository, IMasrafRepository masrafRepository)
    {
        _depoRepository = depoRepository;
        _stokRepository = stokRepository;
        _hizmetRepository = hizmetRepository;
        _masrafRepository = masrafRepository;
    }

    public async Task CheckCreateAsync(Guid? depoId, Guid? stokId, Guid? hizmetId, Guid? masrafId)
    {
        await _depoRepository.EntityAnyAsync(depoId, x => x.Id == depoId);
        await _stokRepository.EntityAnyAsync(stokId, x => x.Id == stokId);
        await _hizmetRepository.EntityAnyAsync(hizmetId, x => x.Id == hizmetId);
        await _masrafRepository.EntityAnyAsync(masrafId, x => x.Id == masrafId);
    }         

    public async Task CheckUpdateAsync(Guid? depoId, Guid? stokId, Guid? hizmetId, Guid? masrafId)
    {
        await _depoRepository.EntityAnyAsync(depoId, x => x.Id == depoId);
        await _stokRepository.EntityAnyAsync(stokId, x => x.Id == stokId);
        await _hizmetRepository.EntityAnyAsync(hizmetId, x => x.Id == hizmetId);
        await _masrafRepository.EntityAnyAsync(masrafId, x => x.Id == masrafId);
    }
}
