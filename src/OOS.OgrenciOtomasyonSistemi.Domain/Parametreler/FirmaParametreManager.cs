
namespace OOS.OgrenciOtomasyonSistemi.Parametreler;
public class FirmaParametreManager : DomainService
{
    private readonly IOkulRepository _okulRepository;
    private readonly IDonemRepository _donemRepository;

    public FirmaParametreManager(IOkulRepository okulRepository, IDonemRepository donemRepository)
    {
        _okulRepository = okulRepository;        
        _donemRepository = donemRepository;
    }

    public async Task CheckCreateAsync(Guid? okulId, Guid? donemId)
    {
        await _okulRepository.EntityAnyAsync(okulId, x => x.Id == okulId);
        await _donemRepository.EntityAnyAsync(donemId, x => x.Id == donemId);
    }

    public async Task CheckUpdateAsync(Guid? okulId, Guid? donemId)
    {
        await _okulRepository.EntityAnyAsync(okulId, x => x.Id == okulId);
        await _donemRepository.EntityAnyAsync(donemId, x => x.Id == donemId);
    }
}