using Volo.Abp.Modularity;

namespace OnMuhasebe;

[DependsOn(
    typeof(OnMuhasebeDomainModule),
    typeof(OnMuhasebeTestBaseModule)
)]
public class OnMuhasebeDomainTestModule : AbpModule
{

}
