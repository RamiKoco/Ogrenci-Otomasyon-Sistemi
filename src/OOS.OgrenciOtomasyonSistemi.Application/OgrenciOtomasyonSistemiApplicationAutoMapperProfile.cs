
namespace OOS.OgrenciOtomasyonSistemi;
public class OgrenciOtomasyonSistemiApplicationAutoMapperProfile : Profile
{
    public OgrenciOtomasyonSistemiApplicationAutoMapperProfile()
    {
        //ogrenci
        CreateMap<Ogrenci, SelectOgrenciDto>()
             .ForMember(x => x.OzelKod1Adi, y => y.MapFrom(z => z.OzelKod1.Ad))
             .ForMember(x => x.OzelKod2Adi, y => y.MapFrom(z => z.OzelKod2.Ad));

        CreateMap<Ogrenci, ListOgrenciDto>()
             .ForMember(x => x.OzelKod1Adi, y => y.MapFrom(z => z.OzelKod1.Ad))
             .ForMember(x => x.OzelKod2Adi, y => y.MapFrom(z => z.OzelKod2.Ad));

        CreateMap<CreateOgrenciDto, Ogrenci>();
        CreateMap<UpdateOgrenciDto, Ogrenci>();
        CreateMap<SelectOgrenciDto, CreateOgrenciDto>();
        CreateMap<SelectOgrenciDto, UpdateOgrenciDto>();

        //OzelKod
        CreateMap<OzelKod, SelectOzelKodDto>();
        CreateMap<OzelKod, ListOzelKodDto>();
        CreateMap<CreateOzelKodDto, OzelKod>();
        CreateMap<UpdateOzelKodDto, OzelKod>();
        CreateMap<SelectOzelKodDto, CreateOzelKodDto>();
        CreateMap<SelectOzelKodDto, UpdateOzelKodDto>();


    }
}
