using System.Threading.Tasks;

namespace OOS.OgrenciOtomasyonSistemi.Data;

public interface IOgrenciOtomasyonSistemiDbSchemaMigrator
{
    Task MigrateAsync();
}
