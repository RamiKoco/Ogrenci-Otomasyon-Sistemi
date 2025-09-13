
namespace OOS.OgrenciOtomasyonSistemi.Ogrenciler;
[Authorize(OgrenciOtomasyonSistemiPermissions.Ogrenci.Default)]
public class OgrenciAppService : OgrenciOtomasyonSistemiAppService, IOgrenciAppService
{
    private readonly IOgrenciRepository _ogrenciRepository;
    private readonly OgrenciManager _ogrenciManager;
    public OgrenciAppService(IOgrenciRepository ogrenciRepository, OgrenciManager ogrenciManager)
    {
        _ogrenciRepository = ogrenciRepository;
        _ogrenciManager = ogrenciManager;
    }
    public virtual async Task<SelectOgrenciDto> GetAsync(Guid id)
    {
        var entity = await _ogrenciRepository.GetAsync(id, x => x.Id == id);

        return ObjectMapper.Map<Ogrenci, SelectOgrenciDto>(entity);

    }

    public virtual async Task<PagedResultDto<ListOgrenciDto>> GetListAsync(OgrenciListParameterDto input)
    {
        var entities = await _ogrenciRepository.GetPagedListAsync(input.SkipCount,
            input.MaxResultCount,
             x => x.Durum == input.Durum,
             x => x.Kod);

        var totalCount = await _ogrenciRepository.CountAsync(x => x.Durum == input.Durum);

        return new PagedResultDto<ListOgrenciDto>(totalCount,
            ObjectMapper.Map<List<Ogrenci>, List<ListOgrenciDto>>(entities)
            );
    }
    [Authorize(OgrenciOtomasyonSistemiPermissions.Ogrenci.Create)]
    public virtual async Task<SelectOgrenciDto> CreateAsync(CreateOgrenciDto input)
    {
        await _ogrenciManager.CheckCreateAsync(input.Kod);

        var entity = ObjectMapper.Map<CreateOgrenciDto, Ogrenci>(input);
        await _ogrenciRepository.InsertAsync(entity);
        return ObjectMapper.Map<Ogrenci, SelectOgrenciDto>(entity);
    }
    [Authorize(OgrenciOtomasyonSistemiPermissions.Ogrenci.Update)]
    public virtual async Task<SelectOgrenciDto> UpdateAsync(Guid id, UpdateOgrenciDto input)
    {
        var entity = await _ogrenciRepository.GetAsync(id, x => x.Id == id);

        await _ogrenciManager.CheckUpdateAsync(id, input.Kod, entity);

        var mappedEntity = ObjectMapper.Map(input, entity);
        await _ogrenciRepository.UpdateAsync(mappedEntity);
        return ObjectMapper.Map<Ogrenci, SelectOgrenciDto>(mappedEntity);
    }
    [Authorize(OgrenciOtomasyonSistemiPermissions.Ogrenci.Delete)]
    public virtual async Task DeleteAsync(Guid id)
    {
        await _ogrenciRepository.DeleteAsync(id);
    }

    public virtual async Task<string> GetCodeAsync(CodeParameterDto input)
    {
        return await _ogrenciRepository.GetCodeAsync(x => x.Kod, x => x.Durum == input.Durum);
    }
}
