﻿using OnMuhasebe.BankaHesaplar;
using OnMuhasebe.Entities.BankaHesaplar;
using OnMuhasebe.Makbuzlar;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Repositories;

namespace OnMuhasebe.AppServices.BankaHesaplar;
public class BankaHesapAppService : OnMuhasebeAppService, IBankaHesapAppService
{
    private readonly IBankaHesapRepository _bankaHesapRepository;
    private readonly BankaHesapManager _bankaHesapManager;

    public BankaHesapAppService(IBankaHesapRepository bankaHesapRepository, BankaHesapManager bankaHesapManager)
    {
        _bankaHesapRepository = bankaHesapRepository;
        _bankaHesapManager = bankaHesapManager;
    }

    public virtual async Task<SelectBankaHesapDto> CreateAsync(CreateBankaHesapDto input)
    {
        await _bankaHesapManager.CheckCreateAsync(input.Kod, input.BankaSubeId, input.OzelKod1Id, input.OzelKod2Id, input.SubeId);
        var entity = ObjectMapper.Map<CreateBankaHesapDto, BankaHesap>(input);
        await _bankaHesapRepository.InsertAsync(entity);
        return ObjectMapper.Map<BankaHesap, SelectBankaHesapDto>(entity);

    }

    public virtual async Task DeleteAsync(Guid id)
    {
        await _bankaHesapManager.CheckDeleteAsync(id);
        await _bankaHesapRepository.DeleteAsync(id);
    }

    public virtual async Task<SelectBankaHesapDto> GetAsync(Guid id)
    {
        var entity = await _bankaHesapRepository.GetAsync(id, b => b.Id == id, b => b.BankaSube, x => x.BankaSube.Banka, x => x.OzelKod1, x => x.OzelKod2);
        var mappedDto = ObjectMapper.Map<BankaHesap, SelectBankaHesapDto>(entity);
        mappedDto.HesapTuruAdi = L[$"Enum:BankaHesapTuru:{(byte)mappedDto.HesapTuru}"];

        return mappedDto;
    }

    public virtual async Task<string> GetCodeAsync(BankaHesapCodeParameterDto input)
    {
        return await _bankaHesapRepository.GetCodeAsync(x => x.Kod, x => x.SubeId == input.SubeId && x.Durum == input.Durum);
    }

    public virtual async Task<PagedResultDto<ListBankaHesapDto>> GetListAsync(BankaHesapListParameterDto input)
    {
        var entities = await _bankaHesapRepository.GetPagedListAsync(input.SkipCount, input.MaxResultCount,
            x => input.HesapTuru == null ? x.SubeId == input.SubeId && x.Durum == input.Durum :
            x.HesapTuru == input.HesapTuru && x.SubeId == input.SubeId && x.Durum == input.Durum, x => x.Kod, x => x.BankaSube, x => x.BankaSube.Banka, x => x.OzelKod1, x => x.OzelKod2, x => x.MakbuzHareketler);

        var totalCount = await _bankaHesapRepository.CountAsync(
            x => input.HesapTuru == null ? x.SubeId == input.SubeId && x.Durum == input.Durum :
            x.HesapTuru == input.HesapTuru && x.SubeId == input.SubeId && x.Durum == input.Durum);

        var mappedDtos = ObjectMapper.Map<List<BankaHesap>, List<ListBankaHesapDto>>(entities);

        foreach (var item in mappedDtos)
        {
            item.HesapTuruAdi = L[$"Enum:BankaHesapTuru:{(byte)item.HesapTuru}"];
            item.Borc = item.MakbuzHareketler.Where(y => y.BelgeDurumu == BelgeDurumu.TahsilEdildi || y.OdemeTuru == OdemeTuru.Pos && y.BelgeDurumu == BelgeDurumu.Portfoyde).Sum(y => y.Tutar);
            item.Alacak = item.MakbuzHareketler.Where(y => y.BelgeDurumu == BelgeDurumu.TahsilEdildi).Sum(y => y.Tutar);
        }

        return new PagedResultDto<ListBankaHesapDto>(totalCount, mappedDtos);

    }

    public virtual async Task<SelectBankaHesapDto> UpdateAsync(Guid id, UpdateBankaHesapDto input)
    {
        var entity = await _bankaHesapRepository.GetAsync(id,x => x.Id == id);
        await _bankaHesapManager.CheckUpdateAsync(id, input.Kod, entity, input.BankaSubeId, input.OzelKod1Id, input.OzelKod2Id);
        var mappedEntity = ObjectMapper.Map(input, entity);
        await _bankaHesapRepository.UpdateAsync(mappedEntity);
        return ObjectMapper.Map<BankaHesap, SelectBankaHesapDto>(mappedEntity);

    }
}
