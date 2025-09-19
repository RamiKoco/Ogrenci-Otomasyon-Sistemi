
namespace OOS.OgrenciOtomasyonSistemi.Blazor.Services;
public class OkulService : BaseService<ListOkulDto, SelectOkulDto>, IScopedDependency
{
    public override void SelectEntity(IEntityDto targetEntity)
    {       
        switch (targetEntity)
        {
            case SelectFirmaParametreDto firmaParametre:
                firmaParametre.OkulId = SelectedItem.Id;
                firmaParametre.OkulAdi = SelectedItem.Ad;
                break;
        }
    }
}
