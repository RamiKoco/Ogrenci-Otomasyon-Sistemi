
namespace OOS.OgrenciOtomasyonSistemi.Blazor.Services;
public class AppService : ICoreAppService, IScopedDependency
{
   
    public Action HasChanged { get; set; }
    public bool ShowFirmaParametreEditPage { get; set; }
    public bool ShowSubeDonemEditPage { get; set; }
}