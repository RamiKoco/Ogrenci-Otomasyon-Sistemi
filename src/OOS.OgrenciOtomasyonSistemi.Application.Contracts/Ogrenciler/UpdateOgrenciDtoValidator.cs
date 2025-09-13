
using FluentValidation;

namespace OOS.OgrenciOtomasyonSistemi.Ogrenciler;
public class UpdateOgrenciDtoValidator : AbstractValidator<UpdateOgrenciDto>
{
    public UpdateOgrenciDtoValidator(IStringLocalizer<OgrenciOtomasyonSistemiResource> localizer)
    {
        RuleFor(x => x.Kod)
           .NotEmpty()
           .WithMessage(localizer[OgrenciOtomasyonSistemiDomainErrorCodes.Required, localizer["Code"]])

           .MaximumLength(EntityConsts.MaxKodLength)
           .WithMessage(localizer[OgrenciOtomasyonSistemiDomainErrorCodes.MaxLenght, localizer["Code"],
            EntityConsts.MaxKodLength]);

        RuleFor(x => x.Ad)
            .NotEmpty()
            .WithMessage(localizer[OgrenciOtomasyonSistemiDomainErrorCodes.Required, localizer["Name"]])
            .MaximumLength(EntityConsts.MaxAdLength)
            .WithMessage(localizer[OgrenciOtomasyonSistemiDomainErrorCodes.MaxLenght, localizer["Name"],
             EntityConsts.MaxAdLength]);

        RuleFor(x => x.Soyad)
           .MaximumLength(EntityConsts.MaxAdLength)
           .WithMessage(localizer[OgrenciOtomasyonSistemiDomainErrorCodes.MaxLenght, localizer["Surname"],
            EntityConsts.MaxAdLength]);

        RuleFor(x => x.SeriNo)
       .MaximumLength(EntityConsts.MaxSeriNoLength)
       .WithMessage(localizer[OgrenciOtomasyonSistemiDomainErrorCodes.MaxLenght, localizer["DocumentNo"],
        EntityConsts.MaxSeriNoLength]);

        RuleFor(x => x.AnneAd)
          .MaximumLength(EntityConsts.MaxAdLength)
          .WithMessage(localizer[OgrenciOtomasyonSistemiDomainErrorCodes.MaxLenght, localizer["MotherName"],
           EntityConsts.MaxAdLength]);

        RuleFor(x => x.BabaAd)
           .MaximumLength(EntityConsts.MaxAdLength)
           .WithMessage(localizer[OgrenciOtomasyonSistemiDomainErrorCodes.MaxLenght, localizer["FatherName"],
            EntityConsts.MaxAdLength]);

        RuleFor(x => x.TCNo)
          .MaximumLength(EntityConsts.MaxTCNoLength)
          .WithMessage(localizer[OgrenciOtomasyonSistemiDomainErrorCodes.MaxLenght,
           localizer["IdNumber"]]);

        RuleFor(x => x.Telefon)
            .MaximumLength(EntityConsts.MaxTelefonLength)
            .WithMessage(localizer[OgrenciOtomasyonSistemiDomainErrorCodes.MaxLenght,
             localizer["Telephone"], EntityConsts.MaxTelefonLength]);
      

        RuleFor(x => x.Email)
           .MaximumLength(EntityConsts.MaxEmailLength)
           .WithMessage(localizer[OgrenciOtomasyonSistemiDomainErrorCodes.MaxLenght,
            localizer["Email"], EntityConsts.MaxEmailLength]);

        RuleFor(x => x.DogumYeri)
        .MaximumLength(EntityConsts.MaxAdLength)
        .WithMessage(localizer[OgrenciOtomasyonSistemiDomainErrorCodes.MaxLenght, localizer["BirthPlace"],
         EntityConsts.MaxAdLength]);

        RuleFor(x => x.Cinsiyet)
          .IsInEnum()
          .WithMessage(localizer[OgrenciOtomasyonSistemiDomainErrorCodes.Required,
           localizer["Gender"]])//Hesap Türü Alanı Zorunludur Msg.
          .NotEmpty()
          .WithMessage(localizer[OgrenciOtomasyonSistemiDomainErrorCodes.Required,
           localizer["Gender"]]);

        RuleFor(x => x.KanGrubu)
          .IsInEnum()
          .WithMessage(localizer[OgrenciOtomasyonSistemiDomainErrorCodes.Required,
           localizer["BloodGroup"]])//Hesap Türü Alanı Zorunludur Msg.
          .NotEmpty()
          .WithMessage(localizer[OgrenciOtomasyonSistemiDomainErrorCodes.Required,
           localizer["BloodGroup"]]);
      
        RuleFor(x => x.Image)
       .MaximumLength(EntityConsts.MaxAdLength)
       .WithMessage(localizer[OgrenciOtomasyonSistemiDomainErrorCodes.MaxLenght,
        localizer["Image"], EntityConsts.MaxAdLength]);
    

        RuleFor(x => x.Aciklama)
          .MaximumLength(EntityConsts.MaxAciklamaLength)
          .WithMessage(localizer[OgrenciOtomasyonSistemiDomainErrorCodes.MaxLenght,
           localizer["Description"], EntityConsts.MaxAciklamaLength]);
    }
}
