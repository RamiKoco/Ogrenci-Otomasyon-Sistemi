
namespace OOS.OgrenciOtomasyonSistemi;

[DependsOn(
    typeof(OgrenciOtomasyonSistemiDomainModule),
    typeof(AbpAccountApplicationModule),
    typeof(OgrenciOtomasyonSistemiApplicationContractsModule),
    typeof(AbpIdentityApplicationModule),
    typeof(AbpPermissionManagementApplicationModule),
    typeof(AbpTenantManagementApplicationModule),
    typeof(AbpFeatureManagementApplicationModule),
    typeof(AbpSettingManagementApplicationModule)
    )]
public class OgrenciOtomasyonSistemiApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<OgrenciOtomasyonSistemiApplicationModule>();
        });
    }
}
