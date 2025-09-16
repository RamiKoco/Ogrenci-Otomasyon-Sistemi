
namespace OOS.OgrenciOtomasyonSistemi;

[DependsOn(
    typeof(OgrenciOtomasyonSistemiDomainSharedModule),
    typeof(AbpAccountApplicationContractsModule),
    typeof(AbpFeatureManagementApplicationContractsModule),
    typeof(AbpIdentityApplicationContractsModule),
    typeof(AbpPermissionManagementApplicationContractsModule),
    typeof(AbpSettingManagementApplicationContractsModule),
    typeof(AbpTenantManagementApplicationContractsModule),
    typeof(AbpObjectExtendingModule)
)]
public class OgrenciOtomasyonSistemiApplicationContractsModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        OgrenciOtomasyonSistemiDtoExtensions.Configure();
    }
}
