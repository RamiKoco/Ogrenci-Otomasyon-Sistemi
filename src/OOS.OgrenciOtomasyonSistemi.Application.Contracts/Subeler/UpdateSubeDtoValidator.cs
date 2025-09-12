
namespace OOS.OgrenciOtomasyonSistemi.Subeler;
public class UpdateSubeDtoValidator : AbstractValidator<UpdateSubeDto>
{
    public UpdateSubeDtoValidator(IStringLocalizer<OgrenciOtomasyonSistemiResource> localizer)
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

        RuleFor(x => x.Aciklama)
            .MaximumLength(EntityConsts.MaxAciklamaLength)
            .WithMessage(localizer[OgrenciOtomasyonSistemiDomainErrorCodes.MaxLenght,
             localizer["Description"], EntityConsts.MaxAciklamaLength]);
    }
}