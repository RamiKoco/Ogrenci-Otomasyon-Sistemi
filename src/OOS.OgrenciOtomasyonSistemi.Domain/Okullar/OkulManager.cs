
namespace OOS.OgrenciOtomasyonSistemi.Okullar;
public class OkulManager : DomainService
{
    private readonly IOkulRepository _okulRepository;
    private readonly IOzelKodRepository _ozelKodRepository;
    public OkulManager(IOkulRepository okulRepository, IOzelKodRepository ozelKodRepository)
    {
        _okulRepository = okulRepository;
        _ozelKodRepository = ozelKodRepository;
    }
    public async Task CheckCreateAsync(string kod, Guid? ozelKod1Id, Guid? ozelKod2Id)
    {
        await _okulRepository.KodAnyAsync(kod, x => x.Kod == kod);

        await _ozelKodRepository.EntityAnyAsync(ozelKod1Id, OzelKodTuru.OzelKod1,
            KartTuru.Okul);

        await _ozelKodRepository.EntityAnyAsync(ozelKod2Id, OzelKodTuru.OzelKod2,
            KartTuru.Okul);

    }
    public async Task CheckUpdateAsync(Guid id, string kod, Okul entity, Guid? ozelKod1Id, Guid? ozelKod2Id)
    {
        await _okulRepository.KodAnyAsync(kod, x => x.Id != id && x.Kod == kod,
            entity.Kod != kod);

        await _ozelKodRepository.EntityAnyAsync(ozelKod1Id, OzelKodTuru.OzelKod1,
            KartTuru.Okul, entity.OzelKod1Id != ozelKod1Id);

        await _ozelKodRepository.EntityAnyAsync(ozelKod2Id, OzelKodTuru.OzelKod2,
            KartTuru.Okul, entity.OzelKod2Id != ozelKod2Id);
    
    }

    public async Task CheckDeleteAsync(Guid id)
    {
        await _okulRepository.RelationalEntityAnyAsync(
            x => x.FirmaParemetreler.Any(y => y.OkulId == id));
    }
}
