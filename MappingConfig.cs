using AutoMapper;
using Microservices.TaskManagement.Models.Dto;

namespace Microservices.TaskManagement
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<TaskManagementDto, Task>();
                config.CreateMap<Task, TaskManagementDto>();
            });
            return mappingConfig;
        }
    }
}
