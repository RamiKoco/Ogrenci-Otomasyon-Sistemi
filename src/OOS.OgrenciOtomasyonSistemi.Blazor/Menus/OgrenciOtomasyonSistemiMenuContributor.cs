
namespace OOS.OgrenciOtomasyonSistemi.Blazor.Menus;
public class OgrenciOtomasyonSistemiMenuContributor : IMenuContributor
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
        var l = context.GetLocalizer<OgrenciOtomasyonSistemiResource>();
        context.Menu.Items.Clear();
        context.Menu.Items.Insert(
            0,
            new ApplicationMenuItem(
                OgrenciOtomasyonSistemiMenus.Home,
                l["Menu:Home"],
                "/",
                icon: "fas fa-home",
                order: 0
            )
        );
        return Task.CompletedTask;
    }
}