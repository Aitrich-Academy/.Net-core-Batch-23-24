using AutoMapper;
using Exercise_Razor.DTOs;
using Exercise_Razor.Models;

namespace Exercise_Razor.Helper
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {

            CreateMap<Job, JobDto>().ReverseMap();
            CreateMap<RegisterDto, User>();
        }
     
    }
}
