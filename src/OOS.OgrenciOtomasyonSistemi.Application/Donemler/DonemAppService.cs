﻿
namespace OOS.OgrenciOtomasyonSistemi.Donemler;

[Authorize(OgrenciOtomasyonSistemiPermissions.Donem.Default)]
public class DonemAppService : OgrenciOtomasyonSistemiAppService, IDonemAppService
{
    private readonly IDonemRepository _donemRepository;
    private readonly DonemManager _donemManager;

    public DonemAppService(IDonemRepository donemRepository, DonemManager donemManager)
    {
        _donemRepository = donemRepository;
        _donemManager = donemManager;
    }

    public virtual async Task<SelectDonemDto> GetAsync(Guid id)
    {
        var entity = await _donemRepository.GetAsync(id, x => x.Id == id);
        return ObjectMapper.Map<Donem, SelectDonemDto>(entity);
    }

    public virtual async Task<PagedResultDto<ListDonemDto>> GetListAsync(
        DonemListParameterDto input)
    {
        var entities = await _donemRepository.GetPagedListAsync(input.SkipCount,
            input.MaxResultCount,
            x => x.Durum == input.Durum,
            x => x.Kod);

        var totalCount = await _donemRepository.CountAsync(x => x.Durum == input.Durum);

        return new PagedResultDto<ListDonemDto>(
            totalCount,
            ObjectMapper.Map<List<Donem>, List<ListDonemDto>>(entities)
            );
    }

    [Authorize(OgrenciOtomasyonSistemiPermissions.Donem.Create)]
    public virtual async Task<SelectDonemDto> CreateAsync(CreateDonemDto input)
    {
        await _donemManager.CheckCreateAsync(input.Kod);

        var entity = ObjectMapper.Map<CreateDonemDto, Donem>(input);
        await _donemRepository.InsertAsync(entity);
        return ObjectMapper.Map<Donem, SelectDonemDto>(entity);
    }

    [Authorize(OgrenciOtomasyonSistemiPermissions.Donem.Update)]
    public virtual async Task<SelectDonemDto> UpdateAsync(Guid id, UpdateDonemDto input)
    {
        var entity = await _donemRepository.GetAsync(id, x => x.Id == id);
        await _donemManager.CheckUpdateAsync(id, input.Kod, entity);

        var mappedEntity = ObjectMapper.Map(input, entity);
        await _donemRepository.UpdateAsync(mappedEntity);
        return ObjectMapper.Map<Donem, SelectDonemDto>(mappedEntity);
    }

    [Authorize(OgrenciOtomasyonSistemiPermissions.Donem.Delete)]
    public virtual async Task DeleteAsync(Guid id)
    {
      
        await _donemRepository.DeleteAsync(id);
    }

    public virtual async Task<string> GetCodeAsync(CodeParameterDto input)
    {
        return await _donemRepository.GetCodeAsync(x => x.Kod, x => x.Durum == input.Durum);
    }
}