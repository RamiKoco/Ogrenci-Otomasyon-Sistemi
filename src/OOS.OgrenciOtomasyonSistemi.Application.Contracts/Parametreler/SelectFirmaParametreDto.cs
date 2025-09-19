namespace OOS.OgrenciOtomasyonSistemi.Parametreler;
public class SelectFirmaParametreDto : EntityDto<Guid>
{
    public Guid OkulId { get; set; }
    public string OkulAdi { get; set; } 
    public Guid DonemId { get; set; }
    public string DonemAdi { get; set; }
}