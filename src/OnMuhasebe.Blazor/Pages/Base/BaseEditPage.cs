using Microsoft.AspNetCore.Components;
using OnMuhasebe.Localization;
using Volo.Abp.AspNetCore.Components;

namespace OnMuhasebe.Blazor.Pages.Base;

public abstract class BaseEditPage : AbpComponentBase
{
    protected BaseEditPage()
    {
        LocalizationResource = typeof(OnMuhasebeResource);
    }

     [Parameter] public EventCallback OnSubmit { get; set; }
}
