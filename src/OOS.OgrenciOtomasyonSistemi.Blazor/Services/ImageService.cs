
namespace OOS.OgrenciOtomasyonSistemi.Blazor.Services;
public class ImageService : BaseService<ListImageDto, SelectImageDto>, IScopedDependency
{
    public override void SelectEntity(IEntityDto targetEntity)
    {
        base.SelectEntity(targetEntity);
    }
}
