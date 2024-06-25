﻿using AutoMapper;
using Domain.Entities;
using Service.DTOs.Admin.Countries;

namespace Service.Helpers
{
    internal class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CountryCreateDto, Country>();
            CreateMap<Country, CountryDto>();
        }
    }
}
