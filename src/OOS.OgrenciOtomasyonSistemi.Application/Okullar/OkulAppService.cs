
namespace OOS.OgrenciOtomasyonSistemi.Okullar;
[Authorize(OgrenciOtomasyonSistemiPermissions.Okul.Default)]
public class OkulAppService : OgrenciOtomasyonSistemiAppService, IOkulAppService
{
    private readonly IOkulRepository _okulRepository;
    private readonly OkulManager _okulManager;
    public OkulAppService(IOkulRepository okulRepository, OkulManager okulManager)
    {
        _okulRepository = okulRepository;
        _okulManager = okulManager;
    }
    public virtual async Task<SelectOkulDto> GetAsync(Guid id)
    {
        var entity = await _okulRepository.GetAsync(id, x => x.Id == id, x => x.OzelKod1, x => x.OzelKod2);

        return ObjectMapper.Map<Okul, SelectOkulDto>(entity);

    }
    public virtual async Task<PagedResultDto<ListOkulDto>> GetListAsync(OkulListParameterDto input)
    {
        var entities = await _okulRepository.GetPagedListAsync(input.SkipCount,
            input.MaxResultCount,
             x => x.Durum == input.Durum,
             x => x.Kod,
             x => x.OzelKod1,
             x => x.OzelKod2);

        var totalCount = await _okulRepository.CountAsync(x => x.Durum == input.Durum);

        return new PagedResultDto<ListOkulDto>(totalCount,
            ObjectMapper.Map<List<Okul>, List<ListOkulDto>>(entities)
            );
    }

    [Authorize(OgrenciOtomasyonSistemiPermissions.Okul.Create)]
    public virtual async Task<SelectOkulDto> CreateAsync(CreateOkulDto input)
    {
        await _okulManager.CheckCreateAsync(input.Kod, input.OzelKod1Id,
            input.OzelKod2Id);

        var entity = ObjectMapper.Map<CreateOkulDto, Okul>(input);
        await _okulRepository.InsertAsync(entity);
        return ObjectMapper.Map<Okul, SelectOkulDto>(entity);
    }

    [Authorize(OgrenciOtomasyonSistemiPermissions.Okul.Update)]
    public virtual async Task<SelectOkulDto> UpdateAsync(Guid id, UpdateOkulDto input)
    {
        var entity = await _okulRepository.GetAsync(id, x => x.Id == id);

        await _okulManager.CheckUpdateAsync(id, input.Kod, entity, input.OzelKod1Id,
            input.OzelKod2Id);

        var mappedEntity = ObjectMapper.Map(input, entity);
        await _okulRepository.UpdateAsync(mappedEntity);
        return ObjectMapper.Map<Okul, SelectOkulDto>(mappedEntity);
    }

    [Authorize(OgrenciOtomasyonSistemiPermissions.Okul.Delete)]
    public virtual async Task DeleteAsync(Guid id)
    {
        await _okulManager.CheckDeleteAsync(id);
        await _okulRepository.DeleteAsync(id);
    }
    public virtual async Task<string> GetCodeAsync(CodeParameterDto input)
    {
        return await _okulRepository.GetCodeAsync(x => x.Kod, x => x.Durum == input.Durum);
    }
}
