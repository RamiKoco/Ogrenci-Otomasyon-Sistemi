
namespace OOS.OgrenciOtomasyonSistemi.Donemler;
public class EfCoreDonemRepository : EfCoreCommonRepository<Donem>, IDonemRepository
{
    public EfCoreDonemRepository(IDbContextProvider<OgrenciOtomasyonSistemiDbContext> dbContextProvider)
        : base(dbContextProvider)
    {
    }
}