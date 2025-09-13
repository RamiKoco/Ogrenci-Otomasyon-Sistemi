using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OOS.OgrenciOtomasyonSistemi.Data;
using Volo.Abp.DependencyInjection;

namespace OOS.OgrenciOtomasyonSistemi.EntityFrameworkCore;

public class EntityFrameworkCoreOgrenciOtomasyonSistemiDbSchemaMigrator
    : IOgrenciOtomasyonSistemiDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreOgrenciOtomasyonSistemiDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the OgrenciOtomasyonSistemiDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<OgrenciOtomasyonSistemiDbContext>()
            .Database
            .MigrateAsync();
    }
}
