
namespace OOS.OgrenciOtomasyonSistemi.Images;
public class ListImageDto : EntityDto<Guid>
{
    public string Kod { get; set; }
    public string FileName { get; set; }
    public string FilePath { get; set; }
    public bool Durum { get; set; }
}
