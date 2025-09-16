
namespace OOS.OgrenciOtomasyonSistemi.OzelKodlar;
public class CreateOzelKodDtoValidator : AbstractValidator<CreateOzelKodDto>
{
    public CreateOzelKodDtoValidator(IStringLocalizer<OgrenciOtomasyonSistemiResource> localizer)
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

        RuleFor(x => x.KodTuru)
            .IsInEnum()
            .WithMessage(localizer[OgrenciOtomasyonSistemiDomainErrorCodes.Required,
             localizer["CodeType"]])

            .NotEmpty()
            .WithMessage(localizer[OgrenciOtomasyonSistemiDomainErrorCodes.Required,
             localizer["CodeType"]]);

        RuleFor(x => x.KartTuru)
            .IsInEnum()
            .WithMessage(localizer[OgrenciOtomasyonSistemiDomainErrorCodes.Required,
             localizer["CardType"]])

            .NotEmpty()
            .WithMessage(localizer[OgrenciOtomasyonSistemiDomainErrorCodes.Required,
             localizer["CardType"]]);

        RuleFor(x => x.Aciklama)
            .MaximumLength(EntityConsts.MaxAciklamaLength)
            .WithMessage(localizer[OgrenciOtomasyonSistemiDomainErrorCodes.MaxLenght,
             localizer["Description"], EntityConsts.MaxAciklamaLength]);
    }
}