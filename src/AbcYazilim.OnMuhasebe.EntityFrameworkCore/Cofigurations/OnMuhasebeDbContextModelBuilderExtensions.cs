
namespace AbcYazilim.OnMuhasebe.Cofigurations;
public static class OnMuhasebeDbContextModelBuilderExtensions
{

    public static void ConfigureDonem(this ModelBuilder builder)
    {
        builder.Entity<Donem>(b =>
        {
            b.ToTable(OnMuhasebeConsts.DbTablePrefix + "Donemler", OnMuhasebeConsts.DbSchema);
            b.ConfigureByConvention();

            //properties
            b.Property(x => x.Kod)
                .IsRequired()
                .HasColumnType(SqlDbType.VarChar.ToString())
                .HasMaxLength(EntityConsts.MaxKodLength);

            b.Property(x => x.Ad)
                .IsRequired()
                .HasColumnType(SqlDbType.VarChar.ToString())
                .HasMaxLength(EntityConsts.MaxAciklamaLength);

            b.Property(x => x.Aciklama)
                .HasColumnType(SqlDbType.VarChar.ToString())
                .HasMaxLength(EntityConsts.MaxAciklamaLength);

            b.Property(x => x.Durum)
                .HasColumnType(SqlDbType.Bit.ToString());

            //indexs
            b.HasIndex(x => x.Kod);

            //relations
        });
    }
    public static void ConfigureFirmaParametre(this ModelBuilder builder)
    {
        builder.Entity<FirmaParametre>(b =>
        {
            b.ToTable(OnMuhasebeConsts.DbTablePrefix + "FirmaParametreler", OnMuhasebeConsts.DbSchema);
            b.ConfigureByConvention();

            //properties
            b.Property(x => x.UserId)
                .IsRequired()
                .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.SubeId)
                .IsRequired()
                .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.NoktaId)                
                .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.DonemId)
                .IsRequired()
                .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.DepoId)
                .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            //indexs

            //relations
            b.HasOne(x => x.User)
                .WithOne()
                .HasForeignKey<FirmaParametre>(x => x.UserId);

            b.HasOne(x => x.Sube)
                .WithMany(x => x.FirmaParemetreler)
                .OnDelete(DeleteBehavior.NoAction);

            b.HasOne(x => x.Donem)
                .WithMany(x => x.FirmaParametreler)
                .OnDelete(DeleteBehavior.NoAction);

        });
    }
    public static void ConfigureOgrenci(this ModelBuilder builder)
    {
        builder.Entity<Ogrenci>(b =>
        {
            b.ToTable(OnMuhasebeConsts.DbTablePrefix + "Ogrenciler", OnMuhasebeConsts.DbSchema);
            b.ConfigureByConvention();

            //properties
            b.Property(x => x.Kod)
                .IsRequired()
                .HasColumnType(SqlDbType.VarChar.ToString())
                .HasMaxLength(EntityConsts.MaxKodLength);

            b.Property(x => x.Ad)
                .IsRequired()
                .HasColumnType(SqlDbType.VarChar.ToString())
                .HasMaxLength(EntityConsts.MaxAdLength);

            b.Property(x => x.Soyad)
                .HasColumnType(SqlDbType.VarChar.ToString())
                .HasMaxLength(EntityConsts.MaxAdLength);

            b.Property(x => x.KimlikGT)               
               .HasColumnType(SqlDbType.Date.ToString());

            b.Property(x => x.SeriNo)               
               .HasColumnType(SqlDbType.VarChar.ToString())
               .HasMaxLength(EntityConsts.MaxSeriNoLength);          

            b.Property(x => x.AnneAd)
               .HasColumnType(SqlDbType.VarChar.ToString())
               .HasMaxLength(EntityConsts.MaxAdLength);

            b.Property(x => x.BabaAd)
               .HasColumnType(SqlDbType.VarChar.ToString())
               .HasMaxLength(EntityConsts.MaxAdLength);

            b.Property(x => x.TCNo)
              .HasColumnType(SqlDbType.VarChar.ToString())
              .HasMaxLength(EntityConsts.MaxTCNoLength);          

            b.Property(x => x.Image)
             .HasColumnType(SqlDbType.VarChar.ToString())
             .HasMaxLength(EntityConsts.MaxAdLength);

            b.Property(x => x.Telefon)
                .HasColumnType(SqlDbType.VarChar.ToString())
                .HasMaxLength(EntityConsts.MaxTelefonLength);         

            b.Property(x => x.Email)
               .HasColumnType(SqlDbType.VarChar.ToString())
               .HasMaxLength(EntityConsts.MaxEmailLength);           

            b.Property(x => x.DogumTarihi)
               .IsRequired()
               .HasColumnType(SqlDbType.Date.ToString());

            b.Property(x => x.DogumYeri)
              .HasColumnType(SqlDbType.VarChar.ToString())
              .HasMaxLength(EntityConsts.MaxAdLength);
           
            b.Property(x => x.Cinsiyet)
             .HasColumnType(SqlDbType.TinyInt.ToString());

            b.Property(x => x.KanGrubu)
              .HasColumnType(SqlDbType.TinyInt.ToString());

            b.Property(x => x.OzelKod1Id)
               .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.OzelKod2Id)
                .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.Aciklama)
                .HasColumnType(SqlDbType.VarChar.ToString())
                .HasMaxLength(EntityConsts.MaxAciklamaLength);

            b.Property(x => x.Durum)
                .HasColumnType(SqlDbType.Bit.ToString());

            //indexs
            b.HasIndex(x => x.Kod);

            //relations    
          
        });
    }
    public static void ConfigureSube(this ModelBuilder builder)
    {
        builder.Entity<Sube>(b =>
        {
            b.ToTable(OnMuhasebeConsts.DbTablePrefix + "Subeler", OnMuhasebeConsts.DbSchema);
            b.ConfigureByConvention();

            //properties
            b.Property(x => x.Kod)
                .IsRequired()
                .HasColumnType(SqlDbType.VarChar.ToString())
                .HasMaxLength(EntityConsts.MaxKodLength);

            b.Property(x => x.Ad)
                .IsRequired()
                .HasColumnType(SqlDbType.VarChar.ToString())
                .HasMaxLength(EntityConsts.MaxAdLength);

            b.Property(x => x.Aciklama)
                .HasColumnType(SqlDbType.VarChar.ToString())
                .HasMaxLength(EntityConsts.MaxAciklamaLength);

            b.Property(x => x.Durum)
                .HasColumnType(SqlDbType.Bit.ToString());

            //indexs
            b.HasIndex(x => x.Kod);

            //relations
        });
    }
    public static void ConfigureImage(this ModelBuilder builder)
    {
        builder.Entity<Image>(b =>
        {
            b.ToTable(OnMuhasebeConsts.DbTablePrefix + "Images", OnMuhasebeConsts.DbSchema);
            b.ConfigureByConvention();

            //properties
            b.Property(x => x.Kod)
                .IsRequired()
                .HasColumnType(SqlDbType.VarChar.ToString())
                .HasMaxLength(EntityConsts.MaxKodLength);

            b.Property(x => x.FileName)
                .HasColumnType(SqlDbType.VarChar.ToString())
                .HasMaxLength(EntityConsts.MaxAdLength);

            b.Property(x => x.FilePath)
                 .HasColumnType(SqlDbType.VarChar.ToString())
                 .HasMaxLength(EntityConsts.MaxAdLength);

            b.Property(x => x.Durum)
                .HasColumnType(SqlDbType.Bit.ToString());

            //indexs
            b.HasIndex(x => x.Kod);

            //relations

        });
    }
}