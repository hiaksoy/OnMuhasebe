using OnMuhasebe.Commons;
using OnMuhasebe.EntityFrameworkCore;

namespace OnMuhasebe.Raporlar;
public class EfCoreGirenCikanBakiyeRepository : EfCoreCommonNoKeyRepository<GirenCikanBakiye>, IGirenCikanBakiyeRepository
{
    public EfCoreGirenCikanBakiyeRepository(IDbContextProvider<OnMuhasebeDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
}
