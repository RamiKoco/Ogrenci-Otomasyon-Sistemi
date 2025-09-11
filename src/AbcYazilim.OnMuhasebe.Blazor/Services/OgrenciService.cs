
namespace AbcYazilim.OnMuhasebe.Blazor.Services;
public class OgrenciService : BaseService<ListOgrenciDto, SelectOgrenciDto>, IScopedDependency
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
