using AutoMapper;
using HotelAPI.Data;
using HotelAPI.Model.Country;
using HotelAPI.Model.Hotel;

namespace HotelAPI.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<Country , CreateCountryModel>().ReverseMap();
            CreateMap<Country, GetCountryModel>().ReverseMap();
            CreateMap<Country, UpdateCountryModel>().ReverseMap();

            CreateMap<Hotel, HotelModel>().ReverseMap();
            CreateMap<Hotel, createHotelModel>().ReverseMap();
        }
    }
}
