using OnMuhasebe.Commons;
using OnMuhasebe.EntityFrameworkCore;

namespace OnMuhasebe.EntityRepos.Birimler;
public class EfCoreBirimRepository : EfCoreCommonRepository<Birim> , IBirimRepository
{
    public EfCoreBirimRepository(IDbContextProvider<OnMuhasebeDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
}
