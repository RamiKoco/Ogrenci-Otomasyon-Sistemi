
namespace AbcYazilim.OnMuhasebe.Blazor
{
    [Dependency(ReplaceServices = true)]
    public class OnMuhasebeBrandingProvider : DefaultBrandingProvider
    {
        private readonly IStringLocalizer<OnMuhasebeResource> _localizer;

        public OnMuhasebeBrandingProvider(IStringLocalizer<OnMuhasebeResource> localizer)
        {
            _localizer = localizer;
        }

        public override string AppName => $" {_localizer["fas fa-landmark"]} {_localizer["Pre-Accounting"]}";
    }
}
