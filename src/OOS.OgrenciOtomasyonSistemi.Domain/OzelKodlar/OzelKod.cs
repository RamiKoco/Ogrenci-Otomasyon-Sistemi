using OOS.OgrenciOtomasyonSistemi.Ogrenciler;
using OOS.OgrenciOtomasyonSistemi.Ogretmenler;
using OOS.OgrenciOtomasyonSistemi.Okullar;

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
    public ICollection<Okul> OzelKod1Okullar { get; set; }
    public ICollection<Okul> OzelKod2Okullar { get; set; }
    public ICollection<Ogretmen> OzelKod1Ogretmenler { get; set; }
    public ICollection<Ogretmen> OzelKod2Ogretmenler { get; set; }
}