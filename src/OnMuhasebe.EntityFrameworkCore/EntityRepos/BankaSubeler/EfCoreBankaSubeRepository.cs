using OnMuhasebe.Commons;
using OnMuhasebe.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnMuhasebe.EntityRepos.BankaSubeler;
public class EfCoreBankaSubeRepository : EfCoreCommonRepository<BankaSube> , IBankaSubeRepository
{
    public EfCoreBankaSubeRepository(IDbContextProvider<OnMuhasebeDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
}
