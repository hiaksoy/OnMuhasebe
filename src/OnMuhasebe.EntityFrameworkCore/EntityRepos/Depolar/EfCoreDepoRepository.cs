using OnMuhasebe.Commons;
using OnMuhasebe.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnMuhasebe.EntityRepos.Depolar;
public class EfCoreDepoRepository : EfCoreCommonRepository<Depo> , IDepoRepository
{
    public EfCoreDepoRepository(IDbContextProvider<OnMuhasebeDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }

    public override async Task<IQueryable<Depo>> WithDetailsAsync()
    {
        return (await GetQueryableAsync()).Include(x => x.OzelKod1).Include(x => x.OzelKod2).Include(x => x.FaturaHareketler).ThenInclude(x => x.Fatura);
    }
}
