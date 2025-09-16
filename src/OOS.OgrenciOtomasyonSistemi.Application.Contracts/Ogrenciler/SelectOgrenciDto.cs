
namespace OOS.OgrenciOtomasyonSistemi.Ogrenciler;
public class SelectOgrenciDto : EntityDto<Guid>,IOzelKod
{
    public string Kod { get; set; }
    public string Ad { get; set; }
    public string Soyad { get; set; }

    public string Image { get; set; }
    public DateTime KimlikGT { get; set; }= DateTime.Today.AddYears(1);
    public string SeriNo { get; set; }

    public string TCNo { get; set; }
    public string Telefon { get; set; } 
    public string Email { get; set; }
    public string AnneAd { get; set; }
    public string BabaAd { get; set; }
    public DateTime DogumTarihi { get; set; } = new DateTime(2000, DateTime.Today.Month, DateTime.Today.Day);
    public string DogumYeri { get; set; }
    public Cinsiyet Cinsiyet { get; set; }
    public KanGrubu KanGrubu { get; set; }
    public Guid SubeId { get; set; }
    public Guid? OzelKod1Id { get; set; }
    public string OzelKod1Adi { get; set; }
    public Guid? OzelKod2Id { get; set; }
    public string OzelKod2Adi { get; set; }
    public string Aciklama { get; set; }
    public bool Durum { get; set; }
}
