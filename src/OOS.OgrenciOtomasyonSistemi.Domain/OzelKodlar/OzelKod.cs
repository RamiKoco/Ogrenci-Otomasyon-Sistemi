using OOS.OgrenciOtomasyonSistemi.Ogrenciler;

namespace OOS.OgrenciOtomasyonSistemi.OzelKodlar;
public class OzelKod : FullAuditedAggregateRoot<Guid>
{
    public string Kod { get; set; }
    public string Ad { get; set; }
    public OzelKodTuru KodTuru { get; set; }
    public KartTuru KartTuru { get; set; }
    public string Aciklama { get; set; }
    public bool Durum { get; set; }
    public ICollection<Ogrenci> OzelKod1Ogrenciler { get; set; }
    public ICollection<Ogrenci> OzelKod2Ogrenciler { get; set; } 
}