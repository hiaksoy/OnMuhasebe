using OnMuhasebe.Commons;
using OnMuhasebe.Entities.OdemeBelgeleri;
using OnMuhasebe.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnMuhasebe.EntityRepos.OdemeBelgeleri;
public class EfcoreOdemeBelgesiRepository : EfCoreCommonRepository<OdemeBelgesi>, IOdemeBelgesiRepository
{
    public EfcoreOdemeBelgesiRepository(IDbContextProvider<OnMuhasebeDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
}
