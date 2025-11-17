using AutoMapper;
using Login_Register.Models;

namespace Login_Register.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserDto, User>();
        }
    }
}
