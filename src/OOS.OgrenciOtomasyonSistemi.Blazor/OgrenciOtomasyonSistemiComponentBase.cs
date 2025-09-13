using OOS.OgrenciOtomasyonSistemi.Localization;
using Volo.Abp.AspNetCore.Components;

namespace OOS.OgrenciOtomasyonSistemi.Blazor;

public abstract class OgrenciOtomasyonSistemiComponentBase : AbpComponentBase
{
    protected OgrenciOtomasyonSistemiComponentBase()
    {
        LocalizationResource = typeof(OgrenciOtomasyonSistemiResource);
    }
}
