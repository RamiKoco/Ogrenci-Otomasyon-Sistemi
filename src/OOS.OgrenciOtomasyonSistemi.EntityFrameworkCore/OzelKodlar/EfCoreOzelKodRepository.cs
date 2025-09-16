
namespace OOS.OgrenciOtomasyonSistemi.OzelKodlar;
public class EfCoreOzelKodRepository : EfCoreCommonRepository<OzelKod>, IOzelKodRepository
{
    public EfCoreOzelKodRepository(IDbContextProvider<OgrenciOtomasyonSistemiDbContext> dbContextProvider)
        : base(dbContextProvider)
    {
    }
}