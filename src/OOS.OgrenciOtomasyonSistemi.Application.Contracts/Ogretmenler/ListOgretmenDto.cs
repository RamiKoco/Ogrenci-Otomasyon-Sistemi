
using OOS.OgrenciOtomasyonSistemi.Ogrenciler;

namespace OOS.OgrenciOtomasyonSistemi.Ogretmenler;
public class ListOgretmenDto : EntityDto<Guid>
{
    public string Kod { get; set; }
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public string Image { get; set; }
    public string OzelKod1Adi { get; set; }
    public string OzelKod2Adi { get; set; }
    public KanGrubu KanGrubu { get; set; }
    public Cinsiyet Cinsiyet { get; set; }
    public string Aciklama { get; set; }
    public bool Durum { get; set; }
}
