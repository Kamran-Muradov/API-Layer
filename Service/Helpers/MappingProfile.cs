using AutoMapper;
using Domain.Entities;
using Service.DTOs.Admin.Countries;

namespace Service.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Country, CountryDto>();
            CreateMap<Country, CountryDetailDto>();
            CreateMap<CountryCreateDto, Country>();
            CreateMap<CountryEditDto, Country>();
        }
    }
}
