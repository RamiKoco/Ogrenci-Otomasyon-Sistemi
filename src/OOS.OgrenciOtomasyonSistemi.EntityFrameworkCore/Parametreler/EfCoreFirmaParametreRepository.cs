
namespace OOS.OgrenciOtomasyonSistemi.Parametreler;
public class EfCoreFirmaParametreRepository : EfCoreCommonRepository<FirmaParametre>, IFirmaParametreRepository
{
    public EfCoreFirmaParametreRepository(IDbContextProvider<OgrenciOtomasyonSistemiDbContext> dbContextProvider)
        : base(dbContextProvider)
    {
    }
}
