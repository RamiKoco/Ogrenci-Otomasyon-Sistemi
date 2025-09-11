
namespace AbcYazilim.OnMuhasebe.Images;
public class CreateImageDtoValidator : AbstractValidator<CreateImageDto>
{
    public CreateImageDtoValidator(IStringLocalizer<OnMuhasebeResource> localizer)
    {
        RuleFor(x => x.Kod)
           .NotEmpty()
           .WithMessage(localizer[OnMuhasebeDomainErrorCodes.Required, localizer["Code"]])
           .MaximumLength(EntityConsts.MaxKodLength)
           .WithMessage(localizer[OnMuhasebeDomainErrorCodes.MaxLenght, localizer["Code"],
            EntityConsts.MaxKodLength]);

        RuleFor(x => x.FileName)
            .NotEmpty()
            .WithMessage(localizer[OnMuhasebeDomainErrorCodes.Required, localizer["FileName"]])
            .MaximumLength(EntityConsts.MaxAdLength)
            .WithMessage(localizer[OnMuhasebeDomainErrorCodes.MaxLenght, localizer["FileName"],
             EntityConsts.MaxAdLength]);

        RuleFor(x => x.FilePath)
           .NotEmpty()
           .WithMessage(localizer[OnMuhasebeDomainErrorCodes.Required, localizer["FilePath"]])
           .MaximumLength(EntityConsts.MaxAdLength)
           .WithMessage(localizer[OnMuhasebeDomainErrorCodes.MaxLenght, localizer["FilePath"],
            EntityConsts.MaxAdLength]);
    }
}
