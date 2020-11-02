using AutoMapper;
using Microsoft.Graph;
using ThunderRaeder.API.Dtos;
using ThunderRaeder.Data.Entities;
using ThunderRaeder.Shared.ServerApiContracts.Responses;

namespace ThunderRaeder.API.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<AppUser, UserDto>();
        }
    }

    public class UserDtoProfile : Profile
    {
        public UserDtoProfile()
        {
            CreateMap<UserDto, UserResponse>()
                .ForMember(dest => dest.UserType,
                opt => opt.MapFrom(src => src.UserType.ToString()))
                .ForMember(dest => dest.Books,
                opt => opt.MapFrom(src => src.AppUserBooks));
        }
    }

    public class AzureUserProfile : Profile
    {
        public AzureUserProfile()
        {
            CreateMap<User, AzureAdUserResponse>();
        }
    }
}
