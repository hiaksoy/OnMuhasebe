using OnMuhasebe.Commons;
using OnMuhasebe.EntityFrameworkCore;

namespace OnMuhasebe.EntityRepos.OzelKodlar;
public class EfCoreOzelKodRepository : EfCoreCommonRepository<OzelKod>, IOzelKodRepository
{
    public EfCoreOzelKodRepository(IDbContextProvider<OnMuhasebeDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
}
