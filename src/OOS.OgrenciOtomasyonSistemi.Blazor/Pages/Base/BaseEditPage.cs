
namespace OOS.OgrenciOtomasyonSistemi.Blazor.Pages.Base;
public abstract class BaseEditPage : AbpComponentBase
{
    public BaseEditPage()
    {
        LocalizationResource = typeof(OgrenciOtomasyonSistemiResource);
    }

    [Parameter] public EventCallback OnSubmit { get; set; }
}