using AutoMapper;

namespace OOS.OgrenciOtomasyonSistemi;

public class OgrenciOtomasyonSistemiApplicationAutoMapperProfile : Profile
{
    public OgrenciOtomasyonSistemiApplicationAutoMapperProfile()
    {
        //ogrenci
        CreateMap<Ogrenci, SelectOgrenciDto>();

        CreateMap<Ogrenci, ListOgrenciDto>();

        CreateMap<CreateOgrenciDto, Ogrenci>();
        CreateMap<UpdateOgrenciDto, Ogrenci>();
        CreateMap<SelectOgrenciDto, CreateOgrenciDto>();
        CreateMap<SelectOgrenciDto, UpdateOgrenciDto>();

    }
}
