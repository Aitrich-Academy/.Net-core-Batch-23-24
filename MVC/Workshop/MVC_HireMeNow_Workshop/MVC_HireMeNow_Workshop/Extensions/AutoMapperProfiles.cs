using AutoMapper;
using MVC_HireMeNow_Workshop.Models.DTOs;
using MVC_HireMeNow_Workshop.Models.Entities;

namespace MVC_HireMeNow_Workshop.Extensions
{
    public class AutoMapperProfiles:Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<UserDTO, User>().ReverseMap();
           
            
            CreateMap<CompanyDTO, Company>().ReverseMap();
            CreateMap<JobDTO, Job>().ReverseMap();
            CreateMap<CompanyMemberDTO, User>().ReverseMap();
        }
    }
}
