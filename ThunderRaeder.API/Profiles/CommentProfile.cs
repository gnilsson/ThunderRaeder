using AutoMapper;
using ThunderRaeder.API.Dtos;
using ThunderRaeder.Data.Entities;
using ThunderRaeder.Shared.ServerApiContracts.Responses;

namespace ThunderRaeder.API.Profiles
{
    public class CommentProfile : Profile
    {
        public CommentProfile()
        {
            CreateMap<Comment, CommentDto>();
        }
    }

    public class CommentDtoProfile : Profile
    {
        public CommentDtoProfile()
        {
            CreateMap<CommentDto, CommentResponse>();
        }
    }
}
