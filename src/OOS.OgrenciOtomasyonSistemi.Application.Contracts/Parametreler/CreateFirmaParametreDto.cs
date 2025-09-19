
namespace OOS.OgrenciOtomasyonSistemi.Parametreler;
public class CreateFirmaParametreDto : IEntityDto
{
    public Guid UserId { get; set; }
    public Guid OkulId { get; set; }
    public Guid DonemId { get; set; }
}