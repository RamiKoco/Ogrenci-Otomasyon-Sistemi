
namespace OOS.OgrenciOtomasyonSistemi.Blazor.Services;
public class OgretmenService : BaseService<ListOgretmenDto, SelectOgretmenDto>, IScopedDependency
{
    public void KanGrubuSelectedItemChanged(ComboBoxEnumItem<KanGrubu>
 selectedItem)
    {
        DataSource.KanGrubu = selectedItem.Value;
    }
    public void CinsiyetSelectedItemChanged(ComboBoxEnumItem<Cinsiyet>
    selectedItem)
    {
        DataSource.Cinsiyet = selectedItem.Value;
    }
    public override void SelectEntity(IEntityDto targetEntity)
    {
        base.SelectEntity(targetEntity);
    }
}
