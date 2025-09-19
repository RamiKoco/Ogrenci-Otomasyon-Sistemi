
using OOS.OgrenciOtomasyonSistemi.Donemler;
using OOS.OgrenciOtomasyonSistemi.Ogretmenler;
using OOS.OgrenciOtomasyonSistemi.Okullar;
using OOS.OgrenciOtomasyonSistemi.Parametreler;

namespace OOS.OgrenciOtomasyonSistemi;
public class OgrenciOtomasyonSistemiApplicationAutoMapperProfile : Profile
{
    public OgrenciOtomasyonSistemiApplicationAutoMapperProfile()
    {
        //donem
        CreateMap<Donem, SelectDonemDto>();
        CreateMap<Donem, ListDonemDto>();
        CreateMap<CreateDonemDto, Donem>();
        CreateMap<UpdateDonemDto, Donem>();
        CreateMap<SelectDonemDto, CreateDonemDto>();
        CreateMap<SelectDonemDto, UpdateDonemDto>();

        //Firma Parametre
        CreateMap<FirmaParametre, SelectFirmaParametreDto>()
            .ForMember(x => x.OkulAdi, y => y.MapFrom(z => z.Okul.Ad))
            .ForMember(x => x.DonemAdi, y => y.MapFrom(z => z.Donem.Ad));

        CreateMap<CreateFirmaParametreDto, FirmaParametre>();
        CreateMap<UpdateFirmaParametreDto, FirmaParametre>();

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

        //ogretmen
        CreateMap<Ogretmen, SelectOgretmenDto>()
             .ForMember(x => x.OzelKod1Adi, y => y.MapFrom(z => z.OzelKod1.Ad))
             .ForMember(x => x.OzelKod2Adi, y => y.MapFrom(z => z.OzelKod2.Ad));

        CreateMap<Ogretmen, ListOgretmenDto>()
             .ForMember(x => x.OzelKod1Adi, y => y.MapFrom(z => z.OzelKod1.Ad))
             .ForMember(x => x.OzelKod2Adi, y => y.MapFrom(z => z.OzelKod2.Ad));

        CreateMap<CreateOgretmenDto, Ogretmen>();
        CreateMap<UpdateOgretmenDto, Ogretmen>();
        CreateMap<SelectOgretmenDto, CreateOgretmenDto>();
        CreateMap<SelectOgretmenDto, UpdateOgretmenDto>();

        //okul
        CreateMap<Okul, SelectOkulDto>()
             .ForMember(x => x.OzelKod1Adi, y => y.MapFrom(z => z.OzelKod1.Ad))
             .ForMember(x => x.OzelKod2Adi, y => y.MapFrom(z => z.OzelKod2.Ad));

        CreateMap<Okul, ListOkulDto>()
             .ForMember(x => x.OzelKod1Adi, y => y.MapFrom(z => z.OzelKod1.Ad))
             .ForMember(x => x.OzelKod2Adi, y => y.MapFrom(z => z.OzelKod2.Ad));

        CreateMap<CreateOkulDto, Okul>();
        CreateMap<UpdateOkulDto, Okul>();
        CreateMap<SelectOkulDto, CreateOkulDto>();
        CreateMap<SelectOkulDto, UpdateOkulDto>();

        //OzelKod
        CreateMap<OzelKod, SelectOzelKodDto>();
        CreateMap<OzelKod, ListOzelKodDto>();
        CreateMap<CreateOzelKodDto, OzelKod>();
        CreateMap<UpdateOzelKodDto, OzelKod>();
        CreateMap<SelectOzelKodDto, CreateOzelKodDto>();
        CreateMap<SelectOzelKodDto, UpdateOzelKodDto>();


    }
}
