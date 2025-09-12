
namespace OOS.OgrenciOtomasyonSistemi
{
    /* Inherit your application services from this class.
     */
    public abstract class OgrenciOtomasyonSistemiAppService : ApplicationService
    {
        protected OgrenciOtomasyonSistemiAppService()
        {
            LocalizationResource = typeof(OgrenciOtomasyonSistemiResource);
        }
    }
}
