using OnMuhasebe.Commons;
using OnMuhasebe.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnMuhasebe.EntityRepos.BankaHesaplar;
public class EfCoreBankaHesapRepository : EfCoreCommonRepository<BankaHesap> ,IBankaHesapRepository
{
    public EfCoreBankaHesapRepository(IDbContextProvider<OnMuhasebeDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
}
