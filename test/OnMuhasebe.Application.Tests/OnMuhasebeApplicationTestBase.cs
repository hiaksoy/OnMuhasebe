using Volo.Abp.Modularity;

namespace OnMuhasebe;

public abstract class OnMuhasebeApplicationTestBase<TStartupModule> : OnMuhasebeTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
