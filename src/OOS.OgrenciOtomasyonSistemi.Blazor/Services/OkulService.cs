using OOS.OgrenciOtomasyonSistemi.Okullar;

namespace OOS.OgrenciOtomasyonSistemi.Blazor.Services;

public class OkulService : BaseService<ListOkulDto, SelectOkulDto>, IScopedDependency
{
    public override void SelectEntity(IEntityDto targetEntity)
    {
        base.SelectEntity(targetEntity);
    }
}
