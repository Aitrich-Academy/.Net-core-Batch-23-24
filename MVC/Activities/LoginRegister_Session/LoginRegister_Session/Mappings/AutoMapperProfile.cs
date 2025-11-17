using AutoMapper;
using LoginRegister_Session.DTOs;
using LoginRegister_Session.Models;

namespace LoginRegister_Session.Mappings
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<UserDTO, User>();
        }
    }
}
