using Volo.Abp.Modularity;

namespace OOS.OgrenciOtomasyonSistemi;

[DependsOn(
    typeof(OgrenciOtomasyonSistemiApplicationModule),
    typeof(OgrenciOtomasyonSistemiDomainTestModule)
)]
public class OgrenciOtomasyonSistemiApplicationTestModule : AbpModule
{

}
