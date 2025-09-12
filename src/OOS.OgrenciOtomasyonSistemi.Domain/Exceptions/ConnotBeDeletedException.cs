
namespace OOS.OgrenciOtomasyonSistemi.Exceptions;
public class ConnotBeDeletedException : BusinessException
{
    public ConnotBeDeletedException() : base(OgrenciOtomasyonSistemiDomainErrorCodes.ConnotBeDeleted)
    {
    }
}