using OnMuhasebe.Commons;
using OnMuhasebe.EntityFrameworkCore;

namespace OnMuhasebe.EntityRepos.Parametreler;
public class EfCoreFirmaParametreRepository : EfCoreCommonRepository<FirmaParametre>, IFirmaParametreRepository
{
    public EfCoreFirmaParametreRepository(IDbContextProvider<OnMuhasebeDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }

}
