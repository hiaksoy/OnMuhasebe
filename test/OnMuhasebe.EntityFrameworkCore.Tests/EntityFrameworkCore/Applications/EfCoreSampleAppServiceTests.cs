using OnMuhasebe.Samples;
using Xunit;

namespace OnMuhasebe.EntityFrameworkCore.Applications;

[Collection(OnMuhasebeTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<OnMuhasebeEntityFrameworkCoreTestModule>
{

}
