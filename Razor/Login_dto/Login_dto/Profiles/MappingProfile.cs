using AutoMapper;
using Login_dto.DTOs;
using Login_dto.Models;

namespace Login_dto.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // map RegisterDto to User 
            CreateMap<RegisterDto, User>();
        }
    }
}
