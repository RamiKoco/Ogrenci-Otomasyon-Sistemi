
namespace OOS.OgrenciOtomasyonSistemi.Blazor.Components.Pages.Ogrenciler;
public partial class OgrenciListPage
{
    public AppService AppService { get; set; }

    protected override async Task GetListDataSourceAsync()
    {
        var listDataSource = (await GetListAsync(new OgrenciListParameterDto
        {
            Durum = Service.IsActiveCards                 

        }))?.Items.ToList();

        Service.IsLoaded = true;

        if (listDataSource != null)
            Service.ListDataSource = listDataSource;

    }
    protected override async Task BeforeInsertAsync()
    {
        Service.DataSource = new SelectOgrenciDto
        {
            Kod = await GetCodeAsync(new CodeParameterDto
            {               
                Durum = Service.IsActiveCards
            }),

            
            KanGrubu = KanGrubu.APozitif,
            Cinsiyet=Cinsiyet.Erkek,
            Durum = Service.IsActiveCards
        };

        Service.ShowEditPage();
    }
}
