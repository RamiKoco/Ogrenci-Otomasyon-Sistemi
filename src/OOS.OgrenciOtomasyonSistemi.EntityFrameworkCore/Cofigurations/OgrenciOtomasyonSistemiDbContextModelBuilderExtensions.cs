
namespace OOS.OgrenciOtomasyonSistemi.Cofigurations;
public static class OgrenciOtomasyonSistemiDbContextModelBuilderExtensions
{
    public static void ConfigureOgrenci(this ModelBuilder builder)
    {
        builder.Entity<Ogrenci>(b =>
        {
            b.ToTable(OgrenciOtomasyonSistemiConsts.DbTablePrefix + "Ogrenciler", OgrenciOtomasyonSistemiConsts.DbSchema);
            b.ConfigureByConvention();

            //properties
            b.Property(x => x.Kod)
                .IsRequired()
               .HasColumnType("varchar")
               .HasMaxLength(EntityConsts.MaxKodLength);

            b.Property(x => x.Ad)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(EntityConsts.MaxAdLength);

            b.Property(x => x.Soyad)
                .HasColumnType("varchar")
                .HasMaxLength(EntityConsts.MaxAdLength);

            b.Property(x => x.KimlikGT)               
               .HasColumnType("date");

            b.Property(x => x.SeriNo)               
               .HasColumnType("varchar")
               .HasMaxLength(EntityConsts.MaxSeriNoLength);          

            b.Property(x => x.AnneAd)
               .HasColumnType("varchar")
               .HasMaxLength(EntityConsts.MaxAdLength);

            b.Property(x => x.BabaAd)
               .HasColumnType("varchar")
               .HasMaxLength(EntityConsts.MaxAdLength);

            b.Property(x => x.TCNo)
              .HasColumnType("varchar")
              .HasMaxLength(EntityConsts.MaxTCNoLength);          

            b.Property(x => x.Image)
             .HasColumnType("varchar")
             .HasMaxLength(EntityConsts.MaxAdLength);

            b.Property(x => x.Telefon)
                .HasColumnType("varchar")
                .HasMaxLength(EntityConsts.MaxTelefonLength);         

            b.Property(x => x.Email)
               .HasColumnType("varchar")
               .HasMaxLength(EntityConsts.MaxEmailLength);           

            b.Property(x => x.DogumTarihi)
               .IsRequired()
               .HasColumnType("date");

            b.Property(x => x.DogumYeri)
              .HasColumnType("varchar")
              .HasMaxLength(EntityConsts.MaxAdLength);
           
            b.Property(x => x.Cinsiyet)
             .HasColumnType("smallint");

            b.Property(x => x.KanGrubu)
              .HasColumnType("smallint");

            b.Property(x => x.OzelKod1Id)
               .HasColumnType("uuid");

            b.Property(x => x.OzelKod2Id)
                .HasColumnType("uuid");

            b.Property(x => x.Aciklama)
                .HasColumnType("varchar")
                .HasMaxLength(EntityConsts.MaxAciklamaLength);
            
            b.Property(x => x.Durum)
                .HasColumnType("boolean");

            //indexs
            b.HasIndex(x => x.Kod);

            //relations    
            b.HasOne(x => x.OzelKod1)
           .WithMany(x => x.OzelKod1Ogrenciler)
           .OnDelete(DeleteBehavior.NoAction);

            b.HasOne(x => x.OzelKod2)
                .WithMany(x => x.OzelKod2Ogrenciler)
                .OnDelete(DeleteBehavior.NoAction);
        });
    }

    public static void ConfigureOzelKod(this ModelBuilder builder)
    {
        builder.Entity<OzelKod>(b =>
        {
            b.ToTable(OgrenciOtomasyonSistemiConsts.DbTablePrefix + "OzelKodlar", OgrenciOtomasyonSistemiConsts.DbSchema);
            b.ConfigureByConvention();

            //properties
            b.Property(x => x.Kod)
             .IsRequired()
            .HasColumnType("varchar")
            .HasMaxLength(EntityConsts.MaxKodLength);

            b.Property(x => x.Ad)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(EntityConsts.MaxAdLength);          

            b.Property(x => x.KodTuru)
                .IsRequired()
                .HasColumnType("smallint");

            b.Property(x => x.KartTuru)
                .IsRequired()
                .HasColumnType("smallint");

            b.Property(x => x.Aciklama)
                .HasColumnType("varchar")
                .HasMaxLength(EntityConsts.MaxAciklamaLength);

            b.Property(x => x.Durum)
                .HasColumnType("boolean");

            //indexs
            b.HasIndex(x => x.Kod);

            //relations


        });
    }

}