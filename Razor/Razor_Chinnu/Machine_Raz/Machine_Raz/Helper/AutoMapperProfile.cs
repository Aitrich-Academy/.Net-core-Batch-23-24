using AutoMapper;
using Machine_Raz.Dto;
using Machine_Raz.Model;

namespace Machine_Raz.Helper
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Job, JobDto>().ReverseMap();
        }
    }
}
