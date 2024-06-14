using Volo.Abp.Modularity;

namespace OnMuhasebe;

/* Inherit from this class for your domain layer tests. */
public abstract class OnMuhasebeDomainTestBase<TStartupModule> : OnMuhasebeTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
