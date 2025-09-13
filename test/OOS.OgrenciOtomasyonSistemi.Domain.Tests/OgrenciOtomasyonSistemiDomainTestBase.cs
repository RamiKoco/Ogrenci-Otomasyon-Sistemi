using Volo.Abp.Modularity;

namespace OOS.OgrenciOtomasyonSistemi;

/* Inherit from this class for your domain layer tests. */
public abstract class OgrenciOtomasyonSistemiDomainTestBase<TStartupModule> : OgrenciOtomasyonSistemiTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
