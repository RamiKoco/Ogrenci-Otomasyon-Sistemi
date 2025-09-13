using Microsoft.Extensions.Localization;
using OOS.OgrenciOtomasyonSistemi.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace OOS.OgrenciOtomasyonSistemi.Blazor.WebApp.Tiered;

[Dependency(ReplaceServices = true)]
public class OgrenciOtomasyonSistemiBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<OgrenciOtomasyonSistemiResource> _localizer;

    public OgrenciOtomasyonSistemiBrandingProvider(IStringLocalizer<OgrenciOtomasyonSistemiResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
