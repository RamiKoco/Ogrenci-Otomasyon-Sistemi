namespace OOS.OgrenciOtomasyonSistemi.Data
{
    /* This is used if database provider does't define
     * IOgrenciOtomasyonSistemiDbSchemaMigrator implementation.
     */
    public class NullOgrenciOtomasyonSistemiDbSchemaMigrator : IOgrenciOtomasyonSistemiDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}