namespace AbcYazilim.OnMuhasebe.Images;
public class ImageManager : DomainService
{
    private readonly IImageRepository _imageRepository;
    public ImageManager(IImageRepository imageRepository)
    {
        _imageRepository = imageRepository;
    }
    public async Task CheckCreateAsync(string kod)
    {
        await _imageRepository.KodAnyAsync(kod, x => x.Kod == kod);
    }
    public async Task CheckUpdateAsync(Guid id, string kod, Image entity)
    {
        await _imageRepository.KodAnyAsync(kod, x => x.Id != id && x.Kod == kod,
            entity.Kod != kod);

    }
}
