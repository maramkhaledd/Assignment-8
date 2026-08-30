using AutoMapper;
using Assignment7.DTO;
using Assignment_3.Models;

namespace Assignment7.Mapping
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Tasks, TaskItemDto>()
                .ForMember(
                    dest => dest.CreatedAt,
                    opt => opt.MapFrom(src => DateTime.UtcNow)
                );

            CreateMap<UpdateTaskRequest, Tasks>();


       


        }

    }
}
