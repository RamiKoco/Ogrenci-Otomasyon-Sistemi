using OOS.OgrenciOtomasyonSistemi.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace OOS.OgrenciOtomasyonSistemi.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(OgrenciOtomasyonSistemiEntityFrameworkCoreModule),
        typeof(OgrenciOtomasyonSistemiApplicationContractsModule)
        )]
    public class OgrenciOtomasyonSistemiDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
