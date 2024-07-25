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

     [Parameter,EditorRequired] public EventCallback OnSubmit { get; set; }
}
