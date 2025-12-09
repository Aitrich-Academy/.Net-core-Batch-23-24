using AutoMapper;
using WebApi_Login.DTOs;
using WebApi_Login.Models;

namespace WebApi_Login.Profiles
{
    public class UserProfile:Profile
    {
        public UserProfile()
        {
            CreateMap<UserRegisterDto, User>();
        }
    }
}
