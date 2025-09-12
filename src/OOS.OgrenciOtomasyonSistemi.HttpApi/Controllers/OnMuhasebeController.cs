using OOS.OgrenciOtomasyonSistemi.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace OOS.OgrenciOtomasyonSistemi.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class OgrenciOtomasyonSistemiController : AbpControllerBase
    {
        protected OgrenciOtomasyonSistemiController()
        {
            LocalizationResource = typeof(OgrenciOtomasyonSistemiResource);
        }
    }
}