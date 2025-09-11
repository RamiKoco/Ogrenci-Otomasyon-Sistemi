
namespace AbcYazilim.OnMuhasebe
{
    /* Inherit your application services from this class.
     */
    public abstract class OnMuhasebeAppService : ApplicationService
    {
        protected OnMuhasebeAppService()
        {
            LocalizationResource = typeof(OnMuhasebeResource);
        }
    }
}
