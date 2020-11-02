using AutoMapper;
using ThunderRaeder.API.Dtos;
using ThunderRaeder.Data.Entities;
using ThunderRaeder.Shared.ServerApiContracts.Responses.Simplified;

namespace ThunderRaeder.API.Profiles
{
    public class UserBookProfile : Profile
    {
        public UserBookProfile()
        {
            CreateMap<AppUserBook, UserBookDto>()
                .ForMember(dest => dest.Title,
                opt => opt.MapFrom(src => src.Book.Title));
        }
    }

    public class UserBookDtoProfile : Profile
    {
        public UserBookDtoProfile()
        {
            CreateMap<UserBookDto, UserBookResponseSimplified>()
                .ForMember(dest => dest.Id,
                opt => opt.MapFrom(src => src.BookId.ToString()));
        }
    }
}
