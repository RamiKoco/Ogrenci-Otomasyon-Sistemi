
namespace OOS.OgrenciOtomasyonSistemi.Blazor
{
    [Dependency(ReplaceServices = true)]
    public class OgrenciOtomasyonSistemiBrandingProvider : DefaultBrandingProvider
    {
        private readonly IStringLocalizer<OgrenciOtomasyonSistemiResource> _localizer;

        public OgrenciOtomasyonSistemiBrandingProvider(IStringLocalizer<OgrenciOtomasyonSistemiResource> localizer)
        {
            _localizer = localizer;
        }

        public override string AppName => $" {_localizer["fas fa-landmark"]} {_localizer["Pre-Accounting"]}";
    }
}
