using OnMuhasebe.Commons;
using OnMuhasebe.EntityFrameworkCore;

namespace OnMuhasebe.EntityRepos.MakbuzHareketler;
public class EfCoreMakbuzHareketRepository : EfCoreCommonRepository<MakbuzHareket>, IMakbuzHareketRepository
{
    public EfCoreMakbuzHareketRepository(IDbContextProvider<OnMuhasebeDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
}
