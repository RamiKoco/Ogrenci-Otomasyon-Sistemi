
namespace AbcYazilim.OnMuhasebe
{
    [DependsOn(
        typeof(OnMuhasebeDomainModule),
        typeof(AbpAccountApplicationModule),
        typeof(OnMuhasebeApplicationContractsModule),
        typeof(AbpIdentityApplicationModule),
        typeof(AbpPermissionManagementApplicationModule),
        typeof(AbpTenantManagementApplicationModule),
        typeof(AbpFeatureManagementApplicationModule),
        typeof(AbpSettingManagementApplicationModule)
        )]
    public class OnMuhasebeApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<OnMuhasebeApplicationModule>();
            });
        }
    }
}
