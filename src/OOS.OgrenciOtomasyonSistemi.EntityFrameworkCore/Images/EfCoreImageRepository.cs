
namespace OOS.OgrenciOtomasyonSistemi.Images;
public class EfCoreImageRepository : EfCoreCommonRepository<Image>, IImageRepository
{
    public EfCoreImageRepository(IDbContextProvider<OgrenciOtomasyonSistemiDbContext> dbContextProvider) : base(dbContextProvider)
    {
        
    }
}
