using AutoMapper;
using HotelAPI.Data;
using HotelAPI.Model.Country;

namespace HotelAPI.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<Country , CreateCountryModel>().ReverseMap();
            CreateMap<Country, GetCountryModel>().ReverseMap();
            CreateMap<Country, UpdateCountryModel>().ReverseMap();

        }
    }
}
