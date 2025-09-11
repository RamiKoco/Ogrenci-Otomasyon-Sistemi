
namespace AbcYazilim.OnMuhasebe.Images;
[Authorize(OnMuhasebePermissions.Image.Default)]
public class ImageAppService : OnMuhasebeAppService, IImageAppService
{
    private readonly IImageRepository _imageRepository;
    private readonly ImageManager _imageManager;
    public ImageAppService(IImageRepository imageRepository, ImageManager imageManager)
    {
        _imageRepository = imageRepository;
        _imageManager = imageManager;  
    }

    public virtual async Task<SelectImageDto> GetAsync(Guid id)
    {
        var entity = await _imageRepository.GetAsync(id, x => x.Id == id);

        return ObjectMapper.Map<Image, SelectImageDto>(entity);
    }

    public virtual async Task<PagedResultDto<ListImageDto>> GetListAsync(ImageListParameterDto input)
    {
        var entities = await _imageRepository.GetPagedListAsync(input.SkipCount,
            input.MaxResultCount,
            x => x.Durum == input.Durum,
            x => x.Kod);

        var totalCount = await _imageRepository.CountAsync(x => x.Durum == input.Durum);

        return new PagedResultDto<ListImageDto>(
            totalCount,
            ObjectMapper.Map<List<Image>, List<ListImageDto>>(entities)
            );
    }
    [Authorize(OnMuhasebePermissions.Image.Create)]
    public virtual async Task<SelectImageDto> CreateAsync(CreateImageDto input)
    {
        await _imageManager.CheckCreateAsync(input.Kod);

        var entity = ObjectMapper.Map<CreateImageDto, Image>(input);
        await _imageRepository.InsertAsync(entity);
        return ObjectMapper.Map<Image, SelectImageDto>(entity);
    }
    [Authorize(OnMuhasebePermissions.Image.Update)]
    public virtual async Task<SelectImageDto> UpdateAsync(Guid id, UpdateImageDto input)
    {
        var entity = await _imageRepository.GetAsync(id, x => x.Id == id);

        await _imageManager.CheckUpdateAsync(id, input.Kod, entity);

        var mappedEntity = ObjectMapper.Map(input, entity);
        await _imageRepository.UpdateAsync(mappedEntity);
        return ObjectMapper.Map<Image, SelectImageDto>(mappedEntity);
    }
    [Authorize(OnMuhasebePermissions.Image.Delete)]
    public virtual async Task DeleteAsync(Guid id)
    {
        await _imageRepository.DeleteAsync(id);
    }

    public virtual async Task<string> GetCodeAsync(CodeParameterDto input)
    {
        return await _imageRepository.GetCodeAsync(x => x.Kod, x => x.Durum == input.Durum);
    }

}
