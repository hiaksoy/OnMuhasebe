﻿using OnMuhasebe.Commons;
using OnMuhasebe.EntityFrameworkCore;

namespace OnMuhasebe.EntityRepos.Stoklar;
public class EfCoreStokRepository : EfCoreCommonRepository<Stok>, IStokRepository
{
    public EfCoreStokRepository(IDbContextProvider<OnMuhasebeDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }

    public override async Task<IQueryable<Stok>> WithDetailsAsync()
    {
        return (await GetQueryableAsync()).Include(x => x.Birim).Include(x => x.OzelKod1).Include(x => x.OzelKod2).Include(x=> x.FaturaHareketler).ThenInclude(x=>x.Fatura);
    }
}
