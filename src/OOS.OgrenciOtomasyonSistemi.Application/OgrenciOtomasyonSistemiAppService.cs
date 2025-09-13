using System;
using System.Collections.Generic;
using System.Text;
using OOS.OgrenciOtomasyonSistemi.Localization;
using Volo.Abp.Application.Services;

namespace OOS.OgrenciOtomasyonSistemi;

/* Inherit your application services from this class.
 */
public abstract class OgrenciOtomasyonSistemiAppService : ApplicationService
{
    protected OgrenciOtomasyonSistemiAppService()
    {
        LocalizationResource = typeof(OgrenciOtomasyonSistemiResource);
    }
}
