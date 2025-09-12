using System.IO;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace OOS.OgrenciOtomasyonSistemi.EntityFrameworkCore
{
    public class OgrenciOtomasyonSistemiDbContextFactory : IDesignTimeDbContextFactory<OgrenciOtomasyonSistemiDbContext>
    {
        public OgrenciOtomasyonSistemiDbContext CreateDbContext(string[] args)
        {
            OgrenciOtomasyonSistemiEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<OgrenciOtomasyonSistemiDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new OgrenciOtomasyonSistemiDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../OOS.OgrenciOtomasyonSistemi.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
