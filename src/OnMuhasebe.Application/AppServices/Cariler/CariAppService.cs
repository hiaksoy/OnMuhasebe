﻿using OnMuhasebe.Cariler;
using OnMuhasebe.CommonDtos;
using OnMuhasebe.Entities.Cariler;
using OnMuhasebe.Faturalar;
using OnMuhasebe.Makbuzlar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Repositories;

namespace OnMuhasebe.AppServices.Cariler;
public class CariAppService : OnMuhasebeAppService, ICariAppService
{
    private readonly ICariRepository _cariRepository;
    private readonly CariManager _cariManager;

    public CariAppService(ICariRepository cariRepository, CariManager cariManager)
    {
        _cariRepository = cariRepository;
        _cariManager = cariManager;
    }

    public virtual async Task<SelectCariDto> CreateAsync(CreateCariDto input)
    {
        await _cariManager.CheckCreateAsync(input.Kod, input.OzelKod1Id, input.OzelKod2Id);
        var entity = ObjectMapper.Map<CreateCariDto, Cari>(input);
        await _cariRepository.InsertAsync(entity);
        return ObjectMapper.Map<Cari, SelectCariDto>(entity);

    }

    public virtual async Task DeleteAsync(Guid id)
    {
        await _cariManager.CheckDeleteAsync(id);
        await _cariRepository.DeleteAsync(id);
    }

    public virtual async Task<SelectCariDto> GetAsync(Guid id)
    {
        var entity = await _cariRepository.GetAsync(id, x => x.Id == id, x => x.OzelKod1, x => x.OzelKod2);
        return ObjectMapper.Map<Cari, SelectCariDto>(entity);
    }

    public virtual async Task<string> GetCodeAsync(CodeParameterDto input)
    {
        return await _cariRepository.GetCodeAsync(x => x.Kod, x => x.Durum == input.Durum);
    }

    public virtual async Task<PagedResultDto<ListCariDto>> GetListAsync(CariListParameterDto input)
    {
        var entities = await _cariRepository.GetPagedListAsync(input.SkipCount, input.MaxResultCount, x => x.Durum == input.Durum, x => x.Kod, x => x.OzelKod1, x => x.OzelKod2, x => x.Faturalar, x => x.Makbuzlar);
        var totalCount = await _cariRepository.CountAsync(x => x.Durum == input.Durum);
        var mappedDtos = ObjectMapper.Map<List<Cari>, List<ListCariDto>>(entities);

        foreach (var item in mappedDtos)
        {
            item.Alacak = item.Faturalar.Where(y => y.FaturaTuru == FaturaTuru.Alis).Sum(y => y.NetTutar);
            item.Alacak = item.Makbuzlar.Where(y => y.MakbuzTuru == MakbuzTuru.Tahsilat).Sum(y => y.CekToplam + y.SenetToplam + y.PosToplam + y.NakitToplam + y.BankaToplam);
            item.Borc = item.Faturalar.Where(y => y.FaturaTuru == FaturaTuru.Satis).Sum(y => y.NetTutar);
            item.Borc = item.Makbuzlar.Where(y => y.MakbuzTuru == MakbuzTuru.Odeme).Sum(y => y.CekToplam + y.SenetToplam + y.PosToplam + y.NakitToplam + y.BankaToplam);
        }                                                                
                                                                         
        return new PagedResultDto<ListCariDto>(totalCount, mappedDtos);  
    }                                                                    
                                                                         
    public virtual async Task<SelectCariDto> UpdateAsync(Guid id, UpdateCariDto input)
    {                                                                    
        var entity = await _cariRepository.GetAsync(id, x => x.Id == id); 
        await _cariManager.CheckUpdateAsync(id, input.Kod, entity, input.OzelKod1Id, input.OzelKod2Id);
        var mappedEntity = ObjectMapper.Map(input, entity);
        await _cariRepository.UpdateAsync(mappedEntity);
        return ObjectMapper.Map<Cari, SelectCariDto>(mappedEntity);
    }
}
