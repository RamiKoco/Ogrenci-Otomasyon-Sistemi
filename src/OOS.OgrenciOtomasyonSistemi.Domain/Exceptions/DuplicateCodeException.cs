namespace OOS.OgrenciOtomasyonSistemi.Exceptions;
public class DuplicateCodeException : BusinessException
{
    public DuplicateCodeException(string kod) : base(OgrenciOtomasyonSistemiDomainErrorCodes.DuplicateKod)
    {
        WithData("kod", kod);
    }
}