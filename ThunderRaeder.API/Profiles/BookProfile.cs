using AutoMapper;
using ThunderRaeder.API.Dtos;
using ThunderRaeder.Data.Entities;
using ThunderRaeder.Shared.ServerApiContracts.Responses;
using ThunderRaeder.Shared.ServerApiContracts.Responses.Simplified;

namespace ThunderRaeder.API.Profiles
{
    public class BookProfile : Profile
    {
        public BookProfile()
        {
            CreateMap<Book, BookDto>();
        }
    }

    public class BookDtoProfile : Profile
    {
        public BookDtoProfile()
        {
            CreateMap<BookDto, BookResponseSimplified>()
                .ForMember(dest => dest.Genre,
                opt => opt.MapFrom(src => src.Genre.ToString()));

            CreateMap<BookDto, BookResponse>()
                .ForMember(dest => dest.Genre,
                opt => opt.MapFrom(src => src.Genre.ToString()));


            //.ForMember(dest => dest.Author,
            //opt => opt.MapFrom(src => src.Author));

            //.ForMember(dest => dest.AuthorName,
            //opt => opt.MapFrom(src => $"{src.Author.LastName}, {src.Author.FirstName}"));
        }
    }
}
