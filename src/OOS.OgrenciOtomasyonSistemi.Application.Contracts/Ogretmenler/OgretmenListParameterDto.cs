
namespace OOS.OgrenciOtomasyonSistemi.Ogretmenler;
public class OgretmenListParameterDto : PagedResultRequestDto, IDurum, IEntityDto
{
    public Guid SubeId { get; set; }
    public bool Durum { get; set; }
    public override int MaxResultCount { get; set; } = MaxMaxResultCount = 5000;
}
