using AutoMapper;
using StudentManagementAPI.DomainModels;
using DataModels=StudentManagementAPI.DataModels;

namespace StudentManagementAPI.Profiles
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<DataModels.Studentt, Studentt>().ReverseMap();
            CreateMap<DataModels.Gender, Gender>().ReverseMap();
            CreateMap<DataModels.Address, Address>().ReverseMap();
        }
    }
}
