
namespace AbcYazilim.OnMuhasebe.Ogrenciler;
public class OgrenciManager : DomainService
{   
    private readonly IOgrenciRepository _ogrenciRepository;
    public OgrenciManager(IOgrenciRepository ogrenciRepository)
    {
        _ogrenciRepository = ogrenciRepository;
    }
    public async Task CheckCreateAsync(string kod)
    {
        await _ogrenciRepository.KodAnyAsync(kod, x => x.Kod == kod);
    }

    public async Task CheckUpdateAsync(Guid id, string kod, Ogrenci entity)
    {
        await _ogrenciRepository.KodAnyAsync(kod, x => x.Id != id && x.Kod == kod,
            entity.Kod != kod);

    }
}
