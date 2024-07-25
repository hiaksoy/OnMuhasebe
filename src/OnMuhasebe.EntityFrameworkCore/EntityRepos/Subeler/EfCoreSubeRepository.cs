using OnMuhasebe.Commons;
using OnMuhasebe.EntityFrameworkCore;

namespace OnMuhasebe.EntityRepos.Subeler;
public class EfCoreSubeRepository : EfCoreCommonRepository<Sube>, ISubeRepository
{
    public EfCoreSubeRepository(IDbContextProvider<OnMuhasebeDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
}
