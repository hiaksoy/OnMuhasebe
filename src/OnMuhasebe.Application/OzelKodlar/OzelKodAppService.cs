﻿namespace OnMuhasebe.AppServices.OzelKodlar;

[Authorize(OnMuhasebePermissions.OzelKod.Default)]
public class OzelKodAppService : OnMuhasebeAppService, IOzelKodAppService
{
    private readonly IOzelKodRepository _ozelKodRepository;
    private readonly OzelKodManager _ozelKodManager;

    public OzelKodAppService(IOzelKodRepository ozelKodRepository, OzelKodManager ozelKodManager)
    {
        _ozelKodRepository = ozelKodRepository;
        _ozelKodManager = ozelKodManager;
    }

    [Authorize(OnMuhasebePermissions.OzelKod.Create)]
    public virtual async Task<SelectOzelKodDto> CreateAsync(CreateOzelKodDto input)
    {
        await _ozelKodManager.CheckCreateAsync(input.Kod, input.KodTuru, input.KartTuru);
        var entity = ObjectMapper.Map<CreateOzelKodDto, OzelKod>(input);
        await _ozelKodRepository.InsertAsync(entity);
        return ObjectMapper.Map<OzelKod, SelectOzelKodDto>(entity);

    }


    [Authorize(OnMuhasebePermissions.OzelKod.Delete)]
    public virtual async Task DeleteAsync(Guid id)
    {
        await _ozelKodManager.CheckDeleteAsync(id);
        await _ozelKodRepository.DeleteAsync(id);
    }

    public virtual async Task<SelectOzelKodDto> GetAsync(Guid id)
    {
        var entity = await _ozelKodRepository.GetAsync(id, x => x.Id == id);
        return ObjectMapper.Map<OzelKod, SelectOzelKodDto>(entity);
    }

    public virtual async Task<string> GetCodeAsync(OzelKodCodeParameterDto input)
    {
        return await _ozelKodRepository.GetCodeAsync(x => x.Kod, x => x.KodTuru == input.KodTuru && x.KartTuru == input.KartTuru && x.Durum == input.Durum);
    }

    public virtual async Task<PagedResultDto<ListOzelKodDto>> GetListAsync(OzelKodListParameterDto input)
    {
        var entities = await _ozelKodRepository.GetPagedListAsync(input.SkipCount, input.MaxResultCount,
            x => x.KodTuru == input.KodTuru && x.KartTuru == input.KartTuru && x.Durum == input.Durum,
            x => x.Kod);
        var totalCount = await _ozelKodRepository.CountAsync(x => x.KodTuru == input.KodTuru && x.KartTuru == input.KartTuru && x.Durum == input.Durum);
        var mappedDtos = ObjectMapper.Map<List<OzelKod>, List<ListOzelKodDto>>(entities);
        return new PagedResultDto<ListOzelKodDto>(totalCount, mappedDtos);

    }


    [Authorize(OnMuhasebePermissions.OzelKod.Update)]
    public virtual async Task<SelectOzelKodDto> UpdateAsync(Guid id, UpdateOzelKodDto input)
    {
        var entity = await _ozelKodRepository.GetAsync(id, x => x.Id == id);
        await _ozelKodManager.CheckUpdateAsync(id, input.Kod, entity);
        ObjectMapper.Map(input, entity);
        await _ozelKodRepository.UpdateAsync(entity);
        return ObjectMapper.Map<OzelKod, SelectOzelKodDto>(entity);

    }
}
