namespace OOS.OgrenciOtomasyonSistemi.Blazor.Pages.Ogretmenler;

public partial class OgretmenListPage
{
    public AppService AppService { get; set; }

    protected override async Task GetListDataSourceAsync()
    {
        var listDataSource = (await GetListAsync(new OgretmenListParameterDto
        {
            Durum = Service.IsActiveCards

        }))?.Items.ToList();

        Service.IsLoaded = true;

        if (listDataSource != null)
            Service.ListDataSource = listDataSource;

    }
    protected override async Task BeforeInsertAsync()
    {
        Service.DataSource = new SelectOgretmenDto
        {
            Kod = await GetCodeAsync(new CodeParameterDto
            {
                Durum = Service.IsActiveCards
            }),


            KanGrubu = KanGrubu.APozitif,
            Cinsiyet = Cinsiyet.Erkek,
            Durum = Service.IsActiveCards
        };

        Service.ShowEditPage();
    }
}
