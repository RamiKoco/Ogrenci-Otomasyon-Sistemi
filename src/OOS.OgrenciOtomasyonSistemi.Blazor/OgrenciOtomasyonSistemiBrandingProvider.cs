
namespace OOS.OgrenciOtomasyonSistemi.Blazor;

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
