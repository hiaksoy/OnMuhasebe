using OnMuhasebe.Samples;
using Xunit;

namespace OnMuhasebe.EntityFrameworkCore.Domains;

[Collection(OnMuhasebeTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<OnMuhasebeEntityFrameworkCoreTestModule>
{

}
