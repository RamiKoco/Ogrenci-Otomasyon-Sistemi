
namespace OOS.OgrenciOtomasyonSistemi.Images;
public class UpdateImageDtoValidator : AbstractValidator<UpdateImageDto>
{
    public UpdateImageDtoValidator(IStringLocalizer<OgrenciOtomasyonSistemiResource> localizer)
    {
        RuleFor(x => x.Kod)
         .NotEmpty()
         .WithMessage(localizer[OgrenciOtomasyonSistemiDomainErrorCodes.Required, localizer["Code"]])
         .MaximumLength(EntityConsts.MaxKodLength)
         .WithMessage(localizer[OgrenciOtomasyonSistemiDomainErrorCodes.MaxLenght, localizer["Code"],
          EntityConsts.MaxKodLength]);

        RuleFor(x => x.FileName)
            .NotEmpty()
            .WithMessage(localizer[OgrenciOtomasyonSistemiDomainErrorCodes.Required, localizer["FileName"]])
            .MaximumLength(EntityConsts.MaxAdLength)
            .WithMessage(localizer[OgrenciOtomasyonSistemiDomainErrorCodes.MaxLenght, localizer["FileName"],
             EntityConsts.MaxAdLength]);

        RuleFor(x => x.FilePath)
           .NotEmpty()
           .WithMessage(localizer[OgrenciOtomasyonSistemiDomainErrorCodes.Required, localizer["FilePath"]])
           .MaximumLength(EntityConsts.MaxAdLength)
           .WithMessage(localizer[OgrenciOtomasyonSistemiDomainErrorCodes.MaxLenght, localizer["FilePath"],
            EntityConsts.MaxAdLength]);
    }
}
