
namespace OOS.OgrenciOtomasyonSistemi.Ogretmenler;
public class EfCoreOgretmenRepository : EfCoreCommonRepository<Ogretmen>, IOgretmenRepository
{
    public EfCoreOgretmenRepository(IDbContextProvider<OgrenciOtomasyonSistemiDbContext> dbContextProvider)
            : base(dbContextProvider)
    {        
    }
}
