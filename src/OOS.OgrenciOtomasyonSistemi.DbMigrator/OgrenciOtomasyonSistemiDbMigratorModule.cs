using OOS.OgrenciOtomasyonSistemi.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace OOS.OgrenciOtomasyonSistemi.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(OgrenciOtomasyonSistemiEntityFrameworkCoreModule),
    typeof(OgrenciOtomasyonSistemiApplicationContractsModule)
    )]
public class OgrenciOtomasyonSistemiDbMigratorModule : AbpModule
{
}
