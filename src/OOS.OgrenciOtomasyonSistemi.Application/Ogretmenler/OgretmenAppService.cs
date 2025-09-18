
namespace OOS.OgrenciOtomasyonSistemi.Ogretmenler;
[Authorize(OgrenciOtomasyonSistemiPermissions.Ogretmen.Default)]
public class OgretmenAppService : OgrenciOtomasyonSistemiAppService, IOgretmenAppService
{
    private readonly IOgretmenRepository _ogretmenRepository;
    private readonly OgretmenManager _ogretmenManager;
    public OgretmenAppService(IOgretmenRepository ogretmenRepository, OgretmenManager ogretmenManager)
    {
        _ogretmenRepository = ogretmenRepository;
        _ogretmenManager = ogretmenManager;
    }
    public virtual async Task<SelectOgretmenDto> GetAsync(Guid id)
    {
        var entity = await _ogretmenRepository.GetAsync(id, x => x.Id == id, x => x.OzelKod1, x => x.OzelKod2);

        return ObjectMapper.Map<Ogretmen, SelectOgretmenDto>(entity);
    }

    public virtual async Task<PagedResultDto<ListOgretmenDto>> GetListAsync(OgretmenListParameterDto input)
    {
        var entities = await _ogretmenRepository.GetPagedListAsync(input.SkipCount,
            input.MaxResultCount,
             x => x.Durum == input.Durum,
             x => x.Kod,
             x => x.OzelKod1,
             x => x.OzelKod2);

        var totalCount = await _ogretmenRepository.CountAsync(x => x.Durum == input.Durum);

        return new PagedResultDto<ListOgretmenDto>(totalCount,
            ObjectMapper.Map<List<Ogretmen>, List<ListOgretmenDto>>(entities) );
    }

    [Authorize(OgrenciOtomasyonSistemiPermissions.Ogretmen.Create)]
    public virtual async Task<SelectOgretmenDto> CreateAsync(CreateOgretmenDto input)
    {
        await _ogretmenManager.CheckCreateAsync(input.Kod, input.OzelKod1Id,
            input.OzelKod2Id);

        var entity = ObjectMapper.Map<CreateOgretmenDto, Ogretmen>(input);
        await _ogretmenRepository.InsertAsync(entity);
        return ObjectMapper.Map<Ogretmen, SelectOgretmenDto>(entity);
    }

    [Authorize(OgrenciOtomasyonSistemiPermissions.Ogretmen.Update)]
    public virtual async Task<SelectOgretmenDto> UpdateAsync(Guid id, UpdateOgretmenDto input)
    {
        var entity = await _ogretmenRepository.GetAsync(id, x => x.Id == id);

        await _ogretmenManager.CheckUpdateAsync(id, input.Kod, entity, input.OzelKod1Id,
            input.OzelKod2Id);

        var mappedEntity = ObjectMapper.Map(input, entity);
        await _ogretmenRepository.UpdateAsync(mappedEntity);
        return ObjectMapper.Map<Ogretmen, SelectOgretmenDto>(mappedEntity);
    }

    [Authorize(OgrenciOtomasyonSistemiPermissions.Ogretmen.Delete)]
    public virtual async Task DeleteAsync(Guid id)
    {
        await _ogretmenRepository.DeleteAsync(id);
    }
    public virtual async Task<string> GetCodeAsync(CodeParameterDto input)
    {
        return await _ogretmenRepository.GetCodeAsync(x => x.Kod, x => x.Durum == input.Durum);
    }
}
