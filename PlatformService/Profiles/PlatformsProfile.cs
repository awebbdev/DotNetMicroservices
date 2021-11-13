using AutoMapper;

namespace PlatformService.Profiles
{
    public class PlatformsProfile : Profile
    {
        public PlatformsProfile()
        {
            //Source -> Target
            CreateMap<PlatformService.Models.Platform, PlatformService.Dtos.PlatformReadDto>();
            //Target -> Source
            CreateMap<PlatformService.Dtos.PlatformCreateDto, PlatformService.Models.Platform>();            
        }
    }
}