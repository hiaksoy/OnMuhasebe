using System.Threading.Tasks;
using OnMuhasebe.Localization;
using OnMuhasebe.MultiTenancy;
using Volo.Abp.Identity.Blazor;
using Volo.Abp.SettingManagement.Blazor.Menus;
using Volo.Abp.TenantManagement.Blazor.Navigation;
using Volo.Abp.UI.Navigation;

namespace OnMuhasebe.Blazor.Menus;

public class OnMuhasebeMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
      
        var l = context.GetLocalizer<OnMuhasebeResource>();

        context.Menu.Items.Clear();
        context.Menu.Items.Insert(
            0,
            new ApplicationMenuItem(
                OnMuhasebeMenus.Home,
                l["Menu:Home"],
                "/",
                icon: "fas fa-home",
                order: 0
            )
        );

        return Task.CompletedTask;
    }
}
