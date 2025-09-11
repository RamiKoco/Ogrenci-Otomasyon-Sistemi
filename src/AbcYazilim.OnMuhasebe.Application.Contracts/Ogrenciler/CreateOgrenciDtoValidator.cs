
namespace AbcYazilim.OnMuhasebe.Ogrenciler;
public class CreateOgrenciDtoValidator : AbstractValidator<CreateOgrenciDto>
{
    public CreateOgrenciDtoValidator(IStringLocalizer<OnMuhasebeResource> localizer)
    {
        RuleFor(x => x.Kod)
          .NotEmpty()
          .WithMessage(localizer[OnMuhasebeDomainErrorCodes.Required, localizer["Code"]])

          .MaximumLength(EntityConsts.MaxKodLength)
          .WithMessage(localizer[OnMuhasebeDomainErrorCodes.MaxLenght, localizer["Code"],
           EntityConsts.MaxKodLength]);

        RuleFor(x => x.Ad)
            .NotEmpty()
            .WithMessage(localizer[OnMuhasebeDomainErrorCodes.Required, localizer["Name"]])
            .MaximumLength(EntityConsts.MaxAdLength)
            .WithMessage(localizer[OnMuhasebeDomainErrorCodes.MaxLenght, localizer["Name"],
             EntityConsts.MaxAdLength]);

        RuleFor(x => x.Soyad)
            .MaximumLength(EntityConsts.MaxAdLength)
            .WithMessage(localizer[OnMuhasebeDomainErrorCodes.MaxLenght, localizer["Surname"],
             EntityConsts.MaxAdLength]);

        RuleFor(x => x.SeriNo)  
          .MaximumLength(EntityConsts.MaxSeriNoLength)
          .WithMessage(localizer[OnMuhasebeDomainErrorCodes.MaxLenght, localizer["DocumentNo"],
           EntityConsts.MaxSeriNoLength]);

        RuleFor(x => x.AnneAd)    
           .MaximumLength(EntityConsts.MaxAdLength)
           .WithMessage(localizer[OnMuhasebeDomainErrorCodes.MaxLenght, localizer["MotherName"],
            EntityConsts.MaxAdLength]);

        RuleFor(x => x.BabaAd)
           .MaximumLength(EntityConsts.MaxAdLength)
           .WithMessage(localizer[OnMuhasebeDomainErrorCodes.MaxLenght, localizer["FatherName"],
            EntityConsts.MaxAdLength]);

        RuleFor(x => x.TCNo)
          .MaximumLength(EntityConsts.MaxTCNoLength)
          .WithMessage(localizer[OnMuhasebeDomainErrorCodes.MaxLenght,
           localizer["IdNumber"]]);  

        RuleFor(x => x.Telefon)
            .MaximumLength(EntityConsts.MaxTelefonLength)
            .WithMessage(localizer[OnMuhasebeDomainErrorCodes.MaxLenght,
             localizer["Telephone"], EntityConsts.MaxTelefonLength]);

    
        RuleFor(x => x.Email)
           .MaximumLength(EntityConsts.MaxEmailLength)
           .WithMessage(localizer[OnMuhasebeDomainErrorCodes.MaxLenght,
            localizer["Email"], EntityConsts.MaxEmailLength]);     

        RuleFor(x => x.DogumYeri)
          .MaximumLength(EntityConsts.MaxAdLength)
          .WithMessage(localizer[OnMuhasebeDomainErrorCodes.MaxLenght, localizer["BirthPlace"],
           EntityConsts.MaxAdLength]);
               

        RuleFor(x => x.Cinsiyet)
          .IsInEnum()
          .WithMessage(localizer[OnMuhasebeDomainErrorCodes.Required,
           localizer["Gender"]])//Hesap Türü Alanı Zorunludur Msg.
          .NotEmpty()
          .WithMessage(localizer[OnMuhasebeDomainErrorCodes.Required,
           localizer["Gender"]]);

        RuleFor(x => x.KanGrubu)
          .IsInEnum()
          .WithMessage(localizer[OnMuhasebeDomainErrorCodes.Required,
           localizer["BloodGroup"]])//Hesap Türü Alanı Zorunludur Msg.
          .NotEmpty()
          .WithMessage(localizer[OnMuhasebeDomainErrorCodes.Required,
           localizer["BloodGroup"]]);
               

        RuleFor(x => x.Image)
        .MaximumLength(EntityConsts.MaxAdLength)
        .WithMessage(localizer[OnMuhasebeDomainErrorCodes.MaxLenght,
         localizer["Image"], EntityConsts.MaxAdLength]);     

        RuleFor(x => x.Aciklama)
      .MaximumLength(EntityConsts.MaxAciklamaLength)
      .WithMessage(localizer[OnMuhasebeDomainErrorCodes.MaxLenght,
       localizer["Description"], EntityConsts.MaxAciklamaLength]);
    }
}
