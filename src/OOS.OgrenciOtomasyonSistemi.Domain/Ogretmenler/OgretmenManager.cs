
namespace OOS.OgrenciOtomasyonSistemi.Ogretmenler;
public class OgretmenManager : DomainService
{
    private readonly IOgretmenRepository _ogretmenRepository;
    private readonly IOzelKodRepository _ozelKodRepository;
    public OgretmenManager(IOgretmenRepository ogretmenRepository, IOzelKodRepository ozelKodRepository)
    {
        _ogretmenRepository = ogretmenRepository;
        _ozelKodRepository = ozelKodRepository;
    }
    public async Task CheckCreateAsync(string kod, Guid? ozelKod1Id, Guid? ozelKod2Id)
    {
        await _ogretmenRepository.KodAnyAsync(kod, x => x.Kod == kod);
        await _ozelKodRepository.EntityAnyAsync(ozelKod1Id, OzelKodTuru.OzelKod1,
         KartTuru.Ogretmen);

        await _ozelKodRepository.EntityAnyAsync(ozelKod2Id, OzelKodTuru.OzelKod2,
            KartTuru.Ogretmen);
    }
    public async Task CheckUpdateAsync(Guid id, string kod, Ogretmen entity, Guid? ozelKod1Id, Guid? ozelKod2Id)
    {
        await _ogretmenRepository.KodAnyAsync(kod, x => x.Id != id && x.Kod == kod,
            entity.Kod != kod);
        await _ozelKodRepository.EntityAnyAsync(ozelKod1Id, OzelKodTuru.OzelKod1,
         KartTuru.Ogretmen, entity.OzelKod1Id != ozelKod1Id);

        await _ozelKodRepository.EntityAnyAsync(ozelKod2Id, OzelKodTuru.OzelKod2,
            KartTuru.Ogretmen, entity.OzelKod2Id != ozelKod2Id);

    }
}
