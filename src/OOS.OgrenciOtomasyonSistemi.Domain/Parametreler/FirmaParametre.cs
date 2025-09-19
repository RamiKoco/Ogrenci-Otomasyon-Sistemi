
namespace OOS.OgrenciOtomasyonSistemi.Parametreler;
public class FirmaParametre : Entity<Guid>
{
    public Guid UserId { get; set; }
    public Guid OkulId { get; set; }   
    public Guid DonemId { get; set; }
    public IdentityUser User { get; set; }
    public Okul Okul { get; set; }    
    public Donem Donem { get; set; } 
}