1️⃣ Migration İşlemleri
Projeyi ilk kez ayağa kaldırmadan önce veritabanını oluşturmak için Entity Framework Core migration komutlarını çalıştırmanız gerekir.

a) Migration ekleme
Add-Migration InitialCreate

b) Veritabanını güncelleme
Update-Database

Bu işlemler sonucunda gerekli tablolar otomatik olarak oluşturulacaktır.

2️⃣ Varsayılan Kullanıcılar

Kurulum sonrası aşağıdaki kullanıcılar sistemde hazır gelir:

Kullanıcı Rolü	Kullanıcı Adı	Şifre
👨‍💼 Admin	Admin	Admin.123
🎓 Öğrenci	Ogrenci	Ogrenci.123
👩‍🏫 Öğretmen	Ogretmen	Ogretmen.123

3️⃣ Kullanıcı Rolleri

Admin
Kullanıcı yönetimi (ekleme, silme, yetkilendirme)
Sistem ayarları
Öğrenci
Ders programını görüntüleme
Notlarını takip etme
Öğretmen
Ders tanımlama
Öğrencilere not verme

**Kullanılacak Teknolojiler**
• Backend: .NET 9
• ORM: Entity Framework Core
• Frontend: Blazor
• Veritabanı: PostgreSQL
• Versiyon Kontrol: GitHub
