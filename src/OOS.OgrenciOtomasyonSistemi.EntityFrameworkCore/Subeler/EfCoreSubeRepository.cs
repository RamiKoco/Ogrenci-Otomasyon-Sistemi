
namespace OOS.OgrenciOtomasyonSistemi.Subeler;
public class EfCoreSubeRepository : EfCoreCommonRepository<Sube>, ISubeRepository
{
    public EfCoreSubeRepository(IDbContextProvider<OgrenciOtomasyonSistemiDbContext> dbContextProvider) 
        : base(dbContextProvider)
    {
    }
}