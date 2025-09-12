using Volo.Abp.Application.Services;
namespace OOS.OgrenciOtomasyonSistemi.Services;
public interface ICodeAppService<in TGetCodeInput> : IApplicationService
{
    Task<string> GetCodeAsync(TGetCodeInput input);
}