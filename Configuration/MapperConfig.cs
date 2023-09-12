using AutoMapper;
using UdemyProj1.Models;
using UdemyProj1.ViewModels;

namespace UdemyProj1.Configuration
{
    public class MapperConfig : Profile
    {
        public MapperConfig() 
        {
            CreateMap<LeaveType, LeaveTypeVM>().ReverseMap();
        }

    }
}
