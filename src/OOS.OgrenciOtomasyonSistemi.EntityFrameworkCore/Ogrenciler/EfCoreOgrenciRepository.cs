
namespace OOS.OgrenciOtomasyonSistemi.Ogrenciler;
public class EfCoreOgrenciRepository : EfCoreCommonRepository<Ogrenci>, IOgrenciRepository
{
    public EfCoreOgrenciRepository(IDbContextProvider<OgrenciOtomasyonSistemiDbContext> dbContextProvider) 
        : base(dbContextProvider)
    {        
    }
}
