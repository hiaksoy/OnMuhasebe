using OnMuhasebe.Entities.BankaHesaplar;
using OnMuhasebe.Entities.Bankalar;
using OnMuhasebe.Entities.BankaSubeler;
using OnMuhasebe.Entities.Kasalar;
using OnMuhasebe.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Services;

namespace OnMuhasebe.Entities.Parametreler;
public class FirmaParametreManager :DomainService
{
    private readonly ISubeRepository _subeRepository;
    private readonly IDonemRepository _donemRepository;
    private readonly IDepoRepository _depoRepository;



    public FirmaParametreManager(ISubeRepository subeRepository, IDonemRepository donemRepository, IDepoRepository depoRepository)
    {
        _subeRepository = subeRepository;
        _donemRepository = donemRepository;
        _depoRepository = depoRepository;
    }

    public async Task CheckCreateAsync(Guid? subeId, Guid? donemId, Guid? depoId)
    {
        await _subeRepository.EntityAnyAsync(subeId, x => x.Id == subeId);
        await _donemRepository.EntityAnyAsync(donemId, x => x.Id == donemId);
        await _depoRepository.EntityAnyAsync(depoId, x => x.Id == depoId);
    }

    public async Task CheckUpdateAsync(Guid? subeId, Guid? donemId, Guid? depoId)
    {
        await _subeRepository.EntityAnyAsync(subeId, x => x.Id == subeId);
        await _donemRepository.EntityAnyAsync(donemId, x => x.Id == donemId);
        await _depoRepository.EntityAnyAsync(depoId, x => x.Id == depoId);
    }


}
