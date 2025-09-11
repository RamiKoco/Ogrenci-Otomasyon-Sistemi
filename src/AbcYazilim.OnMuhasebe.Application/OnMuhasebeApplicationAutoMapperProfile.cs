
namespace AbcYazilim.OnMuhasebe
{
    public class OnMuhasebeApplicationAutoMapperProfile : Profile
    {
        public OnMuhasebeApplicationAutoMapperProfile()
        {
          
            //donem
            CreateMap<Donem, SelectDonemDto>();
            CreateMap<Donem, ListDonemDto>();
            CreateMap<CreateDonemDto, Donem>();
            CreateMap<UpdateDonemDto, Donem>();
            CreateMap<SelectDonemDto, CreateDonemDto>();
            CreateMap<SelectDonemDto, UpdateDonemDto>();

         

            //Image
            CreateMap<Image, SelectImageDto>();
            CreateMap<Image, ListImageDto>();

            CreateMap<CreateImageDto, Image>();
            CreateMap<UpdateImageDto, Image>();
            CreateMap<SelectImageDto, CreateImageDto>();
            CreateMap<SelectImageDto, UpdateImageDto>();

           
            //ogrenci
            CreateMap<Ogrenci, SelectOgrenciDto>();

            CreateMap<Ogrenci, ListOgrenciDto>();

            CreateMap<CreateOgrenciDto, Ogrenci>();
            CreateMap<UpdateOgrenciDto, Ogrenci>();
            CreateMap<SelectOgrenciDto, CreateOgrenciDto>();
            CreateMap<SelectOgrenciDto, UpdateOgrenciDto>();

          
            //Firma Parametre
            CreateMap<FirmaParametre, SelectFirmaParametreDto>()
                .ForMember(x => x.SubeAdi, y => y.MapFrom(z => z.Sube.Ad))
                .ForMember(x => x.DonemAdi, y => y.MapFrom(z => z.Donem.Ad));

            CreateMap<CreateFirmaParametreDto, FirmaParametre>();
            CreateMap<UpdateFirmaParametreDto, FirmaParametre>();

            //sube
            CreateMap<Sube, SelectSubeDto>();
            CreateMap<Sube, ListSubeDto>();
            CreateMap<CreateSubeDto, Sube>();
            CreateMap<UpdateSubeDto, Sube>();
            CreateMap<SelectSubeDto, CreateSubeDto>();
            CreateMap<SelectSubeDto, UpdateSubeDto>();
          
        }
    }
}