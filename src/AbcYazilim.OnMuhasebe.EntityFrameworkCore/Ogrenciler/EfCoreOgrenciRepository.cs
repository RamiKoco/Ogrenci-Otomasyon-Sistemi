
namespace AbcYazilim.OnMuhasebe.Ogrenciler;
public class EfCoreOgrenciRepository : EfCoreCommonRepository<Ogrenci>, IOgrenciRepository
{
    public EfCoreOgrenciRepository(IDbContextProvider<OnMuhasebeDbContext> dbContextProvider) 
        : base(dbContextProvider)
    {        
    }
}
