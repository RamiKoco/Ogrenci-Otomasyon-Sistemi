
namespace OOS.OgrenciOtomasyonSistemi.Ogrenciler;
public class OgrenciManager : DomainService
{   
    private readonly IOgrenciRepository _ogrenciRepository;
    private readonly IOzelKodRepository _ozelKodRepository;
    public OgrenciManager(IOgrenciRepository ogrenciRepository, IOzelKodRepository ozelKodRepository)
    {
        _ogrenciRepository = ogrenciRepository;
        _ozelKodRepository = ozelKodRepository;
    }
    public async Task CheckCreateAsync(string kod, Guid? ozelKod1Id, Guid? ozelKod2Id)
    {
        await _ogrenciRepository.KodAnyAsync(kod, x => x.Kod == kod);
        await _ozelKodRepository.EntityAnyAsync(ozelKod1Id, OzelKodTuru.OzelKod1,
         KartTuru.Ogrenci);

        await _ozelKodRepository.EntityAnyAsync(ozelKod2Id, OzelKodTuru.OzelKod2,
            KartTuru.Ogrenci);
    }
    public async Task CheckUpdateAsync(Guid id, string kod, Ogrenci entity, Guid? ozelKod1Id, Guid? ozelKod2Id)
    {
        await _ogrenciRepository.KodAnyAsync(kod, x => x.Id != id && x.Kod == kod,
            entity.Kod != kod);
        await _ozelKodRepository.EntityAnyAsync(ozelKod1Id, OzelKodTuru.OzelKod1,
         KartTuru.Ogrenci, entity.OzelKod1Id != ozelKod1Id);

        await _ozelKodRepository.EntityAnyAsync(ozelKod2Id, OzelKodTuru.OzelKod2,
            KartTuru.Ogrenci, entity.OzelKod2Id != ozelKod2Id);

    }
}
