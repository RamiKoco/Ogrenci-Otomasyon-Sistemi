
namespace OOS.OgrenciOtomasyonSistemi.Okullar;
public class EfCoreOkulRepository : EfCoreCommonRepository<Okul>, IOkulRepository
{
    public EfCoreOkulRepository(IDbContextProvider<OgrenciOtomasyonSistemiDbContext> dbContextProvider)
         : base(dbContextProvider)
    {        
    }
}
