using OnMuhasebe.Commons;
using OnMuhasebe.EntityFrameworkCore;

namespace OnMuhasebe.Raporlar;
public class EfCoreOdemeBelgeleriDagilimRepository : EfCoreCommonNoKeyRepository<OdemeBelgeleriDagilim>, IOdemeBelgeleriDagilimRepository
{
    public EfCoreOdemeBelgeleriDagilimRepository(IDbContextProvider<OnMuhasebeDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
}
