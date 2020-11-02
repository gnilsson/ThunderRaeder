using AutoMapper;
using ThunderRaeder.API.Dtos;
using ThunderRaeder.Data.Entities;
using ThunderRaeder.Shared.ServerApiContracts.Responses;
using ThunderRaeder.Shared.ServerApiContracts.Responses.Simplified;

namespace ThunderRaeder.API.Profiles
{
    public class AuthorProfile : Profile
    {
        public AuthorProfile()
        {
            CreateMap<Author, AuthorDto>();
        }

    }

    public class AuthorDtoProfile : Profile
    {
        public AuthorDtoProfile()
        {
            CreateMap<AuthorDto, AuthorResponseSimplified>()
                .ForMember(dest => dest.Gender,
                opt => opt.MapFrom(src => src.Gender.ToString()));
                //.ForMember(dest => dest.FullName,
                //opt => opt.MapFrom(src => $"{src.LastName}, {src.FirstName}"));

            CreateMap<AuthorDto, AuthorResponse>()
                .ForMember(dest => dest.Gender,
                opt => opt.MapFrom(src => src.Gender.ToString()));
        }
    }
}

