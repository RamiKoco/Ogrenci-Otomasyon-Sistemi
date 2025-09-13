using OOS.OgrenciOtomasyonSistemi.Localization;
using Volo.Abp.AspNetCore.Components;

namespace OOS.OgrenciOtomasyonSistemi.Blazor.WebApp.Tiered;

public abstract class OgrenciOtomasyonSistemiComponentBase : AbpComponentBase
{
    protected OgrenciOtomasyonSistemiComponentBase()
    {
        LocalizationResource = typeof(OgrenciOtomasyonSistemiResource);
    }
}
