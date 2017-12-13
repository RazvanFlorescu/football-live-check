using AutoMapper;
using FootballLiveCheck.Business.User.Models;

namespace FootballLiveCheck.Business.MappingProfiles
{
    public class UserMappingProfile : Profile
    {
        public UserMappingProfile()
        {
            CreateMap<Domain.Entities.User, UserModel>().ReverseMap();
        }        
    }
}