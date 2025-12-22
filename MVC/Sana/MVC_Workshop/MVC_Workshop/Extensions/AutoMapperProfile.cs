using AutoMapper;
using MVC_Workshop.Models.DTOs;
using MVC_Workshop.Models.Entities;

namespace MVC_Workshop.Extensions
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<JobDTO, Job>().ReverseMap();
        }
    }
}
