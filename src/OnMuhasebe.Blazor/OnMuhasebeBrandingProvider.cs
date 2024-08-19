using Microsoft.Extensions.Localization;
using OnMuhasebe.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace OnMuhasebe.Blazor;

[Dependency(ReplaceServices = true)]
public class OnMuhasebeBrandingProvider : DefaultBrandingProvider
{
    private readonly IStringLocalizer<OnMuhasebeResource> _localizer;

    public OnMuhasebeBrandingProvider(IStringLocalizer<OnMuhasebeResource> localizer)
    {
        _localizer = localizer;
    }


    public override string AppName => $"Aksoy {_localizer["Software"]} {_localizer["Pre-Accounting"]}";
}
