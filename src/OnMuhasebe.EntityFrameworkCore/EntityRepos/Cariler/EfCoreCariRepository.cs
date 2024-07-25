using OnMuhasebe.Commons;
using OnMuhasebe.EntityFrameworkCore;

namespace OnMuhasebe.EntityRepos.Cariler;
public class EfCoreCariRepository : EfCoreCommonRepository<Cari> , ICariRepository
{
    public EfCoreCariRepository(IDbContextProvider<OnMuhasebeDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
}
