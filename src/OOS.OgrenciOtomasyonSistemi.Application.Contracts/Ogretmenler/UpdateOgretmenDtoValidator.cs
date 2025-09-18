using OOS.OgrenciOtomasyonSistemi.Ogrenciler;

namespace OOS.OgrenciOtomasyonSistemi.Ogretmenler;
public class UpdateOgretmenDtoValidator : AbstractValidator<UpdateOgrenciDto>
{
    public UpdateOgretmenDtoValidator(IStringLocalizer<OgrenciOtomasyonSistemiResource> localizer)
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
