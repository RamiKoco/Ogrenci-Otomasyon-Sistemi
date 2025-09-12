namespace OOS.OgrenciOtomasyonSistemi.Subeler;
public class SubeManager : DomainService
{
    private readonly ISubeRepository _subeRepository;

    public SubeManager(ISubeRepository subeRepository)
    {
        _subeRepository = subeRepository;
    }

    public async Task CheckCreateAsync(string kod)
    {
        await _subeRepository.KodAnyAsync(kod, x => x.Kod == kod);
    }

    public async Task CheckUpdateAsync(Guid id, string kod, Sube entity)
    {
        await _subeRepository.KodAnyAsync(kod, x => x.Id != id && x.Kod == kod,
            entity.Kod != kod);
    }

}