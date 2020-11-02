using AutoMapper;
using ThunderRaeder.API.Dtos;
using ThunderRaeder.Data.Entities;
using ThunderRaeder.Shared.ServerApiContracts.Responses;

namespace ThunderRaeder.API.Profiles
{
    public class AnnouncementProfile : Profile
    {
        public AnnouncementProfile()
        {
            CreateMap<Announcement, AnnouncementDto>();
        }

    }
    public class AnnouncementDtoProfile : Profile
    {
        public AnnouncementDtoProfile()
        {
            CreateMap<AnnouncementDto, AnnouncementResponse>();
        }
    }
}
