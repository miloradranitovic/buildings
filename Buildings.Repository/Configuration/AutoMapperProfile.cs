using AutoMapper;
using Buildings.Domain.Data;
using Buildings.Domain.Data.Models;
using Buildings.Model.Dto;

namespace Buildings.Domain.Configuration
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<BuildingDto, Building>();
            CreateMap<AccountDto, Account>();
        }
    }
}
