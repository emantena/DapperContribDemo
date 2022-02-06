using AutoMapper;

namespace DapperContribDemo.Api.Mapper
{
    public static class AutoMapperConfig
    {
        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new DomainToResponseMappingProfile());
                cfg.AddProfile(new RequestToDomainMappingProfile());
            });
        }
    }
}
