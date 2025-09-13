using Volo.Abp.Modularity;

namespace OOS.OgrenciOtomasyonSistemi;

[DependsOn(
    typeof(OgrenciOtomasyonSistemiDomainModule),
    typeof(OgrenciOtomasyonSistemiTestBaseModule)
)]
public class OgrenciOtomasyonSistemiDomainTestModule : AbpModule
{

}
